﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class Sicp
    {
        // f(n) = n if n < 3, and f(n) = f(n - 1) + 2f(n - 2) + 3f(n - 3) if n >= 3.
        public int Function(int n)
        {
            if (n < 3)
            {
                return n;
            }
            else
            {
                return Function(n - 1) + (2 * Function(n - 2)) + (3 * Function(n - 3));
            }
        }

        public int FactorialRecursion(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            
            return number * FactorialRecursion(number - 1);
        }

        public int FactorialIterative(int number)
        {
            int Iter(int counter, int acc)
            {
                if (counter > number)
                {
                    return acc;
                }

                return Iter(counter + 1, counter * acc);
            }

            return Iter(1, 1);
        }

        public int FibonachiRecursion(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }

            return FibonachiRecursion(n - 1) + FibonachiRecursion(n - 2);
        }

        /*public int FibonachiIterative(int n)
        {
            int Iter(int counter, int num1, int num2)
            {
                if (n == 0) { return 0; }
                else if (n == 1 || n == 2) { return 1; }

                else if (counter > n)
                {
                    return num1 + num2;
                }
                
                return Iter(counter + 1, num1 + 1, num2 + 1);
            }

            return Iter(2, 0, 1);
        }

        public void FibbonachiArray(int n)
        {
            var arrayNumbers = new int[n];
            arrayNumbers[0] = 0;
            arrayNumbers[1] = 1;
            arrayNumbers[2] = 1;

            var j1 = 1;
            var j2 = 2;

            for (var i = 3; i <= arrayNumbers.Length - 1; i++, j1++, j2++)
            {
                arrayNumbers[i] = arrayNumbers[j1] + arrayNumbers[j2];
            }

            foreach (var m in arrayNumbers)
            {
                Console.WriteLine(m);
            }
        }*/

        public int PascalTriangle(int row, int column)
        {
            if (column > row)
            {
                return 0;
            }
            else if (column < 0)
            {
                return 0;
            }
            else if (column == 1)
            {
                return 1;
            }
            else 
            {
                return PascalTriangle(row - 1, column - 1) + PascalTriangle(row - 1, column);
            }
        }

        public int ExponentiationRecursion(int number, int degree)
        {
            if (degree == 0)
            {
                return 1;
            }

            return number * ExponentiationRecursion(number, degree - 1);
        }

        public int ExponentiationLoop(int number, int degree)
        {
            if (degree == 0) { return 1; }

            var result = 1;
            var counter = 0;
            while (counter != degree)
            {
                result = result * number;
                counter++;
            }

            return result;
        }

        public int ExponentiationIterativeUp(int number, int degree)
        {
            int Iter(int counter, int acc)
            {
                if (counter > degree)
                {
                    return acc;
                }

                return Iter(counter + 1, acc * number);
            }

            return Iter(1, 1);
        }

        public int ExponentiationIterativeDown(int number, int degree)
        {
            int Iter(int counter, int acc)
            {
                if (counter == 0) { return acc; }

                return Iter( counter - 1, acc * number);
            }

            return Iter(degree, 1);
        }

        public int ExponentiationIterativeDegreeDivisionTwo(int number, int degree)
        {
            int Iter(int counter, int acc)
            {
                if (counter > degree)
                {
                    return acc;
                }

                return Iter(counter + 1, acc * number);
            }

            if (number % 2 == 0)
            {
                return Iter(1, 1);
            }
            else
            {
                return number * Iter(1, 1);
            }
        }

        public int ExponentiationRecursionDegreeDivisionTwo(int number, int degree)
        {
            int Square(int n)
            {
                return n * n;
            }

            if (degree == 0) { return 1; }
            if (degree == 1) { return number; }

            else if (degree % 2 == 0)
            {
                return Square(ExponentiationRecursionDegreeDivisionTwo(number, degree / 2));
            }
            else
            {
                return number * Square(ExponentiationRecursionDegreeDivisionTwo(number, degree - 1));
            }
        }
    }
}