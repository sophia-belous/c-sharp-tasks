using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorAndPolinomLibrary
{
    public class Vector
    {
        private double[] _coordinates;

        public double[] Сoordinates
        {
            get
            {
                return _coordinates;//
            }

            set
            {
                if (value == null)
                    throw new ArgumentNullException(Resource.NullExsp);

                _coordinates = (double[])value.Clone();
            }
        }

        public int Count
        {
            get
            {
                return _coordinates.Length;
            }
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(_coordinates.Sum(x => x * x));
            }
        }

        public Vector(params double[] coordinates)
        {

            if (coordinates == null || coordinates.Length <= 1)
                throw new ArgumentException(Resource.SmallLength);

            Сoordinates = (double[])coordinates.Clone();
        }

        public double this[int index]
        {
            get
            {
                if (index < 0 || index >= _coordinates.Length) 
                    throw new IndexOutOfRangeException(Resource.IndexOut);

                return _coordinates[index];
            }

            set
            {
                if (index < 0 || index >= _coordinates.Length)
                    throw new IndexOutOfRangeException(Resource.IndexOut);

                _coordinates[index] = value;
            }
        }

        public static Vector operator +(Vector firstV, Vector secondV)
        {
            if (firstV == null || secondV == null || firstV.Count != secondV.Count)
                throw new ArgumentException(Resource.EqualsLength);

            double[] sumOfVectorCoordinates = new double[firstV.Count];

            for (int i = 0; i < sumOfVectorCoordinates.Length; i++)
            {
                sumOfVectorCoordinates[i] = firstV[i] + secondV[i];
            }

            return new Vector(sumOfVectorCoordinates);
        }

        public static Vector operator -(Vector firstV, Vector secondV)
        {
            if (firstV == null || secondV == null || firstV.Count != secondV.Count)
                throw new ArgumentException(Resource.EqualsLength);

            double[] diffOfVectorCoordinates = new double[firstV.Count];

            for (int i = 0; i < diffOfVectorCoordinates.Length; i++)
            {
                diffOfVectorCoordinates[i] = firstV[i] - secondV[i];
            }

            return new Vector(diffOfVectorCoordinates);
        }

        public static double operator * (Vector firstV, Vector secondV) 
        {
            if (firstV == null || secondV == null || firstV.Count != secondV.Count)
                throw new ArgumentException(Resource.EqualsLength);

            double[] prodOfVectorCoordinates = new double[firstV.Count];

            for (int i = 0; i < prodOfVectorCoordinates.Length; i++)
            {
                prodOfVectorCoordinates[i] = firstV[i] * secondV[i];
            }

            return prodOfVectorCoordinates.Sum();
        }

        public static double GetAngleBetweenVectors(Vector firstV, Vector secondV)
        {
            if (firstV == null || secondV == null || firstV.Count != secondV.Count)
                throw new ArgumentException(Resource.EqualsLength);

            return Math.Acos(firstV * secondV / (firstV.Length * secondV.Length));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < _coordinates.Length; i++)
            {
                sb.Append(_coordinates[i]);
            }

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            Vector vector = obj as Vector;

            if ((object)vector == null)
                return false;

            if (this._coordinates.Length != vector._coordinates.Length)
                return false;

            for (int i = 0; i < _coordinates.Length; i++)
            {
                if (_coordinates[i] != vector._coordinates[i])
                    return false;
            }

            return true;
        }


        public override int GetHashCode()
        {
            //
            return base.GetHashCode();
        }

        public static bool operator ==(Vector firstV, Vector secondV)
        {
            // If both are null, or both are same instance, return true.
            if (Object.ReferenceEquals(firstV, secondV))
                return true;

            // If one is null, but not both, return false.
            if (((object)firstV == null) || ((object)secondV == null))
                return false;

            return firstV.Equals(secondV);
        }

        public static bool operator !=(Vector firstV, Vector secondV)
        {
            return !(firstV == secondV);
        }   
    }
}
