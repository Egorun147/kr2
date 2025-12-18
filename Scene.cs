using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kontrol2
{
    internal class Scene
    {
        List<GameObject> Objects = new List<GameObject>();
        public Scene() { }
        public void AddObj(GameObject obj) { Objects.Add(obj); }

        public void PrintAll()
        {
            foreach (var obj in Objects)
            {
                Console.WriteLine(obj.Info());
            }
        }
        public void PrintInteractiveObjects()
        {
            Console.WriteLine("\n=== Interactive Objects (IInteractable) ===");
            foreach (var obj in Objects)
            {
                if (obj is IInteractable && obj.IsActive)
                {
                    Console.WriteLine(obj.Info());
                }
            }
            Console.WriteLine();
        }
        public void Innteractiveprint()
        {
            for (int i = 0; i < Objects.Count; i++) 
            {
              if (Objects is IInteractable)
                {
                    Console.WriteLine(Objects[i].Info());
                }
            }
        }
    }
}
