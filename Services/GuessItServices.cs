namespace ARobinsonMC5Eight2Ten_EndPnt.Services
{
    public class GuessItServices
    {
        Random generate = new Random();
        public string goGuessIt(int guessInt, int min, int max)
        {

            int correctNum = generate.Next(min, max);
            if(guessInt < min || guessInt > max)
            {
                return "This value is outside of the number range";
            } else if(guessInt < correctNum)
            {
                return "Your guess is less than the correct number.";
            }else if(guessInt > correctNum)
            {
                return "Your guess is greater than the correct number.";
            }else if (guessInt == correctNum)
            {
                return "You guessed the right number!";
            }
            return "Your answer is invalid.";
        }
    }
}