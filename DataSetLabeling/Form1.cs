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

namespace DataSetLabeling
{
    public partial class DataSetLabeler : Form
    {
        System.IO.Stream myStream = null;
        Int32[][] LabelMatrix = new Int32[30][];
        List<String> Pictures = new List<string>();
        int lines = 0;
        String[] Classes = new String[30];

        public DataSetLabeler()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String About_Message;
            About_Message = "This application has been created to assist in Masters thesis.\n"
                + "Author: Jasim Khan\n" + "DISI\n" + "University of Trento\n";
            MessageBox.Show(About_Message);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button_Excel_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFile = new OpenFileDialog();
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.Filter = "Comma Separated (.csv)|*.csv";
            openFileDialog1.FilterIndex = 1;

            openFileDialog1.Multiselect = false;

            DialogResult Result = openFileDialog1.ShowDialog();

            if (Result == DialogResult.OK)
            {
                label_ExcelFile.Text = openFileDialog1.FileName;
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                            string file = Path.GetFileName(openFileDialog1.FileName);
                            string path = Path.GetFullPath(file); //when i did it like this it's work fine but all the time give me same path whatever where my "*.txt" file is
                                                                  //Insert code to read the stream here. 
                                                                  //fileName = openFileDialog1.FileName; 
                            StreamReader csvFile = new StreamReader(openFileDialog1.FileName);

                            String line;
                            int i = 0, j = 0, line1 = 0;

                            while ((line = csvFile.ReadLine()) != null)
                            {
                                String[] line_split = line.Split(',');

                                if (i == 0)
                                {
                                    line1 = line_split.Length;
                                }

                                if (i != 0)
                                {
                                    if (line1 != line_split.Length)
                                        MessageBox.Show("Error in Csv file...");
                                }

                                LabelMatrix[i] = new Int32[line_split.Length-1];

                                for (int k=0; k <= line_split.Length-1; k++)
                                {
                                    if ( k==0 )
                                    {
                                        switch (i+1)
                                        {
                                            case 1:
                                                checkBox1.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 2:
                                                checkBox2.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 3:
                                                checkBox3.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 4:
                                                checkBox4.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 5:
                                                checkBox5.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 6:
                                                checkBox6.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 7:
                                                checkBox7.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 8:
                                                checkBox8.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 9:
                                                checkBox9.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 10:
                                                checkBox10.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 11:
                                                checkBox11.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 12:
                                                checkBox12.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 13:
                                                checkBox13.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 14:
                                                checkBox14.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 15:
                                                checkBox15.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 16:
                                                checkBox16.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 17:
                                                checkBox17.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 18:
                                                checkBox18.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 19:
                                                checkBox19.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 20:
                                                checkBox20.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 21:
                                                checkBox21.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 22:
                                                checkBox22.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 23:
                                                checkBox23.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 24:
                                                checkBox24.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 25:
                                                checkBox25.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 26:
                                                checkBox26.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 27:
                                                checkBox27.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 28:
                                                checkBox28.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 29:
                                                checkBox29.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                            case 30:
                                                checkBox30.Text = line_split[0];
                                                Classes[i] = line_split[0];
                                                break;

                                        }
                                    }
                                    else
                                    {
                                        if (line_split[k] == "1")
                                        {
                                            LabelMatrix[i][k - 1] = 1;
                                        }
                                        else
                                        {
                                            LabelMatrix[i][k - 1] = 0;
                                        }
                                        
                                    }
                                }
                                i++;
                            }
                            csvFile.Close();
                            lines = i;



                            //MessageBox.Show(file, "fileName");
                            //MessageBox.Show(openFileDialog1.FileName, "Directory");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Folder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label_PicsFolder.Text = folderBrowserDialog1.SelectedPath;
            }

            if (folderBrowserDialog1.SelectedPath != "")
            {
                int count = 0;
                int fCount = Directory.GetFiles(label_PicsFolder.Text, "*.jpg", SearchOption.TopDirectoryOnly).Length;

                String[] filenames = Directory.GetFileSystemEntries(folderBrowserDialog1.SelectedPath, "*.jpg", SearchOption.TopDirectoryOnly);

                String[] ValidPics = new String[fCount];

                for (int i=0; i<fCount; i++)
                {
                    ValidPics[i] = String.Concat("\\" + Convert.ToString(i + 1), ".jpg");
                    ValidPics[i] = String.Concat(folderBrowserDialog1.SelectedPath, ValidPics[i]);
                    if (File.Exists(ValidPics[i]))
                    {
                        Pictures.Add(ValidPics[i]);
                        count++;
                    }
                    else
                    {
                        MessageBox.Show("Out of " + Convert.ToString(fCount) + ", " + Convert.ToString(count) + " valid Pictures discovered...");
                        break;
                    }
                }
                
            }
            
        }

