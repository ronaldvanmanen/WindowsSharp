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
using static System.MathF;

namespace D3D11Sharp.In.WPF
{
    internal sealed class CCamera
    {
        private float r;

        private float theta;

        private float phi;

        private Vector3 m_eye;

        private Vector3 m_at;

        private Vector3 m_up;

        public Matrix4x4 View;

        public CCamera()
        {
            Reset();
        }

        public int UpdatePosition()
        {
            m_eye = new Vector3(
                r * Sin(theta) * Cos(phi),
                r * Sin(phi),
                -r * Cos(theta) * Cos(phi));

            return 0;
        }

        public void Reset()
        {
            View = Matrix4x4.Identity;
            m_eye = new Vector3(0f, 0f, -0.3f);
            m_at = new Vector3(0f, 0f, 1f);
            m_up = new Vector3(0f, 1f, 0f);
        }

        public void Update()
        {
            View = Matrix4x4.CreateLookAt(m_eye + m_at, m_at, m_up);
        }

        public void SetCenterDepth(float depth)
        {
            m_at = new Vector3(0f, 0f, depth);
        }

        public void SetRadius(float r)
        {
            this.r = r;
            UpdatePosition();
        }

        public void SetTheta(float theta)
        {
            this.theta = theta;
            UpdatePosition();
        }

        public void SetPhi(float phi)
        {
            this.phi = phi;
            UpdatePosition();
        }

        public Vector3 GetUp() { return m_up; }

        public Vector3 GetEye() { return m_eye; }
    };
}
