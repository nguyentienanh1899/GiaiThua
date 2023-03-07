

// Cách tính bình thường
/*using System;

namespace GiaiThua
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so n nguyen duong");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                while (n < 0)
                {
                    Console.WriteLine("Nhap lai vao so n nguyen duong");
                    n = int.Parse(Console.ReadLine());
                }
            }
            int result = 1;
            if (n == 0)
            {
                Console.Write("Giai thua cua {0} la: {1} \n", n, result);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                Console.Write("Giai thua cua {0} la: {1} \n", n, result);
            }
        }
    }
}*/
// Sử dụng đệ quy.
using System;
using System.Collections;
namespace GiaiThua

{
    class TinhGiaiThua
    {
        static long TinhGiaithuaSoNguyenDuong(int n)
        {
            long result;
            if (n > 0)
            {
                return result = n * TinhGiaithuaSoNguyenDuong(n - 1);
            }
            else
            {
                return 1;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so n nguyen duong");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                while (n < 0)
                {
                    Console.WriteLine("Nhap lai vao so n nguyen duong");
                    n = int.Parse(Console.ReadLine());
                }
            }
            var result = TinhGiaithuaSoNguyenDuong(n);
            Console.Write("Giai thua cua {0} la: {1} \n", n, result);
        }
    }
}
