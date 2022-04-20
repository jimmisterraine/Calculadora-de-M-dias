using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace p15_CalculandoMedias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 15 - Notas");
            char linha = ' ';
            Console.Write(linha);
            Console.Write(linha);

            Console.WriteLine("Digite a sua nota na disciplina de Português");
            int Portugues = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua nota na disciplina de Matemática");
            int Matematica = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua nota na disciplina de Inglês");
            int Ingles = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua nota na disciplina de Ciencias");
            int Ciencias = int.Parse(Console.ReadLine());

            int soma = Ciencias + Portugues + Ingles + Matematica;
            float media = (float)soma;
            float mediaFinal = media / 4;

            int maiorNota = ' ';

            if (Portugues > Ingles && Portugues > Ciencias && Portugues > Matematica)
            {
                maiorNota = 001;
            }
            else if (Ingles > Portugues && Ingles > Ciencias && Ingles > Matematica)
            {
                maiorNota = 002;
            }
            else if (Matematica > Ingles && Matematica > Ciencias && Matematica > Portugues)
            {
                maiorNota = 003;
            }
            else if (Ciencias > Ingles && Ciencias > Portugues && Ciencias > Matematica)
            {
                maiorNota = 004;
            }
            else
            {
                return;
            }
            
            switch(maiorNota)
            {
                case 001:
                    //portugues
                    Console.WriteLine("Sua maior nota foi na disciplina de PORTUGUÊS");
                    break;
                case 002:
                    //ingles
                    Console.WriteLine("Sua maior nota foi na disciplina de INGLÊS");
                    break;
                case 003:
                    //matematica
                    Console.WriteLine("Sua maior nota foi na disciplina de MATEMÁTICA");
                    break;
                case 004:
                    //CIENCIAS
                    Console.WriteLine("Sua maior nota foi na disciplina de CIÊNCIAS");
                    break;
            }

            int menorNota = ' ';

            if (Portugues < Ingles && Portugues < Ciencias && Portugues < Matematica)
            {
                menorNota = 0010;
            }
            else if (Ingles < Portugues && Ingles < Ciencias && Ingles < Matematica)
            {
                menorNota = 0020;
            }
            else if (Matematica < Ingles && Matematica < Ciencias && Matematica < Portugues)
            {
                menorNota = 0030;
            }
            else if (Ciencias < Ingles && Ciencias < Portugues && Ciencias < Matematica)
            {
                menorNota = 0040;
            }
            else
            {
                return;
            }

            switch (menorNota)
            {
                case 0010:
                    //portugues
                    Console.WriteLine("Sua menor nota foi na disciplina de PORTUGUÊS");
                    break;
                case 0020:
                    //ingles
                    Console.WriteLine("Sua menor nota foi na disciplina de INGLÊS");
                    break;
                case 0030:
                    //matematica
                    Console.WriteLine("Sua menor nota foi na disciplina de MATEMÁTICA");
                    break;
                case 0040:
                    //CIENCIAS
                    Console.WriteLine("Sua menor nota foi na disciplina de CIÊNCIAS");
                    break;
            }

            if ((soma / 4) <= 6)
            {
                Console.WriteLine("Sua média final foi de " + mediaFinal);
                Console.WriteLine("*********VOCE É BURRO, DESISTE!*********");
            }
            else
            {
                Console.WriteLine("Sua média final foi de " + mediaFinal);
                Console.WriteLine("*********PARABÉNS, VC É INTELIGENTE*********");
            }

            Console.WriteLine(' ');
            Console.WriteLine("Execução finalizada. Tecle ENTER para encerrar");
            Console.ReadLine();
        }
    }
}