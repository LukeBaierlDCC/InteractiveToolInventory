using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolInventoryMGMT
{
    class Tool
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Cost { get; set; }
        public double Size { get; set; }
        public float Weight { get; set; }
        public string Model { get; set; }

        public Tool(string name, int quantity, double cost, double size, float weight, string model)
        {
            Name = name;
            Quantity = quantity;
            Cost = cost;
            Size = size;
            Weight = Weight;
            Model = model;
        }
    }
}
