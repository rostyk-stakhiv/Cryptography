namespace CesarCipher
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
            this.EncodedText = new System.Windows.Forms.TextBox();
            this.DecodedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EncodeBtn = new System.Windows.Forms.Button();
            this.DecodeBtn = new System.Windows.Forms.Button();
            this.HackBtn = new System.Windows.Forms.Button();
            this.TableBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.English = new System.Windows.Forms.RadioButton();
            this.Ukrainian = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Picture = new System.Windows.Forms.RadioButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Decoded = new System.Windows.Forms.RadioButton();
            this.Encoded = new System.Windows.Forms.RadioButton();
            this.key = new System.Windows.Forms.TextBox();
            this.openNotepad = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncodedText
            // 
            this.EncodedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncodedText.Location = new System.Drawing.Point(18, 551);
            this.EncodedText.MaxLength = 2147483647;
            this.EncodedText.Multiline = true;
            this.EncodedText.Name = "EncodedText";
            this.EncodedText.Size = new System.Drawing.Size(1219, 376);
            this.EncodedText.TabIndex = 0;
            // 
            // DecodedText
            // 
            this.DecodedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecodedText.Location = new System.Drawing.Point(12, 90);
            this.DecodedText.MaxLength = 2147483647;
            this.DecodedText.Multiline = true;
            this.DecodedText.Name = "DecodedText";
            this.DecodedText.Size = new System.Drawing.Size(1219, 376);
            this.DecodedText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Encoded";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Decoded";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EncodeBtn
            // 
            this.EncodeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncodeBtn.Location = new System.Drawing.Point(1437, 90);
            this.EncodeBtn.Name = "EncodeBtn";
            this.EncodeBtn.Size = new System.Drawing.Size(339, 75);
            this.EncodeBtn.TabIndex = 4;
            this.EncodeBtn.Text = "Encode";
            this.EncodeBtn.UseVisualStyleBackColor = true;
            this.EncodeBtn.Click += new System.EventHandler(this.EncodeBtn_Click);
            // 
            // DecodeBtn
            // 
            this.DecodeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecodeBtn.Location = new System.Drawing.Point(1437, 256);
            this.DecodeBtn.Name = "DecodeBtn";
            this.DecodeBtn.Size = new System.Drawing.Size(339, 75);
            this.DecodeBtn.TabIndex = 5;
            this.DecodeBtn.Text = "Decode";
            this.DecodeBtn.UseVisualStyleBackColor = true;
            this.DecodeBtn.Click += new System.EventHandler(this.DecodeBtn_Click);
            // 
            // HackBtn
            // 
            this.HackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HackBtn.Location = new System.Drawing.Point(1437, 401);
            this.HackBtn.Name = "HackBtn";
            this.HackBtn.Size = new System.Drawing.Size(339, 75);
            this.HackBtn.TabIndex = 6;
            this.HackBtn.Text = "Save Notepad";
            this.HackBtn.UseVisualStyleBackColor = true;
            this.HackBtn.Click += new System.EventHandler(this.HackBtn_Click);
            // 
            // TableBtn
            // 
            this.TableBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableBtn.Location = new System.Drawing.Point(1437, 611);
            this.TableBtn.Name = "TableBtn";
            this.TableBtn.Size = new System.Drawing.Size(339, 75);
            this.TableBtn.TabIndex = 7;
            this.TableBtn.Text = "Generate gamma";
            this.TableBtn.UseVisualStyleBackColor = true;
            this.TableBtn.Click += new System.EventHandler(this.TableBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1882, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAuthorToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutAuthorToolStripMenuItem
            // 
            this.aboutAuthorToolStripMenuItem.Name = "aboutAuthorToolStripMenuItem";
            this.aboutAuthorToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.aboutAuthorToolStripMenuItem.Text = "About author";
            this.aboutAuthorToolStripMenuItem.Click += new System.EventHandler(this.aboutAuthorToolStripMenuItem_Click);
            // 
            // English
            // 
            this.English.AutoSize = true;
            this.English.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.English.Location = new System.Drawing.Point(1255, 279);
            this.English.Name = "English";
            this.English.Size = new System.Drawing.Size(105, 30);
            this.English.TabIndex = 10;
            this.English.TabStop = true;
            this.English.Text = "English";
            this.English.UseVisualStyleBackColor = true;
            this.English.CheckedChanged += new System.EventHandler(this.English_CheckedChanged);
            // 
            // Ukrainian
            // 
            this.Ukrainian.AutoSize = true;
            this.Ukrainian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ukrainian.Location = new System.Drawing.Point(1255, 321);
            this.Ukrainian.Name = "Ukrainian";
            this.Ukrainian.Size = new System.Drawing.Size(125, 30);
            this.Ukrainian.TabIndex = 11;
            this.Ukrainian.TabStop = true;
            this.Ukrainian.Text = "Ukrainian";
            this.Ukrainian.UseVisualStyleBackColor = true;
            this.Ukrainian.CheckedChanged += new System.EventHandler(this.Ukrainian_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Picture
            // 
            this.Picture.AutoSize = true;
            this.Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Picture.Location = new System.Drawing.Point(1255, 357);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(101, 30);
            this.Picture.TabIndex = 12;
            this.Picture.TabStop = true;
            this.Picture.Text = "Picture";
            this.Picture.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Decoded);
            this.panel1.Controls.Add(this.Encoded);
            this.panel1.Location = new System.Drawing.Point(1246, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 100);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Save from";
            // 
            // Decoded
            // 
            this.Decoded.AutoSize = true;
            this.Decoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decoded.Location = new System.Drawing.Point(0, 70);
            this.Decoded.Name = "Decoded";
            this.Decoded.Size = new System.Drawing.Size(120, 30);
            this.Decoded.TabIndex = 1;
            this.Decoded.TabStop = true;
            this.Decoded.Text = "Decoded";
            this.Decoded.UseVisualStyleBackColor = true;
            // 
            // Encoded
            // 
            this.Encoded.AutoSize = true;
            this.Encoded.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encoded.Location = new System.Drawing.Point(0, 37);
            this.Encoded.Name = "Encoded";
            this.Encoded.Size = new System.Drawing.Size(119, 30);
            this.Encoded.TabIndex = 0;
            this.Encoded.TabStop = true;
            this.Encoded.Text = "Encoded";
            this.Encoded.UseVisualStyleBackColor = true;
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(1237, 90);
            this.key.Multiline = true;
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(185, 174);
            this.key.TabIndex = 14;
            this.key.TextChanged += new System.EventHandler(this.key_TextChanged);
            // 
            // openNotepad
            // 
            this.openNotepad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openNotepad.Location = new System.Drawing.Point(1437, 502);
            this.openNotepad.Name = "openNotepad";
            this.openNotepad.Size = new System.Drawing.Size(339, 75);
            this.openNotepad.TabIndex = 15;
            this.openNotepad.Text = "Open Notepad";
            this.openNotepad.UseVisualStyleBackColor = true;
            this.openNotepad.Click += new System.EventHandler(this.openNotepad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 953);
            this.Controls.Add(this.openNotepad);
            this.Controls.Add(this.key);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Ukrainian);
            this.Controls.Add(this.English);
            this.Controls.Add(this.TableBtn);
            this.Controls.Add(this.HackBtn);
            this.Controls.Add(this.DecodeBtn);
            this.Controls.Add(this.EncodeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecodedText);
            this.Controls.Add(this.EncodedText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EncodedText;
        private System.Windows.Forms.TextBox DecodedText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EncodeBtn;
        private System.Windows.Forms.Button DecodeBtn;
        private System.Windows.Forms.Button HackBtn;
        private System.Windows.Forms.Button TableBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAuthorToolStripMenuItem;
        private System.Windows.Forms.RadioButton English;
        private System.Windows.Forms.RadioButton Ukrainian;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton Picture;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Decoded;
        private System.Windows.Forms.RadioButton Encoded;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Button openNotepad;
    }
}

