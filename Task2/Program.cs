// через рекурсию (метод вызывает сам себя до определенного момента)
// Задайте значения M и N. напишите прогу, которая найдет сумму натуральных элементов в промежутке от M до n
 
Console.WriteLine("Enter first number:");
int numStart = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
int numEnd = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumber(numStart, numEnd));
Console.WriteLine($"Sum of Elemets = {FindSum(numStart, numEnd)}");

string PrintNumber(int start, int end)
{
    if(start == end)
    {
        return start.ToString();
    }
    return (start + "," + PrintNumber(start + 1, end));
}

int FindSum (int numStart, int numEnd)
{
    int sum = 0;
    for (int i = numStart; i <= numEnd; i++)
    {
        sum = sum + i;
    }
    return sum;
}
