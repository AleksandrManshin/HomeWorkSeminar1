Console.Write("Введите число больше 1:");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count < number)
{
if(count % 2 == 0)
{
Console.Write(count + " ");
}
count++;
}
if(number <= 1)
{
Console.WriteLine("Число " + number + " меньше либо равно 1");
}