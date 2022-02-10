using System.Collections.Generic;
using Lab9;

namespace lab9;

public class Student
{
    public string imie { get; set; }
    public string nazwisko { get; set; }
    public int NrIndeksu { get; set; }
    public string wydzial { get; set; }
    public List<Ocena> oceny { get; set; }

    public Student(string imie, string nazwisko, int NrIndeksu, string wydzial)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.NrIndeksu = NrIndeksu;
        this.wydzial = wydzial;
        oceny = new List<Ocena>();
    }

    public Student() : this("", "", 0, "")
    {
    }

    public Student(string imie, string nazwisko, int NrIndeksu, string wydzial, List<Ocena> oceny)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.NrIndeksu = NrIndeksu;
        this.wydzial = wydzial;
        this.oceny = oceny;
    }
}

public class Ocena
{
    public string przedmiot { get; set; }
    public double wartosc { get; set; }

    public Ocena(string przedmiot, double wartosc)
    {
        this.przedmiot = przedmiot;
        this.wartosc = wartosc;
    }

    public Ocena() : this("", 0)
    {
    }
}