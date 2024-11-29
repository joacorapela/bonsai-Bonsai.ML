using System;
using MathNet.Numerics.LinearAlgebra;

namespace JoacoRapela.Bonsai.ML.OnlineBayesianLinearRegression
{
    public class PosteriorDataItem
    {
        public Vector<double> mn;
        public Matrix<double> Sn;
    }
}
