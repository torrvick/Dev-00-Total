string[] array = {"abc", "defg", "hi", "g", "klmn", "opqrst", "uv", "wxyz"};
Console.WriteLine();
Console.WriteLine("Исходный массив:");
Console.WriteLine($"[\"{String.Join("\", \"", array)}\"]");
Console.WriteLine();

string[] ArrayFilter(string[] array)
{
    string strTemp = "";
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3) strTemp += array[i] + ",";
    strTemp = strTemp.Trim(',');
    string[] arrayFiltered = strTemp.Split(',');
    return arrayFiltered;
}

Console.WriteLine("Отфильтрованный массив:");
Console.WriteLine($"[\"{String.Join("\", \"", ArrayFilter(array))}\"]");
Console.WriteLine();