namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            lblMensaje = new Label();
            btDespedida = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(295, 50);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Saludo!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(116, 50);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(38, 15);
            lblMensaje.TabIndex = 1;
            lblMensaje.Text = "label1";
            // 
            // btDespedida
            // 
            btDespedida.Location = new Point(295, 89);
            btDespedida.Name = "btDespedida";
            btDespedida.Size = new Size(75, 23);
            btDespedida.TabIndex = 2;
            btDespedida.Text = "Despedida";
            btDespedida.UseVisualStyleBackColor = true;
            btDespedida.Click += btDespedida_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 375);
            Controls.Add(btDespedida);
            Controls.Add(lblMensaje);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Programa 01 ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblMensaje;
        private Button btDespedida;
    }
}