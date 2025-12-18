using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrol2
{
    abstract class GameObject
    {
        protected int id;
        protected string name;
        protected bool isActive;

        public int Id
        {
            get { return id; }
        }

        public string Name { get { return name; } }

        public bool IsActive
        {
            get { return isActive; }
            private set { isActive = value; }
        }

        protected GameObject(int id, string name, bool isActive)
        {
            this.id = id;
            this.name = name;
            this.isActive = isActive;
        }
        public void Enable()
        {
            IsActive = true;
        }
        public void Disable()
        {
            IsActive = false;
        }
        public abstract string Info();
    }
}