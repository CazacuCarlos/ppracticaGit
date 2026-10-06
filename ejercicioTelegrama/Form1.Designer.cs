namespace ejercicioTelegrama
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
            label1 = new Label();
            txtPrecio = new TextBox();
            label2 = new Label();
            button1 = new Button();
            cbUrgente = new CheckBox();
            txtTelegrama = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 35);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Texto";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(193, 353);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(257, 27);
            txtPrecio.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 360);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Coste:";
            // 
            // button1
            // 
            button1.Location = new Point(569, 306);
            button1.Name = "button1";
            button1.Size = new Size(180, 74);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbUrgente
            // 
            cbUrgente.AutoSize = true;
            cbUrgente.Location = new Point(113, 286);
            cbUrgente.Name = "cbUrgente";
            cbUrgente.Size = new Size(91, 24);
            cbUrgente.TabIndex = 5;
            cbUrgente.Text = "Urgente?";
            cbUrgente.UseVisualStyleBackColor = true;
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(126, 79);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(623, 174);
            txtTelegrama.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTelegrama);
            Controls.Add(cbUrgente);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtPrecio);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPrecio;
        private Label label2;
        private Button button1;
        private CheckBox cbUrgente;
        private TextBox txtTelegrama;
    }
}
