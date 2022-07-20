﻿namespace Entra21.BancoDados02.Ado.Net.Views.Cidades
{
    partial class CidadeListagemForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnidadeFederativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantidadeHabitantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataHoraFundacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnUnidadeFederativa,
            this.ColumnQuantidadeHabitantes,
            this.ColumnDataHoraFundacao,
            this.ColumnPib});
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(652, 252);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonApagar
            // 
            this.buttonApagar.Location = new System.Drawing.Point(427, 12);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 23);
            this.buttonApagar.TabIndex = 1;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(508, 12);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 2;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.Location = new System.Drawing.Point(589, 12);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastro.TabIndex = 3;
            this.buttonCadastro.Text = "Cadastro";
            this.buttonCadastro.UseVisualStyleBackColor = true;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Código";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            // 
            // ColumnUnidadeFederativa
            // 
            this.ColumnUnidadeFederativa.HeaderText = "UF";
            this.ColumnUnidadeFederativa.Name = "ColumnUnidadeFederativa";
            this.ColumnUnidadeFederativa.ReadOnly = true;
            // 
            // ColumnQuantidadeHabitantes
            // 
            this.ColumnQuantidadeHabitantes.HeaderText = "Quantidade Habitantes";
            this.ColumnQuantidadeHabitantes.Name = "ColumnQuantidadeHabitantes";
            this.ColumnQuantidadeHabitantes.ReadOnly = true;
            // 
            // ColumnDataHoraFundacao
            // 
            this.ColumnDataHoraFundacao.HeaderText = "Data Hora Fundação";
            this.ColumnDataHoraFundacao.Name = "ColumnDataHoraFundacao";
            this.ColumnDataHoraFundacao.ReadOnly = true;
            // 
            // ColumnPib
            // 
            this.ColumnPib.HeaderText = "PIB";
            this.ColumnPib.Name = "ColumnPib";
            this.ColumnPib.ReadOnly = true;
            // 
            // CidadeListagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 312);
            this.Controls.Add(this.buttonCadastro);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonApagar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CidadeListagemForm";
            this.Text = "CidadeListagemForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonApagar;
        private Button buttonEditar;
        private Button buttonCadastro;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNome;
        private DataGridViewTextBoxColumn ColumnUnidadeFederativa;
        private DataGridViewTextBoxColumn ColumnQuantidadeHabitantes;
        private DataGridViewTextBoxColumn ColumnDataHoraFundacao;
        private DataGridViewTextBoxColumn ColumnPib;
    }
}