// 1~100 짝수 출력
Console.WriteLine("1~100 짝수 출력");
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

// 0~10 while문으로 출력
Console.WriteLine("0~10 while문 출력");
int num = 0;
while (num <= 10)
{
    Console.WriteLine(num);
    num++;
}

// 1~100 홀수 do-while로 출력
Console.WriteLine("1~100 홀수 출력");
int odd = 1;
do
{
    if (odd % 2 == 1)
    {
        Console.WriteLine(odd);
    }
    odd++;
}
while (odd <= 100);

// 별 피라미드 출력
Console.WriteLine("별 피라미드 출력");
for (int i = 1; i <= 8; i++)
{
    for (int j = 1; j <= 8 - i; j++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= i * 2 - 1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

// 숫자 5개 입력받아 최솟값/최댓값 출력
Console.WriteLine("숫자 5개 입력");
int min = 0;
int max = 0;
for (int i = 0; i < 5; i++)
{
    Console.Write("숫자 입력: ");
    int input = int.Parse(Console.ReadLine());
    if (i == 0)
    {
        min = input;
        max = input;
    }
    else
    {
        if (input < min) min = input;
        if (input > max) max = input;
    }
}
Console.WriteLine("최솟값: " + min);
Console.WriteLine("최댓값: " + max);
