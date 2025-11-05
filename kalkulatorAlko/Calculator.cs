using System;

namespace kalkulatorAlko
{
    public class Calculator
    {
        // Метод для расчета общего объема жидкости
        public double CalculateTotalVolume(double capacity, int quantity)
        {
            return capacity * quantity;
        }

        // Метод для расчета объема чистой субстанции
        public double CalculatePureSubstance(double capacity, double percentage, int quantity)
        {
            double totalVolume = CalculateTotalVolume(capacity, quantity);
            return totalVolume * (percentage / 100.0);
        }
    }
}