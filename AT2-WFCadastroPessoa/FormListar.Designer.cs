﻿namespace AT2_WFCadastroPessoa
{
    partial class FormListar
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
            dgvListagem = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListagem).BeginInit();
            SuspendLayout();
            // 
            // dgvListagem
            // 
            dgvListagem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListagem.Dock = DockStyle.Fill;
            dgvListagem.Location = new Point(0, 0);
            dgvListagem.Name = "dgvListagem";
            dgvListagem.Size = new Size(800, 450);
            dgvListagem.TabIndex = 0;
            // 
            // FormListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListagem);
            Name = "FormListar";
            Text = "FormListar";
            Load += FormListar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListagem;
    }
}