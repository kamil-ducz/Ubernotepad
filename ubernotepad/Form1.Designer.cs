namespace ubernotepad
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.radioPanel = new System.Windows.Forms.Panel();
            this.radioDefault = new System.Windows.Forms.RadioButton();
            this.radioMagnolia = new System.Windows.Forms.RadioButton();
            this.radioBlue = new System.Windows.Forms.RadioButton();
            this.saveAsButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanWholeCodeBlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.filePath = new System.Windows.Forms.TextBox();
            this.northwindDataSet = new ubernotepad.NorthwindDataSet();
            this.showRecord = new System.Windows.Forms.Button();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new ubernotepad.NorthwindDataSetTableAdapters.ProductsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showRecord2 = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.customSaveButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.dbLabel = new System.Windows.Forms.Label();
            this.recipientTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.radioPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioPanel
            // 
            this.radioPanel.Controls.Add(this.radioDefault);
            this.radioPanel.Controls.Add(this.radioMagnolia);
            this.radioPanel.Controls.Add(this.radioBlue);
            this.radioPanel.Location = new System.Drawing.Point(748, 28);
            this.radioPanel.Name = "radioPanel";
            this.radioPanel.Size = new System.Drawing.Size(120, 119);
            this.radioPanel.TabIndex = 3;
            // 
            // radioDefault
            // 
            this.radioDefault.AutoSize = true;
            this.radioDefault.Location = new System.Drawing.Point(18, 15);
            this.radioDefault.Name = "radioDefault";
            this.radioDefault.Size = new System.Drawing.Size(59, 17);
            this.radioDefault.TabIndex = 3;
            this.radioDefault.TabStop = true;
            this.radioDefault.Text = "Default";
            this.radioDefault.UseVisualStyleBackColor = true;
            this.radioDefault.CheckedChanged += new System.EventHandler(this.radioDefault_CheckedChanged_1);
            // 
            // radioMagnolia
            // 
            this.radioMagnolia.AutoSize = true;
            this.radioMagnolia.Location = new System.Drawing.Point(18, 62);
            this.radioMagnolia.Name = "radioMagnolia";
            this.radioMagnolia.Size = new System.Drawing.Size(68, 17);
            this.radioMagnolia.TabIndex = 2;
            this.radioMagnolia.TabStop = true;
            this.radioMagnolia.Text = "Magnolia";
            this.radioMagnolia.UseVisualStyleBackColor = true;
            this.radioMagnolia.CheckedChanged += new System.EventHandler(this.radioMagnolia_CheckedChanged_1);
            // 
            // radioBlue
            // 
            this.radioBlue.AutoSize = true;
            this.radioBlue.Location = new System.Drawing.Point(18, 38);
            this.radioBlue.Name = "radioBlue";
            this.radioBlue.Size = new System.Drawing.Size(46, 17);
            this.radioBlue.TabIndex = 1;
            this.radioBlue.TabStop = true;
            this.radioBlue.Text = "Blue";
            this.radioBlue.UseVisualStyleBackColor = true;
            this.radioBlue.CheckedChanged += new System.EventHandler(this.radioBlue_CheckedChanged);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Location = new System.Drawing.Point(0, 0);
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(75, 23);
            this.saveAsButton.TabIndex = 8;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(0, 0);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cleanWholeCodeBlockToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.copyToolStripMenuItem.Text = "Copy whole code block";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cleanWholeCodeBlockToolStripMenuItem
            // 
            this.cleanWholeCodeBlockToolStripMenuItem.Name = "cleanWholeCodeBlockToolStripMenuItem";
            this.cleanWholeCodeBlockToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cleanWholeCodeBlockToolStripMenuItem.Text = "Clean whole code block";
            this.cleanWholeCodeBlockToolStripMenuItem.Click += new System.EventHandler(this.cleanWholeCodeBlockToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultFontToolStripMenuItem,
            this.increaseFontToolStripMenuItem,
            this.decreaseFontToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // defaultFontToolStripMenuItem
            // 
            this.defaultFontToolStripMenuItem.Name = "defaultFontToolStripMenuItem";
            this.defaultFontToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.defaultFontToolStripMenuItem.Text = "Default font";
            this.defaultFontToolStripMenuItem.Click += new System.EventHandler(this.defaultFontToolStripMenuItem_Click);
            // 
            // increaseFontToolStripMenuItem
            // 
            this.increaseFontToolStripMenuItem.Name = "increaseFontToolStripMenuItem";
            this.increaseFontToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.increaseFontToolStripMenuItem.Text = "Increase font";
            this.increaseFontToolStripMenuItem.Click += new System.EventHandler(this.increaseFontToolStripMenuItem_Click);
            // 
            // decreaseFontToolStripMenuItem
            // 
            this.decreaseFontToolStripMenuItem.Name = "decreaseFontToolStripMenuItem";
            this.decreaseFontToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.decreaseFontToolStripMenuItem.Text = "Decrease font";
            this.decreaseFontToolStripMenuItem.Click += new System.EventHandler(this.decreaseFontToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainTextBox
            // 
            this.mainTextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainTextBox.Location = new System.Drawing.Point(24, 139);
            this.mainTextBox.MaximumSize = new System.Drawing.Size(600, 600);
            this.mainTextBox.Multiline = true;
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(517, 239);
            this.mainTextBox.TabIndex = 13;
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(13, 28);
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(716, 20);
            this.filePath.TabIndex = 14;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showRecord
            // 
            this.showRecord.Location = new System.Drawing.Point(847, 632);
            this.showRecord.Name = "showRecord";
            this.showRecord.Size = new System.Drawing.Size(129, 40);
            this.showRecord.TabIndex = 17;
            this.showRecord.Text = "Show Products";
            this.showRecord.UseVisualStyleBackColor = true;
            this.showRecord.Click += new System.EventHandler(this.showRecord_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.northwindDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 478);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1024, 758);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 344);
            this.dataGridView1.TabIndex = 18;
            // 
            // showRecord2
            // 
            this.showRecord2.Location = new System.Drawing.Point(847, 534);
            this.showRecord2.Name = "showRecord2";
            this.showRecord2.Size = new System.Drawing.Size(129, 51);
            this.showRecord2.TabIndex = 19;
            this.showRecord2.Text = "Show Orders";
            this.showRecord2.UseVisualStyleBackColor = true;
            this.showRecord2.Click += new System.EventHandler(this.showRecord2_Click);
            // 
            // newButton
            // 
            this.newButton.Image = global::ubernotepad.Properties.Resources._new;
            this.newButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newButton.Location = new System.Drawing.Point(13, 54);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(36, 36);
            this.newButton.TabIndex = 20;
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // customSaveButton
            // 
            this.customSaveButton.Image = global::ubernotepad.Properties.Resources.save_as_template_256;
            this.customSaveButton.Location = new System.Drawing.Point(139, 54);
            this.customSaveButton.Name = "customSaveButton";
            this.customSaveButton.Size = new System.Drawing.Size(36, 36);
            this.customSaveButton.TabIndex = 12;
            this.customSaveButton.UseVisualStyleBackColor = true;
            this.customSaveButton.Click += new System.EventHandler(this.customSaveButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Image = global::ubernotepad.Properties.Resources.save;
            this.saveButton.Location = new System.Drawing.Point(97, 54);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(36, 36);
            this.saveButton.TabIndex = 11;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openButton
            // 
            this.openButton.Image = global::ubernotepad.Properties.Resources.open_file_icon;
            this.openButton.Location = new System.Drawing.Point(55, 54);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(36, 36);
            this.openButton.TabIndex = 10;
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // dbLabel
            // 
            this.dbLabel.AutoSize = true;
            this.dbLabel.Font = new System.Drawing.Font("Webdings", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.dbLabel.Location = new System.Drawing.Point(214, 418);
            this.dbLabel.Name = "dbLabel";
            this.dbLabel.Size = new System.Drawing.Size(492, 30);
            this.dbLabel.TabIndex = 21;
            this.dbLabel.Text = "Northind Database";
            this.dbLabel.Click += new System.EventHandler(this.dbLabel_Click);
            // 
            // recipientTextBox
            // 
            this.recipientTextBox.Location = new System.Drawing.Point(547, 224);
            this.recipientTextBox.Name = "recipientTextBox";
            this.recipientTextBox.Size = new System.Drawing.Size(243, 20);
            this.recipientTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "WORKFIELD";
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.Location = new System.Drawing.Point(619, 250);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(75, 23);
            this.sendEmailButton.TabIndex = 24;
            this.sendEmailButton.Text = "Send";
            this.sendEmailButton.UseVisualStyleBackColor = true;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(616, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Email Address";
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(901, 28);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 26;
            this.restartButton.Text = "Logout";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sendEmailButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recipientTextBox);
            this.Controls.Add(this.dbLabel);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.showRecord2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showRecord);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.customSaveButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.saveAsButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.radioPanel);
            this.Name = "MainForm";
            this.Text = "mainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.radioPanel.ResumeLayout(false);
            this.radioPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel radioPanel;
        private System.Windows.Forms.RadioButton radioMagnolia;
        private System.Windows.Forms.RadioButton radioBlue;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button saveAsButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button customSaveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.RadioButton radioDefault;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.ToolStripMenuItem cleanWholeCodeBlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseFontToolStripMenuItem;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.Button showRecord;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private NorthwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showRecord2;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Label dbLabel;
        private System.Windows.Forms.TextBox recipientTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button restartButton;
    }
}

