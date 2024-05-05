
namespace Encode
{
    partial class Decodeform
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
            this.VigenereCipher_btn = new System.Windows.Forms.Button();
            this.RC2_btn = new System.Windows.Forms.Button();
            this.AtbashCipher_btn = new System.Windows.Forms.Button();
            this.MD5_btn = new System.Windows.Forms.Button();
            this.Caesar_btn = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.VigenereCipher_txt = new System.Windows.Forms.TextBox();
            this.RC2_txt = new System.Windows.Forms.TextBox();
            this.AtbashCipher_txt = new System.Windows.Forms.TextBox();
            this.MD5_txt = new System.Windows.Forms.TextBox();
            this.Caesar_txt = new System.Windows.Forms.TextBox();
            this.String_btn = new System.Windows.Forms.Button();
            this.string_mtehod = new System.Windows.Forms.TextBox();
            this.LabelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VigenereCipher_btn
            // 
            this.VigenereCipher_btn.Location = new System.Drawing.Point(12, 267);
            this.VigenereCipher_btn.Name = "VigenereCipher_btn";
            this.VigenereCipher_btn.Size = new System.Drawing.Size(103, 29);
            this.VigenereCipher_btn.TabIndex = 25;
            this.VigenereCipher_btn.Text = "VigenereCipher";
            this.VigenereCipher_btn.UseVisualStyleBackColor = true;
            this.VigenereCipher_btn.Click += new System.EventHandler(this.VigenereCipher_Click);
            // 
            // RC2_btn
            // 
            this.RC2_btn.Location = new System.Drawing.Point(12, 231);
            this.RC2_btn.Name = "RC2_btn";
            this.RC2_btn.Size = new System.Drawing.Size(103, 29);
            this.RC2_btn.TabIndex = 24;
            this.RC2_btn.Text = "RC2";
            this.RC2_btn.UseVisualStyleBackColor = true;
            this.RC2_btn.Click += new System.EventHandler(this.RSAEncryption_btn_Click);
            // 
            // AtbashCipher_btn
            // 
            this.AtbashCipher_btn.Location = new System.Drawing.Point(12, 194);
            this.AtbashCipher_btn.Name = "AtbashCipher_btn";
            this.AtbashCipher_btn.Size = new System.Drawing.Size(103, 29);
            this.AtbashCipher_btn.TabIndex = 23;
            this.AtbashCipher_btn.Text = "AtbashCipher";
            this.AtbashCipher_btn.UseVisualStyleBackColor = true;
            this.AtbashCipher_btn.Click += new System.EventHandler(this.AtbashCipher_btn_Click);
            // 
            // MD5_btn
            // 
            this.MD5_btn.Location = new System.Drawing.Point(12, 159);
            this.MD5_btn.Name = "MD5_btn";
            this.MD5_btn.Size = new System.Drawing.Size(103, 29);
            this.MD5_btn.TabIndex = 22;
            this.MD5_btn.Text = "MD5";
            this.MD5_btn.UseVisualStyleBackColor = true;
            this.MD5_btn.Click += new System.EventHandler(this.MD5_btn_Click);
            // 
            // Caesar_btn
            // 
            this.Caesar_btn.Location = new System.Drawing.Point(12, 122);
            this.Caesar_btn.Name = "Caesar_btn";
            this.Caesar_btn.Size = new System.Drawing.Size(103, 29);
            this.Caesar_btn.TabIndex = 21;
            this.Caesar_btn.Text = "Caesar";
            this.Caesar_btn.UseVisualStyleBackColor = true;
            this.Caesar_btn.Click += new System.EventHandler(this.Caesar_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(12, 37);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(733, 20);
            this.txt.TabIndex = 20;
            // 
            // VigenereCipher_txt
            // 
            this.VigenereCipher_txt.Location = new System.Drawing.Point(121, 272);
            this.VigenereCipher_txt.Name = "VigenereCipher_txt";
            this.VigenereCipher_txt.Size = new System.Drawing.Size(624, 20);
            this.VigenereCipher_txt.TabIndex = 19;
            // 
            // RC2_txt
            // 
            this.RC2_txt.Location = new System.Drawing.Point(121, 236);
            this.RC2_txt.Name = "RC2_txt";
            this.RC2_txt.Size = new System.Drawing.Size(624, 20);
            this.RC2_txt.TabIndex = 18;
            // 
            // AtbashCipher_txt
            // 
            this.AtbashCipher_txt.Location = new System.Drawing.Point(121, 199);
            this.AtbashCipher_txt.Name = "AtbashCipher_txt";
            this.AtbashCipher_txt.Size = new System.Drawing.Size(624, 20);
            this.AtbashCipher_txt.TabIndex = 17;
            // 
            // MD5_txt
            // 
            this.MD5_txt.Location = new System.Drawing.Point(121, 164);
            this.MD5_txt.Name = "MD5_txt";
            this.MD5_txt.Size = new System.Drawing.Size(624, 20);
            this.MD5_txt.TabIndex = 16;
            // 
            // Caesar_txt
            // 
            this.Caesar_txt.Location = new System.Drawing.Point(121, 127);
            this.Caesar_txt.Name = "Caesar_txt";
            this.Caesar_txt.Size = new System.Drawing.Size(624, 20);
            this.Caesar_txt.TabIndex = 15;
            // 
            // String_btn
            // 
            this.String_btn.Location = new System.Drawing.Point(12, 88);
            this.String_btn.Name = "String_btn";
            this.String_btn.Size = new System.Drawing.Size(103, 29);
            this.String_btn.TabIndex = 14;
            this.String_btn.Text = "String Method";
            this.String_btn.UseVisualStyleBackColor = true;
            this.String_btn.Click += new System.EventHandler(this.String_btn_Click_1);
            // 
            // string_mtehod
            // 
            this.string_mtehod.Location = new System.Drawing.Point(121, 91);
            this.string_mtehod.Name = "string_mtehod";
            this.string_mtehod.Size = new System.Drawing.Size(624, 20);
            this.string_mtehod.TabIndex = 13;
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Location = new System.Drawing.Point(12, 21);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(122, 13);
            this.LabelText.TabIndex = 26;
            this.LabelText.Text = "Please enter your code: ";
            // 
            // Decodeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 310);
            this.Controls.Add(this.LabelText);
            this.Controls.Add(this.VigenereCipher_btn);
            this.Controls.Add(this.RC2_btn);
            this.Controls.Add(this.AtbashCipher_btn);
            this.Controls.Add(this.MD5_btn);
            this.Controls.Add(this.Caesar_btn);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.VigenereCipher_txt);
            this.Controls.Add(this.RC2_txt);
            this.Controls.Add(this.AtbashCipher_txt);
            this.Controls.Add(this.MD5_txt);
            this.Controls.Add(this.Caesar_txt);
            this.Controls.Add(this.String_btn);
            this.Controls.Add(this.string_mtehod);
            this.Name = "Decodeform";
            this.Text = "Decode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button VigenereCipher_btn;
        private System.Windows.Forms.Button RC2_btn;
        private System.Windows.Forms.Button AtbashCipher_btn;
        private System.Windows.Forms.Button MD5_btn;
        private System.Windows.Forms.Button Caesar_btn;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox VigenereCipher_txt;
        private System.Windows.Forms.TextBox RC2_txt;
        private System.Windows.Forms.TextBox AtbashCipher_txt;
        private System.Windows.Forms.TextBox MD5_txt;
        private System.Windows.Forms.TextBox Caesar_txt;
        private System.Windows.Forms.Button String_btn;
        private System.Windows.Forms.TextBox string_mtehod;
        private System.Windows.Forms.Label LabelText;
    }
}