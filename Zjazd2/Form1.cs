using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zjazd2
{
    public partial class Form1 : Form
    {
        Zadanie_1 zad1 = new Zadanie_1();
        Zadanie_2 zad2 = new Zadanie_2();
        Zadanie_3 zad3 = new Zadanie_3();
        Zadanie_4 zad4 = new Zadanie_4();
        Zadanie_5 zad5 = new Zadanie_5();

        public Form1()
        {
            InitializeComponent();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "1")
            {
                textBox1.Visible = true;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox5.Text = "Zaprojektuj Kryptosystem dla szyfru “simple substitution” bazującego na tabeli wygenerowanej przez słowo kluczowe będące twoim nazwiskiem.";
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            }
            else if (comboBox1.SelectedItem.ToString() == "2")
            {
                textBox1.Visible = false;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox5.Text = "Zaprojektuj kryptosystem bazujący na równaniu: c = (a * k1 + k0)mod n";
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            }
            else if (comboBox1.SelectedItem.ToString() == "3")
            {
                textBox1.Visible = true;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox5.Text = "Zaprojektuj kryptosystem bazujący na tablicy Vigenere.";
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            }
            else if (comboBox1.SelectedItem.ToString() == "4")
            {
                textBox1.Visible = true;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox5.Text = "Zaprojektuj kryptosystem bazujący na algorytmie “Playfair cipher” (jako słowo kluczowe należy wziąć swoje nazwisko).";
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            }
            else if (comboBox1.SelectedItem.ToString() == "5")
            {
                textBox1.Visible = true;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox5.Text = "Zaprojektuj kryptosystem bazujący na własnym pomyśle ”simple substitution”.";
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox6.Text = textBox7.Text = "";
        }                   //clear

        private void button3_Click(object sender, EventArgs e)                      //set default
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "1")
                {
                    textBox2.Text = "HEREISASECRETMESSAGEENCIPHEREDBYSUBSTITUTION";
                    textBox1.Text = "MACIEJCZUK";
                }
                else if (comboBox1.SelectedItem.ToString() == "2")
                {
                    textBox2.Text = "HEREISASECRETMESSAGEENCIPHEREDBYSUBSTITUTION";
                    textBox6.Text = "3";
                    textBox7.Text = "7";

                }
                else if (comboBox1.SelectedItem.ToString() == "3")
                {
                    textBox2.Text = "CRYPTOGRAPHY";
                    textBox1.Text = "BREAK";
                }
                else if (comboBox1.SelectedItem.ToString() == "4")
                {
                    textBox2.Text = "HEREISASECRETMESSAGEENCIPHEREDBYSUBSTITUTION";
                    textBox1.Text = "MACIEJCZUK";
                }
                else if (comboBox1.SelectedItem.ToString() == "5")
                {
                    textBox2.Text = "HEREISASECRETMESSAGEENCIPHEREDBYSUBSTITUTION";
                    textBox1.Text = "MACIEJCZUK";
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Wybierz zadanie");
            }
        }

        private void button1_Click(object sender, EventArgs e)                      //encipher          
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "1")
                {
                    textBox3.Text = zad1.encipher(textBox1.Text, textBox2.Text);
                }
                else if (comboBox1.SelectedItem.ToString() == "2")
                {
                    textBox3.Text = zad2.encipher(textBox6.Text, textBox7.Text, textBox2.Text);
                }
                else if (comboBox1.SelectedItem.ToString() == "3")
                {
                    textBox3.Text = zad3.encipher(textBox1.Text, textBox2.Text);
                }
                else if (comboBox1.SelectedItem.ToString() == "4")
                {
                    //textBox3.Text = zad4.encipher(textBox1.Text, textBox2.Text);
                }
                else if (comboBox1.SelectedItem.ToString() == "5")
                {
                    //textBox3.Text = zad5.encipher(textBox1.Text, textBox2.Text);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Wybierz zadanie");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Wpisz dane");
            }


        }

        private void button2_Click(object sender, EventArgs e)                      //decipher
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "1")
                {
                    textBox4.Text = zad1.decipher(textBox1.Text, textBox3.Text);
                }
                else if (comboBox1.SelectedItem.ToString() == "2")
                {

                }
                else if (comboBox1.SelectedItem.ToString() == "3")
                {
                    textBox4.Text = zad3.decipher(textBox1.Text, textBox3.Text);
                }
                else if (comboBox1.SelectedItem.ToString() == "4")
                {

                }
                else if (comboBox1.SelectedItem.ToString() == "5")
                {

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Wybierz zadanie");
            }


        }
        }
 }

