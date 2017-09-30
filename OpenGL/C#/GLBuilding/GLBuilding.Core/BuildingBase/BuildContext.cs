using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLBuilding.Core.BuildingBase;

namespace GLBuilding.Core
{
    public class BuildContext
    {
        public Color ClearColor { get; set; } = Color.Blue();
        public int Width { get; set; } = 800;
        public int Height { get; set; } = 600;
    }
}
