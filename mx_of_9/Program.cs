// C# functions and methods learning

  int max(int arg1, int arg2, int arg3)
  {
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
  }

int a1 = 45;
int b1 = 34;
int c1 = 77;
int a2 = 234;
int b2 = 34;
int c2 = 22;
int a3 = 235;
int b3 = 24;
int c3 = 533;

// Вызов функции на поиск максимального значения, передавая в качестве параметров, вызов этой же функции
// с поиском максмимума между тремя цифрами
int winner = max(max(a1,b1,c1), 
                max(a2,b2,c2), 
                max(a3,b3,c3));

Console.WriteLine($"Max number is {winner}");