namespace HomeTasks.Task3;
using System;

public class ExchangeProgram
{

/*
 * Використовуючи Visual Studio, створіть проєкт за шаблоном Console Application.
 * Напишіть програму, яка буде конвертувати валюти. Користувач вводить: суму грошей у певній валюті.
 * курс конвертації в іншу валюту. Організуйте виведення результату операції конвертування валюти на екран.
 */

    public static void CurrencyConverter() 
    {
        Console.WriteLine("Add amount in ZL that you want to convert in USD");
        double amountInZl = Convert.ToDouble(Console.ReadLine());

        double exchangeRate = 0.25;
        Console.WriteLine($"Exchange rate today is {exchangeRate}");

        double result = amountInZl * exchangeRate;

        Console.WriteLine($"You will receive {result} dollars.");

    }

}