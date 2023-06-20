namespace WinForm_Phonebook
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
            this.personGrid = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblMobilePhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtWorkPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblWorkPhone = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMobileDisplay = new System.Windows.Forms.TextBox();
            this.txtAddressDisplay = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchDisplay = new System.Windows.Forms.TextBox();
            this.lblSearchHeader = new System.Windows.Forms.Label();
            this.lblSearchAddress = new System.Windows.Forms.Label();
            this.lblSearchMobile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // personGrid
            // 
            this.personGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personGrid.Location = new System.Drawing.Point(544, 209);
            this.personGrid.Name = "personGrid";
            this.personGrid.RowHeadersWidth = 82;
            this.personGrid.RowTemplate.Height = 33;
            this.personGrid.Size = new System.Drawing.Size(767, 299);
            this.personGrid.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Cooper Black", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(803, 74);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(291, 61);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Directory";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(453, 365);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 46);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.lblMobilePhone);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.txtMobilePhone);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtWorkPhone);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblWorkPhone);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Location = new System.Drawing.Point(268, 572);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 482);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(256, 195);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(358, 31);
            this.txtAddress.TabIndex = 8;
            // 
            // lblMobilePhone
            // 
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.BackColor = System.Drawing.Color.White;
            this.lblMobilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobilePhone.Location = new System.Drawing.Point(32, 246);
            this.lblMobilePhone.Name = "lblMobilePhone";
            this.lblMobilePhone.Size = new System.Drawing.Size(186, 31);
            this.lblMobilePhone.TabIndex = 10;
            this.lblMobilePhone.Text = "Mobile Phone:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.White;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(32, 195);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(122, 31);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address:";
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Location = new System.Drawing.Point(256, 246);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(358, 31);
            this.txtMobilePhone.TabIndex = 6;
            this.txtMobilePhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtMobilePhone_Validating);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(453, 417);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 46);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.Location = new System.Drawing.Point(256, 144);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(358, 31);
            this.txtWorkPhone.TabIndex = 7;
            this.txtWorkPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtWorkPhone_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(256, 93);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(358, 31);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(256, 43);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(358, 31);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.BackColor = System.Drawing.Color.White;
            this.lblWorkPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkPhone.Location = new System.Drawing.Point(32, 144);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(170, 31);
            this.lblWorkPhone.TabIndex = 3;
            this.lblWorkPhone.Text = "Work Phone:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.White;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(32, 93);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(153, 31);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.White;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(32, 43);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(155, 31);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMobileDisplay);
            this.groupBox2.Controls.Add(this.txtAddressDisplay);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtSearchDisplay);
            this.groupBox2.Controls.Add(this.lblSearchHeader);
            this.groupBox2.Controls.Add(this.lblSearchAddress);
            this.groupBox2.Controls.Add(this.lblSearchMobile);
            this.groupBox2.Location = new System.Drawing.Point(962, 572);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 482);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // txtMobileDisplay
            // 
            this.txtMobileDisplay.Location = new System.Drawing.Point(235, 412);
            this.txtMobileDisplay.Name = "txtMobileDisplay";
            this.txtMobileDisplay.Size = new System.Drawing.Size(358, 31);
            this.txtMobileDisplay.TabIndex = 13;
            // 
            // txtAddressDisplay
            // 
            this.txtAddressDisplay.Location = new System.Drawing.Point(235, 365);
            this.txtAddressDisplay.Name = "txtAddressDisplay";
            this.txtAddressDisplay.Size = new System.Drawing.Size(358, 31);
            this.txtAddressDisplay.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(252, 166);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 46);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchDisplay
            // 
            this.txtSearchDisplay.Location = new System.Drawing.Point(150, 120);
            this.txtSearchDisplay.Name = "txtSearchDisplay";
            this.txtSearchDisplay.Size = new System.Drawing.Size(358, 31);
            this.txtSearchDisplay.TabIndex = 10;
            // 
            // lblSearchHeader
            // 
            this.lblSearchHeader.AutoSize = true;
            this.lblSearchHeader.BackColor = System.Drawing.Color.DarkGray;
            this.lblSearchHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchHeader.Location = new System.Drawing.Point(144, 27);
            this.lblSearchHeader.Name = "lblSearchHeader";
            this.lblSearchHeader.Size = new System.Drawing.Size(384, 31);
            this.lblSearchHeader.TabIndex = 9;
            this.lblSearchHeader.Text = "Search Personal Information";
            // 
            // lblSearchAddress
            // 
            this.lblSearchAddress.AutoSize = true;
            this.lblSearchAddress.BackColor = System.Drawing.Color.White;
            this.lblSearchAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAddress.Location = new System.Drawing.Point(28, 365);
            this.lblSearchAddress.Name = "lblSearchAddress";
            this.lblSearchAddress.Size = new System.Drawing.Size(122, 31);
            this.lblSearchAddress.TabIndex = 4;
            this.lblSearchAddress.Text = "Address:";
            // 
            // lblSearchMobile
            // 
            this.lblSearchMobile.AutoSize = true;
            this.lblSearchMobile.BackColor = System.Drawing.Color.White;
            this.lblSearchMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMobile.Location = new System.Drawing.Point(28, 412);
            this.lblSearchMobile.Name = "lblSearchMobile";
            this.lblSearchMobile.Size = new System.Drawing.Size(186, 31);
            this.lblSearchMobile.TabIndex = 2;
            this.lblSearchMobile.Text = "Mobile Phone:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1909, 1193);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.personGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView personGrid;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtWorkPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSearchAddress;
        private System.Windows.Forms.Label lblWorkPhone;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSearchHeader;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.Label lblSearchMobile;
        private System.Windows.Forms.Label lblMobilePhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchDisplay;
        private System.Windows.Forms.TextBox txtMobileDisplay;
        private System.Windows.Forms.TextBox txtAddressDisplay;
    }
}

