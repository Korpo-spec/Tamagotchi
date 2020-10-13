using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        float hunger = 0;
        float boredom = 0;
        List<string> words = new List<string>();
        bool isAlive = true;
        static private Random generator = new Random();
        public string name;

        public Tamagotchi(){
            
        }

        public void Tick(){
            boredom += 0.2f;
            hunger += 0.1f;

            if(boredom > 10 || hunger > 10){
                isAlive = false;
            }
            Draw(boredom, "Boredom");
            Draw(hunger, "Hunger");
        }

        void Draw(float input, string NameOfVariable){
            Console.Clear();
            Console.Write(NameOfVariable + ": ");
            Console.Write("[");
            float runs = (10f - input) * 5;
            
            string dots = "";
            for (float i = 0; i < runs; i++)
            {
                dots += ".";
            }
            string commas = "";
            for (int i = 0; i < input*5; i++)
            {
                commas += ",";
            }
            Console.Write(dots);
            Console.Write(commas);
            Console.WriteLine("]");


        }

        public void Feed(){

        }
        
        public void Hi(){

        }

        public void Teach(string word){

        }

        public void PrintStats(){

        }

        public bool GetAlive(){

            return isAlive;
        }

        private void ReduceBoredom(){


            
        }
    }
}
