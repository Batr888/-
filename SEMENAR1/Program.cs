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
// Console.WriteLine("Введите номер дня недели:");
// int x=Convert.ToInt32( Console.ReadLine());
// if (x>0&&x<8)
// {
// if(x==1) Console.WriteLine("Понедельник");
// else if (x==2) Console.WriteLine("Вторник");
// else if (x==3) Console.WriteLine("Среда");
// else if (x==4) Console.WriteLine("Четверг");
// else if (x==5) Console.WriteLine("Пятница");
// else if (x==6) Console.WriteLine("Суббота");
// else if (x==7) Console.WriteLine("Воскресенье");
// }
// else Console.WriteLine("Введено не корректный номер дня недели");


// int x = new Random().Next(10,100);
// Console.WriteLine("Было сгенерировано число"+x);
// // Console.WriteLine($"Было сгенерировано число (x)");
// int x1 = x/10 ;
// int x2 = x%10;
// if (x1>x2) Console.WriteLine(x1);
// else if(x1<x2) Console.WriteLine (x2);
// else Console.WriteLine("цифры числа одинаковы");

// напишите программу,которое выводит случайное трехзначное число и удаляет вторую цифру этого числа


// напишите задачу, которая будет принимать на вход два числа 
//и выводить является ли второе число кратным первому. 
//Если второе число 2 не кратно 1 то прорамма выводит остаток деления

// int x= new Random().Next(100,1000);
// Console.WriteLine("Было сгенерировано число" +x);
// int x3= x%10;
// int x1 =x/100;
// Console.Write(x1);
// Console.Write(x3);



// Console.WriteLine("ВВедите превое целое число");
// int x1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("ВВедите второе целое число");
// int x2= Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine(x1);
// // Console.WriteLine(x2);
// int x3 = x1 % x2;
// if(x3==0) Console.WriteLine("yes");
// else Console.WriteLine($"Остаток полсле деления {x3}");


//напишите программу, которая принимет на вход число и провети
// кратно ли оно одновременно числу 7 и 23

// Console.WriteLine("Введите число для проверки");
// int x=Convert.ToInt32(Console.ReadLine());
// int a=x%7;
// int b=x%23;
// if(a==0 && b==0) Console.WriteLine("Кратно");
// else Console.WriteLine("не кратно");


// напишите программу которая принимает два числа и проверяет 
//является ли одно число квадратом другого

Console.WriteLine("Введите два числа ");
int x1= Convert.ToInt32(Console.ReadLine());
int x2= Convert.ToInt32(Console.ReadLine());
int a=x1*x1;
int b=x2*x2;
if (x1==b) Console.WriteLine("первое число является квадратом второго");
else if(x2==a) Console.WriteLine("второе число является квадратом первого");
else Console.WriteLine("ни первое число, ни второе не является квадратом другого числа");
