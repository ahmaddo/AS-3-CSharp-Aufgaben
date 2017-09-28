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
            int zahl = 247;
            getNumbersWithCrossSum15();

            Console.WriteLine(zahl);
            zahl = calcCrosSum(zahl);
            Console.WriteLine(zw(zahl));

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

            //die `for` schleife um die Methode auf alle nummeern zu verwenden 
            for (int i=0; i <= 1000; i++) {

                //die quersumme Methode wird nur auf zweistellige Nummern verwnedet
				if (i > 9) {
                    int crossSum = calcCrosSum(i);
                    //die Quersummer wird in der Konsole gezeigt, falls sie gleich 15 ist
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
            Console.WriteLine("======Numbers with ´7´ as cross sum======");

            //die `for` schleife um die Methode auf alle nummeern zu verwenden 
            for (int i = 0; i <= 1000; i++)
            {

                //die quersumme Methode wird nur auf zweistellige Nummern verwnedet
                if (i > 9)
                {
                    int crossSum = calcCrosSum(i);
                    //die Quersummer wird in der Konsole gezeigt, falls sie gleich 7 ist
                    if (crossSum == 7)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.WriteLine("======================================");
        }

        //Aufgabe 3

        public static int zw(int number)
        {
            //numer variable mit die Quersummer überschreiben
            number = calcCrosSum(number);

            //die methode nochmal nochmal benutzen, fass die quersumme 
            if (number > 10)
            {
                number = zw(number);
            } 

            return number;
        }
    }
}