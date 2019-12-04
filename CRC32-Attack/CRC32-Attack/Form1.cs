using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections;
using Crc32C;
using Force.Crc32;


namespace CRC32_Attack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string generateHexStringFromByteArray(byte[] input)
        {
            string hexString = BitConverter.ToString(input);
            return hexString.Replace("-", "");
        }

        public static byte[] hexStringToByteArray(string hex)
        {
            while (hex.Length < 8)
            {
                hex = "0" + hex;
            }
            int numberChars = hex.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public static byte[] exclusiveOR(byte[] arr1, byte[] arr2)
        {
            byte[] result = new byte[arr1.Length];

            for (int i = 0; i < arr1.Length; ++i)
                result[i] = (byte)(arr1[i] ^ arr2[i]);

            return result;
        }

        public static byte Reverse(byte inByte)
        {
            byte result = 0x00;

            for (byte mask = 0x80; Convert.ToInt32(mask) > 0; mask >>= 1)
            {
                // shift right current result
                result = (byte)(result >> 1);

                // tempbyte = 1 if there is a 1 in the current position
                var tempbyte = (byte)(inByte & mask);
                if (tempbyte != 0x00)
                {
                    // Insert a 1 in the left
                    result = (byte)(result | 0x80);
                }
            }

            return (result);
        }

        public static byte[] Preprocessing(string message)
        {
            var byteArr = hexStringToByteArray(message);
            var byteArrList = new byte[byteArr.Length];

            for (int i = 0; i <= 3; i++)
            {
                var reversedByte = Reverse(byteArr[i]);
                var num = Convert.ToInt32(reversedByte);
                byteArrList[i] = (byte)~reversedByte;
            }

            if (byteArr.Length > 4)
            {
                for (int i = 4; i < byteArr.Length; i++)
                {
                    var reversedByte = Reverse(byteArr[i]);
                    byteArrList[i] = reversedByte;
                }
            }

            return byteArrList;
        }

        public static byte[] PostProcessing(string crc)
        {
            var crcByteArr = hexStringToByteArray(crc);
            var crcByteArrList = new byte[crcByteArr.Length];
            Array.Reverse(crcByteArr, 0, crcByteArr.Length);
            for (int i = 0; i < crcByteArr.Length; i++)
            {
                var reversedByte = Reverse(crcByteArr[i]);
                crcByteArrList[i] = (byte)~reversedByte;
            }

            return crcByteArrList;
        }

        public static byte[] BitArrayToByteArray(BitArray bits)
        {
            byte[] ret = new byte[(bits.Length - 1) / 8 + 1];
            bits.CopyTo(ret, 0);
            return ret;
        }

        public static BitArray GenerateBitArrayWithFlips(List<int> flipVals, int len)
        {
            var flipsBits = new BitArray(len);
            foreach (var flipVal in flipVals)
            {
                flipsBits[flipVal - 1] = true;
            }
            return flipsBits;
        }

        public static String CalculateCRC(byte[] input)
        {
            var crc = Crc32Algorithm.Compute(input).ToString("X");
            while (crc.Length < 8)
            {
                crc = "0" + crc;
            }

            return crc;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var str = txtMessage.Text;
            var strFlips = txtFlips.Text.Split(',');
            var flipVals = new List<int>();
            foreach (var strFlip in strFlips)
            {
                flipVals.Add(Convert.ToInt32(strFlip));
            }

            var preprocessedByteArr = Preprocessing(str);
            var crc32Val = CalculateCRC(preprocessedByteArr);
            var postprocessedByteArr = PostProcessing(crc32Val);
            var crcSender = generateHexStringFromByteArray(postprocessedByteArr);

            var senderMessage = str + crcSender;
            var xoredHex = "";
            for (int i = 0; i < senderMessage.Length; i++)
            {
                xoredHex += "F";
            }

            var xoredMessageHex = generateHexStringFromByteArray(exclusiveOR(hexStringToByteArray(senderMessage), hexStringToByteArray(xoredHex)));
            //MessageBox.Show(xoredMessageHex);

            var flipsBits = GenerateBitArrayWithFlips(flipVals, str.Length * 4);

            var byteFlips = BitArrayToByteArray(flipsBits);
            Array.Reverse(byteFlips, 0, byteFlips.Length);
            var flipHex = generateHexStringFromByteArray(byteFlips);

            var preprocessedByteFlip = Preprocessing(flipHex);
            var crc32FlipVal = CalculateCRC(preprocessedByteFlip);
            //MessageBox.Show("Attacker PreProcessed CRC --> " + crc32FlipVal);
            var postProcessedByteFlip = PostProcessing(crc32FlipVal);
            var crcAttacker = generateHexStringFromByteArray(postProcessedByteFlip);
            //MessageBox.Show("Attacker PostProcessed CRC --> " + crcAttacker);

            var attackerMessage = flipHex + crcAttacker;
            var xoredAttackerMessageHex = generateHexStringFromByteArray(exclusiveOR(hexStringToByteArray(attackerMessage), hexStringToByteArray(xoredMessageHex)));
            //MessageBox.Show("Reciever that recieve Message --> " + xoredAttackerMessageHex);

            var xoredRecieverGetMessageHex = generateHexStringFromByteArray(exclusiveOR(hexStringToByteArray(xoredAttackerMessageHex), hexStringToByteArray(xoredHex)));
            //MessageBox.Show("Reciever XoRed Message --> " + xoredRecieverGetMessageHex);

            String recieverIncomeCrc = "", recieverIncomeMessage = "";
            for (int i = 0; i < xoredRecieverGetMessageHex.Length; i++)
            {
                var condVal = xoredRecieverGetMessageHex.Length - crcAttacker.Length;
                if (i < condVal) recieverIncomeMessage += xoredRecieverGetMessageHex[i];
                else recieverIncomeCrc += xoredRecieverGetMessageHex[i];
            }

            //MessageBox.Show("Reciever Incoming CRC --> " + recieverIncomeCrc);
            //MessageBox.Show("Reciever Incoming Message --> " + recieverIncomeMessage);

            var preProcessedByteRecieve = Preprocessing(recieverIncomeMessage);
            var crc32RecieverVal = CalculateCRC(preProcessedByteRecieve);
            //MessageBox.Show("Reciever Incoming Message PostProcessed CRC --> " + crc32RecieverVal);
            var postProcessedByteRecieve = PostProcessing(crc32RecieverVal);
            var crcReciever = generateHexStringFromByteArray(postProcessedByteRecieve);
            if (crcReciever == recieverIncomeCrc)
            {
                lblAttackStatus.ForeColor = Color.Green;
                lblAttackStatus.Text = "Attack is valid!";
            }
            else
            {
                lblAttackStatus.ForeColor = Color.Red;
                lblAttackStatus.Text = "Attack is not valid!";
            }

            lblSenderDelta.Text = flipHex;
            lblSenderCrc.Text = crc32Val;
            lblSenderPreprocessed.Text = generateHexStringFromByteArray(preprocessedByteArr);
            lblSenderNativeCrc.Text = crcSender;
            lblSenderMsg.Text = senderMessage;
            lblSenderSend.Text = xoredMessageHex;

            lblAttackerXoredMsg.Text = xoredMessageHex;
            lblAttackerDeltaProcessed.Text = generateHexStringFromByteArray(preprocessedByteFlip);
            lblAttackerCrc.Text = crc32FlipVal;
            lblAttackerNativeCrc.Text = crcAttacker;
            lblAttackerMessage.Text = attackerMessage;
            lblAttackerSend.Text = xoredAttackerMessageHex;

            lblRecieverGetMsg.Text = xoredAttackerMessageHex;
            lblRecieverXorMsg.Text = xoredRecieverGetMessageHex;
            lblRecieverCrc.Text = crc32RecieverVal;
            lblRecieverNativeCRC.Text = crcReciever;
            lblRecievedCrc.Text = recieverIncomeCrc;
            lblRecieverPreprocessed.Text = generateHexStringFromByteArray(preProcessedByteRecieve);
            lblRecieverCalculatedMsg.Text = recieverIncomeMessage;
            lblRecieverCalculatedMsgCRC.Text = recieverIncomeCrc;
        }
    }
}
