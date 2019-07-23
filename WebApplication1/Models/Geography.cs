using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Geography
    {
        public string Region { get; set; }
        public List<District> Districts { get; set; }
    }

    public class District
    {
        public string Name { get; set; }
        public List<string> Cities{ get; set; }
    }
}