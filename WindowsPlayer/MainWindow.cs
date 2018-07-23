using E3DEngine;
using GLLibrary;
using System;
using System.Windows.Forms;


namespace CSPlayer
{
    public partial class MainWindow : Form
    {
        private GLContext glContext = new GLContext();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            glContext.InitGLES(this.RenderPanel.Handle);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            glContext.UseContext();
            gl2.BindFramebuffer(gl2.GL_FRAMEBUFFER, 0);
            gl2.Viewport(0, 0, this.RenderPanel.Width, this.RenderPanel.Height);
            gl2.ClearColor(0, 0, 1, 0);
            gl2.Clear(gl2.GL_COLOR_BUFFER_BIT | gl2.GL_DEPTH_BUFFER_BIT | gl2.GL_STENCIL_BUFFER_BIT);
            glContext.SwapBuffer();
            gl2.Flush();
        }
    }
}
