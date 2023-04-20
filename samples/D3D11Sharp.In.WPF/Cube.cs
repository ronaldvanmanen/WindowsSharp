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

using System.Numerics;
using DXGISharp;
using WindowsSharp.Interop;
using static WindowsSharp.Interop.NativeMethods;
using static D3D11Sharp.In.WPF.Helpers;
using WindowsSharp.Internals;

namespace D3D11Sharp.In.WPF
{
    internal sealed unsafe class CCube
    {
        private readonly CCamera m_camera;

        private HINSTANCE m_hInst;
        private D3D_DRIVER_TYPE m_driverType;
        private readonly D3D_FEATURE_LEVEL m_featureLevel;

        private readonly D3D11Device m_pd3dDevice;
        private readonly D3D11DeviceContext m_pImmediateContext;
        private readonly DXGISwapChain m_pSwapChain;
        private readonly D3D11RenderTargetView m_pRenderTargetView;
        private D3D11InputLayout m_pVertexLayout;
        private readonly D3D11Buffer m_pVertexBuffer;
        private readonly D3D11Buffer m_pIndexBuffer;
        private readonly D3D11Buffer m_pConstantBuffer;

        private Matrix4x4 m_World;
        private Matrix4x4 m_View;
        private Matrix4x4 m_Projection;

        private D3D11VertexShader m_pVertexShader;
        private D3D11PixelShader m_pPixelShader;

        // Initial window resolution
        private uint m_Width;
        private uint m_Height;

        public CCube()
        {
            m_camera = null!;

            m_Height = 0;
            m_Width = 0;

            m_hInst = null;
            m_featureLevel = D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0;
            m_pd3dDevice = null!;
            m_pImmediateContext = null!;
            m_pSwapChain = null!;
            m_pRenderTargetView = null!;
            m_pVertexLayout = null!;
            m_pVertexBuffer = null!;
            m_pIndexBuffer = null!;
            m_pConstantBuffer = null!;
            m_pVertexShader = null!;
            m_pPixelShader = null!;
        }

        ~CCube()
        {
            m_pImmediateContext?.ClearState();

            m_pIndexBuffer?.Dispose();
            m_pPixelShader?.Dispose();
            m_pVertexBuffer?.Dispose();
            m_pVertexLayout?.Dispose();
            m_pVertexShader?.Dispose();
            m_pSwapChain?.Dispose();
            m_pImmediateContext?.Dispose();
            m_pd3dDevice?.Dispose();
        }

        public void LoadShaders()
        {
            // Compile the pixel shader
            using var pPSBlob = CompileShaderFromFile("Visualization.fx", "PS", "ps_4_0");

            // Create the pixel shader
            m_pPixelShader = m_pd3dDevice.CreatePixelShader(pPSBlob.GetBuffer());

            // Compile the vertex shader
            using var pVSBlob = CompileShaderFromFile("D3DVisualization.fx", "VS", "vs_4_0");

            // Create the vertex shader
            m_pVertexShader = m_pd3dDevice.CreateVertexShader(pVSBlob.GetBuffer());

            // Define the input layout
            D3D11_INPUT_ELEMENT_DESC[] layout =
            {
                new D3D11_INPUT_ELEMENT_DESC
                {
                    SemanticName = new MarshaledString("POSITION"),
                    SemanticIndex = 0,
                    Format = DXGI_FORMAT.DXGI_FORMAT_R32G32B32_FLOAT,
                    InputSlot = 0,
                    AlignedByteOffset = 0,
                    InputSlotClass = D3D11_INPUT_CLASSIFICATION.D3D11_INPUT_PER_VERTEX_DATA,
                    InstanceDataStepRate = 0
                },
                new D3D11_INPUT_ELEMENT_DESC
                {
                    SemanticName = new MarshaledString("COLOR"),
                    SemanticIndex = 0,
                    Format = DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT,
                    InputSlot = 0,
                    AlignedByteOffset = 12,
                    InputSlotClass = D3D11_INPUT_CLASSIFICATION.D3D11_INPUT_PER_VERTEX_DATA,
                    InstanceDataStepRate = 0
                },
            };

            // Create the input layout
            m_pVertexLayout = m_pd3dDevice.CreateInputLayout(layout, pVSBlob.GetBuffer());

            // Set the input layout
            m_pImmediateContext.IASetInputLayout(m_pVertexLayout);
        }

