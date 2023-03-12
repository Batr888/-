// Console.WriteLine("Введите целое число:"); //приглашает пользователя ввести информацию.
// int x =Convert.ToInt32( Console.ReadLine()); //перевели данные пользователя в целое число и в переменную x тоже целое число.
// int y = x*x;
// Console.WriteLine("квадрат введенного числа равен:" +y);
// // СДЕЛАЕМ ПРОВЕРКУ НА ДВУХзначные числа
// if (x>9 && x<100)
// {
//   Console.WriteLine("Вы ввели положительное двухзначное число!!!");
//}
// напишите программу, которая на вход приминает два числа и проверяет является ли первое число квадратом второго


// Console.WriteLine("Введите первое число:");
// int x= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int y= Convert.ToInt32(Console.ReadLine());
// int z=y*y;
// if(y<x)
// {
// if(z==x)
// {
//   Console.WriteLine("yes");
// }
// else
// {
//   Console.WriteLine("no");
// }
// }
// else
// {
//   Console.WriteLine("Первое число не является квадратом второго");
// }


//написать программу, которая будет выдавать название дня недели по заданному номеру.
Console.WriteLine("Введите номер дня недели:");
int x=Convert.ToInt32( Console.ReadLine());
if (x>0&&x<8)
{
if(x==1) Console.WriteLine("Понедельник");
else if (x==2) Console.WriteLine("Вторник");
else if (x==3) Console.WriteLine("Среда");
else if (x==4) Console.WriteLine("Четверг");
else if (x==5) Console.WriteLine("Пятница");
else if (x==6) Console.WriteLine("Суббота");
else if (x==7) Console.WriteLine("Воскресенье");
}
else Console.WriteLine("Введено не корректный номер дня недели");