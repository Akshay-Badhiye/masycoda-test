using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter input:");

            int userInput = Convert.ToInt32(Console.ReadLine());
            List<Coordinate> result = new List<Coordinate>();

            int i = 10;

            for (int x1 = 0; x1 < i; x1++)
            {
                for (int y1 = 0; y1 < i; y1++)
                {
                    for(int z1 = 1; z1 < i; z1++)
                    {
                        for (int x2 = 0; x2 < i; x2++)
                        {
                            for (int y2 = 0; y2 < i; y2++)
                            {
                                for (int z2 = 1; z2 < i; z2++)
                                {
                                    Coordinate coordinate = new Coordinate();
                                    coordinate.x1 = x1;
                                    coordinate.x2 = x2;
                                    coordinate.y1 = y1;
                                    coordinate.y2 = y2;
                                    coordinate.z1 = z1;
                                    coordinate.z2 = z2;
                                    coordinate.result = ((Math.Pow((Math.Pow(x2 - x1, 2) +
                                                        Math.Pow(y2 - y1, 2) +
                                                        Math.Pow(z2 - z1, 2) *
                                                1.0), 0.5)) * 1.05);
                                    result.Add(coordinate);
                                }                                 
                            }

                        }
                    }
                    
                }

            }

            double result1 = 0;
            
            var a = result.OrderBy(x => x.result).ToList();
            // Print the value of the variable (userName), which will display the input value
            foreach (var coordinate in a)
            {
                if(userInput > 1 && coordinate.result !=0)
                {
                    result1 += coordinate.result;
                    Console.WriteLine($"x1={coordinate.x1},y1={coordinate.y1},z1={coordinate.z1}" +
                                $" - x2={coordinate.x2},y2={coordinate.y2},z2={coordinate.z2} = result {coordinate.result}");
                    
                    userInput--;                   
                }
                
            }
            Console.WriteLine("Distance is: " + result1);
            Console.ReadLine();
        }

        public class Coordinate
        {
            public int x1 { get; set; }
            public int x2 { get; set; }
            public int y1 { get; set; }
            public int y2 { get; set; }
            public int z1 { get; set; }
            public int z2 { get; set; }
            public double result { get; set; }
        }
    }
}
