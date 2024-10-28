
string[] ordersID = ["B123", "B179", "C235", "G3003", "B177", "C234", "A345", "C15"];

foreach (string fraOrderIDs in ordersID)
{
    if (fraOrderIDs.StartsWith('B'))
    {
        Console.WriteLine(fraOrderIDs);
    }
}

//find the how many 'o' in the string

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int x = 0;
foreach (char i in charMessage)
{
     if (i == 'o')
     { 
        x++; 
     }
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

/* int[] inventory = [200, 450, 700, 175, 250];
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");
 */

/* string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process."); */


/* string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}"); 
*/


/* 
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

Console.WriteLine(daysUntilExpiration);

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage != 0)
{
Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
 */



/* Random dice = new();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

roll1 = 4;
roll2 = 4;
roll3 = 4;

int total = roll1 + roll2 + roll3;

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine($"Your total including the bonus: {total}");
    
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        total += 6;
        Console.WriteLine("You rolled triples! +6 bonus to total!");
    }
    else
    {
        total += 2;
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
    }
}

Console.WriteLine($"Dice roll : {roll1} + {roll2} + {roll3} = {total}");

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if(total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
 */



/* Random dice = new Random();
int result = Random.Next();// can not do like this
int randomInt = dice.Next(1, 7);
Console.WriteLine(randomInt);
Console.Clear(); //clear the terminal and here not given anything as output
Console.Read();

Random dice = new(); 
int roll1 = dice.Next();
int roll2 = dice.Next(501);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue,secondValue);
 */