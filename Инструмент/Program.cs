using System;
namespace Инструмент
{
    interface Instrument
    {
        void play();
    }
    class Guitar: Instrument
    {
        int colvostrings;
        public void play()
        {

        }
    }
    class Drum: Instrument
    {
        int size;
        public void play()
        {

        }
    }
    class Trumpet: Instrument
    {
        int diameter;
        public void play()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Guitar guitar = new Guitar();
            Drum drum = new Drum();
            Trumpet trumpet = new Trumpet();
            string KEY = "До мажор";
            Instrument[] massiv = { };
            foreach (Instrument i in massiv)
            {
                guitar.play();
                drum.play();
                trumpet.play();
            }
        }
    }
}