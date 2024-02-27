Console.Write("Fill in the elements of the future array: ");
string str = Console.ReadLine();
str = str.Replace(" ", ""); // убрали промежутки
string[] array = str.Split(","); // сделали массив из строки
