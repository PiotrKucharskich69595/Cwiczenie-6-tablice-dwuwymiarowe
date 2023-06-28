using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj rozmiar tablicy: ");
        int rozmiar = Convert.ToInt32(Console.ReadLine());

        int[,] tablica = new int[rozmiar, rozmiar];
        int liczba = 0;

        for (int wiersz = 0; wiersz < rozmiar; wiersz++)
        {
            if (wiersz % 2 == 0)
            {
                // Wiersze parzyste - rosnąco
                for (int kolumna = 0; kolumna < rozmiar; kolumna++)
                {
                    tablica[wiersz, kolumna] = liczba;
                    liczba++;
                }
            }
            else
            {
                // Wiersze nieparzyste - malejąco
                for (int kolumna = rozmiar - 1; kolumna >= 0; kolumna--)
                {
                    tablica[wiersz, kolumna] = liczba;
                    liczba++;
                }
            }
        }

        // Wyświetlanie tablicy
        for (int wiersz = 0; wiersz < rozmiar; wiersz++)
        {
            for (int kolumna = 0; kolumna < rozmiar; kolumna++)
            {
                Console.Write(tablica[wiersz, kolumna] + "\t");
            }
            Console.WriteLine();
        }
    }
}