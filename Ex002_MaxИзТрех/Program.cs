// Преподовательская версия программы, которая принимает два числа и
// сообщает какое число больше

//Task_1(); // В данном случае вызов функции осуществлен ПРЕЖДЕ чем был описан
Task_2(); // функия поиска макс. числа в массиве

// void Task_1() // основная функция, которая использует все функции, которые для нее написаны
// {
//     int firstNumber = ReadInt("First Number");
//     int secondNumber = ReadInt("Second Number");

//     PrintMore(firstNumber,secondNumber);
// }

void Task_2()
{
    int[] array = {ReadInt("First Number"), ReadInt("Second Number"), ReadInt("Third Number")};

    PrintMoreFromArray(array);
}

int ReadInt(string argument)
{
    Console.Write($"Input {argument}: ");
    int number; // переменная (объявление) вынесено за блок while чтобы она была видна вне его

    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Error! Try again.");
    }
    return number;
}

// void PrintMoreFromTwo(int firstNumber, int secondNumber)
// {
//     if (firstNumber > secondNumber)
//     {
//         Console.WriteLine($"{firstNumber} > {secondNumber}");
//     }
//     else
//     {
//         if(firstNumber == secondNumber)
//         {
//            Console.WriteLine($"{firstNumber} = {secondNumber}"); 
//         }
//         else Console.WriteLine($"{secondNumber} > {firstNumber}");
//     }
// }

// void PrintMoreFromThree(int firstNumber, int secondNumber, int thirdNumber)
// {
//     int max = firstNumber;
//     if (secondNumber > max)
//     {
//         max = secondNumber;
//     }
//     if (thirdNumber > max)
//     {
//         max = thirdNumber;
//     }

//     Console.WriteLine($"The biggest number is {max}");
// }

void PrintMoreFromArray(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }

    Console.WriteLine($"The biggest number is {max}");
}