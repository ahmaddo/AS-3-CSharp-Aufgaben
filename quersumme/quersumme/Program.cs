/*
 * User: Ahmad Ahmad
 * Class: FA-65
 * Date: 08.09.2017
 * Time: 12:31
 */
using System;

namespace quersumme
{
	class Program
	{
		public static void Main(string[] args)
		{
            //Implementierung der Methoden


            int zahl = 47;
            //Aufgabe 1.
            int crosSumValue = GetCrosSum(zahl);
            Console.WriteLine(crosSumValue);

            //Aufgabe 2.
            PrintNumbersWithCrossSum15();

            //Aufgabe 3.
            PrintNumbersWithCrossSumMultipleSeven();

            //Aufgabe 4.
            int root = Zw(crosSumValue);
            int zahl_1 = 47;

            Console.WriteLine("Quersummer von {0} ist: {1}", zahl_1, crosSumValue);
            Console.WriteLine("Ziffernwurzel von {0} ist: {1}", crosSumValue, root);

            //Aufgabe 5.
            PrintCommenCrossNummber();
            
            //Aufgabe 6.
            PrintMultiplicativeRoot();

            Console.ReadKey(true);
        }


        //Aufgabe 1 
        //1.Das Programm soll eine Methode zur Bestimmung der Quersumme enthalten
        public static int GetCrosSum(int number) 
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
            return moduloRest + GetCrosSum(number);
		}

        //Aufgabe 2
        //2.Alle Zahlen von 0 - 1000 sollen ausgegeben werden, welche die Quersumme 15 haben.
        public static void PrintNumbersWithCrossSum15()
		{
            Console.WriteLine("========================================");
            Console.WriteLine("======Numbers with 15 as cross sum======");

            //die `for` schleife um die Methode auf alle nummern zu verwenden 
            for (int i=0; i <= 1000; i++) {

                //die quersumme Methode wird nur auf zweistellige Nummern verwnedet
				if (i > 9) {
                    int crossSum = GetCrosSum(i);
                    //die Quersummer wird in der Konsole gezeigt, falls sie gleich 15 ist
                    if (crossSum == 15) {
						Console.WriteLine(i);
					}
				}
			}
        }

        //Aufgabe 3
        //3.lle Zahlen von 0 - 1000 sollen ausgegeben werden, welche die Quersumme ein Vielfaches von 7 sind.
        public static void PrintNumbersWithCrossSumMultipleSeven()
        {
            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("======Numbers with ´7´ as cross sum======");

            //die `for` schleife um die Methode auf alle nummern zu verwenden 
            for (int i = 0; i <= 1000; i++)
            {

                //die quersumme Methode wird nur auf zweistellige Nummern verwnedet
                if (i > 9)
                {
                    int crossSum = GetCrosSum(i);
                    //die Quersummer wird in der Konsole gezeigt, falls sie gleich 7 ist
                    if (crossSum == 7)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.WriteLine("=========================================");
            Console.WriteLine();
        }

        //Aufgabe 4
        //2.Schreiben Sie eine rekursive Methode, welche die iterierte Quersumme bestimmt. 
        public static int Zw(int number)
        {
            //numer variable mit die Quersummer überschreiben
            number = GetCrosSum(number);

            //die methode nochmal nochmal benutzen, fass die quersumme 
            if (number > 10)
            {
                number = Zw(number);
            } 

            return number;
        }

        //Aufagbe 5
        // Welche iterierte Quersumme der Zahlen von 0 - 1000 kommen am häufigsten vor?
        public static void PrintCommenCrossNummber()
        {
            Console.WriteLine();
            Console.WriteLine("=========================================");

            //die max quersummen zahl ist 1001
            int[] commonCrossNumber = new int[1001];

            //`for` schleife um die Methode auf alle nummern zu verwenden 
            for (int i = 0; i <= 1000; i++)
            {
                int crossNumber = GetCrosSum(i);
                commonCrossNumber[crossNumber]++;
            }

            //arrays elemnte sortieren
            Array.Sort(commonCrossNumber);
            //die Sortierung umgekehrt um die häufigsten zuerst zu setzen
            Array.Reverse(commonCrossNumber);
            Console.WriteLine("Die fünf häufigten Quersummen für die Nummern von 0 bis 1000 sind:");
            for (int i=0; i < 5; i++)
            {
                Console.WriteLine("Der Zahl {0} wurde {1} mal als Quersumme wiederholt.", i, commonCrossNumber[i]);
            }
            Console.WriteLine("=========================================");
            Console.WriteLine();
        }

        //Aufgabe 6
        //6.Alle Zahlen von 0 - 1000 sollen ausgegeben werden, bei denen die Quersumme und Querprodukt wieder die Zahl selbst ergibt.
        public static void PrintMultiplicativeRoot()
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Zahlen mit gleichen Quersumme und Querprodukt");
            for (int i = 0; i <= 1000; i++)
            {
                int quersumme = GetCrosSum(i);
                int querprodukt = MultiplicativeRootHelper(i);

                //Ausgabe jedes Nummers in der schleife, deren quersumme und querprodukt gleich sind
                if (querprodukt + quersumme == i)
                {
                 Console.WriteLine(i);
                }
            }
            Console.WriteLine("=========================================");
            Console.WriteLine();
        }

        public static int MultiplicativeRootHelper(int number)
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

            //modulorest werden zusammen mit zurückgegebenen modulos rest multiplizieren 
            return moduloRest * GetCrosSum(number);
        }

    }
}