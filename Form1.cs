using System;
using System.Windows.Forms;

namespace _8th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Make Form1 an MDI Parent
            IsMdiContainer = true;

            // Create Menu
            MenuStrip menu = new MenuStrip();

            // File Menu
            ToolStripMenuItem file = new ToolStripMenuItem("File");

            ToolStripMenuItem newWindow =
                new ToolStripMenuItem("New Window");

            ToolStripMenuItem exit =
                new ToolStripMenuItem("Exit");

            // Help Menu
            ToolStripMenuItem help =
                new ToolStripMenuItem("Help");

            ToolStripMenuItem about =
                new ToolStripMenuItem("About");

            // Add menu items
            file.DropDownItems.Add(newWindow);
            file.DropDownItems.Add(exit);

            help.DropDownItems.Add(about);

            menu.Items.Add(file);
            menu.Items.Add(help);

            // Add menu to form
            Controls.Add(menu);
            MainMenuStrip = menu;

            // Events
            newWindow.Click += NewWindow_Click;
            exit.Click += Exit_Click;
            about.Click += About_Click;
        }

        private void NewWindow_Click(object sender, EventArgs e)
        {
            Form child = new Form();

            child.Text = "Child Window";
            child.MdiParent = this;
            child.Width = 400;
            child.Height = 300;

            child.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "MDI Application",
                "About");
        }
    }
}