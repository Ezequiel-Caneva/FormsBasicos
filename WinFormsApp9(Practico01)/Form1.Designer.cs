namespace WinFormsApp9_Practico01_
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
            lblNombre = new Label();
            lblSeguro = new Label();
            textBoxNombre = new TextBox();
            groupBox1 = new GroupBox();
            rbnTotal = new RadioButton();
            rbnTerceros = new RadioButton();
            rbnBasico = new RadioButton();
            groupBox2 = new GroupBox();
            cbxAudio = new CheckBox();
            cbxAire = new CheckBox();
            lblEquipo = new Label();
            lblCosto = new Label();
            textboxCosto = new TextBox();
            btnCotizar = new Button();
            textBoxCotizacion = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(21, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblSeguro
            // 
            lblSeguro.AutoSize = true;
            lblSeguro.Location = new Point(6, 19);
            lblSeguro.Name = "lblSeguro";
            lblSeguro.Size = new Size(44, 15);
            lblSeguro.TabIndex = 1;
            lblSeguro.Text = "Seguro";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(78, 24);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbnTotal);
            groupBox1.Controls.Add(rbnTerceros);
            groupBox1.Controls.Add(rbnBasico);
            groupBox1.Controls.Add(lblSeguro);
            groupBox1.Location = new Point(22, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 139);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seguro a Seleccionar";
            // 
            // rbnTotal
            // 
            rbnTotal.AutoSize = true;
            rbnTotal.Location = new Point(61, 75);
            rbnTotal.Name = "rbnTotal";
            rbnTotal.Size = new Size(50, 19);
            rbnTotal.TabIndex = 4;
            rbnTotal.Text = "Total";
            rbnTotal.UseVisualStyleBackColor = true;
            // 
            // rbnTerceros
            // 
            rbnTerceros.AutoSize = true;
            rbnTerceros.Location = new Point(61, 50);
            rbnTerceros.Name = "rbnTerceros";
            rbnTerceros.Size = new Size(78, 19);
            rbnTerceros.TabIndex = 3;
            rbnTerceros.Text = "A terceros";
            rbnTerceros.UseVisualStyleBackColor = true;
            // 
            // rbnBasico
            // 
            rbnBasico.AutoSize = true;
            rbnBasico.Checked = true;
            rbnBasico.Location = new Point(61, 25);
            rbnBasico.Name = "rbnBasico";
            rbnBasico.Size = new Size(59, 19);
            rbnBasico.TabIndex = 2;
            rbnBasico.TabStop = true;
            rbnBasico.Text = "Basico";
            rbnBasico.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbxAudio);
            groupBox2.Controls.Add(cbxAire);
            groupBox2.Controls.Add(lblEquipo);
            groupBox2.Location = new Point(258, 61);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 139);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Equipamiento";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // cbxAudio
            // 
            cbxAudio.AutoSize = true;
            cbxAudio.Location = new Point(64, 51);
            cbxAudio.Name = "cbxAudio";
            cbxAudio.Size = new Size(116, 19);
            cbxAudio.TabIndex = 2;
            cbxAudio.Text = "Sistema de audio";
            cbxAudio.UseVisualStyleBackColor = true;
            // 
            // cbxAire
            // 
            cbxAire.AutoSize = true;
            cbxAire.Location = new Point(63, 22);
            cbxAire.Name = "cbxAire";
            cbxAire.Size = new Size(131, 19);
            cbxAire.TabIndex = 1;
            cbxAire.Text = "Aire Acondicionado";
            cbxAire.UseVisualStyleBackColor = true;
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.Location = new Point(13, 18);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(44, 15);
            lblEquipo.TabIndex = 0;
            lblEquipo.Text = "Equipo";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(28, 213);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(38, 15);
            lblCosto.TabIndex = 5;
            lblCosto.Text = "Costo";
            // 
            // textboxCosto
            // 
            textboxCosto.Location = new Point(72, 210);
            textboxCosto.Name = "textboxCosto";
            textboxCosto.Size = new Size(100, 23);
            textboxCosto.TabIndex = 5;
            textboxCosto.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCotizar
            // 
            btnCotizar.Location = new Point(240, 209);
            btnCotizar.Name = "btnCotizar";
            btnCotizar.Size = new Size(75, 23);
            btnCotizar.TabIndex = 6;
            btnCotizar.Text = "Cotizar";
            btnCotizar.UseVisualStyleBackColor = true;
            btnCotizar.Click += btnCotizar_Click;
            // 
            // textBoxCotizacion
            // 
            textBoxCotizacion.Location = new Point(32, 250);
            textBoxCotizacion.Multiline = true;
            textBoxCotizacion.Name = "textBoxCotizacion";
            textBoxCotizacion.Size = new Size(426, 173);
            textBoxCotizacion.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 450);
            Controls.Add(textBoxCotizacion);
            Controls.Add(btnCotizar);
            Controls.Add(textboxCosto);
            Controls.Add(lblCosto);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBoxNombre);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblSeguro;
        private TextBox textBoxNombre;
        private GroupBox groupBox1;
        private RadioButton rbnTotal;
        private RadioButton rbnTerceros;
        private RadioButton rbnBasico;
        private GroupBox groupBox2;
        private CheckBox cbxAudio;
        private CheckBox cbxAire;
        private Label lblEquipo;
        private Label lblCosto;
        private TextBox textboxCosto;
        private Button btnCotizar;
        private TextBox textBoxCotizacion;
    }
}