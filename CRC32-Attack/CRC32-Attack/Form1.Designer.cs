namespace CRC32_Attack
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtFlips = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSender = new System.Windows.Forms.GroupBox();
            this.lblSenderSend = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSenderMsg = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblSenderNativeCrc = new System.Windows.Forms.Label();
            this.lblSenderCrc = new System.Windows.Forms.Label();
            this.lblSenderDelta = new System.Windows.Forms.Label();
            this.lblSenderPreprocessed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpAttacker = new System.Windows.Forms.GroupBox();
            this.lblAttackerSend = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAttackerMessage = new System.Windows.Forms.Label();
            this.lblAttackerXoredMsg = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAttackerNativeCrc = new System.Windows.Forms.Label();
            this.lblAttackerDeltaProcessed = new System.Windows.Forms.Label();
            this.lblAttackerCrc = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRecieverCalculatedMsgCRC = new System.Windows.Forms.Label();
            this.lblRecieverCalculatedMsg = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblRecievedCrc = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRecieverNativeCRC = new System.Windows.Forms.Label();
            this.lblRecieverGetMsg = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblRecieverCrc = new System.Windows.Forms.Label();
            this.lblRecieverXorMsg = new System.Windows.Forms.Label();
            this.lblRecieverPreprocessed = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblAttackStatus = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.grpSender.SuspendLayout();
            this.grpAttacker.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(499, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Initiate Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMessage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMessage.Location = new System.Drawing.Point(12, 32);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(250, 27);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "AB0D291AA74D";
            this.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFlips
            // 
            this.txtFlips.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFlips.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFlips.Location = new System.Drawing.Point(268, 32);
            this.txtFlips.Name = "txtFlips";
            this.txtFlips.Size = new System.Drawing.Size(243, 27);
            this.txtFlips.TabIndex = 2;
            this.txtFlips.Text = "4,6,10,20,24,36";
            this.txtFlips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Enter Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Bits that you want to flip (use comma)";
            // 
            // grpSender
            // 
            this.grpSender.Controls.Add(this.lblSenderSend);
            this.grpSender.Controls.Add(this.label11);
            this.grpSender.Controls.Add(this.lblSenderMsg);
            this.grpSender.Controls.Add(this.label16);
            this.grpSender.Controls.Add(this.lblSenderNativeCrc);
            this.grpSender.Controls.Add(this.lblSenderCrc);
            this.grpSender.Controls.Add(this.lblSenderDelta);
            this.grpSender.Controls.Add(this.lblSenderPreprocessed);
            this.grpSender.Controls.Add(this.label6);
            this.grpSender.Controls.Add(this.label5);
            this.grpSender.Controls.Add(this.label4);
            this.grpSender.Controls.Add(this.label3);
            this.grpSender.Location = new System.Drawing.Point(12, 111);
            this.grpSender.Name = "grpSender";
            this.grpSender.Size = new System.Drawing.Size(499, 189);
            this.grpSender.TabIndex = 5;
            this.grpSender.TabStop = false;
            this.grpSender.Text = "Sender Information";
            // 
            // lblSenderSend
            // 
            this.lblSenderSend.AutoSize = true;
            this.lblSenderSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSenderSend.ForeColor = System.Drawing.Color.Red;
            this.lblSenderSend.Location = new System.Drawing.Point(117, 157);
            this.lblSenderSend.Name = "lblSenderSend";
            this.lblSenderSend.Size = new System.Drawing.Size(19, 20);
            this.lblSenderSend.TabIndex = 17;
            this.lblSenderSend.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Sender Sends";
            // 
            // lblSenderMsg
            // 
            this.lblSenderMsg.AutoSize = true;
            this.lblSenderMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSenderMsg.ForeColor = System.Drawing.Color.Red;
            this.lblSenderMsg.Location = new System.Drawing.Point(117, 139);
            this.lblSenderMsg.Name = "lblSenderMsg";
            this.lblSenderMsg.Size = new System.Drawing.Size(19, 20);
            this.lblSenderMsg.TabIndex = 15;
            this.lblSenderMsg.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(6, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Sender Message";
            // 
            // lblSenderNativeCrc
            // 
            this.lblSenderNativeCrc.AutoSize = true;
            this.lblSenderNativeCrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSenderNativeCrc.ForeColor = System.Drawing.Color.Red;
            this.lblSenderNativeCrc.Location = new System.Drawing.Point(274, 103);
            this.lblSenderNativeCrc.Name = "lblSenderNativeCrc";
            this.lblSenderNativeCrc.Size = new System.Drawing.Size(19, 20);
            this.lblSenderNativeCrc.TabIndex = 13;
            this.lblSenderNativeCrc.Text = "0";
            // 
            // lblSenderCrc
            // 
            this.lblSenderCrc.AutoSize = true;
            this.lblSenderCrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSenderCrc.ForeColor = System.Drawing.Color.Red;
            this.lblSenderCrc.Location = new System.Drawing.Point(6, 103);
            this.lblSenderCrc.Name = "lblSenderCrc";
            this.lblSenderCrc.Size = new System.Drawing.Size(19, 20);
            this.lblSenderCrc.TabIndex = 12;
            this.lblSenderCrc.Text = "0";
            // 
            // lblSenderDelta
            // 
            this.lblSenderDelta.AutoSize = true;
            this.lblSenderDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSenderDelta.ForeColor = System.Drawing.Color.Red;
            this.lblSenderDelta.Location = new System.Drawing.Point(5, 47);
            this.lblSenderDelta.Name = "lblSenderDelta";
            this.lblSenderDelta.Size = new System.Drawing.Size(19, 20);
            this.lblSenderDelta.TabIndex = 11;
            this.lblSenderDelta.Text = "0";
            // 
            // lblSenderPreprocessed
            // 
            this.lblSenderPreprocessed.AutoSize = true;
            this.lblSenderPreprocessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSenderPreprocessed.ForeColor = System.Drawing.Color.Red;
            this.lblSenderPreprocessed.Location = new System.Drawing.Point(274, 47);
            this.lblSenderPreprocessed.Name = "lblSenderPreprocessed";
            this.lblSenderPreprocessed.Size = new System.Drawing.Size(19, 20);
            this.lblSenderPreprocessed.TabIndex = 10;
            this.lblSenderPreprocessed.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(275, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sender Native CRC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sender CRC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(275, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preprocessed Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Delta of Message";
            // 
            // grpAttacker
            // 
            this.grpAttacker.Controls.Add(this.lblAttackerSend);
            this.grpAttacker.Controls.Add(this.label10);
            this.grpAttacker.Controls.Add(this.lblAttackerMessage);
            this.grpAttacker.Controls.Add(this.lblAttackerXoredMsg);
            this.grpAttacker.Controls.Add(this.label9);
            this.grpAttacker.Controls.Add(this.label8);
            this.grpAttacker.Controls.Add(this.lblAttackerNativeCrc);
            this.grpAttacker.Controls.Add(this.lblAttackerDeltaProcessed);
            this.grpAttacker.Controls.Add(this.lblAttackerCrc);
            this.grpAttacker.Controls.Add(this.label12);
            this.grpAttacker.Controls.Add(this.label13);
            this.grpAttacker.Controls.Add(this.label14);
            this.grpAttacker.Location = new System.Drawing.Point(8, 306);
            this.grpAttacker.Name = "grpAttacker";
            this.grpAttacker.Size = new System.Drawing.Size(503, 189);
            this.grpAttacker.TabIndex = 14;
            this.grpAttacker.TabStop = false;
            this.grpAttacker.Text = "Attacker Information";
            // 
            // lblAttackerSend
            // 
            this.lblAttackerSend.AutoSize = true;
            this.lblAttackerSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAttackerSend.ForeColor = System.Drawing.Color.Red;
            this.lblAttackerSend.Location = new System.Drawing.Point(129, 155);
            this.lblAttackerSend.Name = "lblAttackerSend";
            this.lblAttackerSend.Size = new System.Drawing.Size(19, 20);
            this.lblAttackerSend.TabIndex = 19;
            this.lblAttackerSend.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(12, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Attacker Sends";
            // 
            // lblAttackerMessage
            // 
            this.lblAttackerMessage.AutoSize = true;
            this.lblAttackerMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAttackerMessage.ForeColor = System.Drawing.Color.Red;
            this.lblAttackerMessage.Location = new System.Drawing.Point(129, 135);
            this.lblAttackerMessage.Name = "lblAttackerMessage";
            this.lblAttackerMessage.Size = new System.Drawing.Size(19, 20);
            this.lblAttackerMessage.TabIndex = 17;
            this.lblAttackerMessage.Text = "0";
            // 
            // lblAttackerXoredMsg
            // 
            this.lblAttackerXoredMsg.AutoSize = true;
            this.lblAttackerXoredMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAttackerXoredMsg.ForeColor = System.Drawing.Color.Red;
            this.lblAttackerXoredMsg.Location = new System.Drawing.Point(10, 48);
            this.lblAttackerXoredMsg.Name = "lblAttackerXoredMsg";
            this.lblAttackerXoredMsg.Size = new System.Drawing.Size(19, 20);
            this.lblAttackerXoredMsg.TabIndex = 14;
            this.lblAttackerXoredMsg.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Attacker Message";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Attacker Get XoRed Message";
            // 
            // lblAttackerNativeCrc
            // 
            this.lblAttackerNativeCrc.AutoSize = true;
            this.lblAttackerNativeCrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAttackerNativeCrc.ForeColor = System.Drawing.Color.Red;
            this.lblAttackerNativeCrc.Location = new System.Drawing.Point(277, 105);
            this.lblAttackerNativeCrc.Name = "lblAttackerNativeCrc";
            this.lblAttackerNativeCrc.Size = new System.Drawing.Size(19, 20);
            this.lblAttackerNativeCrc.TabIndex = 12;
            this.lblAttackerNativeCrc.Text = "0";
            // 
            // lblAttackerDeltaProcessed
            // 
            this.lblAttackerDeltaProcessed.AutoSize = true;
            this.lblAttackerDeltaProcessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAttackerDeltaProcessed.ForeColor = System.Drawing.Color.Red;
            this.lblAttackerDeltaProcessed.Location = new System.Drawing.Point(277, 48);
            this.lblAttackerDeltaProcessed.Name = "lblAttackerDeltaProcessed";
            this.lblAttackerDeltaProcessed.Size = new System.Drawing.Size(19, 20);
            this.lblAttackerDeltaProcessed.TabIndex = 11;
            this.lblAttackerDeltaProcessed.Text = "0";
            // 
            // lblAttackerCrc
            // 
            this.lblAttackerCrc.AutoSize = true;
            this.lblAttackerCrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAttackerCrc.ForeColor = System.Drawing.Color.Red;
            this.lblAttackerCrc.Location = new System.Drawing.Point(10, 105);
            this.lblAttackerCrc.Name = "lblAttackerCrc";
            this.lblAttackerCrc.Size = new System.Drawing.Size(19, 20);
            this.lblAttackerCrc.TabIndex = 10;
            this.lblAttackerCrc.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(277, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Attacker Native CRC";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(11, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Attacker CRC";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(278, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(189, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Preprocessed Delta Message";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRecieverCalculatedMsgCRC);
            this.groupBox1.Controls.Add(this.lblRecieverCalculatedMsg);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.lblRecievedCrc);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblRecieverNativeCRC);
            this.groupBox1.Controls.Add(this.lblRecieverGetMsg);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.lblRecieverCrc);
            this.groupBox1.Controls.Add(this.lblRecieverXorMsg);
            this.groupBox1.Controls.Add(this.lblRecieverPreprocessed);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Location = new System.Drawing.Point(8, 501);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 222);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receiver Information";
            // 
            // lblRecieverCalculatedMsgCRC
            // 
            this.lblRecieverCalculatedMsgCRC.AutoSize = true;
            this.lblRecieverCalculatedMsgCRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecieverCalculatedMsgCRC.ForeColor = System.Drawing.Color.Red;
            this.lblRecieverCalculatedMsgCRC.Location = new System.Drawing.Point(278, 100);
            this.lblRecieverCalculatedMsgCRC.Name = "lblRecieverCalculatedMsgCRC";
            this.lblRecieverCalculatedMsgCRC.Size = new System.Drawing.Size(19, 20);
            this.lblRecieverCalculatedMsgCRC.TabIndex = 23;
            this.lblRecieverCalculatedMsgCRC.Text = "0";
            // 
            // lblRecieverCalculatedMsg
            // 
            this.lblRecieverCalculatedMsg.AutoSize = true;
            this.lblRecieverCalculatedMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecieverCalculatedMsg.ForeColor = System.Drawing.Color.Red;
            this.lblRecieverCalculatedMsg.Location = new System.Drawing.Point(9, 100);
            this.lblRecieverCalculatedMsg.Name = "lblRecieverCalculatedMsg";
            this.lblRecieverCalculatedMsg.Size = new System.Drawing.Size(19, 20);
            this.lblRecieverCalculatedMsg.TabIndex = 22;
            this.lblRecieverCalculatedMsg.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(278, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(190, 16);
            this.label18.TabIndex = 21;
            this.label18.Text = "Receiver Calculated Msg CRC";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(10, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(190, 16);
            this.label22.TabIndex = 20;
            this.label22.Text = "Receiver Calculated Message";
            // 
            // lblRecievedCrc
            // 
            this.lblRecievedCrc.AutoSize = true;
            this.lblRecievedCrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecievedCrc.ForeColor = System.Drawing.Color.Red;
            this.lblRecievedCrc.Location = new System.Drawing.Point(146, 195);
            this.lblRecievedCrc.Name = "lblRecievedCrc";
            this.lblRecievedCrc.Size = new System.Drawing.Size(19, 20);
            this.lblRecievedCrc.TabIndex = 19;
            this.lblRecievedCrc.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(10, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 18;
            this.label15.Text = "Receiver CRC";
            // 
            // lblRecieverNativeCRC
            // 
            this.lblRecieverNativeCRC.AutoSize = true;
            this.lblRecieverNativeCRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecieverNativeCRC.ForeColor = System.Drawing.Color.Red;
            this.lblRecieverNativeCRC.Location = new System.Drawing.Point(146, 175);
            this.lblRecieverNativeCRC.Name = "lblRecieverNativeCRC";
            this.lblRecieverNativeCRC.Size = new System.Drawing.Size(19, 20);
            this.lblRecieverNativeCRC.TabIndex = 17;
            this.lblRecieverNativeCRC.Text = "0";
            // 
            // lblRecieverGetMsg
            // 
            this.lblRecieverGetMsg.AutoSize = true;
            this.lblRecieverGetMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecieverGetMsg.ForeColor = System.Drawing.Color.Red;
            this.lblRecieverGetMsg.Location = new System.Drawing.Point(10, 48);
            this.lblRecieverGetMsg.Name = "lblRecieverGetMsg";
            this.lblRecieverGetMsg.Size = new System.Drawing.Size(19, 20);
            this.lblRecieverGetMsg.TabIndex = 14;
            this.lblRecieverGetMsg.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(10, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(136, 16);
            this.label19.TabIndex = 16;
            this.label19.Text = "Receiver Native CRC";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(11, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 16);
            this.label20.TabIndex = 13;
            this.label20.Text = "Receiver Get Message";
            // 
            // lblRecieverCrc
            // 
            this.lblRecieverCrc.AutoSize = true;
            this.lblRecieverCrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecieverCrc.ForeColor = System.Drawing.Color.Red;
            this.lblRecieverCrc.Location = new System.Drawing.Point(279, 146);
            this.lblRecieverCrc.Name = "lblRecieverCrc";
            this.lblRecieverCrc.Size = new System.Drawing.Size(19, 20);
            this.lblRecieverCrc.TabIndex = 12;
            this.lblRecieverCrc.Text = "0";
            // 
            // lblRecieverXorMsg
            // 
            this.lblRecieverXorMsg.AutoSize = true;
            this.lblRecieverXorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecieverXorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblRecieverXorMsg.Location = new System.Drawing.Point(279, 48);
            this.lblRecieverXorMsg.Name = "lblRecieverXorMsg";
            this.lblRecieverXorMsg.Size = new System.Drawing.Size(19, 20);
            this.lblRecieverXorMsg.TabIndex = 11;
            this.lblRecieverXorMsg.Text = "0";
            // 
            // lblRecieverPreprocessed
            // 
            this.lblRecieverPreprocessed.AutoSize = true;
            this.lblRecieverPreprocessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecieverPreprocessed.ForeColor = System.Drawing.Color.Red;
            this.lblRecieverPreprocessed.Location = new System.Drawing.Point(10, 146);
            this.lblRecieverPreprocessed.Name = "lblRecieverPreprocessed";
            this.lblRecieverPreprocessed.Size = new System.Drawing.Size(19, 20);
            this.lblRecieverPreprocessed.TabIndex = 10;
            this.lblRecieverPreprocessed.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(279, 126);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(94, 16);
            this.label24.TabIndex = 8;
            this.label24.Text = "Receiver CRC";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(11, 124);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(181, 16);
            this.label25.TabIndex = 7;
            this.label25.Text = "Receiver Preprocessed Msg";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(280, 26);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(205, 16);
            this.label26.TabIndex = 6;
            this.label26.Text = "Receiver Calculate Xor Message";
            // 
            // lblAttackStatus
            // 
            this.lblAttackStatus.AutoSize = true;
            this.lblAttackStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAttackStatus.ForeColor = System.Drawing.Color.Black;
            this.lblAttackStatus.Location = new System.Drawing.Point(152, 734);
            this.lblAttackStatus.Name = "lblAttackStatus";
            this.lblAttackStatus.Size = new System.Drawing.Size(101, 20);
            this.lblAttackStatus.TabIndex = 21;
            this.lblAttackStatus.Text = "In Progress";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(16, 736);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 16);
            this.label21.TabIndex = 20;
            this.label21.Text = "Attack Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(523, 768);
            this.Controls.Add(this.lblAttackStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.grpAttacker);
            this.Controls.Add(this.grpSender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFlips);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRC32 Attack";
            this.grpSender.ResumeLayout(false);
            this.grpSender.PerformLayout();
            this.grpAttacker.ResumeLayout(false);
            this.grpAttacker.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtFlips;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSender;
        private System.Windows.Forms.Label lblSenderNativeCrc;
        private System.Windows.Forms.Label lblSenderCrc;
        private System.Windows.Forms.Label lblSenderDelta;
        private System.Windows.Forms.Label lblSenderPreprocessed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpAttacker;
        private System.Windows.Forms.Label lblAttackerDeltaProcessed;
        private System.Windows.Forms.Label lblAttackerCrc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSenderMsg;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblAttackerXoredMsg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAttackerNativeCrc;
        private System.Windows.Forms.Label lblAttackerMessage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAttackerSend;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblSenderSend;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRecievedCrc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblRecieverNativeCRC;
        private System.Windows.Forms.Label lblRecieverGetMsg;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblRecieverCrc;
        private System.Windows.Forms.Label lblRecieverXorMsg;
        private System.Windows.Forms.Label lblRecieverPreprocessed;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblAttackStatus;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblRecieverCalculatedMsgCRC;
        private System.Windows.Forms.Label lblRecieverCalculatedMsg;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
    }
}

