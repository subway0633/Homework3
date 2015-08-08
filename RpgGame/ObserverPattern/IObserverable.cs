using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.ObserverPattern
{
    public interface IObserverable
    {
        void AddObserver(IObserver o);

        void RemoveObserver(IObserver o);

        void Notify(EventArgs e);
    }
}