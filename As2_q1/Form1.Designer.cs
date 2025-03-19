namespace As2_q1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sortbtn = new Button();
            searchbtn = new Button();
            arraytxt = new RichTextBox();
            searchtxt = new TextBox();
            resultstxt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // sortbtn
            // 
            sortbtn.Location = new Point(52, 39);
            sortbtn.Name = "sortbtn";
            sortbtn.Size = new Size(75, 23);
            sortbtn.TabIndex = 0;
            sortbtn.Text = "Sort";
            sortbtn.UseVisualStyleBackColor = true;
            // 
            // searchbtn
            // 
            searchbtn.Location = new Point(167, 39);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 1;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            // 
            // arraytxt
            // 
            arraytxt.Location = new Point(52, 77);
            arraytxt.Name = "arraytxt";
            arraytxt.Size = new Size(416, 96);
            arraytxt.TabIndex = 3;
            arraytxt.Text = "";
            // 
            // searchtxt
            // 
            searchtxt.Location = new Point(248, 40);
            searchtxt.Name = "searchtxt";
            searchtxt.Size = new Size(82, 23);
            searchtxt.TabIndex = 4;
            // 
            // resultstxt
            // 
            resultstxt.Location = new Point(386, 40);
            resultstxt.Name = "resultstxt";
            resultstxt.Size = new Size(82, 23);
            resultstxt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 42);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 214);
            Controls.Add(label1);
            Controls.Add(resultstxt);
            Controls.Add(searchtxt);
            Controls.Add(arraytxt);
            Controls.Add(searchbtn);
            Controls.Add(sortbtn);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Assigment 3 - Binary Search of an Unordered Array";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sortbtn;
        private Button searchbtn;
        private RichTextBox arraytxt;
        private TextBox searchtxt;
        private TextBox resultstxt;
        private Label label1;
    }
}
