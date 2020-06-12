using System;
using System.Globalization;

namespace ExercicioLista
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public Funcionario()
        {
        }
        public void AumentoSalario(double valor)
        {
            Salario += Salario * valor / 100;
        }
        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }     
}
