// This file is part of WindowsSharp
//
// Copyright (C) 2021-2023 Ronald van Manen <rvanmanen@gmail.com>
//
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using WindowsSharp.Interop;

namespace D3D9Sharp.Extensions.Windows.Interop
{
    internal sealed unsafe class SurfaceQueueDeviceD3D11 : IDisposable
    {
        private readonly ID3D11Device* _pDevice;

        public SurfaceQueueDeviceD3D11(ID3D11Device* pDevice)
        {
            if (pDevice == null)
            {
                throw new ArgumentNullException(nameof(pDevice));
            }
            pDevice->AddRef();
            _pDevice = pDevice;
        }

        ~SurfaceQueueDeviceD3D11()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Dispose(true);
        }

        private void Dispose(bool _)
        {
            _pDevice->Release();
        }

        HRESULT CSurfaceQueueDeviceD3D11::CreateSharedSurface(
            UINT Width, UINT Height,
            DXGI_FORMAT format,
            IUnknown** ppUnknown,
            HANDLE* pHandle)
        {
            ASSERT(_pDevice);
            ASSERT(ppUnknown);
            ASSERT(pHandle);

            if (NULL == _pDevice || NULL == ppUnknown || NULL == pHandle)
            {
                return E_FAIL;
            }

            HRESULT hr;

            ID3D11Texture2D** ppTexture = (ID3D11Texture2D**)ppUnknown;

            D3D11_TEXTURE2D_DESC Desc;
            Desc.Width = Width;
            Desc.Height = Height;
            Desc.MipLevels = 1;
            Desc.ArraySize = 1;
            Desc.Format = format;
            Desc.SampleDesc.Count = 1;
            Desc.SampleDesc.Quality = 0;
            Desc.Usage = D3D11_USAGE_DEFAULT;
            Desc.BindFlags = D3D11_BIND_RENDER_TARGET | D3D11_BIND_SHADER_RESOURCE;
            Desc.CPUAccessFlags = 0;
            Desc.MiscFlags = D3D11_RESOURCE_MISC_SHARED;

            hr = _pDevice->CreateTexture2D(&Desc, NULL, ppTexture);

            if (SUCCEEDED(hr))
            {
                if (FAILED(GetSharedHandle(*ppUnknown, pHandle)))
                {
                    (*ppTexture)->Release();
                    (*ppTexture) = NULL;
                }
            }

            return hr;
        }

        HRESULT CSurfaceQueueDeviceD3D11::OpenSurface(
            HANDLE hSharedHandle,
            void** ppSurface,
            UINT,
            UINT,
            DXGI_FORMAT)
        {
            return _pDevice->OpenSharedResource(hSharedHandle, __uuidof(ID3D11Texture2D), ppSurface);
        }

        HRESULT CSurfaceQueueDeviceD3D11::GetSharedHandle(IUnknown* pUnknown, HANDLE* pHandle)
        {
            ASSERT(pUnknown);
            ASSERT(pHandle);

            if (NULL == pUnknown || NULL == pHandle)
            {
                return E_FAIL;
            }

            HRESULT hr = S_OK;

            *pHandle = NULL;
            IDXGIResource* pSurface;

            if (FAILED(hr = pUnknown->QueryInterface(__uuidof(IDXGIResource), (void**)&pSurface)))
            {
                return hr;
            }

            hr = pSurface->GetSharedHandle(pHandle);
            pSurface->Release();

            return hr;
        }

        HRESULT CSurfaceQueueDeviceD3D11::CreateCopyResource(DXGI_FORMAT format, UINT width, UINT height, IUnknown** ppRes)
        {
            ASSERT(ppRes);
            ASSERT(_pDevice);

            if (NULL == ppRes || NULL == _pDevice)
            {
                return E_FAIL;
            }

            D3D11_TEXTURE2D_DESC Desc;
            Desc.Width = width;
            Desc.Height = height;
            Desc.MipLevels = 1;
            Desc.ArraySize = 1;
            Desc.Format = format;
            Desc.SampleDesc.Count = 1;
            Desc.SampleDesc.Quality = 0;
            Desc.Usage = D3D11_USAGE_STAGING;
            Desc.BindFlags = 0;
            Desc.CPUAccessFlags = D3D11_CPU_ACCESS_READ;
            Desc.MiscFlags = 0;

            return _pDevice->CreateTexture2D(&Desc, NULL, reinterpret_cast<ID3D11Texture2D**>(ppRes));
        }

