using System;
class UserInput
{
public static void Main(string[] args)
{
    Console.Write("Enter user Name: ");
   string? studentName =Console.ReadLine();
   Console.WriteLine("welcome vr mode "+ studentName);

int studentAge;
Console.Write("Enter Your Age: ");
studentAge=Convert.ToInt32(Console.ReadLine());
Console.Write( "Age: "+ studentAge +" Years Old");




}

}