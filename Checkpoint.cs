using System;

namespace kontrol2
{
    internal class CheckpointObj : GameObject, IInteractable
    {
        public CheckpointObj(int id, string name, bool IsActive) : base(id, name, IsActive)
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