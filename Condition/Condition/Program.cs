

//task1


//int c = 70;
//if (c < 50)
//{
//    Console.WriteLine("Ugursuz");
//}
//else if (c >= 50 && c <= 69)
//{
//    Console.WriteLine("orta");
//}
//else if (c >= 70 && c <= 89)
//{
//    Console.WriteLine("yaxshi");
//}
//else if (c >= 90 && c <= 100)
//{
//    Console.WriteLine("ela");
//}
//else
//{
//    Console.WriteLine("Duzgun bal daxil edilmeyib");
//}






//task2


//static void Main()
//{
//    Console.Write("Ayın nömrəsini daxil edin (1-12): ");
//    int ay = Convert.ToInt32(Console.ReadLine());


//    switch (ay)
//    {

//        case 12:
//        case 1:
//        case 2:
//            Console.WriteLine("Qış");
//            break;
//        case 3:
//        case 4:
//        case 5:
//            Console.WriteLine("Yaz");
//            break;
//        case 6:
//        case 7:
//        case 8:
//            Console.WriteLine("Yay");
//            break;
//        case 9:
//        case 10:
//        case 11:
//            Console.WriteLine("Payız");
//            break;
//        default:
//            Console.WriteLine("Düzgün ay nömrəsi daxil edilməyib.");
//            break;
//    }
//}




//task3



//static void Main()
//{
//    Console.Write("1-7 arası bir rəqəm daxil edin:");
//    int gun = Convert.ToInt32(Console.ReadLine());

//    switch (gun)
//    {
//        case 1:
//            Console.WriteLine("Bazar ertəsi");
//            break;
//        case 2:
//            Console.WriteLine("Çərşənbə axşamı");
//            break;
//        case 3:
//            Console.WriteLine("Çərşənbə");
//            break;
//        case 4:
//            Console.WriteLine("Cümə axşamı");
//            break;
//        case 5:
//            Console.WriteLine("Cümə");
//            break;
//        case 6:
//            Console.WriteLine("Şənbə");
//            break;
//        case 7:
//            Console.WriteLine("Bazar");
//            break;
//        default:
//            Console.WriteLine("Düzgün rəqəm daxil");
//            break;
//    }
//}



//Console.Write("Bir ədəd daxil edin: ");
//        int eded = Convert.ToInt32(Console.ReadLine());

//        if (eded % 2 == 0)
//        {
//            Console.WriteLine("Bu ədəd cütdür.");
//        }
//        else
//        {
//            Console.WriteLine("Bu ədəd təkdir.");
//        }





//Sual1: Verilmis iki mertebeli ededin en boyuk reqemini tapan algoritm


//int c = 57;
//int a = c / 10;
//int b = c % 10;
//int d;
//if (a > b)
//{
//    d = a;
//}
//else
//{
//    d = b;
//}

//Console.WriteLine("84 ededinin en boyuk reqemini tap:"+ d);



//Sual2: Verilmis 3 mertebeli ededin mertebeleri cemini tapan algoritm:


//int c = 461;
//int a = c / 100;
//int b = (c/10)%10;
//int d = c % 10;
//int e = a + b + d;
//Console.WriteLine(e);






//Task3

//Console.Write("Dil seçin (a/A - Azərbaycan, r/R - Rus): ");
//char dil = Console.ReadKey().KeyChar;
//Console.WriteLine();
char dil= Console.ReadKey().KeyChar;

if (dil == 'a' || dil == 'A')
{
    Console.WriteLine("Azərbaycan dili seçildi");
}
else if (dil == 'r' || dil == 'R')
{
    Console.WriteLine("Rus dili seçildi");
}
else
{
    Console.WriteLine("Yanlış sorğu");
}