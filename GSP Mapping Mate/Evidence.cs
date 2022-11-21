using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GSP_Mapping_Mate
{
    [Serializable]
    public class Evidence
    {
        public string Name;
        public string Description;
        public string FileName;
        public Dictionary<string, List<string>> CompDict = new Dictionary<string, List<string>>();
        public Evidence(string _Name, string _Description)
        {
            Name = _Name;
            Description = _Description;
        }

        public void SaveEvidence()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"EvidenceDatabase/"+this.Name.Replace(" ","_")+".bin", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, this);
            stream.Close();
        }

        public int HowManyCompetenciesMapped()
        {
            int count = 0;
            foreach (KeyValuePair<string, List<string>> entry in CompDict)
            {
                count++;
                count += entry.Value.Count;
            }

            return count;
        }
    }
}
