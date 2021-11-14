namespace ModemKraKor
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxTerminal = new System.Windows.Forms.TextBox();
            this.buttonStopConnection = new System.Windows.Forms.Button();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.textBoxSendMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCommand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(13, 13);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(191, 51);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Połącz z modemem port szeregowy";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(210, 28);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(123, 20);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Brak połączenia";
            // 
            // textBoxTerminal
            // 
            this.textBoxTerminal.Location = new System.Drawing.Point(436, 12);
            this.textBoxTerminal.Multiline = true;
            this.textBoxTerminal.Name = "textBoxTerminal";
            this.textBoxTerminal.Size = new System.Drawing.Size(697, 371);
            this.textBoxTerminal.TabIndex = 2;
            // 
            // buttonStopConnection
            // 
            this.buttonStopConnection.Location = new System.Drawing.Point(12, 70);
            this.buttonStopConnection.Name = "buttonStopConnection";
            this.buttonStopConnection.Size = new System.Drawing.Size(191, 51);
            this.buttonStopConnection.TabIndex = 3;
            this.buttonStopConnection.Text = "Zakończ połączenie";
            this.buttonStopConnection.UseVisualStyleBackColor = true;
            this.buttonStopConnection.Click += new System.EventHandler(this.buttonStopConnection_Click);
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(13, 127);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(191, 51);
            this.buttonSendMessage.TabIndex = 4;
            this.buttonSendMessage.Text = "Wyślij wiadomość";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // textBoxSendMessage
            // 
            this.textBoxSendMessage.Location = new System.Drawing.Point(210, 152);
            this.textBoxSendMessage.Name = "textBoxSendMessage";
            this.textBoxSendMessage.Size = new System.Drawing.Size(216, 26);
            this.textBoxSendMessage.TabIndex = 5;
            this.textBoxSendMessage.Enter += new System.EventHandler(this.textBoxSendMessage_Enter);
            this.textBoxSendMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSendMessage_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wpisz wiadomość:";
            // 
            // buttonCommand
            // 
            this.buttonCommand.Location = new System.Drawing.Point(214, 70);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(191, 51);
            this.buttonCommand.TabIndex = 11;
            this.buttonCommand.Text = "Wejdź w tryb komend";
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 987);
            this.Controls.Add(this.buttonCommand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSendMessage);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.buttonStopConnection);
            this.Controls.Add(this.textBoxTerminal);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxTerminal;
        private System.Windows.Forms.Button buttonStopConnection;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.TextBox textBoxSendMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCommand;
    }
}

