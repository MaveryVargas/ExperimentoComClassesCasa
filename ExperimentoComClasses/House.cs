using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExperimentoComClasses
{
    class House
    {
        Boolean prop;
        private string nomeDono;

        public void Dono()
        {
            nomeDono = "Mavery";
            string EndCasa = "Rua XPTO, bairro TESTE, num 000";

            Console.WriteLine("Voce e o dono da casa? (Digite 1 para verdadeiro ou 0 para falso)");
            prop =Convert.ToBoolean(Console.ReadLine());
            if(prop == true)
            {
                Console.WriteLine("Qual é seu nome?");
                Console.WriteLine("Voce de nome "+nomeDono+" é proprietario da casa no endereço"+EndCasa);
            }
            else
            {
                Console.WriteLine("Você nao e o dono da casa");
            }
        }

        public bool VerificaDono()
        {
            string nomeDono = "Mavery";
            Console.WriteLine("Digite o seu nome");
            var aux = Convert.ToString(Console.ReadLine());
            if (aux == nomeDono)
            {
                Console.WriteLine("Você pode entrar");
                return true;
            }
            else Console.WriteLine("Voce nao é o dono, nao pode entrar");
            return false;
        }
        public void Acende()
        {
            Console.WriteLine("As luzes estao acesas");
        }
        public void Apagar()
        {
            Console.WriteLine("As luzes estao apagadas");
        }
    }
}
