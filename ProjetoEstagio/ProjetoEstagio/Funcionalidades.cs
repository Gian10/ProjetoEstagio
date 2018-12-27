using System;
using System.Collections.Generic;
using System.Linq;


namespace ProjetoEstagio
{
    class Funcionalidades
    {

        List<Orçamento> array = new List<Orçamento>();

        public void CadastroOrcamento(Orçamento orca)
        {
            array.Add(orca);
        }

        public List<Orçamento> ListarOrçamento()
        {
            return array;

        }

        public double Maior()   
        {
           double maior = 0;
           foreach(Orçamento o in array) {
                if (maior < o.getTotal() ) {
                    maior = o.getTotal();
                    
                }
            }

            return maior;
        }

        public double Soma()
        {
            double total = 0;
            foreach(Orçamento o in array) {

                total += o.getTotal();
            }

            return total;
        }
    }  
 }

