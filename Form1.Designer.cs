namespace Picture_Puzzle_Game
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.play_btn = new System.Windows.Forms.Button();
			this.moves_label = new System.Windows.Forms.Label();
			this.timer_label = new System.Windows.Forms.Label();
			this.example_pictureBox = new System.Windows.Forms.PictureBox();
			//this.splitter1 = new System.Windows.Forms.Splitter();
			this.label1 = new System.Windows.Forms.Label();
			this.autoSolve_btn = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.score_label = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.example_pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(26, 59);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(270, 270);
			this.panel1.TabIndex = 0;
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(90, 180);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(90, 90);
			this.button8.TabIndex = 7;
			this.button8.TabStop = false;
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(0, 180);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(90, 90);
			this.button7.TabIndex = 6;
			this.button7.TabStop = false;
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(180, 90);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(90, 90);
			this.button6.TabIndex = 5;
			this.button6.TabStop = false;
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(90, 90);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(90, 90);
			this.button5.TabIndex = 4;
			this.button5.TabStop = false;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(0, 90);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(90, 90);
			this.button4.TabIndex = 3;
			this.button4.TabStop = false;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(180, 0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(90, 90);
			this.button3.TabIndex = 2;
			this.button3.TabStop = false;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(90, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 90);
			this.button2.TabIndex = 1;
			this.button2.TabStop = false;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 90);
			this.button1.TabIndex = 0;
			this.button1.TabStop = false;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// play_btn
			// 
			this.play_btn.Location = new System.Drawing.Point(327, 369);
			this.play_btn.Name = "play_btn";
			this.play_btn.Size = new System.Drawing.Size(100, 50);
			this.play_btn.TabIndex = 8;
			this.play_btn.TabStop = false;
			this.play_btn.Text = "Play";
			this.play_btn.UseVisualStyleBackColor = true;
			this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
			// 
			// moves_label
			// 
			this.moves_label.AutoSize = true;
			this.moves_label.BackColor = System.Drawing.SystemColors.Window;
			this.moves_label.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.moves_label.ForeColor = System.Drawing.Color.DodgerBlue;
			this.moves_label.Location = new System.Drawing.Point(41, 359);
			this.moves_label.Name = "moves_label";
			this.moves_label.Size = new System.Drawing.Size(142, 32);
			this.moves_label.TabIndex = 0;
			this.moves_label.Text = "Total moves";
			// 
			// timer_label
			// 
			this.timer_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.timer_label.AutoSize = true;
			this.timer_label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.timer_label.Location = new System.Drawing.Point(359, 75);
			this.timer_label.Name = "timer_label";
			this.timer_label.Size = new System.Drawing.Size(158, 46);
			this.timer_label.TabIndex = 10;
			this.timer_label.Text = "00:00:00";
			// 
			// example_pictureBox
			// 
			this.example_pictureBox.Location = new System.Drawing.Point(584, 31);
			this.example_pictureBox.Name = "example_pictureBox";
			this.example_pictureBox.Size = new System.Drawing.Size(360, 360);
			this.example_pictureBox.TabIndex = 11;
			this.example_pictureBox.TabStop = false;
			// 
			// splitter1
			// 
			//this.splitter1.Location = new System.Drawing.Point(0, 0);
			//this.splitter1.Name = "splitter1";
			//this.splitter1.Size = new System.Drawing.Size(4, 498);
			//this.splitter1.TabIndex = 12;
			//this.splitter1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(380, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 46);
			this.label1.TabIndex = 13;
			this.label1.Text = "Time";
			// 
			// autoSolve_btn
			// 
			this.autoSolve_btn.Location = new System.Drawing.Point(462, 369);
			this.autoSolve_btn.Name = "autoSolve_btn";
			this.autoSolve_btn.Size = new System.Drawing.Size(100, 50);
			this.autoSolve_btn.TabIndex = 14;
			this.autoSolve_btn.Text = "AutoSolve";
			this.autoSolve_btn.UseVisualStyleBackColor = true;
			this.autoSolve_btn.Click += new System.EventHandler(this.autoSolve_btn_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// score_label
			// 
			this.score_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.score_label.AutoSize = true;
			this.score_label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.score_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.score_label.Location = new System.Drawing.Point(347, 193);
			this.score_label.Name = "score_label";
			this.score_label.Size = new System.Drawing.Size(126, 46);
			this.score_label.TabIndex = 15;
			this.score_label.Text = "Score :";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(966, 498);
			this.Controls.Add(this.score_label);
			this.Controls.Add(this.autoSolve_btn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.example_pictureBox);
			this.Controls.Add(this.timer_label);
			this.Controls.Add(this.moves_label);
			this.Controls.Add(this.play_btn);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Picture Puzzle Game";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.example_pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Panel panel1;
		private Button button8;
		private Button button7;
		private Button button6;
		private Button button5;
		private Button button4;
		private Button button3;
		private Button button2;
		private Button button1;
		private Button play_btn;
		private Label moves_label;
		private Label timer_label;
		private PictureBox example_pictureBox;
		private Splitter splitter1;
		private Label label1;
		private Button autoSolve_btn;
		private System.Windows.Forms.Timer timer1;
		private Label score_label;
	}
}