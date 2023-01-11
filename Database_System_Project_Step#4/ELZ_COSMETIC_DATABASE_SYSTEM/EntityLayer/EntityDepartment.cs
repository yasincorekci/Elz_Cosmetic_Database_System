using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityDepartment
    {
        private int Dno;
        private string DName;
        private string ManagerSsn;
        private int NoOfWorkers;

        public int Dno1 { get => Dno; set => Dno = value; }
        public string DName1 { get => DName; set => DName = value; }
        public string ManagerSsn1 { get => ManagerSsn; set => ManagerSsn = value; }
        public int NoOfWorkers1 { get => NoOfWorkers; set => NoOfWorkers = value; }
    }
}
