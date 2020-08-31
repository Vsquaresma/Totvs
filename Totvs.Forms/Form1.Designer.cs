namespace Totvs.Forms
{
    partial class Form1
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
            this.txtURI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnDeletarPaciente = new System.Windows.Forms.Button();
            this.btnAtualizaPaciente = new System.Windows.Forms.Button();
            this.btnIncluirPaciente = new System.Windows.Forms.Button();
            this.btnPacientesPorId = new System.Windows.Forms.Button();
            this.btnObterPacientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtURI
            // 
            this.txtURI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURI.Location = new System.Drawing.Point(168, 23);
            this.txtURI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(885, 26);
            this.txtURI.TabIndex = 11;
            this.txtURI.Text = "https://localhost:44303/Api/Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "URI - Web API : ";
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(28, 65);
            this.dgvDados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersWidth = 51;
            this.dgvDados.Size = new System.Drawing.Size(1027, 416);
            this.dgvDados.TabIndex = 9;
            // 
            // btnDeletarPaciente
            // 
            this.btnDeletarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDeletarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarPaciente.Location = new System.Drawing.Point(856, 489);
            this.btnDeletarPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeletarPaciente.Name = "btnDeletarPaciente";
            this.btnDeletarPaciente.Size = new System.Drawing.Size(199, 54);
            this.btnDeletarPaciente.TabIndex = 4;
            this.btnDeletarPaciente.Text = "Deletar Paciente";
            this.btnDeletarPaciente.UseVisualStyleBackColor = false;
            this.btnDeletarPaciente.Click += new System.EventHandler(this.btnDeletarPaciente_Click);
            // 
            // btnAtualizaPaciente
            // 
            this.btnAtualizaPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAtualizaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizaPaciente.Location = new System.Drawing.Point(649, 489);
            this.btnAtualizaPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtualizaPaciente.Name = "btnAtualizaPaciente";
            this.btnAtualizaPaciente.Size = new System.Drawing.Size(199, 54);
            this.btnAtualizaPaciente.TabIndex = 5;
            this.btnAtualizaPaciente.Text = "Atualizar Paciente";
            this.btnAtualizaPaciente.UseVisualStyleBackColor = false;
            this.btnAtualizaPaciente.Click += new System.EventHandler(this.btnAtualizaPaciente_Click);
            // 
            // btnIncluirPaciente
            // 
            this.btnIncluirPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnIncluirPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirPaciente.Location = new System.Drawing.Point(443, 489);
            this.btnIncluirPaciente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIncluirPaciente.Name = "btnIncluirPaciente";
            this.btnIncluirPaciente.Size = new System.Drawing.Size(199, 54);
            this.btnIncluirPaciente.TabIndex = 6;
            this.btnIncluirPaciente.Text = "Incluir Paciente";
            this.btnIncluirPaciente.UseVisualStyleBackColor = false;
            this.btnIncluirPaciente.Click += new System.EventHandler(this.btnIncluirPaciente_Click);
            // 
            // btnPacientesPorId
            // 
            this.btnPacientesPorId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPacientesPorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientesPorId.Location = new System.Drawing.Point(236, 489);
            this.btnPacientesPorId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPacientesPorId.Name = "btnPacientesPorId";
            this.btnPacientesPorId.Size = new System.Drawing.Size(199, 54);
            this.btnPacientesPorId.TabIndex = 7;
            this.btnPacientesPorId.Text = "Obter Paciente Por ID";
            this.btnPacientesPorId.UseVisualStyleBackColor = false;
            this.btnPacientesPorId.Click += new System.EventHandler(this.btnPacientesPorId_Click);
            // 
            // btnObterPacientes
            // 
            this.btnObterPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnObterPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObterPacientes.Location = new System.Drawing.Point(29, 489);
            this.btnObterPacientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnObterPacientes.Name = "btnObterPacientes";
            this.btnObterPacientes.Size = new System.Drawing.Size(199, 54);
            this.btnObterPacientes.TabIndex = 8;
            this.btnObterPacientes.Text = "Retornar Pacientes";
            this.btnObterPacientes.UseVisualStyleBackColor = false;
            this.btnObterPacientes.Click += new System.EventHandler(this.btnObterPacientes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1084, 553);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnDeletarPaciente);
            this.Controls.Add(this.btnAtualizaPaciente);
            this.Controls.Add(this.btnIncluirPaciente);
            this.Controls.Add(this.btnPacientesPorId);
            this.Controls.Add(this.btnObterPacientes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumindo Web API";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnDeletarPaciente;
        private System.Windows.Forms.Button btnAtualizaPaciente;
        private System.Windows.Forms.Button btnIncluirPaciente;
        private System.Windows.Forms.Button btnPacientesPorId;
        private System.Windows.Forms.Button btnObterPacientes;
    }
}

