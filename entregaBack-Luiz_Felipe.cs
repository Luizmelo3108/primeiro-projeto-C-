using System;

namespace ConsoleApp311
{
    public class Program
    {
        static void Main(string[] args)
        {
            string controleDeSaida = "S";

            while (controleDeSaida.ToUpper() == "S")
            {
                Console.WriteLine("\n\r Bem vindo ao nosso sistema sign-up, antes de começarmos, digite o seu nome por favor ! \n\r");

                Console.Write("Nome : ");
                string nome = Console.ReadLine();

                Console.WriteLine("\n\r Óla {0} ! Para prosseguirmos, preciso saber sua data de nascimento.\n\r", nome);

                Console.Write("Digite sua data de nascimento : ");
                string dtNascimento = Console.ReadLine();

                if (ValidaIdade(dtNascimento))
                {

                    Console.Write("Digite seu CPF : ");
                    string CPF = Console.ReadLine();

                    Console.Write("Digite seu e-mail :");
                    string email = Console.ReadLine();

                    Console.WriteLine("\n\r Antes de finalizarmos por favor verifique seus dados abaixo.");

                    Console.WriteLine("\n\r Nome: {0}  \n\r Nascimento : {1} \n\r CPF : {2} \n\r E-mail : {3} ", nome, dtNascimento, CPF, email);

                    Console.WriteLine("\n\r Todos os dados estão corretos ? digite S ou N ");
                    string confDados = Console.ReadLine();

                    if (confDados.ToUpper() == "S")
                    {
                        Console.WriteLine("\n\r Cadastro concluído com sucesso . ");
                        controleDeSaida = "N";
                    }
                    else
                    {
                        Console.Clear();
                    }

                }
                else
                {
                    controleDeSaida = "N";
                }               
            }
        }

        static private bool ValidaIdade(string dataDeNascimento)
        {
            DateTime dtNascimento = Convert.ToDateTime(dataDeNascimento);

            int idade = DateTime.Now.Year - dtNascimento.Year;

            if (idade < 24)
            {
                Console.WriteLine("Sentimos muito, mas infelizmente não será possível prosseguir com o cadastro. Agradecemos a preferência!");
                return false;
            }
            else
            {
                Console.WriteLine("Tudo Certo Vamos Prosseguir.");
                return true;
            }

        }

    }
}
