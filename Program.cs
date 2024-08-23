using System;

namespace TimGiaTriNhoNhatTrongMang
{
    class Program
    {
        static void Main(string [] args)
        {
            int numArray;
            int i;
            int min;
            while(true)
            {
                Console.Write("Nhap vao so luong phan tu cua mang: ");
                if(int.TryParse(Console.ReadLine(),out numArray))
                {
                    break;
                }
                continue;
            }
            int [] array= new int [numArray];
            for (i=0; i<numArray; i++)
            {
                while(true)
                {
                    Console.Write("Nhap vao phan tu thu {0}: ", i);
                    if (int.TryParse(Console.ReadLine(),out array[i]))
                    {
                        break;
                    }
                    continue;
                }
            }
            min=TimGiaTriNhoNhat(array);
            Console.WriteLine("Gia tri nho nhat trong mang la: "+min);
        }
        static int TimGiaTriNhoNhat(int []array)
        {
            int min=array[0];
            for (int i=0; i<array.Length;i++)
            {                
                if(array[i] < min)
                min = array[i];
            }
            return min;
        }
    }
}