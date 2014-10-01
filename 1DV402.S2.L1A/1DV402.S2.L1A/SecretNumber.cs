using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    class SecretNumber
    {
        public const int MaxNumberOfGuesses = 7;

        private int _number;
        private int _count;

        public SecretNumber()
        {
            Initialize();
        }

        public void Initialize()
        {
            _count = 0;
            Random myRandom = new Random();
            _number = myRandom.Next(1, 101);
        }

        public bool MakeGuess(int number) 
        {
            if (_count >= MaxNumberOfGuesses)
            {
                throw new ApplicationException();
            }

            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }

            _count++;

            if (number == _number)
            {
                Console.WriteLine("RÄTT GISSAT. Du klarade det på {0} försök. ", _count);
                return true;
            }

            if (number < _number)
            {
                Console.WriteLine("{0} är för lågt. Du har {1} gissningar kvar.", number, MaxNumberOfGuesses - _count);
            }
            else
            {
                Console.WriteLine("{0} är för högt. Du har {1} gissningar kvar.", number, MaxNumberOfGuesses - _count);
            }

            if (_count == MaxNumberOfGuesses)
            {
                Console.WriteLine("Det hemliga talet är ", _number);
            }
    
            return false;
        }
    }
}
