using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Calculator_Better_Design
{
    public partial class Calculator : Form
    {
        Logic.Calculator calc;
        public Calculator()
        {
            InitializeComponent();
            calc = new Logic.Calculator();
            Lhs_lbl.Text = "";
            Op_lbl.Text = "";
            Rhs_lbl.Text = "";
            Ans_lbl.Text = "";
        }

        private void number1_Click(object sender, EventArgs e)
        {
            textBox1.Text += number_1.Text;
            calc.Number_entered(double.Parse(textBox1.Text));
        }

        private void number_2_Click(object sender, EventArgs e)
        {
            textBox1.Text += number_2.Text;
            calc.Number_entered(double.Parse(textBox1.Text));
        }


        private void number3_Click(object sender, EventArgs e)
        {
            textBox1.Text += number3.Text;
            calc.Number_entered(double.Parse(textBox1.Text));
        }

        private void number4_Click(object sender, EventArgs e)
        {
            textBox1.Text += number4.Text;
            calc.Number_entered(double.Parse(textBox1.Text));
        }

        private void number5_Click(object sender, EventArgs e)
        {
            textBox1.Text += number5.Text;
            calc.Number_entered(double.Parse(textBox1.Text));
        }

        private void number6_Click(object sender, EventArgs e)
        {
            textBox1.Text += number6.Text;
            calc.Number_entered(double.Parse(textBox1.Text));
        }

        private void number7_Click(object sender, EventArgs e)
        {
            textBox1.Text += number7.Text;
            calc.Number_entered(double.Parse(textBox1.Text));
        }

        private void number8_Click(object sender, EventArgs e)
        {
            textBox1.Text += number8.Text;
            calc.Number_entered(double.Parse(textBox1.Text));
        }

        private void number9_Click(object sender, EventArgs e)
        {
            textBox1.Text += number9.Text;
            calc.Number_entered(double.Parse(textBox1.Text));
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            Op_lbl.Text = Add_btn.Text;
            Lhs_lbl.Text = textBox1.Text;
            Tape_txtBox.AppendText(Lhs_lbl.Text + "\n");
            textBox1.Clear();
            calc.Addition_entered();
        }

        private void Subtract_btn_Click(object sender, EventArgs e)
        {
            Op_lbl.Text = Subtract_btn.Text;
            Lhs_lbl.Text = textBox1.Text;
            Tape_txtBox.AppendText(Lhs_lbl.Text + "\n");
            textBox1.Clear();
            calc.Subtraction_entered();
        }

        private void Equals_btn_Click(object sender, EventArgs e)
        {
            Rhs_lbl.Text = textBox1.Text;
            textBox1.Text = calc.Equals().ToString();
            Tape_txtBox.AppendText(Rhs_lbl.Text + "\n");
            Ans_lbl.Text = textBox1.Text;
        }

        private void Multiply_btn_Click(object sender, EventArgs e)
        {
            Op_lbl.Text = Multiply_btn.Text;
            Lhs_lbl.Text = textBox1.Text;
            Tape_txtBox.AppendText(Lhs_lbl.Text + "\n");
            textBox1.Clear();
            calc.Multiplication_entered();
        }

        private void Division_btn_Click(object sender, EventArgs e)
        {
            Op_lbl.Text = Division_btn.Text;
            Lhs_lbl.Text = textBox1.Text;
            Tape_txtBox.AppendText(Lhs_lbl.Text + "\n");
            textBox1.Clear();
            calc.Division_entered();
        }

        private void Reciprocal_btn_Click(object sender, EventArgs e)
        {
            Op_lbl.Text = Reciprocal_btn.Text;
            Lhs_lbl.Text = textBox1.Text;
            Tape_txtBox.AppendText(Lhs_lbl.Text + "\n");
            textBox1.Clear();
            calc.Reciprocal_entered();
        }

        private void Sqroot_btn_Click(object sender, EventArgs e)
        {
            Op_lbl.Text = Sqroot_btn.Text;
            Lhs_lbl.Text = textBox1.Text;
            Tape_txtBox.AppendText(Lhs_lbl.Text + "\n");
            textBox1.Clear();
            calc.Square_root_entered();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Lhs_lbl.Text = "";
            Rhs_lbl.Text = "";
            Op_lbl.Text = "";
            Ans_lbl.Text = "";
            textBox1.Clear();
        }

        private void Pos_Neg_btn_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBox1.Text);
            textBox1.Text = (temp - (temp * 2)).ToString();
            calc.Number_entered(double.Parse(textBox1.Text));
        }

        private void number0_Click(object sender, EventArgs e)
        {
            textBox1.Text += number0.Text;
            calc.Number_entered(double.Parse(textBox1.Text));
        }

        private void Decimal_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text += Decimal_btn.Text;
            calc.Number_entered(double.Parse(textBox1.Text));
        }
    }
}
