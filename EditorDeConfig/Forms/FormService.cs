using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using Microsoft.Win32;

namespace EditorDeConfig.Forms {
    public partial class FormService : Form {
        public FormService() {
            InitializeComponent();
        }

        private void MontaColunasListView() {
            listaServicos.Columns.Add("Nome", 250, HorizontalAlignment.Left);
            listaServicos.Columns.Add("Status", 100, HorizontalAlignment.Left);
            listaServicos.Columns.Add("Localização", 500, HorizontalAlignment.Left);
            listaServicos.Columns.Add("Descrição", 500, HorizontalAlignment.Left);
        }
        private void btnListarServicos_Click(object sender, EventArgs e) {
                ServiceController[] services = ServiceController.GetServices();
                MontaColunasListView();

                foreach(ServiceController service in services) {
                    try {
                        ListViewItem linhaListView = new ListViewItem();

                        linhaListView.Text = service.ServiceName.ToString();
                        linhaListView.SubItems.Add(service.Status.ToString());

                        RegistryKey regKey1 = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\" + service.ServiceName);
                        linhaListView.SubItems.Add(regKey1.GetValue("ImagePath").ToString());
                        linhaListView.SubItems.Add(regKey1.GetValue("Description").ToString());
                        regKey1.Close();

                        listaServicos.Items.Add(linhaListView);
                    }
                    catch(Exception ex) {
                        Console.WriteLine(ex.Message);
                    }
                };
        }
    }
}
