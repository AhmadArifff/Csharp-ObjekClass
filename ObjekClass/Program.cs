using System;

namespace ObjekClass
{
    class Program
    {
        static Timer T = new Timer();
        static Triangle C = new Triangle();
        static void Main(string[] args)
        {
            T.Hours = 2;
            Console.WriteLine("***************Class Time***************\nHours : " + T.Hours + "\nMinutes : " + T.Minute);
            C.CalculateArea();
            //Level myVar = Level.Medium;
            //switch (myVar)
            //{
            //}
        }
    }
    class Timer
    {
        private double seconds;
        public double Hours
        {
            get
            {
                return seconds / 3600;
            }
            set
            {
                seconds = (value % 24) * 3600;
            }
        }
        public double Minute
        {
            get
            {
                return seconds / 60;
            }
            set
            {
                seconds = value * 60;
            }
        }
    }
    class Triangle
    {
        private int jumlah;
        public int a    
        public int t { get; set; }
        public int CalculateArea()
        {
            return 1 / 2 * a * t;
            //tidak dipanggil
            //jumlah = 1 / 2 * a * t;
            //Console.WriteLine("Jumlah Volume Segitiga : " + jumlah);
        }
        public enum Level
        {
            Low, Medium, Hight = 300
        }
        public struct MHS
        {
            public string Nama;
            public string NPM;
        }
    }
}
