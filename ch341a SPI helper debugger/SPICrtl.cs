using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class spihelper : Form
    {
        public spihelper()
        {
            InitializeComponent();
        }


        //for more information about native lib,please check the CH341DLL.h file
        [DllImport("CH341DLL.DLL")]
        public static extern bool CH341StreamSPI4(int index, int iChipSelect, int iLength, byte[] buf);

        [DllImport("CH341DLL.DLL")]
        public static extern bool CH341SetStream(int index, int m);

        [DllImport("CH341DLL.DLL")]
        public static extern bool CH341OpenDevice(int index);

        [DllImport("CH341DLL.DLL")]
        public static extern void CH341CloseDevice(int index);

        private byte[] strToToHexByte(string hexString)
        {
            try { 
                hexString = hexString.Replace(" ", "");
                if ((hexString.Length % 2) != 0)
                    hexString += "0";
                byte[] returnBytes = new byte[hexString.Length / 2];
                for (int i = 0; i < returnBytes.Length; i++)
                    returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                return returnBytes;
            }catch(FormatException e){
                MessageBox.Show("illegal hex value");
                return null;
            }
        }
        public string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2")+" ";
                }
            }
            return returnStr;
        }

        private void open341_Click(object sender, EventArgs e)
        {
            if (CH341OpenDevice(0)&&CH341SetStream(0, 0x81))
            {
                Message.Text = "Ch341A is ready!";
                open341.Enabled = false;
                close341.Enabled = true;
                datalen.Enabled = true;
                formatdw.Enabled = true;
                dataw.Enabled = true;
                datar.Enabled = true;
                transport.Enabled = true;
                datalen.Enabled = true;
                claerdataw.Enabled = true;
                cleardatar.Enabled = true;
            }
            else
            {
                Message.Text = "Ch341A is not ready,cheak your deriver and hardware";
            }
            
        }
        private void transport_Click(object sender, EventArgs e)
        {
            int lenth = int.Parse(datalen.Text);
            byte[] wbuff = strToToHexByte(dataw.Text);
            if (wbuff == null) return;
            byte[] rbuff = new byte[lenth];
            for (int i = 0; i < wbuff.Length; i++)
            {
                if(rbuff.Length>i)rbuff[i] = wbuff[i];
            }
            bool r = CH341StreamSPI4(0, 0x80,lenth , rbuff);
            datar.Text = byteToHexStr(rbuff);
            if(r) Message.Text = "transport scuess";
            formatDataw();
        }

        private void close341_Click(object sender, EventArgs e)
        {
            CH341CloseDevice(0);
            Message.Text = "Ch341A is closed!";
            open341.Enabled = true;
            close341.Enabled = false;
            datalen.Enabled = false;
            dataw.Enabled = false;
            datar.Enabled = false;
            transport.Enabled = false;
            claerdataw.Enabled = false;
            formatdw.Enabled = false;
            cleardatar.Enabled = false;
            datalen.Enabled = false;
            Message.Text = "close Ch341A fail!";
        }

        private void claerdataw_Click(object sender, EventArgs e)
        {
            dataw.Text = "";
        }

        private void cleardatar_Click(object sender, EventArgs e)
        {
            datar.Text = "";
        }

        private void formatDataw()
        {
            byte[] hex = strToToHexByte(dataw.Text);
            if (hex == null) return;
            dataw.Text = byteToHexStr(hex);
            countDataw.Text = "count: " + dataw.Text.Length / 3 +" byte";
        }

        private void formatdw_Click(object sender, EventArgs e)
        {
            formatDataw();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ziyaofeng @ https://github.com/ziyaofeng");
        }


    }
}
