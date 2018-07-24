using System;
using System.Windows.Forms;
using E3DEngineRenderSystem;
using E3DEngine;
using WindowsGL;

namespace WindowsPlayer
{
    public partial class MainWindow : Form
    {
        private GLContext glContext = new GLContext();
        private GLESRenderSystem renderSystem = new GLESRenderSystem();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            glContext.InitGLES(this.Handle);
            EngineDelegate.Instance.RenderSystem = renderSystem;
            renderSystem.ViewportHeight = this.Height;
            renderSystem.ViewportWidth = this.Width;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            glContext.UseContext();
            renderSystem.Update(this.timer1.Interval / 1000.0f);
            glContext.SwapBuffer();
        }
    }
}
