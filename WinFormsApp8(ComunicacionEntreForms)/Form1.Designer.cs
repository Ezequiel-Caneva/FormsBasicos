namespace WinFormsApp8_ComunicacionEntreForms_
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
            btnEnvio1 = new Button();
            textboxMensaje = new TextBox();
            btnEnvio2 = new Button();
            SuspendLayout();
            // 
            // btnEnvio1
            // 
            btnEnvio1.Location = new Point(242, 39);
            btnEnvio1.Name = "btnEnvio1";
            btnEnvio1.Size = new Size(75, 23);
            btnEnvio1.TabIndex = 0;
            btnEnvio1.Text = "Envio 1 ";
            btnEnvio1.UseVisualStyleBackColor = true;
            btnEnvio1.Click += btnEnvio1_Click;
            // 
            // textboxMensaje
            // 
            textboxMensaje.Location = new Point(90, 40);
            textboxMensaje.Name = "textboxMensaje";
            textboxMensaje.Size = new Size(100, 23);
            textboxMensaje.TabIndex = 1;
            // 
            // btnEnvio2
            // 
            btnEnvio2.AllowDrop = true;
            btnEnvio2.Location = new Point(242, 85);
            btnEnvio2.Name = "btnEnvio2";
            btnEnvio2.Size = new Size(75, 23);
            btnEnvio2.TabIndex = 2;
            btnEnvio2.Text = "Envio 2";
            btnEnvio2.UseVisualStyleBackColor = true;
            btnEnvio2.Click += btnEnvio2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnvio2);
            Controls.Add(textboxMensaje);
            Controls.Add(btnEnvio1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnvio1;
        private TextBox textboxMensaje;
        private Button btnEnvio2;
    }
}