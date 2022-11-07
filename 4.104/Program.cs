Console.WriteLine("(4.104 Введите порядковый номер дня недели от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine(Wk.ПОНЕДЕЛЬНИК);
        break;
    case 2:
        Console.WriteLine(Wk.ВТОРНИК);
        break;
    case 3:
        Console.WriteLine(Wk.СРЕДА);
        break;
    case 4:
        Console.WriteLine(Wk.ЧЕТВЕРГ);
        break;
    case 5:
        Console.WriteLine(Wk.ПЯТНИЦА);
        break;
    case 6:
        Console.WriteLine(Wk.СУББОТА);
        break;
    case 7:
        Console.WriteLine(Wk.ВОСКРЕСЕНЬЕ);
        break;

}
Console.WriteLine();
enum Wk
{
    ПОНЕДЕЛЬНИК,
    ВТОРНИК,
    СРЕДА,
    ЧЕТВЕРГ,
    ПЯТНИЦА,
    СУББОТА,
    ВОСКРЕСЕНЬЕ
}
