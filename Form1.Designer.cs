
namespace test_99999999
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
            this.textcpf = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.textdia = new System.Windows.Forms.TextBox();
            this.labeldia = new System.Windows.Forms.Label();
            this.labelValordia = new System.Windows.Forms.Label();
            this.textvalordia = new System.Windows.Forms.TextBox();
            this.buttonPronto = new System.Windows.Forms.Button();
            this.textmes = new System.Windows.Forms.TextBox();
            this.textvalortotaldomes = new System.Windows.Forms.TextBox();
            this.labelmes = new System.Windows.Forms.Label();
            this.labelvalortotaldomes = new System.Windows.Forms.Label();
            this.labelvaloranual = new System.Windows.Forms.Label();
            this.textvaloranual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textcpf
            // 
            this.textcpf.Location = new System.Drawing.Point(79, 22);
            this.textcpf.Multiline = true;
            this.textcpf.Name = "textcpf";
            this.textcpf.Size = new System.Drawing.Size(153, 31);
            this.textcpf.TabIndex = 0;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCPF.Location = new System.Drawing.Point(9, 23);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(40, 19);
            this.labelCPF.TabIndex = 1;
            this.labelCPF.Text = "Cpf :";
            // 
            // textdia
            // 
            this.textdia.Location = new System.Drawing.Point(79, 69);
            this.textdia.Multiline = true;
            this.textdia.Name = "textdia";
            this.textdia.Size = new System.Drawing.Size(48, 29);
            this.textdia.TabIndex = 2;
            // 
            // labeldia
            // 
            this.labeldia.AutoSize = true;
            this.labeldia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labeldia.Location = new System.Drawing.Point(12, 70);
            this.labeldia.Name = "labeldia";
            this.labeldia.Size = new System.Drawing.Size(42, 19);
            this.labeldia.TabIndex = 3;
            this.labeldia.Text = " dia :";
            // 
            // labelValordia
            // 
            this.labelValordia.AutoSize = true;
            this.labelValordia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelValordia.Location = new System.Drawing.Point(9, 137);
            this.labelValordia.Name = "labelValordia";
            this.labelValordia.Size = new System.Drawing.Size(99, 19);
            this.labelValordia.TabIndex = 4;
            this.labelValordia.Text = "Valor do dia :";
            // 
            // textvalordia
            // 
            this.textvalordia.Location = new System.Drawing.Point(114, 127);
            this.textvalordia.Multiline = true;
            this.textvalordia.Name = "textvalordia";
            this.textvalordia.Size = new System.Drawing.Size(148, 29);
            this.textvalordia.TabIndex = 5;
            // 
            // buttonPronto
            // 
            this.buttonPronto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPronto.Location = new System.Drawing.Point(103, 320);
            this.buttonPronto.Name = "buttonPronto";
            this.buttonPronto.Size = new System.Drawing.Size(92, 38);
            this.buttonPronto.TabIndex = 6;
            this.buttonPronto.Text = "Pronto";
            this.buttonPronto.UseVisualStyleBackColor = true;
            this.buttonPronto.Click += new System.EventHandler(this.buttonPronto_Click);
            // 
            // textmes
            // 
            this.textmes.Location = new System.Drawing.Point(212, 69);
            this.textmes.Multiline = true;
            this.textmes.Name = "textmes";
            this.textmes.Size = new System.Drawing.Size(50, 29);
            this.textmes.TabIndex = 7;
            // 
            // textvalortotaldomes
            // 
            this.textvalortotaldomes.BackColor = System.Drawing.SystemColors.Menu;
            this.textvalortotaldomes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textvalortotaldomes.Location = new System.Drawing.Point(162, 188);
            this.textvalortotaldomes.Name = "textvalortotaldomes";
            this.textvalortotaldomes.Size = new System.Drawing.Size(100, 16);
            this.textvalortotaldomes.TabIndex = 8;
            // 
            // labelmes
            // 
            this.labelmes.AutoSize = true;
            this.labelmes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelmes.Location = new System.Drawing.Point(151, 70);
            this.labelmes.Name = "labelmes";
            this.labelmes.Size = new System.Drawing.Size(44, 19);
            this.labelmes.TabIndex = 9;
            this.labelmes.Text = "Mês :";
            // 
            // labelvalortotaldomes
            // 
            this.labelvalortotaldomes.AutoSize = true;
            this.labelvalortotaldomes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelvalortotaldomes.Location = new System.Drawing.Point(9, 185);
            this.labelvalortotaldomes.Name = "labelvalortotaldomes";
            this.labelvalortotaldomes.Size = new System.Drawing.Size(140, 19);
            this.labelvalortotaldomes.TabIndex = 10;
            this.labelvalortotaldomes.Text = "Valor total do Mês :";
            // 
            // labelvaloranual
            // 
            this.labelvaloranual.AutoSize = true;
            this.labelvaloranual.Location = new System.Drawing.Point(15, 230);
            this.labelvaloranual.Name = "labelvaloranual";
            this.labelvaloranual.Size = new System.Drawing.Size(67, 15);
            this.labelvaloranual.TabIndex = 11;
            this.labelvaloranual.Text = "Valor Anual";
            // 
            // textvaloranual
            // 
            this.textvaloranual.Location = new System.Drawing.Point(151, 230);
            this.textvaloranual.Name = "textvaloranual";
            this.textvaloranual.Size = new System.Drawing.Size(100, 23);
            this.textvaloranual.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 391);
            this.Controls.Add(this.textvaloranual);
            this.Controls.Add(this.labelvaloranual);
            this.Controls.Add(this.labelvalortotaldomes);
            this.Controls.Add(this.labelmes);
            this.Controls.Add(this.textvalortotaldomes);
            this.Controls.Add(this.textmes);
            this.Controls.Add(this.buttonPronto);
            this.Controls.Add(this.textvalordia);
            this.Controls.Add(this.labelValordia);
            this.Controls.Add(this.labeldia);
            this.Controls.Add(this.textdia);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.textcpf);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textcpf;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.TextBox textdia;
        private System.Windows.Forms.Label labeldia;
        private System.Windows.Forms.Label labelValordia;
        private System.Windows.Forms.TextBox textvalordia;
        private System.Windows.Forms.Button buttonPronto;
        private System.Windows.Forms.TextBox textmes;
        private System.Windows.Forms.TextBox textvalortotaldomes;
        private System.Windows.Forms.Label labelmes;
        private System.Windows.Forms.Label labelvalortotaldomes;
        private System.Windows.Forms.Label labelvaloranual;
        private System.Windows.Forms.TextBox textvaloranual;
    }
}

