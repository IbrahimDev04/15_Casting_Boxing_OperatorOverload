using Polimorphism.Models;

namespace _15_Upcasting_Downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Shark akula = new Shark("Akula");
            Eagle qartal = new Eagle("Shahin");
            Cat mestan = new("Şahin");

            //Upcating
            Animal a = new Shark("Akula");

            Animal[] animals = { akula, qartal, mestan, new Chicken("asd") };
            foreach (var animal in animals)
            {
                if(animal is Eagle)
                {
                    //Downcasting
                    Eagle eagle = (Eagle)animal;
                    eagle.Hunt();
                }
            }
        }
    }
}
