using System.Diagnostics;
using System.Globalization;
int repeats = 1000;
int bench = 2000;
Stopwatch stopwatch = new Stopwatch();
// DynamicStack stack1 = new DynamicStack(4);
// StaticStack stack2 = new StaticStack(bench*2);

// stopwatch.Start();
// for (int i = 0; i < repeats; i++)
// {
//     for (int j = 0; j < bench/2; j++)
//     {
//         stack1.push(j);
//     }
//     for (int j = bench/2; j < bench ; j++)
//     {
//         stack1.pop();
//     }
// }
// stopwatch.Stop();
// Console.Write("STATIC TOTAL: ");
// Console.Write(stopwatch.Elapsed);
// Console.WriteLine("s");
// Console.Write("STATIC AVERAGE: ");
// Console.Write(stopwatch.Elapsed/repeats);
// Console.WriteLine("s");
// stopwatch.Reset();

// stopwatch.Start();
// for (int i = 0; i < repeats; i++)
// {
//     for (int j = 0; j < bench/2; j++)
//     {
//         stack2.push(j);
//     }
//     for (int j = bench/2; j < bench ; j++)
//     {
//         stack2.pop();
//     }
// }
// stopwatch.Stop();
// Console.Write("DYNAMIC TOTAL: ");
// Console.Write(stopwatch.Elapsed);
// Console.WriteLine("s");
// Console.Write("DYNAMIC AVERAGE: ");
// Console.Write(stopwatch.Elapsed/repeats);
// Console.WriteLine("s");


//github: https://github.com/PH77SER/hp35

for (int j = 0; j < repeats; j++)
{
Item[]expr = new Item[bench-1];
for (int i = 0;i < bench/2; i++)
    expr[i] = new Item(1);
for (int i = bench/2; i < bench-1; i++)
    expr[i] = new Item(itemType.ADD);

stopwatch.Start();
Calculator calc = new Calculator(expr, bench*2); 
calc.run();
stopwatch.Stop();
Console.WriteLine(stopwatch.Elapsed);
stopwatch.Reset();
}

