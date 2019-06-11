namespace OrderStockSystem
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.selectedCustomerButton = new System.Windows.Forms.Button();
            this.salesListButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.companyNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.companyNameTextBox.Location = new System.Drawing.Point(195, 16);
            this.companyNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(231, 22);
            this.companyNameTextBox.TabIndex = 154;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.companyNameLabel.Location = new System.Drawing.Point(29, 19);
            this.companyNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(139, 17);
            this.companyNameLabel.TabIndex = 153;
            this.companyNameLabel.Text = "Müşteri Firma Adı:";
            // 
            // selectedCustomerButton
            // 
            this.selectedCustomerButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectedCustomerButton.Location = new System.Drawing.Point(468, 13);
            this.selectedCustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectedCustomerButton.Name = "selectedCustomerButton";
            this.selectedCustomerButton.Size = new System.Drawing.Size(265, 34);
            this.selectedCustomerButton.TabIndex = 152;
            this.selectedCustomerButton.Text = "Seçili müşteri için satış bilgilerini getir";
            this.selectedCustomerButton.UseVisualStyleBackColor = false;
            this.selectedCustomerButton.Click += new System.EventHandler(this.selectedCustomerButton_Click);
            // 
            // salesListButton
            // 
            this.salesListButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.salesListButton.Location = new System.Drawing.Point(758, 13);
            this.salesListButton.Margin = new System.Windows.Forms.Padding(4);
            this.salesListButton.Name = "salesListButton";
            this.salesListButton.Size = new System.Drawing.Size(181, 34);
            this.salesListButton.TabIndex = 151;
            this.salesListButton.Text = "Tüm satış bilgilerini getir";
            this.salesListButton.UseVisualStyleBackColor = false;
            this.salesListButton.Click += new System.EventHandler(this.salesListButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 463);
            this.dataGridView1.TabIndex = 150;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1169, 542);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.selectedCustomerButton);
            this.Controls.Add(this.salesListButton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ RAPORU";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Button selectedCustomerButton;
        private System.Windows.Forms.Button salesListButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}