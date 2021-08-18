using System;
using System.Collections.Generic;
using System.Text;

namespace test_99999999
{
    class Despesas
    {
        public int Cpf { get; }
        public int Dia { get; set; }
        public int Valor { get; set; }
        public int Mes { get; set; }
        public int Somames { get; set; }
        public int Ano { get; set; }

        int[] x = new int[10];
        public int Dadosdia()
        {
            for (int i = 0; i < 30; i++)
            {
                return Dia + 1;
            }
        }
        public int Dadosmes()
        {
            for (int i = 0; i <= 12; i++)
            {
                return Mes ;
                
            }
        }
        public int valoresmes()
        {
            return Somames = Valor + Valor;
        }
        public int valoresano()
        {
            return Ano = Mes + Mes;
        }
        public override string ToString()
        {
            return $"";
        }
    }    
}
