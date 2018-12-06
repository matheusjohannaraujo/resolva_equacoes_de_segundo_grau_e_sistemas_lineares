using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolvaCalculosMatematicos
{
    class Program
    {
        //  Função de conversão de String para Double
        static Double ConV(String valor)
        {
            if (valor == "")
            {
                valor = "0";
                Double cv = Convert.ToDouble(valor);
                return cv;
            }
            else
            {
                Double cv = Convert.ToDouble(valor);
                return cv;
            }
        }
        static void Main(string[] args)
        {
            String resposta = "n";
            while (resposta == "n")
            {
                //  CONFIGURAÇÃO DO CONSOLE
                Console.Title = "Resolva seu problemas matemáticos | Desenvolvido por: Matheus Johann Araújo";
                Console.BackgroundColor = ConsoleColor.DarkGray;//  Muda a cor da tela.
                Console.ForegroundColor = ConsoleColor.White;// Muda a cor da letra.
                Console.Clear();
                Console.WriteLine("\n Calcular Sistemas Lineares 2x2 ... 1");
                Console.WriteLine("\n Calcular Equação do 2º Grau ...... 2");
                Console.WriteLine("\n Sair do programa.................. 3");
                Console.Write("\n Digite o número da opção desejada: ");
                String op = Convert.ToString(Console.ReadLine());
                switch (op)
                {
                    case "1":
                        resposta = "s";
                        while (resposta == "S" || resposta == "s")
                        {
                            //  VARIAVEIS
                            Double ixc, iyc, izc, ixb, iyb, izb, IXCxIYB, IXBxIYC, delta, IZCxIZB, IZBxIYC, deltax, IXCxIZB, IXBxIZC, deltay, calx, caly;
                            //  CONFIGURAÇÃO DO CONSOLE
                            Console.Title = "Calculador de Sistemas Lineares 2x2 | Desenvolvido por: Matheus Johann Araújo";
                            Console.BackgroundColor = ConsoleColor.DarkBlue;// Muda a cor da tela.
                            Console.ForegroundColor = ConsoleColor.White;// Muda a cor da letra.
                            Console.Clear();
                            Console.WriteLine(" ----------------------------------------");
                            Console.WriteLine("  Sistema Linear - Resolvendo por Cramer");
                            Console.WriteLine(" ----------------------------------------");
                            Console.WriteLine("                     ---------------");
                            Console.WriteLine(" Fileira Superior -> (x) | (y) = (?) ");
                            Console.WriteLine(" Fileira Inferior -> (x) | (y) = (?) ");
                            Console.WriteLine("                     ---------------");
                            Console.WriteLine(" Digite cada valor com seu respectivo sinal (+/-)");
                            Console.Write("\n Digite a incognita (x) da fileira superior: ");
                            ixc = ConV(Console.ReadLine());
                            Console.Write(" Digite a incognita (y) da fileira superior: ");
                            iyc = ConV(Console.ReadLine());
                            Console.Write(" Digite a incognita (?) da fileira superior: ");
                            izc = ConV(Console.ReadLine());
                            Console.Write("\n Digite a incognita (x) da fileira inferior: ");
                            ixb = ConV(Console.ReadLine());
                            Console.Write(" Digite a incognita (y) da fileira inferior: ");
                            iyb = ConV(Console.ReadLine());
                            Console.Write(" Digite a incognita (?) da fileira inferior: ");
                            izb = ConV(Console.ReadLine());
                            Console.WriteLine(ixc + " " + iyc + " " + izc + " " + ixb + " " + iyb + " " + izb);

                            //  CALCULA O DELTA
                            IXCxIYB = (ixc * iyb);
                            IXBxIYC = (ixb * iyc);
                            delta = (IXCxIYB - IXBxIYC);
                            //  TERMINA DE CALCULAR O DELTA

                            //  CALCULA O DeltaX
                            IZCxIZB = (izc * iyb);
                            IZBxIYC = (izb * iyc);
                            deltax = (IZCxIZB - IZBxIYC);
                            //  TERMINA DE CALCULAR O DeltaY

                            //  CALCULA O DeltaY
                            IXCxIZB = (ixc * izb);
                            IXBxIZC = (ixb * izc);
                            deltay = (IXCxIZB) - (IXBxIZC);
                            //  TERMINA DE CALCULAR O DeltaY

                            //  CALCULA O CONJUNTO SOLUÇÃO {X,Y}
                            calx = (deltax / delta);
                            caly = (deltay / delta);
                            //  TERMINA DE CALCULAR O CONJUNTO SOLUÇÃO {X,Y}

                            Console.WriteLine(" ------------------------------------------");
                            Console.WriteLine("  Seu Sistema Linear foi:");
                            Console.WriteLine("  Parte Superior -> [ " + ixc + " ] [ " + iyc + " ] = [ " + izc + " ]");
                            Console.WriteLine("  Parte Inferior -> [ " + ixb + " ] [ " + iyb + " ] = [ " + izb + " ]");
                            Console.WriteLine(" ------------------------------------------");
                            Console.WriteLine("\n ------------------------------------------------------------------------------");
                            Console.WriteLine("  DELTA POR  . [ " + ixc + " ] [ " + iyc + " ] -> " + ixb + " x " + iyc + " = [ " + IXBxIYC + " ]");
                            Console.WriteLine("   CRAMER    . [ " + ixb + " ] [ " + iyb + " ] -> " + ixc + " x " + iyb + " = [ " + IXCxIYB + " ]");
                            Console.WriteLine("  Resolução: [ " + IXCxIYB + " ] - [ " + IXBxIYC + " ] -> Logo seu Delta foi: [ " + delta + " ]");
                            Console.WriteLine("\n ------------------------------------------------------------------------------");
                            Console.WriteLine("\n ------------------------------------------------------------------------------");
                            Console.WriteLine("  DeltaX POR  . [ " + izc + " ] [ " + iyc + " ] -> " + izb + " x " + iyc + " = [ " + IZBxIYC + " ]");
                            Console.WriteLine("    CRAMER    . [ " + izb + " ] [ " + iyb + " ] -> " + izc + " x " + iyb + " = [ " + IZCxIZB + " ]");
                            Console.WriteLine("\n  Resolução: [ " + IZCxIZB + " ] - [ " + IZBxIYC + " ] -> Logo seu Delta foi: [ " + deltax + " ]");
                            Console.WriteLine(" ------------------------------------------------------------------------------");
                            Console.WriteLine("\n ------------------------------------------------------------------------------");
                            Console.WriteLine("  DeltaY POR  . [ " + ixc + " ] [ " + izc + " ] -> " + ixb + " x " + izc + " = [ " + IXBxIZC + " ]");
                            Console.WriteLine("    CRAMER    . [ " + ixb + " ] [ " + izb + " ] -> " + ixc + " x " + izb + " = [ " + IXCxIZB + " ]");
                            Console.WriteLine("\n  Resolução: [ " + IXCxIZB + " ] - [ " + IXBxIZC + " ] -> Logo seu Delta foi: [ " + deltay + " ]");
                            Console.WriteLine(" ------------------------------------------------------------------------------");
                            Console.WriteLine("\n ------------------------------------------------------------------------------");
                            Console.WriteLine("  O (x) do S.Linear é: (DeltaX / DELTA) [ " + deltax + " /" + delta + " ] = [ " + calx + " ]");
                            Console.WriteLine("  O (y) do S.Linear é: (DeltaY / DELTA) [ " + deltay + " /" + delta + " ] = [ " + caly + " ]");
                            Console.WriteLine("\n  Logo seu conjunto solução sera: { " + calx + " e " + caly + " }");
                            Console.WriteLine(" ------------------------------------------------------------------------------");
                            Console.WriteLine("\n ---- Seu Sistema Linear montado foi este -------------------------------------");
                            Console.WriteLine("\n  [ " + ixc + " ] [ " + iyc + " ] = [ " + izc + " ]");
                            Console.WriteLine("  [ " + ixb + " ] [ " + iyb + " ] = [ " + izb + " ]");
                            Console.WriteLine("\n ---- Respostas do seu Sistema Linear abaixo-----------------------------------");
                            Console.WriteLine("\n -> O Delta é:  [ " + delta + " ]");
                            Console.WriteLine(" -> O DeltaX é: [ " + deltax + " ]");
                            Console.WriteLine(" -> O DeltaY é: [ " + deltay + " ]");
                            Console.WriteLine(" -> O conjunto Solução é: { (" + calx + ") e (" + caly + ") }");
                            Console.Write("\n Deseja realizar outro calculo de S.Linear? (S/N): ");
                            resposta = Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case "2":
                        resposta = "s";
                        while (resposta == "S" || resposta == "s")
                        {
                            //  CONFIGURAÇÃO DO CONSOLE
                            Console.Title = "Calculador de Equação do 2º Grau | Desenvolvido por: Matheus Johann Araújo";
                            Console.BackgroundColor = ConsoleColor.DarkRed;// Muda a cor da tela.
                            Console.ForegroundColor = ConsoleColor.White;// Muda a cor da letra.
                            Console.Clear();
                            //  INSERINDO OS VALORES NAS VARIAVEIS
                            Double a, b, c, delta, raizdelta, x1, x2, xv, yv = 0;
                            Console.WriteLine(" ----------------------------");
                            Console.WriteLine("  CALCULA EQUAÇÃO DO 2º GRAU");
                            Console.WriteLine(" ----------------------------");
                            Console.WriteLine("\n ----VALORES DA EQUAÇÃO----");
                            Console.Write("\n  Qual é o valor de (a)? ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\n  Qual é o valor de (b)? ");
                            b = Convert.ToDouble(Console.ReadLine());
                            Console.Write("\n  Qual é o valor de (c)? ");
                            c = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("\n --------------------------");
                            //  FORMULAS ABAIXO
                            delta = Math.Pow(b, 2) - 4 * a * c;
                            raizdelta = Math.Sqrt(delta);
                            x1 = (-b + raizdelta) / (2 * a);
                            x2 = (-b - raizdelta) / (2 * a);
                            xv = -b / (2 * a);
                            yv = -delta / (4 * a);
                            //  EXIBINDO O RESULTADO
                            Console.WriteLine("\n  Sua equação: " + a + "x² " + b + "x " + c + " = 0");
                            Console.WriteLine("\n -------------------------RESULTADO-------------------------");
                            Console.WriteLine("\n  Delta = " + delta + " | " + " Raiz de Delta é = " + raizdelta);
                            Console.WriteLine("\n  Raizes da equação -> " + "(X1 = " + x1 + ")" + " e " + "(X2 = " + x2 + ")");
                            Console.WriteLine("\n  Os Vértices da equação -> " + "(Yv = " + yv + ")" + " e " + "(Xv = " + xv + ")");
                            Console.WriteLine("\n -----------------------------------------------------------");
                            Console.Write("\n Deseja realizar outro calculo de Equação do 2º Grau? (S/N): ");
                            resposta = Console.ReadLine();
                            Console.Clear();
                        }
                        break;
                    case "3":
                        resposta = "sair";
                        break;
                    default:
                        break;

                }
            }
        }
    }
}