        public HRESULT InitDevice()
        {
            HRESULT hr = S_OK;

            var createDeviceFlags = D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_BGRA_SUPPORT;

            D3D_DRIVER_TYPE[] driverTypes =
            {
                D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_HARDWARE,
                D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_WARP,
                D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_REFERENCE,
            };
            var numDriverTypes = driverTypes.Length;

            // DX10 or 11 devices are suitable
            D3D_FEATURE_LEVEL[] featureLevels =
            {
                D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_11_0,
                D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_10_1,
                D3D_FEATURE_LEVEL.D3D_FEATURE_LEVEL_10_0,
            };
            var numFeatureLevels = featureLevels.Length;

            for (var driverTypeIndex = 0; driverTypeIndex < numDriverTypes; ++driverTypeIndex)
            {
                hr = D3D11CreateDevice(null, driverTypes[driverTypeIndex], null, createDeviceFlags, featureLevels, numFeatureLevels,
                    D3D11_SDK_VERSION, &m_pd3dDevice, &m_featureLevel, &m_pImmediateContext);

                if (SUCCEEDED(hr))
                {
                    m_driverType = driverTypes[driverTypeIndex];
                    break;
                }
            }

            if (FAILED(hr))
            {
                MessageBox(NULL, L"Could not create a Direct3D 10 or 11 device.", L"Error", MB_ICONHAND | MB_OK);
                return hr;
            }

            LoadShaders();

            // Create vertex buffer
            SimpleVertex[] vertices =
            {
                new SimpleVertex { Pos = new Vector3(-1.0f, 1.0f, -1.0f), Color = new Vector4(0.0f, 0.0f, 1.0f, 0.5f) },
                new SimpleVertex { Pos = new Vector3(1.0f, 1.0f, -1.0f), Color = new Vector4(0.0f, 1.0f, 0.0f, 0.5f) },
                new SimpleVertex { Pos = new Vector3(1.0f, 1.0f, 1.0f), Color = new Vector4(0.0f, 1.0f, 1.0f, 0.5f) },
                new SimpleVertex { Pos = new Vector3(-1.0f, 1.0f, 1.0f), Color = new Vector4(1.0f, 0.0f, 0.0f, 0.5f) },
                new SimpleVertex { Pos = new Vector3(-1.0f, -1.0f, -1.0f), Color = new Vector4(1.0f, 0.0f, 1.0f, 0.5f) },
                new SimpleVertex { Pos = new Vector3(1.0f, -1.0f, -1.0f), Color = new Vector4(1.0f, 1.0f, 0.0f, 0.5f) },
                new SimpleVertex { Pos = new Vector3(1.0f, -1.0f, 1.0f), Color = new Vector4(1.0f, 1.0f, 1.0f, 0.5f) },
                new SimpleVertex { Pos = new Vector3(-1.0f, -1.0f, 1.0f), Color = new Vector4(0.0f, 0.0f, 0.0f, 0.5f) },
            };

            D3D11_BUFFER_DESC bd;
            ZeroMemory(&bd, sizeof(bd));
            bd.Usage = D3D11_USAGE_DEFAULT;
            bd.ByteWidth = sizeof(SimpleVertex) * 8;
            bd.BindFlags = D3D11_BIND_VERTEX_BUFFER;
            bd.CPUAccessFlags = 0;
            D3D11_SUBRESOURCE_DATA InitData;
            ZeroMemory(&InitData, sizeof(InitData));
            InitData.pSysMem = vertices;
            hr = m_pd3dDevice->CreateBuffer(&bd, &InitData, &m_pVertexBuffer);
            if (FAILED(hr))
                return hr;

            // Set vertex buffer
            UINT stride = sizeof(SimpleVertex);
            UINT offset = 0;
            m_pImmediateContext->IASetVertexBuffers(0, 1, &m_pVertexBuffer, &stride, &offset);

            // Create index buffer
            int[] indices =
            {
                3, 1, 0,
                2, 1, 3,

                0, 5, 4,
                1, 5, 0,

                3, 4, 7,
                0, 4, 3,

                1, 6, 5,
                2, 6, 1,

                2, 7, 6,
                3, 7, 2,

                6, 4, 5,
                7, 4, 6,
            };
            bd.Usage = D3D11_USAGE_DEFAULT;
            bd.ByteWidth = sizeof(WORD) * 36;        // 36 vertices needed for 12 triangles in a triangle list
            bd.BindFlags = D3D11_BIND_INDEX_BUFFER;
            bd.CPUAccessFlags = 0;
            InitData.pSysMem = indices;
            hr = m_pd3dDevice->CreateBuffer(&bd, &InitData, &m_pIndexBuffer);
            if (FAILED(hr))
                return hr;

            // Set index buffer
            m_pImmediateContext->IASetIndexBuffer(m_pIndexBuffer, DXGI_FORMAT_R16_UINT, 0);

            // Set primitive topology
            m_pImmediateContext->IASetPrimitiveTopology(D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST);

            // Create the constant buffer
            bd.Usage = D3D11_USAGE_DEFAULT;
            bd.ByteWidth = sizeof(ConstantBuffer);
            bd.BindFlags = D3D11_BIND_CONSTANT_BUFFER;
            bd.CPUAccessFlags = 0;
            hr = m_pd3dDevice->CreateBuffer(&bd, NULL, &m_pConstantBuffer);
            if (FAILED(hr))
                return hr;

            // Initialize the world matrix
            m_World = Matrix4x4.Identity;

            // Initialize the view matrix
            var Eye = new Vector3(0.0f, 1.0f, -5.0f);
            var At = new Vector3(0.0f, 1.0f, 0.0f);
            var Up = new Vector3(0.0f, 1.0f, 0.0f);
            m_View = Matrix4x4.CreateLookAt(Eye, At, Up);

            return S_OK;
        }

