using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private int hunger = 0;
        private int boredom = 0;
        private List<string> words = new List<string>();
        private bool isAlive = true;
        static private Random generator = new Random();
        public string name;

        Tamagotchi(){
            
        }

        public void Tick(){

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
