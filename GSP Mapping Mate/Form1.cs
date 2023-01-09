using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml;

namespace GSP_Mapping_Mate
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Competency> CompDict = new Dictionary<string, Competency>();
        private Dictionary<int, string[]> SubDomainsDict = new Dictionary<int, string[]>();
        public Form2 f2;
        private List<Evidence> _EvidenceList; //Kept it in from when ti was two forms maybe i can stream line it later... not sure its toally needed.
        private string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public Form1()
        {
            try
            {
                InitializeComponent();
                Load += Form1_Load;
                f2 = new Form2();
                f2.Form = this;


                CompViewer.Columns.Add("Col1", "Name");
                CompAssinged.Columns.Add("Col1", "Name");
                MissingComp.Columns.Add("Col1", "Name");

                EvLeaderBoard.Columns.Add("Col1", "Evidence Title");
                EvLeaderBoard.Columns.Add("Col2", "Comptencies Mapped");
                EvLeaderBoard.ColumnHeadersVisible = true;

                SelectedComp.Text = "X.X.X";

                CompViewer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                CompViewer.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                CompViewer.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                CompViewer.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                CompAssinged.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                CompAssinged.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                CompAssinged.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                CompAssinged.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                CompAssinged.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;





                XmlDocument doc = new XmlDocument();
                doc.Load("GSPComps.xml");
                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    string id = "-1";
                    string RootComp = "-1";
                    List<string> ChildComps = new List<string>();
                    foreach (XmlNode ChildNode in node.ChildNodes)
                    {
                        if (ChildNode.Name == "id") { id = ChildNode.InnerText; }
                        if (ChildNode.Name == "RootComp") { RootComp = ChildNode.InnerText; }
                        if (ChildNode.Name == "ChildComp") { ChildComps.Add(ChildNode.InnerText); }
                    }

                    CompDict.Add(id, new Competency(id, RootComp, ChildComps));
                }


                doc = new XmlDocument();
                doc.Load("GSPDomains.xml");


                for (int i = 0; i < doc.DocumentElement.ChildNodes.Count; i++) { DomainCombo.Items.Add(""); }

                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    //Get the domains in the list...
                    string DomainName = node.SelectNodes("name")[0].InnerText;
                    int id = int.Parse(node.SelectNodes("id")[0].InnerText);
                    DomainCombo.Items[id - 1] = DomainName;

                    //Get the subdomains and put the im in the dict
                    int SubDomainCount = node.SelectNodes("subdomain").Count;
                    SubDomainsDict.Add(id, new string[SubDomainCount]);

                    foreach (XmlNode SubNode in node.SelectNodes("subdomain"))
                    {
                        string SubDomainName = SubNode.SelectNodes("name")[0].InnerText;
                        int Subid = int.Parse(SubNode.SelectNodes("id")[0].InnerText);
                        SubDomainsDict[id][Subid - 1] = SubDomainName;
                    }

                }

                DomainCombo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData.PerformClick();
        }



        private void DomainCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<string> SubDomains = SubDomainsDict[DomainCombo.SelectedIndex + 1].ToList();
                int ID = 1;
                SubDomainCombo.Items.Clear();
                foreach (string SubDomain in SubDomains)
                {
                    SubDomainCombo.Items.Add(ID.ToString() + " " + SubDomain);
                    ID++;
                }
                SubDomainCombo.SelectedIndex = 0;
                UpdateCompDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateCompDisplay()
        {
            try
            {
                if (Domain3.Items.Count == 0)
                    SelectedComp.Text = (DomainCombo.SelectedIndex + 1).ToString() + "." + (SubDomainCombo.SelectedIndex + 1).ToString() + ".X";
                else
                    SelectedComp.Text = (DomainCombo.SelectedIndex + 1).ToString() + "." + (SubDomainCombo.SelectedIndex + 1).ToString() + "." + (Domain3.SelectedIndex + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SubDomainCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Domain3.Items.Clear();
                foreach (KeyValuePair<string, Competency> entry in CompDict)
                {
                    string[] IDS = entry.Key.Split('.');
                    if (int.Parse(IDS[0]) == DomainCombo.SelectedIndex + 1 && int.Parse(IDS[1]) == SubDomainCombo.SelectedIndex + 1)
                    {
                        Domain3.Items.Add(IDS[2]);
                    }
                }
                if (Domain3.Items.Count > 0)
                    Domain3.SelectedIndex = 0;
                UpdateCompDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Domain3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateCompDisplay();
                //Update the display
                CompViewer.Rows.Clear();

                CompViewer.Rows.Add(SelectedComp.Text + " " + CompDict[SelectedComp.Text].RootComp);

                int count = 0;
                foreach (string ChildComp in CompDict[SelectedComp.Text].ChildComps)
                {
                    CompViewer.Rows.Add("(" + alphabet[count] + ") " + ChildComp);
                    CompViewer.Rows[CompViewer.Rows.Count - 1].Cells[0].Style.Padding = new Padding(30, 0, 0, 0);
                    count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SaveEv_Click(object sender, EventArgs e)
        {
            try
            {
                Evidence Ev = new Evidence(EvName.Text, EvDesc.Text);
                if (FileName.Text != "") { Ev.FileName = FileName.Text; }
                Ev.CompDict = GetDictFromDataGrid(CompAssinged);
                Ev.SaveEvidence();
                RefreshData.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            try
            {
                var filePath = string.Empty;
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;
                    }
                }
                FileName.Text = filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileName.Text != "")
                {
                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = FileName.Text;
                    psi.UseShellExecute = true;
                    Process.Start(psi);
                }
                else
                {
                    throw new Exception("Error: No file selected!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void RefreshData_Click(object sender, EventArgs e)
        {
            try
            {
                List<Evidence> Evidences = new List<Evidence>();

                DirectoryInfo dinfo = new DirectoryInfo(@"EvidenceDatabase");
                FileInfo[] Files = dinfo.GetFiles("*.bin");
                foreach (FileInfo file in Files)
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read);
                    Evidence Evidence = (Evidence)formatter.Deserialize(stream);
                    Evidences.Add(Evidence);
                    stream.Close();
                }
                PopDBList(Evidences);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadEv_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.EvidenceGrid.CurrentRow;

            if (row==null)
                throw new Exception("Error: No files selected!");

            LoadEvidence(_EvidenceList[row.Index]);
        }
        public void LoadEvidence(Evidence Ev)
        {
            EvName.Text = Ev.Name;
            EvDesc.Text = Ev.Description;
            FileName.Text = Ev.FileName;
            AddDictToDataGrid(CompAssinged, Ev.CompDict);
        }

        public void PopDBList(List<Evidence> EvidenceList)
        {
            EvidenceGrid.Rows.Clear();
            EvidenceGrid.Columns.Clear();
            EvidenceGrid.Columns.Add("Col1", "Evidence Name");
            foreach (Evidence Ev in EvidenceList)
            {
                EvidenceGrid.Rows.Add(Ev.Name);
            }
            _EvidenceList = EvidenceList;
            //this.ShowDialog();
        }

        private void AddComp_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> SelectedRows_Idx = new List<int>();
                foreach (DataGridViewCell cell in CompViewer.SelectedCells)
                {
                    SelectedRows_Idx.Add(cell.RowIndex);
                }

                if (CompViewer.SelectedCells.Count > 0)
                {
                    //If we select the root
                    if (SelectedRows_Idx.Contains(0) && SelectedRows_Idx.Count == 1)
                    {
                        foreach (DataGridViewRow row in CompViewer.Rows)
                        {
                            CompAssinged.Rows.Add(row.Cells[0].Value.ToString());
                            CompAssinged.Rows[CompAssinged.Rows.Count - 1].Cells[0].Style.Padding = new Padding(30, 0, 0, 0);
                        }
                    }

                    if (SelectedRows_Idx.Contains(0) == false)
                    {
                        int RootIndex = -1;
                        //check if root already exists and if so add to the bottom of that
                        foreach (DataGridViewRow row in CompAssinged.Rows)
                        {
                            if (row.Cells[0].Value.ToString() == CompViewer.Rows[0].Cells[0].Value.ToString())
                            {
                                RootIndex = row.Index;
                            }
                        }

                        //This means we didn't find the root in the list so we should add it to the end
                        if (RootIndex == -1)
                        {
                            CompAssinged.Rows.Add(CompViewer.Rows[0].Cells[0].Value.ToString());
                            foreach (DataGridViewCell cell in CompViewer.SelectedCells)
                            {
                                CompAssinged.Rows.Add(cell.Value.ToString());
                                CompAssinged.Rows[CompAssinged.Rows.Count - 1].Cells[0].Style.Padding = new Padding(30, 0, 0, 0);
                            }
                        }
                        else //Thism eans we did find it so we don't need to add just append to the end
                        {
                            foreach (DataGridViewCell cell in CompViewer.SelectedCells)
                            {
                                CompAssinged.Rows.Insert(RootIndex + 1, cell.Value.ToString());
                                CompAssinged.Rows[RootIndex + 1].Cells[0].Style.Padding = new Padding(30, 0, 0, 0);
                            }
                        }
                    }
                }


                //Sort the datagrid
                Dictionary<string, List<string>> Order_Dict = GetDictFromDataGrid(CompAssinged);

                AddDictToDataGrid(CompAssinged, Order_Dict);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void RemoveDuplicate(DataGridView grv)
        {
            for (int currentRow = 0; currentRow < grv.Rows.Count - 1; currentRow++)
            {
                DataGridViewRow rowToCompare = grv.Rows[currentRow];

                for (int otherRow = currentRow + 1; otherRow < grv.Rows.Count; otherRow++)
                {
                    DataGridViewRow row = grv.Rows[otherRow];

                    bool duplicateRow = true;

                    for (int cellIndex = 0; cellIndex < row.Cells.Count; cellIndex++)
                    {
                        if (!rowToCompare.Cells[cellIndex].Value.Equals(row.Cells[cellIndex].Value))
                        {
                            duplicateRow = false;
                            break;
                        }
                    }

                    if (duplicateRow)
                    {
                        grv.Rows.Remove(row);
                        otherRow--;
                    }
                }
            }
        }

        private Dictionary<string,List<string>> GetDictFromDataGrid(DataGridView grid)
        {
            Dictionary<string, List<string>> Order_Dict = new Dictionary<string, List<string>>();
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[0].Value.ToString()[0] != '(' && Order_Dict.ContainsKey(row.Cells[0].Value.ToString()) == false)
                {
                    Order_Dict.Add(row.Cells[0].Value.ToString(), new List<string>());
                }
            }

            string CurrentRoot = "";
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[0].Value.ToString()[0] != '(')
                {
                    CurrentRoot = row.Cells[0].Value.ToString();
                }


                if (row.Cells[0].Value.ToString()[0] == '(')
                {
                    Order_Dict[CurrentRoot].Add(row.Cells[0].Value.ToString());
                }
            }
            return Order_Dict;
        }

        private void AddDictToDataGrid(DataGridView grid, Dictionary<string, List<string>> Order_Dict)
        {
            List<string> Keys = new List<string>();
            foreach (var item in Order_Dict)
            {
                Order_Dict[item.Key].Sort();
                Keys.Add(item.Key);
            }
            Keys.Sort();
            grid.Rows.Clear();
            foreach (string key in Keys)
            {
                grid.Rows.Add(key);
                foreach (var value in Order_Dict[key])
                {
                    grid.Rows.Add(value);
                    grid.Rows[grid.Rows.Count - 1].Cells[0].Style.Padding = new Padding(30, 0, 0, 0);
                }
                    
                    
            }
            RemoveDuplicate(grid);
        }

        private void RemoveComp_Click(object sender, EventArgs e)
        {
            try
            {

                //int SelcIndex = CompAssinged.CurrentCell.RowIndex;
                //Find what we need to remove and check if any are roots 
                List<string> CompsToRemove = new List<string>();
                List<string> Roots = new List<string>();
                foreach (DataGridViewCell cell in CompAssinged.SelectedCells)
                {
                    CompsToRemove.Add(cell.Value.ToString());
                    if (cell.Value.ToString()[0] != '(')
                        Roots.Add(cell.Value.ToString());
                }


                Dictionary<string, List<string>> Order_Dict = GetDictFromDataGrid(CompAssinged);
                //If we have roots lets remove them
                foreach (string root in Roots)
                {
                    Order_Dict.Remove(root);
                }

                foreach (var item in Order_Dict)
                {
                    foreach (string comp in CompsToRemove)
                    {
                        if (Order_Dict[item.Key].Contains(comp))
                            Order_Dict[item.Key].Remove(comp);
                    }

                }


                AddDictToDataGrid(CompAssinged, Order_Dict);
                CompAssinged.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void ScanForMissing_Click(object sender, EventArgs e)
        {
            try
            {
                MissingComp.Rows.Clear();
                EvLeaderBoard.Rows.Clear();
                //MissingComp.Rows.Add("1.1.1" + " " + CompDict["1.1.1"].RootComp);
                foreach (var item in CompDict.Keys)
                {
                    MissingComp.Rows.Add(item + " " + CompDict[item].RootComp);
                    int count = 0;
                    foreach (string ChildComp in CompDict[item].ChildComps)
                    {
                        MissingComp.Rows.Add("(" + alphabet[count] + ") " + ChildComp);
                        MissingComp.Rows[MissingComp.Rows.Count - 1].Cells[0].Style.Padding = new Padding(30, 0, 0, 0);
                        count++;
                    }
                }

                int idx1 = 0;
                foreach (DataGridViewRow row1 in MissingComp.Rows)
                {
                    int idx2 = 0;
                    foreach (DataGridViewRow row2 in MissingComp.Rows)
                    {
                        
                        if (row1.Cells[0].Value.ToString() == row2.Cells[0].Value.ToString() && idx1 != idx2)
                        {
                            MissingComp.Rows.Clear();
                            throw new Exception("Error: Non distinct value found, if the competencies are correct please report this error!");
                        }
                        idx2++;
                    }
                    idx1++;
                }

                List<Evidence> EvList = new List<Evidence>();

                DirectoryInfo dinfo = new DirectoryInfo(@"EvidenceDatabase");
                FileInfo[] Files = dinfo.GetFiles("*.bin");
                List<String> CompMatched = new List<string>();
                foreach (FileInfo file in Files)
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read);
                    Evidence Evidence = (Evidence)formatter.Deserialize(stream);
                    EvList.Add(Evidence);


                    foreach (var RootComp in Evidence.CompDict.Keys)
                    {
                        CompMatched.Add(RootComp);
                        foreach (var Comp in Evidence.CompDict[RootComp])
                            CompMatched.Add(Comp);
                    }
                    stream.Close();
                }

                List<int> RemovedIndex = new List<int>();
                foreach (string Str in CompMatched)
                {
                    int count = 0;
                    foreach (DataGridViewRow row in MissingComp.Rows)
                    {
                        if (Str == row.Cells[0].Value.ToString())
                        {
                            RemovedIndex.Add(row.Cells[0].RowIndex);
                        }  
                    }
                    if (count > 1)
                    {
                        MissingComp.Rows.Clear();
                        throw new Exception("Error: Duplicate found in scan, missing competencies list will be incorrect!");
                    }

                }
                RemovedIndex = RemovedIndex.Distinct().ToList();
                RemovedIndex.Sort();
                RemovedIndex.Reverse();
                foreach (int i in RemovedIndex)
                {
                    MissingComp.Rows.RemoveAt(i);
                }

                MappedComp.Text = "Mapped Comptencies Count : " + RemovedIndex.Count.ToString();
                MissingCompStat.Text = "Missing Comptencies Count : " + MissingComp.Rows.Count.ToString();


                foreach (Evidence Ev in EvList)
                {
                    this.EvLeaderBoard.Rows.Add(Ev.Name, Ev.HowManyCompetenciesMapped());
                }
                this.EvLeaderBoard.Sort(this.EvLeaderBoard.Columns["Col2"], ListSortDirection.Descending);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LatexTable_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");
        }

        private void NewEv_Click(object sender, EventArgs e)
        {
            FileName.Clear();
            CompAssinged.Rows.Clear();
            EvName.Clear();
            EvDesc.Clear();
        }
    }
}