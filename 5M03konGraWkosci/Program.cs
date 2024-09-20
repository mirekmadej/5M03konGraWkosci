namespace _5M03konGraWkosci
{
    //inf_04_2024_06_01_SG.pdf
    internal class Program
    {
        private static int[] tabLos = new int[10];
        
        private static int suma = 0;
        private static int liczbaRzutów = 0;
        static void Main(string[] args)
        {
            
            
            string pytanie;
            do
            {
                wylosujTablice();
                wypiszTablice();
                Console.WriteLine($"Liczba uzyskanych punktów: {obliczPunkty()}");
                Console.WriteLine("Czy jeszcze raz? (t/n)");
                pytanie = Console.ReadLine();
            }while (pytanie == "t");
            
        }

        private static int obliczPunkty()
        {
            int[] tabwynik = new int[7];
            for(int i=0; i<7; i++)
                tabwynik[i] = 0;
            //liczba wylosowanych konkretnych wartości
            for(int i = 0; i < liczbaRzutów; i++)
                tabwynik[tabLos[i]]++;
            //foreach(int i in tabwynik)
            //    Console.WriteLine(i);
            int suma = 0;
            for (int i = 1; i <= 6; i++)
                if (tabwynik[i] > 1)
                    suma += tabwynik[i] * i;
            return suma;
        }


        private static void wylosujTablice()
        {
            do
            {
                Console.WriteLine("ile kostek chcesz rzucić? (3-10)");
                liczbaRzutów = int.Parse(Console.ReadLine());
            } while (liczbaRzutów < 3 || liczbaRzutów > 11);
            //Console.WriteLine($"rzucam {liczbaRzutów}");
            Random r = new Random();
            for (int i = 0; i < liczbaRzutów; i++)
                tabLos[i] = r.Next(1, 7);
        }
        private static void wypiszTablice()
        {
            for (int i = 0; i < liczbaRzutów; i++)
                Console.WriteLine($"Kostka {i + 1}: {tabLos[i]}");

        }
    }
}
