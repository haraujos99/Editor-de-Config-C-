using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace EditorDeConfig.Forms {
    public partial class FormConfig : Form {
        TxtManager configFile;
        public FormConfig() {
            InitializeComponent();
            configFile = new TxtManager( @"C:\Users\luiz.sales\Documents\Projetos-Integracao\TESTE\Origem");
            textBoxConfig.Text = configFile.ReadFile("appsettings.json");
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void btnEditConfig_Click(object sender, EventArgs e) {
            try {
                configFile.OverwriteFile(textBoxConfig.Text, "appsettings.json");
                MessageBox.Show("Alteração salva!");
            } catch (Exception ex){
                MessageBox.Show(ex.Message);
            }

        }
    }
}
