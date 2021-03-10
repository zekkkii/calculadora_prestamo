using System;

namespace LogicLayer
{
    public class Calcular
    {
       


        public double calcularMontoPagar(double monto, int mesesPago,int porciento)
        {
            double porcentaje = (monto * porciento) / 100;  
            double resultado = porcentaje + monto;
            return resultado / mesesPago;
        }




    }
}
