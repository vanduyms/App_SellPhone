namespace Project2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.historyBtn = new System.Windows.Forms.Button();
            this.cartBtn = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Red;
            this.splitContainer1.Panel1.Controls.Add(this.historyBtn);
            this.splitContainer1.Panel1.Controls.Add(this.cartBtn);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.searchBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(718, 408);
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // historyBtn
            // 
            this.historyBtn.BackColor = System.Drawing.Color.Transparent;
            this.historyBtn.BackgroundImage = global::Project2.Properties.Resources.historyIcon;
            this.historyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.historyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historyBtn.Location = new System.Drawing.Point(598, 15);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(31, 29);
            this.historyBtn.TabIndex = 3;
            this.historyBtn.UseVisualStyleBackColor = false;
            // 
            // cartBtn
            // 
            this.cartBtn.BackColor = System.Drawing.Color.Transparent;
            this.cartBtn.BackgroundImage = global::Project2.Properties.Resources.cartIcon;
            this.cartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cartBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartBtn.Location = new System.Drawing.Point(641, 15);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(31, 29);
            this.cartBtn.TabIndex = 2;
            this.cartBtn.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Cyan;
            this.btnSearch.BackgroundImage = global::Project2.Properties.Resources.searchIcon;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Location = new System.Drawing.Point(464, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 29);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(142, 15);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(316, 29);
            this.searchBox.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listView1);
            this.splitContainer2.Size = new System.Drawing.Size(718, 347);
            this.splitContainer2.SplitterDistance = 206;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BỘ LỌC TÌM KIẾM";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(508, 347);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 408);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button cartBtn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}

