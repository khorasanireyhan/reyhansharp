// Class exercises

/*#region session1
//console:writeLine & readLine core:
Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Please enter your Last name:");
string lastName = Console.ReadLine();
Console.WriteLine("Please enter your age :");
int age =Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"your name is : {name} , your last name is :{lastName},your age is: {age}");
Console.WriteLine("your name is :"+""+ name , "your last name is :" + lastName ,"your age is:" +""+ age);
#endregion*/
#region session2
//برنامه ایی که از کاربر وزن جعبه را بگیر و یکسری شرط را لحاظ کند:
//value
int costPerKilo = 100;
int totalPrice = 0;

Console.WriteLine("Welcome to the Golden Cargo Ship");
//user input
Console.WriteLine("please enter  cargo weight : ");
int cargoWeight =Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"your cargo weight is{cargoWeight}kg.");
//condition
if (cargoWeight<=20)
{
    totalPrice = cargoWeight * costPerKilo;
}
else if(cargoWeight is>20and<=40)
{
    costPerKilo += 5;  //costPerKilo=castPerKilo+5;
    totalPrice = cargoWeight * costPerKilo;
}
//output
Console.WriteLine("your bill is ready .... ");
Console.WriteLine($"Total Price:{totalPrice}$.");
#endregion
