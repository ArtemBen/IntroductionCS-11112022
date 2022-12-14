// С клавиатуры вводится число - день недели. определить день недели

int day=1;
if (day==1) System.Console.WriteLine("Понедельник");
    else
        if (day==2) System.Console.WriteLine("Вторник");
            else
                if (day==3) System.Console.WriteLine("Среда");

switch(day)
{
    case 1:
        System.Console.WriteLine("Понедельник");
        break;
    case 2:
        System.Console.WriteLine("Вторник");
        break;
    case 3:
        System.Console.WriteLine("Среда");
        break;
    default:
        System.Console.WriteLine("неправильный ввод");
        break;

}

metka1:

goto metka1;// оператор безусловного перехода
//GOTO - нельзя пользоваться