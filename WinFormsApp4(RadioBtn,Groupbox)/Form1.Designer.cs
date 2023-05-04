namespace WinFormsApp4_RadioBtn_Groupbox_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textA = new TextBox();
            textB = new TextBox();
            btnCalcular = new Button();
            groupBoxOperaciones = new GroupBox();
            rbMulti = new RadioButton();
            rbDivision = new RadioButton();
            rbResta = new RadioButton();
            rbSuma = new RadioButton();
            label1 = new Label();
            groupBoxOperaciones.SuspendLayout();
            SuspendLayout();
            // 
            // textA
            // 
            textA.Location = new Point(57, 25);
            textA.Name = "textA";
            textA.Size = new Size(100, 23);
            textA.TabIndex = 0;
            textA.Text = "0";
            textA.TextAlign = HorizontalAlignment.Right;
            // 
            // textB
            // 
            textB.Location = new Point(57, 54);
            textB.Name = "textB";
            textB.Size = new Size(100, 23);
            textB.TabIndex = 1;
            textB.Text = "0";
            textB.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(186, 25);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // groupBoxOperaciones
            // 
            groupBoxOperaciones.Controls.Add(rbMulti);
            groupBoxOperaciones.Controls.Add(rbDivision);
            groupBoxOperaciones.Controls.Add(rbResta);
            groupBoxOperaciones.Controls.Add(rbSuma);
            groupBoxOperaciones.Location = new Point(57, 103);
            groupBoxOperaciones.Name = "groupBoxOperaciones";
            groupBoxOperaciones.Size = new Size(164, 130);
            groupBoxOperaciones.TabIndex = 3;
            groupBoxOperaciones.TabStop = false;
            groupBoxOperaciones.Text = "Operaciones";
            // 
            // rbMulti
            // 
            rbMulti.AutoSize = true;
            rbMulti.Location = new Point(23, 71);
            rbMulti.Name = "rbMulti";
            rbMulti.Size = new Size(101, 19);
            rbMulti.TabIndex = 4;
            rbMulti.TabStop = true;
            rbMulti.Text = "Multiplicacion";
            rbMulti.UseVisualStyleBackColor = true;
            // 
            // rbDivision
            // 
            rbDivision.AutoSize = true;
            rbDivision.Location = new Point(23, 96);
            rbDivision.Name = "rbDivision";
            rbDivision.Size = new Size(67, 19);
            rbDivision.TabIndex = 3;
            rbDivision.TabStop = true;
            rbDivision.Text = "Division";
            rbDivision.UseVisualStyleBackColor = true;
            // 
            // rbResta
            // 
            rbResta.AutoSize = true;
            rbResta.Location = new Point(23, 47);
            rbResta.Name = "rbResta";
            rbResta.Size = new Size(53, 19);
            rbResta.TabIndex = 1;
            rbResta.TabStop = true;
            rbResta.Text = "Resta";
            rbResta.UseVisualStyleBackColor = true;
            // 
            // rbSuma
            // 
            rbSuma.AutoSize = true;
            rbSuma.Location = new Point(23, 22);
            rbSuma.Name = "rbSuma";
            rbSuma.Size = new Size(55, 19);
            rbSuma.TabIndex = 0;
            rbSuma.TabStop = true;
            rbSuma.Text = "Suma";
            rbSuma.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 82);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(groupBoxOperaciones);
            Controls.Add(btnCalcular);
            Controls.Add(textB);
            Controls.Add(textA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxOperaciones.ResumeLayout(false);
            groupBoxOperaciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textA;
        private TextBox textB;
        private Button btnCalcular;
        private GroupBox groupBoxOperaciones;
        private RadioButton rbDivision;
        private RadioButton rbResta;
        private RadioButton rbSuma;
        private RadioButton rbMulti;
        private Label label1;
    }
}