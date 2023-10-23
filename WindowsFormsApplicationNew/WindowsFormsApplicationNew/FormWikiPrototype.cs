using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

/* Student Name: Olga Selezneva
 * Student ID: 30079256
 * Date: 23/10/2023
 */

namespace WindowsFormsApplicationNew
{
    public partial class FormWikiPrototype : Form
    {
        public FormWikiPrototype()
        {
            InitializeComponent();
        }
        //6.2 Create a global List<T> of type Information called Wiki.
        List<Information> Wiki = new List<Information>();

        #region ADD
        //6.3 Create a button method to ADD a new item to the list.
        //Use a TextBox for the Name input, ComboBox for the Category,
        //Radio group for the Structure and Multiline TextBox for the Definition.
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxName.Text))
            {           

                if (ValidName(TextBoxName.Text))
                {
                    Information addItem = new Information();
                    addItem.SetName(TextBoxName.Text);
                    addItem.SetCategory(ComboBoxCategory.Text);
                    addItem.SetStructure(GetStructureRadioButton());
                    addItem.SetDefinition(TextBoxDefinition.Text);
                    Wiki.Add(addItem);
                    DisplayDataStructures();
                } else ToolStripStatusLabelFeedback.Text = "Error: Duplicate name";
            }
            else
            {
                ToolStripStatusLabelFeedback.Text = "Error: Empty textbox";
            }
            ClearInput();            
        }
        #endregion
        #region RADIO BUTTON
        //6.6 Create two methods to highlight and return the values from the Radio button GroupBox.
        //The first method must return a string value from the selected radio button (Linear or Non-Linear).
        //The second method must send an integer index which will highlight an appropriate radio button.
        private string GetStructureRadioButton()
        {
            string rbStructureValue = "";
            foreach (RadioButton rbStructure in GroupBoxStructure.Controls.OfType<RadioButton>())
            {
                if (rbStructure.Checked)
                {
                    rbStructureValue = rbStructure.Text;                    
                }                
            }
            return rbStructureValue; 
        }

        private void SetStructureRadioButton(int item)
        {
            foreach (RadioButton rb in GroupBoxStructure.Controls.OfType<RadioButton>()) 
            {
                if (rb.Text == Wiki[item].GetStructure())
                {
                    rb.Checked = true;
                }
                else
                {
                    rb.Checked = false;
                }
                    
            }
        }
        #endregion
        #region DISPLAY
        //6.9 Create a single custom method that will sort and then display
        //the Name and Category from the wiki information in the list.
        private void DisplayDataStructures()
        {
            ListViewDataStructures.Items.Clear();
            Wiki.Sort();
            foreach (var infoItem in Wiki)
            {
                ListViewItem item = new ListViewItem(infoItem.GetName());
                item.SubItems.Add(infoItem.GetCategory());
                ListViewDataStructures.Items.Add(item);
            }
        }
        #endregion
        #region FORM LOAD
        //6.4 Create a custom method to populate the ComboBox when the Form Load method is called.
        //The six categories must be read from a simple text file.
        private void FormWikiPrototype_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            ComboBoxCategory.Items.AddRange(System.IO.File.ReadAllLines(@"categories.txt"));
            ComboBoxCategory.SelectedIndex = 0;
        }
        #endregion
        #region VALID NAME
        //6.5 Create a custom ValidName method which will take a parameter string value
        //from the Textbox Name and returns a Boolean after checking for duplicates.
        //Use the built in List<T> method “Exists” to answer this requirement.
        private bool ValidName(string checkName)
        {
            bool validName = !Wiki.Exists(infoItem => infoItem.GetName() == checkName);
            Trace.WriteLine(checkName + " is a valid name: " + validName);
            return validName;
        }
        #endregion
        #region DELETE
        //6.7 Create a button method that will delete the currently selected record in the ListView.
        //Ensure the user has the option to backout of this action by using a dialog box.
        //Display an updated version of the sorted list at the end of this process.
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxName.Text))
            {
                int selectedItem = ListViewDataStructures.SelectedIndices[0];
                DialogResult result = MessageBox.Show("Delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Wiki.RemoveAt(selectedItem);
                    DisplayDataStructures();
                    ToolStripStatusLabelFeedback.Text = "Record deleted";
                    Trace.WriteLine("User selected Yes in the dialog box. Record deleted at index " + selectedItem);
                }
                else
                {
                    ToolStripStatusLabelFeedback.Text = "Record not deleted";
                    Trace.WriteLine("User selected No in the dialog box. Record not deleted");
                }
            }
            else
            {
                ToolStripStatusLabelFeedback.Text = "Error: No record selected"; 
                Trace.WriteLine("Record not selected");
            }
            ClearInput();
            TextBoxName.Focus();
        }
        #endregion
        #region SELECT
        //6.11 Create a ListView event so a user can select a Data Structure Name from the list of Names
        //and the associated information will be displayed in the related text boxes combo box and radio button.
        private void ListViewDataStructures_MouseClick(object sender, MouseEventArgs e)
        {
            int selectedItem = ListViewDataStructures.SelectedIndices[0]; 
            ToolStripStatusLabelFeedback.Text = "";
 
            TextBoxName.Text = Wiki[selectedItem].GetName();
            ComboBoxCategory.Text = Wiki[selectedItem].GetCategory();
            SetStructureRadioButton(selectedItem);
            TextBoxDefinition.Text = Wiki[selectedItem].GetDefinition();
        }
        #endregion
        #region CLEAR
        //6.12 Create a custom method that will clear and reset the TextBoxes, ComboBox and Radio button
        private void ClearInput()
        {
            TextBoxName.Clear();
            ComboBoxCategory.SelectedIndex = 0;
            RadioButtonNonLinear.Checked = false;
            RadioButtonLinear.Checked = true;
            TextBoxDefinition.Clear();
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            ToolStripStatusLabelFeedback.Text = "";
        }
        #endregion
        #region EDIT
        //6.8 Create a button method that will save the edited record of the currently selected item in the ListView.
        //All the changes in the input controls will be written back to the list.
        //Display an updated version of the sorted list at the end of this process.
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxName.Text))
            {
                int selectedItem = ListViewDataStructures.SelectedIndices[0];
                Wiki[selectedItem].SetName(TextBoxName.Text);
                Wiki[selectedItem].SetCategory(ComboBoxCategory.Text);
                Wiki[selectedItem].SetStructure(GetStructureRadioButton());
                Wiki[selectedItem].SetDefinition(TextBoxDefinition.Text);
                ClearInput();
                DisplayDataStructures();
                Trace.WriteLine("Record edited at index " + selectedItem);
            }
            else
            {
                ToolStripStatusLabelFeedback.Text = "Error: No record selected";
                Trace.WriteLine("Record not selected");
            }
        }
        #endregion
        #region DOUBLE CLICK
        //6.13 Create a double click event on the Name TextBox to clear the TextBboxes, ComboBox and Radio button.
        private void TextBoxName_DoubleClick(object sender, EventArgs e)
        {
            ClearInput();
        }
        #endregion
        #region SEARCH
        //6.10 Create a button method that will use the builtin binary search to find a Data Structure name.
        //If the record is found the associated details will populate the appropriate input controls and
        //highlight the name in the ListView. At the end of the search process the search input TextBox must be cleared.
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            ClearInput();
 
            if (!string.IsNullOrEmpty(TextBoxSearch.Text))
            {
                Information searchItem = new Information();
                searchItem.SetName(TextBoxSearch.Text);
                int found = Wiki.BinarySearch(searchItem);
                if (found >= 0)
                {
                    ListViewDataStructures.SelectedItems.Clear();
                    ListViewDataStructures.Items[found].Selected = true;
                    ListViewDataStructures.Focus();
                    TextBoxName.Text = Wiki[found].GetName();
                    ComboBoxCategory.Text = Wiki[found].GetCategory();
                    SetStructureRadioButton(found);
                    TextBoxDefinition.Text = Wiki[found].GetDefinition();
                    ToolStripStatusLabelFeedback.Text = "Found";
                }
                else
                {
                    ToolStripStatusLabelFeedback.Text = "Not found";                    
                }
            }
            else
            {
                ToolStripStatusLabelFeedback.Text = "Error: No search input";
 
            }
            TextBoxSearch.Clear();
            TextBoxSearch.Focus();
        }
        #endregion
        #region OPEN AND SAVE
        //6.14 Create two buttons for the manual open and save option;
        //this must use a dialog box to select a file or rename a saved file.
        //All Wiki data is stored/retrieved using a binary reader/writer file format.
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            ToolStripStatusLabelFeedback.Text = "";
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "bin file |*.bin";
            saveFile.Title = "Save data structures to a binary file";
            saveFile.InitialDirectory = Application.StartupPath;
            saveFile.DefaultExt = "bin";
            DialogResult result = saveFile.ShowDialog();
            string fileName = "DataStructures.bin";
                     
            if (result == DialogResult.Cancel)
            {
                SaveRecord(fileName);
            }
            if (result == DialogResult.OK)
            {
                SaveRecord(saveFile.FileName);
            }  
        }

        private void SaveRecord(string saveFileName)
        {
            try
            {
                using (var stream = File.Open(saveFileName, FileMode.Create))
                {
                    using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                    {
                        foreach (var item in Wiki)
                        {
                            writer.Write(item.GetName());
                            writer.Write(item.GetCategory());
                            writer.Write(item.GetStructure());
                            writer.Write(item.GetDefinition());
                        }
                    }
                }
            }
            catch (IOException)
            {
                ToolStripStatusLabelFeedback.Text = "Error: Failed to save file";
            }
        }
        
        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            ToolStripStatusLabelFeedback.Text = "";
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Application.StartupPath;
            openFile.Filter = "BIN |*.bin";
            openFile.Title = "Open a BIN file";
            string fileName = "DataStructures.bin";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName = openFile.FileName;
            }
            try
            {
                Wiki.Clear();
                using (Stream stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        while (stream.Position < stream.Length)
                        {
                            Information item = new Information();
                            item.SetName(reader.ReadString());
                            item.SetCategory(reader.ReadString());
                            item.SetStructure(reader.ReadString());
                            item.SetDefinition(reader.ReadString());
                            Wiki.Add(item);
                        }
                    }
                }
                DisplayDataStructures();
            }
            catch (IOException)
            {
                ToolStripStatusLabelFeedback.Text = "Error: Failed to open file";
            }
        }
        #endregion
        #region FORM CLOSE
        //6.15 The Wiki application will save data when the form closes. 
        private void FormWikiPrototype_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveRecord("DataStructures.bin");
        }
        #endregion      

    }
}
