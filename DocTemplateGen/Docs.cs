using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace DocTemplateGen
{
    public partial class MainForm : Form
    {
        private Word.Application wordApp; // Word application instance
        private List<string> templates; // List to store template file paths

        public MainForm()
        {
            InitializeComponent();
            wordApp = new Word.Application(); // Initialize Word application
            templates = new List<string>();

            LoadTemplates(); // Load templates on form initialization
        }

        // Method to load template files from the specified directory
        private void LoadTemplates()
        {
            string templatePath = @"D:\my project vs\DocTemplateGen\DocTemplateGen\Templates"; // Path to templates
            if (Directory.Exists(templatePath))
            {
                templates.AddRange(Directory.GetFiles(templatePath, "*.dotx")); // Add .dotx files to templates list
                listBoxTemplates.DataSource = templates; // Bind templates list to ListBox
            }
            else
            {
                MessageBox.Show("Templates not found!"); // Show error if directory doesn't exist
            }
        }

        // Event handler for Generate button click
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (listBoxTemplates.SelectedItem == null)
            {
                MessageBox.Show("Please select a template!"); // Show error if no template is selected
                return;
            }

            string templateFile = listBoxTemplates.SelectedItem.ToString(); // Get selected template file path
            string outputPath = txtOutputPath.Text; // Get output path from text box

            if (string.IsNullOrEmpty(outputPath))
            {
                MessageBox.Show("Please specify an output path!"); // Show error if output path is empty
                return;
            }

            GenerateDocument(templateFile, outputPath); // Call method to generate document
        }

        // Method to generate document from the selected template
        private void GenerateDocument(string templateFile, string outputPath)
        {
            try
            {
                Word.Document doc = wordApp.Documents.Add(templateFile); // Add new document from template
                // Find and replace placeholders with user input
                FindAndReplace(doc, "<FIRST_NAME>", txtFirstName.Text);
                FindAndReplace(doc, "<LAST_NAME>", txtLastName.Text);
                FindAndReplace(doc, "<EMAIL>", txtEmail.Text);
                FindAndReplace(doc, "<PRODUCT_NAME>", txtProductName.Text);
                FindAndReplace(doc, "<DISCOUNT>", txtDiscount.Text);
                FindAndReplace(doc, "<EXPIRY_DATE>", txtExpiryDate.Text);

                doc.SaveAs2(outputPath); // Save the document to the specified output path
                doc.Close(); // Close the document
                MessageBox.Show("Document saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Show error message if an exception occurs
            }
        }

        // Method to find and replace text in the document
        private void FindAndReplace(Word.Document doc, object findText, object replaceWithText)
        {
            foreach (Word.Range range in doc.StoryRanges) // Iterate through all story ranges in the document
            {
                Word.Find find = range.Find;
                find.Text = findText.ToString(); // Set text to find
                find.Replacement.Text = replaceWithText.ToString(); // Set replacement text
                find.Execute(Replace: Word.WdReplace.wdReplaceAll); // Execute find and replace
            }
        }

        // Event handler for Browse button click
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents|*.docx", // Set file filter for SaveFileDialog
                Title = "Save Document"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtOutputPath.Text = saveFileDialog.FileName; // Set output path text box to selected file path
            }
        }

        // Event handler for form closing
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            wordApp.Quit(); // Quit Word application when form is closing
        }
    }
}
