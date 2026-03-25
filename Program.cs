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
Console.WriteLine("=========================================================");
Console.WriteLine("new code");
Console.WriteLine("=========================================================");
Console.WriteLine("Enter a value between 5 and 10");
int valueInput;
do
{
    bool isValid;
    isValid = int.TryParse(Console.ReadLine(), out valueInput);
    if (isValid && !(valueInput >= 5 && valueInput <= 10))
        Console.WriteLine($"You entered {valueInput}, please enter a number between 5 and 10.");
    else if (!isValid)
        Console.WriteLine("Sorry you entered an invalid number, please try again.");
} while (!(valueInput>5 && valueInput<10));
if(valueInput>5 && valueInput < 10)
{
    Console.WriteLine($"Your input value ({valueInput}) has been accepted");
}


Console.WriteLine("Enter your role name (administrator, manager or user)");
String? inputToCheck; 
while(true)
{
    inputToCheck = Console.ReadLine()!.Trim();
    String checkInput = inputToCheck!.ToLower().Trim();
    if (checkInput == "administrator" || checkInput == "manager" || checkInput == "user")
    {
        Console.WriteLine($"Your input value ({inputToCheck}) has been accepted.");
        break;
    }
    else
    {
        Console.WriteLine($"The role name that you entered, \"{inputToCheck}\" is not valid. Enter your role name (administrator, manager, user)");
    }
}
String[] myStrings = new String[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
Console.WriteLine("===================================================");
Console.WriteLine("new code");
Console.WriteLine("===================================================");

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i) { 
    case 0:
    
        animalSpecies = "dog";
        animalID = "d1";
        animalAge = "2";
        animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
        animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
        animalNickname = "lola";
        break;
    case  1:
    
        animalSpecies = "dog";
        animalID = "d2";
        animalAge = "9";
        animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
        animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
        animalNickname = "loki";
        break;
    
    case 2:
    
        animalSpecies = "cat";
        animalID = "c3";
        animalAge = "1";
        animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
        animalPersonalityDescription = "friendly";
        animalNickname = "Puss";
        break;
    
    case  3:
    
        animalSpecies = "cat";
        animalID = "c4";
        animalAge = "?";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
        break;
    
     default: 
    
        animalSpecies = "";
        animalID = "";
        animalAge = "";
        animalPhysicalDescription = "";
        animalPersonalityDescription = "";
        animalNickname = "";
        break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options
do {


Console.Clear();

Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
Console.WriteLine(" 1. List all of our current pet information");
Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
Console.WriteLine(" 5. Edit an animal’s age");
Console.WriteLine(" 6. Edit an animal’s personality description");
Console.WriteLine(" 7. Display all cats with a specified characteristic");
Console.WriteLine(" 8. Display all dogs with a specified characteristic");
Console.WriteLine();
Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

readResult = Console.ReadLine();
if (readResult != null)
{
    menuSelection = readResult.ToLower();
}

//Console.WriteLine($"You selected menu option {menuSelection}.");
//Console.WriteLine("Press the Enter key to continue");

// pause code execution
//readResult = Console.ReadLine();
    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            readResult = Console.ReadLine();
            break;
        case "2":
            // Add a new animal friend to the ourAnimals array
            string anotherPet = "y";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                bool validEntry = false;

                // get species (cat or dog) - string animalSpecies is a required field 
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            //Console.WriteLine($"You entered: {animalSpecies}.");
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // get the pet's age. can be ? at initial entry.
                do
                {
                    int petAge;
                    Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");

                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do
                {
                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                        }
                    }
                } while (animalPersonalityDescription == "");

                // get the pet's nickname. animalNickname can be blank.
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                petCount = petCount + 1;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            break;


        case "3":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "4":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "5":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "6":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "7":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "8":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        default:
            break;
    }
   
} while (menuSelection != "exit");

Console.WriteLine("====================================");
Console.WriteLine("New Code");
Console.WriteLine("====================================");

Console.WriteLine("Signed integral types: ");
Console.WriteLine($"sbyte   : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short   : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long    : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue}  to {decimal.MaxValue} (with 28-29 digits of precision)");

int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value Types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");


int[] ref_A = new int[3];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;
Console.WriteLine("--Refrence Types--");
Console.WriteLine($"ref_A: {ref_A[0]}");
Console.WriteLine($"ref_B: {ref_B[0]}");

Console.WriteLine("=============================================");
Console.WriteLine("new code");
Console.WriteLine("=============================================");

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

int myInt = 3;
Console.WriteLine($"int: {myInt}");
decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}.");
decimal convertToInt = 3.14m;
Console.WriteLine($"decimal: {convertToInt}");
int convertedFromDecimal = (int)convertToInt;
Console.WriteLine($"int: {convertedFromDecimal}");

decimal convertToFloat = 1.23456789m;
float convertedDecimalToFloat = (float)convertToFloat;

