using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Email_Sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if(txtEmail.Text == "[Email]")
            {
                txtEmail.Clear();
                txtEmail.ForeColor = Color.FromArgb(0, 0, 255);
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(txtEmail.Text == "")
            {
                txtEmail.Text = "[Email]";
                txtEmail.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void txtSubject_Enter(object sender, EventArgs e)
        {
            if (txtSubject.Text == "[Subject]")
            {
                txtSubject.Clear();
                txtSubject.ForeColor = Color.FromArgb(0, 0, 255);
            }
        }

        private void txtSubject_Leave(object sender, EventArgs e)
        {
            if (txtSubject.Text == "")
            {
                txtSubject.Text = "[Subject]";
                txtSubject.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void txtMessage_Enter(object sender, EventArgs e)
        {
            if (txtMessage.Text == "[Message]")
            {
                txtMessage.Clear();
                txtMessage.ForeColor = Color.FromArgb(0, 0, 255);
            }
        }
        private void txtMessage_Leave(object sender, EventArgs e)
        {
            if (txtMessage.Text == "")
            {
                txtMessage.Text = "[Message]";
                txtMessage.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void bttnLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bttnAttach_Click(object sender, EventArgs e)
        {
            var annex = new OpenFileDialog();
            // Open windows window.
            annex.InitialDirectory = @"Your local here";
            // Designates the initial local where the windows window will open.
            if (annex.ShowDialog() == DialogResult.OK)
            {
                txtAttachs.Text = annex.FileName;
                // Put the attachmment inside the text box.
            }
        }

        private void bttnSend_Click(object sender, EventArgs e)
        {
            string destiny, from, password, body;
            MailMessage message = new MailMessage();
            // Starts a new message.
            destiny = txtEmail.Text;
            // Defines to who the email will be sent.
            from = "Your email here";
            // Your email here, where you gonna send from.
            // *******IMPORTANT*******: The email wich you gonna sent the message has to have less secure apps active, and the IMAP on your gmail haf to be enabled too. To do this:
            // Go to your google account, security, then go to less secure apps acess and activate, in gmail go to configurations and enable IMAP.
            password = "Your password here";
            // Your password here.
            body = txtMessage.Text;
            // The body it's being definied on the text box.
            if (txtAttachs.Text != "")
            {
                message.Attachments.Add(new Attachment(txtAttachs.Text));
            }
            // If your text box it's empty, your application will add the path of the archive in the text box.
            message.To.Add(destiny);
            // Adds the receiver of the message.
            message.From = new MailAddress(from);
            // Adds the sender of the email.
            message.Body = body;
            // Adds the body of the message.
            message.Subject = txtSubject.Text;
            // Defines the subject of the message as being the text from the text box.
            message.IsBodyHtml = true;
            // Tells if the message is in html, because it's going to google it's a html.
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            // Creates the smtp server and defines it as being a gmail.
            client.EnableSsl = true;
            // Defines if the client has the Ssl(Secure Sockets Layer) and because it's a gmail it has Ssl.
            client.Port = 587;
            // Defines the Port that google uses it.
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            // Defines how the email will be sent, in this case it will be sent in a smtp server using the internet.
            client.Credentials = new NetworkCredential(from, password);
            // Defines the credentials(password and user);
            try
            {
                client.Send(message);
                DialogResult code = MessageBox.Show("Email sucefully sent!", "Email sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (code == DialogResult.OK)
                {
                    txtEmail.Clear();
                    txtSubject.Clear();
                    txtMessage.Clear();
                    txtAttachs.Clear();
                }
                // If the messa has been sent it will clean the text fields ans it will show the message that email has been sent.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                // In case of error it will show the error on the screen.
            }
        }
    }
}
