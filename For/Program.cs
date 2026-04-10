

// Оголошуємо масив з яким будемо проводити експерименти
int[] numbers = { 4, 1, 10, -3, 20, 15, 2, 100, -4 };


//Виведемо на екран всі елементи масиву
Console.WriteLine("All elements:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine("\n");

//Надрукуємо на екран елементи масив з кінця до початку
Console.WriteLine("Array from end to start:");
for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine("\n");


//Виведемо на екран лише ті елементи масиву, які більші або рівні 10
Console.WriteLine("Elements greater than or equal to 10:");
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= 10)
    {
        Console.Write($"{numbers[i]} ");
    }
}
Console.WriteLine("\n");

//Надрукуємо кожний другий елемент масиву, починаючи з першого
Console.WriteLine("Every second element:");
for (int i = 0; i < numbers.Length; i += 2)
{
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine();

//Змінну циклу можна ініціалізувати поза циклом, тоді в умові та кроку можна використовувати лише її ім'я.
//Це може бути корисно, якщо вам потрібно використовувати цю змінну після завершення циклу.
int x = 0;
for (; x < numbers.Length; x += 2)
{
    Console.Write($"{numbers[x]} ");
}
Console.WriteLine($"Value of 'x' after the loop: {x}");
x++;