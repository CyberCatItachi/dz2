// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Ведите цифру от 1 до 7");
int num = int.Parse(Console.ReadLine());
if (num>=1)
{
    if (num<=7)
    {
        if (num<=5)
        {
            Console.WriteLine("Это не выходной");
        }
        else
        {
            Console.WriteLine("Это выходной!");
        }
    }
    else
    {
        Console.WriteLine("Ошибка");
    }

}
else
{
    Console.WriteLine("Ошибка");
}