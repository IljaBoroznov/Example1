int first = 2;
int second = 3;
int third = 7;
int max = 0;

if (second < first)
{
    max = first;
}
else
{
    max = second;
}
if (third < max)
{
   Console.Write("max = ");
   Console.WriteLine(max); 
}
else
{
   Console.Write("max = ");
   Console.WriteLine(third);  
}