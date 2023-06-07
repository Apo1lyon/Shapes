using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{   
    /// <summary>
    ///Класс-родитель всех фигур 
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double Square();

        const long ExponentMask = 0x7FF0000000000000;
        /// <summary>
        /// Определяет, является ли заданное значение нормальным.
        /// </summary>
        /// <param name="v">Число двойной точности с плавающей запятой.</param>
        /// <returns></returns>
        public virtual bool IsNormal(double v)
        {
            long bithack = BitConverter.DoubleToInt64Bits(v);
            bithack &= ExponentMask;
            return (bithack != 0) && (bithack != ExponentMask);
        }
    }
}
