//math OR chemistry >= 90

using System.Net.NetworkInformation;

int math, bio, che;

Console.WriteLine("Enter your math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result:");
bio = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result:");
che = Int32.Parse(Console.ReadLine());

if ((math >= 90 || che >= 90) || (math >= 90 && bio >= 90) || (che >= 90 && bio >= 90))
{
    Console.WriteLine("Congratulations! You got accepted!");
}
else
{
    Console.WriteLine("Your application can not be approved.");
}