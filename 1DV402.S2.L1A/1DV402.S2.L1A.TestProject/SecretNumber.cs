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
        public void Initialize()
        {
            _count = 0;          
            Random myRandom = new Random();
            _number = myRandom.Next(1, 101);
        }
        public SecretNumber()
        {
            Initialize();
        }
        public bool MakeGuess(int number) 
        {
            if (_count > (MaxNumberOfGuesses - 1))
            {
                Initialize();
                throw new ApplicationException();
            }
            else 
            {
                _count++;
            }
            if (number < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number < _number)
            {
                Console.WriteLine(string.Format("{0} är för lågt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count)));
                return false;
            }
            if (number > _number)
            {
                Console.WriteLine(string.Format("{0} är för högt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count)));
                return false;
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
                    return false;
                }
                if (number > _number)
                {
                    Console.WriteLine(string.Format("{0} är för högt. Du har {1} gissningar kvar.", number, (MaxNumberOfGuesses - _count)));
                    Console.WriteLine("Det hemliga talet är ", _number);
                    return false;
                }
            }
            return false;
        }
    }
}
