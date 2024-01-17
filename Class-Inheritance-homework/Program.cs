using System;

namespace Class_Inheritance_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arrayStr;
            int array;
           
            do
            {
                Console.WriteLine("City sayi:");
                arrayStr = Console.ReadLine();
            } while (!int.TryParse(arrayStr, out array) || array < 0);

            ChinaCity[] chinaCity = new ChinaCity[array];


            for (int i = 0; i < array; i++)
            {
                string cityName;
                bool letter;
                do
                {
                    Console.Write("City adi: ");
                    cityName = Console.ReadLine();
                    letter = false;
                    for (int s = 0; s < cityName.Length; s++)
                    {
                        if (char.IsDigit(cityName[s]))
                        {
                            Console.WriteLine("City heriflerden ibaretdir");
                            letter = true;
                            break;
                        }
                    }
                } while (string.IsNullOrWhiteSpace(cityName)|| letter);
                string populationStr;
                int population;
                do
                {
                    Console.Write("Population: ");
                    populationStr = Console.ReadLine();

                } while (!int.TryParse(populationStr, out population));
                ChinaCity city = new ChinaCity()
                {
                    Name = cityName,
                    Population = population
                };

                chinaCity[i] = city;
            }
            int count = 0;
            int sum = 0;
            int result = 0;
            for (int i = 0; i < chinaCity.Length; i++)
            {
                count++;
                sum += chinaCity[i].Population;
                result = sum / count;
            }
            Console.WriteLine($"Ortalamasi: {result}");
        }
        
    }
}
