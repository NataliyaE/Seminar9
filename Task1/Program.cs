// Задайте значение N. напишите прогу, которая выведет все натуральные числа в промежутке от 1 до n

Console.WriteLine("Enter number:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumber(num, 1));
string PrintNumber(int start, int end)
{
    if(start == end)
    {
        return start.ToString();
        // сначала пишем окончание рекурсии
    }
    return (start + "," + PrintNumber(start - 1, end));
    // потом сама рекурсия
}

