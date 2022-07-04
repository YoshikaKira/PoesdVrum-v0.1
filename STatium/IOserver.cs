using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STatium
{
    interface IObserver
    {
        void Notify(Train train);
        
    }
}
