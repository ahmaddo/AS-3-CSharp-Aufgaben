/*
 * Created by SharpDevelop.
 * User: user
 * Date: 08.09.2017
 * Time: 12:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace quersumme
{
	class Program
	{
		public static void Main(string[] args)
		{
            
            getNumbersWithCrossSum15();

            int zahl = 5759;

			zahl = calcCrosSum(zahl);

			Console.WriteLine(zahl);

            Console.WriteLine(zw(47));

            Console.ReadKey(true);
        }
		

		//Aufgabe 1 
		public static int calcCrosSum(int number) 
		{
            //Zahl wird zurückgegeben wenn der einstelliger Zahle wäre
            if (number < 10)
            {
                return number;
            }

			// modulo anwenden um die Reste zu finden
			int moduloRest = number % 10;
			
			//die rest von Modulo von der Nummer abziehen
			number = number - moduloRest;
			
			//Nummer mit 10 teilen
			number = number / 10;

            //modulorest werden zusammen mit zurückgegebenen modulos rest addiert
            return moduloRest + calcCrosSum(number);
		}
		
		//Aufgabe 2
		public static void getNumbersWithCrossSum15()
		{
            Console.WriteLine("======Numbers with 15 as cross sum======");

            for (int i=0; i <= 1000; i++) {
				if (i > 9) {
                    int crossSum = calcCrosSum(i);

                    if (crossSum == 15) {
						Console.WriteLine(i);
					}
				}
			}

            Console.WriteLine("======================================");
        }

        //Aufgabe 3
        public static void getNumbersWithCrossSumMultipleSeven()
        {
            for (int i = 0; i <= 1000; i++)
            {
                if (i > 9)
                {
                    int currentNumber = i;
                    int moduloRest = i % 10;
                    i = i - moduloRest;
                    int result = i / 10;

                    if (result % 7 == 0)
                    {
                        Console.WriteLine(currentNumber);
                    }
                }


            }
        }

        //Aufgabe 3

        /// <summary>
        /// Berechnet die Prüfsumme von <paramref name="zahl"/>
        /// </summary>
        /// <param name="zahl">
        /// Zahl von der die Prüfsumme berechnet werden soll
        /// </param>
        /// <returns>
        /// Prüfsumme von <paramref name="zahl"/>
        /// </returns>

        public static int zw(int number)
        {
            number = calcCrosSum(number);

            if (number > 10)
            {
                number = zw(number);
            } 

            return number;
        }
    }
}