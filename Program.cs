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
Console.WriteLine("===================================================");
Console.WriteLine("new code");
Console.WriteLine("===================================================");

/*string[] fraudulentOrderIds = new string[3];

fraudulentOrderIds[0] = "A123";
fraudulentOrderIds[1] = "B456";
fraudulentOrderIds[2] = "C789";
//fraudulentOrderIds[3] = "D000";*/

string[] fraudulentOrderIds = ["A123", "B456", "C789"];

Console.WriteLine($"First: {fraudulentOrderIds[0]}");
Console.WriteLine($"Second: {fraudulentOrderIds[1]}");
Console.WriteLine($"Third: {fraudulentOrderIds[2]}");

fraudulentOrderIds[0] = "F000";

Console.WriteLine($"Reassign firsr: {fraudulentOrderIds[0]}");
Console.WriteLine($"There are {fraudulentOrderIds.Length} fraudulent orders to process");

string[] names = { "Rowena", "Robin", "Bao" };

foreach(string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700,175, 250 };
int sum = 0;
int bin = 0;

foreach(int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in the inventory.");

string Name = "Bob";
if (Name.StartsWith('B'))
{
    Console.WriteLine($"The name {Name} starts with [B]!");
}

string[] orderIds = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach(string id in orderIds)
{
    if (id.StartsWith('B'))
    {
        Console.WriteLine(id);
    }
}

Console.WriteLine("==================================================================");
Console.WriteLine("new code");
Console.WriteLine("==================================================================");

/*string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");*/

/*
 * The following code creates five random order ids
 * to test the fraud detection process. Order ids consist of 
 * a letter from A to E, and a three digit number. Ex. A123.
 */
Random newRandom = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = newRandom.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = newRandom.Next(1, 1000).ToString("000");
    orderIDs[i] = prefix + suffix;
}

foreach(string orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

//example 1
Console
.
WriteLine
(
"Hello example 1!"
)
;

//example 2
string firstWord = "Hello";string secondWord = "example 2!";Console.WriteLine(firstWord + " " + secondWord);
/*
 * this code takes a message and coverts it into a character array.
 * then reverses it, counts the number a character appears and converts it back to a string.
 */
string originalMessage = "The quick brown fox jumps over the lazy dog";
char[] characterMessage = originalMessage.ToCharArray();

Array.Reverse(characterMessage);

int letterCount = 0;

foreach (char letter in characterMessage) 
{ 
    if (letter == 'o')
    {
        letterCount++; 
    }
};

string new_message = new String(characterMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {letterCount} times");

Console.WriteLine("=======================================================");
Console.WriteLine("new code");
Console.WriteLine("=======================================================");
int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScore = new int[10];
string currentStudentLetterGrade = "";


Console.WriteLine("Student\t\tExam Score\tOveral\tGrade\tExtra Credit");

foreach(string name in studentNames)
{
    string currentStudent = name; ;
    if (currentStudent == "Sophia")
        studentScore = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScore = andrewScores;
    else if (currentStudent == "Emma")
        studentScore = emmaScores;
    else if (currentStudent == "Logan")
        studentScore = loganScores;
    else if (currentStudent == "Becky")
        studentScore = beckyScores;
    else if (currentStudent == "Chris")
        studentScore = chrisScores;
    else if (currentStudent == "Eric")
        studentScore = ericScores;
    else if (currentStudent == "Gregor")
        studentScore = gregorScores;
    else
        continue;

    int sumAssignmentScores = 0;
    int examScore = 0;
    int extraCredit = 0;
        decimal currentStudentGrade = 0;
    decimal currentStudentExamScore = 0;
    decimal currentStudentExtraCredit = 0;

    int gradeAssignments = 0;
    foreach (int score in studentScore) 
        {
        gradeAssignments += 1;
        if (gradeAssignments <= examAssignments) {
            sumAssignmentScores += score;
            examScore += score;
        }
        else
        {
           sumAssignmentScores += score / 10;
            if(gradeAssignments > examAssignments)
                extraCredit += score;
        }
           
           
        }

        currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;
    currentStudentExamScore = (decimal)examScore / examAssignments;
    currentStudentExtraCredit = (decimal)extraCredit / (studentScore.Length - examAssignments);

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{name}:\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCredit} ({(extraCredit * 10/100m)/5} pts)");
    
}

Console.WriteLine("Press the enter key to continue");
Console.ReadLine();
Console.WriteLine("========================================================");
Console.WriteLine("new code");
Console.WriteLine("========================================================");
Console.WriteLine("a" == "a");
Console.WriteLine("A" == "a");
Console.WriteLine(1 == 2);
string myName = "a";
Console.WriteLine(myName == "a");
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
Console.WriteLine("a" != "a");
Console.WriteLine("A" != "a");
Console.WriteLine(1 != 2);
string myValue = "a";
Console.WriteLine(myValue != "a");
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);
string pangram = "The quick brown fox jumos over the lazy dog";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
int a = 6;
int b = 7;
Console.WriteLine(a != b);
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2);
Console.WriteLine("=========================================================");
Console.WriteLine("new code");
Console.WriteLine("=========================================================");
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");
Console.WriteLine("=========================================================");
Console.WriteLine("new code");
Console.WriteLine("=========================================================");
Random chance = new Random();
int nextChance = chance.Next(1, 3);
Console.WriteLine(nextChance == 1 ? "heads":"tails");
Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");
Console.WriteLine("=========================================================");
Console.WriteLine("new code");
Console.WriteLine("=========================================================");
String permissions = "Admin|Manager";
int level = 55;
if(permissions.Contains("Admin") && level > 55)
{
    Console.WriteLine("Welcome, Auper Admin user");
} else if(permissions.Contains("Admin") && level <= 55)
{
    Console.WriteLine("Welcome, Admin user");
} else if(permissions.Contains("Manager") && level >= 20)
{
    Console.WriteLine("Contact admin for help");
} else if(permissions.Contains("Manager") && level < 20)
{
    Console.WriteLine("You don't have sufficient privilages");
}
else
{
    Console.WriteLine("You don't have sufficient privilages");
}
Console.WriteLine("==========================================================");
Console.WriteLine("new code");
Console.WriteLine("==========================================================");
bool flag = true;
int value = 6;
if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}
Console.WriteLine($"Outside the code block: {value}");
Console.WriteLine("===========================================================");
Console.WriteLine("new code");
Console.WriteLine("===========================================================");
int employeeLevel = 100;
string employeeName = "John Smith";
string title = "";

