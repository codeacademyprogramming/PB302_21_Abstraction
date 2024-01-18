using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLesson
{
    internal class Makarov : Gun, IGun, IFireable, IReloadable
    {
        public int Capacity => _capacity;
        public int Magazine => _magazine;


        public void Fire()
        {
            _capacity--;
        }
        public  void Reload()
        {
            _magazine = _capacity;
        }
        
    }
}
