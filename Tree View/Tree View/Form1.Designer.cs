namespace Tree_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Smallicon = new System.Windows.Forms.ImageList(this.components);
            this.Largeicon = new System.Windows.Forms.ImageList(this.components);
            this.rdoLargeIcon = new System.Windows.Forms.RadioButton();
            this.rdoSmallIcon = new System.Windows.Forms.RadioButton();
            this.rdoDetails = new System.Windows.Forms.RadioButton();
            this.rdoTile = new System.Windows.Forms.RadioButton();
            this.rdoList = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(296, 511);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.Largeicon;
            this.listView1.Location = new System.Drawing.Point(294, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(406, 511);
            this.listView1.SmallImageList = this.Smallicon;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Smallicon
            // 
            this.Smallicon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Smallicon.ImageStream")));
            this.Smallicon.TransparentColor = System.Drawing.Color.Transparent;
            this.Smallicon.Images.SetKeyName(0, "icons8-folder-16.png");
            // 
            // Largeicon
            // 
            this.Largeicon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Largeicon.ImageStream")));
            this.Largeicon.TransparentColor = System.Drawing.Color.Transparent;
            this.Largeicon.Images.SetKeyName(0, "icons8-folder-48.png");
            // 
            // rdoLargeIcon
            // 
            this.rdoLargeIcon.AutoSize = true;
            this.rdoLargeIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLargeIcon.Location = new System.Drawing.Point(743, 106);
            this.rdoLargeIcon.Name = "rdoLargeIcon";
            this.rdoLargeIcon.Size = new System.Drawing.Size(86, 17);
            this.rdoLargeIcon.TabIndex = 2;
            this.rdoLargeIcon.TabStop = true;
            this.rdoLargeIcon.Text = "Large Icon";
            this.rdoLargeIcon.UseVisualStyleBackColor = true;
            this.rdoLargeIcon.CheckedChanged += new System.EventHandler(this.rdoList_CheckedChanged);
            // 
            // rdoSmallIcon
            // 
            this.rdoSmallIcon.AutoSize = true;
            this.rdoSmallIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSmallIcon.Location = new System.Drawing.Point(745, 129);
            this.rdoSmallIcon.Name = "rdoSmallIcon";
            this.rdoSmallIcon.Size = new System.Drawing.Size(84, 17);
            this.rdoSmallIcon.TabIndex = 3;
            this.rdoSmallIcon.TabStop = true;
            this.rdoSmallIcon.Text = "Small Icon";
            this.rdoSmallIcon.UseVisualStyleBackColor = true;
            this.rdoSmallIcon.CheckedChanged += new System.EventHandler(this.rdoList_CheckedChanged);
            // 
            // rdoDetails
            // 
            this.rdoDetails.AutoSize = true;
            this.rdoDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDetails.Location = new System.Drawing.Point(745, 152);
            this.rdoDetails.Name = "rdoDetails";
            this.rdoDetails.Size = new System.Drawing.Size(64, 17);
            this.rdoDetails.TabIndex = 4;
            this.rdoDetails.TabStop = true;
            this.rdoDetails.Text = "Details";
            this.rdoDetails.UseVisualStyleBackColor = true;
            this.rdoDetails.CheckedChanged += new System.EventHandler(this.rdoList_CheckedChanged);
            // 
            // rdoTile
            // 
            this.rdoTile.AutoSize = true;
            this.rdoTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTile.Location = new System.Drawing.Point(745, 175);
            this.rdoTile.Name = "rdoTile";
            this.rdoTile.Size = new System.Drawing.Size(52, 17);
            this.rdoTile.TabIndex = 5;
            this.rdoTile.TabStop = true;
            this.rdoTile.Text = "Tiles";
            this.rdoTile.UseVisualStyleBackColor = true;
            this.rdoTile.CheckedChanged += new System.EventHandler(this.rdoList_CheckedChanged);
            // 
            // rdoList
            // 
            this.rdoList.AutoSize = true;
            this.rdoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoList.Location = new System.Drawing.Point(745, 198);
            this.rdoList.Name = "rdoList";
            this.rdoList.Size = new System.Drawing.Size(45, 17);
            this.rdoList.TabIndex = 6;
            this.rdoList.TabStop = true;
            this.rdoList.Text = "List";
            this.rdoList.UseVisualStyleBackColor = true;
            this.rdoList.CheckedChanged += new System.EventHandler(this.rdoList_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 511);
            this.Controls.Add(this.rdoList);
            this.Controls.Add(this.rdoTile);
            this.Controls.Add(this.rdoDetails);
            this.Controls.Add(this.rdoSmallIcon);
            this.Controls.Add(this.rdoLargeIcon);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList Smallicon;
        private System.Windows.Forms.ImageList Largeicon;
        private System.Windows.Forms.RadioButton rdoLargeIcon;
        private System.Windows.Forms.RadioButton rdoSmallIcon;
        private System.Windows.Forms.RadioButton rdoDetails;
        private System.Windows.Forms.RadioButton rdoTile;
        private System.Windows.Forms.RadioButton rdoList;
    }
}

