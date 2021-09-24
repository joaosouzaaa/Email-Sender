
namespace Email_Sender
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.bttnAttach = new System.Windows.Forms.Button();
            this.txtAttachs = new System.Windows.Forms.TextBox();
            this.bttnSend = new System.Windows.Forms.Button();
            this.bttnLeave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Email_Sender.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtEmail.Location = new System.Drawing.Point(12, 191);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 30);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Text = "[Email]";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(91, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email Sender";
            // 
            // txtSubject
            // 
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtSubject.Location = new System.Drawing.Point(12, 237);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(334, 30);
            this.txtSubject.TabIndex = 5;
            this.txtSubject.Text = "[Subject]";
            this.txtSubject.Enter += new System.EventHandler(this.txtSubject_Enter);
            this.txtSubject.Leave += new System.EventHandler(this.txtSubject_Leave);
            // 
            // txtMessage
            // 
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtMessage.Location = new System.Drawing.Point(12, 273);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(334, 147);
            this.txtMessage.TabIndex = 6;
            this.txtMessage.Text = "[Message]";
            this.txtMessage.Enter += new System.EventHandler(this.txtMessage_Enter);
            this.txtMessage.Leave += new System.EventHandler(this.txtMessage_Leave);
            // 
            // bttnAttach
            // 
            this.bttnAttach.BackColor = System.Drawing.SystemColors.Highlight;
            this.bttnAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAttach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAttach.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnAttach.Location = new System.Drawing.Point(201, 426);
            this.bttnAttach.Name = "bttnAttach";
            this.bttnAttach.Size = new System.Drawing.Size(145, 32);
            this.bttnAttach.TabIndex = 7;
            this.bttnAttach.Text = "Attach Files";
            this.bttnAttach.UseVisualStyleBackColor = false;
            this.bttnAttach.Click += new System.EventHandler(this.bttnAttach_Click);
            // 
            // txtAttachs
            // 
            this.txtAttachs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttachs.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtAttachs.Location = new System.Drawing.Point(12, 433);
            this.txtAttachs.Multiline = true;
            this.txtAttachs.Name = "txtAttachs";
            this.txtAttachs.Size = new System.Drawing.Size(183, 22);
            this.txtAttachs.TabIndex = 8;
            // 
            // bttnSend
            // 
            this.bttnSend.BackColor = System.Drawing.SystemColors.Highlight;
            this.bttnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSend.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnSend.Location = new System.Drawing.Point(12, 464);
            this.bttnSend.Name = "bttnSend";
            this.bttnSend.Size = new System.Drawing.Size(334, 69);
            this.bttnSend.TabIndex = 9;
            this.bttnSend.Text = "Send email";
            this.bttnSend.UseVisualStyleBackColor = false;
            this.bttnSend.Click += new System.EventHandler(this.bttnSend_Click);
            // 
            // bttnLeave
            // 
            this.bttnLeave.BackColor = System.Drawing.SystemColors.Highlight;
            this.bttnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnLeave.ForeColor = System.Drawing.SystemColors.Window;
            this.bttnLeave.Location = new System.Drawing.Point(56, 539);
            this.bttnLeave.Name = "bttnLeave";
            this.bttnLeave.Size = new System.Drawing.Size(220, 41);
            this.bttnLeave.TabIndex = 10;
            this.bttnLeave.Text = "Leave Aplicattion";
            this.bttnLeave.UseVisualStyleBackColor = false;
            this.bttnLeave.Click += new System.EventHandler(this.bttnLeave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(358, 585);
            this.Controls.Add(this.bttnLeave);
            this.Controls.Add(this.bttnSend);
            this.Controls.Add(this.txtAttachs);
            this.Controls.Add(this.bttnAttach);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button bttnAttach;
        private System.Windows.Forms.TextBox txtAttachs;
        private System.Windows.Forms.Button bttnSend;
        private System.Windows.Forms.Button bttnLeave;
    }
}

