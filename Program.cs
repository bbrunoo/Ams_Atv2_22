double euro = 5.13;

Console.WriteLine("Digite a quantidade de euro para compra");
int valor = Convert.ToInt32(Console.ReadLine());

double eurocompra = (euro*valor);

Console.WriteLine($"O valor em real é: {eurocompra}");