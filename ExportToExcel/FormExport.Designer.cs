namespace ExportToExcel
{
	partial class FormExport
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.btnExport = new System.Windows.Forms.Button();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.label = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView.Location = new System.Drawing.Point(0, 90);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(408, 289);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(304, 35);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(92, 23);
			this.btnExport.TabIndex = 1;
			this.btnExport.Text = "Export to excel";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// comboBox
			// 
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Location = new System.Drawing.Point(85, 35);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(213, 21);
			this.comboBox.TabIndex = 2;
			this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label
			// 
			this.label.AutoEllipsis = true;
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(16, 40);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(63, 13);
			this.label.TabIndex = 3;
			this.label.Text = "Select table";
			// 
			// FormExport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 379);
			this.Controls.Add(this.label);
			this.Controls.Add(this.comboBox);
			this.Controls.Add(this.btnExport);
			this.Controls.Add(this.dataGridView);
			this.Name = "FormExport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ExportToExcel";
			this.Load += new System.EventHandler(this.FormExport_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.Label label;
	}
}

