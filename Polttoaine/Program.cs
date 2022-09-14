using System;
using System.Collections.Generic;

namespace Polttoaine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Täällä suoritetaan sovellus
            // käytetään ajoneuvoja

            // luodaan "ajoneuvo"-luokasta objekti
            // tarvitaan tietorakenne
            // Lista, tai taulukko
            List<Ajoneuvo> autot = new List<Ajoneuvo>();
            autot.Add(new Ajoneuvo());
            // Ajoneuvo auto1 = new Ajoneuvo();
            string input;
            int aktiivinenAuto = 0; // listan indeksi

            while (true)
            {
                Console.WriteLine("T <= Tankkaa ajoneuvo");
                Console.WriteLine("A <= Aja ajoneuvolla");
                Console.WriteLine("U <= Lisää ajoneuvo");
                Console.Write("Valitse toiminto: ");
                input = Console.ReadLine();

                // rakenne, jolla suoritetaan käyttäjän haluama toiminto
                switch (input)
                {
                    case "T":
                        autot[aktiivinenAuto].Tankkaus();
                        break;
                    case "A":
                        Console.WriteLine("Montako kilometriä ajetaan?");
                        input = Console.ReadLine();
                        autot[aktiivinenAuto].Ajo(Double.Parse(input));
                        break;
                    case "U":
                        // kysytään käyttäjältä nimi
                        autot.Add(new Ajoneuvo("Nimi")); // constructor parametri
                        break;
                    default: // käyttäjä ei syöttänyt hyväksyttävää arvoa
                        break;
                } // switch päättyy
            } // while päättyy
        } // main päättyy

        // TEHTÄVIÄ
        // 1. Näytä arvot kahden desimaalin tarkkuudella
        // 2. lisää käyttäjälle mahdollisuus lopettaa sovelluksen suoritus
        // 3. Lisää "Ajoneuvo"-luokkaan "AjetutKilometrit"-property,
        //      jossa kerätään kaikkien ajojen kilometrit talteen.
        //      Lisää käyttäjälle toiminto, joka näyttää ajetut kilometrit
        // 4. Lisää käyttäjälle toiminto lisätä ajoneuvoja (uusi objekti)
        // 5. Lisää ajoneuvolla Esim: "Nimi"-property
        // 6. Käyttäjä pystyy vaihtamaan aktiivisen ajoneuvon

    }
}
