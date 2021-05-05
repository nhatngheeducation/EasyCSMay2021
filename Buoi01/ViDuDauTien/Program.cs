using System;

namespace ViDuDauTien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Xin chào các bạn");
            string HoTen;
            Console.Write("Ten ban: ");
            HoTen = Console.ReadLine();
            int NamSinh;
            Console.Write("Sinh: ");
            NamSinh = int.Parse(Console.ReadLine());

            var Tuoi = DateTime.Now.Year - NamSinh;

            var chuoiXuat = $"Ban {HoTen} sinh {NamSinh}, {Tuoi} tuoi";
            Console.WriteLine(chuoiXuat);
        }
    }
}
