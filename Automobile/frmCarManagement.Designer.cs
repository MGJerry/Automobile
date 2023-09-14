namespace Automobile
{
    partial class frmCarManagement
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
            btnDelete = new Button();
            btnNew = new Button();
            txtCarName = new TextBox();
            txtCarID = new TextBox();
            lbReleaseYear = new Label();
            lbPrice = new Label();
            lbManufacturer = new Label();
            lbCarName = new Label();
            lbCarID = new Label();
            txtReleaseYear = new TextBox();
            txtPrice = new TextBox();
            txtManufacturer = new TextBox();
            btnLoad = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.DialogResult = DialogResult.Cancel;
            btnDelete.Location = new Point(566, 174);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 30);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.DialogResult = DialogResult.OK;
            btnNew.Location = new Point(360, 174);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(99, 30);
            btnNew.TabIndex = 22;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtCarName
            // 
            txtCarName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCarName.Location = new Point(143, 87);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(231, 25);
            txtCarName.TabIndex = 18;
            // 
            // txtCarID
            // 
            txtCarID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtCarID.Location = new Point(143, 43);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(231, 25);
            txtCarID.TabIndex = 17;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbReleaseYear.Location = new Point(415, 91);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(97, 21);
            lbReleaseYear.TabIndex = 16;
            lbReleaseYear.Text = "Release Year";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrice.Location = new Point(415, 47);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(44, 21);
            lbPrice.TabIndex = 15;
            lbPrice.Text = "Price";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbManufacturer.Location = new Point(26, 135);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(104, 21);
            lbManufacturer.TabIndex = 14;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCarName.Location = new Point(26, 91);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(80, 21);
            lbCarName.TabIndex = 13;
            lbCarName.Text = "Car Name";
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbCarID.Location = new Point(26, 47);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(53, 21);
            lbCarID.TabIndex = 12;
            lbCarID.Text = "Car ID";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtReleaseYear.Location = new Point(532, 87);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(231, 25);
            txtReleaseYear.TabIndex = 25;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(532, 43);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(231, 25);
            txtPrice.TabIndex = 24;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtManufacturer.Location = new Point(143, 131);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(231, 25);
            txtManufacturer.TabIndex = 26;
            // 
            // btnLoad
            // 
            btnLoad.DialogResult = DialogResult.Cancel;
            btnLoad.Location = new Point(143, 174);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(99, 30);
            btnLoad.TabIndex = 27;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(12, 210);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowTemplate.Height = 25;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(776, 197);
            dgvCarList.TabIndex = 28;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.OK;
            btnClose.Location = new Point(360, 413);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(99, 30);
            btnClose.TabIndex = 29;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnLoad);
            Controls.Add(txtManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnNew;
        private TextBox txtCarName;
        private TextBox txtCarID;
        private Label lbReleaseYear;
        private Label lbPrice;
        private Label lbManufacturer;
        private Label lbCarName;
        private Label lbCarID;
        private TextBox txtReleaseYear;
        private TextBox txtPrice;
        private TextBox txtManufacturer;
        private Button btnLoad;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}