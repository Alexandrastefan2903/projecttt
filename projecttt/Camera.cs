using System;
using System.Collections.Generic;

namespace projecttt
{
    [Serializable]
    class Camera : ICloneable, IComparable
    {
        public int NumarCamera { get; set; }
        public int PretPeNoapte { get; set; }
        public bool Disponibilitate { get; set; }
        private List<Rezervare> listaRezervari;

        public Camera(int numarCamera)
        {
            NumarCamera = numarCamera;
            if (numarCamera <= 5)
            {
                PretPeNoapte = 100;
            }
            else
            {
                PretPeNoapte = 150;
            }
            Disponibilitate = true;
            listaRezervari = new List<Rezervare>();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Camera otherCamera = obj as Camera;
            if (otherCamera != null)
                return this.NumarCamera.CompareTo(otherCamera.NumarCamera);
            else
                throw new ArgumentException("Object is not a Camera");
        }

        public static bool operator <(Camera c1, Camera c2)
        {
            return c1.NumarCamera.CompareTo(c2.NumarCamera) < 0;
        }

        public static bool operator >(Camera c1, Camera c2)
        {
            return c1.NumarCamera.CompareTo(c2.NumarCamera) > 0;
        }

        public bool Disponibila(DateTime dataCheckIn, DateTime dataCheckOut)
        {
            foreach (Rezervare rezervare in listaRezervari)
            {
                if (dataCheckIn >= rezervare.DataCheckIn && dataCheckIn < rezervare.DataCheckOut ||
                    dataCheckOut > rezervare.DataCheckIn && dataCheckOut <= rezervare.DataCheckOut)
                {
                    return false;
                }
            }
            return true;
        }

        public void AdaugaRezervare(Rezervare rezervare)
        {
            listaRezervari.Add(rezervare);
        }
    }
}
