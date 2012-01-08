using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace SparseMatrices
{
    /// <remarks>
    /// Main application class (entry point)
    /// </remarks>
    public static class Launch
    {
        /// <summary>
        /// The main entry point for the application.
        /// Initializes main window.<br/>
        /// Activates DigitalRune engine (The license key is valid until 2012-12-05) (official license key (for students) is used)
        /// </summary>
        [STAThread]
        public static void Main()
        {
            //Activate digitalRune engine
            DigitalRune.Licensing.AddSerialNumber("tgCcAZC8VAM0s8wB0JPijs7SzQEoACNLb25zdGFudGluIEthc3Rhbm92IzEjMSNOb25Db21tZXJjaWFsDQpAg7LDkM1RVAQDAfwPE/dwtOuvB09Rs3YGx6dK9iVTav9mx0wODFY4HeAURfEUqVh2Qmvxgbe494f6fjoh");

            //Initialize GUI
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI.MainWindow());
        }
    }
}
