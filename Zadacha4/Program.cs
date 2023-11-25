Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int a1=a;
int n=1;
while (a1>=10)
{
    a1/=10;
    n*=10;
}
while (n>1)
{
   Console.Write(a/n%10 +", ");
   n/=10;
 }
Console.WriteLine(a%10);