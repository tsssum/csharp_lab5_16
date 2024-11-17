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

//Дан текстовый файл, слова содержащий слова, разделенные одним или несколькими пробелами.
//Создать новый файл, содержащий строки с наибольшим числом различных слов.
namespace lab5_16
{
    public partial class Form1 : Form
    {
        private string fileName = "";
        string projectPath = AppDomain.CurrentDomain.BaseDirectory;
        public Form1()
        {
            InitializeComponent();
        }

        private void newStripMenuItem1_Click(object sender, EventArgs e)
        {
            string randomFileName = $"{Guid.NewGuid()}.txt";
            fileName = Path.Combine(projectPath, randomFileName);

            textBox1.Text = fileName;
            using (StreamWriter file_output = new StreamWriter(fileName))
            {
                file_output.Write("");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openStripMenuItem2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                using (StreamReader file_input = new StreamReader(fileName))
                    textBox1.Text = file_input.ReadToEnd();
            }
        }

        private void saveStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                saveAsStripMenuItem1_Click(sender, e);
            else
            {
                using (StreamWriter file_output = new StreamWriter(fileName))
                {
                    file_output.WriteLine(textBox1.Text);
                }
            }
        }

        private void saveAsStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
                textBox2.Text = fileName;
                using (StreamWriter file_output = new StreamWriter(saveFileDialog1.FileName))
                    file_output.WriteLine(textBox1.Text);
            }
        }

        private void taskStripMenuItem1_Click(object sender, EventArgs e)
        {
            string[] line = textBox1.Lines, result = new string[line.Length];
            int count = 0, res_size = 0, i = 0;

            while (i < line.Length)
            {
                // разделка строки на слова
                string[] words = line[i].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                int count_curr = CountUniqueWords(words);
                if (count_curr > count)
                {
                    count = count_curr;
                    res_size = 0; 
                    result[res_size] = line[i]; 
                    res_size++; 
                }
                else if (count_curr == count)
                {
                    result[res_size] = line[i]; 
                    res_size++; 
                }

                i++;
            }

            if(res_size < result.Length)
            {
                string[] newResult = new string[res_size];
                for (int j = 0; j < res_size; j++)
                {
                    newResult[j] = result[j];
                }
                result = newResult;
            }


            textBox2.Lines = result;
        }

        private int CountUniqueWords(string[] words)
        {
            string[] unique_words = new string[words.Length];
            int count = 0;
            int i= 0;

            while (i < words.Length)
            {
                string word = words[i];

                bool exists = false;

                int j = 0;
                while (j < count)
                {
                    if (unique_words[j] == word)
                    {
                        exists = true;
                        break;
                    }
                    j++;
                }

                if (!exists)
                {
                    unique_words[count] = word;
                    count++;
                }

                i++; 
            }

            return count;
        }
        private void clearStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }


        private void exitStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}