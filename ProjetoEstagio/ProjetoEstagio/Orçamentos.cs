using System;

namespace ProjetoEstagio
{
    class Orçamento
    {

        private int numero;
        private DateTime data;
        private string cliente;
        private double total;

        public Orçamento(int numero, string cliente, double total)
        {
            this.numero = numero;
            this.cliente = cliente;
            this.total = total;
            this.data = DateTime.Now;
        }

        public int getNumero()
        {
            return numero;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;

        }

        public DateTime getData()
        {
            return data;
        }

        public void setData(DateTime data)
        {
            this.data = data;


        }


        public string getCliente()
        {
            return cliente;
        }

        public void setCliente(string cliente)
        {
            this.cliente = cliente;

        }


        public double getTotal()
        {
            return total;
        }

        public void setTotal(double total)
        {
            this.total = total;

        }

    }
}
