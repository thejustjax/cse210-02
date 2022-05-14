using System;

namespace unit02_hilo
{
    class Card
    {
        public int cardValue;

        public void getNewCard(){
            Random randomGenerator = new Random();
            cardValue = randomGenerator.Next(1,14);
        }
    }
}