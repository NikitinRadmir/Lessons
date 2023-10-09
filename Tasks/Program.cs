// ps1 1.14
/*
string? ticket = Console.ReadLine();
if ((Convert.ToInt32(ticket) < 100000) || (Convert.ToInt32(ticket) >= 1000000))
    Console.WriteLine("неверный вид билета");
else if ((ticket[0] + ticket[1] + ticket[2]) == (ticket[3] + ticket[4] + ticket[5]))
    Console.WriteLine("счастливый билет");
else
    Console.WriteLine("несчастливый билет");
*/

// ps1 2.5
/*
double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
double d = double.Parse(Console.ReadLine());
int count = 0;
double sum = 0;
while (num1 < num2)
{
    num2 -= d;
    count++;
    sum += num2;
}
Console.WriteLine(count-1);
Console.WriteLine(sum);*/

// ps1 2.16

/*Random r = new Random();
int num = 1;
string str = "";
while (num != 0)
{   
    if (num > 0)
    {
        str += "+";
    }
    num = r.Next(-5, 5);
}
Console.WriteLine(str + ";");*/

// ps1 4.7

int k = int.Parse(Console.ReadLine());
bool fl = false;
static int Factorial(int n)
{
    if (n == 1) return 1;

    return n * Factorial(n - 1);
}
for (int num = 1; num < Factorial(k) + 1; num++)
{
    for (int i = 1; i <= k; i++)
    {
        if (fl)
        {
            break;
        }
        if (num % i != 0)
            break;
        if ((i == k) && (num % i == 0))
        {
            Console.WriteLine(num);
            fl = true;
        }
    }
}
