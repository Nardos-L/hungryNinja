using System;

namespace hungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            //In your Program's Main method, instantiate a Buffet and Ninja object, and have the Ninja eat until they are full!
            Buffet myBuffet = new Buffet();
            Ninja  myNinja = new Ninja();
            while (!myNinja.IsFull)
            {
                myNinja.Eat(myBuffet.Serve());
            }
            
        }
    }
}
