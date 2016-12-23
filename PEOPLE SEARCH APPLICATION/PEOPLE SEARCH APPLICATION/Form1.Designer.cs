namespace PEOPLE_SEARCH_APPLICATION
{
    partial class Form1
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
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtInterests = new System.Windows.Forms.TextBox();
            this.lblInterests = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnAddProfile = new System.Windows.Forms.Button();
            this.searchdbDataSet = new PEOPLE_SEARCH_APPLICATION.searchdbDataSet();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profileTableAdapter = new PEOPLE_SEARCH_APPLICATION.searchdbDataSetTableAdapters.ProfileTableAdapter();
            this.profileIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interestsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUploadImage.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadImage.Location = new System.Drawing.Point(17, 181);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(152, 23);
            this.btnUploadImage.TabIndex = 5;
            this.btnUploadImage.Text = "UPLOAD IMAGE";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profileIDDataGridViewTextBoxColumn,
            this.personNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.interestsDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dataGridView.DataSource = this.profileBindingSource;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView.Location = new System.Drawing.Point(15, 268);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(737, 183);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.datagridView_KeyDown);
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPersonName.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonName.Location = new System.Drawing.Point(215, 53);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(128, 18);
            this.lblPersonName.TabIndex = 2;
            this.lblPersonName.Text = "PERSON NAME:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(205, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "PEOPLE SEARCH APP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel.Controls.Add(this.txtAddress);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.lblAddress);
            this.panel.Controls.Add(this.txtInterests);
            this.panel.Controls.Add(this.lblInterests);
            this.panel.Controls.Add(this.txtPhoneNumber);
            this.panel.Controls.Add(this.lblPhoneNumber);
            this.panel.Controls.Add(this.txtAge);
            this.panel.Controls.Add(this.lblAge);
            this.panel.Controls.Add(this.txtPersonName);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.btnUploadImage);
            this.panel.Controls.Add(this.lblPersonName);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(-2, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(754, 225);
            this.panel.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profileBindingSource, "Address", true));
            this.txtAddress.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(377, 163);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(377, 36);
            this.txtAddress.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddress.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(215, 168);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(86, 18);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "ADDRESS:";
            // 
            // txtInterests
            // 
            this.txtInterests.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtInterests.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profileBindingSource, "Interests", true));
            this.txtInterests.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInterests.Location = new System.Drawing.Point(377, 128);
            this.txtInterests.Multiline = true;
            this.txtInterests.Name = "txtInterests";
            this.txtInterests.Size = new System.Drawing.Size(377, 29);
            this.txtInterests.TabIndex = 3;
            // 
            // lblInterests
            // 
            this.lblInterests.AutoSize = true;
            this.lblInterests.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInterests.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterests.Location = new System.Drawing.Point(215, 131);
            this.lblInterests.Name = "lblInterests";
            this.lblInterests.Size = new System.Drawing.Size(99, 18);
            this.lblInterests.TabIndex = 10;
            this.lblInterests.Text = "INTERESTS:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profileBindingSource, "PhoneNumber", true));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(377, 102);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(377, 25);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(215, 105);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(145, 18);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "PHONE NUMBER:";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAge.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profileBindingSource, "Age", true));
            this.txtAge.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(377, 76);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(377, 25);
            this.txtAge.TabIndex = 1;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAge.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(215, 79);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(46, 18);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "AGE:";
            // 
            // txtPersonName
            // 
            this.txtPersonName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPersonName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profileBindingSource, "PersonName", true));
            this.txtPersonName.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonName.Location = new System.Drawing.Point(377, 50);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(377, 25);
            this.txtPersonName.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.profileBindingSource, "Image", true));
            this.pictureBox.Location = new System.Drawing.Point(2, 1);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(197, 174);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSearch.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(93, 234);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(659, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSearch.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 237);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 18);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "SEARCH:";
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveProfile.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProfile.Location = new System.Drawing.Point(663, 457);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(89, 23);
            this.btnSaveProfile.TabIndex = 5;
            this.btnSaveProfile.Text = "Save Profile";
            this.btnSaveProfile.UseVisualStyleBackColor = false;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelEdit.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.Location = new System.Drawing.Point(582, 457);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCancelEdit.TabIndex = 4;
            this.btnCancelEdit.Text = "Cancel Edit";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditProfile.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProfile.Location = new System.Drawing.Point(491, 457);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(85, 23);
            this.btnEditProfile.TabIndex = 3;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnAddProfile
            // 
            this.btnAddProfile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProfile.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProfile.Location = new System.Drawing.Point(410, 457);
            this.btnAddProfile.Name = "btnAddProfile";
            this.btnAddProfile.Size = new System.Drawing.Size(75, 23);
            this.btnAddProfile.TabIndex = 2;
            this.btnAddProfile.Text = "Add Profile";
            this.btnAddProfile.UseVisualStyleBackColor = false;
            this.btnAddProfile.Click += new System.EventHandler(this.btnAddProfile_Click);
            // 
            // searchdbDataSet
            // 
            this.searchdbDataSet.DataSetName = "searchdbDataSet";
            this.searchdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profileBindingSource
            // 
            this.profileBindingSource.DataMember = "Profile";
            this.profileBindingSource.DataSource = this.searchdbDataSet;
            // 
            // profileTableAdapter
            // 
            this.profileTableAdapter.ClearBeforeFill = true;
            // 
            // profileIDDataGridViewTextBoxColumn
            // 
            this.profileIDDataGridViewTextBoxColumn.DataPropertyName = "Profile_ID";
            this.profileIDDataGridViewTextBoxColumn.HeaderText = "Profile_ID";
            this.profileIDDataGridViewTextBoxColumn.Name = "profileIDDataGridViewTextBoxColumn";
            this.profileIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // personNameDataGridViewTextBoxColumn
            // 
            this.personNameDataGridViewTextBoxColumn.DataPropertyName = "PersonName";
            this.personNameDataGridViewTextBoxColumn.HeaderText = "PersonName";
            this.personNameDataGridViewTextBoxColumn.Name = "personNameDataGridViewTextBoxColumn";
            this.personNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 30;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // interestsDataGridViewTextBoxColumn
            // 
            this.interestsDataGridViewTextBoxColumn.DataPropertyName = "Interests";
            this.interestsDataGridViewTextBoxColumn.HeaderText = "Interests";
            this.interestsDataGridViewTextBoxColumn.Name = "interestsDataGridViewTextBoxColumn";
            this.interestsDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.Width = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(781, 490);
            this.Controls.Add(this.btnAddProfile);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnSaveProfile);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THE PEOPLE SEARCH APPLICATION";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtInterests;
        private System.Windows.Forms.Label lblInterests;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnAddProfile;
        private searchdbDataSet searchdbDataSet;
        private System.Windows.Forms.BindingSource profileBindingSource;
        private searchdbDataSetTableAdapters.ProfileTableAdapter profileTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn profileIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn interestsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
    }
}

