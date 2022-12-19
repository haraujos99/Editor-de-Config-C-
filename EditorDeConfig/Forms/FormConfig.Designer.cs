
namespace EditorDeConfig.Forms {
    partial class FormConfig {
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
            this.panelConfig = new System.Windows.Forms.Panel();
            this.textBoxConfig = new System.Windows.Forms.TextBox();
            this.btnEditConfig = new FontAwesome.Sharp.IconButton();
            this.panelConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConfig
            // 
            this.panelConfig.AutoSize = true;
            this.panelConfig.Controls.Add(this.textBoxConfig);
            this.panelConfig.Location = new System.Drawing.Point(12, 45);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(543, 328);
            this.panelConfig.TabIndex = 2;
            // 
            // textBoxConfig
            // 
            this.textBoxConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxConfig.Location = new System.Drawing.Point(0, 0);
            this.textBoxConfig.Multiline = true;
            this.textBoxConfig.Name = "textBoxConfig";
            this.textBoxConfig.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxConfig.Size = new System.Drawing.Size(543, 328);
            this.textBoxConfig.TabIndex = 0;
            // 
            // btnEditConfig
            // 
            this.btnEditConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(59)))), ((int)(((byte)(33)))));
            this.btnEditConfig.FlatAppearance.BorderSize = 0;
            this.btnEditConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditConfig.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.btnEditConfig.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEditConfig.IconColor = System.Drawing.Color.Black;
            this.btnEditConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditConfig.Location = new System.Drawing.Point(428, 12);
            this.btnEditConfig.Name = "btnEditConfig";
            this.btnEditConfig.Size = new System.Drawing.Size(124, 27);
            this.btnEditConfig.TabIndex = 1;
            this.btnEditConfig.Text = "Salvar alterações";
            this.btnEditConfig.UseVisualStyleBackColor = false;
            this.btnEditConfig.Click += new System.EventHandler(this.btnEditConfig_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(112)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(564, 371);
            this.Controls.Add(this.btnEditConfig);
            this.Controls.Add(this.panelConfig);
            this.Name = "FormConfig";
            this.Text = "Configurações";
            this.panelConfig.ResumeLayout(false);
            this.panelConfig.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelConfig;
        private FontAwesome.Sharp.IconButton btnEditConfig;
        private System.Windows.Forms.TextBox textBoxConfig;
    }
}