using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word; // Скорочене ім'я для Microsoft.Office.Interop.Word

namespace DocTemplateGen
{
    public partial class MainForm : Form
    {
        private Word.Application wordApp;
        private List<string> templates;

        public MainForm()
        {
            InitializeComponent();
            wordApp = new Word.Application();
            templates = new List<string>();

            LoadTemplates();
        }

        private void LoadTemplates()
        {
            // Припустимо, що шаблони зберігаються в папці "Templates" в корені проекту
            string templatePath = @"D:\my project vs\DocTemplateGen\DocTemplateGen\Templates";
            if (Directory.Exists(templatePath))
            {
                templates.AddRange(Directory.GetFiles(templatePath, "*.dotx"));
                listBoxTemplates.DataSource = templates;
            }
            else
            {
                MessageBox.Show("Шаблони не знайдено!");
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (listBoxTemplates.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, оберіть шаблон!");
                return;
            }

            string templateFile = listBoxTemplates.SelectedItem.ToString();
            string outputPath = txtOutputPath.Text;

            if (string.IsNullOrEmpty(outputPath))
            {
                MessageBox.Show("Будь ласка, вкажіть шлях для збереження документа!");
                return;
            }

            GenerateDocument(templateFile, outputPath);
        }

        private void GenerateDocument(string templateFile, string outputPath)
        {
            try
            {
                Word.Document doc = wordApp.Documents.Add(templateFile);
                FindAndReplace(doc, "<FIRST_NAME>", txtFirstName.Text);
                FindAndReplace(doc, "<LAST_NAME>", txtLastName.Text);
                FindAndReplace(doc, "<EMAIL>", txtEmail.Text);
                FindAndReplace(doc, "<PRODUCT_NAME>", txtProductName.Text);
                FindAndReplace(doc, "<DISCOUNT>", txtDiscount.Text);
                FindAndReplace(doc, "<EXPIRY_DATE>", txtExpiryDate.Text);

                doc.SaveAs2(outputPath);
                doc.Close();
                MessageBox.Show("Документ успішно збережено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void FindAndReplace(Word.Document doc, object findText, object replaceWithText)
        {
            foreach (Word.Range range in doc.StoryRanges)
            {
                Word.Find find = range.Find;
                find.Text = findText.ToString();
                find.Replacement.Text = replaceWithText.ToString();
                find.Execute(Replace: Word.WdReplace.wdReplaceAll);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents|*.docx",
                Title = "Збереження документа"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputPath.Text = saveFileDialog.FileName;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            wordApp.Quit();
        }
    }
}
