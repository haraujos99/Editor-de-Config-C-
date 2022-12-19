
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
            this.panel1.SuspendLayout();
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
            this.btnLigarServico.Location = new System.Drawing.Point(308, 161);
            this.btnLigarServico.Name = "btnLigarServico";
            this.btnLigarServico.Size = new System.Drawing.Size(101, 71);
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
            this.btnPararServico.Location = new System.Drawing.Point(161, 161);
            this.btnPararServico.Name = "btnPararServico";
            this.btnPararServico.Size = new System.Drawing.Size(101, 71);
            this.btnPararServico.TabIndex = 1;
            this.btnPararServico.Text = "Parar";
            this.btnPararServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPararServico.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLigarServico);
            this.panel1.Controls.Add(this.btnPararServico);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 371);
            this.panel1.TabIndex = 2;
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
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnLigarServico;
        private FontAwesome.Sharp.IconButton btnPararServico;
        private System.Windows.Forms.Panel panel1;
    }
}