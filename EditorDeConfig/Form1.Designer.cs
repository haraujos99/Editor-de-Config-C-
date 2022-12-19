
namespace EditorDeConfig {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelBarraLateral = new System.Windows.Forms.Panel();
            this.btnServico = new FontAwesome.Sharp.IconButton();
            this.btnConfig = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximizar = new FontAwesome.Sharp.IconPictureBox();
            this.btnFechar = new FontAwesome.Sharp.IconPictureBox();
            this.labelActualForm = new System.Windows.Forms.Label();
            this.iconActualForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBarraLateral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconActualForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraLateral
            // 
            this.panelBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(59)))), ((int)(((byte)(33)))));
            this.panelBarraLateral.Controls.Add(this.btnServico);
            this.panelBarraLateral.Controls.Add(this.btnConfig);
            this.panelBarraLateral.Controls.Add(this.panel1);
            this.panelBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBarraLateral.Location = new System.Drawing.Point(0, 0);
            this.panelBarraLateral.Name = "panelBarraLateral";
            this.panelBarraLateral.Size = new System.Drawing.Size(220, 450);
            this.panelBarraLateral.TabIndex = 0;
            // 
            // btnServico
            // 
            this.btnServico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServico.FlatAppearance.BorderSize = 0;
            this.btnServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServico.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.btnServico.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnServico.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.btnServico.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServico.IconSize = 32;
            this.btnServico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServico.Location = new System.Drawing.Point(0, 200);
            this.btnServico.Name = "btnServico";
            this.btnServico.Size = new System.Drawing.Size(220, 60);
            this.btnServico.TabIndex = 3;
            this.btnServico.Text = "Parar/Ligar Serviço";
            this.btnServico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServico.UseVisualStyleBackColor = true;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(59)))), ((int)(((byte)(33)))));
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.btnConfig.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnConfig.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.btnConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfig.IconSize = 32;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 140);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(220, 60);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "Configurações";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 140);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::EditorDeConfig.Properties.Resources.LOGO__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(59)))), ((int)(((byte)(33)))));
            this.panelTitle.Controls.Add(this.btnMinimizar);
            this.panelTitle.Controls.Add(this.btnMaximizar);
            this.panelTitle.Controls.Add(this.btnFechar);
            this.panelTitle.Controls.Add(this.labelActualForm);
            this.panelTitle.Controls.Add(this.iconActualForm);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(580, 40);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(59)))), ((int)(((byte)(33)))));
            this.btnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 15;
            this.btnMinimizar.Location = new System.Drawing.Point(535, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnMinimizar.Size = new System.Drawing.Size(15, 40);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(59)))), ((int)(((byte)(33)))));
            this.btnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.SquareFull;
            this.btnMaximizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximizar.IconSize = 15;
            this.btnMaximizar.Location = new System.Drawing.Point(550, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnMaximizar.Size = new System.Drawing.Size(15, 40);
            this.btnMaximizar.TabIndex = 3;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(59)))), ((int)(((byte)(33)))));
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.btnFechar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnFechar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.btnFechar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFechar.IconSize = 15;
            this.btnFechar.Location = new System.Drawing.Point(565, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnFechar.Size = new System.Drawing.Size(15, 40);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // labelActualForm
            // 
            this.labelActualForm.AutoSize = true;
            this.labelActualForm.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelActualForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.labelActualForm.Location = new System.Drawing.Point(21, 19);
            this.labelActualForm.Name = "labelActualForm";
            this.labelActualForm.Size = new System.Drawing.Size(46, 19);
            this.labelActualForm.TabIndex = 1;
            this.labelActualForm.Text = "Home";
            // 
            // iconActualForm
            // 
            this.iconActualForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(59)))), ((int)(((byte)(33)))));
            this.iconActualForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.iconActualForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconActualForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.iconActualForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconActualForm.IconSize = 15;
            this.iconActualForm.Location = new System.Drawing.Point(6, 22);
            this.iconActualForm.Name = "iconActualForm";
            this.iconActualForm.Size = new System.Drawing.Size(15, 15);
            this.iconActualForm.TabIndex = 0;
            this.iconActualForm.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(112)))), ((int)(((byte)(20)))));
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(580, 410);
            this.panelMain.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelBarraLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.panelBarraLateral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconActualForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraLateral;
        private FontAwesome.Sharp.IconButton btnConfig;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnServico;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconPictureBox iconActualForm;
        private System.Windows.Forms.Label labelActualForm;
        private FontAwesome.Sharp.IconPictureBox btnFechar;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private FontAwesome.Sharp.IconPictureBox btnMaximizar;
        private System.Windows.Forms.Panel panelMain;
    }
}

