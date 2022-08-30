// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
bool isWork = true;
string decision = String.Empty;
int count = 0;
while(isWork)
{
    Console.Write("Введите число или напишите 'Exit': ");
    decision = Console.ReadLine();
    if(decision.ToLower() == "exit")
    {
        isWork = false;
    }
    else
    {
        if(Convert.ToInt32(decision) > 0)
        {
            count++;
        }
    }
}
Console.WriteLine($"Количетсво чисел, больше 0 = {count}");
