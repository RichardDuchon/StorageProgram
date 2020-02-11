using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageProgram
{
    public partial class CompanyFrm : MetroFramework.Forms.MetroForm
    {
        public CompanyFrm()
        {
            InitializeComponent();
        }

        private void CompanyFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zltMgx2tGNDataSet1.Company' table. You can move, or remove it, as needed.
            this.companyTableAdapter.Fill(this.zltMgx2tGNDataSet1.Company);

        }
    }
}
