using System.Drawing;
using System.Windows.Forms;

namespace Habitat.Rendering
{
    public class RenderMethods
    {
        public void RenderDateTimeBox(Control control)
        {
            var box = new RichTextBox();
            
            box.ReadOnly = true;
            box.BorderStyle = BorderStyle.None;
            box.Width = 200;
            box.Height = 30;
            box.Location = new Point(control.Width / 2 - box.Width / 2, control.Height / 2 - box.Height);
            box.ForeColor = System.Drawing.Color.LightGreen;
            box.BackColor = System.Drawing.Color.Black;
            box.SelectionAlignment = HorizontalAlignment.Center;
            box.Text = System.DateTime.Now.ToString();

            control.Controls.Add(box);
            box.BringToFront();
        }
    }
}
