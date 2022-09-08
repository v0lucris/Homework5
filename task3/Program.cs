// Написать программу копирования массива

int[] array = new int[10];
int arrayCopy;

Console.Write("Your array : [ ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + "  ");
}
Console.Write("]");
Console.WriteLine();
Console.Write("   Copy : [ ");
for (int i = 0; i < array.Length; i++)
{
    arrayCopy = array[i];
    Console.Write(arrayCopy + " ");
   
}
Console.Write("]");