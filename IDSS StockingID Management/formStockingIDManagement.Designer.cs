namespace IDSS_StockingID_Management
{
    partial class formStockingIDManagement
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent ()
        {
            this.groupSearch = new System.Windows.Forms.GroupBox();
            this.textMM = new System.Windows.Forms.TextBox();
            this.labelMM = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboNeedTest = new System.Windows.Forms.ComboBox();
            this.labelNeedTest = new System.Windows.Forms.Label();
            this.comboHVI = new System.Windows.Forms.ComboBox();
            this.labelHVI = new System.Windows.Forms.Label();
            this.textFamily = new System.Windows.Forms.TextBox();
            this.labelFamily = new System.Windows.Forms.Label();
            this.textProductGroup = new System.Windows.Forms.TextBox();
            this.labelProductGroup = new System.Windows.Forms.Label();
            this.comboProductType = new System.Windows.Forms.ComboBox();
            this.labelProductType = new System.Windows.Forms.Label();
            this.comboBU = new System.Windows.Forms.ComboBox();
            this.labelBU = new System.Windows.Forms.Label();
            this.textProductCode = new System.Windows.Forms.TextBox();
            this.labelProductCode = new System.Windows.Forms.Label();
            this.textStockingID = new System.Windows.Forms.TextBox();
            this.labelStockingID = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridStockingIDList = new System.Windows.Forms.DataGridView();
            this.groupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStockingIDList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupSearch
            // 
            this.groupSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupSearch.Controls.Add(this.textMM);
            this.groupSearch.Controls.Add(this.labelMM);
            this.groupSearch.Controls.Add(this.buttonSearch);
            this.groupSearch.Controls.Add(this.comboNeedTest);
            this.groupSearch.Controls.Add(this.labelNeedTest);
            this.groupSearch.Controls.Add(this.comboHVI);
            this.groupSearch.Controls.Add(this.labelHVI);
            this.groupSearch.Controls.Add(this.textFamily);
            this.groupSearch.Controls.Add(this.labelFamily);
            this.groupSearch.Controls.Add(this.textProductGroup);
            this.groupSearch.Controls.Add(this.labelProductGroup);
            this.groupSearch.Controls.Add(this.comboProductType);
            this.groupSearch.Controls.Add(this.labelProductType);
            this.groupSearch.Controls.Add(this.comboBU);
            this.groupSearch.Controls.Add(this.labelBU);
            this.groupSearch.Controls.Add(this.textProductCode);
            this.groupSearch.Controls.Add(this.labelProductCode);
            this.groupSearch.Controls.Add(this.textStockingID);
            this.groupSearch.Controls.Add(this.labelStockingID);
            this.groupSearch.Location = new System.Drawing.Point(10, 10);
            this.groupSearch.Name = "groupSearch";
            this.groupSearch.Size = new System.Drawing.Size(615, 142);
            this.groupSearch.TabIndex = 2;
            this.groupSearch.TabStop = false;
            // 
            // textMM
            // 
            this.textMM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textMM.Location = new System.Drawing.Point(325, 81);
            this.textMM.Margin = new System.Windows.Forms.Padding(2);
            this.textMM.Name = "textMM";
            this.textMM.Size = new System.Drawing.Size(92, 21);
            this.textMM.TabIndex = 25;
            // 
            // labelMM
            // 
            this.labelMM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMM.AutoSize = true;
            this.labelMM.Location = new System.Drawing.Point(296, 83);
            this.labelMM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMM.Name = "labelMM";
            this.labelMM.Size = new System.Drawing.Size(23, 12);
            this.labelMM.TabIndex = 24;
            this.labelMM.Text = "MM#";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearch.Location = new System.Drawing.Point(526, 106);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 23;
            this.buttonSearch.Text = "查找";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // comboNeedTest
            // 
            this.comboNeedTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboNeedTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNeedTest.FormattingEnabled = true;
            this.comboNeedTest.Location = new System.Drawing.Point(510, 52);
            this.comboNeedTest.Margin = new System.Windows.Forms.Padding(2);
            this.comboNeedTest.Name = "comboNeedTest";
            this.comboNeedTest.Size = new System.Drawing.Size(92, 20);
            this.comboNeedTest.Sorted = true;
            this.comboNeedTest.TabIndex = 22;
            // 
            // labelNeedTest
            // 
            this.labelNeedTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNeedTest.AutoSize = true;
            this.labelNeedTest.Location = new System.Drawing.Point(428, 55);
            this.labelNeedTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNeedTest.Name = "labelNeedTest";
            this.labelNeedTest.Size = new System.Drawing.Size(59, 12);
            this.labelNeedTest.TabIndex = 21;
            this.labelNeedTest.Text = "Need Test";
            // 
            // comboHVI
            // 
            this.comboHVI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboHVI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHVI.FormattingEnabled = true;
            this.comboHVI.Location = new System.Drawing.Point(325, 52);
            this.comboHVI.Margin = new System.Windows.Forms.Padding(2);
            this.comboHVI.Name = "comboHVI";
            this.comboHVI.Size = new System.Drawing.Size(92, 20);
            this.comboHVI.Sorted = true;
            this.comboHVI.TabIndex = 20;
            // 
            // labelHVI
            // 
            this.labelHVI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHVI.AutoSize = true;
            this.labelHVI.Location = new System.Drawing.Point(296, 55);
            this.labelHVI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHVI.Name = "labelHVI";
            this.labelHVI.Size = new System.Drawing.Size(23, 12);
            this.labelHVI.TabIndex = 19;
            this.labelHVI.Text = "HVI";
            // 
            // textFamily
            // 
            this.textFamily.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textFamily.Location = new System.Drawing.Point(100, 110);
            this.textFamily.Margin = new System.Windows.Forms.Padding(2);
            this.textFamily.Name = "textFamily";
            this.textFamily.Size = new System.Drawing.Size(181, 21);
            this.textFamily.TabIndex = 18;
            // 
            // labelFamily
            // 
            this.labelFamily.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFamily.AutoSize = true;
            this.labelFamily.Location = new System.Drawing.Point(11, 112);
            this.labelFamily.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(41, 12);
            this.labelFamily.TabIndex = 17;
            this.labelFamily.Text = "Family";
            // 
            // textProductGroup
            // 
            this.textProductGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textProductGroup.Location = new System.Drawing.Point(100, 81);
            this.textProductGroup.Margin = new System.Windows.Forms.Padding(2);
            this.textProductGroup.Name = "textProductGroup";
            this.textProductGroup.Size = new System.Drawing.Size(181, 21);
            this.textProductGroup.TabIndex = 16;
            // 
            // labelProductGroup
            // 
            this.labelProductGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProductGroup.AutoSize = true;
            this.labelProductGroup.Location = new System.Drawing.Point(11, 83);
            this.labelProductGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductGroup.Name = "labelProductGroup";
            this.labelProductGroup.Size = new System.Drawing.Size(83, 12);
            this.labelProductGroup.TabIndex = 15;
            this.labelProductGroup.Text = "Product Group";
            // 
            // comboProductType
            // 
            this.comboProductType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProductType.FormattingEnabled = true;
            this.comboProductType.Location = new System.Drawing.Point(510, 24);
            this.comboProductType.Margin = new System.Windows.Forms.Padding(2);
            this.comboProductType.Name = "comboProductType";
            this.comboProductType.Size = new System.Drawing.Size(92, 20);
            this.comboProductType.Sorted = true;
            this.comboProductType.TabIndex = 14;
            // 
            // labelProductType
            // 
            this.labelProductType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProductType.AutoSize = true;
            this.labelProductType.Location = new System.Drawing.Point(428, 26);
            this.labelProductType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductType.Name = "labelProductType";
            this.labelProductType.Size = new System.Drawing.Size(77, 12);
            this.labelProductType.TabIndex = 13;
            this.labelProductType.Text = "Product Type";
            // 
            // comboBU
            // 
            this.comboBU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBU.FormattingEnabled = true;
            this.comboBU.Location = new System.Drawing.Point(325, 24);
            this.comboBU.Margin = new System.Windows.Forms.Padding(2);
            this.comboBU.Name = "comboBU";
            this.comboBU.Size = new System.Drawing.Size(92, 20);
            this.comboBU.Sorted = true;
            this.comboBU.TabIndex = 12;
            // 
            // labelBU
            // 
            this.labelBU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBU.AutoSize = true;
            this.labelBU.Location = new System.Drawing.Point(296, 26);
            this.labelBU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBU.Name = "labelBU";
            this.labelBU.Size = new System.Drawing.Size(17, 12);
            this.labelBU.TabIndex = 11;
            this.labelBU.Text = "BU";
            // 
            // textProductCode
            // 
            this.textProductCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textProductCode.Location = new System.Drawing.Point(100, 52);
            this.textProductCode.Margin = new System.Windows.Forms.Padding(2);
            this.textProductCode.Name = "textProductCode";
            this.textProductCode.Size = new System.Drawing.Size(181, 21);
            this.textProductCode.TabIndex = 10;
            // 
            // labelProductCode
            // 
            this.labelProductCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProductCode.AutoSize = true;
            this.labelProductCode.Location = new System.Drawing.Point(11, 55);
            this.labelProductCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductCode.Name = "labelProductCode";
            this.labelProductCode.Size = new System.Drawing.Size(77, 12);
            this.labelProductCode.TabIndex = 9;
            this.labelProductCode.Text = "Product Code";
            // 
            // textStockingID
            // 
            this.textStockingID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textStockingID.Location = new System.Drawing.Point(100, 24);
            this.textStockingID.Margin = new System.Windows.Forms.Padding(2);
            this.textStockingID.Name = "textStockingID";
            this.textStockingID.Size = new System.Drawing.Size(181, 21);
            this.textStockingID.TabIndex = 8;
            // 
            // labelStockingID
            // 
            this.labelStockingID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStockingID.AutoSize = true;
            this.labelStockingID.Location = new System.Drawing.Point(11, 26);
            this.labelStockingID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStockingID.Name = "labelStockingID";
            this.labelStockingID.Size = new System.Drawing.Size(71, 12);
            this.labelStockingID.TabIndex = 7;
            this.labelStockingID.Text = "Stocking ID";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.Location = new System.Drawing.Point(286, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "批量导入";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(487, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "GPST 导入";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.Location = new System.Drawing.Point(101, 158);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "手工添加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridStockingIDList
            // 
            this.dataGridStockingIDList.AllowUserToAddRows = false;
            this.dataGridStockingIDList.AllowUserToDeleteRows = false;
            this.dataGridStockingIDList.AllowUserToResizeRows = false;
            this.dataGridStockingIDList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridStockingIDList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridStockingIDList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStockingIDList.Location = new System.Drawing.Point(10, 188);
            this.dataGridStockingIDList.MultiSelect = false;
            this.dataGridStockingIDList.Name = "dataGridStockingIDList";
            this.dataGridStockingIDList.ReadOnly = true;
            this.dataGridStockingIDList.RowTemplate.Height = 23;
            this.dataGridStockingIDList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridStockingIDList.Size = new System.Drawing.Size(615, 202);
            this.dataGridStockingIDList.TabIndex = 3;
            this.dataGridStockingIDList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStockingIDList_CellDoubleClick);
            // 
            // formStockingIDManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 399);
            this.Controls.Add(this.dataGridStockingIDList);
            this.Controls.Add(this.groupSearch);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "formStockingIDManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统型号管理";
            this.Load += new System.EventHandler(this.formStockingIDManagement_Load);
            this.groupSearch.ResumeLayout(false);
            this.groupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStockingIDList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSearch;
        private System.Windows.Forms.DataGridView dataGridStockingIDList;
        private System.Windows.Forms.ComboBox comboProductType;
        private System.Windows.Forms.Label labelProductType;
        private System.Windows.Forms.ComboBox comboBU;
        private System.Windows.Forms.Label labelBU;
        private System.Windows.Forms.TextBox textProductCode;
        private System.Windows.Forms.Label labelProductCode;
        private System.Windows.Forms.TextBox textStockingID;
        private System.Windows.Forms.Label labelStockingID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textMM;
        private System.Windows.Forms.Label labelMM;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboNeedTest;
        private System.Windows.Forms.Label labelNeedTest;
        private System.Windows.Forms.ComboBox comboHVI;
        private System.Windows.Forms.Label labelHVI;
        private System.Windows.Forms.TextBox textFamily;
        private System.Windows.Forms.Label labelFamily;
        private System.Windows.Forms.TextBox textProductGroup;
        private System.Windows.Forms.Label labelProductGroup;
    }
}

