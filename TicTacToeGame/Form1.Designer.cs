namespace TicTacToeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mSinglePlayerButton = new System.Windows.Forms.Button();
            this.mMultiPlayerButton = new System.Windows.Forms.Button();
            this.mLabel1 = new System.Windows.Forms.Label();
            this.mLabel2 = new System.Windows.Forms.Label();
            this.mLabel5 = new System.Windows.Forms.Label();
            this.mLabel3 = new System.Windows.Forms.Label();
            this.mLabel4 = new System.Windows.Forms.Label();
            this.mExitButton = new System.Windows.Forms.Button();
            this.mButton1 = new System.Windows.Forms.Button();
            this.mButton2 = new System.Windows.Forms.Button();
            this.mButton3 = new System.Windows.Forms.Button();
            this.mButton4 = new System.Windows.Forms.Button();
            this.mButton5 = new System.Windows.Forms.Button();
            this.mButton6 = new System.Windows.Forms.Button();
            this.mButton7 = new System.Windows.Forms.Button();
            this.mButton8 = new System.Windows.Forms.Button();
            this.mButton9 = new System.Windows.Forms.Button();
            this.mTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mSinglePlayerButton
            // 
            this.mSinglePlayerButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mSinglePlayerButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mSinglePlayerButton.ForeColor = System.Drawing.Color.LightSlateGray;
            this.mSinglePlayerButton.Location = new System.Drawing.Point(565, 350);
            this.mSinglePlayerButton.Name = "mSinglePlayerButton";
            this.mSinglePlayerButton.Size = new System.Drawing.Size(223, 34);
            this.mSinglePlayerButton.TabIndex = 2;
            this.mSinglePlayerButton.Text = "Singleplayer";
            this.mSinglePlayerButton.UseVisualStyleBackColor = false;
            this.mSinglePlayerButton.Click += new System.EventHandler(this.mSinglePlayerButton_Click);
            // 
            // mMultiPlayerButton
            // 
            this.mMultiPlayerButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mMultiPlayerButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mMultiPlayerButton.ForeColor = System.Drawing.Color.LightSlateGray;
            this.mMultiPlayerButton.Location = new System.Drawing.Point(565, 390);
            this.mMultiPlayerButton.Name = "mMultiPlayerButton";
            this.mMultiPlayerButton.Size = new System.Drawing.Size(223, 34);
            this.mMultiPlayerButton.TabIndex = 3;
            this.mMultiPlayerButton.Text = "Multiplayer";
            this.mMultiPlayerButton.UseVisualStyleBackColor = false;
            this.mMultiPlayerButton.Click += new System.EventHandler(this.mMultiPlayerButton_Click);
            // 
            // mLabel1
            // 
            this.mLabel1.BackColor = System.Drawing.Color.Transparent;
            this.mLabel1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabel1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.mLabel1.Location = new System.Drawing.Point(563, 50);
            this.mLabel1.Name = "mLabel1";
            this.mLabel1.Size = new System.Drawing.Size(226, 97);
            this.mLabel1.TabIndex = 4;
            this.mLabel1.Text = "TicTacToe Game";
            this.mLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mLabel2
            // 
            this.mLabel2.BackColor = System.Drawing.Color.Transparent;
            this.mLabel2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabel2.ForeColor = System.Drawing.Color.LightSlateGray;
            this.mLabel2.Location = new System.Drawing.Point(565, 281);
            this.mLabel2.Name = "mLabel2";
            this.mLabel2.Size = new System.Drawing.Size(226, 57);
            this.mLabel2.TabIndex = 5;
            this.mLabel2.Text = "Gamemode: Multiplayer";
            this.mLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mLabel5
            // 
            this.mLabel5.BackColor = System.Drawing.Color.Transparent;
            this.mLabel5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabel5.ForeColor = System.Drawing.Color.LightSlateGray;
            this.mLabel5.Location = new System.Drawing.Point(562, 241);
            this.mLabel5.Name = "mLabel5";
            this.mLabel5.Size = new System.Drawing.Size(226, 32);
            this.mLabel5.TabIndex = 7;
            this.mLabel5.Text = "Player O Score: 0";
            this.mLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mLabel3
            // 
            this.mLabel3.BackColor = System.Drawing.Color.Transparent;
            this.mLabel3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabel3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.mLabel3.Location = new System.Drawing.Point(562, 157);
            this.mLabel3.Name = "mLabel3";
            this.mLabel3.Size = new System.Drawing.Size(226, 24);
            this.mLabel3.TabIndex = 8;
            this.mLabel3.Text = "Turn: Player X";
            this.mLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mLabel4
            // 
            this.mLabel4.BackColor = System.Drawing.Color.Transparent;
            this.mLabel4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mLabel4.ForeColor = System.Drawing.Color.LightSlateGray;
            this.mLabel4.Location = new System.Drawing.Point(563, 214);
            this.mLabel4.Name = "mLabel4";
            this.mLabel4.Size = new System.Drawing.Size(226, 27);
            this.mLabel4.TabIndex = 6;
            this.mLabel4.Text = "Player X Score: 0";
            this.mLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mExitButton
            // 
            this.mExitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mExitButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mExitButton.ForeColor = System.Drawing.Color.LightSlateGray;
            this.mExitButton.Location = new System.Drawing.Point(565, 430);
            this.mExitButton.Name = "mExitButton";
            this.mExitButton.Size = new System.Drawing.Size(223, 34);
            this.mExitButton.TabIndex = 9;
            this.mExitButton.Text = "Exit";
            this.mExitButton.UseVisualStyleBackColor = false;
            this.mExitButton.Click += new System.EventHandler(this.mExitButton_Click);
            // 
            // mButton1
            // 
            this.mButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mButton1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButton1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mButton1.Location = new System.Drawing.Point(26, 22);
            this.mButton1.Name = "mButton1";
            this.mButton1.Size = new System.Drawing.Size(104, 97);
            this.mButton1.TabIndex = 0;
            this.mButton1.UseVisualStyleBackColor = false;
            this.mButton1.Click += new System.EventHandler(this.mButton_Click);
            // 
            // mButton2
            // 
            this.mButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mButton2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButton2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mButton2.Location = new System.Drawing.Point(182, 22);
            this.mButton2.Name = "mButton2";
            this.mButton2.Size = new System.Drawing.Size(104, 97);
            this.mButton2.TabIndex = 1;
            this.mButton2.UseVisualStyleBackColor = false;
            this.mButton2.Click += new System.EventHandler(this.mButton_Click);
            // 
            // mButton3
            // 
            this.mButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mButton3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mButton3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButton3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mButton3.Location = new System.Drawing.Point(338, 22);
            this.mButton3.Name = "mButton3";
            this.mButton3.Size = new System.Drawing.Size(104, 97);
            this.mButton3.TabIndex = 2;
            this.mButton3.UseVisualStyleBackColor = false;
            this.mButton3.Click += new System.EventHandler(this.mButton_Click);
            // 
            // mButton4
            // 
            this.mButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mButton4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mButton4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButton4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mButton4.Location = new System.Drawing.Point(26, 164);
            this.mButton4.Name = "mButton4";
            this.mButton4.Size = new System.Drawing.Size(104, 97);
            this.mButton4.TabIndex = 3;
            this.mButton4.UseVisualStyleBackColor = false;
            this.mButton4.Click += new System.EventHandler(this.mButton_Click);
            // 
            // mButton5
            // 
            this.mButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mButton5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mButton5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButton5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mButton5.Location = new System.Drawing.Point(182, 164);
            this.mButton5.Name = "mButton5";
            this.mButton5.Size = new System.Drawing.Size(104, 97);
            this.mButton5.TabIndex = 4;
            this.mButton5.UseVisualStyleBackColor = false;
            this.mButton5.Click += new System.EventHandler(this.mButton_Click);
            // 
            // mButton6
            // 
            this.mButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mButton6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mButton6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButton6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mButton6.Location = new System.Drawing.Point(338, 164);
            this.mButton6.Name = "mButton6";
            this.mButton6.Size = new System.Drawing.Size(104, 97);
            this.mButton6.TabIndex = 5;
            this.mButton6.UseVisualStyleBackColor = false;
            this.mButton6.Click += new System.EventHandler(this.mButton_Click);
            // 
            // mButton7
            // 
            this.mButton7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mButton7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mButton7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButton7.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mButton7.Location = new System.Drawing.Point(26, 306);
            this.mButton7.Name = "mButton7";
            this.mButton7.Size = new System.Drawing.Size(104, 97);
            this.mButton7.TabIndex = 6;
            this.mButton7.UseVisualStyleBackColor = false;
            this.mButton7.Click += new System.EventHandler(this.mButton_Click);
            // 
            // mButton8
            // 
            this.mButton8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mButton8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mButton8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButton8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mButton8.Location = new System.Drawing.Point(182, 306);
            this.mButton8.Name = "mButton8";
            this.mButton8.Size = new System.Drawing.Size(104, 97);
            this.mButton8.TabIndex = 7;
            this.mButton8.UseVisualStyleBackColor = false;
            this.mButton8.Click += new System.EventHandler(this.mButton_Click);
            // 
            // mButton9
            // 
            this.mButton9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mButton9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mButton9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mButton9.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.mButton9.Location = new System.Drawing.Point(338, 306);
            this.mButton9.Name = "mButton9";
            this.mButton9.Size = new System.Drawing.Size(104, 97);
            this.mButton9.TabIndex = 8;
            this.mButton9.UseVisualStyleBackColor = false;
            this.mButton9.Click += new System.EventHandler(this.mButton_Click);
            // 
            // mTableLayoutPanel
            // 
            this.mTableLayoutPanel.BackgroundImage = global::TicTacToeGame.Properties.Resources.maths_background4;
            this.mTableLayoutPanel.ColumnCount = 3;
            this.mTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mTableLayoutPanel.Controls.Add(this.mButton9, 2, 2);
            this.mTableLayoutPanel.Controls.Add(this.mButton8, 1, 2);
            this.mTableLayoutPanel.Controls.Add(this.mButton7, 0, 2);
            this.mTableLayoutPanel.Controls.Add(this.mButton6, 2, 1);
            this.mTableLayoutPanel.Controls.Add(this.mButton5, 1, 1);
            this.mTableLayoutPanel.Controls.Add(this.mButton4, 0, 1);
            this.mTableLayoutPanel.Controls.Add(this.mButton3, 2, 0);
            this.mTableLayoutPanel.Controls.Add(this.mButton2, 1, 0);
            this.mTableLayoutPanel.Controls.Add(this.mButton1, 0, 0);
            this.mTableLayoutPanel.Location = new System.Drawing.Point(55, 55);
            this.mTableLayoutPanel.Margin = new System.Windows.Forms.Padding(20);
            this.mTableLayoutPanel.Name = "mTableLayoutPanel";
            this.mTableLayoutPanel.RowCount = 3;
            this.mTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mTableLayoutPanel.Size = new System.Drawing.Size(469, 426);
            this.mTableLayoutPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::TicTacToeGame.Properties.Resources.maths_background4;
            this.ClientSize = new System.Drawing.Size(824, 511);
            this.Controls.Add(this.mExitButton);
            this.Controls.Add(this.mLabel3);
            this.Controls.Add(this.mLabel5);
            this.Controls.Add(this.mLabel4);
            this.Controls.Add(this.mLabel2);
            this.Controls.Add(this.mLabel1);
            this.Controls.Add(this.mMultiPlayerButton);
            this.Controls.Add(this.mSinglePlayerButton);
            this.Controls.Add(this.mTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(840, 550);
            this.MinimumSize = new System.Drawing.Size(840, 550);
            this.Name = "Form1";
            this.Text = "TicTacToeGame";
            this.mTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button mSinglePlayerButton;
        private System.Windows.Forms.Button mMultiPlayerButton;
        private System.Windows.Forms.Label mLabel1;
        private System.Windows.Forms.Label mLabel2;
        private System.Windows.Forms.Label mLabel5;
        private System.Windows.Forms.Label mLabel3;
        private System.Windows.Forms.Label mLabel4;
        private System.Windows.Forms.Button mExitButton;
        private System.Windows.Forms.Button mButton1;
        private System.Windows.Forms.Button mButton2;
        private System.Windows.Forms.Button mButton3;
        private System.Windows.Forms.Button mButton4;
        private System.Windows.Forms.Button mButton5;
        private System.Windows.Forms.Button mButton6;
        private System.Windows.Forms.Button mButton7;
        private System.Windows.Forms.Button mButton8;
        private System.Windows.Forms.Button mButton9;
        private System.Windows.Forms.TableLayoutPanel mTableLayoutPanel;
    }
}

