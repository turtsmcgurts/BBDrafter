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
            this.txtEnemyName.Location = new System.Drawing.Point(436, 6);
            this.txtEnemyName.Name = "txtEnemyName";
            this.txtEnemyName.Size = new System.Drawing.Size(144, 20);
            this.txtEnemyName.TabIndex = 21;
            // 
            // txtFriendlyName
            // 
            this.txtFriendlyName.Location = new System.Drawing.Point(8, 6);
            this.txtFriendlyName.Name = "txtFriendlyName";
            this.txtFriendlyName.Size = new System.Drawing.Size(142, 20);
            this.txtFriendlyName.TabIndex = 20;
            this.txtFriendlyName.Text = "itsalreadygg";
            // 
            // btnRemoveRight
            // 
            this.btnRemoveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveRight.Location = new System.Drawing.Point(371, 315);
            this.btnRemoveRight.Name = "btnRemoveRight";
            this.btnRemoveRight.Size = new System.Drawing.Size(59, 59);
            this.btnRemoveRight.TabIndex = 19;
            this.btnRemoveRight.Text = "X";
            this.btnRemoveRight.UseVisualStyleBackColor = true;
            this.btnRemoveRight.Click += new System.EventHandler(this.btnRemoveRight_Click);
            // 
            // btnRemoveLeft
            // 
            this.btnRemoveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveLeft.Location = new System.Drawing.Point(156, 315);
            this.btnRemoveLeft.Name = "btnRemoveLeft";
            this.btnRemoveLeft.Size = new System.Drawing.Size(59, 59);
            this.btnRemoveLeft.TabIndex = 18;
            this.btnRemoveLeft.Text = "X";
            this.btnRemoveLeft.UseVisualStyleBackColor = true;
            this.btnRemoveLeft.Click += new System.EventHandler(this.btnRemoveLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(371, 32);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(59, 277);
            this.btnRight.TabIndex = 17;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(156, 32);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(59, 277);
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
            this.listFriendly.Location = new System.Drawing.Point(8, 32);
            this.listFriendly.Name = "listFriendly";
            this.listFriendly.Size = new System.Drawing.Size(144, 342);
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
            this.listEnemy.Location = new System.Drawing.Point(436, 32);
            this.listEnemy.Name = "listEnemy";
            this.listEnemy.Size = new System.Drawing.Size(144, 342);
            this.listEnemy.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 536);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnemyName);
            this.Controls.Add(this.txtFriendlyName);
            this.Controls.Add(this.btnRemoveRight);
            this.Controls.Add(this.btnRemoveLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.listFriendly);
            this.Controls.Add(this.listPool);
            this.Controls.Add(this.listEnemy);
            this.Name = "Form1";
            this.Text = "BBDrafter";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

