namespace OrderStockSystem
{
    partial class AddSalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSalesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.kdvliTotalTextBox = new System.Windows.Forms.TextBox();
            this.kdvTextBox = new System.Windows.Forms.TextBox();
            this.kdvRateTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.pieceTextBox = new System.Windows.Forms.TextBox();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.salesKodeTextBox = new System.Windows.Forms.TextBox();
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.kdvTotalLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.kdvLabel = new System.Windows.Forms.Label();
            this.pieceLabel = new System.Windows.Forms.Label();
            this.kdvRateLabel = new System.Windows.Forms.Label();
            this.salesKodeLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.unitpriceLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listOrderButton = new System.Windows.Forms.Button();
            this.paymentButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.productTextBox);
            this.panel1.Controls.Add(this.addOrderButton);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.kdvliTotalTextBox);
            this.panel1.Controls.Add(this.kdvTextBox);
            this.panel1.Controls.Add(this.kdvRateTextBox);
            this.panel1.Controls.Add(this.AmountTextBox);
            this.panel1.Controls.Add(this.unitPriceTextBox);
            this.panel1.Controls.Add(this.pieceTextBox);
            this.panel1.Controls.Add(this.customerTextBox);
            this.panel1.Controls.Add(this.salesKodeTextBox);
            this.panel1.Controls.Add(this.companyNameLabel);
            this.panel1.Controls.Add(this.kdvTotalLabel);
            this.panel1.Controls.Add(this.productLabel);
            this.panel1.Controls.Add(this.kdvLabel);
            this.panel1.Controls.Add(this.pieceLabel);
            this.panel1.Controls.Add(this.kdvRateLabel);
            this.panel1.Controls.Add(this.salesKodeLabel);
            this.panel1.Controls.Add(this.amountLabel);
            this.panel1.Controls.Add(this.unitpriceLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 212);
            this.panel1.TabIndex = 0;
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(191, 95);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(200, 22);
            this.productTextBox.TabIndex = 24;
            // 
            // addOrderButton
            // 
            this.addOrderButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.addOrderButton.Location = new System.Drawing.Point(853, 147);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(139, 47);
            this.addOrderButton.TabIndex = 23;
            this.addOrderButton.Text = "Sipariş Ekle";
            this.addOrderButton.UseVisualStyleBackColor = false;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(18, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tarih:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kdvliTotalTextBox
            // 
            this.kdvliTotalTextBox.Location = new System.Drawing.Point(631, 171);
            this.kdvliTotalTextBox.Name = "kdvliTotalTextBox";
            this.kdvliTotalTextBox.Size = new System.Drawing.Size(160, 22);
            this.kdvliTotalTextBox.TabIndex = 16;
            // 
            // kdvTextBox
            // 
            this.kdvTextBox.Location = new System.Drawing.Point(631, 132);
            this.kdvTextBox.Name = "kdvTextBox";
            this.kdvTextBox.Size = new System.Drawing.Size(160, 22);
            this.kdvTextBox.TabIndex = 15;
            // 
            // kdvRateTextBox
            // 
            this.kdvRateTextBox.Location = new System.Drawing.Point(631, 91);
            this.kdvRateTextBox.Name = "kdvRateTextBox";
            this.kdvRateTextBox.Size = new System.Drawing.Size(160, 22);
            this.kdvRateTextBox.TabIndex = 14;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(631, 50);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(160, 22);
            this.AmountTextBox.TabIndex = 13;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(631, 13);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(160, 22);
            this.unitPriceTextBox.TabIndex = 12;
            // 
            // pieceTextBox
            // 
            this.pieceTextBox.Location = new System.Drawing.Point(191, 132);
            this.pieceTextBox.Name = "pieceTextBox";
            this.pieceTextBox.Size = new System.Drawing.Size(200, 22);
            this.pieceTextBox.TabIndex = 11;
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(191, 55);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(200, 22);
            this.customerTextBox.TabIndex = 10;
            // 
            // salesKodeTextBox
            // 
            this.salesKodeTextBox.Location = new System.Drawing.Point(191, 17);
            this.salesKodeTextBox.Name = "salesKodeTextBox";
            this.salesKodeTextBox.Size = new System.Drawing.Size(200, 22);
            this.salesKodeTextBox.TabIndex = 9;
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.companyNameLabel.Location = new System.Drawing.Point(18, 56);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(139, 17);
            this.companyNameLabel.TabIndex = 8;
            this.companyNameLabel.Text = "Müşteri Firma Adı:";
            // 
            // kdvTotalLabel
            // 
            this.kdvTotalLabel.AutoSize = true;
            this.kdvTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kdvTotalLabel.Location = new System.Drawing.Point(500, 172);
            this.kdvTotalLabel.Name = "kdvTotalLabel";
            this.kdvTotalLabel.Size = new System.Drawing.Size(101, 17);
            this.kdvTotalLabel.TabIndex = 2;
            this.kdvTotalLabel.Text = "KDV li Tutar:";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productLabel.Location = new System.Drawing.Point(18, 95);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(48, 17);
            this.productLabel.TabIndex = 7;
            this.productLabel.Text = "Ürün:";
            // 
            // kdvLabel
            // 
            this.kdvLabel.AutoSize = true;
            this.kdvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kdvLabel.Location = new System.Drawing.Point(500, 133);
            this.kdvLabel.Name = "kdvLabel";
            this.kdvLabel.Size = new System.Drawing.Size(88, 17);
            this.kdvLabel.TabIndex = 3;
            this.kdvLabel.Text = "KDV Tutar:";
            // 
            // pieceLabel
            // 
            this.pieceLabel.AutoSize = true;
            this.pieceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pieceLabel.Location = new System.Drawing.Point(18, 136);
            this.pieceLabel.Name = "pieceLabel";
            this.pieceLabel.Size = new System.Drawing.Size(46, 17);
            this.pieceLabel.TabIndex = 6;
            this.pieceLabel.Text = "Adet:";
            // 
            // kdvRateLabel
            // 
            this.kdvRateLabel.AutoSize = true;
            this.kdvRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kdvRateLabel.Location = new System.Drawing.Point(500, 91);
            this.kdvRateLabel.Name = "kdvRateLabel";
            this.kdvRateLabel.Size = new System.Drawing.Size(85, 17);
            this.kdvRateLabel.TabIndex = 1;
            this.kdvRateLabel.Text = "KDV Oran:";
            // 
            // salesKodeLabel
            // 
            this.salesKodeLabel.AutoSize = true;
            this.salesKodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salesKodeLabel.Location = new System.Drawing.Point(18, 21);
            this.salesKodeLabel.Name = "salesKodeLabel";
            this.salesKodeLabel.Size = new System.Drawing.Size(74, 17);
            this.salesKodeLabel.TabIndex = 0;
            this.salesKodeLabel.Text = "Satış No:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.amountLabel.Location = new System.Drawing.Point(500, 51);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(52, 17);
            this.amountLabel.TabIndex = 4;
            this.amountLabel.Text = "Tutar:";
            // 
            // unitpriceLabel
            // 
            this.unitpriceLabel.AutoSize = true;
            this.unitpriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unitpriceLabel.Location = new System.Drawing.Point(500, 15);
            this.unitpriceLabel.Name = "unitpriceLabel";
            this.unitpriceLabel.Size = new System.Drawing.Size(89, 17);
            this.unitpriceLabel.TabIndex = 5;
            this.unitpriceLabel.Text = "Birim Fiyat:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dataGridView1.DataSource = this.salesOrderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 270);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Order_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Order_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Order_Kode";
            this.dataGridViewTextBoxColumn2.HeaderText = "SİPARİŞ_KODU";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Sales_Piece";
            this.dataGridViewTextBoxColumn3.HeaderText = "SATIŞ_MİKTARI";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Unit_Price";
            this.dataGridViewTextBoxColumn4.HeaderText = "BİRİM_FİYAT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sales_Date";
            this.dataGridViewTextBoxColumn5.HeaderText = "SİPARİŞ_TARİHİ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "KDV_Rate";
            this.dataGridViewTextBoxColumn6.HeaderText = "KDV_ORANI";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Sales_Total";
            this.dataGridViewTextBoxColumn7.HeaderText = "KDVSİZ_TUTAR";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Sales_KDV_Total";
            this.dataGridViewTextBoxColumn8.HeaderText = "KDVLİ_TUTAR";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CustomerId";
            this.dataGridViewTextBoxColumn9.HeaderText = "CustomerId";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn10.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CustomerKode";
            this.dataGridViewTextBoxColumn11.HeaderText = "MÜŞTERİ_KODU";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ProductKode";
            this.dataGridViewTextBoxColumn12.HeaderText = "ÜRÜN_KODU";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Control";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Control";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn13.HeaderText = "Product";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Customer";
            this.dataGridViewTextBoxColumn14.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "sales";
            this.dataGridViewTextBoxColumn15.HeaderText = "sales";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // salesOrderBindingSource
            // 
            this.salesOrderBindingSource.DataSource = typeof(OrderStockSystem.DatabaseTables.SalesOrder);
            // 
            // listOrderButton
            // 
            this.listOrderButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listOrderButton.Location = new System.Drawing.Point(578, 519);
            this.listOrderButton.Name = "listOrderButton";
            this.listOrderButton.Size = new System.Drawing.Size(204, 45);
            this.listOrderButton.TabIndex = 2;
            this.listOrderButton.Text = "Tüm Siparişler";
            this.listOrderButton.UseVisualStyleBackColor = false;
            this.listOrderButton.Click += new System.EventHandler(this.listOrderButton_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.paymentButton.Location = new System.Drawing.Point(803, 519);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(222, 45);
            this.paymentButton.TabIndex = 3;
            this.paymentButton.Text = "Sipariş Detay-Ödeme Sayfası";
            this.paymentButton.UseVisualStyleBackColor = false;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // AddSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1055, 583);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.listOrderButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞ OLUŞTUR";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesOrderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label salesKodeLabel;
        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label pieceLabel;
        private System.Windows.Forms.Label kdvRateLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label unitpriceLabel;
        private System.Windows.Forms.Label kdvTotalLabel;
        private System.Windows.Forms.Label kdvLabel;
        private System.Windows.Forms.TextBox kdvliTotalTextBox;
        private System.Windows.Forms.TextBox kdvTextBox;
        private System.Windows.Forms.TextBox kdvRateTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox pieceTextBox;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox salesKodeTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisAdetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kDVOranDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvliTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisDetayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button listOrderButton;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderKodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPieceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kDVRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesKDVTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerKodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productKodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn controlDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salesOrderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}