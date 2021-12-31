using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginDesign
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool instanceCountOne = false;
            //Used to prevent multiple applications from running at the same time
            using (Mutex mtex = new Mutex(true, "LoginDesign", out instanceCountOne))
            {

                if (instanceCountOne)
                {



          

                  Application.EnableVisualStyles();
                  Application.SetCompatibleTextRenderingDefault(false);
                  Application.Run(new Login());



                }
                else
                {
                    MessageBox.Show("Another Process of LoginDesign Is Already Running");
                }



            }







        }
       
        
    }
}
