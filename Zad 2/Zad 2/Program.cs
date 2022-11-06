namespace Zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double liczba1, liczba2;
            
            double wynik;

            Console.WriteLine("Podaj liczbe");

            liczba1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbe");

            liczba2 = double.Parse(Console.ReadLine());

            wynik = (liczba1 + liczba2) / 2;

            Console.WriteLine(wynik);

            Console.ReadKey();


        }
    }
}