        HRESULT CSurfaceQueueDeviceD3D11::CopySurface(IUnknown* pDst, IUnknown* pSrc, UINT width, UINT height)
        {
            HRESULT hr;

            D3D11_BOX UnitBox = { 0, 0, 0, width, height, 1 };

            ID3D11DeviceContext* pContext = NULL;
            ID3D11Resource* pSrcRes = NULL;
            ID3D11Resource* pDstRes = NULL;

            _pDevice->GetImmediateContext(&pContext);
            ASSERT(pContext);

            if (FAILED(hr = pDst->QueryInterface(__uuidof(ID3D11Resource), (void**)&pDstRes)))
            {
                goto end;
            }

            if (FAILED(hr = pSrc->QueryInterface(__uuidof(ID3D11Resource), (void**)&pSrcRes)))
            {
                goto end;
            }

            pContext->CopySubresourceRegion(
                pDstRes,
                0,
                0, 0, 0, //(x, y, z)
                pSrcRes,
                0,
                &UnitBox);
end:
            if (pSrcRes)
            {
                pSrcRes->Release();
            }
            if (pDstRes)
            {
                pDstRes->Release();
            }
            if (pContext)
            {
                pContext->Release();
            }

            return hr;
        }

        HRESULT CSurfaceQueueDeviceD3D11::LockSurface(IUnknown* pSurface, DWORD flags)
        {
            ASSERT(pSurface);

            if (NULL == pSurface)
            {
                return E_FAIL;
            }

            HRESULT hr = S_OK;
            D3D11_MAPPED_SUBRESOURCE region;

            ID3D11Resource* pResource = NULL;
            ID3D11DeviceContext* pContext = NULL;
            DWORD d3d11flags = 0;

            _pDevice->GetImmediateContext(&pContext);
            ASSERT(pContext);

            if (flags & SURFACE_QUEUE_FLAG_DO_NOT_WAIT)
            {
                d3d11flags |= D3D11_MAP_FLAG_DO_NOT_WAIT;
            }

            if (FAILED(hr = pSurface->QueryInterface(__uuidof(ID3D11Resource), (void**)&pResource)))
            {
                goto end;
            }

            hr = pContext->Map(pResource, 0, D3D11_MAP_READ, d3d11flags, &region);

end:
            if (pResource)
            {
                pResource->Release();
            }
            if (pContext)
            {
                pContext->Release();
            }
            return hr;
        }

        HRESULT CSurfaceQueueDeviceD3D11::UnlockSurface(IUnknown* pSurface)
        {
            ASSERT(pSurface);

            if (NULL == pSurface)
            {
                return E_FAIL;
            }

            HRESULT hr = S_OK;

            ID3D11DeviceContext* pContext = NULL;
            ID3D11Resource* pResource = NULL;

            _pDevice->GetImmediateContext(&pContext);
            ASSERT(pContext);

            if (FAILED(hr = pSurface->QueryInterface(__uuidof(ID3D11Resource), (void**)&pResource)))
            {
                goto end;
            }

            pContext->Unmap(pResource, 0);

end:
            if (pResource)
            {
                pResource->Release();
            }
            if (pContext)
            {
                pContext->Release();
            }
            return hr;
        }

        BOOL CSurfaceQueueDeviceD3D11::ValidateREFIID(REFIID id)
        {
            return (id == __uuidof(ID3D11Texture2D)) ||
                (id == __uuidof(IDXGISurface));
        }

    }
}
