class Program
{
    static void Main()
    {
        szyfr();
    }

    static void szyfr()
    {
        string haslo = "abc";
        int key = 3;
        char[] alfabet = "abcdefghijklmnopqrstuwxyz".ToCharArray();

        char[] wynik = new char[haslo.Length];

        for (int i = 0; i < haslo.Length; i++)
        {
            
            int index = haslo[i] - 'a';
            int newIndex = (index + key) % 26;
            wynik[i] = alfabet[newIndex];
        }
        string zaszyfrowaneHaslo = new string(wynik);

        Console.WriteLine(zaszyfrowaneHaslo);
    }
}