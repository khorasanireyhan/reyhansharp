//Homework

/*#region session1
//Business card
Console.WriteLine("__________________________");
//user input
Console.WriteLine("Hi.Please.... ");
Console.WriteLine("Enter your name :");
string name = Console.ReadLine();
Console.WriteLine("Enter your age :");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your gender :");
string gender = Console.ReadLine();
//Console.WriteLine($"your name is {name}, your age is {age}, your gender is {gender}");
Console.WriteLine("__________________________");
Console.WriteLine(" name :"+name);
Console.WriteLine(" age :" + age);
Console.WriteLine(" gender :" + gender);
Console.WriteLine("__________________________");
#endregion*/

/*#region session2
//Building a simple calculator
//value
double result;
//user input
Console.WriteLine("..........................");
Console.WriteLine("Enter your first number :");
double num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your other number: ");
double num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("what do you want to do ?");
Console.WriteLine("(+),(_),(/),(*)");
string op = Console.ReadLine();

//Console.WriteLine("*The operation is in progress*");
/*
//condidtion
if (op=="+")
{
    result = num1 + num1;
    Console.WriteLine("result is :"+result);
}
else if (op=="_")
{
    result = num1 - num2;
    Console.WriteLine("result is:"+result);
}
else if (op=="/")
{
    result = num1 / num2;
    Console.WriteLine("result is :"+result);
}
else if(op=="*")
{
    result = num1 * num2;
    Console.WriteLine("result is :"+result);
}

//another condition
switch (op)
{
    case"+":
        result=num1+num2;
        Console.WriteLine("result is: "+result);
        break;
    case"_":
        result=num1-num2;
        Console.WriteLine("result is: "+result);
        break;
    case"/":
        result=num1 / num2;
        Console.WriteLine("result is: "+result);
        break;
    case"*":
        result=num1 * num2;
        Console.WriteLine("result is: "+result);
        break;
    default:
        Console.WriteLine("you entered wrong option");
        break;
}

Console.WriteLine("..........................");

#endregion*/

/*#region session3
//cargo ship with (switch & decimal=task )
//use an empty array +switch statement + decimal data type =>
//value


decimal costPerKilo = 100; 
decimal totalPrice = 0;

Console.WriteLine("Welcome to the Golden Cargo Ship");
//user input
Console.WriteLine("How many cargos do you have ? ");
int numofcargos = int.Parse(Console.ReadLine());

//array or list option
List<decimal> cargoWeight = new List<decimal>();

for (int i = 1; i <= numofcargos; i++)
{
    Console.WriteLine("enter your cargos weight :");
    decimal weight = decimal.Parse(Console.ReadLine());
       cargoWeight.Add(weight);
      Console.WriteLine($"your cargo weight is{weight}kg.");
}
// condition
// For weight under 20 kg, use the fixed price.
// For 20 to 40 kg, increase the price by 3%.
// For 40 to 60 kg, increase the price by 4%.
// For 60 to 100 kg, increase the price by 5%.
// For weights above 100 kg, we do not offer delivery.
foreach (decimal weight in cargoWeight)
{
    switch (weight)
    {
        case < 20:
            totalPrice = weight * costPerKilo;
            break;
        case > 20 and <= 40:
            costPerKilo *= (decimal)0.03;
            totalPrice = weight * costPerKilo;
            break;
        case > 40 and < 60:
            costPerKilo *= (decimal)0.04;
            totalPrice = weight * costPerKilo;
            break;
        case >= 60 and < 100:
            costPerKilo *= (decimal)0.05;
            totalPrice = weight * costPerKilo;
            break;
        case >= 100:
            Console.WriteLine($"No delivery for {weight} . It's over 100 kg. ");
            break;
        default:
            Console.WriteLine("wrong cargo weight");
            break;
    }
}

//output
Console.WriteLine("your bill is ready ... ");

Console.WriteLine("____________________________________");
Console.WriteLine($"Here your Price:{totalPrice}$ for {numofcargos} cargos with {cargoWeight} kg .");

Console.WriteLine("Have a nice day ^_^");
    
Console.WriteLine("____________________________________");

#endregion*/
/*
#region session3_(2)
// Create an array with 4 elements and insert a new value at index 2,
// shifting the existing elements to the right.
//create a list =>
List<int> numlist = new List<int> { 1, 2, 3, 3 };
numlist.Insert(2, 14);
foreach (int i in numlist)
{
    Console.WriteLine(i);
}
//numlist.ForEach(i => Console.WriteLine( i)); 
//Console.WriteLine(string.Join(" ", numlist)); //use ai 
#endregion*/

#region session4
//create a Rock Paper Scissors Game
//user interface
Console.WriteLine("welcome to the game");
Console.WriteLine("enter your name :");
string name = Console.ReadLine();
Console.WriteLine("choose your choice ((...1.rock_2.scissor_3.paper...))");
int userchoice = Convert.ToInt32(Console.ReadLine());
//also we can write=>[string userchoice = Console.ReadLine();]Converting a string to a number
//computer choice(used ai)
Random rnd = new Random();
int computerChoice = rnd.Next(0, 3); // 0, 1, or 2
//game logic
switch (userchoice)
{
    case1://rock
    if (computerChoice== 1)
    {Console.WriteLine($"computer choose the same dear {name}");
    Console.WriteLine("try again !!!");
    return;
    } 
}





#endregion