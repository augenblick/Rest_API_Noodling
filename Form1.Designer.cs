﻿namespace RestTest
{
    partial class FormRestTest
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
            this.textRestURI = new System.Windows.Forms.TextBox();
            this.textRestResponse = new System.Windows.Forms.TextBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.labelRestURI = new System.Windows.Forms.Label();
            this.labelResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textRestURI
            // 
            this.textRestURI.Location = new System.Drawing.Point(81, 40);
            this.textRestURI.Name = "textRestURI";
            this.textRestURI.Size = new System.Drawing.Size(369, 20);
            this.textRestURI.TabIndex = 0;
            // 
            // textRestResponse
            // 
            this.textRestResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textRestResponse.Location = new System.Drawing.Point(81, 77);
            this.textRestResponse.Multiline = true;
            this.textRestResponse.Name = "textRestResponse";
            this.textRestResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textRestResponse.Size = new System.Drawing.Size(438, 128);
            this.textRestResponse.TabIndex = 1;
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(456, 38);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 2;
            this.buttonGet.Text = "Get";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // labelRestURI
            // 
            this.labelRestURI.AutoSize = true;
            this.labelRestURI.Location = new System.Drawing.Point(12, 43);
            this.labelRestURI.Name = "labelRestURI";
            this.labelRestURI.Size = new System.Drawing.Size(54, 13);
            this.labelRestURI.TabIndex = 3;
            this.labelRestURI.Text = "Rest URI:";
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Location = new System.Drawing.Point(8, 77);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(58, 13);
            this.labelResponse.TabIndex = 3;
            this.labelResponse.Text = "Response:";
            // 
            // FormRestTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 217);
            this.Controls.Add(this.labelResponse);
            this.Controls.Add(this.labelRestURI);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.textRestResponse);
            this.Controls.Add(this.textRestURI);
            this.Name = "FormRestTest";
            this.Text = "Rest Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRestURI;
        private System.Windows.Forms.TextBox textRestResponse;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Label labelRestURI;
        private System.Windows.Forms.Label labelResponse;
    }
}

