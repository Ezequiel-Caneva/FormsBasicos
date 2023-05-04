namespace WinFormsApp3
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
            lblA = new Label();
            txtA = new TextBox();
            lblB = new Label();
            txtB = new TextBox();
            Resultado = new Label();
            btnSuma = new Button();
            btnResta = new Button();
            btnDiv = new Button();
            btnMulti = new Button();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(34, 16);
            lblA.Name = "lblA";
            lblA.Size = new Size(21, 15);
            lblA.TabIndex = 0;
            lblA.Text = "A: ";
            // 
            // txtA
            // 
            txtA.Location = new Point(50, 12);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 1;
            txtA.TextAlign = HorizontalAlignment.Right;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(34, 46);
            lblB.Name = "lblB";
            lblB.Size = new Size(17, 15);
            lblB.TabIndex = 2;
            lblB.Text = "B:";
            // 
            // txtB
            // 
            txtB.Location = new Point(50, 43);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 3;
            txtB.TextAlign = HorizontalAlignment.Right;
            // 
            // Resultado
            // 
            Resultado.AutoSize = true;
            Resultado.Location = new Point(73, 84);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(38, 15);
            Resultado.TabIndex = 4;
            Resultado.Text = "label1";
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(176, 12);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(32, 23);
            btnSuma.TabIndex = 5;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(176, 42);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(32, 23);
            btnResta.TabIndex = 6;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(214, 42);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(32, 23);
            btnDiv.TabIndex = 8;
            btnDiv.Text = "%";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(214, 12);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(32, 23);
            btnMulti.TabIndex = 7;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 247);
            Controls.Add(btnDiv);
            Controls.Add(btnMulti);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(Resultado);
            Controls.Add(txtB);
            Controls.Add(lblB);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private TextBox txtA;
        private Label lblB;
        private TextBox txtB;
        private Label Resultado;
        private Button btnSuma;
        private Button btnResta;
        private Button btnDiv;
        private Button btnMulti;
    }
}