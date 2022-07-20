namespace Entra21.BancoDados02.Ado.Net.Views
{
    partial class MenuPrincipalForm
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
            this.buttonUf = new System.Windows.Forms.Button();
            this.buttonCidade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUf
            // 
            this.buttonUf.Location = new System.Drawing.Point(12, 12);
            this.buttonUf.Name = "buttonUf";
            this.buttonUf.Size = new System.Drawing.Size(75, 65);
            this.buttonUf.TabIndex = 0;
            this.buttonUf.Text = "UF";
            this.buttonUf.UseVisualStyleBackColor = true;
            this.buttonUf.Click += new System.EventHandler(this.buttonUf_Click);
            // 
            // buttonCidade
            // 
            this.buttonCidade.Location = new System.Drawing.Point(93, 12);
            this.buttonCidade.Name = "buttonCidade";
            this.buttonCidade.Size = new System.Drawing.Size(75, 65);
            this.buttonCidade.TabIndex = 1;
            this.buttonCidade.Text = "Cidade";
            this.buttonCidade.UseVisualStyleBackColor = true;
            this.buttonCidade.Click += new System.EventHandler(this.buttonCidade_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 91);
            this.Controls.Add(this.buttonCidade);
            this.Controls.Add(this.buttonUf);
            this.Name = "MenuPrincipalForm";
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonUf;
        private Button buttonCidade;
    }
}