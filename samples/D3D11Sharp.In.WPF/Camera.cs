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
