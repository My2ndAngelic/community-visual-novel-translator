using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;
using EnterpriseDT.Util.Debug;
using EnterpriseDT.Net.Ftp;

namespace Community_Novel_Translator
{
    public partial class BTTranslator : Form
    {
        string PathTxt = @"C:/script.txt";
        string PathLine = @"C:/lines.txt";
        public BTTranslator()
        {
            InitializeComponent();
        }

        private byte[] downloadedData;

        //Connects to a URL and attempts to download the file
        private void downloadData(string url)
        {

            downloadedData = new byte[0];
            try
            {
                System.Net.ServicePointManager.Expect100Continue = false;
                //Get a data stream from the url
                WebRequest req = WebRequest.Create(url);
                req.Proxy = null;
                WebResponse response = req.GetResponse();
                Stream stream = response.GetResponseStream();

                //Download in chuncks
                byte[] buffer = new byte[1024];

                //Get Total Size
                int dataLength = (int)response.ContentLength;

                //With the total data we can set up our progress indicators
                PBDown.Maximum = dataLength;
                // lbProgress.Text = "0/" + dataLength.ToString();

                Application.DoEvents();

                //Download to memory
                //Note: adjust the streams here to download directly to the hard drive
                MemoryStream memStream = new MemoryStream();
                while (true)
                {
                    //Try to read the data
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);

                    if (bytesRead == 0)
                    {
                        //Finished downloading
                        PBDown.Value = PBDown.Maximum;
                        //lbProgress.Text = dataLength.ToString() + "/" + dataLength.ToString();

                        Application.DoEvents();
                        break;
                    }
                    else
                    {
                        //Write the downloaded data
                        memStream.Write(buffer, 0, bytesRead);

                        //Update the progress bar
                        if (PBDown.Value + bytesRead <= PBDown.Maximum)
                        {
                            PBDown.Value += bytesRead;
                            //lbProgress.Text = PBDown.Value.ToString() + "/" + dataLength.ToString();

                            PBDown.Refresh();
                            Application.DoEvents();
                        }
                    }
                }

                //Convert the downloaded stream to a byte array
                downloadedData = memStream.ToArray();

                //Clean up
                stream.Close();
                memStream.Close();
            }
            catch (Exception)
            {
                //May not be connected to the internet
                //Or the URL might not exist
                MessageBox.Show("File download error, close the software and retry.");
            }
        }

        public void BTOttieni_Click(object sender, EventArgs e)
        {
            if (File.Exists("C:/script.txt") == false)
            {
                //Download script
                downloadData("http://zer0byt3.altervista.org/script.txt");
            
                //Save script
                FileStream script = new FileStream("C:/script.txt", FileMode.Create);
                script.Write(downloadedData, 0, downloadedData.Length);
                script.Close();
            }
            else if (File.Exists("C:/script.txt") == true)
            {
            }

            //Download lines
            downloadData("http://zer0byt3.altervista.org/line.txt");
            //Save Lines
            FileStream linea = new FileStream("C:/lines.txt", FileMode.Create);
            linea.Write(downloadedData, 0, downloadedData.Length);
            linea.Close();

            //Load text files
            System.IO.TextReader tr = new System.IO.StreamReader(PathTxt);
            System.IO.TextReader lr = new System.IO.StreamReader(PathLine);

            //Read how many lines have already been translated
            string linestring = lr.ReadLine();
            int line = Convert.ToInt32(linestring);

            //Set the number of lines to download
            int NumberOfLines = line + 5;

            //Update download lines count
            lr.Close();
            RichTextBox RTBAddLine = new RichTextBox();
            string lineaupdate = Convert.ToString(NumberOfLines);
            RTBAddLine.Text = lineaupdate;
            System.IO.File.WriteAllText(PathLine, RTBAddLine.Text);

            //Make lines array
            string[] ListLines = new string[NumberOfLines];

            //Read the number of lines set before
            for (int i = 1; i < NumberOfLines; i++)
            {
                ListLines[i] = tr.ReadLine();
            }

            //Put lines in the RichTextBox
            for (int i = line; i < NumberOfLines; i++)
            {
                if (i < NumberOfLines - 1)
                {
                    RTBOriginale.Text += ListLines[i] + System.Environment.NewLine;
                }
                else
                {
                    RTBOriginale.Text += ListLines[i];
                }
            }

            // Close streams
            tr.Close();
        }

        private void BTTradotto_Click(object sender, EventArgs e)
        {
            int check_originale = RTBOriginale.GetLineFromCharIndex(2147483647);
            int check_traduzione = RTBTraduzione.GetLineFromCharIndex(2147483647);
            RTBTraduzione.Text += System.Environment.NewLine;
            //Read how many lines have already been translated
            System.IO.TextReader lr = new System.IO.StreamReader(PathLine);
            string linestring = lr.ReadLine();
            int line = Convert.ToInt32(linestring);

            if (check_originale == check_traduzione)
            {
                RTBTraduzione.SaveFile("C:/" + Convert.ToString(line - 5) + " - " + Convert.ToString(line - 1) + ".txt", RichTextBoxStreamType.PlainText);
            }
            else
            {
                MessageBox.Show("The original text and the translated text have a different number of lines, please check the translation.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            string host = "yourftphost";
            string user = "ftpuser";
            string password = "ftppassword";

            Logger.CurrentLevel = Level.ALL;

            FTPClient ftp = null;

            try
            {
                // set up client
                ftp = new FTPClient(host);

                // login
                ftp.Login(user, password);

                // set up passive ASCII transfers
                ftp.ConnectMode = FTPConnectMode.PASV;
                ftp.TransferType = FTPTransferType.ASCII;

                //Starting FTP upload
                ftp.Put("C:/" + Convert.ToString(line - 5) + " - " + Convert.ToString(line - 1) + ".txt", Convert.ToString(line - 5) + " - " + Convert.ToString(line - 1) + ".txt");

                ftp.Put(PathLine, "line.txt");

                //Delete temporary files
                lr.Close();
                ftp.Quit();

                File.Delete("C:/" + Convert.ToString(line - 5) + " - " + Convert.ToString(line - 1) + ".txt");
                BTReset_Click(sender, e);
                BTOttieni_Click(sender, e);

            }

            catch (Exception)
            {
            }

         }

        private void BTReset_Click(object sender, EventArgs e)
        {
            File.Delete(PathLine);
            RTBOriginale.ResetText();
            RTBTraduzione.ResetText();
            PBDown.Value = 0;
        }

        private void BTExit_Click(object sender, EventArgs e)
        {
            File.Delete(PathLine);
            File.Delete(PathTxt);
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTExit_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form FRMTranslator = new FRMTranslator();
            FRMTranslator.Show();
        }

    }
}
