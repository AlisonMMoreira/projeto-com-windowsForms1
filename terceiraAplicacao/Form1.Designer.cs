namespace terceiraAplicacao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_adProd1 = new terceiraAplicacao.UC_adProd();
            this.uC_verEst1 = new terceiraAplicacao.UC_verEst();
            this.uC_retPeca1 = new terceiraAplicacao.UC_retPeca();
            this.uC_imRel1 = new terceiraAplicacao.UC_imRel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uC_prodCad1 = new terceiraAplicacao.UC_prodCad();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 375);
            this.panel1.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Swis721 WGL4 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(0, 0);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(200, 58);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Adicionar Produto";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Swis721 WGL4 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(0, 58);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(200, 58);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Verificar Estoque";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Swis721 WGL4 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(0, 116);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(200, 58);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "Retirar Produto";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Swis721 WGL4 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(0, 174);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(200, 58);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "Imp. Relatório";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn1);
            this.flowLayoutPanel1.Controls.Add(this.btn2);
            this.flowLayoutPanel1.Controls.Add(this.btn3);
            this.flowLayoutPanel1.Controls.Add(this.btn4);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.btn5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(202, 375);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 38);
            this.label1.TabIndex = 4;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Swis721 WGL4 BT", 15.75F);
            this.btn5.Location = new System.Drawing.Point(0, 270);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(198, 96);
            this.btn5.TabIndex = 3;
            this.btn5.Text = "Fechar";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.uC_adProd1);
            this.panel2.Controls.Add(this.uC_verEst1);
            this.panel2.Controls.Add(this.uC_retPeca1);
            this.panel2.Controls.Add(this.uC_imRel1);
            this.panel2.Location = new System.Drawing.Point(215, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 373);
            this.panel2.TabIndex = 3;
            // 
            // uC_adProd1
            // 
            this.uC_adProd1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_adProd1.Location = new System.Drawing.Point(0, 0);
            this.uC_adProd1.Name = "uC_adProd1";
            this.uC_adProd1.Size = new System.Drawing.Size(498, 373);
            this.uC_adProd1.TabIndex = 3;
            // 
            // uC_verEst1
            // 
            this.uC_verEst1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_verEst1.Location = new System.Drawing.Point(0, 0);
            this.uC_verEst1.Name = "uC_verEst1";
            this.uC_verEst1.Size = new System.Drawing.Size(498, 373);
            this.uC_verEst1.TabIndex = 2;
            // 
            // uC_retPeca1
            // 
            this.uC_retPeca1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_retPeca1.Location = new System.Drawing.Point(0, 0);
            this.uC_retPeca1.Name = "uC_retPeca1";
            this.uC_retPeca1.Size = new System.Drawing.Size(498, 373);
            this.uC_retPeca1.TabIndex = 1;
            // 
            // uC_imRel1
            // 
            this.uC_imRel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_imRel1.Location = new System.Drawing.Point(0, 0);
            this.uC_imRel1.Name = "uC_imRel1";
            this.uC_imRel1.Size = new System.Drawing.Size(498, 373);
            this.uC_imRel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(201, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 373);
            this.label2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uC_prodCad1);
            this.panel3.Location = new System.Drawing.Point(3, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 247);
            this.panel3.TabIndex = 4;
            // 
            // uC_prodCad1
            // 
            this.uC_prodCad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_prodCad1.Location = new System.Drawing.Point(0, 0);
            this.uC_prodCad1.Name = "uC_prodCad1";
            this.uC_prodCad1.Size = new System.Drawing.Size(492, 247);
            this.uC_prodCad1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 375);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(729, 414);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private UC_verEst uC_verEst1;
        private UC_retPeca uC_retPeca1;
        private UC_imRel uC_imRel1;
        private UC_adProd uC_adProd1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private UC_prodCad uC_prodCad1;
    }
}

