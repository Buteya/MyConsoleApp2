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
{  if((roll1 == roll2) && (roll2 == roll3))
{
    total += 6;
    Console.WriteLine("You rolled tripples! +6 bonus to total!");
    Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} + 6 = {total}");
    }
    else
    {
  total += 2;
    Console.WriteLine("You rolled doubles! +2 bonus added to your total!");
    Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} + 2 = {total}");
    }
    }





if (total >= 16)
{
    Console.WriteLine("You win a car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
} else
{
    Console.WriteLine("You win a kitten!!!");
}

    string message = "The quick brown fox, jumps over the lazy dog";

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

// new code 
Console.WriteLine("===================================================");
Console.WriteLine("new code");
Console.WriteLine("===================================================");
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
Console.WriteLine(daysUntilExpiration);
if(daysUntilExpiration < 10 && daysUntilExpiration > 5 )
{
    Console.WriteLine("Your subscription will expire soon. Renew now!!!");
}else if (daysUntilExpiration <= 5 && daysUntilExpiration > 1)
{
    discountPercentage += 10;
    Console.WriteLine($"Your subscription expires in {11 - daysUntilExpiration}days.");    
} else if(daysUntilExpiration == 1)
{ 
    discountPercentage += 20;
    Console.WriteLine("Your subscription expires in a day"); 
}else if(daysUntilExpiration < 1)
{
    Console.WriteLine("Your subscription has expired");
}

if(discountPercentage == 10)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%");
}else if(discountPercentage == 20)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%");
}
