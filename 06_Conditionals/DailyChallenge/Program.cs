//ONE

int numberOne = 1;

string carType = "What kind of car do you drive?";

DateTime dayBorn = new DateTime(1989, 03, 23);

char firstInitial = 'A';



// TWO

int subtractionResult = 10 - 5;
Console.WriteLine("10 - 5 = " + subtractionResult);


// THREE 

Console.Write("Please give us your name: ");
string name = Console.ReadLine();

Console.Write("Now, please provide your age: ");
string age = Console.ReadLine();

string nameAndAge = "Your name is " + name + " and you are " + age + ".";
Console.WriteLine(nameAndAge);



// FOUR

Console.WriteLine("Are you wearing clothes right now?");
string wearingClothes = Console.ReadLine();

switch (wearingClothes)
{
    case "no" :
    Console.WriteLine("Aren't you freezing?!");
    break;
    case "yes" :
    Console.WriteLine("Cool, me too.");
    break;
    default:
    Console.WriteLine("I'm sorry, I didn't catch that. Yes or no to wearing clothes?");
    break;
}


// FIVE

Console.WriteLine("On a scale of 1-5, how do you think my outfit looks today?");
string ratingInput = Console.ReadLine();
int outfitRating = int.Parse(ratingInput);

string response = outfitRating switch 
{
    1 => "Yikes. I might as well be naked.",
    2 => "Hmm.. What should I wear instead?",
    3 => "Ok, what exactly don't you like about it?",
    4 => "Cool, thanks!",
    5 => "Really? Wow! I always knew I had an eye for fashion.",
    _ => "More than a five?! Wow!!!",
};

Console.WriteLine(response);


// SIX

Console.WriteLine("Welcome to the Wendy's Burger Portal! Would you like a single, double, triple, or baconator?");
string orderType = Console.ReadLine();

switch(orderType) {
    case "single":
    Console.WriteLine("Classic single, sounds good!");
    break;
    case "double":
    Console.WriteLine("Mmm... delicious double.");
    break;
    case "triple":
    Console.WriteLine("The ol' triple bypass, got it!");
    break;
    case "baconator":
    Console.WriteLine("Enjoy your nap afterwards!");
    break;
    default:
    Console.WriteLine("I'm sorry, I didn't get that. What burger would you like?");
    break;
};


// SEVEN --- I can't figure out how to do this with a bool 

Console.WriteLine("Are you happy? y/n");
string userAnswer = Console.ReadLine();

if (userAnswer == "y") {
    Console.WriteLine("Great, glad to hear it.");
}
else {
    Console.WriteLine("Oh... well, there's always tomorrow.");
}



// EIGHT

