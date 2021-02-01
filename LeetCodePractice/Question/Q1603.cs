using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Question
{
    public class Q1603
    {
        int _big = 0;
        int _medium = 0;
        int _small = 0;

        public Q1603(int big, int medium, int small)
        {
            _big = big;
            _medium = medium;
            _small = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    if (_big > 0)
                    {
                        _big--;
                        return true;
                    }
                    return false;
                case 2:
                    if (_medium > 0)
                    {
                        _medium--;
                        return true;
                    }
                    return false;
                case 3:
                    if (_small > 0)
                    {
                        _small--;
                        return true;
                    }
                    return false;
                default:
                    break;
            }
            return true;
        }
    }
}
