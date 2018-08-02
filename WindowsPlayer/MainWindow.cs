using System;
using System.Windows.Forms;
using E3DEngineRenderSystem;
using E3DEngine;
using WindowsGL;

namespace WindowsPlayer
{
    public partial class MainWindow : Form
    {
        private glContext mglContext = new glContext();
        private GLESRenderSystem renderSystem = new GLESRenderSystem();
        private long startTime = 0;
        private long endTime = 0;
        private float deltaTime = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mglContext.InitGLES(this.Handle);
            EngineDelegate.Instance.Initilize(); 
            renderSystem.ViewportHeight = this.Height;
            renderSystem.ViewportWidth = this.Width;
            EngineDelegate.RenderSystem = renderSystem;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startTime = DateTime.Now.Ticks / 10000;
            mglContext.UseContext();
            renderSystem.BeginFrame();
            EngineDelegate.Instance.Update(deltaTime/1000.0f);
            renderSystem.EndFrame();
            mglContext.SwapBuffer();
            endTime = DateTime.Now.Ticks / 10000;
            deltaTime = endTime - startTime;
        }
    }
}
