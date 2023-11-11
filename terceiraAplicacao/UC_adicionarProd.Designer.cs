namespace terceiraAplicacao
{
    partial class UC_adProd
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rdBtnSim = new System.Windows.Forms.RadioButton();
            this.grpBoxOne = new System.Windows.Forms.GroupBox();
            this.rdBtnNao = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_prodCad1 = new terceiraAplicacao.UC_prodCad();
            this.uC_verEst1 = new terceiraAplicacao.UC_verEst();
            this.grpBoxOne.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Swis721 WGL4 BT", 15.75F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Produtos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdBtnSim
            // 
            this.rdBtnSim.AutoSize = true;
            this.rdBtnSim.Location = new System.Drawing.Point(75, 31);
            this.rdBtnSim.Name = "rdBtnSim";
            this.rdBtnSim.Size = new System.Drawing.Size(62, 29);
            this.rdBtnSim.TabIndex = 1;
            this.rdBtnSim.TabStop = true;
            this.rdBtnSim.Text = "Sim";
            this.rdBtnSim.UseVisualStyleBackColor = true;
            this.rdBtnSim.CheckedChanged += new System.EventHandler(this.rdBtnSim_CheckedChanged);
            // 
            // grpBoxOne
            // 
            this.grpBoxOne.Controls.Add(this.rdBtnNao);
            this.grpBoxOne.Controls.Add(this.rdBtnSim);
            this.grpBoxOne.Font = new System.Drawing.Font("Swis721 WGL4 BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxOne.Location = new System.Drawing.Point(124, 296);
            this.grpBoxOne.Name = "grpBoxOne";
            this.grpBoxOne.Size = new System.Drawing.Size(286, 66);
            this.grpBoxOne.TabIndex = 2;
            this.grpBoxOne.TabStop = false;
            this.grpBoxOne.Text = "O produto já está cadastrado?";
            // 
            // rdBtnNao
            // 
            this.rdBtnNao.AutoSize = true;
            this.rdBtnNao.Location = new System.Drawing.Point(143, 31);
            this.rdBtnNao.Name = "rdBtnNao";
            this.rdBtnNao.Size = new System.Drawing.Size(65, 29);
            this.rdBtnNao.TabIndex = 2;
            this.rdBtnNao.TabStop = true;
            this.rdBtnNao.Text = "Não";
            this.rdBtnNao.UseVisualStyleBackColor = true;
            this.rdBtnNao.CheckedChanged += new System.EventHandler(this.rdBtnNao_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_verEst1);
            this.panel1.Controls.Add(this.uC_prodCad1);
            this.panel1.Location = new System.Drawing.Point(5, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 251);
            this.panel1.TabIndex = 3;
            // 
            // uC_prodCad1
            // 
            this.uC_prodCad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_prodCad1.Location = new System.Drawing.Point(0, 0);
            this.uC_prodCad1.Name = "uC_prodCad1";
            this.uC_prodCad1.Size = new System.Drawing.Size(525, 251);
            this.uC_prodCad1.TabIndex = 0;
            // 
            // uC_verEst1
            // 
            this.uC_verEst1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_verEst1.Location = new System.Drawing.Point(0, 0);
            this.uC_verEst1.Name = "uC_verEst1";
            this.uC_verEst1.Size = new System.Drawing.Size(525, 251);
            this.uC_verEst1.TabIndex = 1;
            // 
            // UC_adProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpBoxOne);
            this.Controls.Add(this.label1);
            this.Name = "UC_adProd";
            this.Size = new System.Drawing.Size(533, 365);
            this.grpBoxOne.ResumeLayout(false);
            this.grpBoxOne.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBtnSim;
        private System.Windows.Forms.GroupBox grpBoxOne;
        private System.Windows.Forms.RadioButton rdBtnNao;
        private System.Windows.Forms.Panel panel1;
        private UC_prodCad uC_prodCad1;
        private UC_verEst uC_verEst1;
    }
}
