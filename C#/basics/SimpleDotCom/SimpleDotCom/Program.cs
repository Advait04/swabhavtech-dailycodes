using System;
class SimpleDotCom
{
    int[] locationsCells;
    int numOfHits = 0;
    public void setLocationCells(int[] locs)
    {
        locationsCells = locs;
    }
    public String checkYourself(String stringGuess)
    {
        int guess = int.Parse(stringGuess);
        String result = "miss";
        foreach (int cell in locationsCells)
        {
            if (guess == cell)
            {
                result = "hit";
                numOfHits++;
                break;
            }
        }
        if (numOfHits == locationsCells.Length)
        {
            result = "kill";
        }
        Console.WriteLine(result);
        return result;

    }
}
class GameHelper
{
    public String getUserInput(String prompt)
    {
        String inputLine = null;
        Console.WriteLine(prompt + " ");
        try
        {

            inputLine = Console.ReadLine();
            if (inputLine.Length == 0)
            {
                return null;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("IOException: " + e);
        }
        return inputLine;
    }


}
public class SimpleDotComTest
{
    public static void Main(String[] args)
    {
        int numOfGuesses = 0;
        GameHelper helper = new GameHelper();
        SimpleDotCom dot = new SimpleDotCom();
        Random random = new Random();

        string result;
        int randomNum = random.Next(1, 5);
        int[] locations = { randomNum, randomNum + 1, randomNum + 2 };
        dot.setLocationCells(locations);
        bool isAlive = true;
        while (isAlive == true)
        {
            String guess = helper.getUserInput("Enter a number:");
            result = dot.checkYourself(guess);
            numOfGuesses++;
            if (result.Equals("kill"))
            {
                isAlive = false;
            }
        }
        Console.WriteLine(" You took " + numOfGuesses + " guesses ");
        int[] locations1 = { 2, 3, 4 };
        dot.setLocationCells(locations1);
        String userGuess = "  ";
        result = dot.checkYourself(userGuess);
        String testResult = "failed";
        if (result.Equals("hit"))
        {
            testResult = "passed";
        }
        Console.WriteLine(testResult);
    }
}