switch (employeeLevel) {
    // for case 100 and 200 both to represent senior associate
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}
Console.WriteLine($"{employeeName} {title}");
Console.WriteLine("====================================================");
Console.WriteLine("new code");
Console.WriteLine("====================================================");
//SKU = Stock Keeping Unit
//SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0]) {
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "other";
        break;
}
switch (product[1]) {
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}
switch (product[2]) {
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}
Console.WriteLine($"product: {size} {color} {type}");
Console.WriteLine("==================================================");
Console.WriteLine("new code");
Console.WriteLine("==================================================");
Console.Write("{i e R: 0 <= i >= 10} ");
for(int i = 0; i <= 10; i++)
{
   
    Console.Write(i);
}
Console.WriteLine();
string[] firstnames = { "michael", "David", "Cain", "Joshua" };
for(int i = 0;i < firstnames.Length; i++)
{
    Console.WriteLine(firstnames[i]);
}
Console.WriteLine("===================================================");
Console.WriteLine("new code");
Console.WriteLine("===================================================");
for(int i = 1; i <= 100; i++)
{        
    if(i % 3 == 0)
        {
        if (i % 5 == 0)
        {
            Console.WriteLine($"{i} - FizzBuzz");
            continue;
        }
        Console.WriteLine($"{i} - Fizz");
        }
        else if(i % 5 == 0)
        {
            Console.WriteLine($"{i} - Buzz");
        }
    else
    {
        Console.WriteLine(i);
    }    
}

Console.WriteLine("========================================================");
Console.WriteLine("new code");
Console.WriteLine("========================================================");
Random numberRandom = new Random();
int currentNumber = 0;
/*do {
    currentNumber = numberRandom.Next(1, 11);
     if(currentNumber >= 8)
        continue;
    Console.WriteLine(currentNumber);
} while (currentNumber != 7);

*/
while(currentNumber >= 3)
{
    Console.WriteLine(currentNumber);
    currentNumber = numberRandom.Next(1, 11);
}
Console.WriteLine($"Last number: {currentNumber}");
Console.WriteLine("=========================================================");
Console.WriteLine("new code");
Console.WriteLine("=========================================================");
int heroHealth = 10;
int monsterHealth = 10;
Random randomAttack = new Random();

do
{
    int attack = randomAttack.Next(1, 11);  
    if (monsterHealth <= 0 || heroHealth <= 0) break;  
    monsterHealth -= attack;
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth} health.");
    if (monsterHealth > 0)
    {
        attack = randomAttack.Next(1, 11);
        heroHealth -= attack;
        Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health.");
    }
 
    
} while (monsterHealth >= 0 || heroHealth >= 0);
if(monsterHealth <= 0)
{
    Console.WriteLine("Hero wins!");
}
else
{
    Console.WriteLine("Monster wins!");
}


