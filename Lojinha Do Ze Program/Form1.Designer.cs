﻿namespace Lojinha_Do_Ze
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(479, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(388, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonInserir.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserir.ForeColor = System.Drawing.Color.Peru;
            this.buttonInserir.Location = new System.Drawing.Point(11, 425);
            this.buttonInserir.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(223, 138);
            this.buttonInserir.TabIndex = 1;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonConsultar.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.ForeColor = System.Drawing.Color.Peru;
            this.buttonConsultar.Location = new System.Drawing.Point(583, 425);
            this.buttonConsultar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(284, 138);
            this.buttonConsultar.TabIndex = 2;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lojinha do Zé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(15, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(19, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(261, 32);
            this.txtNome.TabIndex = 6;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(19, 175);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(261, 58);
            this.txtDesc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(15, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(19, 271);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(261, 32);
            this.txtPreco.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News706 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(15, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantidade";
            // 
            // txtQuant
            // 
            this.txtQuant.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(19, 341);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(261, 32);
            this.txtQuant.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(878, 576);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Niagara Engraved", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "Lojinha do Zé";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuant;
    }
}

