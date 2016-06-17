using System;
using OpenTK;
using OpenTK.Graphics;

namespace Otso
{
    public class Display
    {
        private static GameWindow window;

        public static string Title
        {
            get
            {
                return window.Title;
            }
            set
            {
                window.Title = value;
            }
        }

        public static void Create(string title, int width, int height)
        {
            window = new GameWindow(
                width, height,
                GraphicsMode.Default,
                title,
                GameWindowFlags.Default,
                DisplayDevice.Default,
                3, 0, GraphicsContextFlags.ForwardCompatible
            );
        }

        public static void Create(string title)
        {
            window = new GameWindow(
                DisplayDevice.Default.Width,
                DisplayDevice.Default.Height,
                GraphicsMode.Default,
                title,
                GameWindowFlags.Fullscreen,
                DisplayDevice.Default,
                3, 0, GraphicsContextFlags.ForwardCompatible
            );
        }

        public static void Run(
            Action start,
            Action<float> render,
            Action<float> update)
        {
            using (window)
            {
                window.Load += (object s, EventArgs e) => start();
                window.RenderFrame += (object s, FrameEventArgs e) => render((float)e.Time);
                window.UpdateFrame += (object s, FrameEventArgs e) => update((float)e.Time);
                window.Run();
            }
        }

        public static void SwapBuffers()
        {
            window.SwapBuffers();
        }
    }
}
