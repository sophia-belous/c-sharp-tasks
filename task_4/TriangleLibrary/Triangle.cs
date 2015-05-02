using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleLibrary
{
    public struct PointOfTriangle
    {
        public int X;
        public int Y;


        PointOfTriangle(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static double GetDistanceOfPoints(PointOfTriangle pointFirst, PointOfTriangle pointSecond)
        {
            return Math.Pow(Math.Pow(pointFirst.Y - pointSecond.Y, 2) + Math.Pow(pointFirst.X - pointSecond.X, 2), 0.5);
        }
    }

    public class Triangle
    {
        static int temp = 0;
        private double _sideFirst;
        private double _sideSecond;
        private double _sideThird;

        public double SideFirst  
        {
            get
            {
                return _sideFirst; 
            }
            set
            {
                if (IsNotTriangle(value, _sideSecond, _sideThird))
                    _sideFirst = value;                    		 
                else
                    throw new ArgumentException();
            }
        }

        public double SideSecond
        {
            get
            {
                return _sideSecond;
            }
            set
            {
                if (IsNotTriangle(_sideFirst, value, _sideThird))
                    _sideSecond = value;
                else
                    throw new ArgumentException();
            }
        }

        public double SideThird
        {
            get
            {
                return _sideThird;
            }
            set
            {
                if (IsNotTriangle(_sideFirst, _sideSecond, value))
                    _sideThird = value;
                else
                    throw new ArgumentException();
            }
        }

        public Triangle(PointOfTriangle pointFirst, PointOfTriangle pointSecond, PointOfTriangle pointThird)
        {
            SideFirst = PointOfTriangle.GetDistanceOfPoints(pointFirst, pointSecond);
            SideSecond = PointOfTriangle.GetDistanceOfPoints(pointSecond, pointThird);
            SideThird = PointOfTriangle.GetDistanceOfPoints(pointThird, pointFirst);

            if (IsNotTriangle(SideFirst, SideSecond, SideThird))
                throw new ArgumentException();

                temp++;
        }

        public Triangle(double sideFirst, double sideSecond, double sideThird)
        {
            SideFirst = sideFirst;
            SideSecond = sideSecond;
            SideThird = sideThird;

            if (IsNotTriangle(SideFirst, SideSecond, SideThird))
                throw new ArgumentException();

            temp++;
        }

        private bool IsNotTriangle(double sideFirst, double sideSecond, double sideThird)
        {
            if (sideFirst <= 0 || sideFirst <= 0 || sideFirst <= 0)
                return true;
            if ((sideFirst + sideSecond <= sideThird) || (sideSecond + sideThird <= sideFirst) || (sideFirst + sideThird <= sideSecond))
                return true;

            return false;
            
        }

        public double GetPerimeter()
        {
            return SideFirst + SideSecond + SideThird;
        }

        public double GetSquare() 
        {
            double halfPerimeter = GetPerimeter() / 2;
            return Math.Pow(halfPerimeter * (halfPerimeter - SideFirst) * (halfPerimeter - SideSecond) * (halfPerimeter - SideThird), 0.5);
        }

        static int CompareTriangles(Triangle triangleFirst, Triangle triangleSecond)
        {
            if (triangleFirst == null || triangleSecond == null)
                throw new ArgumentNullException();

            if (triangleFirst.GetSquare() > triangleSecond.GetSquare())
                return 1;
            else if (triangleFirst.GetSquare() == triangleSecond.GetSquare())
                return 0;
            else
                return -1;
        }

    }
}
