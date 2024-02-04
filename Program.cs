//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
/*
char [,] array = {{'a', 'b', 'c', 'd'}, {'e', 'f', 'g', 'k'}, {'k', 'l', 'm', 'o'}};

void Show2DArray(char[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Show2DArray(array);

string CharArrayToString(char[,] arr)
{
    string str = "";
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            str+=arr[i, j];
        }
        
    }
    return str;
}

string answ = CharArrayToString(array);
Console.WriteLine(answ);
*/
//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.
/*
string str = "fDfdsAEfdsf!-";

string StringToLower(string str)
{
string lowerStr = str.ToLower();
return lowerStr;
}

string answ = StringToLower(str);
Console.WriteLine(answ);
*/
//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
/*
string str = "bararab";
int strLength = str.Length;
int index = strLength / 2;
string substringBegining = str.Substring(0, index);
string substringEnding = str.Substring(strLength-index);

string ArrayReverseString(string stringToReverse)
{
    var charArray = stringToReverse.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

string reverse = ArrayReverseString(substringEnding);

if(substringBegining == reverse){
Console.WriteLine($"{str} is a palindrom");
}
else
{
    Console.WriteLine($"{str} is not a palindrom");
}
*/