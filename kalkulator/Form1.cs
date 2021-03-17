using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Calculator : Form
    {
        Double value = 0;
        string text = "";
        bool op_pressed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, EventArgs e)
        {
            if((txtHasil.Text == "0") || (op_pressed))
            {
                txtHasil.Clear();
            }
            Button button = (Button)sender;
            txtHasil.Text = txtHasil.Text + button.Text;
            op_pressed = false;
        }

        private void btn_delete(object sender, EventArgs e)
        {
            txtHasil.Text = txtHasil.Text.Remove(txtHasil.Text.Length - 1, 1);
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            text = button.Text;
            value = Double.Parse(txtHasil.Text);

            op_pressed = true;
        }

        private void btn_hasil(object sender, EventArgs e)
        {
            switch (text)
            {
                case "+": 
                    txtHasil.Text = (value + Double.Parse(txtHasil.Text)).ToString();
                    break;
                case "-": 
                    txtHasil.Text = (value - Double.Parse(txtHasil.Text)).ToString(); 
                    break;
                case "/": 
                    txtHasil.Text = (value / Double.Parse(txtHasil.Text)).ToString(); 
                    break;
                case "X": 
                    txtHasil.Text = (value * Double.Parse(txtHasil.Text)).ToString(); 
                    break;
                default: break;
            }
            op_pressed = true;
        }

        private void operator_akar(object sender, EventArgs e)
        {
            txtHasil.Text = (Math.Sqrt(Double.Parse(txtHasil.Text))).ToString();
            op_pressed = true;
        }

        private void operator_persen(object sender, EventArgs e)
        {
            txtHasil.Text = (Double.Parse(txtHasil.Text) * 0.01).ToString();
            op_pressed = true;
        }

        private void btn_hapus(object sender, EventArgs e)
        {
            txtHasil.Text = "0";
        }

        private void btn_exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