        private void button_PicCount_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.SelectedPath != "")
            {
                int count = 0;
                int fCount = Directory.GetFiles(label_PicsFolder.Text, "*.jpg", SearchOption.TopDirectoryOnly).Length;

                String[] filenames = Directory.GetFileSystemEntries(folderBrowserDialog1.SelectedPath, "*", SearchOption.TopDirectoryOnly);

                String pattern = "^\\d+.jpg";

                foreach (string s in filenames)
                {
                    string FileName = s.Substring(s.LastIndexOf('\\') + 1);

                    if (System.Text.RegularExpressions.Regex.IsMatch(FileName, pattern))
                    {
                        count = count + 1;
                    }
                }
                label3_PicCount.Text = Convert.ToString(count) + " of " + Convert.ToString(fCount);
            }
            else
            {
                MessageBox.Show("Error: Folder not selected... ");
            }
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.SelectedPath != "" && openFileDialog1.FileName != "")
            {
                pictureBox1.ImageLocation = Pictures[0];
                textBox_PicName.Text = Pictures[0];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Load();
                RefreshInfo(Pictures[0]);
            }
            else
            {
                MessageBox.Show("Error: Missing Parameters... ");
            }
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            String currentFile = textBox_PicName.Text;
            //int index = Array.IndexOf(PictureLocations, currentFile);
            int index = Pictures.IndexOf(currentFile);

            index = index + 1;
            pictureBox1.ImageLocation = Pictures[index];
            textBox_PicName.Text = Pictures[index];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Load();
            RefreshInfo(Pictures[index]);
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            String currentFile = textBox_PicName.Text;
            //int index = Array.IndexOf(PictureLocations, currentFile);
            int index = Pictures.IndexOf(currentFile);

            if(index == 0)
            {
                MessageBox.Show("Error, cannot go back further...");
            }
            else
            {
                index = index - 1;
                pictureBox1.ImageLocation = Pictures[index];
                textBox_PicName.Text = Pictures[index];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Load();
                RefreshInfo(Pictures[index]);
            }
        }

        private void RefreshInfo(String ImageLocation)
        {
            String FileName = ImageLocation.Substring(ImageLocation.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32( strings[0] );
            FileNum = FileNum - 1;

            for (int i = 0; i <= lines-1; i++)
            {
                switch (i)
                {
                    case 0:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox1.Checked = true;
                            textBox1.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox1.Checked = false;
                            textBox1.Text = Convert.ToString(0);
                        }
                        break;

                    case 1:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox2.Checked = true;
                            textBox2.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox2.Checked = false;
                            textBox2.Text = Convert.ToString(0);
                        }
                        break;

                    case 2:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox3.Checked = true;
                            textBox3.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox3.Checked = false;
                            textBox3.Text = Convert.ToString(0);
                        }
                        break;

                    case 3:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox4.Checked = true;
                            textBox4.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox4.Checked = false;
                            textBox4.Text = Convert.ToString(0);
                        }
                        break;

                    case 4:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox5.Checked = true;
                            textBox5.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox5.Checked = false;
                            textBox5.Text = Convert.ToString(0);
                        }
                        break;

                    case 5:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox6.Checked = true;
                            textBox6.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox6.Checked = false;
                            textBox6.Text = Convert.ToString(0);
                        }
                        break;

                    case 6:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox7.Checked = true;
                            textBox7.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox7.Checked = false;
                            textBox7.Text = Convert.ToString(0);
                        }
                        break;

                    case 7:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox8.Checked = true;
                            textBox8.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox8.Checked = false;
                            textBox8.Text = Convert.ToString(0);
                        }
                        break;

                    case 8:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox9.Checked = true;
                            textBox9.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox9.Checked = false;
                            textBox9.Text = Convert.ToString(0);
                        }
                        break;

                    case 9:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox10.Checked = true;
                            textBox10.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox10.Checked = false;
                            textBox10.Text = Convert.ToString(0);
                        }
                        break;

                    case 10:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox11.Checked = true;
                            textBox11.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox11.Checked = false;
                            textBox11.Text = Convert.ToString(0);
                        }
                        break;

                    case 11:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox12.Checked = true;
                            textBox12.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox12.Checked = false;
                            textBox12.Text = Convert.ToString(0);
                        }
                        break;

                    case 12:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox13.Checked = true;
                            textBox13.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox13.Checked = false;
                            textBox13.Text = Convert.ToString(0);
                        }
                        break;

                    case 13:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox14.Checked = true;
                            textBox14.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox14.Checked = false;
                            textBox14.Text = Convert.ToString(0);
                        }
                        break;

                    case 14:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox15.Checked = true;
                            textBox15.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox15.Checked = false;
                            textBox15.Text = Convert.ToString(0);
                        }
                        break;

                    case 15:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox16.Checked = true;
                            textBox16.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox16.Checked = false;
                            textBox16.Text = Convert.ToString(0);
                        }
                        break;

                    case 16:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox17.Checked = true;
                            textBox17.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox17.Checked = false;
                            textBox17.Text = Convert.ToString(0);
                        }
                        break;

                    case 17:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox18.Checked = true;
                            textBox18.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox18.Checked = false;
                            textBox18.Text = Convert.ToString(0);
                        }
                        break;

                    case 18:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox19.Checked = true;
                            textBox19.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox19.Checked = false;
                            textBox19.Text = Convert.ToString(0);
                        }
                        break;

                    case 19:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox20.Checked = true;
                            textBox20.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox20.Checked = false;
                            textBox20.Text = Convert.ToString(0);
                        }
                        break;

                    case 20:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox21.Checked = true;
                            textBox21.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox21.Checked = false;
                            textBox21.Text = Convert.ToString(0);
                        }
                        break;

                    case 21:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox22.Checked = true;
                            textBox22.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox22.Checked = false;
                            textBox22.Text = Convert.ToString(0);
                        }
                        break;

                    case 22:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox23.Checked = true;
                            textBox23.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox23.Checked = false;
                            textBox23.Text = Convert.ToString(0);
                        }
                        break;

                    case 23:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox24.Checked = true;
                            textBox24.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox24.Checked = false;
                            textBox24.Text = Convert.ToString(0);
                        }
                        break;

                    case 24:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox25.Checked = true;
                            textBox25.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox25.Checked = false;
                            textBox25.Text = Convert.ToString(0);
                        }
                        break;

                    case 25:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox26.Checked = true;
                            textBox26.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox26.Checked = false;
                            textBox26.Text = Convert.ToString(0);
                        }
                        break;

                    case 26:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox27.Checked = true;
                            textBox27.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox27.Checked = false;
                            textBox27.Text = Convert.ToString(0);
                        }
                        break;

                    case 27:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox28.Checked = true;
                            textBox28.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox28.Checked = false;
                            textBox28.Text = Convert.ToString(0);
                        }
                        break;

                    case 28:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox29.Checked = true;
                            textBox29.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox29.Checked = false;
                            textBox29.Text = Convert.ToString(0);
                        }
                        break;

                    case 29:
                        if (LabelMatrix[i][FileNum] == Convert.ToInt32(1))
                        {
                            checkBox30.Checked = true;
                            textBox30.Text = Convert.ToString(1);
                        }
                        else
                        {
                            checkBox30.Checked = false;
                            textBox30.Text = Convert.ToString(0);
                        }
                        break;

                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox1.Checked == true)
            {
                LabelMatrix[0][FileNum-1] = 1;
                textBox1.Text = "1";
            }
            else
            {
                LabelMatrix[0][FileNum-1] = 0;
                textBox1.Text = "0";
            }
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox2.Checked == true)
            {
                LabelMatrix[1][FileNum - 1] = 1;
                textBox2.Text = "1";
            }
            else
            {
                LabelMatrix[1][FileNum - 1] = 0;
                textBox2.Text = "0";
            }
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            if (sender.Equals(checkBox3))
            {
                String FileName_temp = textBox_PicName.Text;
                String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
                String[] strings = FileName.Split('.');
                Int32 FileNum = Convert.ToInt32(strings[0]);

                if (checkBox3.Checked == true)
                {
                    LabelMatrix[2][FileNum - 1] = 1;
                    textBox3.Text = "1";
                }
                else
                {
                    LabelMatrix[2][FileNum - 1] = 0;
                    textBox3.Text = "0";
                }
            }
            else
            {
                String FileName_temp = textBox_PicName.Text;
                String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
                String[] strings = FileName.Split('.');
                Int32 FileNum = Convert.ToInt32(strings[0]);

                if (checkBox4.Checked == true)
                {
                    LabelMatrix[3][FileNum - 1] = 1;
                    textBox4.Text = "1";
                }
                else
                {
                    LabelMatrix[3][FileNum - 1] = 0;
                    textBox4.Text = "0";
                }
            }
        }

        private void checkBox5_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox5.Checked == true)
            {
                LabelMatrix[4][FileNum - 1] = 1;
                textBox5.Text = "1";
            }
            else
            {
                LabelMatrix[4][FileNum - 1] = 0;
                textBox5.Text = "0";
            }
        }

        private void checkBox6_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox6.Checked == true)
            {
                LabelMatrix[5][FileNum - 1] = 1;
                textBox6.Text = "1";
            }
            else
            {
                LabelMatrix[5][FileNum - 1] = 0;
                textBox6.Text = "0";
            }
        }

        private void checkBox7_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox7.Checked == true)
            {
                LabelMatrix[6][FileNum - 1] = 1;
                textBox7.Text = "1";
            }
            else
            {
                LabelMatrix[6][FileNum - 1] = 0;
                textBox7.Text = "0";
            }
        }

        private void checkBox8_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox8.Checked == true)
            {
                LabelMatrix[7][FileNum - 1] = 1;
                textBox8.Text = "1";
            }
            else
            {
                LabelMatrix[7][FileNum - 1] = 0;
                textBox8.Text = "0";
            }
        }

        private void checkBox9_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox9.Checked == true)
            {
                LabelMatrix[8][FileNum - 1] = 1;
                textBox9.Text = "1";
            }
            else
            {
                LabelMatrix[8][FileNum - 1] = 0;
                textBox9.Text = "0";
            }
        }

        private void checkBox10_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox10.Checked == true)
            {
                LabelMatrix[9][FileNum - 1] = 1;
                textBox10.Text = "1";
            }
            else
            {
                LabelMatrix[9][FileNum - 1] = 0;
                textBox10.Text = "0";
            }
        }

        private void checkBox11_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox11.Checked == true)
            {
                LabelMatrix[10][FileNum - 1] = 1;
                textBox11.Text = "1";
            }
            else
            {
                LabelMatrix[10][FileNum - 1] = 0;
                textBox11.Text = "0";
            }
        }

        private void checkBox12_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox12.Checked == true)
            {
                LabelMatrix[11][FileNum - 1] = 1;
                textBox12.Text = "1";
            }
            else
            {
                LabelMatrix[11][FileNum - 1] = 0;
                textBox12.Text = "0";
            }
        }

        private void checkBox13_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox13.Checked == true)
            {
                LabelMatrix[12][FileNum - 1] = 1;
                textBox13.Text = "1";
            }
            else
            {
                LabelMatrix[12][FileNum - 1] = 0;
                textBox13.Text = "0";
            }
        }

        private void checkBox14_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox14.Checked == true)
            {
                LabelMatrix[13][FileNum - 1] = 1;
                textBox14.Text = "1";
            }
            else
            {
                LabelMatrix[13][FileNum - 1] = 0;
                textBox14.Text = "0";
            }
        }

        private void checkBox15_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox15.Checked == true)
            {
                LabelMatrix[14][FileNum - 1] = 1;
                textBox15.Text = "1";
            }
            else
            {
                LabelMatrix[14][FileNum - 1] = 0;
                textBox15.Text = "0";
            }
        }

        private void checkBox16_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox16.Checked == true)
            {
                LabelMatrix[15][FileNum - 1] = 1;
                textBox16.Text = "1";
            }
            else
            {
                LabelMatrix[15][FileNum - 1] = 0;
                textBox16.Text = "0";
            }
        }

        private void checkBox17_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox17.Checked == true)
            {
                LabelMatrix[16][FileNum - 1] = 1;
                textBox17.Text = "1";
            }
            else
            {
                LabelMatrix[16][FileNum - 1] = 0;
                textBox17.Text = "0";
            }
        }

        private void checkBox18_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox18.Checked == true)
            {
                LabelMatrix[17][FileNum - 1] = 1;
                textBox18.Text = "1";
            }
            else
            {
                LabelMatrix[17][FileNum - 1] = 0;
                textBox18.Text = "0";
            }
        }

        private void checkBox19_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox19.Checked == true)
            {
                LabelMatrix[18][FileNum - 1] = 1;
                textBox19.Text = "1";
            }
            else
            {
                LabelMatrix[18][FileNum - 1] = 0;
                textBox19.Text = "0";
            }
        }

        private void checkBox20_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox20.Checked == true)
            {
                LabelMatrix[19][FileNum - 1] = 1;
                textBox20.Text = "1";
            }
            else
            {
                LabelMatrix[19][FileNum - 1] = 0;
                textBox20.Text = "0";
            }
        }

        private void checkBox21_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox21.Checked == true)
            {
                LabelMatrix[20][FileNum - 1] = 1;
                textBox21.Text = "1";
            }
            else
            {
                LabelMatrix[20][FileNum - 1] = 0;
                textBox21.Text = "0";
            }
        }

        private void checkBox22_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox22.Checked == true)
            {
                LabelMatrix[21][FileNum - 1] = 1;
                textBox22.Text = "1";
            }
            else
            {
                LabelMatrix[21][FileNum - 1] = 0;
                textBox22.Text = "0";
            }
        }

        private void checkBox23_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox23.Checked == true)
            {
                LabelMatrix[22][FileNum - 1] = 1;
                textBox23.Text = "1";
            }
            else
            {
                LabelMatrix[22][FileNum - 1] = 0;
                textBox23.Text = "0";
            }
        }

        private void checkBox24_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox24.Checked == true)
            {
                LabelMatrix[23][FileNum - 1] = 1;
                textBox24.Text = "1";
            }
            else
            {
                LabelMatrix[23][FileNum - 1] = 0;
                textBox24.Text = "0";
            }
        }

        private void checkBox25_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox25.Checked == true)
            {
                LabelMatrix[24][FileNum - 1] = 1;
                textBox25.Text = "1";
            }
            else
            {
                LabelMatrix[24][FileNum - 1] = 0;
                textBox25.Text = "0";
            }
        }

        private void checkBox26_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox26.Checked == true)
            {
                LabelMatrix[25][FileNum - 1] = 1;
                textBox26.Text = "1";
            }
            else
            {
                LabelMatrix[25][FileNum - 1] = 0;
                textBox26.Text = "0";
            }
        }

        private void checkBox27_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox27.Checked == true)
            {
                LabelMatrix[26][FileNum - 1] = 1;
                textBox27.Text = "1";
            }
            else
            {
                LabelMatrix[26][FileNum - 1] = 0;
                textBox27.Text = "0";
            }
        }

        private void checkBox28_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox28.Checked == true)
            {
                LabelMatrix[27][FileNum - 1] = 1;
                textBox28.Text = "1";
            }
            else
            {
                LabelMatrix[27][FileNum - 1] = 0;
                textBox28.Text = "0";
            }
        }

        private void checkBox29_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox29.Checked == true)
            {
                LabelMatrix[28][FileNum - 1] = 1;
                textBox1.Text = "1";
            }
            else
            {
                LabelMatrix[28][FileNum - 1] = 0;
                textBox29.Text = "0";
            }
        }

        private void checkBox30_CheckStateChanged(object sender, EventArgs e)
        {
            String FileName_temp = textBox_PicName.Text;
            String FileName = FileName_temp.Substring(FileName_temp.LastIndexOf('\\') + 1);
            String[] strings = FileName.Split('.');
            Int32 FileNum = Convert.ToInt32(strings[0]);

            if (checkBox30.Checked == true)
            {
                LabelMatrix[29][FileNum - 1] = 1;
                textBox30.Text = "1";
            }
            else
            {
                LabelMatrix[29][FileNum - 1] = 0;
                textBox30.Text = "0";
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            //StreamWriter sw = new StreamWriter(folderBrowserDialog1.SelectedPath + "\\outputLabel.csv");
            StreamWriter sw = new StreamWriter(openFileDialog1.FileName);
            String line = "";

            for (int i=0; i<lines; i++)
            {
                int size = LabelMatrix[0].Length;
                for (int j=0; j<size; j++)
                {
                    if (j == 0)
                    {
                        line = Classes[i] + "," +  Convert.ToString( LabelMatrix[i][j] );
                    }
                    else
                    {
                        line = line + "," + Convert.ToString(LabelMatrix[i][j]);
                    }

                }
                sw.WriteLine(line);
                line = "";
            }

            sw.Close();
        }
    }
}
