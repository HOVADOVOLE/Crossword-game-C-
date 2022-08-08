namespace CrossWord
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
            this.lblMiss = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMiss
            // 
            this.lblMiss.AutoSize = true;
            this.lblMiss.Location = new System.Drawing.Point(12, 9);
            this.lblMiss.Name = "lblMiss";
            this.lblMiss.Size = new System.Drawing.Size(81, 20);
            this.lblMiss.TabIndex = 0;
            this.lblMiss.Text = "Mistakes: 0";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(365, 298);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(50, 27);
            this.txtInput.TabIndex = 1;
            this.txtInput.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtInput_PreviewKeyDown);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(440, 296);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(94, 29);
            this.btnSub.TabIndex = 2;
            this.btnSub.Text = "Submit";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblMiss);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crossword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMiss;
        private TextBox txtInput;
        private Button btnSub;
    }
}