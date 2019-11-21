using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaMesAno
{
    class DiaMesAno
    {
        private DateTime data;
        public string recebe
        {
            set
            {
                data = Convert.ToDateTime(value);
            }
        }

        public string envia
        {
            get
            {
                DateTime hoje = DateTime.Now;

                int anos = hoje.Year - data.Year;
                int mês = hoje.Month - data.Month;

                if (mês < 0)
                {
                    anos--;
                    mês += 12;
                }

                int dias = hoje.Day - data.Day;
                if (mês < 0)
                {

                    mês--;
                    dias += 30;
                }

                string frase = "A sua idade é ";
                frase += anos.ToString() + " anos ";
                frase += mês.ToString() + " meses ";
                frase += dias.ToString() + " dias ";

                return frase;
            }
        }
    }
}
