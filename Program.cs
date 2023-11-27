Console.WriteLine("-----Entrada Válida-----");
 int NumeroDigitado = -1;
 
while (NumeroDigitado < 0 || NumeroDigitado >9)
{
    Console.WriteLine("Digite um número de 1 a 9 ou 0 para parar a operação");
    NumeroDigitado = Convert.ToInt32(Console.ReadLine());     
}

 if (NumeroDigitado == 0)
 {
    Console.WriteLine("Operação foi cancelada pelo usuário");
 }

 else
{
    Console.WriteLine($"Número selecionado = {NumeroDigitado}");
}

Console.WriteLine("VOLTE SEMPRE !!!");