using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DguSite.Models
{
    public class FacultyNews
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime dateAdd { get; set; }
        public string faculty { get; set; }
        public string url { get; set; }
    }
}
