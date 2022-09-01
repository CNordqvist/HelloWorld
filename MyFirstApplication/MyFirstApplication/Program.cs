// See https://aka.ms/new-console-template for more information

//övning #1

//Console.WriteLine("Var god skriv in erat förnamn");
//string usernamn = "";
//try
//{
//usernamn = Console.ReadLine();
//} catch
//{
//    Console.WriteLine("Var god gör rätt inmatning");
//}

//if (usernamn == "David")
//{
//    Console.WriteLine("Hej David");
//} else
//{
//    Console.WriteLine("Du är inte David.....");
//}


//Övning 2
//string lösen = "123password";
//string userGuess = "";
//bool loginLock = true; 
//Console.WriteLine("Ange lösenordet");

//while (loginLock == true)
//{
//    try
//    {
//        userGuess = Console.ReadLine();
//    }
//    catch
//    {
//        Console.WriteLine("Felaktig inmatning");
//    }

//    if (userGuess == lösen)
//    {
//        Console.WriteLine("Korrekt lösenord!");
//        loginLock = false;
//    }
//    else
//    {
//        Console.WriteLine("Fel!");
//    }
//}


//Övning #3

//int userGuess = -1 ;

//while (userGuess != 0) { 
//    Console.WriteLine("Gissa på en siffra");

//    try
//{
//    userGuess = int.Parse(Console.ReadLine());
//} catch 
//{
//    Console.WriteLine("Var god att mata in en korrekt siffra");
//}

//    if (userGuess > 100)
//    {
//        Console.WriteLine("Du gissade mer än 100");
//    }
//    else if (userGuess == 100)
//    {
//        Console.WriteLine("Du gissade på exakt 100");
//    }
//    else if (userGuess < 100 && userGuess > 0)
//    {
//        Console.WriteLine("Du gissade på mindre än 100");
//    }
//    else if (userGuess == 0)
//    {
//        Console.WriteLine("Du gissade på 0");
//    }
//}

//Övning 4

//Console.WriteLine("Var god skriv in erat förnamn");
//string usernamn = "";
//int hälsningar = 0;  
//try
//{
//    usernamn = Console.ReadLine();
//}
//catch
//{
//    Console.WriteLine("Var god gör rätt inmatning");
//}
//Console.WriteLine("Var god skriv in så många gånger du vill bli hälsad på");
//try
//{
//    hälsningar = int.Parse(Console.ReadLine());
//}
//catch
//{
//    Console.WriteLine("Var god gör rätt inmatning");
//}

//for (int i= 0; i < hälsningar; i++)
//{
//    if (usernamn == "David")
//    {
//        Console.WriteLine("Hej David");
//    }
//    else
//    {
//        Console.WriteLine("Du är inte David.....");
//    }
//}

//övning 5

/*
Console.WriteLine("Skriv in heltal tills du tycker det är tillräkligt, bryt med annan karaktär");

double userAverage = 0;
int userInput = 0;
int userAttempts = 0;

while (true)
{
    try
    {
        userInput = userInput + int.Parse(Console.ReadLine());
        userAttempts++;
    }
    catch
    {
        Console.WriteLine(userAverage);
        break;
    }
    userAverage = userInput / userAttempts;
    Console.WriteLine(" ");
    Console.WriteLine(userInput);
}
*/
//Övning 6


//int userInt1 = 0;
//int userInt2 = 0;
//char userChar1 = 'a';
//int result = 0;
//Console.WriteLine("Skriv in ett heltal");
//try
//{
//    userInt1 = int.Parse(Console.ReadLine());
//} catch
//{
//    Console.WriteLine("Wrong!");
//}

//Console.WriteLine("En karaktär för vad du vill göra med talen");
//try
//{
//    userChar1 = char.Parse(Console.ReadLine());
//} catch { }

//Console.WriteLine("och till sist, ett till heltal");
//try 
//{
//    userInt2 = int.Parse(Console.ReadLine());   
//} catch {}

