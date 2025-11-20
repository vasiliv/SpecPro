using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime;
using Microsoft.Win32;
using System.Collections;
using System.Security.Cryptography;
using System.Configuration;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace SpecPro
{
    public partial class Form_Dial : Form
    {
        public string user = "";
        public string psw = "";
        public string hash = "";
        public string hash0 = "";
        public string hash1 = "";
        public string conn = "";
        public SqlConnection sss = new SqlConnection();
        public SqlConnection sssg = new SqlConnection();
        public string jg = "";
        public string usname = "";
        public string userno = "";
        public string rrw = "";

        [DllImport("Advapi32.dll", EntryPoint = "GetUserName",
                ExactSpelling = false, SetLastError = true)]
        static extern bool GetUserName(
              [MarshalAs(UnmanagedType.LPArray)] byte[] lpBuffer,
              [MarshalAs(UnmanagedType.LPArray)] Int32[] nSize);

        public Form_Dial()
        {
            InitializeComponent();
        }

        private void pr_load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");

            RegistryKey rkey = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
            rkey.SetValue("sShortDate", "dd/MM/yyyy");
            rkey.SetValue("sLongDate", "dd/MM/yyyy");

            conn = ConfigurationManager.ConnectionStrings["FindId"].ConnectionString;

            sss.ConnectionString = conn;
            sssg.ConnectionString = conn;

            try
            {
                sss.Open();
            }
            catch
            {
                sss.Close();
                sss.Open();
            }
            try
            {
                sssg.Open();
            }
            catch
            {
                sssg.Close();
                sssg.Open();
            }

            char[] cc = new char[256];

            byte[] str = new byte[256];
            Int32[] len = new Int32[1];
            len[0] = 256;
            GetUserName(str, len);

            int i = new int();
            int j = new int();
            j = 0;
            for (i = 0; i <= 256; i++)
            {
                try
                {
                    if (str[i] != 0)
                    {
                        j = j + 1;
                        cc[i] = Convert.ToChar(str[i]);
                    }
                }
                catch
                {
                }
            }

            for (i = 0; i <= j - 1; i++)
            {
                user = user + Convert.ToString(cc[i]);
            }

            try
            {
                FileStream inpt0 = File.Open("c:\\Psw/psw1.ini", FileMode.Open);

                StreamReader rest0 = new StreamReader(inpt0);
                TB_mom.Text = rest0.ReadLine();
                rest0.Close();
            }
            catch
            {
                TB_mom.Text = user;
            }

        }

        private void pr_go(object sender, EventArgs e)
        {
            user = TB_mom.Text;
            psw = TB_psw.Text;
            hash = psw;
            hash0 = "";
            string kol = null;

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();

            byte[] bhes = md5.ComputeHash(enc.GetBytes(hash));

            foreach (byte bt in bhes)
            {

                hash0 += string.Format("{0:X2}", bt);

            }

            SqlCommand Sql = new SqlCommand("", sss);
            SqlCommand Sqlg = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;
            Sqlg.CommandType = CommandType.Text;

            Sql.CommandText = "select count(*) from users where user_name = '" + user + "' and status = 0";

            Sqlg.CommandText = "select count(*) from users where user_name = '" + user + "' and status = 0";

            try
            {

                kol = Sql.ExecuteScalar().ToString();
            }
            catch
            {
                sssg.Open();
                kol = Sqlg.ExecuteScalar().ToString();
            }
            

            if (kol == "0")
            {
                MessageBox.Show(Sql.CommandText);
                TB_mom.Text = "";
                TB_mom.Focus();
            }
            else
            {
                Sql.CommandText = "select user_psw from users where user_name = '" + user + "' and status = 0";
                hash1 = Sql.ExecuteScalar().ToString();
                if (hash0 != hash1)
                {
                    MessageBox.Show("მომხმარებლის პაროლი არასწორია !");
                    TB_psw.Text = "";
                    TB_psw.Focus();
                }
                else
                {
                    try
                    {
                        FileStream otptt = File.Open("c:\\Psw/psw1.ini", FileMode.OpenOrCreate);
                        StreamWriter gamot = new StreamWriter(otptt);
                        gamot.WriteLine(TB_mom.Text);
                        gamot.Close();
                    }
                    catch
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName("c:\\Psw/psw1.ini"));
                        FileStream otptt = File.Open("c:\\Psw/psw1.ini", FileMode.OpenOrCreate);
                        StreamWriter gamot = new StreamWriter(otptt);
                        gamot.WriteLine(TB_mom.Text);
                        gamot.Close();
                    }

                    Form_Spec mainfo = new Form_Spec();
                    mainfo.usname = user;
                    mainfo.conn = conn;

                    Sql.CommandText = "select user_id from users where user_name = '" + user + "'";
                    mainfo.userno = Sql.ExecuteScalar().ToString();

                    Sql.CommandText = "select user_poz from users where user_name = '" + user + "'";
                    mainfo.pozc = Convert.ToInt32(Sql.ExecuteScalar());

                    mainfo.Text = "მომხმარებელი – " + user;
                    mainfo.psw = psw;

                    mainfo.FormClosed += new FormClosedEventHandler(mainfo_FormClosed);
                    mainfo.Show();
                    rrw = mainfo.rrw;
                    Hide();
                }
            }

        }

        void mainfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pr_ent(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                object se = new object();
                EventArgs ee = new EventArgs();
                pr_go(se, ee);
            }

        }

    }
}
