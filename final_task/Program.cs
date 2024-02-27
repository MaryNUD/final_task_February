Console.Write("Fill in the elements of the future array: ");
string str = Console.ReadLine();
str = str.Replace(" ", ""); // убрали промежутки
string[] array = str.Split(","); // сделали массив из строки

void PrintArray(string[] array) 
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void Select(string[] arg)
{
    string[] newArray = new string[] {};
    for(int i = 0; i < arg.Length; i++)
    {
        char[] eacharg = arg[i].ToCharArray();
            if (eacharg.Length <= 3)
                newArray = newArray.Append(arg[i]).ToArray();        
    }
    if (newArray.Length == 0)
        Console.WriteLine("no such elements");
    else
        PrintArray(newArray);
}

Select(array);