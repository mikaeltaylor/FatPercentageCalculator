namespace FatPercentageCalculator
{
    partial class fatPercentageForm
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
            this.totalCaloriesInputLabel = new System.Windows.Forms.Label();
            this.fatGramsInputLabel = new System.Windows.Forms.Label();
            this.lowFatInputLabel = new System.Windows.Forms.Label();
            this.totalCaloriesInputText = new System.Windows.Forms.TextBox();
            this.fatGramsInputText = new System.Windows.Forms.TextBox();
            this.lowFatInputCheckbox = new System.Windows.Forms.CheckBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.totalCaloriesOutputLabel = new System.Windows.Forms.Label();
            this.fatGramsOutputLabel = new System.Windows.Forms.Label();
            this.fatCaloriePercentOutputLabel = new System.Windows.Forms.Label();
            this.lowFatOutputLabel = new System.Windows.Forms.Label();
            this.totalCaloriesOutputResults = new System.Windows.Forms.Label();
            this.fatGramsOutputResults = new System.Windows.Forms.Label();
            this.fatPercentageOutputResults = new System.Windows.Forms.Label();
            this.fatCaloriesOutputLabel = new System.Windows.Forms.Label();
            this.fatCaloriesOutputResults = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalCaloriesInputLabel
            // 
            this.totalCaloriesInputLabel.AutoSize = true;
            this.totalCaloriesInputLabel.Location = new System.Drawing.Point(66, 28);
            this.totalCaloriesInputLabel.Name = "totalCaloriesInputLabel";
            this.totalCaloriesInputLabel.Size = new System.Drawing.Size(74, 13);
            this.totalCaloriesInputLabel.TabIndex = 0;
            this.totalCaloriesInputLabel.Text = "Total Calories:";
            // 
            // fatGramsInputLabel
            // 
            this.fatGramsInputLabel.AutoSize = true;
            this.fatGramsInputLabel.Location = new System.Drawing.Point(82, 50);
            this.fatGramsInputLabel.Name = "fatGramsInputLabel";
            this.fatGramsInputLabel.Size = new System.Drawing.Size(58, 13);
            this.fatGramsInputLabel.TabIndex = 1;
            this.fatGramsInputLabel.Text = "Fat Grams:";
            // 
            // lowFatInputLabel
            // 
            this.lowFatInputLabel.AutoSize = true;
            this.lowFatInputLabel.Location = new System.Drawing.Point(13, 72);
            this.lowFatInputLabel.Name = "lowFatInputLabel";
            this.lowFatInputLabel.Size = new System.Drawing.Size(273, 13);
            this.lowFatInputLabel.TabIndex = 2;
            this.lowFatInputLabel.Text = "Would you like to know if the food is considered low fat?";
            // 
            // totalCaloriesInputText
            // 
            this.totalCaloriesInputText.Location = new System.Drawing.Point(146, 25);
            this.totalCaloriesInputText.Name = "totalCaloriesInputText";
            this.totalCaloriesInputText.Size = new System.Drawing.Size(100, 20);
            this.totalCaloriesInputText.TabIndex = 3;
            this.totalCaloriesInputText.TextChanged += new System.EventHandler(this.totalCaloriesInputText_TextChanged);
            this.totalCaloriesInputText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalCaloriesInputText_KeyPress);
            // 
            // fatGramsInputText
            // 
            this.fatGramsInputText.Location = new System.Drawing.Point(146, 47);
            this.fatGramsInputText.Name = "fatGramsInputText";
            this.fatGramsInputText.Size = new System.Drawing.Size(100, 20);
            this.fatGramsInputText.TabIndex = 4;
            this.fatGramsInputText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fatGramsInputText_KeyPress);
            // 
            // lowFatInputCheckbox
            // 
            this.lowFatInputCheckbox.AutoSize = true;
            this.lowFatInputCheckbox.Location = new System.Drawing.Point(146, 89);
            this.lowFatInputCheckbox.Name = "lowFatInputCheckbox";
            this.lowFatInputCheckbox.Size = new System.Drawing.Size(44, 17);
            this.lowFatInputCheckbox.TabIndex = 5;
            this.lowFatInputCheckbox.Text = "Yes";
            this.lowFatInputCheckbox.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(65, 112);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // totalCaloriesOutputLabel
            // 
            this.totalCaloriesOutputLabel.AutoSize = true;
            this.totalCaloriesOutputLabel.Location = new System.Drawing.Point(97, 151);
            this.totalCaloriesOutputLabel.Name = "totalCaloriesOutputLabel";
            this.totalCaloriesOutputLabel.Size = new System.Drawing.Size(74, 13);
            this.totalCaloriesOutputLabel.TabIndex = 7;
            this.totalCaloriesOutputLabel.Text = "Total Calories:";
            // 
            // fatGramsOutputLabel
            // 
            this.fatGramsOutputLabel.AutoSize = true;
            this.fatGramsOutputLabel.Location = new System.Drawing.Point(113, 164);
            this.fatGramsOutputLabel.Name = "fatGramsOutputLabel";
            this.fatGramsOutputLabel.Size = new System.Drawing.Size(58, 13);
            this.fatGramsOutputLabel.TabIndex = 8;
            this.fatGramsOutputLabel.Text = "Fat Grams:";
            // 
            // fatCaloriePercentOutputLabel
            // 
            this.fatCaloriePercentOutputLabel.AutoSize = true;
            this.fatCaloriePercentOutputLabel.Location = new System.Drawing.Point(13, 188);
            this.fatCaloriePercentOutputLabel.Name = "fatCaloriePercentOutputLabel";
            this.fatCaloriePercentOutputLabel.Size = new System.Drawing.Size(158, 13);
            this.fatCaloriePercentOutputLabel.TabIndex = 9;
            this.fatCaloriePercentOutputLabel.Text = "Percentage of Calories from Fat:";
            // 
            // lowFatOutputLabel
            // 
            this.lowFatOutputLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lowFatOutputLabel.Location = new System.Drawing.Point(0, 202);
            this.lowFatOutputLabel.Name = "lowFatOutputLabel";
            this.lowFatOutputLabel.Size = new System.Drawing.Size(311, 26);
            this.lowFatOutputLabel.TabIndex = 10;
            this.lowFatOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCaloriesOutputResults
            // 
            this.totalCaloriesOutputResults.AutoSize = true;
            this.totalCaloriesOutputResults.Location = new System.Drawing.Point(177, 151);
            this.totalCaloriesOutputResults.Name = "totalCaloriesOutputResults";
            this.totalCaloriesOutputResults.Size = new System.Drawing.Size(13, 13);
            this.totalCaloriesOutputResults.TabIndex = 11;
            this.totalCaloriesOutputResults.Text = "0";
            // 
            // fatGramsOutputResults
            // 
            this.fatGramsOutputResults.AutoSize = true;
            this.fatGramsOutputResults.Location = new System.Drawing.Point(177, 164);
            this.fatGramsOutputResults.Name = "fatGramsOutputResults";
            this.fatGramsOutputResults.Size = new System.Drawing.Size(13, 13);
            this.fatGramsOutputResults.TabIndex = 12;
            this.fatGramsOutputResults.Text = "0";
            // 
            // fatPercentageOutputResults
            // 
            this.fatPercentageOutputResults.AutoSize = true;
            this.fatPercentageOutputResults.Location = new System.Drawing.Point(177, 188);
            this.fatPercentageOutputResults.Name = "fatPercentageOutputResults";
            this.fatPercentageOutputResults.Size = new System.Drawing.Size(13, 13);
            this.fatPercentageOutputResults.TabIndex = 13;
            this.fatPercentageOutputResults.Text = "0";
            // 
            // fatCaloriesOutputLabel
            // 
            this.fatCaloriesOutputLabel.AutoSize = true;
            this.fatCaloriesOutputLabel.Location = new System.Drawing.Point(105, 175);
            this.fatCaloriesOutputLabel.Name = "fatCaloriesOutputLabel";
            this.fatCaloriesOutputLabel.Size = new System.Drawing.Size(65, 13);
            this.fatCaloriesOutputLabel.TabIndex = 14;
            this.fatCaloriesOutputLabel.Text = "Fat Calories:";
            // 
            // fatCaloriesOutputResults
            // 
            this.fatCaloriesOutputResults.AutoSize = true;
            this.fatCaloriesOutputResults.Location = new System.Drawing.Point(177, 175);
            this.fatCaloriesOutputResults.Name = "fatCaloriesOutputResults";
            this.fatCaloriesOutputResults.Size = new System.Drawing.Size(13, 13);
            this.fatCaloriesOutputResults.TabIndex = 15;
            this.fatCaloriesOutputResults.Text = "0";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(189, 112);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 16;
            this.clearButton.Text = "Clear Results";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // fatPercentageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 228);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.fatCaloriesOutputResults);
            this.Controls.Add(this.fatCaloriesOutputLabel);
            this.Controls.Add(this.fatPercentageOutputResults);
            this.Controls.Add(this.fatGramsOutputResults);
            this.Controls.Add(this.totalCaloriesOutputResults);
            this.Controls.Add(this.lowFatOutputLabel);
            this.Controls.Add(this.fatCaloriePercentOutputLabel);
            this.Controls.Add(this.fatGramsOutputLabel);
            this.Controls.Add(this.totalCaloriesOutputLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.lowFatInputCheckbox);
            this.Controls.Add(this.fatGramsInputText);
            this.Controls.Add(this.totalCaloriesInputText);
            this.Controls.Add(this.lowFatInputLabel);
            this.Controls.Add(this.fatGramsInputLabel);
            this.Controls.Add(this.totalCaloriesInputLabel);
            this.Name = "fatPercentageForm";
            this.Text = "Fat Percentage Calculator v1.0";
            this.Load += new System.EventHandler(this.fatPercentageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalCaloriesInputLabel;
        private System.Windows.Forms.Label fatGramsInputLabel;
        private System.Windows.Forms.Label lowFatInputLabel;
        private System.Windows.Forms.TextBox totalCaloriesInputText;
        private System.Windows.Forms.TextBox fatGramsInputText;
        private System.Windows.Forms.CheckBox lowFatInputCheckbox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label totalCaloriesOutputLabel;
        private System.Windows.Forms.Label fatGramsOutputLabel;
        private System.Windows.Forms.Label fatCaloriePercentOutputLabel;
        private System.Windows.Forms.Label lowFatOutputLabel;
        private System.Windows.Forms.Label totalCaloriesOutputResults;
        private System.Windows.Forms.Label fatGramsOutputResults;
        private System.Windows.Forms.Label fatPercentageOutputResults;
        private System.Windows.Forms.Label fatCaloriesOutputLabel;
        private System.Windows.Forms.Label fatCaloriesOutputResults;
        private System.Windows.Forms.Button clearButton;
    }
}

