using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

// CODED BY KATHLEEN FORGIARINI DA SILVA
// 2023-03-27
// LAB 7.2 - WORKING WITH TEXT AND BINARY FILES

namespace lab7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string path = @".\files\Names.txt";
        private void wtext_Click(object sender, EventArgs e)
        {
            if (fName.Text == "")
            {
                MessageBox.Show("FName is a required field.");
            }
            else if (lName.Text == "")
            {
                MessageBox.Show("LName is a required field.");
            }
            else
            {
                string dir = @".\files\";
                FileStream fileStream = null;

                try
                {
                    if (!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(fileStream);
                    writer.Write(fName.Text + ";" + lName.Text + "\n");

                    writer.Close();
                    fileStream.Close();

                    MessageBox.Show("Data was written to the file successfully.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured, try again. \n" + ex.Message);
                }
                finally
                {
                    if (fileStream != null) fileStream.Close();
                }
            }
        }

        private void rtext_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fileStream);

                string textToPrint = "";
                int counter = 0;
                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string[] data = line.Split(';');
                    textToPrint += data[0] + " " + data[1] + "\n";
                    counter++;

                    if (counter == 3)
                    {
                        MessageBox.Show(textToPrint);
                        textToPrint = "";
                        counter = 0;
                    }
                }

                if (counter != 0)
                {
                    MessageBox.Show(textToPrint);
                }

                reader.Close();
                fileStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading from the file: \n" + ex.Message);
            }
            finally
            {
                if (fileStream != null) fileStream.Close();
            }
        }

        string pathBinary = @"C:.\files\BNames.dat";
        private void wbinary_Click(object sender, EventArgs e)
        {
            if (fName.Text == "")
            {
                MessageBox.Show("FName is a required field.");
            }
            else if (lName.Text == "")
            {
                MessageBox.Show("LName is a required field.");
            }
            else
            {
                string dir = @".\files\";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                FileStream fs = null;
                try
                {
                    fs = new FileStream(pathBinary, FileMode.Append, FileAccess.Write);
                    BinaryWriter binaryOut = new BinaryWriter(fs);
                    binaryOut.Write(fName.Text.Trim());
                    binaryOut.Write(lName.Text.Trim());
                    binaryOut.Close();
                    fs.Close();

                    MessageBox.Show("Data was written to the file successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured, try again. \n" + ex.Message);
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
            }
        }

        private void rbinary_Click(object sender, EventArgs e)
        {
            FileStream fs = null;

            try
            {
                fs = new FileStream(pathBinary, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryReader binaryIn = new BinaryReader(fs);
                string textToPrint = "FName \t LName \n";
                string LName, FName;
                int counter = 0;
                while (binaryIn.PeekChar() != -1)
                {
                    FName = binaryIn.ReadString();
                    LName = binaryIn.ReadString();
                    textToPrint += FName + ",\t" + LName + "\n";
                    counter++;

                    if (counter == 3)
                    {
                        MessageBox.Show(textToPrint);
                        textToPrint = "";
                        counter = 0;
                    }
                }

                if (counter != 0)
                {
                    MessageBox.Show(textToPrint);
                }

                binaryIn.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading from the file: \n" + ex.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
    }
}
