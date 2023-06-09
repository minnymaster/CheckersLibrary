﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckersLibrary;

namespace FormsInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.FormClosed += GameForm_FormClosed;

            // Отображаем форму игры
            gameForm.Show();
            this.Hide();
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Отображаем форму главного меню после закрытия формы игры
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            rules.FormClosed += Rules_FormClosed;

            // Отображаем форму игры
            rules.Show();
            this.Hide();
        }

        private void Rules_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Отображаем форму главного меню после закрытия формы игры
            this.Show();
        }
    }
}
