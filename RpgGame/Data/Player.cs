using RpgGame.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgGame.Data
{
    public class Player : EventArgs, IObserver
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public string Message { get; set; }

        public void UpdataMessage(EventArgs e)
        {
            this.Message = string.Format("{0}被砍了,血剩下{1}!", this.Name, this.Health);
        }
    }
}