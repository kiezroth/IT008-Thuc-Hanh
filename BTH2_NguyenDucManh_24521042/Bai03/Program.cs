namespace Bai03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            cMatrix matr = new cMatrix();
            matr.NhapMatrix();
            matr.XuatMatrix();
            matr.XuatSoNguyenTo();
            matr.Find_Rows_has_MaxCountPrime();
        }
    }
}
