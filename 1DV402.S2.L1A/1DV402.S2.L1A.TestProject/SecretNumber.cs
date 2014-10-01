using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {
        private int _number;

        private int _count; 

        public const int MaxNumberOfGuesses = 7;

        public SecretNumber()
        {
            Initialize();
        }
        public void Initialize()
        {
            int count = 0;
            _count = count;          
            Random myRandom = new Random();
            int number = myRandom.Next(1, 101);
            _number = number;
        }
        public bool MakeGuess(int number) 
        {
            number = _number;
            _count++;
            Console.WriteLine(string.Format("Gissning {0}:", _count));
            number = int.Parse(Console.ReadLine()); 
            if(number < _number)
            {
                Console.WriteLine(string.Format("{0} är för lågt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count)));
            }
            if (number > _number)
            {
                Console.WriteLine(string.Format("{0} är för högt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count)));
            }
            if (number == _number)
            {
                Console.WriteLine(string.Format("RÄTT GISSAT. Du klarade det på {0} försök. ", number, (MaxNumberOfGuesses - _count)));
                return true;
            }
            if (_count > MaxNumberOfGuesses) 
            {
                if (number < _number)
                {
                    Console.WriteLine(string.Format("{0} är för lågt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count)));
                    Console.WriteLine("Det hemliga talet är ", _number);
                }
                if (number > _number)
                {
                    Console.WriteLine(string.Format("{0} är för högt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count)));
                    Console.WriteLine("Det hemliga talet är ", _number);
                }
            }
            return false;
        }
    }
}
