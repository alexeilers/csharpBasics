// Create initial target
int number = 100;

// for (initializer; condition; interator) {body}


//1     //2        //3     //4
for (int i = 0; i <= number; i++){
    Console.WriteLine(i);
}

// 1 - for keyword,  2 - declaration and initialization of iterator, 3 - boolean expression for the loop, 4 - increment the interator at the end of the loop.




// EXERCISE 

Console.WriteLine("Hello! What number would you like to count to?");
string numberResponse = Console.ReadLine();
int countTo = int.Parse(numberResponse);

for(int i = 0; i <= countTo; i++){
    Console.WriteLine(i);
}

