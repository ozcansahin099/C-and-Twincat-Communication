namespace CSharpCommunication
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
            this.labelActualPosition = new System.Windows.Forms.Label();
            this.labelActualVelocity = new System.Windows.Forms.Label();
            this.labelActualAcceleration = new System.Windows.Forms.Label();
            this.labelJerk = new System.Windows.Forms.Label();
            this.labelDeceleration = new System.Windows.Forms.Label();
            this.labelAcceleration = new System.Windows.Forms.Label();
            this.labelVelocity = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.buttonEnable = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonDisable = new System.Windows.Forms.Button();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxVelocity = new System.Windows.Forms.TextBox();
            this.textBoxAcceleration = new System.Windows.Forms.TextBox();
            this.textBoxDeceleration = new System.Windows.Forms.TextBox();
            this.textBoxJerk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelActualPosition
            // 
            this.labelActualPosition.AutoSize = true;
            this.labelActualPosition.Location = new System.Drawing.Point(549, 204);
            this.labelActualPosition.Name = "labelActualPosition";
            this.labelActualPosition.Size = new System.Drawing.Size(75, 13);
            this.labelActualPosition.TabIndex = 0;
            this.labelActualPosition.Text = "actual position";
            // 
            // labelActualVelocity
            // 
            this.labelActualVelocity.AutoSize = true;
            this.labelActualVelocity.Location = new System.Drawing.Point(549, 231);
            this.labelActualVelocity.Name = "labelActualVelocity";
            this.labelActualVelocity.Size = new System.Drawing.Size(75, 13);
            this.labelActualVelocity.TabIndex = 1;
            this.labelActualVelocity.Text = "actual velocity";
            // 
            // labelActualAcceleration
            // 
            this.labelActualAcceleration.AutoSize = true;
            this.labelActualAcceleration.Location = new System.Drawing.Point(549, 259);
            this.labelActualAcceleration.Name = "labelActualAcceleration";
            this.labelActualAcceleration.Size = new System.Drawing.Size(97, 13);
            this.labelActualAcceleration.TabIndex = 2;
            this.labelActualAcceleration.Text = "actual acceleration";
            // 
            // labelJerk
            // 
            this.labelJerk.AutoSize = true;
            this.labelJerk.Location = new System.Drawing.Point(549, 172);
            this.labelJerk.Name = "labelJerk";
            this.labelJerk.Size = new System.Drawing.Size(27, 13);
            this.labelJerk.TabIndex = 3;
            this.labelJerk.Text = "Jerk";
            // 
            // labelDeceleration
            // 
            this.labelDeceleration.AutoSize = true;
            this.labelDeceleration.Location = new System.Drawing.Point(549, 136);
            this.labelDeceleration.Name = "labelDeceleration";
            this.labelDeceleration.Size = new System.Drawing.Size(67, 13);
            this.labelDeceleration.TabIndex = 4;
            this.labelDeceleration.Text = "Deceleration";
            // 
            // labelAcceleration
            // 
            this.labelAcceleration.AutoSize = true;
            this.labelAcceleration.Location = new System.Drawing.Point(549, 101);
            this.labelAcceleration.Name = "labelAcceleration";
            this.labelAcceleration.Size = new System.Drawing.Size(66, 13);
            this.labelAcceleration.TabIndex = 5;
            this.labelAcceleration.Text = "Acceleration";
            // 
            // labelVelocity
            // 
            this.labelVelocity.AutoSize = true;
            this.labelVelocity.Location = new System.Drawing.Point(549, 72);
            this.labelVelocity.Name = "labelVelocity";
            this.labelVelocity.Size = new System.Drawing.Size(43, 13);
            this.labelVelocity.TabIndex = 6;
            this.labelVelocity.Text = "velocity";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(549, 41);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(43, 13);
            this.labelPosition.TabIndex = 7;
            this.labelPosition.Text = "position";
            // 
            // buttonEnable
            // 
            this.buttonEnable.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEnable.Location = new System.Drawing.Point(84, 41);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(84, 23);
            this.buttonEnable.TabIndex = 8;
            this.buttonEnable.Text = "Enable";
            this.buttonEnable.UseVisualStyleBackColor = false;
            this.buttonEnable.Click += new System.EventHandler(this.buttonEnable_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(84, 101);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(84, 23);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonDisable
            // 
            this.buttonDisable.Location = new System.Drawing.Point(84, 72);
            this.buttonDisable.Name = "buttonDisable";
            this.buttonDisable.Size = new System.Drawing.Size(84, 23);
            this.buttonDisable.TabIndex = 10;
            this.buttonDisable.Text = "Disable";
            this.buttonDisable.UseVisualStyleBackColor = true;
            this.buttonDisable.Click += new System.EventHandler(this.buttonDisable_Click);
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(433, 38);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(100, 20);
            this.textBoxPosition.TabIndex = 11;
            this.textBoxPosition.TextChanged += new System.EventHandler(this.textBoxPosition_TextChanged);
            // 
            // textBoxVelocity
            // 
            this.textBoxVelocity.Location = new System.Drawing.Point(433, 69);
            this.textBoxVelocity.Name = "textBoxVelocity";
            this.textBoxVelocity.Size = new System.Drawing.Size(100, 20);
            this.textBoxVelocity.TabIndex = 12;
            this.textBoxVelocity.TextChanged += new System.EventHandler(this.textBoxVelocity_TextChanged);
            // 
            // textBoxAcceleration
            // 
            this.textBoxAcceleration.Location = new System.Drawing.Point(433, 98);
            this.textBoxAcceleration.Name = "textBoxAcceleration";
            this.textBoxAcceleration.Size = new System.Drawing.Size(100, 20);
            this.textBoxAcceleration.TabIndex = 13;
            this.textBoxAcceleration.TextChanged += new System.EventHandler(this.textBoxAcceleration_TextChanged);
            // 
            // textBoxDeceleration
            // 
            this.textBoxDeceleration.Location = new System.Drawing.Point(433, 133);
            this.textBoxDeceleration.Name = "textBoxDeceleration";
            this.textBoxDeceleration.Size = new System.Drawing.Size(100, 20);
            this.textBoxDeceleration.TabIndex = 14;
            this.textBoxDeceleration.TextChanged += new System.EventHandler(this.textBoxDeceleration_TextChanged);
            // 
            // textBoxJerk
            // 
            this.textBoxJerk.Location = new System.Drawing.Point(433, 169);
            this.textBoxJerk.Name = "textBoxJerk";
            this.textBoxJerk.Size = new System.Drawing.Size(100, 20);
            this.textBoxJerk.TabIndex = 15;
            this.textBoxJerk.TextChanged += new System.EventHandler(this.textBoxJerk_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxJerk);
            this.Controls.Add(this.textBoxDeceleration);
            this.Controls.Add(this.textBoxAcceleration);
            this.Controls.Add(this.textBoxVelocity);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.buttonDisable);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonEnable);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelVelocity);
            this.Controls.Add(this.labelAcceleration);
            this.Controls.Add(this.labelDeceleration);
            this.Controls.Add(this.labelJerk);
            this.Controls.Add(this.labelActualAcceleration);
            this.Controls.Add(this.labelActualVelocity);
            this.Controls.Add(this.labelActualPosition);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelActualPosition;
        private System.Windows.Forms.Label labelActualVelocity;
        private System.Windows.Forms.Label labelActualAcceleration;
        private System.Windows.Forms.Label labelJerk;
        private System.Windows.Forms.Label labelDeceleration;
        private System.Windows.Forms.Label labelAcceleration;
        private System.Windows.Forms.Label labelVelocity;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button buttonEnable;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonDisable;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxVelocity;
        private System.Windows.Forms.TextBox textBoxAcceleration;
        private System.Windows.Forms.TextBox textBoxDeceleration;
        private System.Windows.Forms.TextBox textBoxJerk;
    }
}

