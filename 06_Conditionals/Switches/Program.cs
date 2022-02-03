Console.WriteLine("Please give us your name");
string name = Console.ReadLine();
switch(name)
{
    case "Alex":
    Console.WriteLine("Nice to meet you, " + name + "!");
    break;
    default:
    break;
}


Console.WriteLine("How are you feeling today on a scale of 1-5?");
string feelingRating = Console.ReadLine();

switch (feelingRating)
{
    case "5" :
    Console.WriteLine("That is great to hear!");
    break;
    case "4" :
    Console.WriteLine("Good stuff");
    break;
    case "3" :
    Console.WriteLine("Hope things improve!");
    break;
    case "2" :
    Console.WriteLine("Oh no, sorry to hear that");
    case "1" : 
    Console.WriteLine("Dang, I hope your day gets better soon. There's always tomorrow!");
    break;
    default:
    Console.WriteLine("Sorry, what you entered is not what we asked for. Please try again.");
    break;
}