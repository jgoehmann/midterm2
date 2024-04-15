using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm2
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
            Application.Run(new Login());
        }
        ///I'll describe unit testing here I suppose.
        ///Unit testing is effectively attempting to test your data for any type of input that may produce an incorrecct response.
        ///This can be easier said than done. Usually when you find an incorrect respone you create an exception clause to the program
        ///so that that special case can be handled.
        ///If unit testing is done properly it should create a program that no matter how weird the user input is can either provide a
        ///correct respone or inform the user if and how their input is incorrect.
        ///Unit testing, if done properly should make it easier to change a program, as hopefully changing one thing doesn't make a
        ///few other things in the program break as well.
    }
}
