using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Shape
    {
        //Поля для чтения
        private readonly double radius;
        
        //Поля
        private double? square;

        /// <summary>
        /// Конструктор, для построения круга
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            if (!IsNormal(radius) || radius <= 0)
                throw new ArgumentOutOfRangeException(nameof(radius), "Должно быть положительное число.");
            this.radius = radius;
        }

        /// <summary>
        /// Площадь круга
        /// </summary>
        /// <returns></returns>
        public override double Square()
        {
            if (square is null)
            {
                square = Math.PI * radius * radius;
            }
            return square.Value;
        }
    }

    /// <summary>
        /// Треугольник
        /// </summary>
    public class Triangle : Shape
    {
        //Поля для чтения
        private readonly double firstSide;
        private readonly double secondSide;
        private readonly double thirdSide;
        
        //Поля
        private double? square;
        private bool? isExists;
        private bool? isSquareness;

        /// <summary>
        /// Конструктор, для построения треугольника
        /// </summary>
        /// <param name="firstSide">Первая сторона</param>
        /// <param name="secondSide">Вторая сторона</param>
        /// <param name="thirdSide">Третья сторона</param>
        /// <exception cref="ArgumentOutOfRangeException">Исключение на проверку положительных чисел</exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (!IsNormal(firstSide) || firstSide <= 0)
                throw new ArgumentOutOfRangeException(nameof(firstSide), "Должно быть положительное число.");
            if (!IsNormal(secondSide) || secondSide <= 0)
                throw new ArgumentOutOfRangeException(nameof(secondSide), "Должно быть положительное число.");
            if (!IsNormal(thirdSide) || thirdSide <= 0)
                throw new ArgumentOutOfRangeException(nameof(thirdSide), "Должно быть положительное число.");
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns></returns>
        public override double Square()
        {
            if (square is null)
            {
                double Perimeter = (firstSide + secondSide + thirdSide) / 2;
                double s = Math.Sqrt(Perimeter * (Perimeter - firstSide) * (Perimeter - secondSide) * (Perimeter - thirdSide)); //Формула Герона
                square = s;
            }
            return square.Value;
        }

        /// <summary>
        /// Проверка правильного значения площади
        /// </summary>
        public bool IsExists
        {
            get
            {
                if (isExists is null)
                {
                    isExists = IsNormal(Square());
                }
                return isExists.Value;
            }
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsSquareness
        {
            get
            {
                if (!IsExists)
                    return false;

                if (isSquareness is null)
                {
                    double a = firstSide, b = secondSide, c = thirdSide;
                    if (c < b)
                        (c, b) = (b, c);
                    if (c < a)
                        (c, a) = (a, c);
                    isSquareness = c * c == b * b + a * a;
                }
                return isSquareness.Value;
            }
        }
    }
}
