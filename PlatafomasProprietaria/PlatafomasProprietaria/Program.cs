using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatafomasProprietaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //primitiveDatTypeExercicio1();
            //conditionalStatementsExercicio1();
            //conditionalStatementsExercicio2();
            //loopsExercicio1();

            //loopsExercicio2();
            //loopsExercicio3();
            loopsExercicio4();

        }

        //Exercício 02-primitive-data-types-and-variables
        public static void primitiveDatTypeExercicio1()
        {
            String var1 = "Hello";
            String var2 = "Word";
            object varObj = var1+" "+var2;

            String var3 = varObj.ToString();

            Console.WriteLine(var3+"\n");
         
        }

        //Exercícios 03-conditional-statements
        public static void conditionalStatementsExercicio1()
        {
            Console.WriteLine("Entre com 5 valores para calcular qual será o maior:");
            int numberResult = 0;
            for(int i=0; i < 5; i++)
            {
                String numberStrg = Console.ReadLine();
                try
                {
                    int numberInt = int.Parse(numberStrg);
                    if (numberInt > numberResult)
                    {
                        numberResult = numberInt;
                    }
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Digite um valor válido.");
                    i--;
                }
                
            }

            Console.WriteLine("O maior valor é: "+numberResult+"\n");
                
        }

        public static void conditionalStatementsExercicio2()
        {
       
            float result = 0;
            try
            {
                Console.WriteLine("Entre com um fator entre 1 e 9 para calcular seu bônus:");
                float fatorInt = float.Parse(Console.ReadLine());
                switch (fatorInt)
                {
                    case 1:
                    case 2:
                    case 3:
                        result = fatorInt * 10;
                        break;
                    case 4:
                    case 5:
                    case 6:
                        result = fatorInt * 100;
                        break;
                    case 7:
                    case 8:
                    case 9:
                        result = fatorInt * 1000;
                        break;
                    default:
                        Console.WriteLine("Você digitou uma valor inválido e perdeu o bônus.");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Você digitou uma valor inválido e perdeu o bônus.");
            }

            Console.WriteLine("O fator de bônus é : "+ result);
           
            
        }

        //Exercícios 04-loops
        public static void loopsExercicio1()
        {
            Console.WriteLine("Digite um valor maior que 21?");
            int number = int.Parse(Console.ReadLine());

            for(int i=0; i <= number; i++)
            {
                if(!(i % 3 == 0 && i % 7 == 0))
                {
                    Console.Write(i + "-");
                }
            }

            Console.WriteLine("");
            
        }

        public static void loopsExercicio2()
        {
            Console.WriteLine("Diga o tanto de números que você quer digitar:");
            int lenght = int.Parse(Console.ReadLine());
            int numberResultMore = 0;
            int numberResultLess = int.MaxValue;
            Console.WriteLine("Agora digite a seguência de números para calcular o maior e menor valor:");
            for (int i = 0; i < lenght; i++)
            {
                String numberStrg = Console.ReadLine();
                try
                {
                    int numberInt = int.Parse(numberStrg);
                    if (numberInt > numberResultMore)
                    {
                        numberResultMore = numberInt;
                    }
                    if(numberInt < numberResultLess)
                    {
                        numberResultLess = numberInt;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Digite um valor válido.");
                    i--;
                }

            }
            Console.WriteLine("O menor valor é: " + numberResultLess);
            Console.WriteLine("O maior valor é: " + numberResultMore + "\n");
            

        }

        public static void loopsExercicio3()
        {
            Console.WriteLine("Diga o tanto de números para aparecer na seguência de Fibonacci:");
            int lenght = int.Parse(Console.ReadLine());
            int sumTotal = 0;
            int sum = 0;
            int current = 1;
            int prev = 0;
            int aux = 0;
            Console.Write("0-");
            for(int i=1; i<lenght; i++)
            {
                Console.Write(current + "-");
                sum += current;
                aux = current;
                current = prev + current;
                prev = aux;
                                
            }


            Console.WriteLine("\nA soma total é: "+sum);
        }

        public static void loopsExercicio4()
        {
            Console.WriteLine("Escolha um número até 20 para definir o quadrado da matriz");
            int lenght = int.Parse(Console.ReadLine());
            for(int i=1; i<=lenght; i++)
            {
                Console.WriteLine("");
                for(int j=0; j<lenght; j++)
                {
                    int col = j + i;

                    if(col < 10)
                    {
                        Console.Write("0"+col+" ");
                  
                    }
                    else
                    {
                        Console.Write(col+" ");
                    }


                }
            }
        }



    }


}
