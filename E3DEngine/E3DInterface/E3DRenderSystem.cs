using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3DEngineInterface
{
    public class RenderSystem
    {
        public int ViewportWidth = 800;
        public int ViewportHeight = 600;

        public virtual void Update(float deltaTime)
        {

        }
    }
}
