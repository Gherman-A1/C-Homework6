//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.    0, 7, 8, -2, -2 -> 2     1, -7, 567, 89, 223-> 3

int CheckPositiveNumbers(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите числа через пробел: ");
int[] userArray = Console.ReadLine()!.Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
Console.WriteLine($"массив введенный пользователем: {String.Join(" ", userArray)} количество положительных чисел: {CheckPositiveNumbers(userArray)}");
