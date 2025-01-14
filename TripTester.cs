using System;
using static System.Console;


namespace TripApp
{
    class TripTester
    {
        static void Main(string[] args)
        {
            Trip vacation01 = new Trip ("Chicago", 500m, 10m, 1500m);
            WriteLine(vacation01);
            Trip vacation02 = new Trip("New Orleans", 750m, 20m, 2205m);
            WriteLine(vacation02);
            ReadKey();
            
        }//end of Main
    }//end of class
}
