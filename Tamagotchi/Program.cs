using System.Threading;
using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi tama = new Tamagotchi();
            
            
            
            TimeDelta();
            Console.ReadLine();
        }
        static float TimeSinceLastRun;
        static public float TimeDelta(){
            DateTime time1 = DateTime.Now;
            DateTime time2 = DateTime.Now;
            time2 = DateTime.Now;
            float deltaTime = (time2.Ticks - time1.Ticks) / 10000000f; 
            //Console.WriteLine(deltaTime);  // *float* output {0,2493331}
            //Console.WriteLine(time2.Ticks - time1.Ticks); // *int* output {2493331}
            time1 = time2;
            
            
            return deltaTime;
        }
    }
}
