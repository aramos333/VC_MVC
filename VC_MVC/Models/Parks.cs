using System.Collections.Generic;

namespace VC_MVC.Models
{

    public class Parks
    {
        public string total { get; set; }
        public string limit { get; set; }
        public string start { get; set; }
        public List<Park> data { get; set; }
    }
}
