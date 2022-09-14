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

        public string Nimi { get; set; }

        // nimi
        // merkki
        // malli
        // id 0..1...2..

        // method / function => toiminnallisuus

        // static => voidaan käyttää ilman, että luokasta
        // on luotu objekti

        public Ajoneuvo(string nimi) // constructor. kun luodaan luokasta objekti
        {
            Polttoaineenmaara = 5; // oletusarvot
            Polttoainetankki = 50;
            Keskikulutus = 7.8;
            Nimi = nimi;
        }

        public void Tankkaus()
        {
            double polttoaineenHinta = 1.88; // euroa

            // tankin tilavuus - tämän hetken polttoaine
            // = puuttuva polttoaine

            double puuttuvaPolttoaine = Polttoainetankki -
                Polttoaineenmaara;
            Console.WriteLine($"Polttoainetta tankattu: " +
                $"{puuttuvaPolttoaine}");
            Polttoaineenmaara = Polttoainetankki;
            // määritellään polttoaineen määräksi sama kuin
            // polttoainetankin maksimi tilavuus

            // Lasketaan tankatun polttoaineen hinta ja
            // ilmoitetaan käyttäjälle

            double hinta = puuttuvaPolttoaine * polttoaineenHinta;
            Console.WriteLine($"Tankkauksen hinta: {hinta}");

        } // Tankkaus() päättyy

        public void Ajo(double kilometrit)
        {
            // laske matkalla kuluva polttoaine
            double kulunutPolttoaine = kilometrit / 100 * Keskikulutus;
            // kaava: kilometrit / 100 * keskikulutus (L/100km)
            // päivitä polttoaineenmäärä ajoneuvossa
            Polttoaineenmaara = Polttoaineenmaara - kulunutPolttoaine;
            // ilmoita käyttäjälle kulunut polttoaine
            Console.WriteLine($"Polttoainetta kului: {kulunutPolttoaine}");
            Console.WriteLine($"Polttoainetta on jäljellä: {Polttoaineenmaara}");
        }
    }
}
