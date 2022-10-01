int n1, n2, resto;

Console.WriteLine("Números multiplos..");

Console.Write("\nDigite o Primeiro Número: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("\nDigite o Segundo Número: ");
n2 = Convert.ToInt32(Console.ReadLine());

resto = n1 % n2;

if (resto==0)
{ Console.WriteLine($"\n{n1} é Multiplo de {n2}");}


else 

{Console.WriteLine($"\n{n1} Não é Multiplo de {n2}");}



Console.WriteLine("\nAgredeço Pela Preferência do Programa");

