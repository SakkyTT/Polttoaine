using System;
using System.Collections.Generic;
using System.Text;

namespace Polttoaine
{
    class Ajoneuvo
    {
        // property => data

        public double Polttoaineenmaara { get; set; }
        public double Polttoainetankki { get; set; }
        // lisää keskikulutus
        public double Keskikulutus { get; set; }
        public double AjetutKilometrit { get; set; }
        public string Nimi { get; set; }

        // method / function => toiminnallisuus

        // static => voidaan käyttää ilman, että luokasta
        // on luotu objekti

        public Ajoneuvo(string nimiParametri) // constructor. kun luodaan luokasta objekti
        {
            Polttoaineenmaara = 5; // oletusarvot
            Polttoainetankki = 50;
            Keskikulutus = 7.8;
            Nimi = nimiParametri;
        }

        public void Tankkaus()
        {
            double polttoaineenHinta = 1.88; // euroa

            // tankin tilavuus - tämän hetken polttoaine
            // = puuttuva polttoaine

            double puuttuvaPolttoaine = Polttoainetankki -
                Polttoaineenmaara;
            Console.WriteLine($"Polttoainetta tankattu: " +
                string.Format("{0:0.00}", puuttuvaPolttoaine));
            // 46.43453 => 46.43 || 45 => 45.00 || Math.Round
            //                                  || String.Format
            Polttoaineenmaara = Polttoainetankki;
            // määritellään polttoaineen määräksi sama kuin
            // polttoainetankin maksimi tilavuus

            // Lasketaan tankatun polttoaineen hinta ja
            // ilmoitetaan käyttäjälle

            double hinta = puuttuvaPolttoaine * polttoaineenHinta;
            Console.WriteLine($"Tankkauksen hinta: " +
                string.Format("{0:0.00}", hinta));

        } // Tankkaus() päättyy

        public void Ajo(double kilometrit)
        {
            AjetutKilometrit += kilometrit;
            // laske matkalla kuluva polttoaine
            double kulunutPolttoaine = kilometrit / 100 * Keskikulutus;
            // kaava: kilometrit / 100 * keskikulutus (L/100km)
            // päivitä polttoaineenmäärä ajoneuvossa
            Polttoaineenmaara = Polttoaineenmaara - kulunutPolttoaine;
            // ilmoita käyttäjälle kulunut polttoaine
            Console.WriteLine($"Polttoainetta kului:" +
                string.Format("{0:0.00}", kulunutPolttoaine));
            Console.WriteLine($"Polttoainetta on jäljellä:" +
                string.Format("{0:0.00}", Polttoaineenmaara));
        } // Päättyy Ajo() - Aloita uusi metodi tämän jälkeen

        public void NaytaKilometrit()
        {
            Console.WriteLine($"Ajetut kilometrit: {AjetutKilometrit}");
        }
    }
}
