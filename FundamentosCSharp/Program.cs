Console.WriteLine("Hello, World!");
// Antes de codar, responda:
// Qual o problema será resolvido?
// Quais dados entram?
// O que precisa ser processado?
// Qual o resultado esperado?

// Entrada -> Processamento -> Saída

System.Console.WriteLine("Olá usuário! Entre com o seu nome:");
var nome = System.Console.ReadLine();
System.Console.WriteLine("Olá " + nome + "! Seja bem-vindo(a)!");

    int idade = 26;
    decimal altura = 1.60m;
    float peso = 55.5f;
    double temperatura = 36.5;

    System.Console.WriteLine($"Idade: {idade}");
    System.Console.WriteLine($"Altura: {altura}");
    System.Console.WriteLine($"Peso: {peso}");
    System.Console.WriteLine($"Temperatura: {temperatura}");

    idade = 27;
    System.Console.WriteLine($"Nova idade: {idade}");

    List<string> profissoes = new List<string> {"Engenheiro", "Médico", "Professor"};
    List<string> novasProfissoes = profissoes;

    System.Console.WriteLine($"Profissões: -> {string.Join(", ", profissoes)}");
    System.Console.WriteLine($"Novas Profissões: -> {string.Join(", ", novasProfissoes)}");
    profissoes.Add("Advogado");
    
    System.Console.WriteLine($"Profissões: -> {string.Join(", ", profissoes)}");
    System.Console.WriteLine($"Novas Profissões: -> {string.Join(", ", novasProfissoes)}");