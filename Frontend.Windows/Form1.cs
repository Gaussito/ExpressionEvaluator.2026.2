using Backend;

namespace Frontend.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AgregarTexto(string texto)
        {
            txtExpression.Text += texto;
            txtExpression.SelectionStart = txtExpression.Text.Length;
        }

        private void Numero_Click(object? sender, EventArgs e)
        {
            if (sender is Button boton)
            {
                AgregarTexto(boton.Text);
            }
        }

        private void Operador_Click(object? sender, EventArgs e)
        {
            if (sender is Button boton)
            {
                AgregarTexto(boton.Text);
            }
        }

       private void Punto_Click(object? sender, EventArgs e)
{
    string expresion = txtExpression.Text;

    // Si no hay nada escrito, comenzamos con 0.
    if (string.IsNullOrEmpty(expresion))
    {
        AgregarTexto("0.");
        return;
    }

    // Si el último carácter es un operador o un paréntesis abierto,
    // comenzamos un nuevo número decimal.
    char ultimoCaracter = expresion[expresion.Length - 1];

    if ("+-*/^(".Contains(ultimoCaracter))
    {
        AgregarTexto("0.");
        return;
    }

    // Buscar dónde comenzó el número actual.
    int inicioNumero = expresion.Length - 1;

    while (inicioNumero >= 0)
    {
        char caracter = expresion[inicioNumero];

        if (char.IsDigit(caracter) || caracter == '.')
        {
            inicioNumero--;
        }
        else
        {
            break;
        }
    }

    inicioNumero++;

    // Obtener solamente el número que estamos escribiendo.
    string numeroActual =
        expresion.Substring(inicioNumero);

    // Si este número ya tiene un punto,
    // no permitimos agregar otro.
    if (numeroActual.Contains("."))
    {
        return;
    }

    AgregarTexto(".");
}
        private void Limpiar_Click(object? sender, EventArgs e)
        {
            txtExpression.Clear();
            lblResultado.Text = "Resultado: ";
        }

        private void Igual_Click(object? sender, EventArgs e)
        {
            try
            {
                string expresion = txtExpression.Text;

                if (string.IsNullOrWhiteSpace(expresion))
                {
                    return;
                }

                double resultado =
                    ExpressionEvaluator.Evalute(expresion);

                lblResultado.Text =
                    $"Resultado: {resultado}";
            }
            catch (Exception ex)
            {
                lblResultado.Text =
                    $"Error: {ex.Message}";
            }
        }
    }
}
