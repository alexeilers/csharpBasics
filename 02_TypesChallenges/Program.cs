// BRONZE

int number;
int numberOne = 2;

string name;
string cookiesGone = "Who ate all the cookies?";

bool wasItYou;
bool notMe = true;

float averageCookies;
float amountEaten = 50.2f;

double AmountOwed;
double takeMyMoney = 800.99d;

decimal currentBalance;
decimal accountBalance = 9000.01m;

ulong totalCookies;
ulong allTheCookies = 15000;

Console.WriteLine(numberOne);
Console.WriteLine(cookiesGone);
Console.WriteLine(notMe);
Console.WriteLine(amountEaten);
Console.WriteLine(takeMyMoney);
Console.WriteLine(accountBalance);
Console.WriteLine(allTheCookies);


//SILVER

string caughtYou= "Aha! Caught you red handed!";
string giveThem = "Give back the cookies and no one gets hurt.";
string giveMeTheCookies = caughtYou + " " + giveThem;
Console.WriteLine(giveMeTheCookies);


string compromise = "If you hand them over now, I will give you some... How about I give you ";
int integer = 5;
string compromiseWithAmount = compromise + integer;
Console.WriteLine(compromiseWithAmount);


//GOLD

string year = "1989";
int theYear = int.Parse(year);
Console.WriteLine(theYear);

int nextYear = Convert.ToInt32(year);
Console.WriteLine(nextYear);