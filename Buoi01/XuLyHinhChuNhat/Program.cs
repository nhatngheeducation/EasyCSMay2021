using System;

namespace XuLyHinhChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh Tinh toan Hinh hoc!");
            double Dai, Rong, DienTich, ChuVi;
            Console.Write("Chieu dai HCN: ");
            Dai = double.Parse(Console.ReadLine());
            Console.Write("Chieu rong HCN: ");
            Rong = double.Parse(Console.ReadLine());
            DienTich = Dai * Rong;
            ChuVi = (Dai + Rong) * 2;
            var chuoiXuat = $"HCN {Dai} x {Rong} co S = {DienTich}, P = {ChuVi}";
            Console.WriteLine(chuoiXuat);
        }
    }
}
