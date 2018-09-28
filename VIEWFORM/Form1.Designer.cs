namespace VIEWFORM
{
    partial class ViewNORTHWND
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchName = new System.Windows.Forms.Button();
            this.SearchDescription = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonInsert = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pbxPicture = new System.Windows.Forms.PictureBox();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.ButtonLoadPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(200, 57);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(26, 20);
            this.SearchName.TabIndex = 0;
            this.SearchName.Text = "...";
            this.SearchName.UseVisualStyleBackColor = true;
            this.SearchName.Click += new System.EventHandler(this.SearchName_Click);
            // 
            // SearchDescription
            // 
            this.SearchDescription.Location = new System.Drawing.Point(359, 125);
            this.SearchDescription.Name = "SearchDescription";
            this.SearchDescription.Size = new System.Drawing.Size(26, 23);
            this.SearchDescription.TabIndex = 1;
            this.SearchDescription.Text = "...";
            this.SearchDescription.UseVisualStyleBackColor = true;
            this.SearchDescription.Click += new System.EventHandler(this.SearchDescription_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(254, 245);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(67, 23);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "DELETE";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonInsert
            // 
            this.ButtonInsert.Location = new System.Drawing.Point(69, 245);
            this.ButtonInsert.Name = "ButtonInsert";
            this.ButtonInsert.Size = new System.Drawing.Size(67, 23);
            this.ButtonInsert.TabIndex = 4;
            this.ButtonInsert.Text = "INSERT";
            this.ButtonInsert.UseVisualStyleBackColor = true;
            this.ButtonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(94, 31);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // pbxPicture
            // 
            this.pbxPicture.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pbxPicture.Location = new System.Drawing.Point(407, 12);
            this.pbxPicture.Name = "pbxPicture";
            this.pbxPicture.Size = new System.Drawing.Size(183, 197);
            this.pbxPicture.TabIndex = 9;
            this.pbxPicture.TabStop = false;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(159, 245);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(67, 23);
            this.ButtonUpdate.TabIndex = 10;
            this.ButtonUpdate.Text = "UPDATE";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Description";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(94, 86);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(259, 123);
            this.rtxtDescription.TabIndex = 14;
            this.rtxtDescription.Text = "";
            // 
            // ButtonLoadPhoto
            // 
            this.ButtonLoadPhoto.Location = new System.Drawing.Point(479, 215);
            this.ButtonLoadPhoto.Name = "ButtonLoadPhoto";
            this.ButtonLoadPhoto.Size = new System.Drawing.Size(49, 23);
            this.ButtonLoadPhoto.TabIndex = 15;
            this.ButtonLoadPhoto.Text = "#";
            this.ButtonLoadPhoto.UseVisualStyleBackColor = true;
            this.ButtonLoadPhoto.Click += new System.EventHandler(this.ButtonLoadPhoto_Click);
            // 
            // ViewNORTHWND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 294);
            this.Controls.Add(this.ButtonLoadPhoto);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.pbxPicture);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ButtonInsert);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.SearchDescription);
            this.Controls.Add(this.SearchName);
            this.Name = "ViewNORTHWND";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchName;
        private System.Windows.Forms.Button SearchDescription;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonInsert;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pbxPicture;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Button ButtonLoadPhoto;
    }
}

