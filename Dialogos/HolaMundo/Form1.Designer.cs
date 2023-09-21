namespace HolaMundo
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
            btnMensajePersonalizado = new Button();
            btnDialogoConTitulo = new Button();
            btnDialogoConVariosBotones = new Button();
            SuspendLayout();
            // 
            // btnMensajePersonalizado
            // 
            btnMensajePersonalizado.BackColor = Color.White;
            btnMensajePersonalizado.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMensajePersonalizado.Location = new Point(12, 66);
            btnMensajePersonalizado.Name = "btnMensajePersonalizado";
            btnMensajePersonalizado.Size = new Size(187, 58);
            btnMensajePersonalizado.TabIndex = 0;
            btnMensajePersonalizado.Text = "MENSAJE PERSONALIZADO";
            btnMensajePersonalizado.UseVisualStyleBackColor = false;
            btnMensajePersonalizado.Click += btnMensajePersonalizado_Click;
            // 
            // btnDialogoConTitulo
            // 
            btnDialogoConTitulo.BackColor = Color.White;
            btnDialogoConTitulo.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDialogoConTitulo.Location = new Point(285, 66);
            btnDialogoConTitulo.Name = "btnDialogoConTitulo";
            btnDialogoConTitulo.Size = new Size(187, 58);
            btnDialogoConTitulo.TabIndex = 1;
            btnDialogoConTitulo.Text = "DIALOGO CON TITULO";
            btnDialogoConTitulo.UseVisualStyleBackColor = false;
            btnDialogoConTitulo.Click += btnDialogoConTitulo_Click;
            // 
            // btnDialogoConVariosBotones
            // 
            btnDialogoConVariosBotones.BackColor = Color.White;
            btnDialogoConVariosBotones.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDialogoConVariosBotones.Location = new Point(551, 66);
            btnDialogoConVariosBotones.Name = "btnDialogoConVariosBotones";
            btnDialogoConVariosBotones.Size = new Size(178, 58);
            btnDialogoConVariosBotones.TabIndex = 2;
            btnDialogoConVariosBotones.Text = "DIALOGO CON VARIOS BOTONES";
            btnDialogoConVariosBotones.UseVisualStyleBackColor = false;
            btnDialogoConVariosBotones.Click += btnDialogoConVariosBotones_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(741, 221);
            Controls.Add(btnDialogoConVariosBotones);
            Controls.Add(btnDialogoConTitulo);
            Controls.Add(btnMensajePersonalizado);
            Name = "Form1";
            Text = "HolaMundo";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMensajePersonalizado;
        private Button btnDialogoConTitulo;
        private Button btnDialogoConVariosBotones;
    }
}