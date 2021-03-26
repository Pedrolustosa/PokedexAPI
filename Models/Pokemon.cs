using System.Collections.Generic;

namespace PokedexAPI.Models
{
    public class Pokemon
    {
        // Attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Species { get; set; }
        public List<string> Type { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        // Constructor Method
        public Pokemon()
        {
            Type = new List<string>();
        }
    }
}