        public void SetUpViewport()
        {
            // Setup the viewport
            D3D11_VIEWPORT vp;
            vp.Width = m_Width;
            vp.Height = m_Height;
            vp.MinDepth = 0.0f;
            vp.MaxDepth = 1.0f;
            vp.TopLeftX = 0;
            vp.TopLeftY = 0;
            m_pImmediateContext.RSSetViewports(1, &vp);

            // Initialize the projection matrix
            m_Projection = Matrix4x4.CreatePerspectiveFieldOfView(XM_PIDIV4, m_Width / (float)m_Height, 0.01f, 100.0f);
        }

        public HRESULT InitRenderTarget(void* pResource)
        {
            HRESULT hr = S_OK;

            IUnknown* pUnk = (IUnknown*)pResource;

            IDXGIResource* pDXGIResource;
            hr = pUnk->QueryInterface(__uuidof(IDXGIResource), (void**)&pDXGIResource);
            if (FAILED(hr))
            {
                return hr;
            }

            HANDLE sharedHandle;
            hr = pDXGIResource->GetSharedHandle(&sharedHandle);
            if (FAILED(hr))
            {
                return hr;
            }

            pDXGIResource->Release();

            IUnknown* tempResource11;
            hr = m_pd3dDevice->OpenSharedResource(sharedHandle, __uuidof(ID3D11Resource), (void**)(&tempResource11));
            if (FAILED(hr))
            {
                return hr;
            }

            ID3D11Texture2D* pOutputResource;
            hr = tempResource11->QueryInterface(__uuidof(ID3D11Texture2D), (void**)(&pOutputResource));
            if (FAILED(hr))
            {
                return hr;
            }
            tempResource11->Release();

            D3D11_RENDER_TARGET_VIEW_DESC rtDesc;
            rtDesc.Format = DXGI_FORMAT_B8G8R8A8_UNORM;
            rtDesc.ViewDimension = D3D11_RTV_DIMENSION_TEXTURE2D;
            rtDesc.Texture2D.MipSlice = 0;

            hr = m_pd3dDevice->CreateRenderTargetView(pOutputResource, &rtDesc, &m_pRenderTargetView);
            if (FAILED(hr))
            {
                return hr;
            }

            D3D11_TEXTURE2D_DESC outputResourceDesc;
            pOutputResource->GetDesc(&outputResourceDesc);
            if (outputResourceDesc.Width != m_Width || outputResourceDesc.Height != m_Height)
            {
                m_Width = outputResourceDesc.Width;
                m_Height = outputResourceDesc.Height;

                SetUpViewport();
            }

            m_pImmediateContext->OMSetRenderTargets(1, &m_pRenderTargetView, NULL);

            if (NULL != pOutputResource)
            {
                pOutputResource->Release();
            }

            return hr;
        }

        public HRESULT Render(void* pResource, bool isNewSurface)
        {
            HRESULT hr = S_OK;

            // If we've gotten a new Surface, need to initialize the renderTarget.
            // One of the times that this happens is on a resize.
            if (isNewSurface)
            {
                m_pImmediateContext->OMSetRenderTargets(0, NULL, NULL);
                hr = InitRenderTarget(pResource);
                if (FAILED(hr))
                {
                    return hr;
                }
            }

            // Update our time
            static float t = 0.0f;
            if (m_driverType == D3D_DRIVER_TYPE_REFERENCE)
            {
                t += (float)XM_PI * 0.0125f;
            }
            else
            {
                static DWORD dwTimeStart = 0;
                DWORD dwTimeCur = GetTickCount();
                if (dwTimeStart == 0)
                    dwTimeStart = dwTimeCur;
                t = (dwTimeCur - dwTimeStart) / 1000.0f;
            }

            //
            // Animate the cube
            //
            m_World = XMMatrixRotationX(t) * XMMatrixRotationY(t);

            // Clear the back buffer
            static float ClearColor[4] = { 0.0f, 0.0f, 0.0f, 0.0f };
            m_pImmediateContext->ClearRenderTargetView(m_pRenderTargetView, ClearColor);

            // Update the view matrix
            m_camera.Update();

            XMMATRIX viewProjection = XMMatrixMultiply(m_camera.View, m_Projection);

            ConstantBuffer cb;
            cb.mWorld = XMMatrixTranspose(m_World);
            cb.mView = XMMatrixTranspose(m_View);
            cb.mProjection = XMMatrixTranspose(viewProjection);
            m_pImmediateContext->UpdateSubresource(m_pConstantBuffer, 0, NULL, &cb, 0, 0);

            // Renders a triangle
            m_pImmediateContext->VSSetShader(m_pVertexShader, NULL, 0);
            m_pImmediateContext->VSSetConstantBuffers(0, 1, &m_pConstantBuffer);
            m_pImmediateContext->PSSetShader(m_pPixelShader, NULL, 0);
            m_pImmediateContext->DrawIndexed(36, 0, 0);        // 36 vertices needed for 12 triangles in a triangle list

            if (NULL != m_pImmediateContext)
            {
                m_pImmediateContext->Flush();
            }

            return 0;
        }

        public CCamera GetCamera()
        {
            return m_camera;
        }
    }
}
