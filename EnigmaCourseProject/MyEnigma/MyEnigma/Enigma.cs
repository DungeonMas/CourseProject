using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEnigma
{
    public partial class Enigma : Form
    {
        public Rotor rotor_3, rotor_2, rotor_1, reflector;

        public Rotor reflectorA = new Rotor("EJMZALYXVBWFCRQUONTSPIKHGD", null, '\0');

        char[] validSymbols = { ' ', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', ',', '?', '!', '_', '-', ':', ';'};

        public Enigma()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void input_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

            switch(e.KeyChar.ToString())
            {
                case ",":
                    output_textBox.Text += ",";
                    break;
                case ".":
                    output_textBox.Text += ".";
                    break;
                case "!":
                    output_textBox.Text += "!";
                    break;
                case "?":
                    output_textBox.Text += "?";
                    break;
                case ":":
                    output_textBox.Text += ":";
                    break;
                case ";":
                    output_textBox.Text += ";";
                    break;
                case "-":
                    output_textBox.Text += "-";
                    break;
            }
        }

        private void openFile_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;

            string fileText = File.ReadAllText(filename);
            if (TextIsValid(fileText))
            {
                input_textBox.Text = fileText.ToUpper();
                output_textBox.Clear();

                EncryprionCycle(fileText.ToUpper());
            }
            else
                MessageBox.Show("Файл пуст, либо имеет недопустимые символы","Ошибка");
            
        }

        private bool TextIsValid(string userText)
        {
            return !string.IsNullOrEmpty(userText) && !Regex.IsMatch(userText, @"[^a-zA-Z:,.!?;\p{Pd}\d\s_]");
        }


    private void saveInFile_Button_Click(object sender, EventArgs e)
        {
            if (output_textBox.Text != "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;

                string filename = saveFileDialog1.FileName;

                File.WriteAllText(filename, output_textBox.Text);

                MessageBox.Show("Файл успешно сохранен");
            }
            else
                MessageBox.Show("Нельзя сохранить пустое значение", "Ошибка");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reflector = new Rotor("YRUHQSLDPXNGOKMIEBFZCWVJAT", null, '\0');
            rotor_3 = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", rot_3_lbl, 'V');
            rotor_2 = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", rot_2_lbl, 'E');
            rotor_1 = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", rot_1_lbl, 'Q');

            SetValuesElements();

            reflectorLabel.Text = "Рефлектор: B";
        }

        private void SetValuesElements()
        {
            rotor_3.SetNextRotor(rotor_2);
            rotor_2.SetNextRotor(rotor_1);
            rotor_1.SetNextRotor(reflector);
            rotor_2.SetPreviousRotor(rotor_3);
            rotor_1.SetPreviousRotor(rotor_2);
            reflector.SetPreviousRotor(rotor_1);
        }

        private void input_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Стираем весь текст
            if (input_textBox.Text.Length == 0)
                output_textBox.Clear();

            // Стирание текста поэлементно
            if (e.KeyCode == Keys.Back && input_textBox.Text.Length > 0 && output_textBox.Text.Length > 0)
            {
                output_textBox.Text = output_textBox.Text.Substring(0, output_textBox.Text.Length - 1);

                if(input_textBox.Text.Last() != ' ')
                    rotor_3.SwitchBack();
                return;
            }

            // Набор слов из допустимых символов
            if (((e.KeyValue >= 65 && e.KeyValue <= 90) && !e.Control) || e.KeyCode == Keys.Space)
            {
                if (e.KeyCode != Keys.Space)
                    StartEncryption((char)e.KeyValue);
                else
                    output_textBox.Text += " ";
                
            }

            // Вставка текста
            if (e.Control)
            {
                if (TextIsValid(Clipboard.GetText()))
                {                   
                    input_textBox.Text += Clipboard.GetText().ToUpper();
                    EncryprionCycle(input_textBox.Text);
                }
                else
                    MessageBox.Show("Текст имеет недопустимые символы", "Ошибка");
            }
        }

        private void EncryprionCycle(string textCipre)
        {
            for (int i = 0; i < input_textBox.Text.Length; i++)
            {
                if (Array.IndexOf<char>(validSymbols, textCipre[i]) != -1)
                    output_textBox.Text += textCipre[i];
                else
                    StartEncryption(textCipre.ToCharArray()[i]);
            }
        }

        private void StartEncryption(char userText)
        {
            rotor_3.Switch();
            rotor_3.PutDataIn(userText);
            output_textBox.Text += "" + rotor_3.GetDataOut();
        }

        private void clearAll_Button_Click(object sender, EventArgs e)
        {
            input_textBox.Clear();
            output_textBox.Clear();
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(this);
            settings.ShowDialog();
        }

        public void ChangeReflector(string reflectorAlphabet)
        {
            reflector = new Rotor(reflectorAlphabet, null, '\0');          
            reflector.SetPreviousRotor(rotor_1);
            rotor_1.SetNextRotor(reflector);

        }

        public void ChangeRotors(string rot_value1, string rot_value2, string rot_value3)
        {
            rotor1_lbl.Text = rot_value1;
            rotor2_lbl.Text = rot_value2;
            rotor3_lbl.Text = rot_value3;

            switch(rotor1_lbl.Text)
            {
                case "I":
                    {
                        rotor_1 = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", rot_1_lbl, 'Q');                      
                    }
                    break;
                case "II":
                    {
                        rotor_1 = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", rot_1_lbl, 'Q');
                    }
                    break;
                case "III":
                    {
                        rotor_1 = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", rot_1_lbl, 'Q');
                    }
                    break;
                case "IV":
                    {
                        rotor_1 = new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", rot_1_lbl, 'Q');
                    }
                    break;
                case "V":
                    {
                        rotor_1 = new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", rot_1_lbl, 'Q');
                    }
                    break;
            }

            switch(rotor2_lbl.Text)
            {
                case "I":
                    {
                        rotor_2 = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", rot_2_lbl, 'E');
                    }
                    break;
                case "II":
                    {
                        rotor_2 = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", rot_2_lbl, 'E');
                    }
                    break;
                case "III":
                    {
                        rotor_2 = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", rot_2_lbl, 'E');
                    }
                    break;
                case "IV":
                    {
                        rotor_2 = new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", rot_2_lbl, 'E');
                    }
                    break;
                case "V":
                    {
                        rotor_2 = new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", rot_2_lbl, 'E');
                    }
                    break;
            }

            switch(rotor3_lbl.Text)
            {
                case "I":
                    {
                        rotor_3 = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", rot_3_lbl, 'V');
                    }
                    break;
                case "II":
                    {
                        rotor_3 = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", rot_3_lbl, 'V');
                    }
                    break;
                case "III":
                    {
                        rotor_3 = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", rot_3_lbl, 'V');
                    }
                    break;
                case "IV":
                    {
                        rotor_3 = new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", rot_3_lbl, 'V');
                    }
                    break;
                case "V":
                    {
                        rotor_3 = new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", rot_3_lbl, 'V');
                    }
                    break;
            }

            SetValuesElements();

            rotor_1.ResetOffset();
            rotor_2.ResetOffset();
            rotor_3.ResetOffset();

            rot_1_lbl.Text = "A";
            rot_2_lbl.Text = "A";
            rot_3_lbl.Text = "A";
        }

        private void copy_button_Click(object sender, EventArgs e)
        {
            if (output_textBox.Text != "")
            {
                Clipboard.SetDataObject(output_textBox.Text);
                MessageBox.Show("Текст успешно скопирован");
            }
            else
                MessageBox.Show("Поле вывода пустое","Ошибка");
        }


        private void rot_1_inc_button_Click(object sender, EventArgs e)
        {
            rotor_3.Switch();
        }

        private void rot_2_inc_button_Click(object sender, EventArgs e)
        {
            rotor_2.Switch();
        }

        private void rot_3_inc_button_Click(object sender, EventArgs e)
        {
            rotor_1.Switch();
        }

        private void aboutEnigma_Button_Click(object sender, EventArgs e)
        {
            Information information = new Information();
            information.ShowDialog();
        }

        private void pasteText_Button_Click(object sender, EventArgs e)
        {
            if (TextIsValid(Clipboard.GetText()))
            {
                input_textBox.Text += Clipboard.GetText().ToUpper();
                EncryprionCycle(input_textBox.Text);
            }
            else
                MessageBox.Show("Текст имеет недопустимые символы", "Ошибка");
        }

        private void rot_1_dec_button_Click(object sender, EventArgs e)
        {
            rotor_3.SwitchBack();
        }

        private void rot_2_dec_button_Click(object sender, EventArgs e)
        {
            rotor_2.SwitchBack();
        }

        private void rot_3_dec_button_Click(object sender, EventArgs e)
        {
            rotor_1.SwitchBack();
        }
    }
}
