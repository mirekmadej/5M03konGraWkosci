namespace _5M03konGraWkosci
{
    //inf_04_2024_06_01_SG.pdf
    internal class Program
    {
        private static int[] tabLos = new int[10];
        private static int[] tabwynik = new int[7];
        //liczba wylosowanych konkretnych wartości
        private static int suma = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("");
            wylosujTablice();
        }


        private static void wylosujTablice()
        {
            int liczbaRzutów;
            do
            {
                Console.WriteLine("ile kostek chcesz rzucić? (3-10)");
                liczbaRzutów = int.Parse(Console.ReadLine());
            } while (liczbaRzutów < 3 || liczbaRzutów > 11);
            Console.WriteLine($"rzucam {liczbaRzutów}");
            
        }
    }
}
