using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSP_Mapping_Mate
{
    public partial class Form2 : Form
    {
        public Form1 Form;
        List<Evidence> _EvidenceList;
        public Form2()
        {
            InitializeComponent();
        }

        public void ShowForm(List<Evidence> EvidenceList)
        {
            EvidenceGrid.Rows.Clear();
            EvidenceGrid.Columns.Clear();
            EvidenceGrid.Columns.Add("Col1", "Evidence Name");
            foreach (Evidence Ev in EvidenceList)
            {
                EvidenceGrid.Rows.Add(Ev.Name);
            }
            _EvidenceList = EvidenceList;
            this.ShowDialog();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.EvidenceGrid.CurrentRow;
            Form.LoadEvidence(_EvidenceList[row.Index]);
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
