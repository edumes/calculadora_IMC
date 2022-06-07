namespace IMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_peso = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_imc = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.res_imc = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Location = new System.Drawing.Point(31, 45);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(31, 13);
            this.lbl_peso.TabIndex = 0;
            this.lbl_peso.Text = "Peso";
            this.lbl_peso.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Location = new System.Drawing.Point(28, 85);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(34, 13);
            this.lbl_altura.TabIndex = 2;
            this.lbl_altura.Text = "Altura";
            this.lbl_altura.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lbl_imc
            // 
            this.lbl_imc.AutoSize = true;
            this.lbl_imc.Location = new System.Drawing.Point(31, 207);
            this.lbl_imc.Name = "lbl_imc";
            this.lbl_imc.Size = new System.Drawing.Size(57, 13);
            this.lbl_imc.TabIndex = 4;
            this.lbl_imc.Text = "Seu IMC é";
            this.lbl_imc.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(34, 282);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(139, 282);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpar.TabIndex = 6;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // res_imc
            // 
            this.res_imc.Location = new System.Drawing.Point(94, 204);
            this.res_imc.Name = "res_imc";
            this.res_imc.Size = new System.Drawing.Size(83, 20);
            this.res_imc.TabIndex = 8;
            this.res_imc.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 293);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 317);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.res_imc);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_imc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_peso);
            this.Name = "Form1";
            this.Text = "Calculadora IMC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_imc;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox res_imc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

