namespace atividade_03_revisao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.btoMais = new System.Windows.Forms.Button();
            this.btoMenos = new System.Windows.Forms.Button();
            this.btoVezes = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoDivisao = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nota 02";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(12, 54);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 23);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(138, 54);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 23);
            this.txtN2.TabIndex = 1;
            // 
            // btoMais
            // 
            this.btoMais.Location = new System.Drawing.Point(275, 33);
            this.btoMais.Name = "btoMais";
            this.btoMais.Size = new System.Drawing.Size(42, 44);
            this.btoMais.TabIndex = 2;
            this.btoMais.Text = "+";
            this.btoMais.UseVisualStyleBackColor = true;
            this.btoMais.Click += new System.EventHandler(this.btoMais_Click);
            // 
            // btoMenos
            // 
            this.btoMenos.Location = new System.Drawing.Point(323, 33);
            this.btoMenos.Name = "btoMenos";
            this.btoMenos.Size = new System.Drawing.Size(42, 44);
            this.btoMenos.TabIndex = 3;
            this.btoMenos.Text = "-";
            this.btoMenos.UseVisualStyleBackColor = true;
            this.btoMenos.Click += new System.EventHandler(this.btoMenos_Click);
            // 
            // btoVezes
            // 
            this.btoVezes.Location = new System.Drawing.Point(275, 83);
            this.btoVezes.Name = "btoVezes";
            this.btoVezes.Size = new System.Drawing.Size(42, 44);
            this.btoVezes.TabIndex = 4;
            this.btoVezes.Text = "*";
            this.btoVezes.UseVisualStyleBackColor = true;
            this.btoVezes.Click += new System.EventHandler(this.btoVezes_Click);
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(371, 49);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(60, 28);
            this.btoLimpar.TabIndex = 6;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btoDivisao
            // 
            this.btoDivisao.Location = new System.Drawing.Point(323, 83);
            this.btoDivisao.Name = "btoDivisao";
            this.btoDivisao.Size = new System.Drawing.Size(42, 44);
            this.btoDivisao.TabIndex = 5;
            this.btoDivisao.Text = "/";
            this.btoDivisao.UseVisualStyleBackColor = true;
            this.btoDivisao.Click += new System.EventHandler(this.btoDivisao_Click);
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(371, 83);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(60, 27);
            this.btoSair.TabIndex = 7;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResult.Location = new System.Drawing.Point(12, 98);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(226, 36);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "0";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 155);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btoDivisao);
            this.Controls.Add(this.btoVezes);
            this.Controls.Add(this.btoSair);
            this.Controls.Add(this.btoLimpar);
            this.Controls.Add(this.btoMenos);
            this.Controls.Add(this.btoMais);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mini Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtN1;
        private TextBox txtN2;
        private Button btoMais;
        private Button btoMenos;
        private Button btoVezes;
        private Button btoLimpar;
        private Button btoDivisao;
        private Button btoSair;
        private Label lblResult;
    }
}