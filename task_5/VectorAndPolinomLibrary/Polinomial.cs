using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorAndPolinomLibrary
{
    public class Polinomial
    {
        private double[] _coeffs;
        public double[] Coeffs
        {
            get
            {
                return (double[])_coeffs.Clone();
            } 
            
            set 
            {
                if (value == null)
                    throw new ArgumentNullException(Resource.NullExsp);

                _coeffs = (double[])value.Clone();
            } 
        }

        public int Degree { get { return _coeffs.Length - 1; } }

        public Polinomial(params double[] coeffs)
        {
            if (coeffs == null || coeffs.Length < 2)
                throw new ArgumentException(Resource.SmallLength);

            Coeffs = (double[])coeffs.Clone();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < _coeffs.Length - 1; i++)
            {
                if (_coeffs[i] != 0)
                {
                    sb.Append(_coeffs[i]);
                    sb.Append("x^");
                    sb.Append(Degree - i);
                    sb.Append(" + ");
                }
            }
            double lastCoeff = _coeffs[_coeffs.Length - 1];
            if (lastCoeff != 0)
                sb.Append(lastCoeff);

            return sb.ToString();
        }

        public static explicit operator string(Polinomial pol)
        {
            if (pol == null)
                throw new ArgumentNullException(Resource.NullExsp);

            return pol.ToString();
        }

        public override bool Equals(object obj)
        {
            Polinomial polinom = obj as Polinomial;

            if ((object)polinom == null)
                return false;

            if (this._coeffs.Length != polinom._coeffs.Length)
                return false;

            for (int i = 0; i < _coeffs.Length; i++)
            {
                if (_coeffs[i] != polinom._coeffs[i])
                    return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator ==(Polinomial firstP, Polinomial secondP)
        {
            if (ReferenceEquals(firstP, secondP))
                return true;

            if (((object)firstP == null) || ((object)secondP == null))
                return false;

            if (firstP._coeffs.Length != secondP._coeffs.Length)
                return false;

            return firstP.Equals(secondP);
        }

        public static bool operator !=(Polinomial firstP, Polinomial secondP)
        {
            return !(firstP == secondP);
        }  
    }
}
