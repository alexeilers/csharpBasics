string instructorName = "Jacob"; 
string[] instructors = new string[] {"Adam", "Kate", instructorName};

// foreach(declaredIterator in enumerableCollection){body}

foreach(string name in instructors){
    Console.WriteLine($"Hello, {name}");
}




// EXERCISE
int [] numbers = new int [] {-10, -5, -1, 1, 5, 10};

foreach(int number in numbers)
{
    if (number < 0) 
    {
        Console.WriteLine($"{number} is negative.");
    }
    else if (number >0)
    {
        Console.WriteLine($"{number} is positive.");
    }
    else
    {
        Console.WriteLine($"{number} is neutral.");
    }
};