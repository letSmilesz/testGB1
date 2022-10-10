//Написать программу, которая из имеющегося массива строк сформирует новый массив.
//Условие нового массива - длина строки не больше 3 символов.

//мне было скучно рисовать блок-схему, которую я могу реализовать, поэтому во втором коммите будет вариант по блок-схеме -
//не отоходя от "проекта", а последняя версия - вариант, как это сделать оптимальнее

void PrintText(string text)
{
    Console.Write(text);
}

void NewLine()
{
    Console.WriteLine();
}

dynamic UserEnter()
{
    string a = Console.ReadLine();
    if (a != "")
    {
        if (int.TryParse(a, out int n))
        {
            int b = Convert.ToInt32(a);
            return b;
        }
        else if (a == "y") return true;
        else if (a == "n") return false;
        else return a;
    }
    else
    {
        a = "exit";
        return a;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null)
        {
            Console.Write($"{array[i]}, ");
        }
    }
    Console.WriteLine();
}

string[] UserEnterV2()
{
    PrintText("Введите, сколько строк вы введёте: ");
    int n = UserEnter();
    string[] array = new string[n];
    for (int i = 0; i < array.Length; i++)
    {
        PrintText($"Введите {i + 1} строку:");
        NewLine();
        array[i] = Convert.ToString(UserEnter());
    }
    return array;
}
string[] enter = UserEnterV2();
string[] exit = new string[enter.Length];
int j = 0;
for (int i = 0; i < enter.Length; i++)
{
    if (enter[i].Length < 4)
    {
        exit[j] = enter[i];
        j++;
    }
}

PrintArray(exit);