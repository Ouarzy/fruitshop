using System;

namespace FruitShop
{
    public class Calculator
    {
        private int currentValue;

        public void Add(int value)
        {
            currentValue += value;
        }

        public int Sum()
        {
            return currentValue;
        }
    }
}
