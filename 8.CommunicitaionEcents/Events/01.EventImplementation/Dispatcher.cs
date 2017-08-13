using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.EventImplementation
{
    public delegate void NameChangeEventHandler(object sender,NameChangeEventArgs args);

    public class Dispatcher
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                OnNameChange(new NameChangeEventArgs(value));
            }
        }

        public event NameChangeEventHandler NameChange;

        public void OnNameChange(NameChangeEventArgs args)
        {
            if (NameChange != null)
            {
                NameChange(this, args);
            }
        }
    }

}
