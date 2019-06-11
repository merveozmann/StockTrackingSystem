namespace OrderStockSystem
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listButton = new System.Windows.Forms.Button();
            this.prepaymentButton = new System.Windows.Forms.Button();
            this.creditButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(995, 481);
            this.dataGridView1.TabIndex = 0;
            // 
            // listButton
            // 
            this.listButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listButton.Location = new System.Drawing.Point(141, 12);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(180, 37);
            this.listButton.TabIndex = 1;
            this.listButton.Text = "Tüm Ödeme Bilgileri";
            this.listButton.UseVisualStyleBackColor = false;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // prepaymentButton
            // 
            this.prepaymentButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.prepaymentButton.Location = new System.Drawing.Point(387, 12);
            this.prepaymentButton.Name = "prepaymentButton";
            this.prepaymentButton.Size = new System.Drawing.Size(173, 37);
            this.prepaymentButton.TabIndex = 2;
            this.prepaymentButton.Text = "Peşin Ödeme Bilgileri";
            this.prepaymentButton.UseVisualStyleBackColor = false;
            this.prepaymentButton.Click += new System.EventHandler(this.prepaymentButton_Click);
            // 
            // creditButton
            // 
            this.creditButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.creditButton.Location = new System.Drawing.Point(636, 12);
            this.creditButton.Name = "creditButton";
            this.creditButton.Size = new System.Drawing.Size(212, 37);
            this.creditButton.TabIndex = 3;
            this.creditButton.Text = "Kredi Kartı Ödeme Bilgileri";
            this.creditButton.UseVisualStyleBackColor = false;
            this.creditButton.Click += new System.EventHandler(this.creditButton_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1032, 566);
            this.Controls.Add(this.creditButton);
            this.Controls.Add(this.prepaymentButton);
            this.Controls.Add(this.listButton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖDEME BİLGİLERİ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button listButton;
        private System.Windows.Forms.Button prepaymentButton;
        private System.Windows.Forms.Button creditButton;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}