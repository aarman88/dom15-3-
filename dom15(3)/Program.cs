using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        // Пример строки
        string myString = "Hello, Reflection!";

        // Получаем тип класса String
        Type stringType = typeof(string);

        // Получаем метод Substring
        MethodInfo substringMethod = stringType.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });

        // Параметры для вызова метода
        object[] parameters = { 7, 10 };

        // Вызываем метод и получаем результат
        object result = substringMethod.Invoke(myString, parameters);

        // Выводим результат на экран
        Console.WriteLine("Результат вызова Substring: " + result);
    }
}
