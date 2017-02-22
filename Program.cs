using System;
using System.Windows.Forms;

namespace Habitat.Main
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form form = new Form();

            form.Show();
            form.GameLoop();
        }
    }
}
