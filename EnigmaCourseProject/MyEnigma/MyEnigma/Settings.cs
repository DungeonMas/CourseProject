using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEnigma
{
    public partial class Settings : Form
    {
        private string reflectorString;
        private Enigma enigma;

        public Settings(Enigma enigma)
        {
            InitializeComponent();
            this.enigma = enigma;
            
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (reflector_comboBox.SelectedIndex >= 0)
            {
                // установка значения рефлектору
                reflectorString = reflector_comboBox.SelectedItem.ToString();
                
                switch (reflectorString)
                {
                    case "Reflector А":
                        {
                            enigma.ChangeReflector("EJMZALYXVBWFCRQUONTSPIKHGD");
                            enigma.reflectorLabel.Text = "Рефлектор: A";
                        }
                        break;
                    case "Reflector B":
                        {
                            enigma.ChangeReflector("YRUHQSLDPXNGOKMIEBFZCWVJAT");
                            enigma.reflectorLabel.Text = "Рефлектор: B";
                        }
                        break;
                    case "Reflector C":
                        {
                            enigma.ChangeReflector("FVPJIAOYEDRZXWGCTKUQSBNMHL");
                            enigma.reflectorLabel.Text = "Рефлектор: C";
                        }
                        break;
                }

                // установка значений роторам
                string rotor_1_index = comboBox_Rotor1.SelectedItem.ToString();
                string rotor_2_index = comboBox_Rotor2.SelectedItem.ToString();
                string rotor_3_index = comboBox_Rotor3.SelectedItem.ToString();

                if (rotor_1_index == rotor_2_index || rotor_1_index == rotor_3_index || rotor_2_index == rotor_3_index)
                {
                    MessageBox.Show("Нельзя задавать одинаковые роторы", "Ошибка");
                    return;
                }
                else
                {
                    enigma.ChangeRotors(rotor_1_index, rotor_2_index, rotor_3_index);
                }

                this.Close();
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            string reflectorState = enigma.reflectorLabel.Text;
            comboBox_Rotor1.SelectedItem = enigma.rotor1_lbl.Text;
            comboBox_Rotor2.SelectedItem = enigma.rotor2_lbl.Text;
            comboBox_Rotor3.SelectedItem = enigma.rotor3_lbl.Text;

            switch (reflectorState)
            {
                case "Рефлектор: A":
                    reflector_comboBox.SelectedItem = "Reflector А";
                    break;
                case "Рефлектор: B":
                    reflector_comboBox.SelectedItem = "Reflector B";
                    break;
                case "Рефлектор: C":
                    reflector_comboBox.SelectedItem = "Reflector C";
                    break;
            }
        }

        private void reflector_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int reflectorAlpha = reflector_comboBox.SelectedIndex;

            switch(reflectorAlpha)
            {
                case 0:
                    reflector_textBox.Text = "EJMZALYXVBWFCRQUONTSPIKHGD";
                    break;
                case 1:
                    reflector_textBox.Text = "YRUHQSLDPXNGOKMIEBFZCWVJAT";
                    break;
                case 2:
                    reflector_textBox.Text = "FVPJIAOYEDRZXWGCTKUQSBNMHL";
                    break;
            }
        }

        private void comboBox_Rotor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rotorAlpha = comboBox_Rotor1.SelectedIndex;

            switch (rotorAlpha)
            {
                case 0:
                    rot_1_alpha_textBox.Text = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
                    break;
                case 1:
                    rot_1_alpha_textBox.Text = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
                    break;
                case 2:
                    rot_1_alpha_textBox.Text = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
                    break;
                case 3:
                    rot_1_alpha_textBox.Text = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
                    break;
                case 4:
                    rot_1_alpha_textBox.Text = "VZBRGITYUPSDNHLXAWMJQOFECK";
                    break;
            }
        }

        private void comboBox_Rotor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rotorAlpha = comboBox_Rotor2.SelectedIndex;

            switch (rotorAlpha)
            {
                case 0:
                    rot_2_alpha_textBox.Text = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
                    break;
                case 1:
                    rot_2_alpha_textBox.Text = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
                    break;
                case 2:
                    rot_2_alpha_textBox.Text = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
                    break;
                case 3:
                    rot_2_alpha_textBox.Text = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
                    break;
                case 4:
                    rot_2_alpha_textBox.Text = "VZBRGITYUPSDNHLXAWMJQOFECK";
                    break;
            }
        }

        private void comboBox_Rotor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rotorAlpha = comboBox_Rotor3.SelectedIndex;

            switch (rotorAlpha)
            {
                case 0:
                    rot_3_alpha_textBox.Text = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
                    break;
                case 1:
                    rot_3_alpha_textBox.Text = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
                    break;
                case 2:
                    rot_3_alpha_textBox.Text = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
                    break;
                case 3:
                    rot_3_alpha_textBox.Text = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
                    break;
                case 4:
                    rot_3_alpha_textBox.Text = "VZBRGITYUPSDNHLXAWMJQOFECK";
                    break;
            }
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
