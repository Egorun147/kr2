using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrol2
{
    internal class Light : GameObject, ITriggerable
    {
        private bool IsOn;
        public Light(int id, string name, bool IsActive) : base(id, name, IsActive)
        {
            IsOn = true;
        }
        public override string Info()
        {
            return "Svet";
        }
        public void Trigger()
        {
            IsOn = !IsOn;
            if (IsOn)
            {
                Console.WriteLine("Вкл");
            }
            else
            {
                Console.WriteLine("Выкл");
            }
        }

    }
}
