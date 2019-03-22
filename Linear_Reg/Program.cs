using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;

namespace Linear_Reg
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = Matrix<double>.Build.DenseDiagonal(5, 1);
            Console.WriteLine(A);
        }
    }
}
