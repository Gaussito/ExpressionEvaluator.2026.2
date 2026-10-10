using Backend;

Console.WriteLine("======================================");
Console.WriteLine("     EXPRESSION EVALUATOR - PRUEBAS");
Console.WriteLine("======================================");
Console.WriteLine();

Probar("2 + 3");
Probar("12 + 35");
Probar("125 * 4");
Probar("100 / 4");
Probar("12.5 + 3.75");
Probar("125.50 + 32.75");
Probar("(12.5 + 3.5) * 2");
Probar("2 + 3 * 4");
Probar("4 ^ 3");
Probar("0.5 + 0.25");
Probar("1000.75 - 250.25");
Probar("10.5 * 2");
Probar("99.99 / 3");
Probar("(100.5 - 20.5) / 4");
Probar("2.5 ^ 2");
Probar("10 + 20 * 3");
Probar("(10 + 20) * 3");
Probar("12.50 + 32.75");


Console.WriteLine();
Console.WriteLine("======================================");
Console.WriteLine("          PRUEBAS FINALIZADAS");
Console.WriteLine("======================================");

static void Probar(string expresion)
{
    try
    {
        double resultado = ExpressionEvaluator.Evalute(expresion);

        Console.WriteLine(
            $"Expresión: {expresion,-25} Resultado: {resultado}"
        );
    }
    catch (Exception ex)
    {
        Console.WriteLine(
            $"Expresión: {expresion,-25} ERROR: {ex.Message}"
        );
    }
}
