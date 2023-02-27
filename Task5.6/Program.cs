using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static (string name, string surname, int age, bool pets, List<string> pets_name) Person()
        {
            (string name, string surname, int age, bool pets, List<string> pets_name) person;


            Console.WriteLine("введите ваше имя");
            person.name = Console.ReadLine();
            Console.WriteLine("введите вашу фамилию");
            person.surname = Console.ReadLine();
            person.age = Age();
            person.pets = HasPets();
            person.pets_name = Pets_name();




            return person;


        }
        static bool GetAge(string age, out int intage)
        {

            if (int.TryParse(age, out intage))
            {
                if (intage > 0)
                {
                    return true;
                }
                return false;
            }

            return false;
        }
        static int Age()

        {
            string age;
            int intage;

            do
            {
                Console.WriteLine("введите ваш возраст");
                age = Console.ReadLine();
            } while (!GetAge(age, out intage));
            return intage;
        }

        static bool HasPets()
        {
            Console.WriteLine("у вас есть домашнии животные? да или нет");
            var answer = Console.ReadLine();
            if (answer == "да") { return true; }
            else { return false; }
        }

        static List<string> Pets_name()
        {
            var pets = HasPets();
            List<String> pets_name = new List<String>();
            if (pets == true)
            {
                Console.WriteLine("сколько у вас домашних животных? ответ цифрой");
                var pets_quantity = int.Parse(Console.ReadLine());
                if (pets_quantity > 0)
                {
                    
                    for (int i = 0; i < pets_quantity; i++)
                    {
                        Console.WriteLine("введите кличку вашего питомца");
                        pets_name.Add(Console.ReadLine());
                    }
                    
                }
                

            }
            return pets_name;


        }
        
    }
}
