﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace targil6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a;

        private void Form1_Load(object sender, EventArgs e)
        {
            const int Max = 10;
            int[] a = new int[Max];

            a = new int[10];
            InitializeArrays();
            PrintArray();
        }
        private  void PrintArray()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        private void InitializeArrays()
        {
            Random r = new Random();
            a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(101);

            }

        }
    }
}
