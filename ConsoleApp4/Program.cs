Random random = new Random();
int P = 1;
do
{
    int a = random.Next(10);
    if (a == 0) break;
    P *= a;
    Console.WriteLine($"{a}-{P}" );
}
while (true);

