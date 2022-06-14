using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Body
    {
        public int x=0;
        public int y=0;
        Body parent;
        public Body()
        {
        }
        public Body(Body parent)
        {
            this.parent = parent;
            this.x = parent.x;
            this.y = parent.y;
        }

        public void setToParentPos()
        {
            if (parent == null) return;
            this.x = parent.x;
            this.y = parent.y;
            parent.setToParentPos();
        }

    }
}
