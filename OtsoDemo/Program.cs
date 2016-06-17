using Otso;
using System;

namespace OtsoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Display.Create("Otso Otso"
#if DEBUG
            , 800, 600
#endif
            );
            Display.Run(Start, Render, Update);
        }

        static void Start()
        {
            GL.ClearColor(0.0f, 0.2f, 0.2f, 1);
        }

        static void Update(float dt)
        {
        }

        static void Render(float dt)
        {
#if DEBUG
            Display.Title = "FPS: "+(1 / dt).ToString("0.");
#endif
            GL.Clear(GL.COLOR_BUFFER_BIT);
            Display.SwapBuffers();
        }
    }
}
