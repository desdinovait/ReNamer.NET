using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Drawing.Drawing2D;

namespace Files_Renamer.NET
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormWarrenty fw = new FormWarrenty();
            fw.ShowDialog();

            /*Previene l'utilizzo dopo una certa data
            if (DateTime.Compare(DateTime.Now, new DateTime(2008, 9, 1)) == 1)
            {
                FormExpired fe = new FormExpired();
                fe.ShowDialog();
            }*/

            //Titolo
            this.Text = Assembly.GetExecutingAssembly().GetName(false).Name.ToString() + " " + Assembly.GetExecutingAssembly().GetName(false).Version.ToString();

            //Preview iniziale
            PreviewExample();
        }


        private void buttonSource_Click(object sender, EventArgs e)
        {       
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Barra
                progressBarRanamer.Maximum = openFileDialog1.FileNames.Length;
                progressBarRanamer.Minimum = 0;
                progressBarRanamer.ForeColor = Color.Black;

                //Pulsante
                buttonSource.Enabled = false;

                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {

                    string currentFilename = Path.GetFileName(openFileDialog1.FileNames[i]);
                    string currentDirectory = Path.GetDirectoryName(openFileDialog1.FileNames[i]) + "\\";
                    string currentExt = Path.GetExtension(openFileDialog1.FileNames[i]).ToUpper().TrimStart('.');
                    try
                    {
                        //Disegna l'immagine, se presente
                        Image sourceimage = Image.FromFile(currentDirectory + currentFilename);
                        float rap = (float)sourceimage.Width / (float)sourceimage.Height;
                        int newWidth = (int)((float)100.0f * rap);
                        Image thumb = sourceimage.GetThumbnailImage(newWidth, 100, null, IntPtr.Zero);
                        dataGridViewFiles.Rows.Insert(dataGridViewFiles.Rows.Count, currentDirectory, currentFilename, "", currentExt, thumb);
                        sourceimage.Dispose();
                    }
                    catch
                    {
                        //Mostra l'icona del programma associato
                        dataGridViewFiles.Rows.Insert(dataGridViewFiles.Rows.Count, currentDirectory, currentFilename, "", currentExt, IconExtractor.Extract(openFileDialog1.FileNames[i], IconExtractor.IconSize.Large).ToBitmap());
                    }

                    //Colori
                    dataGridViewFiles.Rows[dataGridViewFiles.Rows.Count - 1].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    //Selezione
                    dataGridViewFiles.Rows[dataGridViewFiles.Rows.Count - 1].Selected = true;

                    //Counter
                    labelCounter.Text = dataGridViewFiles.Rows.Count.ToString() + " / " + openFileDialog1.FileNames.Length.ToString();

                    //Barra
                    progressBarRanamer.Value = progressBarRanamer.Value + 1;

                    this.Refresh();
                }

                //Counter
                labelCounter.Text = "0 / 0";

                //Barra
                progressBarRanamer.Value = 0;
                progressBarRanamer.ForeColor = SystemColors.Highlight;

                //Focus
                dataGridViewFiles.Focus();

                //Pulsante
                buttonSource.Enabled = true;

                //Pulsanti
                if (dataGridViewFiles.RowCount > 0)
                {
                    buttonRemoveAll.Enabled = true;
                    buttonRemoveSelected.Enabled = true;
                }
                if (dataGridViewFiles.RowCount > 1)
                {
                    buttonMoveUp.Enabled = true;
                    buttonMoveDown.Enabled = true;
                }

                //Preview
                PreviewExample();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {
            int rem = dataGridViewFiles.Rows.Count;
            for (int r = 0; r < rem; r++)
            {
                dataGridViewFiles.Rows.RemoveAt(0);
            }

            buttonRemoveAll.Enabled = false;
            buttonRemoveSelected.Enabled = false;
            buttonMoveUp.Enabled = false;
            buttonMoveDown.Enabled = false;
        }

        private void dataGridViewFiles_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            labelTotal.Text = dataGridViewFiles.Rows.Count.ToString();
            PreviewExample();
        }

        private void dataGridViewFiles_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //Controlla la dimensione
            labelTotal.Text = dataGridViewFiles.RowCount.ToString();
            if (labelTotal.Text.Length >= 2)
            {
                numericIndex.Value = labelTotal.Text.Length;
            }
            PreviewExample();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            About aboutMe = new About();
            aboutMe.Show();
        }

        private void checkPreview_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewFiles.Columns[4].Visible = !dataGridViewFiles.Columns[4].Visible;
            if (dataGridViewFiles.Columns[4].Visible)
            {
                for (int i = 0; i < dataGridViewFiles.RowCount; i++)
                {
                    dataGridViewFiles.Rows[i].Height = 50;
                }
            }
            else
            {
                for (int i = 0; i < dataGridViewFiles.RowCount; i++)
                {
                    dataGridViewFiles.Rows[i].Height = 20;
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Impostazioni progress bar
            progressBarRanamer.Maximum = dataGridViewFiles.RowCount;
            progressBarRanamer.Minimum = 0;
            progressBarRanamer.Step = 1;

            //Conteggio
            int copiedFiles = 0;
            int movedFiles = 0;
            int overwritedFiles = 0;
            int resizedFiles = 0;

            //La directory di destinazione deve esistere
            if (Directory.Exists(labelDestination.Text))
            {
                //Esegue su tutti i files
                for (int c = 0; c < dataGridViewFiles.RowCount; c++)
                {
                    //Stringhe nomi files
                    string oldDir = dataGridViewFiles.Rows[c].Cells[0].Value.ToString();
                    string oldFile = dataGridViewFiles.Rows[c].Cells[1].Value.ToString();
                    string newDir = labelDestination.Text + "\\";
                    string newFile = dataGridViewFiles.Rows[c].Cells[2].Value.ToString();

                    //Il file di origine deve esistere
                    if (File.Exists(oldDir + oldFile))
                    {
                        dataGridViewFiles.Rows[c].Cells[1].Style.ForeColor = SystemColors.ControlText;
                        dataGridViewFiles.Rows[c].Cells[2].Style.ForeColor = SystemColors.ControlText;

                        try
                        {
                            if (checkBoxResize.Checked)
                            {
                                Image sourceimage = Image.FromFile(oldDir + oldFile);
                                //Ok
                                Bitmap convertedImage = ResizeBitmap(oldDir + oldFile, Convert.ToInt32(textResX.Text), Convert.ToInt32(textResY.Text), checkBoxHigh.Checked);
                                //Esistenza del file di destinazione
                                if (File.Exists(newDir + newFile))
                                {
                                    //Controllo overwrite
                                    if (checkBoxOverwrite.Checked)
                                    {
                                        //Cancella il file di dest e esegue
                                        File.Delete(newDir + newFile);
                                        FileInfo currentFile = new FileInfo(oldDir + oldFile);
                                        if (radioCopy.Checked)
                                        {
                                            convertedImage.Save(newDir + newFile);
                                            dataGridViewFiles.Rows[c].Cells[1].Style.ForeColor = SystemColors.ControlText;
                                            copiedFiles = copiedFiles + 1;
                                        }
                                        else
                                        {
                                            convertedImage.Save(newDir + newFile);
                                            try
                                            {
                                                sourceimage.Dispose();
                                                currentFile.Delete();
                                            }
                                            catch
                                            {
                                            }
                                            dataGridViewFiles.Rows[c].Cells[1].Style.ForeColor = Color.Red;
                                            movedFiles = movedFiles + 1;
                                        }
                                        dataGridViewFiles.Rows[c].Cells[2].Style.ForeColor = Color.Green;
                                        overwritedFiles = overwritedFiles + 1;
                                        resizedFiles = resizedFiles + 1;
                                    }
                                    else
                                    {
                                        //Non muove perchè il file di dest esiste e non si vuole sovrascriverlo
                                        dataGridViewFiles.Rows[c].Cells[1].Style.ForeColor = SystemColors.ControlText;
                                        dataGridViewFiles.Rows[c].Cells[2].Style.ForeColor = SystemColors.ControlText;
                                    }
                                }
                                else
                                {
                                    //Il file di dest non esiste, esegue senza problemi
                                    FileInfo currentFile = new FileInfo(oldDir + oldFile);
                                    if (radioCopy.Checked)
                                    {
                                        convertedImage.Save(newDir + newFile);
                                        dataGridViewFiles.Rows[c].Cells[1].Style.ForeColor = SystemColors.ControlText;
                                        copiedFiles = copiedFiles + 1;
                                    }
                                    else
                                    {
                                        convertedImage.Save(newDir + newFile);
                                        try
                                        {
                                            sourceimage.Dispose();
                                            currentFile.Delete();
                                        }
                                        catch
                                        {
                                        }
                                        dataGridViewFiles.Rows[c].Cells[1].Style.ForeColor = Color.Red;
                                        movedFiles = movedFiles + 1;
                                    }
                                    resizedFiles = resizedFiles + 1;
                                    dataGridViewFiles.Rows[c].Cells[2].Style.ForeColor = Color.Green;
                                }//*/
                            }
                            else
                            {
                                //Passa alla ridenominazione normale
                                throw new System.Exception();
                            }
                        }
                        catch
                        {
                            //Esistenza del file di destinazione
                            if (File.Exists(newDir + newFile))
                            {
                                //Controllo overwrite
                                if (checkBoxOverwrite.Checked)
                                {
                                    //Cancella il file di dest e esegue
                                    File.Delete(newDir + newFile);
                                    FileInfo currentFile = new FileInfo(oldDir + oldFile);
                                    if (radioCopy.Checked)
                                    {
                                        currentFile.CopyTo(newDir + newFile);
                                        dataGridViewFiles.Rows[c].Cells[1].Style.ForeColor = SystemColors.ControlText;
                                        copiedFiles = copiedFiles + 1;
                                    }
                                    else
                                    {
                                        currentFile.MoveTo(newDir + newFile);
                                        dataGridViewFiles.Rows[c].Cells[1].Style.ForeColor = Color.Red;
                                        movedFiles = movedFiles + 1;
                                    }
                                    dataGridViewFiles.Rows[c].Cells[2].Style.ForeColor = Color.Green;
                                    overwritedFiles = overwritedFiles + 1;
                                }
                                else
                                {
                                    //Non muove perchè il file di dest esiste e non si vuole sovrascriverlo
                                    dataGridViewFiles.Rows[c].Cells[1].Style.ForeColor = SystemColors.ControlText;
                                    dataGridViewFiles.Rows[c].Cells[2].Style.ForeColor = SystemColors.ControlText;
                                }
                            }
                            else
                            {
                                //Il file di dest non esiste, esegue senza problemi
                                FileInfo currentFile = new FileInfo(oldDir + oldFile);
                                if (radioCopy.Checked)
                                {
                                    currentFile.CopyTo(newDir + newFile);
                                    dataGridViewFiles.Rows[c].Cells[1].Style.ForeColor = SystemColors.ControlText;
                                    copiedFiles = copiedFiles + 1;
                                }
                                else
                                {
                                    currentFile.MoveTo(newDir + newFile);
                                    dataGridViewFiles.Rows[c].Cells[1].Style.ForeColor = Color.Red;
                                    movedFiles = movedFiles + 1;
                                }
                                dataGridViewFiles.Rows[c].Cells[2].Style.ForeColor = Color.Green;
                            }//*/
                        }

                    }
                    else
                    {
                        //File di origine non trovato
                        dataGridViewFiles.Rows[c].Cells[1].Style.ForeColor = Color.Blue;
                        dataGridViewFiles.Rows[c].Cells[2].Style.ForeColor = SystemColors.ControlText;
                    }

                    //Counter
                    int count = c + 1;
                    labelCounter.Text = count.ToString() + " / " + dataGridViewFiles.RowCount.ToString();
                    labelCounter.Refresh();

                    //Avanza di uno step
                    progressBarRanamer.Value = progressBarRanamer.Value + 1;
                }
            }
            else
            {
                //Directory di destinazione non trovata
                labelDestination.ForeColor = Color.Blue;
            }

            //Report finale
            FormReport report = new FormReport(dataGridViewFiles.RowCount, copiedFiles, movedFiles, overwritedFiles, resizedFiles, labelDestination.Text);
            report.ShowDialog();
            progressBarRanamer.Value = 0;

        }


        private void dataGridViewFiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Avvia il processo specificato
            try
            {
                Process.Start(dataGridViewFiles.CurrentRow.Cells[1].Value.ToString());
            }
            catch
            {
            }
        }

        private void buttonDestination_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                labelDestination.Text = folderBrowserDialog1.SelectedPath.ToString();
                labelDestination.ForeColor = SystemColors.ControlText;
                PreviewExample();
            }
        }


        private void textMatrix_TextChanged(object sender, EventArgs e)
        {
            PreviewExample();
        }

        private void textExtension_TextChanged(object sender, EventArgs e)
        {
            PreviewExample();
        }

        private void textStart_TextChanged(object sender, EventArgs e)
        {
            if (textStart.TextLength > Convert.ToInt32(numericIndex.Value))
            {
                numericIndex.Value = numericIndex.Value + 1;
            }
            PreviewExample();
        }

        private void numericIndex_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numericIndex.Value) <= textStart.TextLength)
            {
                numericIndex.Value = textStart.TextLength;
            }
            if (Convert.ToInt32(numericIndex.Value) < labelTotal.Text.Length)
            {
                numericIndex.Value = labelTotal.Text.Length;
            }

            PreviewExample();
        }

        private void radioAfter_CheckedChanged(object sender, EventArgs e)
        {
            textFilename.Enabled = true;
            numericIndex.Enabled = true;
            textStart.Enabled = true;
            PreviewExample();
        }

        private void radioBefore_CheckedChanged(object sender, EventArgs e)
        {
            textFilename.Enabled = true;
            numericIndex.Enabled = true;
            textStart.Enabled = true;
            PreviewExample();
        }

        private void PreviewExample()
        {
            try
            {
                //Controllo oltre i limiti (dopo la somma)
                int limit = Convert.ToInt32(textStart.Text) + Convert.ToInt32(labelTotal.Text) - 1;
                if (limit.ToString().Length > numericIndex.Value)
                {
                    numericIndex.Value = limit.ToString().Length;
                }

                //Preview datagrid
                if (dataGridViewFiles.RowCount > 0)
                {
                    for (int r = 0; r < dataGridViewFiles.RowCount; r++)
                    {
                        int currentIndex = r + Convert.ToInt32(textStart.Text);


                        /* legge la data dal valore EXIF nell'immagine (se scattata con un digitale)
                        string exifInfo = string.Empty;
                        string date = string.Empty;
                        string time = string.Empty;
                        try
                        {
                            Image theImage = new Bitmap(dataGridViewFiles.Rows[r].Cells[0].Value.ToString().ToLower() + "\\" + dataGridViewFiles.Rows[r].Cells[1].Value.ToString().ToLower());
                            System.Drawing.Imaging.PropertyItem propItem36867 = theImage.GetPropertyItem(36867);  //preleva le info sulla data, 36867 è un id standard per l'EXIF
                            exifInfo = System.Text.Encoding.ASCII.GetString(propItem36867.Value);
                            string[] splittedInfo = exifInfo.Split(' ');
                            date = splittedInfo[0].Replace(':', '-');
                            time = splittedInfo[1].Substring(0, splittedInfo[1].Length - 1).Replace(':','.');
                        }
                        catch
                        {
                            exifInfo = string.Empty;
                            date = string.Empty;
                            time = string.Empty;
                        }*/


                        string casedName = string.Empty;
                        string casedExt = string.Empty;
                        string currentName = string.Empty;
                        string currentExt = string.Empty;
                        //Nome
                        if ( (radioAfter.Checked) || (radioBefore.Checked) )
                        {
                            casedName = textFilename.Text;
                        }
                        else
                        {
                            casedName = Path.GetFileNameWithoutExtension(dataGridViewFiles.Rows[r].Cells[1].Value.ToString());
                        }
                        //Estensione
                        if (checkExtension.Checked)
                        {
                            casedExt = textExtension.Text;
                        }
                        else
                        {
                            casedExt = dataGridViewFiles.Rows[r].Cells[3].Value.ToString().ToLower();
                        }
                        //case (nome e estensione)
                        if (radioCaseUpper.Checked)
                        {
                            casedName = casedName.ToUpper();
                            if (checkIncludeExt.Checked) casedExt = casedExt.ToUpper();
                        }
                        else if (radioCaseLower.Checked)
                        {
                            casedName = casedName.ToLower();
                            if (checkIncludeExt.Checked) casedExt = casedExt.ToLower();
                        }
                        else if (radioCaseFirst.Checked)
                        {
                            casedName = casedName.ToLower();
                            string firstName = casedName.Substring(0, 1).ToUpper();
                            casedName = casedName.Remove(0, 1);
                            casedName = firstName + casedName;

                            if (checkIncludeExt.Checked)
                            {
                                casedExt = casedExt.ToLower();
                                string firstExt = casedExt.Substring(0, 1).ToUpper();
                                casedExt = casedExt.Remove(0, 1);
                                casedExt = firstExt + casedExt;
                            }
                        }
                        //Creazione nomefile
                        if (radioAfter.Checked)
                        {
                            currentName = casedName;
                            for (int i = 0; i < numericIndex.Value - currentIndex.ToString().Length; i++)
                            {
                                currentName = currentName + "0";
                            }
                            currentName = currentName + currentIndex.ToString() + "." + casedExt;
                        }
                        else if (radioBefore.Checked)
                        {
                            currentName = string.Empty;
                            for (int i = 0; i < numericIndex.Value - currentIndex.ToString().Length; i++)
                            {
                                currentName = currentName + "0";
                            }
                            currentName = currentName + currentIndex.ToString() + casedName + "." + casedExt;
                        }
                        else if (radioDisabled.Checked)
                        {
                            currentName = casedName + "." + casedExt;
                        }

                        //Imposta
                        dataGridViewFiles.Rows[r].Cells[2].Value = currentName;
                    }
                }
            }
            catch
            {
            }
            finally
            {
                //Imposta il pulsante Start in base alle condizioni
                buttonStart.Enabled = false;
                if ((checkExtension.Checked) || (radioCaseUpper.Checked) || (radioCaseLower.Checked) || (radioCaseFirst.Checked) || (radioBefore.Checked) || (radioAfter.Checked))
                {
                    if (dataGridViewFiles.RowCount >= 1)
                    {
                        if (Directory.Exists(labelDestination.Text))
                        {
                            buttonStart.Enabled = true;
                        }
                    }
                }
            }
        }

        private void textStart_Leave(object sender, EventArgs e)
        {
            if (textStart.Text == string.Empty)
            {
                textStart.Text = "0";
            }
        }

        private void checkBoxResize_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxResize.Checked == true)
            {
                textResX.Enabled = true;
                textResY.Enabled = true;
                checkBoxHigh.Enabled = true;
            }
            else
            {
                textResX.Enabled = false;
                textResY.Enabled = false;
                checkBoxHigh.Enabled = false;
            }
        }

        private void checkBoxOverwrite_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBoxOverwrite.Checked)
            {
                if (MessageBox.Show("Are you sure to overwrite destination files, if exists?\nThis may produce inconsistent results on files in the destination directory.", "Are you sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    checkBoxOverwrite.Checked = true;
                }
                else
                {
                    checkBoxOverwrite.Checked = false;
                }
            }
        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            if (dataGridViewFiles.SelectedRows.Count > 0)
            {
                //Rimuove una riga
                dataGridViewFiles.Rows.RemoveAt(dataGridViewFiles.SelectedRows[0].Index);

                //Pulsanti
                if (dataGridViewFiles.RowCount == 0)
                {
                    buttonRemoveAll.Enabled = false;
                    buttonRemoveSelected.Enabled = false;
                    buttonMoveUp.Enabled = false;
                    buttonMoveDown.Enabled = false;
                }
                if (dataGridViewFiles.RowCount == 1)
                {
                    buttonRemoveAll.Enabled = true;
                    buttonRemoveSelected.Enabled = true;
                    buttonMoveUp.Enabled = false;
                    buttonMoveDown.Enabled = false;
                }
                if (dataGridViewFiles.RowCount > 1)
                {
                    buttonRemoveAll.Enabled = true;
                    buttonRemoveSelected.Enabled = true;
                    buttonMoveUp.Enabled = true;
                    buttonMoveDown.Enabled = true;
                }

                //Preview
                PreviewExample();
            }
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            if (dataGridViewFiles.SelectedRows.Count > 0)
            {
                int selected = dataGridViewFiles.SelectedRows[0].Index;
                if (selected > 0)
                {
                    object val0 = dataGridViewFiles.Rows[selected].Cells[0].Value;
                    object val1 = dataGridViewFiles.Rows[selected].Cells[1].Value;
                    object val2 = dataGridViewFiles.Rows[selected].Cells[2].Value;
                    object val3 = dataGridViewFiles.Rows[selected].Cells[3].Value;
                    object val4 = dataGridViewFiles.Rows[selected].Cells[4].Value;

                    dataGridViewFiles.Rows[selected].Cells[0].Value = dataGridViewFiles.Rows[selected - 1].Cells[0].Value;
                    dataGridViewFiles.Rows[selected].Cells[1].Value = dataGridViewFiles.Rows[selected - 1].Cells[1].Value;
                    dataGridViewFiles.Rows[selected].Cells[2].Value = dataGridViewFiles.Rows[selected - 1].Cells[2].Value;
                    dataGridViewFiles.Rows[selected].Cells[3].Value = dataGridViewFiles.Rows[selected - 1].Cells[3].Value;
                    dataGridViewFiles.Rows[selected].Cells[4].Value = dataGridViewFiles.Rows[selected - 1].Cells[4].Value;

                    dataGridViewFiles.Rows[selected - 1].Cells[0].Value = val0;
                    dataGridViewFiles.Rows[selected - 1].Cells[1].Value = val1;
                    dataGridViewFiles.Rows[selected - 1].Cells[2].Value = val2;
                    dataGridViewFiles.Rows[selected - 1].Cells[3].Value = val3;
                    dataGridViewFiles.Rows[selected - 1].Cells[4].Value = val4;

                    dataGridViewFiles.Rows[selected - 1].Selected = true;

                    //Preview
                    PreviewExample();
                }
            }
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            if (dataGridViewFiles.SelectedRows.Count > 0)
            {
                int selected = dataGridViewFiles.SelectedRows[0].Index;
                if (selected < dataGridViewFiles.RowCount - 1)
                {
                    object val0 = dataGridViewFiles.Rows[selected].Cells[0].Value;
                    object val1 = dataGridViewFiles.Rows[selected].Cells[1].Value;
                    object val2 = dataGridViewFiles.Rows[selected].Cells[2].Value;
                    object val3 = dataGridViewFiles.Rows[selected].Cells[3].Value;
                    object val4 = dataGridViewFiles.Rows[selected].Cells[4].Value;

                    dataGridViewFiles.Rows[selected].Cells[0].Value = dataGridViewFiles.Rows[selected + 1].Cells[0].Value;
                    dataGridViewFiles.Rows[selected].Cells[1].Value = dataGridViewFiles.Rows[selected + 1].Cells[1].Value;
                    dataGridViewFiles.Rows[selected].Cells[2].Value = dataGridViewFiles.Rows[selected + 1].Cells[2].Value;
                    dataGridViewFiles.Rows[selected].Cells[3].Value = dataGridViewFiles.Rows[selected + 1].Cells[3].Value;
                    dataGridViewFiles.Rows[selected].Cells[4].Value = dataGridViewFiles.Rows[selected + 1].Cells[4].Value;

                    dataGridViewFiles.Rows[selected + 1].Cells[0].Value = val0;
                    dataGridViewFiles.Rows[selected + 1].Cells[1].Value = val1;
                    dataGridViewFiles.Rows[selected + 1].Cells[2].Value = val2;
                    dataGridViewFiles.Rows[selected + 1].Cells[3].Value = val3;
                    dataGridViewFiles.Rows[selected + 1].Cells[4].Value = val4;

                    dataGridViewFiles.Rows[selected + 1].Selected = true;

                    //Preview
                    PreviewExample();
                }
            }
        }

        private static Bitmap ResizeBitmap(string sourceFile, int W, int H, bool highquality)
        {
            Bitmap source = (Bitmap)Bitmap.FromFile(sourceFile);
            Bitmap workpict = new Bitmap(W, H);
            workpict.SetResolution(source.HorizontalResolution, source.VerticalResolution);
            Graphics graphics = Graphics.FromImage(workpict);
            if (highquality == false)
            {
                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                graphics.SmoothingMode = SmoothingMode.HighSpeed;
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            }
            else
            {
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            }
            Rectangle rect = new Rectangle(0, 0, W, H);
            graphics.DrawImage(source, rect);
            source.Dispose();
            graphics.Dispose();
            return workpict;
        }

        private void radioCaseNone_CheckedChanged(object sender, EventArgs e)
        {
            checkIncludeExt.Enabled = false;
            PreviewExample();
        }

        private void radioCaseUpper_CheckedChanged(object sender, EventArgs e)
        {
            checkIncludeExt.Enabled = true;
            PreviewExample();
        }

        private void radioCaseLower_CheckedChanged(object sender, EventArgs e)
        {
            checkIncludeExt.Enabled = true;
            PreviewExample();
        }

        private void radioCaseFirst_CheckedChanged(object sender, EventArgs e)
        {
            checkIncludeExt.Enabled = true;
            PreviewExample();
        }

        private void checkExtension_CheckedChanged(object sender, EventArgs e)
        {
            if (checkExtension.Checked)
                textExtension.Enabled = true;
            else
                textExtension.Enabled = false;
            PreviewExample();
        }

        private void radioDisabled_CheckedChanged(object sender, EventArgs e)
        {
            textFilename.Enabled = false;
            numericIndex.Enabled = false;
            textStart.Enabled = false;
            PreviewExample();
        }

        private void checkIncludeExt_CheckedChanged(object sender, EventArgs e)
        {
            PreviewExample();
        }

        private void checkExtension_Click(object sender, EventArgs e)
        {
            if (checkExtension.Checked)
            {
                MessageBox.Show("This operation will not convert the file to specified extension.\nThis will only change the extension's characters that could become unusable.", "Extension information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
