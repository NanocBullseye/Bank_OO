using System;

namespace CS_BankSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerenteSauron = new Gerente()
            {
                Nome = "Sauron",
                CPF = "125.238.456-44",
                Salario = 8000,
                NumeroDeAgencias = 2,
            };

            Vendedor vendedorHagar = new Vendedor()
            {
                Nome = "Hagar",
                CPF = "123.456.789-10",
                Salario = 3000,
                NumeroClientesAtendidos = 3,
            };

            Vendedor vendedorOliver = new Vendedor()
            {
                Nome = "Oliver",
                CPF = "109.876.543-21",
                Salario = 5000,
                NumeroClientesAtendidos = 8,
            };

            Vendedor vendedorPatrick = new Vendedor()
            {
                Nome = "Patrick",
                CPF = "666.666.666-66",
                Salario = 4000,
                NumeroClientesAtendidos = 12,
            };

            vendedorOliver.Bonificacao = vendedorOliver.Salario;
            vendedorHagar.Bonificacao = vendedorHagar.Salario;
            gerenteSauron.Bonificacao = gerenteSauron.Salario;
            vendedorPatrick.Bonificacao = vendedorPatrick.Salario;

            ContaCorrente contaDanilo = new ContaCorrente("Danilo Ribeiro Gaspar", 9999, 15000, vendedorPatrick);
            contaDanilo.Conta = 789;
            ContaCorrente contaMarta = new ContaCorrente("Marta", 8888, 12000, vendedorOliver);
            contaMarta.Conta = 789;
            ContaCorrente contaTyrael = new ContaCorrente("Tyrael", 0914, 20000, vendedorHagar);
            contaTyrael.Conta = 123;

            Console.WriteLine("Contas:\n");
            Console.WriteLine("Conta 1:\nNome: " + contaDanilo.Titular +
            "\nAgência: " + contaDanilo.Agencia +
            "\nSaldo: " + contaDanilo.Saldo);

            Console.WriteLine("\nConta 2:\nNome: " + contaGustavo.Titular +
            "\nAgência: " + contaMarta.Agencia +
            "\nSaldo: " + contaMarta.Saldo);

            Console.WriteLine("\nConta 3:\nNome: " + contaJoao.Titular +
            "\nAgência: " + contaTyrael.Agencia +
            "\nSaldo: " + contaTyrael.Saldo);

            Console.WriteLine("\n---------------------\nFuncinários:\n");
            Console.WriteLine("Vendedor 1:\nNome: " + vendedorHagar.Nome +
            "\nCPF: " + vendedorHagar.CPF + "\nSalário: " + vendedorHagar.Salario +
            "\nBonificação: " + vendedorHagar.Bonificacao +
            "\nDias de férias: " + vendedorHagar.CalcularFerias() +
            "\nRemuneração total: " + vendedorHagar.RemuneracaoTotal(vendedorHagar.Salario, vendedorHagar.Bonificacao));

            Console.WriteLine("\nVendedor 2:\nNome: " + vendedorOliver.Nome +
            "\nCPF: " + vendedorOliver.CPF + "\nSalário: " + vendedorOliver.Salario +
            "\nBonificação: " + vendedorOliver.Bonificacao +
            "\nDias de férias: " + vendedorOliver.CalcularFerias() +
            "\nRemuneração total: " + vendedorOliver.RemuneracaoTotal(vendedorOliver.Salario, vendedorOliver.Bonificacao));

            Console.WriteLine("\nVendedor 3:\nNome: " + vendedorPatrick.Nome +
            "\nCPF: " + vendedorPatrick.CPF + "\nSalário: " + vendedorPatrick.Salario +
            "\nBonificação: " + vendedorPatrick.Bonificacao +
            "\nDias de férias: " + vendedorPatrick.CalcularFerias() +
            "\nRemuneração total: " + vendedorPatrick.RemuneracaoTotal(vendedorPatrick.Salario, vendedorPatrick.Bonificacao));

            Console.WriteLine("\nGerente:\nNome: " + gerenteSauron.Nome +
            "\nCPF: " + gerenteSauron.CPF + "\nSalário: " + gerenteSauron.Salario +
            "\nBonificação: " + gerenteSauron.Bonificacao +
            "\nDias de férias: " + gerenteSauron.CalcularFerias() +
            "\nRemuneração total: " + gerenteSauron.RemuneracaoTotal(gerenteSauron.Salario));

            Console.WriteLine("\nContas criadas: " + ContaCorrente.TotaldeContasCriadas);
        }
    }
}
