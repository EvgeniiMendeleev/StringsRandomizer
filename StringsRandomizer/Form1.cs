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

namespace StringsRandomizer
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<FileString>> files = new Dictionary<string, List<FileString>>();
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsUsedAllStringsFromFile(string nameOfFile)
        {
            foreach (FileString str in files[nameOfFile])
            {
                if (!str.isUsedString()) return false;
            }

            return true;
        }

        private void ClearAll()
        {
            comboBoxFiles.Items.Clear();
            files.Clear();
        }

        private void DeleteFilesFromDirectory(string path)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            foreach (FileInfo file in dirInfo.GetFiles()) file.Delete();
        }

        private FileString GetRandomStringFromFile(string nameOfFile)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, files[nameOfFile].Count);

            return files[nameOfFile].ElementAt(randomIndex);
        }

        private void DeleteAllLoadedDatas(object sender, EventArgs e)
        {
            if (files.Count == 0)
            {
                stateOfSystem.Text = "Данных и так нет. Что удалять - то? :/";
                return;
            }

            ClearAll();
            stateOfSystem.Text = "Все данные успешно удалены из памяти!";
        }

        private void LoadFromInputFiles(object sender, EventArgs e)
        {
            if (files.Count > 0) ClearAll();

            string[] filesNames = Directory.GetFiles("InputFiles", "*.txt");
            if (filesNames.Length == 0)
            {
                stateOfSystem.Text = "В входной папке не находится ни одного TXT файла. :(";
                return;
            }

            comboBoxFiles.Items.Add("Все файлы");
            comboBoxFiles.SelectedIndex = 0;
            foreach (string pathOfFile in filesNames)
            {
                using (StreamReader reader = new StreamReader(pathOfFile))
                {
                    List<FileString> stringsFromFile = new List<FileString>();
                    while (!reader.EndOfStream) stringsFromFile.Add(new FileString(reader.ReadLine()));

                    //TODO: Возможно, сделать сообщение о том, что файл пуст.

                    string NameOfFile = pathOfFile.Split('\\').Last<string>();

                    files.Add(NameOfFile, stringsFromFile);
                    comboBoxFiles.Items.Add(NameOfFile);

                    reader.Close();
                }
            }

            stateOfSystem.Text = "Все данные из файлов успешно загружены в память! :)";
        }

        private void WriteRandomStringToFile(string fromFile, string toFile)
        {
            FileString stringFromFile = GetRandomStringFromFile(fromFile);
            while (stringFromFile.isUsedString())
            {
                stringFromFile = GetRandomStringFromFile(fromFile);
            }
            stringFromFile.WriteToFile(toFile);
        }

        private void GenerateResult(object sender, EventArgs e)
        {
            if (comboBoxFiles.SelectedItem == null)
            {
                stateOfSystem.Text = "Не был выбран входной файл или данные не загружены в систему! :(";
                return;
            }

            int countOfOutputFiles = (int)numericCountOfOutputFiles.Value;
            string nameOfInputFile = comboBoxFiles.SelectedItem.ToString();

            if (nameOfInputFile == "Все файлы")
            {
                DeleteFilesFromDirectory("OutputFiles/FromAllFiles");

                for (int numberOfFile = 0; numberOfFile < countOfOutputFiles; numberOfFile++)
                {
                    foreach (string nameOfFile in files.Keys)
                    {
                        if (IsUsedAllStringsFromFile(nameOfFile)) continue;
                        WriteRandomStringToFile(nameOfFile, "OutputFiles/FromAllFiles/" + numberOfFile + ".txt");
                    }
                }
            }
            else
            {   
                DeleteFilesFromDirectory("OutputFiles/FromOneFile");

                for (int numberOfFile = 0; numberOfFile < countOfOutputFiles; numberOfFile++)
                {
                    if (IsUsedAllStringsFromFile(nameOfInputFile)) continue;
                    WriteRandomStringToFile(nameOfInputFile, "OutputFiles/FromOneFile/" + numberOfFile + ".txt");
                }
            }
        }
    }
}
