using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskAndThreadApp.Model;

namespace TaskAndThreadApp
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            this.Height = 200;
            this.Width = 300;
            this.Shown += ButtonsGenerator;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
        public void ButtonsGenerator(object sender, EventArgs e)
        {
            var HelloButton = ButtonCreation("Hello", 9, 9);
            HelloButton.Click += new EventHandler((object s, EventArgs eargs) => MessageBox.Show("Hello"));
            this.Controls.Add(HelloButton);

            var syncButton = ButtonCreation("Sync", 80, 11);
            syncButton.Click += new EventHandler(SyncButtonClick);
            this.Controls.Add(syncButton);

            var threadButton = ButtonCreation("Thread", 150, 12);
            threadButton.Click += new EventHandler(ThreadButtonClick);
            this.Controls.Add(threadButton);

            var taskButton = ButtonCreation("Task", 10, 60);
            taskButton.Click += new EventHandler(TaskButtonClick);
            this.Controls.Add(taskButton);

            var asyncButton = ButtonCreation("Async", 80, 60);
            asyncButton.Click += new EventHandler(AsyncButtonClick);
            this.Controls.Add(asyncButton);

            var asyncResultButton = ButtonCreation("AsyncResult", 150, 60);
            asyncResultButton.Click += new EventHandler(AsyncResultButtonClick);
            this.Controls.Add(asyncResultButton);

        }
        public void SyncButtonClick(object s, EventArgs e)
        {
            new TimePrinter().PrintDelay();
        }

        public void ThreadButtonClick(object s, EventArgs e)
        {
            new Thread(new TimePrinter().PrintDelay).Start();
        }

        public void TaskButtonClick(object s, EventArgs e)
        {
            Task.Run(new TimePrinter().PrintDelay);
        }
        public void AsyncButtonClick(object s, EventArgs e)
        {
            var result = new TimePrinter().PrintAsync();
            MessageBox.Show(result.ToString());
        }
        public async void AsyncResultButtonClick(object s, EventArgs e)
        {
            var result = await new TimePrinter().PrintAsync();
            MessageBox.Show(result.ToString());
        }
        public Button ButtonCreation(string name, int x, int y)
        {
            Button button = new Button();
            button.Text = name;
            button.Size = new Size(50, 30);
            button.Location = new Point(x, y);
            return button;
        }
    }
}
