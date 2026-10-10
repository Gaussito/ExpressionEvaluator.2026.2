namespace Frontend.Windows
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtExpression;
        private Label lblResultado;

        private TableLayoutPanel panelBotones;

        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;

        private Button btnSuma;
        private Button btnResta;
        private Button btnMultiplicacion;
        private Button btnDivision;
        private Button btnPotencia;

        private Button btnPunto;
        private Button btnIgual;
        private Button btnLimpiar;

        private Button btnParentesisAbre;
        private Button btnParentesisCierra;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            txtExpression = new TextBox();
            lblResultado = new Label();
            panelBotones = new TableLayoutPanel();

            btn0 = CrearBoton("0");
            btn1 = CrearBoton("1");
            btn2 = CrearBoton("2");
            btn3 = CrearBoton("3");
            btn4 = CrearBoton("4");
            btn5 = CrearBoton("5");
            btn6 = CrearBoton("6");
            btn7 = CrearBoton("7");
            btn8 = CrearBoton("8");
            btn9 = CrearBoton("9");

            btnSuma = CrearBoton("+");
            btnResta = CrearBoton("-");
            btnMultiplicacion = CrearBoton("*");
            btnDivision = CrearBoton("/");
            btnPotencia = CrearBoton("^");

            btnPunto = CrearBoton(".");
            btnIgual = CrearBoton("=");
            btnLimpiar = CrearBoton("C");

            btnParentesisAbre = CrearBoton("(");
            btnParentesisCierra = CrearBoton(")");

            SuspendLayout();

            // =========================
            // FORMULARIO
            // =========================

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 620);

            Text = "Evaluador de Funciones";

            StartPosition = FormStartPosition.CenterScreen;

            FormBorderStyle = FormBorderStyle.FixedSingle;

            MaximizeBox = false;

            // =========================
            // TITULO / PANTALLA
            // =========================

            txtExpression.Location = new Point(20, 25);

            txtExpression.Size = new Size(380, 50);

            txtExpression.Font =
                new Font("Segoe UI", 20F);

            txtExpression.TextAlign =
                HorizontalAlignment.Right;

            txtExpression.ReadOnly = true;

            // =========================
            // RESULTADO
            // =========================

            lblResultado.Location =
                new Point(20, 85);

            lblResultado.Size =
                new Size(380, 35);

            lblResultado.Text =
                "Resultado: ";

            lblResultado.Font =
                new Font("Segoe UI", 13F);

            lblResultado.TextAlign =
                ContentAlignment.MiddleRight;

            // =========================
            // PANEL
            // =========================

            panelBotones.Location =
                new Point(20, 135);

            panelBotones.Size =
                new Size(380, 450);

            panelBotones.ColumnCount = 4;

            panelBotones.RowCount = 6;

            panelBotones.ColumnStyles.Clear();

            for (int i = 0; i < 4; i++)
            {
                panelBotones.ColumnStyles.Add(
                    new ColumnStyle(
                        SizeType.Percent,
                        25F
                    )
                );
            }

            panelBotones.RowStyles.Clear();

            for (int i = 0; i < 6; i++)
            {
                panelBotones.RowStyles.Add(
                    new RowStyle(
                        SizeType.Percent,
                        16.6667F
                    )
                );
            }

            panelBotones.Padding =
                new Padding(3);

            // =========================
            // FILA 1
            // =========================

            panelBotones.Controls.Add(
                btnLimpiar, 0, 0);

            panelBotones.Controls.Add(
                btnParentesisAbre, 1, 0);

            panelBotones.Controls.Add(
                btnParentesisCierra, 2, 0);

            panelBotones.Controls.Add(
                btnPotencia, 3, 0);

            // =========================
            // FILA 2
            // =========================

            panelBotones.Controls.Add(
                btn7, 0, 1);

            panelBotones.Controls.Add(
                btn8, 1, 1);

            panelBotones.Controls.Add(
                btn9, 2, 1);

            panelBotones.Controls.Add(
                btnDivision, 3, 1);

            // =========================
            // FILA 3
            // =========================

            panelBotones.Controls.Add(
                btn4, 0, 2);

            panelBotones.Controls.Add(
                btn5, 1, 2);

            panelBotones.Controls.Add(
                btn6, 2, 2);

            panelBotones.Controls.Add(
                btnMultiplicacion, 3, 2);

            // =========================
            // FILA 4
            // =========================

            panelBotones.Controls.Add(
                btn1, 0, 3);

            panelBotones.Controls.Add(
                btn2, 1, 3);

            panelBotones.Controls.Add(
                btn3, 2, 3);

            panelBotones.Controls.Add(
                btnResta, 3, 3);

            // =========================
            // FILA 5
            // =========================

            panelBotones.Controls.Add(
                btn0, 0, 4);

            panelBotones.Controls.Add(
                btnPunto, 1, 4);

            panelBotones.Controls.Add(
                btnIgual, 2, 4);

            panelBotones.Controls.Add(
                btnSuma, 3, 4);

            // =========================
            // FILA 6
            // =========================

            Label lblInfo = new Label();

            lblInfo.Text =
                "Usa números, decimales, operadores y paréntesis.";

            lblInfo.Dock =
                DockStyle.Fill;

            lblInfo.TextAlign =
                ContentAlignment.MiddleCenter;

            lblInfo.Font =
                new Font("Segoe UI", 9F);

            panelBotones.Controls.Add(
                lblInfo, 0, 5);

            panelBotones.SetColumnSpan(
                lblInfo, 4);

            // =========================
            // EVENTOS
            // =========================

            btn0.Click += Numero_Click;
            btn1.Click += Numero_Click;
            btn2.Click += Numero_Click;
            btn3.Click += Numero_Click;
            btn4.Click += Numero_Click;
            btn5.Click += Numero_Click;
            btn6.Click += Numero_Click;
            btn7.Click += Numero_Click;
            btn8.Click += Numero_Click;
            btn9.Click += Numero_Click;

            btnSuma.Click += Operador_Click;
            btnResta.Click += Operador_Click;
            btnMultiplicacion.Click += Operador_Click;
            btnDivision.Click += Operador_Click;
            btnPotencia.Click += Operador_Click;

            btnParentesisAbre.Click += Operador_Click;
            btnParentesisCierra.Click += Operador_Click;

            btnPunto.Click += Punto_Click;

            btnIgual.Click += Igual_Click;

            btnLimpiar.Click += Limpiar_Click;

            // =========================
            // AGREGAR CONTROLES
            // =========================

            Controls.Add(txtExpression);

            Controls.Add(lblResultado);

            Controls.Add(panelBotones);

            ResumeLayout(false);

            PerformLayout();
        }

        private Button CrearBoton(string texto)
        {
            Button boton = new Button();

            boton.Text = texto;

            boton.Dock =
                DockStyle.Fill;

            boton.Margin =
                new Padding(4);

            boton.Font =
                new Font("Segoe UI", 14F);

            boton.UseVisualStyleBackColor = true;

            return boton;
        }
    }
}

