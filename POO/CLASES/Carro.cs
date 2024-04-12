using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.CLASES
{
    internal class Carro
    {
        public string Marca { get; }
        public string Modelo { get; }
        public int Año { get; }
        public string Transmision { get; }
        public string Color { get; set; }
        public string Owner { get; set; }

        public bool Encendido = false;
        public bool Seguro = false;
        public bool Alarma = false;

        public bool Parking = true;
        public bool Reverse = false;
        public bool Neutro = false;
        public bool Drive = false;


        public int Velocidad_Actual { get; set; }
        public int Velocidad_Max { get; set; }
        public int Velocidad_Max_Reversa { get; set; }


        string Cambios_Car = "";
        string Cambio_Actual = "P";

        public Carro (string marc, string mode, int año, string tran)
        {
            Marca = marc;
            Modelo = mode;
            Año = año;
            Transmision = tran;
            Velocidad_Max = 120;
            Velocidad_Max_Reversa = Velocidad_Max / 2;
        }

        public void Encender()
        {
            Encendido = true;

        }

        public void Apagar()
        {
            if (Encendido && Velocidad_Actual == 0 && Cambio_Actual == "P")
            {
                Encendido = false;
            }
        }

        public string Caja_Cambios()
        {
            Cambios_Car = Console.ReadLine().ToUpper();

            switch (Cambios_Car)
            {
                case "P":
                    return Cambio_Actual = "P";
                    break;

                case "R":
                    return Cambio_Actual = "R";
                    break;

                case "N":
                    return Cambio_Actual = "N";
                    break;

                case "D":
                    return Cambio_Actual = "D";
                    break;

                default:
                    return "Error";
            }
        }

        public int Acelerar()
        {
            if (!Encendido)
            {
                return Velocidad_Actual;
            }

            if (Encendido && Cambio_Actual == "D")
            {
                Velocidad_Actual += 15;

                if (Velocidad_Actual > Velocidad_Max)
                {
                    Velocidad_Actual = Velocidad_Max;
                }
                return Velocidad_Actual;
            }

            if (Encendido && Cambio_Actual == "R")
            {
                Velocidad_Actual += 10;

                if (Velocidad_Actual > Velocidad_Max_Reversa)
                {
                    Velocidad_Actual = Velocidad_Max_Reversa;
                }
                return Velocidad_Actual;
            }
            return Velocidad_Actual;
        }

        public int Frenar()
        {
            Velocidad_Actual -= Velocidad_Max;

            if (Velocidad_Actual <= 0)
            {
                return Velocidad_Actual = 0;
            }
            return Velocidad_Actual;
        }

        public int Desacelerar()
        {
            Velocidad_Actual -= 10;

            if (Velocidad_Actual <= 0)
            {
                return Velocidad_Actual = 0;
            }
            return Velocidad_Actual;
        }
    }
}