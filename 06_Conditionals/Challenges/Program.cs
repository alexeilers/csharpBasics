// If Statements

bool isRaining = true;
bool isGoingOutside = true;
bool hasUmbrella = true;

if (isRaining) {
    Console.WriteLine("It's raining outside!");
}

if (isGoingOutside) {
    Console.WriteLine("Better bring an umbrella!");
}

if (hasUmbrella) {
    Console.WriteLine("I will stay dry!");
}



if (isRaining && isGoingOutside) {
Console.WriteLine("I hope you have an umbrella!");
}

if (!isRaining || !isGoingOutside) {
    Console.WriteLine("You do not need an umbrella.");
}

if (isRaining ^ isGoingOutside) {
    Console.WriteLine("I will only go outside if it is not raining.");
}





// Else Statements

if (!isRaining) {
    Console.WriteLine("I will go cut the grass!");
}
else
if (isRaining) {
    Console.WriteLine("I guess I can't cut the grass.");
}

if (isGoingOutside) {
    Console.WriteLine("Make sure to dress for the weather!");
}
else
{
    Console.WriteLine("Sounds like a sweats kind of day.");
}


Console.WriteLine("How are you feeling today on a scale of 1-5?");
string feelingRating = Console.ReadLine();

if (feelingRating == "5") {
    Console.WriteLine("That's great to hear!");
}
else if (feelingRating == "4") {
    Console.WriteLine("Good stuff!");
}
else if (feelingRating == "3") {
    Console.WriteLine("Hope things improve!");
}
else if (feelingRating == "2") {
    Console.WriteLine("Oh, sorry to hear that.");
}
else if (feelingRating == "1") {
    Console.WriteLine("Dang. Hope your day gets better!");
}
else {
    Console.WriteLine("Sorry, I didn't understand your response. Please try again.");
}





//Ternary Expressions

Console.Write("Enter your age: ");
string response = System.Console.ReadLine();
int age = int.Parse(response);

string output = age >=18 ? "You can vote!" : "You're too young to vote.";

Console.WriteLine(output);


if (age >= 18)
{
    output = "You can vote!";
}
else 
{
    output = "You're too young to vote.";
}
Console.WriteLine(output);






// Switch Statements

Console.WriteLine("Who is your best friend? (Remember to capitalize the first letter!)2
");
string bestFriend = Console.ReadLine();

switch (bestFriend) {
    case "Adam":
        Console.WriteLine("Adam loves teaching C#.");
        break;
    case "Kate":
        Console.WriteLine("Kate has nightmares about CSS Creatures.");
        break;
    case "Tony":
        Console.WriteLine("Tony had pizza for dinner last night");
        break;
    default: 
        Console.WriteLine("I'm sorry, I don't have any facts about that person. Try someone else?");
        break;
}


