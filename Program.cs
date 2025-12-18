using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace kontrol2
{
    internal class Program
    {
        private static Scene Scene;

        public static int IntInput()
        {
            while (true)
            {
                string str = Console.ReadLine();
                if (int.TryParse(str, out int Int))
                {
                    return Int;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
        }
        public static float FloatInput()
        {
            while (true)
            {
                string str = Console.ReadLine();
                if (float.TryParse(str, out float Float))
                {
                    return Float;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }
            }
        }
        static void Main(string[] args)
        {
            Scene  = new Scene();
            Trap trap = new Trap(52, "Mina",true);
            Scene.AddObj(trap);
            
            while (true)
            {
                Console.WriteLine("1. Показать все объекты");
                Console.WriteLine("2. Показать только интерактивные объекты");
                Console.WriteLine("3. Взаимодействовать с объектом по Id");
                Console.WriteLine("4. Отключить объект по Id");
                Console.WriteLine("5. Включить объект по Id");
                int put = IntInput();
                if (put == 1)
                {
                    Scene.PrintAll();
                }
            }
        }
    }
}
