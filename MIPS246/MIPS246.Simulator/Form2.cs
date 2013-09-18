﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MipsSimulator.Tools;
using MIPS246.Core.ResultComparer;
using System.IO;

namespace MipsSimulator
{
    public partial class Form2 : Form
    {
        public bool isOpen = false;
        public Form2()
        {
            isOpen = false;
            InitializeComponent();
            textBox1.Text = Form1.getOutput();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                string source = getSource();
                string output = getOutput();

                int count1 = File.ReadAllLines(source).Length;
                int count2 = File.ReadAllLines(output).Length;
                if (count2 > count1)
                {
                    string[] output2 = File.ReadAllLines(output);

                    FileInfo fInfo = new FileInfo(output);
                    if (fInfo.Exists)
                    {
                        fInfo.Delete();
                    }
                    FileStream fs = fInfo.OpenWrite();
                    StreamWriter w = new StreamWriter(fs);
                    if (count1 > 0)
                    {
                        for (int i = 0; i < count1; i++)
                        {
                            w.WriteLine(output2[i]);
                        }
                    }

                    w.Flush();
                    w.Close();
                    w.Dispose();
                }
                if (count1 > count2)
                {
                    string[] output1 = File.ReadAllLines(source);

                    FileInfo fInfo = new FileInfo(source);
                    if (fInfo.Exists)
                    {
                        fInfo.Delete();
                    }
                    FileStream fs = fInfo.OpenWrite();
                    StreamWriter w = new StreamWriter(fs);
                    if (count2 > 0)
                    {
                        for (int i = 0; i < count2; i++)
                        {
                            w.WriteLine(output1[i]);
                        }
                    }

                    w.Flush();
                    w.Close();
                    w.Dispose();
                }
                string result = ResultComparer.Compare(source, output);
                this.richTextBox1.Text = result;
                FileControl.Save(result);
            }
            else
            {
                this.richTextBox1.Text = "请输入正确地址！";
                
            }
        }
        public string getSource()
        {
            return textBox1.Text;
        }
        public string getOutput()
        {
            return textBox2.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "文本文件(*.txt)|*.txt";
            openFD.FilterIndex = 1;
            openFD.AddExtension = true;
            openFD.RestoreDirectory = true;

            if (openFD.ShowDialog() == DialogResult.OK)
            {
                string fName = openFD.FileName;
                this.textBox1.Text = fName;
            }
            else
            {
                this.textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "文本文件(*.txt)|*.txt";
            openFD.FilterIndex = 1;
            openFD.AddExtension = true;
            openFD.RestoreDirectory = true;

            if (openFD.ShowDialog() == DialogResult.OK)
            {
                string fName = openFD.FileName;
                this.textBox2.Text = fName;
            }
            else
            {
                this.textBox2.Text = "";
            }
        }

    }
}
