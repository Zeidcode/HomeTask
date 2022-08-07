Console.Write("Введите ваши чиисла:");

int numA = Convert.ToInt32(Console.ReadLine());  
int numB = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(numA>numB)
{
    max = numA;
    Console.WriteLine(max);
}
else
{
    Console.WriteLine(numB);
}