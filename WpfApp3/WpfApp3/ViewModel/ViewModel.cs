using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp3.Models;

namespace WpfApp3.ViewModel
{
    // ModelBase를 상속받는다
    class ViewModel : ModelBase
    {
        public ObservableCollection<ModelBase> MODEL { get; set; } 
        public ViewModel()
        {
            this.MODEL = new ObservableCollection<ModelBase>();
            foreach (uint i in Enumerable.Range(0, (int)1000))
            {
                this.MODEL.Add(new Model() { NAME = "TEST" + i });
            }
        }

    }
}
