using System;

namespace MainDiagonalSumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập kích thước của ma trận vuông
            Console.Write("Nhap vao kich thuoc cua ma tran vuong: ");
            int size = int.Parse(Console.ReadLine());

            // Khởi tạo ma trận vuông với kích thước đã nhập
            double[,] matrix = new double[size, size];

            // Nhập giá trị cho từng phần tử của ma trận
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("Nhap vao gia tri cua phan tu [{0},{1}]: ", i, j);
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            // Tính tổng của các số ở đường chéo chính
            double diagonalSum = 0;
            for (int i = 0; i < size; i++)
            {
                diagonalSum += matrix[i, i];
            }

            // Hiển thị tổng của các số ở đường chéo chính
            Console.WriteLine("Tong cua cac so o duong cheo trinh cua ma tran la: " + diagonalSum);
        }
    }
}
