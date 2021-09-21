using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Models
{
    class Model : ModelBase
    {
        public string NAME { get; set; }
        public Model()
        {
            this.NAME = "TEST1";
        }
    }
}
