string[] InputArrayStrings()
{
    string[] array;
    Console.WriteLine("Введите массив строк через пробел:");
    string m =Console.ReadLine();
    array = m.Split(' ');
    return array;
}
void CreateNewArrayStrings()
{
    string[] firstArray = InputArrayStrings();    
    string str = string.Join(", ", firstArray);
    Console.Write($"[{str}] ->");
    int count = 0;
    string[] secondArray = new string[firstArray.Length];
    foreach (var i in firstArray)
    {
        if (i.Length <= 3)
        {
            secondArray[count] = i;
            count++;            
        }        
    }
    secondArray = secondArray
       .Where(x => x != null)
       .ToArray();                              // Удаляем пустые строки из итогового массива secondArray и перезаписываем его
    str = string.Join(", ", secondArray);
    Console.WriteLine($"[{str}]"); 
}
CreateNewArrayStrings();     