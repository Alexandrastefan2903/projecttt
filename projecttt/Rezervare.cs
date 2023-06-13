using projecttt;
using System;

[Serializable]
class Rezervare
{
    // Atributele clasei
    private Client client;
    private Camera camera;
    public DateTime dataCheckIn;
    public DateTime dataCheckOut;

    // Constructorul
    public Rezervare(Client client, Camera camera, DateTime dataCheckIn, DateTime dataCheckOut)
    {
        this.client = client;
        this.camera = camera;
        this.dataCheckIn = dataCheckIn;
        this.dataCheckOut = dataCheckOut;
    }

    // Proprietati pentru atributele declarate private
    public Client Client
    {
        get { return client; }
        set { client = value; }
    }
    public Camera Camera
    {
        get { return camera; }
        set { camera = value; }
    }
    public DateTime DataCheckIn
    {
        get { return dataCheckIn; }
        set { dataCheckIn = value; }
    }

    public DateTime DataCheckOut
    {
        get { return dataCheckOut; }
        set { dataCheckOut = value; }
    }

    // Metoda de prelucrare a datelor din clasa
    public int CalculeazaNumarNopti()
    {
        TimeSpan durata = DataCheckOut - DataCheckIn;
        return durata.Days;
    }

    public double PretTotal(int numarNopti)
    {
        return numarNopti * Camera.PretPeNoapte;
    }
}
