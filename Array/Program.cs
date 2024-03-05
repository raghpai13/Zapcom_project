// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] a = {11,2,34,5,55,96,117,27,38,9};
int temp;
for (int i = 0; i < a.Length-1; i++)
{
    for (int j = 0; j < a.Length-i-1; j++)
    {
        if (a[j] >= a[j+1])
        {
            temp = a[j];
            a[j] = a[j+1];
            a[j+1] = temp;
        }
    }
}
foreach(int i in a)
{
    Console.Write(" "+i);
}
