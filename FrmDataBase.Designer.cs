namespace Database_Kira
{
    partial class FrmDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataBase));
            this.Bottun_Medico = new System.Windows.Forms.Button();
            this.Bottun_Consultas = new System.Windows.Forms.Button();
            this.Button_Pacientes = new System.Windows.Forms.Button();
            this.GrupoBox = new System.Windows.Forms.GroupBox();
            this.GrupoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bottun_Medico
            // 
            this.Bottun_Medico.BackgroundImage = global::Database_Kira.Properties.Resources.MédicoV2;
            resources.ApplyResources(this.Bottun_Medico, "Bottun_Medico");
            this.Bottun_Medico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bottun_Medico.Name = "Bottun_Medico";
            this.Bottun_Medico.TabStop = false;
            this.Bottun_Medico.UseVisualStyleBackColor = true;
            this.Bottun_Medico.Click += new System.EventHandler(this.Bottun_Medico_Click);
            // 
            // Bottun_Consultas
            // 
            this.Bottun_Consultas.BackgroundImage = global::Database_Kira.Properties.Resources.ConsultasX2;
            resources.ApplyResources(this.Bottun_Consultas, "Bottun_Consultas");
            this.Bottun_Consultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bottun_Consultas.Name = "Bottun_Consultas";
            this.Bottun_Consultas.TabStop = false;
            this.Bottun_Consultas.UseVisualStyleBackColor = true;
            this.Bottun_Consultas.Click += new System.EventHandler(this.Bottun_Consultas_Click);
            // 
            // Button_Pacientes
            // 
            this.Button_Pacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_Pacientes.BackgroundImage = global::Database_Kira.Properties.Resources.PacienteX2;
            resources.ApplyResources(this.Button_Pacientes, "Button_Pacientes");
            this.Button_Pacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Pacientes.Name = "Button_Pacientes";
            this.Button_Pacientes.TabStop = false;
            this.Button_Pacientes.UseVisualStyleBackColor = false;
            this.Button_Pacientes.Click += new System.EventHandler(this.Button_Pacientes_Click);
            // 
            // GrupoBox
            // 
            this.GrupoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GrupoBox.Controls.Add(this.Bottun_Medico);
            this.GrupoBox.Controls.Add(this.Button_Pacientes);
            this.GrupoBox.Controls.Add(this.Bottun_Consultas);
            resources.ApplyResources(this.GrupoBox, "GrupoBox");
            this.GrupoBox.Name = "GrupoBox";
            this.GrupoBox.TabStop = false;
            // 
            // FrmDataBase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Database_Kira.Properties.Resources.bkg_blu;
            this.Controls.Add(this.GrupoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDataBase";
            this.Load += new System.EventHandler(this.FrmDataBase_Load);
            this.GrupoBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Bottun_Consultas;
        private System.Windows.Forms.Button Bottun_Medico;
        private System.Windows.Forms.Button Button_Pacientes;
        private System.Windows.Forms.GroupBox GrupoBox;
    }
}

