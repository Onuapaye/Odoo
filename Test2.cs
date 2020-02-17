using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdooTest
{
    public class Test2
    {
        // a random object to genere secrete code or integers
        Random random = new Random();
        int secretNumber;
        int tempValue;
        int guessCount = 1; //default set to 1
        const int guessLimit = 50;
        int results;

        public void GuessGame()
        {
            // a constant to hold the maximum number of secret values
            const int maximumSecreteInteger = 1000000;
            secretNumber = random.Next(1, maximumSecreteInteger);

            // the guess number is divided into two for optimization purpose
            int guessNumber = maximumSecreteInteger / 2;

            tempValue = guessNumber;

            while (guessCount < guessLimit)
            {
                int check = this.Verify(guessNumber);

                if (tempValue < 2)
                {
                    tempValue *= 2; // tempValue = tempValue * 2;
                } else
                {
                    tempValue /= 2;
                }

                //tempValue = Math.Ceiling(Decimal.TryParse(tempValue.ToString(), out Decimal temp));

                if (check == 1)
                {
                    guessNumber -= tempValue;
                }
                else if (check == -1)
                {
                    guessNumber += tempValue;
                }
                else if (check == 0)
                {
                    Console.WriteLine(String.Format("Bravo! you have won\nGuess Number :: {0},\nGuess Times :: {1}, ", guessNumber, guessCount ));
                    break;
                }

                guessCount += 1;
            }
            
        }

        private int Verify(int guess)
        {

            // check if the guess value passed is integer or string
            bool guessPassed = int.TryParse(guess.ToString(), out int guessReceived);
            if (guessPassed)
            {
                if(guess > secretNumber)
                {
                    results = 1;
                } else if(guess < secretNumber)
                {
                    results = -1;

                } else if (guess == secretNumber)
                {
                    results = 0;
                }

            }
            else
            {
                Console.WriteLine("Invalid Guess value entered");
            }

            return results;
        }

   
    }
}
