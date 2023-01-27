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
        public double Weight { get; set; }
        public string Model { get; set; }

        public Tool(string name, int quantity, double cost, double weight, string model)
        {
            Name = name;
            Quantity = quantity;
            Cost = cost;
            Weight = weight;
            Model = model;
        }
    }
}
