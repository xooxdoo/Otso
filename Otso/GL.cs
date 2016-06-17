using System;
using OpenTK.Graphics.OpenGL4;
using TK = OpenTK.Graphics.OpenGL4.GL;

namespace Otso
{
    public static class GL
    {
        public const int COLOR_BUFFER_BIT = 16384;
        public const int STENCIL_BUFFER_BIT = 1024;
        public const int DEPTH_BUFFER_BIT = 256;

        public const int FRAMEBUFFER_SRGB = 36281;
        public const int DEPTH_TEST = 2929;
        public const int STENCIL_TEST = 2960;
        public const int CULL_FACE = 2884;

        public const int BLEND = 3042;

        public const int TEXTURE1D = 3552;
        public const int TEXTURE2D = 3553;

        public const int GEOMETRY_SHADER = 36313;
        public const int COMPUTE_SHADER = 37305;
        public const int VERTEX_SHADER = 35633;
        public const int FRAGMENT_SHADER = 35632;
        public const int TESS_EVALUATION_SHADER = 36487;
        public const int TESS_CONTROL_SHADER = 36488;

        public const int DELETE_STATUS = 35712;

        public const int SHADER_TYPE = 35663;
        public const int COMPILE_STATUS = 35713;

        public const int VALIDATION_STATUS = 35715;
        public const int LINKING_STATUS = 35714;

        public static void ClearColor(float r, float g, float b, float a)
        {
            TK.ClearColor(r, g, b, a);
        }

        public static void Clear(int bits)
        {
            TK.Clear((ClearBufferMask)bits);
        }

        public static int GenBuffer()
        {
            return TK.GenBuffer();
        }

        public static int GenBuffers()
        {
            return GenBuffer();
        }

        public static int[] GenBuffers(int n)
        {
            var buffers = new int[n];
            TK.GenBuffers(n, buffers);
            return buffers;
        }

        public static int CreateShader(int type)
        {
            return TK.CreateShader((ShaderType)type);
        }

        public static void ShaderSource(int shader, string source)
        {
            TK.ShaderSource(shader, source);
        }

        public static void CompileShader(int shader)
        {
            TK.CompileShader(shader);
        }

        public static int Shader(int shader, int param)
        {
            int result;
            TK.GetShader(shader, (ShaderParameter)param, out result);
            return result;
        }

        public static int GetShaderParameter(int shader, int param)
        {
            return Shader(shader, param);
        }

        public static string GetShaderInfoLog(int shader)
        {
            return TK.GetShaderInfoLog(shader);
        }

        public static int CreateProgram()
        {
            return TK.CreateProgram();
        }

        public static void LinkProgram(int program)
        {
            TK.LinkProgram(program);
        }

        public static void AttachShader(int program, int shader)
        {
            TK.AttachShader(program, shader);
        }

        public static void DetachShader(int program, int shader)
        {
            TK.DetachShader(program, shader);
        }

        public static int Program(int program, int param)
        {
            int result;
            TK.GetProgram(program, (GetProgramParameterName)param, out result);
            return result;
        }

        public static int GetProgramParameter(int program, int param)
        {
            return Program(program, param);
        }

        public static string GetProgramInfoLog(int program)
        {
            return TK.GetProgramInfoLog(program);
        }

        public static void Enable(int cap)
        {
            TK.Enable((EnableCap)cap);
        }

        public static void Disable(int cap)
        {
            TK.Disable((EnableCap)cap);
        }
    }
}
