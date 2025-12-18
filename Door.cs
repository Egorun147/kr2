using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace kontrol2
{
    internal class Checkpoint : GameObject, IInteractable
    {
        public Checkpoint(int id, string name, bool IsActive) : base(id, name, IsActive)
        {
        }

        public override string Info()
        {
            return $"Чекпоинт: {Name} (ID: {Id}, Активен: {IsActive})";
        }

        public string Interact(Player player)
        {
            player.LASTCheckpoint = Id;
            return "Чекпоинт поменян";
        }
    }
}