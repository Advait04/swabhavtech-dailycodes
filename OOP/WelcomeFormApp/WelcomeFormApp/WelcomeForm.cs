using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelcomeFormApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {

            InitializeComponent();
            this.Text = "Advait";
            

            this.Shown += AddLabel;
            this.Shown += CreateButton;


        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }



        public void AddLabel(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Welcome To Form Application";
            label.Width = 220;
            label.Height = 40;
            label.Font = new Font("Arial", 14);

            this.Controls.Add(label);
        }

        public void CreateButton(object sender, EventArgs e)
        {
            Button clickButton = new Button();
            clickButton.Text = "Click Me";
            clickButton.Font = new Font("Arial", 14);
            clickButton.Click += new EventHandler(this.GodListener);
            clickButton.Click += new EventHandler(this.DevilListener);

            clickButton.Size = new Size(140, 40);
            clickButton.Location = new Point(30, 30);
            clickButton.BackColor = Color.Aquamarine;
            this.Controls.Add(clickButton);
        }

        public void GodListener(object sender,EventArgs e)
        {
            Console.WriteLine("\n God Is Listening");
        }

        public void DevilListener(object sender, EventArgs e)
        {
            Console.WriteLine("\n Devil Is Listening");
        }
    }
}
