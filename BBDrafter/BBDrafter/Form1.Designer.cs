namespace BBDrafter {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnemyName = new System.Windows.Forms.TextBox();
            this.txtFriendlyName = new System.Windows.Forms.TextBox();
            this.btnRemoveRight = new System.Windows.Forms.Button();
            this.btnRemoveLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.listFriendly = new System.Windows.Forms.ListBox();
            this.listPool = new System.Windows.Forms.ListBox();
            this.listEnemy = new System.Windows.Forms.ListBox();
            this.listLeftBans = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listRightBans = new System.Windows.Forms.ListBox();
            this.btnRightBan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLeftBan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(9, 409);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(572, 120);
            this.rtbLog.TabIndex = 23;
            this.rtbLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "by turtsmcgurts";
            // 
            // txtEnemyName
            // 
            this.txtEnemyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEnemyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEnemyName.Location = new System.Drawing.Point(387, 6);
            this.txtEnemyName.Name = "txtEnemyName";
            this.txtEnemyName.Size = new System.Drawing.Size(177, 20);
            this.txtEnemyName.TabIndex = 21;
            // 
            // txtFriendlyName
            // 
            this.txtFriendlyName.Location = new System.Drawing.Point(16, 6);
            this.txtFriendlyName.Name = "txtFriendlyName";
            this.txtFriendlyName.Size = new System.Drawing.Size(183, 20);
            this.txtFriendlyName.TabIndex = 20;
            this.txtFriendlyName.Text = "itsalreadygg";
            // 
            // btnRemoveRight
            // 
            this.btnRemoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveRight.Location = new System.Drawing.Point(11, 192);
            this.btnRemoveRight.Name = "btnRemoveRight";
            this.btnRemoveRight.Size = new System.Drawing.Size(59, 39);
            this.btnRemoveRight.TabIndex = 19;
            this.btnRemoveRight.Text = "X";
            this.btnRemoveRight.UseVisualStyleBackColor = true;
            this.btnRemoveRight.Click += new System.EventHandler(this.btnRemoveRight_Click);
            // 
            // btnRemoveLeft
            // 
            this.btnRemoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveLeft.Location = new System.Drawing.Point(131, 189);
            this.btnRemoveLeft.Name = "btnRemoveLeft";
            this.btnRemoveLeft.Size = new System.Drawing.Size(59, 39);
            this.btnRemoveLeft.TabIndex = 18;
            this.btnRemoveLeft.Text = "X";
            this.btnRemoveLeft.UseVisualStyleBackColor = true;
            this.btnRemoveLeft.Click += new System.EventHandler(this.btnRemoveLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(11, 19);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(59, 167);
            this.btnRight.TabIndex = 17;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(131, 16);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(59, 167);
            this.btnLeft.TabIndex = 16;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 380);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(574, 22);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // listFriendly
            // 
            this.listFriendly.AllowDrop = true;
            this.listFriendly.FormattingEnabled = true;
            this.listFriendly.Location = new System.Drawing.Point(7, 16);
            this.listFriendly.Name = "listFriendly";
            this.listFriendly.Size = new System.Drawing.Size(118, 212);
            this.listFriendly.TabIndex = 14;
            // 
            // listPool
            // 
            this.listPool.FormattingEnabled = true;
            this.listPool.Location = new System.Drawing.Point(221, 32);
            this.listPool.Name = "listPool";
            this.listPool.Size = new System.Drawing.Size(144, 342);
            this.listPool.TabIndex = 13;
            // 
            // listEnemy
            // 
            this.listEnemy.AllowDrop = true;
            this.listEnemy.FormattingEnabled = true;
            this.listEnemy.Location = new System.Drawing.Point(76, 19);
            this.listEnemy.Name = "listEnemy";
            this.listEnemy.Size = new System.Drawing.Size(118, 212);
            this.listEnemy.TabIndex = 12;
            // 
            // listLeftBans
            // 
            this.listLeftBans.FormattingEnabled = true;
            this.listLeftBans.Location = new System.Drawing.Point(7, 19);
            this.listLeftBans.Name = "listLeftBans";
            this.listLeftBans.Size = new System.Drawing.Size(112, 69);
            this.listLeftBans.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listEnemy);
            this.groupBox1.Controls.Add(this.btnRight);
            this.groupBox1.Controls.Add(this.btnRemoveRight);
            this.groupBox1.Location = new System.Drawing.Point(371, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 239);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Picks";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRightBan);
            this.groupBox2.Controls.Add(this.listRightBans);
            this.groupBox2.Location = new System.Drawing.Point(371, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 97);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // listRightBans
            // 
            this.listRightBans.FormattingEnabled = true;
            this.listRightBans.Location = new System.Drawing.Point(81, 19);
            this.listRightBans.Name = "listRightBans";
            this.listRightBans.Size = new System.Drawing.Size(112, 69);
            this.listRightBans.TabIndex = 0;
            // 
            // btnRightBan
            // 
            this.btnRightBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightBan.Location = new System.Drawing.Point(16, 19);
            this.btnRightBan.Name = "btnRightBan";
            this.btnRightBan.Size = new System.Drawing.Size(59, 69);
            this.btnRightBan.TabIndex = 1;
            this.btnRightBan.Text = "BAN";
            this.btnRightBan.UseVisualStyleBackColor = true;
            this.btnRightBan.Click += new System.EventHandler(this.btnRightBan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLeftBan);
            this.groupBox3.Controls.Add(this.listLeftBans);
            this.groupBox3.Location = new System.Drawing.Point(9, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 97);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listFriendly);
            this.groupBox4.Controls.Add(this.btnLeft);
            this.groupBox4.Controls.Add(this.btnRemoveLeft);
            this.groupBox4.Location = new System.Drawing.Point(9, 138);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 236);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Picks";
            // 
            // btnLeftBan
            // 
            this.btnLeftBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftBan.Location = new System.Drawing.Point(131, 19);
            this.btnLeftBan.Name = "btnLeftBan";
            this.btnLeftBan.Size = new System.Drawing.Size(59, 69);
            this.btnLeftBan.TabIndex = 25;
            this.btnLeftBan.Text = "BAN";
            this.btnLeftBan.UseVisualStyleBackColor = true;
            this.btnLeftBan.Click += new System.EventHandler(this.btnLeftBan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 536);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnemyName);
            this.Controls.Add(this.txtFriendlyName);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.listPool);
            this.Name = "Form1";
            this.Text = "BBDrafter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnemyName;
        private System.Windows.Forms.TextBox txtFriendlyName;
        private System.Windows.Forms.Button btnRemoveRight;
        private System.Windows.Forms.Button btnRemoveLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox listFriendly;
        private System.Windows.Forms.ListBox listPool;
        private System.Windows.Forms.ListBox listEnemy;
        private System.Windows.Forms.ListBox listLeftBans;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRightBan;
        private System.Windows.Forms.ListBox listRightBans;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLeftBan;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

