/*Написать программу, которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать 
на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

string [] array = Read();

string [] Read()
{
    System.Console.Write($"Введите через запятую с пробелом строковые элементы массива: ");
    string arrayAsString = Console.ReadLine();
    string [] numbersAsString = arrayAsString.Split(", ");
    string [] array = new string [numbersAsString.Length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = numbersAsString[i];
    }
    return array;
}

void NewArray(string [] array)
{   
    string element = string.Empty;
    string [] NewArray = new string [array.Length];
    System.Console.Write("Ваш массив имеет вид: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length-1) System.Console.Write(array[i] + "; ");
        if (i == array.Length-1) System.Console.Write(array[i]);
    }
    System.Console.Write("]");
    System.Console.WriteLine(" ");
    System.Console.Write("Новый массив -> [");
    for (int i = 0; i < array.Length; i++)
    {
        element = array[i];
        if (element.Length < 4 && i < array.Length-1) 
        {
            if (i == 0) 
            {
                NewArray[i] = array[i];
                System.Console.Write(NewArray[i]);
            }
            else 
            {
                NewArray[i] = array[i]; 
                System.Console.Write("; " + NewArray[i]);
            }
        }
        if (element.Length < 4 && i == array.Length-1)
        {
        NewArray[i] = array[i]; 
        System.Console.Write(NewArray[i]);
        }
    }
    
    System.Console.Write("]");
}

NewArray(array);
