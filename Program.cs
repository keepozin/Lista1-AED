using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace Lista1_AEDs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LISTA 1

            #region DADOS INICIAIS
            int opcao = 1;
            while (opcao != 0)
            {
                Console.WriteLine("1 - Exercício 1");
                Console.WriteLine("2 - Exercício 2");
                Console.WriteLine("3 - Exercício 3");
                Console.WriteLine("4 - Exercício 4");
                Console.WriteLine("5 - Exercício 5");
                Console.WriteLine("6 - Exercício 6");
                Console.WriteLine("7 - Exercício 7");
                Console.WriteLine("8 - Exercício 8");
                Console.WriteLine("0 - Sair");

                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Exercício: " + opcao);
                Console.WriteLine();
                #endregion

                switch (opcao)
                {
                    #region SAIR
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    #endregion

                    #region Exercício 1
                    case 1:
                        {
                            int[] vetor1 = { 150, 2245, 433, 760, 124 };
                            int maiorElemento = int.MaxValue;
                            int maiorIndice = 0;

                            Console.WriteLine(string.Join(", ", vetor1));

                            for (int i = 0; i < vetor1.Length; i++)
                            {
                                if (vetor1[i] < maiorElemento)
                                {
                                    maiorElemento = vetor1[i];
                                    maiorIndice = i;
                                }
                            }

                            vetor1[maiorIndice] = vetor1[0];
                            vetor1[0] = maiorElemento;

                            Console.WriteLine(string.Join(", ", vetor1));
                            break;
                        }
                    #endregion

                    #region Exercício 2
                    case 2:
                        {
                            int[] vetor1 = { 124, 5, 12, 55, 11 };
                            int[] vetor2 = { 5, 2, 6, 21, 7 };
                            double[] vetorSoma = new double[5];
                            double[] vetorProduto = new double[5];
                            double[] vetorDiferenca = new double[5];

                            Console.Write("Vetor 1: ");
                            Console.WriteLine(string.Join(", ", vetor1));
                            Console.Write("Vetor 2: ");
                            Console.WriteLine(string.Join(", ", vetor2));

                            for (int i = 0; i < vetor1.Length; i++)
                            {
                                vetorSoma[i] = vetor1[i] + vetor2[i];
                                vetorProduto[i] = vetor1[i] * vetor2[i];
                                vetorDiferenca[i] = vetor1[i] - vetor2[i];
                            }

                            Console.Write("Vetor Soma: ");
                            Console.WriteLine(string.Join(", ", vetorSoma));
                            Console.Write("Vetor Produto: ");
                            Console.WriteLine(string.Join(", ", vetorProduto));
                            Console.Write("Vetor Diferenca: ");
                            Console.WriteLine(string.Join(", ", vetorDiferenca));
                            break;
                        }
                    #endregion

                    #region Exercício 3
                    case 3:
                        {

                            break;
                        }
                    #endregion

                    #region Exercício 4
                    case 4:
                        {
                            int RecebeString(string S, char C, int I)
                            {
                                string subString = S.Substring(I);
                                subString.ToLower();
                                if (subString.Contains(C))
                                {
                                    int nOcorrencias = S.Count(d => char.Equals(d, C));
                                    //Console.WriteLine($"O caractere '{C}' aparece {nOcorrencias} vez(es) na string \"{S}\".");
                                    return nOcorrencias;
                                }
                                else
                                {
                                    //sConsole.WriteLine($"O caractere '{C}' não foi encontrado! Tente outra frase ou posição de início!");
                                    return 0;
                                }
                            }

                            Console.WriteLine("Digite uma string que deseja:");
                            string s = Console.ReadLine();

                            Console.WriteLine("Digite um caractere para procurar na string:");
                            char c = Convert.ToChar(Console.ReadLine());

                            if (!char.IsLetter(c)) //validacao do char
                            {
                                Console.WriteLine("Digite um caractere válido!. ");
                                c = Convert.ToChar(Console.ReadLine());
                            }

                            Console.WriteLine("Digite uma posição: ");
                            int i = Convert.ToInt16(Console.ReadLine());

                            if (i < 0 && i > s.Length)
                            {
                                Console.WriteLine("Digite uma posição válida!");
                                i = Convert.ToInt16(Console.ReadLine());
                            }

                            RecebeString(s, c, i);
                            break;
                        }
                    #endregion

                    #region Exercício 5
                    case 5:
                        {
                            string RetornaPalavras(string[] palavrasCensuradas, string fraseParam)
                            {
                                foreach (string palavra in palavrasCensuradas)
                                {
                                    fraseParam = fraseParam.Replace(palavra.Trim(), "[Censurado]");
                                }

                                return fraseParam;
                            }

                            string frase;
                            string[] vetorPalavrasCensuradas;

                            Console.WriteLine("Insira a lista de palavaras censuradas separadas por vírgula");
                            vetorPalavrasCensuradas = Console.ReadLine().Split(',');

                            Console.WriteLine("Digite uma frase: ");
                            frase = Console.ReadLine();

                            frase = (RetornaPalavras(vetorPalavrasCensuradas, frase));
                            Console.WriteLine(frase);

                            break;
                        }
                    #endregion

                    #region Exercício 6
                    case 6:
                        {
                            string RetornaMatriz()
                            {
                                string csv = "nome,idade,sexo\nAna,25,F\nJoão,30,M\nMaria,22,F";

                                return null;
                            }
                            break;
                        }
                    #endregion

                    #region Exercício 7
                    case 7:
                        {
                            double salarioComAumento;
                            void AumentarSalario(double salario, double porcentagem)
                            {
                                salarioComAumento = salario + (salario * (porcentagem / 100));
                            }

                            Console.WriteLine("Digite um salário: ");
                            double s = Convert.ToDouble(Console.ReadLine());
                            if (s < 0)
                            {
                                Console.WriteLine("Digite um valor válido!");
                                s = Convert.ToDouble(Console.ReadLine());
                            }

                            Console.WriteLine("Digite a porcentagem que deseja incrementar esse salário: ");
                            double porc = Convert.ToDouble(Console.ReadLine());

                            AumentarSalario(s, porc);
                            Console.WriteLine($"O salário de {s} teve um aumento de {porc}%, indo para {salarioComAumento}!");
                            break;
                        }
                    #endregion

                    #region Exercício 8 
                    case 8:
                        {
                            string strEntrada = "C:\\Users\\Victor Goddard\\Downloads\\Aula Prática - Arquivos_Alunos.txt";
                            string strSaida = "C:\\Users\\Victor Goddard\\Downloads\\Aula Prática - Arquivo_Alunos_Media.txt";

                            int numLinhas = File.ReadAllLines(strEntrada).Length;

                            string[] vetorNomes = new string[numLinhas];
                            double[] vetorMedias = new double[numLinhas];
                            string[] linhaCompleta;

                            string linha;
                            int index = 0;

                            using (StreamReader sr = new StreamReader(strEntrada))
                            {
                                while ((linha = sr.ReadLine()) != null)
                                {
                                    linhaCompleta = linha.Split(' ');

                                    if (linhaCompleta.Length > 1)
                                    {
                                        vetorNomes[index] = linhaCompleta[1];
                                        vetorMedias[index] = Math.Round((Convert.ToDouble(linhaCompleta[2], CultureInfo.InvariantCulture)
                                            + Convert.ToDouble(linhaCompleta[3], CultureInfo.InvariantCulture)
                                            + Convert.ToDouble(linhaCompleta[4], CultureInfo.InvariantCulture)) / 3.0, 2);
                                    }

                                    index++;
                                }
                            }

                            using (StreamWriter sw = new StreamWriter(strSaida))
                            {
                                for (int i = 0; i < vetorMedias.Length; i++)
                                {
                                    if (vetorMedias[i] >= 6.0)
                                    {
                                        sw.WriteLine($"A média do aluno {vetorNomes[i]} foi de {vetorMedias[i]}", vetorNomes[i], vetorMedias[i]);
                                    }
                                }
                            }

                            break;
                        }
                    #endregion

                    default:
                        {
                            Console.WriteLine("Digite uma opção válida!");
                            break;
                        }
                }

                Console.WriteLine("----------------------------");
            }
            #endregion
        }
    }
}