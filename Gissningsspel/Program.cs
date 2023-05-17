using System;


// GISSNINGSSPEL
// GISSA ETT TAL
// IFALL TALET ÄR DET SAMMA, "GRATTIS"
// ANNARS "GISSA IGEN"
// ANVÄND TRYPARSE FÖR ATT FÅNGA GISSNINGAR SOM INTE ÄR SIFFOR

Random generator = new Random();
bool playing = true;
int svar = generator.Next(1, 11);
int g;

Console.WriteLine("Gissa på ett tal mellan 1 - 10");

while (playing)
{
    string gissning = Console.ReadLine();
    bool isParsable = Int32.TryParse(gissning, out g);

    if (!isParsable || g > 10 || g < 1)
    {
        Console.WriteLine("Fel! Skriv en siffra mellan 1 - 10");
    }

    if (g == svar)
    {
        Console.WriteLine("Grattis");
        playing = false;
    }
    else
    {
        Console.WriteLine("Försök igen");

    }

}

if (!playing)
{
    Console.WriteLine("Du vann!");
}

Console.ReadLine();


