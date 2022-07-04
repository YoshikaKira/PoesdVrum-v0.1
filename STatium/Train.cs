using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace STatium
{
    class Train
    {
        public Image TrainImage;
        public string Name { get; private set; }
        List<IObserver> observers;
        public Train(string name, Image image)
        {     
            name = Name;
            observers = new List<IObserver>();
            TrainImage = image;
        }
        public void AddObserver (IObserver observer)
        {
            observers.Add(observer);
        }
        public void Notify()
        {
            foreach(IObserver obs in observers)
            {
                obs.Notify(this);
            }
        }
    }
}
