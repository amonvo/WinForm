/*
 * Created by SharpDevelop.
 * User: amonv
 * Date: 17.10.2020
 * Time: 14:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button plusButton;
		private System.Windows.Forms.Button minusButton;
		private System.Windows.Forms.Button multiplyButton;
		private System.Windows.Forms.Button devideButton;
		private System.Windows.Forms.Button resultButton;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button powerButton;
		private System.Windows.Forms.Button squareRootButton;
		private System.Windows.Forms.Button	deleteButton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.plusButton = new System.Windows.Forms.Button();
			this.minusButton = new System.Windows.Forms.Button();
			this.multiplyButton = new System.Windows.Forms.Button();
			this.devideButton = new System.Windows.Forms.Button();
			this.resultButton = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.powerButton = new System.Windows.Forms.Button();
			this.squareRootButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.Location = new System.Drawing.Point(28, 268);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(50, 50);
			this.button1.TabIndex = 0;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.Location = new System.Drawing.Point(96, 268);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(50, 50);
			this.button2.TabIndex = 1;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button3.Location = new System.Drawing.Point(164, 268);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(50, 50);
			this.button3.TabIndex = 2;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button4.Location = new System.Drawing.Point(28, 203);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(50, 50);
			this.button4.TabIndex = 3;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBox1.Location = new System.Drawing.Point(28, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(286, 41);
			this.textBox1.TabIndex = 4;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button5.Location = new System.Drawing.Point(96, 203);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(50, 50);
			this.button5.TabIndex = 5;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button6.Location = new System.Drawing.Point(164, 203);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(50, 50);
			this.button6.TabIndex = 6;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button7.Location = new System.Drawing.Point(28, 142);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(50, 50);
			this.button7.TabIndex = 7;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button8.Location = new System.Drawing.Point(96, 142);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(50, 50);
			this.button8.TabIndex = 8;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button9
			// 
			this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button9.Location = new System.Drawing.Point(164, 142);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(50, 50);
			this.button9.TabIndex = 9;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button10
			// 
			this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button10.Location = new System.Drawing.Point(96, 324);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(50, 50);
			this.button10.TabIndex = 10;
			this.button10.Text = "0";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// plusButton
			// 
			this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.plusButton.Location = new System.Drawing.Point(264, 142);
			this.plusButton.Name = "plusButton";
			this.plusButton.Size = new System.Drawing.Size(50, 50);
			this.plusButton.TabIndex = 11;
			this.plusButton.Text = "+";
			this.plusButton.UseVisualStyleBackColor = true;
			this.plusButton.Click += new System.EventHandler(this.PlusButtonClick);
			// 
			// minusButton
			// 
			this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.minusButton.Location = new System.Drawing.Point(264, 203);
			this.minusButton.Name = "minusButton";
			this.minusButton.Size = new System.Drawing.Size(50, 50);
			this.minusButton.TabIndex = 12;
			this.minusButton.Text = "-";
			this.minusButton.UseVisualStyleBackColor = true;
			this.minusButton.Click += new System.EventHandler(this.MinusButtonClick);
			// 
			// multiplyButton
			// 
			this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.multiplyButton.Location = new System.Drawing.Point(264, 268);
			this.multiplyButton.Name = "multiplyButton";
			this.multiplyButton.Size = new System.Drawing.Size(50, 50);
			this.multiplyButton.TabIndex = 13;
			this.multiplyButton.Text = "*";
			this.multiplyButton.UseVisualStyleBackColor = true;
			this.multiplyButton.Click += new System.EventHandler(this.MultiplyButtonClick);
			// 
			// devideButton
			// 
			this.devideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.devideButton.Location = new System.Drawing.Point(264, 324);
			this.devideButton.Name = "devideButton";
			this.devideButton.Size = new System.Drawing.Size(50, 50);
			this.devideButton.TabIndex = 14;
			this.devideButton.Text = "/";
			this.devideButton.UseVisualStyleBackColor = true;
			this.devideButton.Click += new System.EventHandler(this.DevideButtonClick);
			// 
			// resultButton
			// 
			this.resultButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.resultButton.Location = new System.Drawing.Point(135, 392);
			this.resultButton.Name = "resultButton";
			this.resultButton.Size = new System.Drawing.Size(179, 50);
			this.resultButton.TabIndex = 15;
			this.resultButton.Text = "=";
			this.resultButton.UseVisualStyleBackColor = true;
			this.resultButton.Click += new System.EventHandler(this.ResultButtonClick);
			// 
			// button11
			// 
			this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button11.Location = new System.Drawing.Point(28, 324);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(50, 50);
			this.button11.TabIndex = 16;
			this.button11.Text = ",";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.Button11Click);
			// 
			// powerButton
			// 
			this.powerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.powerButton.Location = new System.Drawing.Point(104, 86);
			this.powerButton.Name = "powerButton";
			this.powerButton.Size = new System.Drawing.Size(55, 50);
			this.powerButton.TabIndex = 17;
			this.powerButton.Text = "x²";
			this.powerButton.UseVisualStyleBackColor = true;
			this.powerButton.Click += new System.EventHandler(this.PowerButtonClick);
			// 
			// squareRootButton
			// 
			this.squareRootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.squareRootButton.Location = new System.Drawing.Point(28, 86);
			this.squareRootButton.Name = "squareRootButton";
			this.squareRootButton.Size = new System.Drawing.Size(70, 50);
			this.squareRootButton.TabIndex = 18;
			this.squareRootButton.Text = "√‾x";
			this.squareRootButton.UseVisualStyleBackColor = true;
			this.squareRootButton.Click += new System.EventHandler(this.squareRootButtonClick);
			// 
			// deleteButton
			// 
			this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.deleteButton.Location = new System.Drawing.Point(164, 326);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(50, 50);
			this.deleteButton.TabIndex = 18;
			this.deleteButton.Text = "CA";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 461);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.squareRootButton);
			this.Controls.Add(this.powerButton);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.resultButton);
			this.Controls.Add(this.devideButton);
			this.Controls.Add(this.multiplyButton);
			this.Controls.Add(this.minusButton);
			this.Controls.Add(this.plusButton);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
