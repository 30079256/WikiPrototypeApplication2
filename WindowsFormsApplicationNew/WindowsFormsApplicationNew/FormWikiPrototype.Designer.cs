namespace WindowsFormsApplicationNew
{
    partial class FormWikiPrototype
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.GroupBoxStructure = new System.Windows.Forms.GroupBox();
            this.RadioButtonNonLinear = new System.Windows.Forms.RadioButton();
            this.RadioButtonLinear = new System.Windows.Forms.RadioButton();
            this.LabelDefinition = new System.Windows.Forms.Label();
            this.TextBoxDefinition = new System.Windows.Forms.TextBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ListViewDataStructures = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabelFeedback = new System.Windows.Forms.ToolStripStatusLabel();
            this.GroupBoxStructure.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(28, 24);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(139, 20);
            this.TextBoxSearch.TabIndex = 0;
            this.TextBoxSearch.Click += new System.EventHandler(this.TextBoxName_DoubleClick);
            this.TextBoxSearch.MouseEnter += new System.EventHandler(this.TextBox_Enter);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(174, 24);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 1;
            this.ButtonSearch.Text = "SEARCH";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(25, 76);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(35, 13);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Name";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(87, 73);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(162, 20);
            this.TextBoxName.TabIndex = 0;
            this.TextBoxName.Click += new System.EventHandler(this.TextBox_Enter);
            this.TextBoxName.DoubleClick += new System.EventHandler(this.TextBoxName_DoubleClick);
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Location = new System.Drawing.Point(25, 112);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(49, 13);
            this.LabelCategory.TabIndex = 4;
            this.LabelCategory.Text = "Category";
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Location = new System.Drawing.Point(87, 109);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(162, 21);
            this.ComboBoxCategory.TabIndex = 5;
            // 
            // GroupBoxStructure
            // 
            this.GroupBoxStructure.Controls.Add(this.RadioButtonNonLinear);
            this.GroupBoxStructure.Controls.Add(this.RadioButtonLinear);
            this.GroupBoxStructure.Location = new System.Drawing.Point(87, 136);
            this.GroupBoxStructure.Name = "GroupBoxStructure";
            this.GroupBoxStructure.Size = new System.Drawing.Size(110, 72);
            this.GroupBoxStructure.TabIndex = 6;
            this.GroupBoxStructure.TabStop = false;
            this.GroupBoxStructure.Text = "Structure";
            // 
            // RadioButtonNonLinear
            // 
            this.RadioButtonNonLinear.AutoSize = true;
            this.RadioButtonNonLinear.Location = new System.Drawing.Point(24, 44);
            this.RadioButtonNonLinear.Name = "RadioButtonNonLinear";
            this.RadioButtonNonLinear.Size = new System.Drawing.Size(77, 17);
            this.RadioButtonNonLinear.TabIndex = 1;
            this.RadioButtonNonLinear.TabStop = true;
            this.RadioButtonNonLinear.Text = "Non-Linear";
            this.RadioButtonNonLinear.UseVisualStyleBackColor = true;
            // 
            // RadioButtonLinear
            // 
            this.RadioButtonLinear.AutoSize = true;
            this.RadioButtonLinear.Checked = true;
            this.RadioButtonLinear.Location = new System.Drawing.Point(24, 20);
            this.RadioButtonLinear.Name = "RadioButtonLinear";
            this.RadioButtonLinear.Size = new System.Drawing.Size(54, 17);
            this.RadioButtonLinear.TabIndex = 0;
            this.RadioButtonLinear.TabStop = true;
            this.RadioButtonLinear.Text = "Linear";
            this.RadioButtonLinear.UseVisualStyleBackColor = true;
            // 
            // LabelDefinition
            // 
            this.LabelDefinition.AutoSize = true;
            this.LabelDefinition.Location = new System.Drawing.Point(25, 217);
            this.LabelDefinition.Name = "LabelDefinition";
            this.LabelDefinition.Size = new System.Drawing.Size(51, 13);
            this.LabelDefinition.TabIndex = 7;
            this.LabelDefinition.Text = "Definition";
            // 
            // TextBoxDefinition
            // 
            this.TextBoxDefinition.Location = new System.Drawing.Point(87, 214);
            this.TextBoxDefinition.Multiline = true;
            this.TextBoxDefinition.Name = "TextBoxDefinition";
            this.TextBoxDefinition.Size = new System.Drawing.Size(197, 147);
            this.TextBoxDefinition.TabIndex = 8;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(28, 376);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 9;
            this.ButtonAdd.Text = "ADD";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(111, 375);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 10;
            this.ButtonEdit.Text = "EDIT";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(192, 375);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 11;
            this.ButtonDelete.Text = "DELETE";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ListViewDataStructures
            // 
            this.ListViewDataStructures.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderCategory});
            this.ListViewDataStructures.HideSelection = false;
            this.ListViewDataStructures.Location = new System.Drawing.Point(303, 24);
            this.ListViewDataStructures.Name = "ListViewDataStructures";
            this.ListViewDataStructures.Size = new System.Drawing.Size(243, 337);
            this.ListViewDataStructures.TabIndex = 12;
            this.ListViewDataStructures.UseCompatibleStateImageBehavior = false;
            this.ListViewDataStructures.View = System.Windows.Forms.View.Details;
            this.ListViewDataStructures.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewDataStructures_MouseClick);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 127;
            // 
            // columnHeaderCategory
            // 
            this.columnHeaderCategory.Text = "Category";
            this.columnHeaderCategory.Width = 161;
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(390, 375);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpen.TabIndex = 13;
            this.ButtonOpen.Text = "LOAD";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(471, 375);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 14;
            this.ButtonSave.Text = "SAVE";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabelFeedback});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(570, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStripFeedback";
            // 
            // ToolStripStatusLabelFeedback
            // 
            this.ToolStripStatusLabelFeedback.Name = "ToolStripStatusLabelFeedback";
            this.ToolStripStatusLabelFeedback.Size = new System.Drawing.Size(0, 17);
            // 
            // FormWikiPrototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.ListViewDataStructures);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxDefinition);
            this.Controls.Add(this.LabelDefinition);
            this.Controls.Add(this.GroupBoxStructure);
            this.Controls.Add(this.ComboBoxCategory);
            this.Controls.Add(this.LabelCategory);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Name = "FormWikiPrototype";
            this.Text = "Wiki Prototype Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWikiPrototype_FormClosing);
            this.Load += new System.EventHandler(this.FormWikiPrototype_Load);
            this.GroupBoxStructure.ResumeLayout(false);
            this.GroupBoxStructure.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.ComboBox ComboBoxCategory;
        private System.Windows.Forms.GroupBox GroupBoxStructure;
        private System.Windows.Forms.RadioButton RadioButtonNonLinear;
        private System.Windows.Forms.RadioButton RadioButtonLinear;
        private System.Windows.Forms.Label LabelDefinition;
        private System.Windows.Forms.TextBox TextBoxDefinition;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.ListView ListViewDataStructures;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderCategory;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabelFeedback;
    }
}

