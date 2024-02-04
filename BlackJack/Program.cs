using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Deck = new int[]
            {
                6 , 7, 8 , 9 , 10, //- цифры
                2 , 3 , 4 , 11, //- картинки

                //6 , 7, 8 , 9 , 10, //- цифры
                //2 , 3 , 4 , 11, //- картинки

                //6 , 7, 8 , 9 , 10, //- цифры
                //2 , 3 , 4 , 11, //- картинки

                //6 , 7, 8 , 9 , 10, //- цифры
                //2 , 3 , 4 , 11, //- картинки
            };
            //int[] deck = new int[] { 1, 2, 3, 4, };
            Deck = Shuffle(Deck);          
          

            for (int i = 0; i < Deck.Length; i++)
            {
                Console.WriteLine(Deck[i]);
            }
            Console.WriteLine();
            //Deck = Shuffle(Deck);


            //for (int i = 0; i < Deck.Length; i++)
            //{
            //    Console.WriteLine(Deck[i]);
            //}
            //Deck = Shuffle(Deck);
            //Console.WriteLine();

            //for (int i = 0; i < Deck.Length; i++)
            //{
            //    Console.WriteLine(Deck[i]);
            //}

            //bool isPlayerAction = true;
            //bool isComputerAction = true;

            Random rng = new Random();
            

            //do
            //{
            //    isPlayerAction = Playa(isPlayerAction);
            //    isComputerAction = Comp(ref isComputerAction, rng);

            //}
            //while (isPlayerAction || isComputerAction);
             

            
        }

        private static int[] Shuffle(int[] deck)
        {
            int[] usedIndex = new int[deck.Length];
            for (int i = 0; i < usedIndex.Length; i++)
            {
                usedIndex[i] = -1;
            }

            int[] result = new int[deck.Length];

            Random rng = new Random();

            

            

            for (int i = 0; i < deck.Length; i++)
            {
                int index = 0;

                do
                {
                    index = rng.Next(0, deck.Length);
                }
                while (Contain(usedIndex, index));
                
                result[i] = deck[index];

                usedIndex[i] = index;
            }
            return result;
        }

        private static bool Contain(int [] values , int value)
        {

            for (int i = 0; i < values.Length; i++)
            {
                if(values[i] == value)
                {
                    return true;
                }
                
            }
            return false;
        }

        private static bool Comp(ref bool isComputerAction, Random rng)
        {
            int Decision = 0;
            if (isComputerAction)
            {
                Decision = rng.Next(0, 2);

            }
            if (Decision == 0)
            {
                Console.WriteLine("Dealer pull the card");
            }
            if (Decision == 1)
            {
                Console.WriteLine("Dealer check");
                isComputerAction = false;
            }
            return isComputerAction;
        }

        private static bool Playa(bool isPlayerAction)
        {
            Console.WriteLine("Do you pull the card? y/n");
            string oklik = Console.ReadLine();

            if (oklik == "y")
            {
                Console.WriteLine("You pull the card");
            }
            if (oklik == "n")
            {
                Console.WriteLine("You check");
                isPlayerAction = false;
            }

            return isPlayerAction;
        }
    }
}
