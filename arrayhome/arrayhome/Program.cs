
// 1.Ədədlərdən ibarət arrayın ən kiçik elementini tapın

//int[] arr = [34, 12, 9, 91];
//int arrmin = arr[0];
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] < arrmin)
//    {

//        arrmin = arr[i];
//    }
//}

//Console.WriteLine("Massivin ən kicik elementi: " + arrmin);




// 2.Ədədlərdən ibarət arrayın elementleri cemini tapan alqoritm

//int[] arr = [12, 54, 10, 72];
//int sum = 0;
//for (int i = 0;i<arr.Length;i++)
//{
//    sum += arr[i];
//}
//Console.WriteLine(sum);




// 3.Verilmish arrayin en boyuk ve en kicik elementlerinin indexlerini ekrana çıxaran  algorithm 

//int[] arr = [12, 4, 9, 11];
//int arrmax = arr[0];
//int maxindex = 0;
//int arrmin = arr[0];
//int minindex = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] > arrmax)
//    {

//        arrmax = arr[i];
//        maxindex = i;
//    }
//    else if (arr[i] < arrmin)
//    {
//        arrmin = arr[i];
//        minindex = i;
//    }
//}

//Console.WriteLine(minindex);
//Console.WriteLine(maxindex);


// 4.Verilmish arrayda murekkeb ededleri ekrana çıxaran algorithm misal:input {5,9,12,11} output 9, 12


//int[] arr = [12,11,7,8];
//for (int i = 0; i < arr.Length; i++)
//        {
//    int num = arr[i];
//    bool eded = false;
// if (num > 1)
//            {
//                for (int j = 2; j <= num / 2; j++)
//                {
//                    if (num % j == 0)
//                    {
//                        eded= true;
//                        break;
//                    }
//                }
//            }

//            if (eded)
//            {
//                Console.Write(num + " ");
//            }
//        }
//             Console.WriteLine();  


