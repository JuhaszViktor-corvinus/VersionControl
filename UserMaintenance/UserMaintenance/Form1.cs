﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMaintenance
{
   
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = Resource1.FullName; // label1
            //lblFirstName.Text = Resource1.FirstName; // label2
            btnAdd.Text = Resource1.Add; // button1

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
            var u = new User()
            {
                LastName = txtLastName.Text,
                FirstName = txtLastName.Text
            };
            users.Add(u);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog mentes = new SaveFileDialog();
            if (mentes.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(mentes.FileName);
                for (int i = 0; i < listUsers.Items.Count; i++)
                {
                    writer.WriteLine((string)listUsers.Items[i]);
                }
                writer.Close();
            }
            mentes.Dispose();
        }

        private void Torles_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedIndex == -1)
            {
                MessageBox.Show("Válaszd ki a törölni kívánt elemet");
            }
            if (listUsers.SelectedIndex > -1)
            {
                listUsers.Items.RemoveAt(listUsers.SelectedIndex);
            }
        }
    }
}
