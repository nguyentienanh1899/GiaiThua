
//Bài 1 : Giai Thừa. 
//C1: Cách tính bình thường
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
//C2: Sử dụng đệ quy.
/*using System;
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
*/
//Bài 2: Số Hoàn Hào:
/*using System;

namespace SoHoanHao
{
    public class SoHoanHao
    {
        static bool Check(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            if (sum == n) return true;
            return false;
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
            var result = Check(n);
            if(result == true)
            {
                Console.Write("So {0} la so hoan hao.\n", n);
            }
            else
            {
                Console.Write("So {0} khong la so hoan hao.\n", n);
            }
        }
    }
}*/
//Bai So 3: Xoa Chuoi


//Bai So 4 : Bài Tổng Số Kẹo.
/*using System;

public class Program
{
    public static int ChaiThem(int keoHienCo, out int newKeoHienCo, int giaDoiKeo)
    {
        newKeoHienCo = 0;
        var soDu = 0;
        var thuong = 0;

        thuong = keoHienCo / giaDoiKeo;
        soDu = keoHienCo % giaDoiKeo;
        newKeoHienCo = thuong + soDu;

        return thuong;
    }

    public static void Main()
    {
        Console.WriteLine("Nhap vao so tien co");
        int soTienCo = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap vao gia keo");
        int giaKeo = int.Parse(Console.ReadLine());
        int soKeoMuaBangTien = soTienCo/giaKeo ;
        Console.WriteLine("Nhap vao so giay doi 1 vien keo");
        int soGiayDoiKeo = int.Parse(Console.ReadLine());


        var keoHienCo = soKeoMuaBangTien;
        var tongSoKeo = keoHienCo;

        do
        {
            tongSoKeo += ChaiThem(keoHienCo, out keoHienCo, soGiayDoiKeo);
        }
        while (keoHienCo >= soGiayDoiKeo);

        Console.WriteLine(tongSoKeo);
    }
}*/