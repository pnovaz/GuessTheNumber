using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumberApp.numberServices;
namespace NumberApp
{
    
    
    public partial class Form1 : Form
    {
        //global values that store the user's guess and actual secret number
        int secretNumber;
        int guess;
        int count; //counts number of button clicks
        numberServices.Service1Client client = new numberServices.Service1Client();

       

    public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int min = int.Parse(textBox1.Text);
            int max = int.Parse(textBox2.Text);

            if (textBox1.Text != "" && textBox2.Text != "") //make sure the user entered two numbers
            {
                secretNumber = client.secretNumber(min, max); //store secret number

                label9.Text = "Secret number generated. Guess the number Below!";
            }

            else
            {
                label9.Text = "Please enter both min and max values to generate secret number.";
            }

          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (label6.Text == "correct!") //if user already played once and guessed correctly erase all contents and start again
            {

                clearAll();

            }

            count++; //counts the click

            if (textBox3.Text != "")
            {
                guess = int.Parse(textBox3.Text); //value that the user guessed

            }
           label6.Text = client.checkNumber(guess, secretNumber); //tells the user if they guessed correctly

           label7.Text = count.ToString(); //update count label when click occurs




        }

        public void clearAll()
        {
            int label7num = int.Parse(label7.Text);
            count = 0;
            textBox1.Text = "";
            textBox2.Text = "";
            label6.Text = "";
            textBox3.Text = "";
            label7num = 0;
        }
     

    private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
