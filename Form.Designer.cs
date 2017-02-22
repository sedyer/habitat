using Habitat.Objects;
using Habitat.Rendering;
using System.Windows.Forms;

namespace Habitat.Main
{
    partial class Form
    {

        Timer timer = new Timer();
        SolarSystem currentSystem = null;
        RenderMethods renderer = new RenderMethods();

        private void RenderScene()
        {
            Controls.Clear();
            renderer.RenderDateTimeBox(this);

        }

        private void GameLogic()
        {
            if (currentSystem == null)
            {
                currentSystem = new SolarSystem();

                currentSystem.CelestialObjects.Add(
                    new CelestialObject { Mass = 1, Radius = 1, PrimaryBody = null }
                    );
            }
        }

        public void GameLoop()
        {
            while (this.Created)
            {
                timer.Reset();
                GameLogic();
                RenderScene();
                Application.DoEvents();
                while (timer.GetTicks() < 50) ;
            }
        }

        #region Generated code

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.SuspendLayout();

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1428, 789);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Habitat";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

