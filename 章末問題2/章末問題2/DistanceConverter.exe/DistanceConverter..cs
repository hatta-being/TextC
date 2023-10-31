using System;

namespace DistanceConverter.exe {
    class Program {
        static void Main(string[] args) {
            for (int feet = 1; feet <= 10; feet++) {
                double meter = feet * 0.3048;
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }
        static double FeetToMeter(int feet) {
            return feet * 0.3048;
        }
    }
}

