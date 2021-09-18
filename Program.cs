using System;

namespace Quit_2
{
    class Program
    {
        static void Main(string[] arg)
        {

        }
    }
    class Flower
    {
        public int NumberPlant;

        public string NamePlant;

        public string Description;

        public string hight;

        public string Treecircumference;

        public Flower(string valuesizeNamePlant, string valueDescription, string valurhight, string valueTreecircumference)
        {
            NamePlant = valuesizeNamePlant;

            Description = valueDescription;

            hight = valurhight;

            Treecircumference = valueTreecircumference;
            
           
        }
        class FlowerCart
        {
            public List<Flower> CartFlower;
            public FlowerCart()
            {
                FlowerCart = new List<Flower>();
                
            }
            public void PrintFlower()
            {

                foreach (Flower Flowerorder in CartFlower)

                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    
                }
            }
        }
    }

}
