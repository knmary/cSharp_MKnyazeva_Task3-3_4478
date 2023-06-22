//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число N >> ");
string inputstring = Console.ReadLine();
int Nnumb = Convert.ToInt32(inputstring);
List<string> Cube = new List<string>();
for (int numb = 1; numb <= Nnumb; numb++)
{
    int cubenumbres = numb * numb * numb;
    string str = Convert.ToString(cubenumbres);
    Cube.Add(str);    
}
string strcube = String.Join(',', Cube);
Console.WriteLine($" -> {strcube}");