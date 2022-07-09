namespace JSON_Reader_PDF
{
    partial class JSONResume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JSONResume));
            this.btngenerateJSON = new System.Windows.Forms.Button();
            this.btnopenFile = new System.Windows.Forms.Button();
            this.RTBoxResult = new System.Windows.Forms.RichTextBox();
            this.btnsavePDF = new System.Windows.Forms.Button();
            this.pcbox1 = new System.Windows.Forms.PictureBox();
            this.lblConverter = new System.Windows.Forms.Label();
            this.lblResume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btngenerateJSON
            // 
            this.btngenerateJSON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btngenerateJSON.BackColor = System.Drawing.Color.LightSalmon;
            this.btngenerateJSON.Location = new System.Drawing.Point(296, 53);
            this.btngenerateJSON.Name = "btngenerateJSON";
            this.btngenerateJSON.Size = new System.Drawing.Size(91, 29);
            this.btngenerateJSON.TabIndex = 0;
            this.btngenerateJSON.Text = "Generate JSON";
            this.btngenerateJSON.UseVisualStyleBackColor = false;
            this.btngenerateJSON.Click += new System.EventHandler(this.btnreadJSON_Click);
            // 
            // btnopenFile
            // 
            this.btnopenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnopenFile.BackColor = System.Drawing.Color.LightSalmon;
            this.btnopenFile.Location = new System.Drawing.Point(296, 88);
            this.btnopenFile.Name = "btnopenFile";
            this.btnopenFile.Size = new System.Drawing.Size(91, 29);
            this.btnopenFile.TabIndex = 1;
            this.btnopenFile.Text = "Open and Read";
            this.btnopenFile.UseVisualStyleBackColor = false;
            this.btnopenFile.Click += new System.EventHandler(this.btnsavePDF_Click);
            // 
            // RTBoxResult
            // 
            this.RTBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBoxResult.Location = new System.Drawing.Point(12, 53);
            this.RTBoxResult.Name = "RTBoxResult";
            this.RTBoxResult.Size = new System.Drawing.Size(278, 256);
            this.RTBoxResult.TabIndex = 2;
            this.RTBoxResult.Text = "";
            // 
            // btnsavePDF
            // 
            this.btnsavePDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsavePDF.BackColor = System.Drawing.Color.LightSalmon;
            this.btnsavePDF.Location = new System.Drawing.Point(296, 123);
            this.btnsavePDF.Name = "btnsavePDF";
            this.btnsavePDF.Size = new System.Drawing.Size(91, 29);
            this.btnsavePDF.TabIndex = 3;
            this.btnsavePDF.Text = "Save PDF";
            this.btnsavePDF.UseVisualStyleBackColor = false;
            this.btnsavePDF.Click += new System.EventHandler(this.btnsavePDF_Click_1);
            // 
            // pcbox1
            // 
            this.pcbox1.BackColor = System.Drawing.Color.Transparent;
            this.pcbox1.Image = ((System.Drawing.Image)(resources.GetObject("pcbox1.Image")));
            this.pcbox1.Location = new System.Drawing.Point(147, 12);
            this.pcbox1.Name = "pcbox1";
            this.pcbox1.Size = new System.Drawing.Size(46, 34);
            this.pcbox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbox1.TabIndex = 69;
            this.pcbox1.TabStop = false;
            // 
            // lblConverter
            // 
            this.lblConverter.AutoSize = true;
            this.lblConverter.BackColor = System.Drawing.Color.Transparent;
            this.lblConverter.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConverter.ForeColor = System.Drawing.Color.Maroon;
            this.lblConverter.Location = new System.Drawing.Point(187, 8);
            this.lblConverter.Name = "lblConverter";
            this.lblConverter.Size = new System.Drawing.Size(216, 39);
            this.lblConverter.TabIndex = 68;
            this.lblConverter.Text = "CONVERTER";
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.BackColor = System.Drawing.Color.Transparent;
            this.lblResume.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResume.ForeColor = System.Drawing.Color.Tomato;
            this.lblResume.Location = new System.Drawing.Point(5, 8);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(153, 39);
            this.lblResume.TabIndex = 67;
            this.lblResume.Text = "RESUME";
            // 
            // JSONResume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(399, 321);
            this.Controls.Add(this.pcbox1);
            this.Controls.Add(this.lblConverter);
            this.Controls.Add(this.lblResume);
            this.Controls.Add(this.btnsavePDF);
            this.Controls.Add(this.RTBoxResult);
            this.Controls.Add(this.btnopenFile);
            this.Controls.Add(this.btngenerateJSON);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JSONResume";
            this.Text = "JSON to PDF";
            ((System.ComponentModel.ISupportInitialize)(this.pcbox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngenerateJSON;
        private System.Windows.Forms.Button btnopenFile;
        private System.Windows.Forms.RichTextBox RTBoxResult;
        private System.Windows.Forms.Button btnsavePDF;
        private System.Windows.Forms.PictureBox pcbox1;
        private System.Windows.Forms.Label lblConverter;
        private System.Windows.Forms.Label lblResume;
    }
}

