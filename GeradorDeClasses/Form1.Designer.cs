namespace GeradorDeClasses
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
            this.btnCriarClasse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeClasse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdicionaPropriedade = new System.Windows.Forms.TextBox();
            this.lstClasses = new System.Windows.Forms.ListBox();
            this.btnAdicionaPropriedade = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCriarClasse
            // 
            this.btnCriarClasse.Location = new System.Drawing.Point(12, 402);
            this.btnCriarClasse.Name = "btnCriarClasse";
            this.btnCriarClasse.Size = new System.Drawing.Size(381, 49);
            this.btnCriarClasse.TabIndex = 0;
            this.btnCriarClasse.Text = "Criar Classe";
            this.btnCriarClasse.UseVisualStyleBackColor = true;
            this.btnCriarClasse.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da classe:";
            // 
            // txtNomeClasse
            // 
            this.txtNomeClasse.Location = new System.Drawing.Point(111, 32);
            this.txtNomeClasse.Name = "txtNomeClasse";
            this.txtNomeClasse.Size = new System.Drawing.Size(282, 23);
            this.txtNomeClasse.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Propriedade:";
            // 
            // txtAdicionaPropriedade
            // 
            this.txtAdicionaPropriedade.Location = new System.Drawing.Point(111, 92);
            this.txtAdicionaPropriedade.Name = "txtAdicionaPropriedade";
            this.txtAdicionaPropriedade.Size = new System.Drawing.Size(282, 23);
            this.txtAdicionaPropriedade.TabIndex = 4;
            // 
            // lstClasses
            // 
            this.lstClasses.FormattingEnabled = true;
            this.lstClasses.ItemHeight = 15;
            this.lstClasses.Location = new System.Drawing.Point(12, 209);
            this.lstClasses.Name = "lstClasses";
            this.lstClasses.Size = new System.Drawing.Size(381, 169);
            this.lstClasses.TabIndex = 5;
            // 
            // btnAdicionaPropriedade
            // 
            this.btnAdicionaPropriedade.Location = new System.Drawing.Point(12, 154);
            this.btnAdicionaPropriedade.Name = "btnAdicionaPropriedade";
            this.btnAdicionaPropriedade.Size = new System.Drawing.Size(381, 39);
            this.btnAdicionaPropriedade.TabIndex = 6;
            this.btnAdicionaPropriedade.Text = "Adicionar propriedade";
            this.btnAdicionaPropriedade.UseVisualStyleBackColor = true;
            this.btnAdicionaPropriedade.Click += new System.EventHandler(this.btnAdicionaPropriedade_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(414, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(694, 419);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 471);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnAdicionaPropriedade);
            this.Controls.Add(this.lstClasses);
            this.Controls.Add(this.txtAdicionaPropriedade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeClasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCriarClasse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriarClasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeClasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdicionaPropriedade;
        private System.Windows.Forms.ListBox lstClasses;
        private System.Windows.Forms.Button btnAdicionaPropriedade;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
