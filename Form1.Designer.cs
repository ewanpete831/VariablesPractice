
namespace VariablesPractice
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
            this.outputLabel = new System.Windows.Forms.Label();
            this.hockeyButton = new System.Windows.Forms.Button();
            this.areaButton = new System.Windows.Forms.Button();
            this.carpetButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(184, 32);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(372, 355);
            this.outputLabel.TabIndex = 0;
            // 
            // hockeyButton
            // 
            this.hockeyButton.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hockeyButton.Location = new System.Drawing.Point(30, 32);
            this.hockeyButton.Name = "hockeyButton";
            this.hockeyButton.Size = new System.Drawing.Size(124, 58);
            this.hockeyButton.TabIndex = 1;
            this.hockeyButton.Text = "Hockey";
            this.hockeyButton.UseVisualStyleBackColor = true;
            this.hockeyButton.Click += new System.EventHandler(this.hockeyButton_click);
            // 
            // areaButton
            // 
            this.areaButton.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areaButton.Location = new System.Drawing.Point(30, 119);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(124, 58);
            this.areaButton.TabIndex = 2;
            this.areaButton.Text = "Area";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_click);
            // 
            // carpetButton
            // 
            this.carpetButton.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpetButton.Location = new System.Drawing.Point(30, 225);
            this.carpetButton.Name = "carpetButton";
            this.carpetButton.Size = new System.Drawing.Size(124, 58);
            this.carpetButton.TabIndex = 3;
            this.carpetButton.Text = "Carpet";
            this.carpetButton.UseVisualStyleBackColor = true;
            this.carpetButton.Click += new System.EventHandler(this.carpetButton_click);
            // 
            // billButton
            // 
            this.billButton.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billButton.Location = new System.Drawing.Point(30, 329);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(124, 58);
            this.billButton.TabIndex = 4;
            this.billButton.Text = "Bill";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(605, 421);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.carpetButton);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.hockeyButton);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Variables Practice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button hockeyButton;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Button carpetButton;
        private System.Windows.Forms.Button billButton;
    }
}

