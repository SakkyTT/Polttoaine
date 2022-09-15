using System;
using System.Collections.Generic;
using System.Linq;

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
            // 0 1 2 3 4 5 6
            List<Ajoneuvo> autot = new List<Ajoneuvo>();
            autot.Add(new Ajoneuvo("Default Car"));
            // Ajoneuvo auto1 = new Ajoneuvo();
            string input;
            int aktiivinenAuto = 0; // listan indeksi
            bool continueLoop = true;

            while (continueLoop)
            {
                Console.WriteLine(); // tyhjä rivi
                Console.WriteLine(); // tyhjä rivi
                Console.WriteLine($"Aktiivinen auto on: {autot[aktiivinenAuto].Nimi}");
                Console.WriteLine(); // tyhjä rivi
                Console.WriteLine("T <= Tankkaa ajoneuvo");
                Console.WriteLine("A <= Aja ajoneuvolla");
                Console.WriteLine("U <= Lisää ajoneuvo");
                Console.WriteLine("V <= Vaihda ajoneuvo");
                Console.WriteLine("K <= Näytä kilometrit");
                Console.WriteLine("S <= Lopeta sovellus");
                Console.Write("Valitse toiminto: ");
                input = Console.ReadLine();
                Console.WriteLine(); // tyhjä rivi

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
                        Console.Write("Anna uuden ajoneuvon nimi: ");
                        input = Console.ReadLine();
                        autot.Add(new Ajoneuvo(input)); // constructor parametri
                        break;
                    case "S":
                        continueLoop = false;
                        break;
                    case "K":
                        autot[aktiivinenAuto].NaytaKilometrit(); // Uusi metodi
                        break;
                    case "V":
                        for (int i = 0; i < autot.Count; i++)
                        {
                            Console.WriteLine(i + 1 + $": {autot[i].Nimi}");
                        }
                        int test = 1;
                        bool onnistui = false;
                        do
                        {
                            Console.Write("Syötä auton numero: ");
                            input = Console.ReadLine();

                            onnistui = int.TryParse(input, out test);
                            // lisää tarkistus, että käyttäjä ei anna kirjaimia
                        } while (!onnistui || test < 1 || test > autot.Count); // 0 -> listan loppuun
                        // ei hyväksytä lukuja, joita ei näytetä käyttäjälle
                        aktiivinenAuto = int.Parse(input) - 1;
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
