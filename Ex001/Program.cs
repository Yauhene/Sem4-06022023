// Преподовательская версия программы, которая принимает два числа и
// сообщает какое число больше

Task_1(); // В данном случае вызов функции осуществлен ПРЕЖДЕ чем был описан

void Task_1() // основная функция, которая использует все функции, которые для нее написаны
{
    int firstNumber = ReadInt("First Number");
    int secondNumber = ReadInt("Second Number");

    PrintMore(firstNumber,secondNumber);
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

void PrintMore(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        Console.WriteLine($"{firstNumber} > {secondNumber}");
    }
    else
    {
        if(firstNumber == secondNumber)
        {
           Console.WriteLine($"{firstNumber} = {secondNumber}"); 
        }
        else Console.WriteLine($"{secondNumber} > {firstNumber}");
    }
}
