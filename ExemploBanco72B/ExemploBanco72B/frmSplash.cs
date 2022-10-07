using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExemploBanco72B
{
    public partial class frmSplash: Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private async void frmSplash_Load(object sender, EventArgs e)
        {
            int contagem = 0;
            do
            {
                await Task.Delay(30);
                pgbCarrega.Value++;
                contagem++;
            }while(contagem < 100);
             this.Close();
        }
    }
}
