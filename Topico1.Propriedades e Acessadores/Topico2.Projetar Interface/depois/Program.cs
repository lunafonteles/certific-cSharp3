using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico2
{
    class Program
    {
        static void Main(string[] args)
        {
            IEletrodomestico eletro1 = new Televisao();
            IEletrodomestico eletro2 = new Abajur();
            IEletrodomestico eletro3 = new Lanterna();
            IEletrodomestico eletro4 = new Radio();

            eletro1 = new Abajur();
            eletro2 = new Televisao();
            eletro3 = new Radio();
            eletro4 = new Lanterna();
        }
    }
     
    interface IEletrodomestico
    {
        event EventHandler Ligou;
        event EventHandler Desligou;
        void Ligar();
        void Desligar();
    }

    interface IIluminacao
    {
        double PotenciaDaLampada { get; set; }

    }

    interface IFrequencia
    {
        double Frequencia { get; set; }

    }

    class Televisao : IEletrodomestico, IFrequencia
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public double Frequencia { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
            if (Ligou != null)
            {
                Ligou(this, new EventArgs());
            }
        }
    }

    class Abajur : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Lanterna : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Radio : IEletrodomestico, IFrequencia
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public double Frequencia { get; set; }

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

}
