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

#region session2
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

Console.WriteLine("*The operation is in progress*");

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
else
{
    
}
{
    
}

Console.WriteLine("..........................");

#endregion