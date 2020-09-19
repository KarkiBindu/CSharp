using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using practice;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Options.SelectedIndex = 0;    
        }     

        private void Options_SelectedIndexChanged(object sender, EventArgs e)
        {
            Information.Text = string.Empty;
            Result.Text = string.Empty;
            if (Options.SelectedItem == "Irresponsive Form Example")
            {
                this.Information.Text = "Irresponsive Form Example; This form cannot be dragged or resized once button is clicked, until the sum is completed";
            }
            if (Options.SelectedItem == "Responsive Form Example 1")
            {
                this.Information.Text = "Responsive Form Example using async await; This form cann be dragged or resized once button is clicked, regardless the sum is completed or not";
            }
            if (Options.SelectedItem == "Responsive Form Example 2")
            {
                this.Information.Text = "Responsive Form Example using thread; This form cann be dragged or resized once button is clicked, regardless the sum is completed or not";
            }

        }

        private async void Irresponsive_Click(object sender, EventArgs e)
        { 
            if (Options.SelectedItem == "Irresponsive Form Example")
            {            
                Functions.AddThreeMillion();
                Result.Text = "Function Completed. The Sum is " + Functions.Sum + " now the form can be dragged, resized.";
            }
            if (Options.SelectedItem == "Responsive Form Example 1")
            {
                Task<int> task = new Task<int>(Functions.AddThreeMillion);
                task.Start();
                Button.Enabled = false;
                Result.Text = "Processing, Please wait......";
                int Sum = await task;
                Result.Text = "Function Completed. The Sum is " + Sum;
                Button.Enabled = true;
            }
            if (Options.SelectedItem == "Responsive Form Example 2")
            {
                int Sum = 0;
                Button.Enabled = false;
                Thread thread = new Thread(() => 
                {
                    Sum = Functions.AddThreeMillion();
                    Action action = new Action
                   (
                        () =>
                        {
                            Result.Text = "Function Completed. The Sum is " + Sum;
                            Button.Enabled = true;
                        }

                   );
                        this.BeginInvoke(action);
                    
                });
                thread.Start();               
                Result.Text = "Processing, Please wait......";                
               
            }


        }

    }
}