//if (userChar1 == '+')
//{
//    result = userInt1 + userInt2;
//} else if (userChar1 == '-')
//{
//    result = userInt1 - userInt2;
//} else if (userChar1 == '*')
//{
//    result = userInt1 * userInt2;
//} else if (userChar1 == '/')
//{
//    result = userInt1 / userInt2;
//}
//Console.WriteLine(userInt1 + " " + userChar1 + " " + userInt2 + " = " result);

//Övning 7
/*
string userInput = "";
int[] currentMonth = new int[2];

for (int i = 0; i < currentMonth.Length; i++)
{
    Console.WriteLine("Var god skriv in namnet på månaden #" + (i + 1));
    try
    {
        userInput = Console.ReadLine();
    }
    catch { }

    switch (userInput)
    {
        case "January":
            currentMonth[i] = 1;
            break;
        case "February":
            currentMonth[i] = 2;
            break;
        case "March":
            currentMonth[i] = 3;
            break;
        case " April":
            currentMonth[i] = 4;
            break;
        case "May":
            currentMonth[i] = 5;
            break;
        case "June":
            currentMonth[i] = 6;
            break;
        case "July":
            currentMonth[i] = 7;
            break;
        case "August":
            currentMonth[i] = 8;
            break;
        case "September":
            currentMonth[i] = 9;
            break;
        case "October":
            currentMonth[i] = 10;
            break;
        case "November":
            currentMonth[i] = 11;
            break;
        case "December":
            currentMonth[i] = 12;
            break;
    }
}
Console.WriteLine("#" + currentMonth[0] + " #" + currentMonth[1]);
Array.Sort(currentMonth);
int pastCheck = 12 - currentMonth[1];
int nowCheck = currentMonth[1] - currentMonth[0];
if ((pastCheck + currentMonth[0]) <= nowCheck)
{
    Console.WriteLine("Med " + (pastCheck + currentMonth[0]) + " månader mellan dem");
}
else if ((pastCheck + currentMonth[0]) > nowCheck)
{
    Console.WriteLine("Med " + nowCheck + " månader mellan dem");
} */


//Övning 8

/*int userbase = 1;
for (int i = 0; i < 16; i++)
{
    Console.WriteLine(userbase);
    userbase = userbase * 2;
}*/

//Övning 9
/*
Random rnd = new Random();
int guessAmount = 0;
int randInt = rnd.Next(1, 101);
int userGuess;
bool userCorrect = false;
Console.WriteLine("Please enter a number between 1-100");
while (userCorrect == false)
{
    guessAmount++;
    int.TryParse(Console.ReadLine(), out userGuess);

    if (userGuess > randInt)
    {
        Console.WriteLine("You guessed too high! Try again.");
    } else if (userGuess < randInt)
    {
        Console.WriteLine("You guessed too low! Try again.");
    } else if (userGuess == randInt)
    {
        Console.WriteLine("You guessed correctly!! the secret number was " + randInt + " all along! It took you " + guessAmount + " of tries!");
        break;
    }

} */

//Övning 9.5

while (true)
{
    string userThrow = "";
    int userInt = 0;
    int puterWins = 0;
    int userWins = 0;
    
    Console.WriteLine("Sten, Sax eller Påse?");
    try
    {
        userThrow = Console.ReadLine();
    } catch 
    {
        break;
    }
    if (userThrow == "Sten")
    {
        userInt = 1;
    } else if (userThrow == "Sax") 
    {
        userInt = 2;
    } else if (userThrow == "Påse")
    {
        userInt = 3;
    }
    

    Random rnd = new Random();
    int puterThrow = rnd.Next(1, 4);
    
    if (puterThrow == 1)
    { 
        Console.WriteLine("Botten kastade sten");
    } else if (puterThrow == 2)
    {
        Console.WriteLine("Botten kastade sax");
    } else if (puterThrow == 3)
      {
        Console.WriteLine("Botten kastade påse");
    }


    if (userInt == puterThrow)
    { 
        Console.WriteLine("Det blev lika");
    }
    else if ((userInt == 1 && puterThrow == 2) || (userInt == 2 && puterThrow == 3) || (userInt == 3 && puterThrow == 1))
    {
        Console.WriteLine()
    }
}
Console.ReadKey();