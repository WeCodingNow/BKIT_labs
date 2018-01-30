using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Lab4
{
    public partial class Form1 : Form
    {
        Stopwatch sw;
        List<string> wordDictionary;


        public Form1()
        {
            InitializeComponent();
            sw = new Stopwatch();
            wordDictionary = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sw.Start();

            String fileContents;
            string delimiters = "., \"()!?\n";

            OpenFileDialog ofd1 = new OpenFileDialog();
            ofd1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            ofd1.ShowDialog();


            if (ofd1.FileName != "")
            {
                fileContents = File.ReadAllText(ofd1.FileName);
                List<string> wordList1 = new List<string>();
                wordList1.AddRange(fileContents.Split(delimiters.ToCharArray()));

                List<string> wordList2 = new List<string>();

                foreach (string i in wordList1)
                {
                    if (!wordList2.Contains(i))
                    {
                        wordList2.Add(i);
                    }
                }
                wordDictionary = wordList2;
            }


            sw.Stop();
            label1.Text = "Время ввода: " + sw.ElapsedMilliseconds + "мс";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sw.Start();

            string wordToFind = textBox1.Text;

            foreach (string i in wordDictionary)
            {
                if (i.Contains(wordToFind))
                {
                    listBox1.BeginUpdate();
                    listBox1.Items.Add(wordToFind);
                    listBox1.EndUpdate();
                    break;
                }
            }

            sw.Stop();
            label2.Text = "Время поиска: " + sw.ElapsedMilliseconds + "мс";
        }
    }
}
