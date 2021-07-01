namespace CorporationProjeto
{
    partial class frmListar
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
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.btnAlterarExcluir = new System.Windows.Forms.Button();
            this.gridListagem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridListagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.Location = new System.Drawing.Point(231, 98);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(152, 30);
            this.btnNovoUsuario.TabIndex = 0;
            this.btnNovoUsuario.Text = "NOVO USUÁRIO";
            this.btnNovoUsuario.UseVisualStyleBackColor = true;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnAlterarExcluir
            // 
            this.btnAlterarExcluir.Location = new System.Drawing.Point(413, 97);
            this.btnAlterarExcluir.Name = "btnAlterarExcluir";
            this.btnAlterarExcluir.Size = new System.Drawing.Size(153, 30);
            this.btnAlterarExcluir.TabIndex = 1;
            this.btnAlterarExcluir.Text = "ALTERAR / EXCLUIR";
            this.btnAlterarExcluir.UseVisualStyleBackColor = true;
            this.btnAlterarExcluir.Click += new System.EventHandler(this.btnAlterarExcluir_Click);
            // 
            // gridListagem
            // 
            this.gridListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListagem.Location = new System.Drawing.Point(145, 157);
            this.gridListagem.Name = "gridListagem";
            this.gridListagem.Size = new System.Drawing.Size(528, 118);
            this.gridListagem.TabIndex = 2;
            this.gridListagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListagem_CellContentClick);
            // 
            // frmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.gridListagem);
            this.Controls.Add(this.btnAlterarExcluir);
            this.Controls.Add(this.btnNovoUsuario);
            this.Name = "frmListar";
            this.Text = "LISTAGEM DE USUÁRIOS";
            this.Load += new System.EventHandler(this.frmListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Button btnAlterarExcluir;
        private System.Windows.Forms.DataGridView gridListagem;
    }
}