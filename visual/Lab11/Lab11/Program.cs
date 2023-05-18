using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Province
    {
        public string pName { get; set; }
        public int nCase { get; set; }
        public int oCase { get; set; }
        public string pRegion { get; set; }
        public Province() { }
        public Province(string name, int newCases, int oldCases, string
       region)
        {
            this.pName = name;
            this.nCase = newCases;
            this.oCase = oldCases;
            this.pRegion = region;
        }
    }

}
