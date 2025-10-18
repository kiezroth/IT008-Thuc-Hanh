using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
     class cMatrix
    {
        private int[,] matrix;
        private int Rows, Cols;
        
        public cMatrix()
        {
            Rows = Cols = 0;
            matrix = new int[Rows, Cols];
        }
        private int readInt(string input)
        {
            int _Convert;
            if (!int.TryParse(input, out _Convert))
                throw new InvalidDataException("Dữ liệu nhập vào không phải số nguyên");
            return _Convert;
        }
        // Câu a. Nhập xuất ma trận
  
        public void NhapMatrix()
        {
            Console.OutputEncoding = Encoding.UTF8;
            matrix = new int[Rows, Cols];
            Console.Write("Nhập kích thước ma trận\nSố hàng: ");
            Rows = readInt(Console.ReadLine()!);
            Console.Write("Số cột: ");
            Cols = readInt(Console.ReadLine()!) ;
            matrix = new int[Rows, Cols];

            for (int i = 0; i < Rows; i++)
            {
                string input = Console.ReadLine()!;
                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != Cols)
                    throw new InvalidDataException("Số lượng dữ liệu trên một hàng không hợp lệ");
                for (int j = 0; j < Cols; j++)
                    matrix[i, j] = readInt(parts[j]);
            }
        }
        public void XuatMatrix()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Ma trận đã nhập");
            for (int i = 0; i < Rows; i++)
            {
                for (int j =0; j < Cols; j++)
                    Console.Write($"{matrix[i, j],-6} ");
                Console.WriteLine();
            }
        }
        //Câu b. Tìm kiếm phần tử
        public bool isFoundInMatrix(int key)
        {
            foreach (var i in matrix)
                if (i == key) return true;
            return false;
        }
        //Câu c. Xuất số nguyên tố
        private bool isPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) return false;
            return true;
        }
        public void XuatSoNguyenTo()
        {

            Console.OutputEncoding = Encoding.UTF8;
            List<int> newList = new List<int>();
            foreach(int p in matrix)
            {
                if (isPrime(p))
                    newList.Add(p);
            }
            if (newList.Count == 0)
                Console.WriteLine("Ma trận không chứa số nguyên tố");
            else
            {
                Console.WriteLine("Các số nguyên tố tìm được là:");
                foreach (int p in newList)
                    Console.Write("{0} ", p);
            }
            Console.WriteLine();
        }
        // Câu d. Cho biết dòng nào có nhiều số nguyên tố nhất
        private Tuple<List<int>,int> MaxCount_PrimesOnRows()
        {
            int[] onRows = new int[Rows];
            int maxCount = 0;
            for (int i = 0; i < Rows; i++)
            {
                onRows[i] = 0;
                for (int j = 0; j < Cols; j++)
                    if (isPrime(matrix[i, j]))
                        onRows[i]++;
                if (onRows[i] > maxCount)
                    maxCount = onRows[i];
            }
            List<int> newList = new List<int>();        // Danh sách dòng
            if (maxCount == 0) return new Tuple<List<int>,int>(newList,-1);

            for (int i = 0; i < Rows; i++)
                if(onRows[i] == maxCount)
                    newList.Add(i + 1);
            return new Tuple<List<int>, int>(newList, maxCount);

        }
        public void Find_Rows_has_MaxCountPrime()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var res = MaxCount_PrimesOnRows();
            if (res.Item1.Count == 0)
            {
                Console.WriteLine("Ma trận không chứa số nguyên tố");
                return;
            }
            if (res.Item1.Count == 1)
                Console.WriteLine("Dòng thứ {0} chứa nhiều số nguyên tố nhất và có {1} số nguyên tố", res.Item1.First(), res.Item2);
            else // Nhiều dòng
            {
                Console.WriteLine("Các dòng sau đây chứa nhiều số nguyên tố nhất và có {0} số nguyên tố trên mỗi hàng:", res.Item2);
                foreach (var p in res.Item1) Console.Write($"{p,-3}");
            }
        }
    }
}