Console.WriteLine($"decimal: {convertToFloat}");
Console.WriteLine($"float: {convertedDecimalToFloat}");

string valueString = "102";
int newResult = 0;
if(int.TryParse(valueString,out newResult))
{
    Console.WriteLine($"mesaurement: {newResult}");
}
else
{
    Console.WriteLine("unable to report the measurement.");
}
Console.WriteLine($"measurement (w/offset): {50 + newResult}");

decimal totalForValue = 0;
string messagesToAdd = "";
string[] valuesToChange = { "12.3","45","ABC","11","DEF" };
decimal parsvalue = 0;
    for (int i = 0; i < valuesToChange.Length; i++)
    {
        if (decimal.TryParse(valuesToChange[i], out parsvalue))
        {
        totalForValue += parsvalue;
        }
        else
        {
        messagesToAdd += valuesToChange[i];      
        }
    }

Console.WriteLine($"message: {messagesToAdd}");
Console.WriteLine($"total: {totalForValue}");

Console.WriteLine("================================================");
Console.WriteLine("new code");
Console.WriteLine("================================================");

string[] pallets = { "B14","A11","B12","A13"};
Console.WriteLine("sorted...");

Array.Sort(pallets);
foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("reversed...");
Array.Reverse(pallets);
foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Array.Clear(pallets, 0, 2);
Console.WriteLine($"clearing 2 ...count {pallets.Length}");
foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"resizing to 6...count {pallets.Length}");
pallets[4] = "C01";
pallets[5] = "C02";

foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"resting to 3...count {pallets.Length}");
foreach(var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

string myStringValue = "abc123";
char[] myCharArray = myStringValue.ToCharArray();
Array.Reverse(myCharArray);
string delimitedString = string.Join(",", myCharArray);
Console.WriteLine(delimitedString);
string[] itemChar = delimitedString.Split(',');
foreach(var item in itemChar)
{
    Console.WriteLine(item);
}
string resultString = new string(myCharArray);
Console.WriteLine(resultString);

string pangramArrays = "The quick brown fox jumps over the lazy dog";

// Step 1
string[] splitPangramArray = pangramArrays.Split(' ');

//Step 2
string[] newStringArray = new string[splitPangramArray.Length];

// Step 3
for (int i = 0; i < splitPangramArray.Length; i++)
{
    char[] letters = splitPangramArray[i].ToCharArray();
    Array.Reverse(letters);
    newStringArray[i] = new string(letters);
}

//Step 4
string reversedString = String.Join(" ", newStringArray);
Console.WriteLine(reversedString);

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] ordersArray = orderStream.Split(',');
ordersArray.Sort();
foreach(var order in ordersArray)
{
    if (order.Length != 4)
    {
        Console.WriteLine($"{order}\t - Error");
    }
    else
    {
        Console.WriteLine(order);
    }
}

Console.WriteLine("=========================================");
Console.WriteLine("new code");
Console.WriteLine("=========================================");

string firstString = "Hello";
string secondString = "World!";
string resultStringFormatted = string.Format("{0},{1}",firstString,secondString);
Console.WriteLine(resultStringFormatted);

decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; 
Console.WriteLine(yourDiscount);

decimal priceDecimal = 67.55m;
decimal salePriceDecimal = 59.99m;

string yourDiscountString = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

Console.WriteLine(yourDiscountString);

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subTotal = 2750.0000m;
decimal taxPercentage = .15825m;
decimal totalBilled = 3581.19m;


Console.WriteLine($"Invoice number: {invoiceNumber}");
Console.WriteLine($"    Shares: {productShares:N3}");
Console.WriteLine($"        Subtotal: {subTotal:C}");
Console.WriteLine($"             Tax: {taxPercentage:P2}");
Console.WriteLine($"                TotalBilled: {totalBilled:C}");

string padThis = "pad this";
Console.WriteLine(padThis.PadLeft(12, '-'));
Console.WriteLine(padThis.PadRight(12, '-'));


string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

Console.WriteLine(comparisonMessage);


Console.WriteLine("====================================================");
Console.WriteLine("new code");
Console.WriteLine("====================================================");

string findParentheses = "Find what is (inside the parentheses)";

int openParentheses = findParentheses.IndexOf('(') + 1;
int closeParentheses = findParentheses.IndexOf(')');
int substringLength = closeParentheses - openParentheses;
string insideParentheses = findParentheses.Substring(openParentheses, substringLength);
Console.WriteLine(insideParentheses);

string messageIndexOf = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = messageIndexOf.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = messageIndexOf.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = messageIndexOf.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(messageIndexOf.Substring(openingPosition, length));
}

string dataRemove = "12345John Smith          5000  3  ";
string updatedData = dataRemove.Remove(5, 20);
Console.WriteLine(updatedData);

string messageReplace = "This--is--ex-amp-le--da-ta";
message = messageReplace.Replace("--", " ");
message = messageReplace.Replace("-", "");
Console.WriteLine(messageReplace);