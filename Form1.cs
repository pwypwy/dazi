using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        string[] line;
        int k = 0;
        string ms="1";
        string fname="m";
        Random r = new Random();
        public void Read(string path)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                //Console.WriteLine(line.ToString());
              //  label1.Text = line;
            }
        }
        public Form1()
        {
            InitializeComponent();
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            int i=s1.Length - 1;
            int j = s2.Length - 1;
          

            if (i<= j)
            {
               // MessageBox.Show("" + i + "," + j);
                  if (s1[i] != s2[i])
                {
                    textBox1.Select(s1.Length - 1, 1);

                }
               
            }
            else
            {

                k++;
                if (k <= line.Length - 1)
                {
                    textBox1.Text = " ";
                    if (ms == "1")
                    {
                        textBox2.Text = line[k];
                    }
                    else
                    {
                        k = r.Next(0, line.Length);
                        string[] s;
                        s = line[k].Split('-');
                        while(!s[0].Contains(textBox4.Text))
                        {
                            k = r.Next(0, line.Length);
                            s = line[k].Split('-');
                        }
                        textBox2.Text = s[1] + s[0] + s[2];
                        label1.Text = s[4].Replace('！', ' ');
                    }
                }
                else
                {
                    k = 0;
                }
               
            }
          
            
  

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ms = "1";
            fname = textBox3.Text;
            string path = @"c:\" + fname + ".txt";
            //Read(path);


            if (File.Exists(path))
            {
                line = File.ReadAllLines(path, Encoding.Default);

                if (ms == "1")
                {
                    textBox2.Text = line[0];
                }
                else
                {
                    k = r.Next(0, line.Length);
                    string[] s;
                    s = line[0].Split('-');

                    textBox2.Text = s[1] + s[0] + s[2] ;
                    label1.Text = s[4].Replace('！', ' ');
                }

            }
            else
            {
                textBox2.Text = "不存在！";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ms = "2";
            fname = textBox3.Text;
            string path = @"c:\" + fname + ".txt";
            //Read(path);


            if (File.Exists(path))
            {
                line = File.ReadAllLines(path, Encoding.Default);

                if (ms == "1")
                {
                    textBox2.Text = line[0];
                }
                else
                {
                    k = r.Next(0, line.Length);
                    string[] s;
                    s = line[0].Split('-');
                    if (s.Length >= 8)
                    {
                        textBox2.Text = s[1] + s[0] + s[2] ;
                        label1.Text = s[4].Replace('！', ' ');
                    }
                    else
                    {
                        textBox2.Text = "错误";
                    }

                   
                   
                    
                }

            }
            else
            {
                textBox2.Text = "不存在！";
            }
        }

     
    }
}
