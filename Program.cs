// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
double consumo, horasDiarias;
decimal custo, estimativa;

Console.WriteLine("Custo de Energia?\n ");

Console.Write("Consumo do aparelho (em kWh/mês): ");
consumo = Convert.ToDouble(Console.ReadLine());

Console.Write("Horas de uso por dia............: ");
horasDiarias = Convert.ToDouble(Console.ReadLine());

Console.Write("Custo da energia (em R$/kWh)....: ");
custo = Convert.ToDecimal(Console.ReadLine());

estimativa = Convert.ToDecimal(consumo * horasDiarias) * custo;

Console.WriteLine($"\nCusto estimado: {estimativa:C}");
