namespace WinFormsApp4_Check_Mesagge_box
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
            checkMonitor = new CheckBox();
            checkTeclado = new CheckBox();
            checkMouse = new CheckBox();
            lblResultado = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // checkMonitor
            // 
            checkMonitor.AutoSize = true;
            checkMonitor.Location = new Point(34, 33);
            checkMonitor.Name = "checkMonitor";
            checkMonitor.Size = new Size(96, 19);
            checkMonitor.TabIndex = 0;
            checkMonitor.Text = "Monitor $250";
            checkMonitor.UseVisualStyleBackColor = true;
            checkMonitor.CheckedChanged += checkMonitor_CheckedChanged;
            // 
            // checkTeclado
            // 
            checkTeclado.AutoSize = true;
            checkTeclado.Location = new Point(34, 58);
            checkTeclado.Name = "checkTeclado";
            checkTeclado.Size = new Size(93, 19);
            checkTeclado.TabIndex = 1;
            checkTeclado.Text = "Teclado $150";
            checkTeclado.UseVisualStyleBackColor = true;
            checkTeclado.CheckedChanged += checkTeclado_CheckedChanged;
            // 
            // checkMouse
            // 
            checkMouse.AutoSize = true;
            checkMouse.Location = new Point(34, 83);
            checkMouse.Name = "checkMouse";
            checkMouse.Size = new Size(83, 19);
            checkMouse.TabIndex = 2;
            checkMouse.Text = "Mouse $20";
            checkMouse.UseVisualStyleBackColor = true;
            checkMouse.CheckedChanged += checkMouse_CheckedChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(34, 121);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label1";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(166, 29);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblResultado);
            Controls.Add(checkMouse);
            Controls.Add(checkTeclado);
            Controls.Add(checkMonitor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkMonitor;
        private CheckBox checkTeclado;
        private CheckBox checkMouse;
        private Label lblResultado;
        private Button btnCalcular;
    }
}