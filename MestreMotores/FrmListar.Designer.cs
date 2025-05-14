namespace MestreMotores
{
    partial class FrmListar
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
            this.lblTabela = new System.Windows.Forms.Label();
            this.lblColuna = new System.Windows.Forms.Label();
            this.dtgListar = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTabela
            // 
            this.lblTabela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.lblTabela.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabela.ForeColor = System.Drawing.Color.White;
            this.lblTabela.Location = new System.Drawing.Point(0, 0);
            this.lblTabela.Name = "lblTabela";
            this.lblTabela.Size = new System.Drawing.Size(750, 50);
            this.lblTabela.TabIndex = 0;
            this.lblTabela.Text = "Tabela";
            this.lblTabela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColuna
            // 
            this.lblColuna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(76)))), ((int)(((byte)(146)))));
            this.lblColuna.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColuna.ForeColor = System.Drawing.Color.White;
            this.lblColuna.Location = new System.Drawing.Point(0, 50);
            this.lblColuna.Name = "lblColuna";
            this.lblColuna.Size = new System.Drawing.Size(30, 400);
            this.lblColuna.TabIndex = 1;
            this.lblColuna.Text = "Coluna";
            this.lblColuna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgListar
            // 
            this.dtgListar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.dtgListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListar.Location = new System.Drawing.Point(30, 50);
            this.dtgListar.Name = "dtgListar";
            this.dtgListar.Size = new System.Drawing.Size(770, 400);
            this.dtgListar.TabIndex = 2;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(750, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(50, 50);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dtgListar);
            this.Controls.Add(this.lblColuna);
            this.Controls.Add(this.lblTabela);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmListar";
            this.Text = "FrmListar";
            this.Load += new System.EventHandler(this.FrmListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTabela;
        private System.Windows.Forms.Label lblColuna;
        private System.Windows.Forms.DataGridView dtgListar;
        private System.Windows.Forms.Button btnFechar;
    }
}