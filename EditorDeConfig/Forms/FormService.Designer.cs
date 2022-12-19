
namespace EditorDeConfig.Forms {
    partial class FormService {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnLigarServico = new FontAwesome.Sharp.IconButton();
            this.btnPararServico = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaServicos = new System.Windows.Forms.ListView();
            this.btnListarServicos = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLigarServico
            // 
            this.btnLigarServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnLigarServico.FlatAppearance.BorderSize = 0;
            this.btnLigarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLigarServico.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLigarServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnLigarServico.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnLigarServico.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(94)))));
            this.btnLigarServico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLigarServico.IconSize = 35;
            this.btnLigarServico.Location = new System.Drawing.Point(506, 71);
            this.btnLigarServico.Name = "btnLigarServico";
            this.btnLigarServico.Size = new System.Drawing.Size(55, 55);
            this.btnLigarServico.TabIndex = 0;
            this.btnLigarServico.Text = "Ligar";
            this.btnLigarServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLigarServico.UseVisualStyleBackColor = false;
            // 
            // btnPararServico
            // 
            this.btnPararServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPararServico.FlatAppearance.BorderSize = 0;
            this.btnPararServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPararServico.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPararServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnPararServico.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.btnPararServico.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPararServico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPararServico.IconSize = 35;
            this.btnPararServico.Location = new System.Drawing.Point(446, 71);
            this.btnPararServico.Name = "btnPararServico";
            this.btnPararServico.Size = new System.Drawing.Size(55, 55);
            this.btnPararServico.TabIndex = 1;
            this.btnPararServico.Text = "Parar";
            this.btnPararServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPararServico.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnListarServicos);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnLigarServico);
            this.panel1.Controls.Add(this.btnPararServico);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 371);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaServicos);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 349);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serviços do Windows";
            // 
            // listaServicos
            // 
            this.listaServicos.HideSelection = false;
            this.listaServicos.Location = new System.Drawing.Point(7, 23);
            this.listaServicos.Name = "listaServicos";
            this.listaServicos.Size = new System.Drawing.Size(414, 327);
            this.listaServicos.TabIndex = 0;
            this.listaServicos.UseCompatibleStateImageBehavior = false;
            // 
            // btnListarServicos
            // 
            this.btnListarServicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(59)))), ((int)(((byte)(33)))));
            this.btnListarServicos.FlatAppearance.BorderSize = 0;
            this.btnListarServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarServicos.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListarServicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnListarServicos.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnListarServicos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(241)))));
            this.btnListarServicos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarServicos.IconSize = 35;
            this.btnListarServicos.Location = new System.Drawing.Point(446, 25);
            this.btnListarServicos.Name = "btnListarServicos";
            this.btnListarServicos.Size = new System.Drawing.Size(118, 40);
            this.btnListarServicos.TabIndex = 3;
            this.btnListarServicos.Text = "Listar Serviços";
            this.btnListarServicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListarServicos.UseVisualStyleBackColor = false;
            this.btnListarServicos.Click += new System.EventHandler(this.btnListarServicos_Click);
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(112)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(564, 371);
            this.Controls.Add(this.panel1);
            this.Name = "FormService";
            this.Text = "FormService";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnLigarServico;
        private FontAwesome.Sharp.IconButton btnPararServico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaServicos;
        private FontAwesome.Sharp.IconButton btnListarServicos;
    }
}