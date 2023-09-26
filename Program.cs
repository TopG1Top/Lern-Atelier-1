
using System.Text.RegularExpressions;


var words = new[]
{
    "coffee",
    "banana",
    "airport",
    "cryptography",
    "computer",
};

.
var chosenWord = words[new Random().Next(0, words.Length - 1)];


var validCharacters = new Regex("^[a-z]$");


var lives = 5;


var letters = new List<string>();


while (lives != 0)
{
    
    var charactersLeft = 0;

    
    foreach (var character in chosenWord)
    {
        
        var letter = character.ToString();

       
        if (letters.Contains(letter))
        {
            Console.Write(letter);
        }
        else
        {
            Console.Write("_");

            
            charactersLeft++;
        }
    }
    Console.WriteLine(string.Empty);

    
    if (charactersLeft == 0)
    {
        break;
    }

    Console.Write("Type in a letter: ");

     
    var key = Console.ReadKey().Key.ToString().ToLower();
    Console.WriteLine(string.Empty);

   
    if (!validCharacters.IsMatch(key))
    {
        
        Console.WriteLine($"The letter {key} is invalid. Try again.");
        continue;
    }

     
    if (letters.Contains(key))
    {
        
        Console.WriteLine("You already entered this letter!");
        continue;
    }

    
    letters.Add(key);

    
    if (!chosenWord.Contains(key))
    {
        lives--;

       
        if (lives > 0)
        {
           
            Console.WriteLine($"The letter {key} is not in the word. You have {lives} {(lives == 1 ? "try" : "tries")} left.");
        }
    }
}


if (lives > 0)
{
    .
    Console.WriteLine($"You won with {lives} {(lives == 1 ? "life" : "lives")} left!");
}
else
{
    Console.WriteLine($"You lost! The word was {chosenWord}.");
}