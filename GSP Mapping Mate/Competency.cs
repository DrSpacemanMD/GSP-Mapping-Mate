using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSP_Mapping_Mate
{

    internal class Competency
    {
        public string id;
        public string RootComp;
        public List<string> ChildComps;
        public Competency(string _id, string _RootComp, List<string> _ChildComps)
        {
            id = _id;
            RootComp = _RootComp;
            ChildComps = _ChildComps;
        }
    }
}
