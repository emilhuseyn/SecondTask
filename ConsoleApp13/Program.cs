#region task 1.1
int n, m, count = 0;
n = Convert.ToInt32(Console.ReadLine());
string bin = "";
while (n > 0)
{
    count++;
    m = n % 2;
    bin = $"{m}" + bin;
    n = n / 2;
}
bool t = true;
for (int i = 1; i < count; i++)
{
    if (bin[i] == '1')
    {
        t = false;
        Console.WriteLine("2-nin quvveti deyildir");
        break;
    }
}
if (t == true)
{
    Console.WriteLine($"2-nin quvvetidir");
}
#endregion
#region task 1.2
double N;
bool t1 = true;
N = 8192;
for (double i = N; i >= 1; i = i / 2)
{
    if (i == 1)
    {
        Console.WriteLine("2-nin quvvetidir");
        t1 = false;
    }
}
if (t1 == true)
{
    Console.WriteLine("2-nin quvveti deyil");
}
#endregion
#region task 2
int n1, j;
bool l = false;
n1 = Convert.ToInt32(Console.ReadLine());
for (j = 2; j < n1 / 2; j++)
{
    if (n1 % j == 0)
    {
        l = true;
        Console.WriteLine("Murekkebdir");
        break;
    }
}
if (l == false)
{
    Console.WriteLine("Sadedir");
}
#endregion