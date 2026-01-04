// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("The current date and time is " + DateTime.Now);
Console.WriteLine("Hello, World! I'm Steve Masira. Nice to meet you here.");
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first line of code!");
Console.WriteLine();
Console.WriteLine("Congratulations!");
Console.Write("You wrote your first line of code!");
Console.WriteLine();
Console.WriteLine("This is the first line.");
Console.Write("This is the second line.");
Console.WriteLine();
Console.WriteLine("==========================================================");
Console.WriteLine("New Topic");
Console.WriteLine("==========================================================");
//New Topic starts here

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{  
    total += 2;
    Console.WriteLine("You rolled doubles! +2 bonus added to your total!");
    Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} + 2 = {total}");
    
}
if((roll1 == roll2) && (roll2 == roll3))
{
    total += 6;
    Console.WriteLine("You rolled tripples! +6 bonus to total!");
    Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} + 6 = {total}");
}

if(total >= 15)
{
    Console.WriteLine("You win!!!");
}

if (total < 15)
{
    Console.WriteLine("Sorry! You loose.");
}

string message = "The quick brown fox, jumps over the lazy dog";

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}
