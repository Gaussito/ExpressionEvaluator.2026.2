using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;

namespace Backend;

public static class ExpressionEvaluator
{
    public static double Evalute(string infix)
    {
        if (string.IsNullOrWhiteSpace(infix))
        {
            throw new Exception("La expresión está vacía.");
        }

        return EvalutePostfix(ToPostfix(infix));
    }

    private static string ToPostfix(string infix)
    {
        var postfix = string.Empty;
        var stack = new Stack<char>();

        int i = 0;

        while (i < infix.Length)
        {
            char item = infix[i];

            // Ignorar espacios
            if (char.IsWhiteSpace(item))
            {
                i++;
                continue;
            }

            // Leer números completos, incluyendo decimales
            if (char.IsDigit(item) || item == '.')
            {
                string number = string.Empty;
                int decimalCount = 0;

                while (i < infix.Length &&
                       (char.IsDigit(infix[i]) || infix[i] == '.'))
                {
                    if (infix[i] == '.')
                    {
                        decimalCount++;

                        if (decimalCount > 1)
                        {
                            throw new Exception("Número decimal inválido.");
                        }
                    }

                    number += infix[i];
                    i++;
                }

                if (number == ".")
                {
                    throw new Exception("Número decimal inválido.");
                }

                postfix += number + " ";
                continue;
            }

            if (IsOperator(item))
            {
                if (item == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfix += stack.Pop() + " ";
                    }

                    if (stack.Count == 0)
                    {
                        throw new Exception("Paréntesis desbalanceados.");
                    }

                    stack.Pop();
                }
                else if (item == '(')
                {
                    stack.Push(item);
                }
                else
                {
                    while (stack.Count > 0 &&
                           stack.Peek() != '(' &&
                           PriorityStack(stack.Peek()) >= PriorityInfix(item))
                    {
                        postfix += stack.Pop() + " ";
                    }

                    stack.Push(item);
                }

                i++;
                continue;
            }

            throw new Exception($"Carácter inválido: {item}");
        }

        while (stack.Count > 0)
        {
            if (stack.Peek() == '(')
            {
                throw new Exception("Paréntesis desbalanceados.");
            }

            postfix += stack.Pop() + " ";
        }

        return postfix;
    }

    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        '(' => 0,
        _ => throw new Exception("Operador inválido."),
    };

    private static int PriorityInfix(char op) => op switch
    {
        '^' => 4,
        '*' => 2,
        '/' => 2,
        '+' => 1,
        '-' => 1,
        _ => throw new Exception("Operador inválido."),
    };

    private static bool IsOperator(char item) =>
        item == '^' ||
        item == '*' ||
        item == '/' ||
        item == '+' ||
        item == '-' ||
        item == '(' ||
        item == ')';

    private static double EvalutePostfix(string postfix)
    {
        var stack = new Stack<double>();

        string[] tokens = postfix.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string token in tokens)
        {
            if (double.TryParse(
                token,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out double number))
            {
                stack.Push(number);
            }
            else if (token.Length == 1 && IsOperator(token[0]))
            {
                if (stack.Count < 2)
                {
                    throw new Exception("Expresión inválida.");
                }

                char operation = token[0];

                double ope2 = stack.Pop();
                double ope1 = stack.Pop();

                stack.Push(Calculate(ope1, ope2, operation));
            }
            else
            {
                throw new Exception("Expresión inválida.");
            }
        }

        if (stack.Count != 1)
        {
            throw new Exception("Expresión inválida.");
        }

        return stack.Pop();
    }

    private static double Calculate(double ope1, double ope2, char item) => item switch
    {
        '*' => ope1 * ope2,
        '/' => ope1 / ope2,
        '+' => ope1 + ope2,
        '-' => ope1 - ope2,
        '^' => Math.Pow(ope1, ope2),
        _ => throw new Exception("Operador inválido."),
    };
}
