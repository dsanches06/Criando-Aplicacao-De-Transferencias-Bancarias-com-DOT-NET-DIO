using DIO.AppBank.Model;
using DIO.AppBank.Model.Enum;
using System;

namespace DIO.AppBank
{
    class Program
    {
         static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Danilson Sanches");
            minhaConta.Depositar(100);
            Console.WriteLine(minhaConta.ToString());
        }
    }
}
