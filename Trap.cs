using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrol2
{
    internal class Trap : GameObject, IInteractable, IDamageable
    {
        private static int Damage = 1;

        public Trap(int id, string name, bool IsActive) : base(id, name, IsActive)
        {
        }

        public override string Info()
        {
            return $"Ловушка: {Name} (ID: {Id}, Активна: {IsActive}, Урон: {Damage})";
        }

        public string Interact(Player player)
        {
            if (IsActive)
            {
                ApplyDamage(Damage);
                player.Hp -= Damage;
                return $"Получил урон {Damage}";
            }
            return "Ловушка неактивна";
        }

        public void ApplyDamage(int amount)
        {
            Disable();
        }
    }
}