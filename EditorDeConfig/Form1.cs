using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EditorDeConfig.Forms;
using FontAwesome.Sharp;
using Utils;

namespace EditorDeConfig {
    public partial class MainForm : Form {

        private IconButton currentButton;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public MainForm() {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelBarraLateral.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ActivateButton(object senderBtn, Color color) {
            if(senderBtn != null) {
                DisableButton();
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(105, 59, 33);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconActualForm.IconChar = currentButton.IconChar;
                labelActualForm.Text = currentButton.Text;

            }
        }

        private void DisableButton() {
            if(currentButton != null) {
                
                currentButton.BackColor = Color.FromArgb(105, 59, 33);
                currentButton.ForeColor = Color.FromArgb(223, 224, 223);
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.FromArgb(223, 224, 223);
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                iconActualForm.IconChar = IconChar.Home;
                labelActualForm.Text = "Home";
            }
        }

        private void btnConfig_Click(object sender, EventArgs e) {
            ActivateButton(sender, Color.FromArgb(250, 112, 20));
            OpenChildForm(new FormConfig());

        }

        private void btnServico_Click(object sender, EventArgs e) {
            ActivateButton(sender, Color.FromArgb(250, 112, 20));
            OpenChildForm(new FormService());
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            DisableButton();
            leftBorderBtn.Visible = false;
            currentChildForm.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitle_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Normal) {
                WindowState = FormWindowState.Maximized;
            } else {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void OpenChildForm(Form childForm) {
            if(currentChildForm != null) {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelActualForm.Text = childForm.Text;
        }
    }
}
