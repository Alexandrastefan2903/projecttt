using System;
using System.Collections.Generic;

[Serializable]
class Client : ICloneable, IComparable
{
    private string nume;
    private string prenume;
    private string telefon;
    private string email;
    private List<Rezervare> rezervari = new List<Rezervare>();

    public Client(string nume, string prenume, string telefon, string email)
    {
        this.nume = nume;
        this.prenume = prenume;
        this.telefon = telefon;
        this.email = email;
    }

    public string Nume
    {
        get { return nume; }
        set { nume = value; }
    }
    public string Telefon
    {
        get { return telefon; }
        set { telefon = value; }
    }
    public string Prenume
    {
        get { return prenume; }
        set { prenume = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }

    public int CompareTo(object obj)
    {
        if (obj == null) return 1;

        Client otherClient = obj as Client;
        if (otherClient != null)
            return this.Nume.CompareTo(otherClient.Nume);
        else
            throw new ArgumentException("Object is not a Client");
    }

    public static bool operator <(Client c1, Client c2)
    {
        return c1.Nume.CompareTo(c2.Nume) < 0;
    }

    public static bool operator >(Client c1, Client c2)
    {
        return c1.Nume.CompareTo(c2.Nume) > 0;
    }

    public void AdaugaRezervare(Rezervare rezervare)
    {
        rezervari.Add(rezervare);
    }
}

