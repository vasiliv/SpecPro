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
using System.Configuration;
using System.Globalization;
using Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Web;
using System.Net;
using System.Net.Http;

namespace SpecPro
{

    public partial class Form_Spec : Form
    {
        public uint SW_SHOW;

        [DllImport("Kernel32.dll")]
        static extern bool WinExec(string PAnsiChar, uint cardinal);

        public string conn = "";
        public SqlConnection sss = new SqlConnection();
        public SqlConnection sss1 = new SqlConnection();
        public SqlConnection sssg = new SqlConnection();
        public SqlConnection sssa = new SqlConnection();
        public SqlCommand Sql = new SqlCommand();
        public SqlCommand Sql1 = new SqlCommand();
        public SqlCommand Sqlg = new SqlCommand();
        public SqlCommand Sqla = new SqlCommand();
        public string usname = "";
        public string userno = "";
        public string psw = "";
        public int pozc = 0;
        public string rrw;
        public SqlDataAdapter ddbru;
        public WebClient webclient = new WebClient();
        public string dges = "";
        public int chmenpoz = 0;
        public int rezhim = 0;
        public int izm = 0;
        public string note = "";
        public string infi = "";
        public int spec0 = 0;
        public int stat0 = 0;
        public int cust0 = 0;
        public string repr0 = "";
        public int rowcur;
        public int moqme = 0;
        public int shag = 0;
        public string[,] filters = new string[4, 500];
        public string[,] filters1 = new string[4, 500];
        public int nomit = 0;
        public int nomit1 = 0;
        public string filter;
        public string filter1;
        public string filter_base = "";
        public string filter_bru = "";
        public byte[] bytes;
        public int av = 0;
        public int krfi = 0;
        public string auqt0;
        public int valmoqme = 0;
        public string indv = "0";
        public int colug = 0;
        public int rowg = 0;
        public int rowwg = 0;
        public int mx;
        public int my;
        
        /*public struct useridliq
        {
            public string user;
            public int user_id;
        };*/  

        public Form_Spec()
        {
            InitializeComponent();
        }

        private void pr_step1(object sender, EventArgs e)
        {
            Pa_psw.BringToFront();
            Pa_psw.Visible = true;
            TB_dzve.Text = "";
            TB_aha.Text = "";
            TB_aha.Enabled = false;
        }

        private void pr_cl_psw(object sender, EventArgs e)
        {
            Pa_psw.Visible = false;
            TB_dzve.Text = "";
            TB_aha.Text = "";
        }

        private void pr_loadmain(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'turnoverDataSet.iso' table. You can move, or remove it, as needed.
            /*this.TA_kur.Fill(this.dS_kur.iso);*/
            // TODO: This line of code loads data into the 'sproDataSet.auqtipe' table. You can move, or remove it, as needed.
            /*this.TA_auqt.Fill(this.DS_auqt.auqtipe);*/
            /*userid[] uuu = new userid[10];

            uuu[0].user = "Davit";
            uuu[0].user_id = 1;*/

            // TODO: This line of code loads data into the 'dS_pdf.files1' table. You can move, or remove it, as needed.
            /*this.TA_pdf.Fill(this.dS_pdf.files1);*/
            // TODO: This line of code loads data into the 'dS_rep.acc' table. You can move, or remove it, as needed.
            /*this.TA_rep.Fill(this.dS_rep.acc);*/
            // TODO: This line of code loads data into the 'dS_bru.receipts' table. You can move, or remove it, as needed.
            /*this.TA_bru.Fill(this.dS_bru.receipts);*/
            // TODO: This line of code loads data into the 'dS_kod.codes' table. You can move, or remove it, as needed.
            /*this.TA_kod.Fill(this.dS_kod.codes);*/
            // TODO: This line of code loads data into the 'dS_log.logs' table. You can move, or remove it, as needed.
            /*this.TA_log.Fill(this.dS_log.logs);*/
            // TODO: This line of code loads data into the 'dS_buy.buyers' table. You can move, or remove it, as needed.
            /*this.TA_buy.Fill(this.dS_buy.buyers);*/
            // TODO: This line of code loads data into the 'dS_repr.represent' table. You can move, or remove it, as needed.
            /*this.TA_repr.Fill(this.dS_repr.represent);*/
            // TODO: This line of code loads data into the 'dS_prep.prep_tbl' table. You can move, or remove it, as needed.
            //this.TA_prep.Fill(this.dS_prep.prep_tbl);
            // TODO: This line of code loads data into the 'dS_cust.customers' table. You can move, or remove it, as needed.
            //this.TA_cust.Fill(this.dS_cust.customers);
            // TODO: This line of code loads data into the 'dS_stat.status' table. You can move, or remove it, as needed.
            //this.TA_stat.Fill(this.dS_stat.status);
            // TODO: This line of code loads data into the 'dS_spec.specialists' table. You can move, or remove it, as needed.
            //this.TA_spec.Fill(this.dS_spec.specialists);
            // TODO: This line of code loads data into the 'dS_info.info' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dS_info.info' table. You can move, or remove it, as needed.
            //this.TA_info.Fill(this.dS_info.info);
            // TODO: This line of code loads data into the 'dS_usr.users' table. You can move, or remove it, as needed.
            /*this.TA_usr.Fill(this.dS_usr.users);*/

            /*BS_cust.CurrentItemChanged -= pr_cust;*/

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");

            dges = DateTime.Today.ToString("dd/MM/yyyy");

            filter_bru = "dt = '" + dges + "'";

            dges = dges.Substring(6, 4) + dges.Substring(3, 2) + dges.Substring(0, 2);

            Random rr = new Random();
            rrw = rr.Next().ToString().Substring(0, 5).Trim();

            TP_work.CustomFormat = "dd/MM/yyyy";

            TP_work.Value = DateTime.Today;

            TB_ad_date.CustomFormat = "dd/MM/yyyy";
            TB_dt_mort.CustomFormat = "dd/MM/yyyy";

            TB_post_send.CustomFormat = "dd/MM/yyyy";
            TB_tnt_send.CustomFormat = "dd/MM/yyyy";
            TB_courier.CustomFormat = "dd/MM/yyyy";
            TB_tel.CustomFormat = "dd/MM/yyyy";
            TB_rez.CustomFormat = "dd/MM/yyyy";
            TB_macne.CustomFormat = "dd/MM/yyyy";
            TB_auc_start.CustomFormat = "dd/MM/yyyy";
            TB_auc_end.CustomFormat = "dd/MM/yyyy";

            TB_post1_send.CustomFormat = "dd/MM/yyyy";
            TB_tnt1_send.CustomFormat = "dd/MM/yyyy";
            TB_courier1.CustomFormat = "dd/MM/yyyy";
            TB_tel1.CustomFormat = "dd/MM/yyyy";
            TB_rez1.CustomFormat = "dd/MM/yyyy";
            TB_macne1.CustomFormat = "dd/MM/yyyy";
            TB_auc1_start.CustomFormat = "dd/MM/yyyy";
            TB_auc1_end.CustomFormat = "dd/MM/yyyy";

            TB_post2_send.CustomFormat = "dd/MM/yyyy";
            TB_tnt2_send.CustomFormat = "dd/MM/yyyy";
            TB_courier2.CustomFormat = "dd/MM/yyyy";
            TB_tel2.CustomFormat = "dd/MM/yyyy";
            TB_rez2.CustomFormat = "dd/MM/yyyy";
            TB_macne2.CustomFormat = "dd/MM/yyyy";
            TB_auc2_start.CustomFormat = "dd/MM/yyyy";
            TB_auc2_end.CustomFormat = "dd/MM/yyyy";

            TP_end.CustomFormat = "dd/MM/yyyy";

            TP_auc2.CustomFormat = "dd/MM/yyyy";
            TP_auc3.CustomFormat = "dd/MM/yyyy";
            TP_gaz.CustomFormat = "dd/MM/yyyy";
            TP_mac.CustomFormat = "dd/MM/yyyy";

            TP_rep_ot.CustomFormat = "dd/MM/yyyy";
            TP_rep_do.CustomFormat = "dd/MM/yyyy";

            TB_tarval.CustomFormat = "dd/MM/yyyy";

            TB_ad_date.Value = DateTime.Today.AddDays(1);
            TB_dt_mort.Value = DateTime.Today.AddDays(1);

            TB_post_send.Value = DateTime.Today.AddDays(1);
            TB_tnt_send.Value = DateTime.Today.AddDays(1);
            TB_courier.Value = DateTime.Today.AddDays(1);
            TB_tel.Value = DateTime.Today.AddDays(1);
            TB_rez.Value = DateTime.Today.AddDays(1);
            TB_macne.Value = DateTime.Today.AddDays(1);
            TB_auc_start.Value = DateTime.Today.AddDays(1);
            TB_auc_end.Value = DateTime.Today.AddDays(1);

            TB_post1_send.Value = DateTime.Today.AddDays(1);
            TB_tnt1_send.Value = DateTime.Today.AddDays(1);
            TB_courier1.Value = DateTime.Today.AddDays(1);
            TB_tel1.Value = DateTime.Today.AddDays(1);
            TB_rez1.Value = DateTime.Today.AddDays(1);
            TB_macne1.Value = DateTime.Today.AddDays(1);
            TB_auc1_start.Value = DateTime.Today.AddDays(1);
            TB_auc1_end.Value = DateTime.Today.AddDays(1);

            TB_post2_send.Value = DateTime.Today.AddDays(1);
            TB_tnt2_send.Value = DateTime.Today.AddDays(1);
            TB_courier2.Value = DateTime.Today.AddDays(1);
            TB_tel2.Value = DateTime.Today.AddDays(1);
            TB_rez2.Value = DateTime.Today.AddDays(1);
            TB_macne2.Value = DateTime.Today.AddDays(1);
            TB_auc2_start.Value = DateTime.Today.AddDays(1);
            TB_auc2_end.Value = DateTime.Today.AddDays(1);

            TP_end.Value = DateTime.Today.AddDays(1);

            TP_auc2.Value = DateTime.Today.AddDays(1);
            TP_auc3.Value = DateTime.Today.AddDays(1);
            TP_gaz.Value = DateTime.Today.AddDays(1);
            TP_mac.Value = DateTime.Today.AddDays(1);

            TB_tarval.Value = DateTime.Today;

            DTP_dan.CustomFormat = "dd/MM/yyyy";
            DTP_mde.CustomFormat = "dd/MM/yyyy";

            DTP_dan.Value = DateTime.Today;
            DTP_mde.Value = DateTime.Today;

            TP_rep_ot.Value = DateTime.Today;
            TP_rep_do.Value = DateTime.Today;

            sss.ConnectionString = conn;

            try
            {
                sss.Open();
            }
            catch
            {
                sss.Close();
                sss.Open();
            }

            sssg.ConnectionString = conn;

            try
            {
                sssg.Open();
            }
            catch
            {
                sssg.Close();
                sssg.Open();
            }

            sss1.ConnectionString = conn;

            try
            {
                sss1.Open();
            }
            catch
            {
                sss1.Close();
                sss1.Open();
            }

            pr_tmi(sender, e);

            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            BS_usr.Filter = "user_name <> 'Admin'";

            TA_usr.Connection = sss;
            this.TA_usr.Fill(this.dS_usr.users);

            TA_info.Connection = sss;

            /*filter_base = "((stat <> 'SOLD') and (stat <> 'Canceld') and (stat <> 'SOLD (2)') and (stat <> 'SOLD (3)') and (stat <> 'SOLD (Stationar)') and (stat <> 'BROCKED'))";*/

            filter_base = "end_date is null";

            BS_info.Filter = filter_base;

            this.TA_info.Fill(this.dS_info.info);


            /*dS_info.Clear();

            this.TA_info.Fill(this.dS_info.info);*/

            /*pr_ref(sender, e);*/

            TA_spec.Connection = sss;
            this.TA_spec.Fill(this.dS_spec.specialists);

            TA_stat.Connection = sss;
            this.TA_stat.Fill(this.dS_stat.status);

            TA_cust.Connection = sss;
            this.TA_cust.Fill(this.dS_cust.customers);

            TA_prep.Connection = sss;
            this.TA_prep.Fill(this.dS_prep.prep_tbl);

            TA_repr.Connection = sss;
            this.TA_repr.Fill(this.dS_repr.represent);

            TA_buy.Connection = sss;
            this.TA_buy.Fill(this.dS_buy.buyers);

            TA_log.Connection = sss;
            this.TA_log.Fill(this.dS_log.logs);

            TA_kod.Connection = sss;
            this.TA_kod.Fill(this.dS_kod.codes);

            TA_bru.Connection = sss;
            BS_bru.Filter = filter_bru;
            this.TA_bru.Fill(this.dS_bru.receipts);

            TA_rep.Connection = sss;
            this.TA_rep.Fill(this.dS_rep.acc);

            TA_pdf.Connection = sss;
            this.TA_pdf.Fill(this.dS_pdf.files1);

            TA_auqt.Connection = sss;
            this.TA_auqt.Fill(this.DS_auqt.auqtipe);

            TA_kur.Connection = sss;
            this.TA_kur.Fill(this.dS_kur.iso);

            CB_filt.Items.Clear();

            for (int i0 = 0; i0 <= DGV_info.ColumnCount - 1; i0++)
            {
                string colugs0 = DGV_info.Columns[i0].Name;

                if (DGV_info.Columns[i0].Visible)
                {
                    if ((colugs0 == "nom") || (colugs0 == "stat") || (colugs0 == "prepaid_dt"))
                    {
                        CB_filt.Items.Add(DGV_info.Columns[i0].HeaderText);
                    }
                }
            }

            CB_filt1.Items.Clear();

            for (int i0 = 0; i0 <= DGV_bru.ColumnCount - 1; i0++)
            {
                if ((DGV_bru.Columns[i0].Visible) || (DGV_bru.Columns[i0].Name == "ind"))
                {
                    CB_filt1.Items.Add(DGV_bru.Columns[i0].HeaderText);
                }
            }

        }

        private void pr_entdzve(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                object se = new object();
                EventArgs ee = new EventArgs();
                if (TB_dzve.Text != psw)
                {
                    MessageBox.Show("ძველი პაროლი არასწორია !");
                    TB_dzve.Text = "";
                    TB_dzve.Focus();
                }
                else
                {
                    TB_aha.Enabled = true;
                    TB_aha.Focus();
                }
            }
        }

        private void pr_go_psw(object sender, EventArgs e)
        {
            string hash0 = "";
            string hash = TB_aha.Text;

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();

            byte[] bhes = md5.ComputeHash(enc.GetBytes(hash));

            foreach (byte bt in bhes)
            {

                hash0 += string.Format("{0:X2}", bt);

            }

            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            Sql.CommandText = "update users set user_psw = '" + hash0 + "' where user_name = '" + usname + "'";
            Sql.ExecuteNonQuery();

            MessageBox.Show("შეასრულეთ რეგისტრაცია თავიდან");

            Close();

        }

        private void pr_step2(object sender, EventArgs e)
        {
            Pa_chusr.BringToFront();
            Pa_chusr.Visible = true;

            TB_chusr.Text = "";
            TB_chupsw.Text = "";

            BS_usr.Position = 0;

        }

        private void pr_cl_chusr(object sender, EventArgs e)
        {
            Pa_chusr.Visible = false;
        }

        private void pr_chusr(object sender, EventArgs e)
        {
            chmenpoz = BS_usr.Position;
            chmenpoz = dS_usr.users[chmenpoz].user_id;

            SqlCommand Sqlg = new SqlCommand("", sssg);
            Sqlg.CommandType = CommandType.Text;

            Sqlg.CommandText = "select user_name from users where user_id = " + chmenpoz.ToString();
            TB_chusr.Text = Sqlg.ExecuteScalar().ToString();

            TB_chupsw.Text = "";

            Sqlg.CommandText = "select user_poz from users where user_id = " + chmenpoz.ToString();
            string poz = Sqlg.ExecuteScalar().ToString();

            if (poz == "0")
            {
                RB_adm.Checked = true;
            }
            else
            {
                RB_op.Checked = true;
            }

            Sqlg.CommandText = "select status from users where user_id = " + chmenpoz.ToString();
            string sta = Sqlg.ExecuteScalar().ToString();

            if (sta == "0")
            {
                RB_act.Checked = true;
            }
            else
            {
                RB_pas.Checked = true;
            }

        }

        private void pr_addusr(object sender, EventArgs e)
        {
            Pa_newusr.BringToFront();
            Pa_newusr.Visible = true;
        }

        private void pr_usrdel(object sender, EventArgs e)
        {
            if (TB_chusr.Text.Trim() != "")
            {
                if (
                (MessageBox.Show("        წაშლა ?", "წაშლა", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)).ToString() == "Yes")
                {

                    SqlCommand Sql = new SqlCommand("", sss);
                    Sql.CommandType = CommandType.Text;

                    Sql.CommandText = "delete from users where user_id = " + chmenpoz.ToString();
                    try
                    {
                        Sql.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("მომხმარებელი დაკავებულია , წაშლა შეუძლებელია");
                    }


                    this.TA_usr.Fill(this.dS_usr.users);

                    CB_mom.Refresh();

                }

            }
            else
            {
                MessageBox.Show("მომხმარებელი არ არის ამორჩეული");
            }

        }

        private void pr_cl_newusr(object sender, EventArgs e)
        {
            Pa_newusr.Visible = false;
        }

        private void pr_go_newusr(object sender, EventArgs e)
        {
            if (TB_newusr.Text.Trim() != "")
            {
                SqlCommand Sql = new SqlCommand("", sss);
                Sql.CommandType = CommandType.Text;

                Sql.CommandText = "insert into users (user_name) values (N'" + TB_newusr.Text.Trim() + "')";

                try
                {
                    Sql.ExecuteNonQuery();

                    this.TA_usr.Fill(this.dS_usr.users);

                    CB_mom.Refresh();

                    Pa_newusr.Visible = false;
                }
                catch
                {
                    MessageBox.Show("სახელი მეორდება");
                }
            }

        }

        private void pr_go_chusr(object sender, EventArgs e)
        {
            int poz = 0;
            int sta = 0;
            string psw = TB_chupsw.Text;
            string hash = "";
            string hash0 = "";

            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            if (RB_adm.Checked)
            {
                poz = 0;
            }
            else
            {
                poz = 1;
            }

            if (RB_act.Checked)
            {
                sta = 0;
            }
            else
            {
                sta = 1;
            }

            if ((TB_chusr.Text.Trim() != "") && (TB_chupsw.Text.Trim() != ""))
            {

                hash = psw;

                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();

                byte[] bhes = md5.ComputeHash(enc.GetBytes(hash));

                foreach (byte bt in bhes)
                {

                    hash0 += string.Format("{0:X2}", bt);

                }

                Sql.CommandText = "update users";
                Sql.CommandText = Sql.CommandText + " set user_name = N'" + TB_chusr.Text + "',user_psw = '" + hash0 + "',status = " + sta.ToString() + ",user_poz = " + poz.ToString() + " where user_id = " + chmenpoz.ToString();

                Sql.ExecuteNonQuery();
            }
            else
            {
                if (TB_chusr.Text.Trim() == "")
                {
                    MessageBox.Show("სახელი ცარიელია");
                }

                if (TB_chupsw.Text.Trim() == "")
                {

                    Sql.CommandText = "select isnull(user_psw,'') from users where user_id = " + chmenpoz.ToString();

                    string ppp = Sql.ExecuteScalar().ToString();

                    if (ppp.Trim() == "")
                    {
                        MessageBox.Show("პაროლი ცარიელია");
                    }
                    else
                    {
                        Sql.CommandText = "update users";
                        Sql.CommandText = Sql.CommandText + " set user_name = N'" + TB_chusr.Text + "',status = " + sta.ToString() + ",user_poz = " + poz.ToString() + " where user_id = " + chmenpoz.ToString();

                        Sql.ExecuteNonQuery();

                    }
                }

            }

        }

        private void pr_hadd(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.IsBalloon = true;
            myToolTip.SetToolTip(B_infadd, "კლიენტის დამატება");
        }

        private void pr_hedit(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.IsBalloon = true;
            myToolTip.SetToolTip(B_infcha, "კლიენტის რედაქტირება");
        }

        private void pr_hdel(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.IsBalloon = true;
            myToolTip.SetToolTip(B_infdel, "კლიენტის წაშლა");
        }

        private void pr_hfilt(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.IsBalloon = true;
            myToolTip.SetToolTip(B_filt, "ფილტრი");
        }

        private void pr_hexp(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.IsBalloon = true;
            myToolTip.SetToolTip(B_exp, "ექსპორტი Excel-ში");
        }

        private void pr_href(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.IsBalloon = true;
            myToolTip.SetToolTip(B_ref, "Refresh");
        }

        private void pr_info(object sender, EventArgs e)
        {
            Pa_info.Left = Left + 21;
            Pa_info.Top = Top + 35;
            Pa_info.Width = Width - 41;
            Pa_info.Height = Height - 67;
            Pa_w.Width = Pa_info.Width - 41;
            B_cl_info.Left = Pa_info.Width - 30;

            DGV_info.Width = Pa_info.Width - 29;
            DGV_info.Height = Pa_info.Height - 60;

            Pa_info.BringToFront();
            Pa_info.Visible = true;

            BS_prep.CurrentItemChanged += pr_repr;

            izm = 0;
            note = "";
        }

        private void pr_cl_info(object sender, EventArgs e)
        {
            if (izm == 1)
            {
                if (
                (MessageBox.Show("         შენახვა", "თქვენ შეასრულეთ ცვლილებები", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)).ToString() == "Yes")
                {
                    pr_save_inf(sender, e);
                }
                else
                {
                    izm = 0;
                    note = "";
                }
            }

            Pa_info.Visible = false;

            DGV_info.Enabled = true;
            B_infadd.Enabled = true;
            B_infcha.Enabled = true;
            B_infdel.Enabled = true;

        }

        private void pr_form(object sender, EventArgs e)
        {
            DateTime d0;
            int colugi = DGV_info.CurrentCell.ColumnIndex;
            int rowwgi = DGV_info.CurrentCell.RowIndex;
            string fre;
            string fre1;
            DateTime dda2 = DateTime.Today;
            DateTime dda3 = DateTime.Today;

            string auqt;

            if (Pa_inf.Visible)
            {
                auqt = TB_auqt.Text;
                auqt0 = auqt;
            }
            else
            {
                auqt = DGV_info.Rows[rowwgi].Cells["auqt"].Value.ToString();
                auqt0 = auqt;
            }

            if (auqt == "თბილისის სააუქციონო სახლი")
            {
                auqt0 = auqt;
            }

            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            if ((DGV_info.Rows[rowwgi].Cells["ad_date"].Value != DBNull.Value) && (DGV_info.Rows[rowwgi].Cells["auc_end"].Value != DBNull.Value) && (DGV_info.Rows[rowwgi].Cells["auc_start"].Value != DBNull.Value))
            {
                /*infi = DGV_info.Rows[rowwgi].Cells["inf_i"].Value.ToString();*/
                fre = DGV_info.Rows[rowwgi].Cells["freeze"].Value.ToString();
                fre1 = DGV_info.Rows[rowwgi].Cells["freeze_1"].Value.ToString();

                Forms frm = new Forms();
                frm.conn = conn;
                frm.sss = sss;
                frm.moqme = moqme;
                frm.mail = DGV_info.Rows[rowwgi].Cells["repres_mail"].Value.ToString();

                if (Pa_inf.Visible)
                {
                    auqt = TB_auqt.Text;
                    auqt0 = auqt;
                }
                else
                {
                    auqt = DGV_info.Rows[rowwgi].Cells["auqt"].Value.ToString();
                    auqt0 = auqt;
                }

                if (auqt == "თბილისის სააუქციონო სახლი")
                {
                    frm.auct = "1";
                    auqt0 = auqt;
                }
                else
                {
                    frm.auct = "0";
                    auqt0 = auqt;
                }

                if (DGV_info.Rows[rowwgi].Cells["stat"].Value.ToString() == "STATIONAR")
                {
                    frm.adg = "ქ. თბილისი, ვ. პეტრიაშვილის N 10";
                }
                else
                {
                    frm.adg = "ვებსაიტი www.eAuction.ge";
                    frm.liv = "";

                    if ((auqt == "LIVO") || (auqt == "Auction.livo.ge"))
                    {
                        frm.adg = "ვებსაიტი auction.livo.ge";
                        frm.liv = "LIVO";
                        auqt0 = auqt;
                    }
                }

                if (DGV_info.Rows[rowwgi].Cells["auqt"].Value.ToString() == "თბილისის სააუქციონო სახლი")
                {
                    frm.adg = "ვებსაიტი www.auctionhouse.ge";
                }

                frm.cw = DGV_info.Rows[rowwgi].Cells["stat"].Value.ToString();
                frm.dgg = DGV_info.Rows[rowwgi].Cells["dgg"].Value.ToString();
                frm.am = DGV_info.Rows[rowwgi].Cells["nom"].Value.ToString();
                frm.qw = DGV_info.Rows[rowwgi].Cells["owner"].Value.ToString();
                frm.rw = DGV_info.Rows[rowwgi].Cells["owner_num"].Value.ToString();
                frm.dw = DGV_info.Rows[rowwgi].Cells["cust"].Value.ToString();
                frm.ww = DGV_info.Rows[rowwgi].Cells["debtor"].Value.ToString();
                frm.xw = DGV_info.Rows[rowwgi].Cells["debtor_num"].Value.ToString();
                frm.yw = DGV_info.Rows[rowwgi].Cells["debtor_addr"].Value.ToString();
                frm.mw = DGV_info.Rows[rowwgi].Cells["property_addr"].Value.ToString();
                frm.nw = DGV_info.Rows[rowwgi].Cells["property_code"].Value.ToString();
                frm.gw = DGV_info.Rows[rowwgi].Cells["n_mortgage"].Value.ToString();
                try
                {
                    d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["dt_mortgage"].Value.ToString());
                    frm.hw = d0.ToString("dd/MM/yyyy");
                }
                catch
                {
                    frm.hw = "";
                }
                frm.iw = DGV_info.Rows[rowwgi].Cells["credit_treaty"].Value.ToString();
                frm.kw = DGV_info.Rows[rowwgi].Cells["debt_gel"].Value.ToString();
                frm.ow = DGV_info.Rows[rowwgi].Cells["property"].Value.ToString();
                frm.pw = DGV_info.Rows[rowwgi].Cells["rights"].Value.ToString();

                /*DateTime dd = DateTime.Now;*/
                DateTime dd = DateTime.Today;
                DateTime dda1 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc_end"].Value.ToString());
                int ind1 = 0;
                int ind2 = 0;
                string kat;

                try
                {
                    dda2 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc1_end"].Value.ToString());
                    ind1 = 1;
                }
                catch
                {
                    ind1 = 0;
                }

                try
                {
                    dda3 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc2_end"].Value.ToString());
                    ind2 = 1;
                }
                catch
                {
                    ind2 = 0;
                }

                frm.auc = "";
                frm.ah = "";
                frm.ahn = "";
                frm.ahg = "";
                frm.ahgn = "";
                frm.aucs = "";
                frm.auce = "";

                if ((dd <= dda1) || ((fre == "True")) || (ind1 == 0))
                {
                    frm.auc = "პირველი";
                    frm.ah = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                    frm.ahn = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                    frm.ahg = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                    frm.ahgn = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                    d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc_start"].Value.ToString());
                    frm.aucs = d0.ToString("dd/MM/yyyy");
                    frm.aucts = d0.ToString("HH:mm");
                    d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc_end"].Value.ToString());
                    frm.auce = d0.ToString("dd/MM/yyyy");
                    frm.aucte = d0.ToString("HH:mm");
                    frm.aw = DGV_info.Rows[rowwgi].Cells["lot_num"].Value.ToString();
                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["macne"].Value.ToString());
                        frm.apw = d0.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        frm.apw = "";
                    }
                }

                if (ind1 == 1)
                {
                    if (((dd > dda1) && (dd <= dda2)) || ((fre1 == "True") || (ind2 == 0)))
                    {
                        frm.auc = "მეორე";
                        frm.ah = DGV_info.Rows[rowwgi].Cells["price1_usd"].Value.ToString();
                        frm.ahn = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                        frm.ahg = DGV_info.Rows[rowwgi].Cells["price1_gel"].Value.ToString();
                        frm.ahgn = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc1_start"].Value.ToString());
                        frm.aucs = d0.ToString("dd/MM/yyyy");
                        frm.aucts = d0.ToString("HH:mm");
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc1_end"].Value.ToString());
                        frm.auce = d0.ToString("dd/MM/yyyy");
                        frm.aucte = d0.ToString("HH:mm");
                        frm.aw = DGV_info.Rows[rowwgi].Cells["lot1_num"].Value.ToString();
                        try
                        {
                            d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["macne1"].Value.ToString());
                            frm.apw = d0.ToString("dd/MM/yyyy");
                        }
                        catch
                        {
                            frm.apw = "";
                        }
                    }
                }
                else
                {
                    frm.auc = "პირველი";
                    frm.ah = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                    frm.ahn = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                    frm.ahg = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                    frm.ahgn = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                    d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc_start"].Value.ToString());
                    frm.aucs = d0.ToString("dd/MM/yyyy");
                    frm.aucts = d0.ToString("HH:mm");
                    d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc_end"].Value.ToString());
                    frm.auce = d0.ToString("dd/MM/yyyy");
                    frm.aucte = d0.ToString("HH:mm");
                    frm.aw = DGV_info.Rows[rowwgi].Cells["lot_num"].Value.ToString();
                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["macne"].Value.ToString());
                        frm.apw = d0.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        frm.apw = "";
                    }
                }

                if (ind2 == 1)
                {
                    if ((dd >= dda2) && (dd <= dda3))
                    {
                        frm.auc = "მესამე";
                        frm.ah = DGV_info.Rows[rowwgi].Cells["price2_usd"].Value.ToString();
                        frm.ahn = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                        frm.ahg = DGV_info.Rows[rowwgi].Cells["price2_gel"].Value.ToString();
                        frm.ahgn = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc2_start"].Value.ToString());
                        frm.aucs = d0.ToString("dd/MM/yyyy");
                        frm.aucts = d0.ToString("HH:mm");
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc2_end"].Value.ToString());
                        frm.auce = d0.ToString("dd/MM/yyyy");
                        frm.aucte = d0.ToString("HH:mm");
                        frm.aw = DGV_info.Rows[rowwgi].Cells["lot2_num"].Value.ToString();
                        try
                        {
                            d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["macne2"].Value.ToString());
                            frm.apw = d0.ToString("dd/MM/yyyy");
                        }
                        catch
                        {
                            frm.apw = "";
                        }
                    }
                }
                else
                {
                    if ((dd <= dda1) || ((fre == "True")) || (ind1 == 0))
                    {
                        frm.auc = "პირველი";
                        frm.ah = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                        frm.ahn = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                        frm.ahg = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                        frm.ahgn = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc_start"].Value.ToString());
                        frm.aucs = d0.ToString("dd/MM/yyyy");
                        frm.aucts = d0.ToString("HH:mm");
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc_end"].Value.ToString());
                        frm.auce = d0.ToString("dd/MM/yyyy");
                        frm.aucte = d0.ToString("HH:mm");
                        frm.aw = DGV_info.Rows[rowwgi].Cells["lot_num"].Value.ToString();
                        try
                        {
                            d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["macne"].Value.ToString());
                            frm.apw = d0.ToString("dd/MM/yyyy");
                        }
                        catch
                        {
                            frm.apw = "";
                        }
                    }

                    if (ind1 == 1)
                    {
                        if (((dd > dda1) && (dd <= dda2)) || ((fre1 == "True") || (ind2 == 0)))
                        {
                            frm.auc = "მეორე";
                            frm.ah = DGV_info.Rows[rowwgi].Cells["price1_usd"].Value.ToString();
                            frm.ahn = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                            frm.ahg = DGV_info.Rows[rowwgi].Cells["price1_gel"].Value.ToString();
                            frm.ahgn = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                            d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc1_start"].Value.ToString());
                            frm.aucs = d0.ToString("dd/MM/yyyy");
                            frm.aucts = d0.ToString("HH:mm");
                            d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc1_end"].Value.ToString());
                            frm.auce = d0.ToString("dd/MM/yyyy");
                            frm.aucte = d0.ToString("HH:mm");
                            frm.aw = DGV_info.Rows[rowwgi].Cells["lot1_num"].Value.ToString();
                            try
                            {
                                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["macne1"].Value.ToString());
                                frm.apw = d0.ToString("dd/MM/yyyy");
                            }
                            catch
                            {
                                frm.apw = "";
                            }
                        }
                    }
                    else
                    {
                        frm.auc = "პირველი";
                        frm.ah = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                        frm.ahn = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                        frm.ahg = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                        frm.ahgn = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc_start"].Value.ToString());
                        frm.aucs = d0.ToString("dd/MM/yyyy");
                        frm.aucts = d0.ToString("HH:mm");
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc_end"].Value.ToString());
                        frm.auce = d0.ToString("dd/MM/yyyy");
                        frm.aucte = d0.ToString("HH:mm");
                        frm.aw = DGV_info.Rows[rowwgi].Cells["lot_num"].Value.ToString();
                        try
                        {
                            d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["macne"].Value.ToString());
                            frm.apw = d0.ToString("dd/MM/yyyy");
                        }
                        catch
                        {
                            frm.apw = "";
                        }
                    }
                }

                if ((dd > dda3) && (ind2 == 1))
                {
                    /*frm.am = "";
                    frm.auc = "";
                    frm.aucs = "";
                    frm.ah = "";
                    frm.ahg = "";
                    frm.dw = "";
                    frm.ew = "";
                    frm.qw = "";
                    frm.rw = "";
                    frm.mw = "";
                    frm.nw = "";
                    frm.ww = "";
                    frm.xw = "";
                    frm.ow = "";
                    frm.pw = "";*/

                    frm.auc = "მესამე";
                    frm.ah = DGV_info.Rows[rowwgi].Cells["price2_usd"].Value.ToString();
                    frm.ahn = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                    frm.ahg = DGV_info.Rows[rowwgi].Cells["price2_gel"].Value.ToString();
                    frm.ahgn = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                    d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc2_start"].Value.ToString());
                    frm.aucs = d0.ToString("dd/MM/yyyy");
                    frm.aucts = d0.ToString("HH:mm");
                    d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc2_end"].Value.ToString());
                    frm.auce = d0.ToString("dd/MM/yyyy");
                    frm.aucte = d0.ToString("HH:mm");
                    frm.aw = DGV_info.Rows[rowwgi].Cells["lot2_num"].Value.ToString();
                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["macne2"].Value.ToString());
                        frm.apw = d0.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        frm.apw = "";
                    }

                }

                if (moqme == 1)
                {
                    string nom = DGV_info.Rows[rowwgi].Cells["nom"].Value.ToString();

                    Sql.CommandText = "select dbo.acc_p1('" + nom + "')";

                    frm.usd = Sql.ExecuteScalar().ToString();

                    Sql.CommandText = "select dbo.acc_p01('" + nom + "')";

                    frm.eur = Sql.ExecuteScalar().ToString();

                    frm.ew = DGV_info.Rows[rowwgi].Cells["representative"].Value.ToString();
                    frm.ow = DGV_info.Rows[rowwgi].Cells["property"].Value.ToString();
                    frm.pw = DGV_info.Rows[rowwgi].Cells["rights"].Value.ToString();

                    frm.aj = DGV_info.Rows[rowwgi].Cells["fee"].Value.ToString();
                    frm.av = DGV_info.Rows[rowwgi].Cells["prepaid"].Value.ToString();
                    frm.ah0 = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                    frm.ah1 = DGV_info.Rows[rowwgi].Cells["sales_eur"].Value.ToString();
                    frm.ahn1 = DGV_info.Rows[rowwgi].Cells["sales_eur"].Value.ToString();
                    frm.ai = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                    frm.aj2 = (Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price1_usd"].Value) * Convert.ToDecimal(frm.usd) + Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price1_gel"].Value)).ToString("##########.00");
                    frm.aj3 = (Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price2_usd"].Value) * Convert.ToDecimal(frm.usd) + Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price2_gel"].Value)).ToString("##########.00");

                    Sql.CommandText = "select dbo.acc_p2('" + nom + "')";

                    frm.pro = Sql.ExecuteScalar().ToString();

                    frm.spr = DGV_info.Rows[rowwgi].Cells["specpr"].Value.ToString();

                    if (frm.auc == "მეორე")
                    {
                        frm.pro = (Convert.ToDecimal(frm.aj2) / 100 * Convert.ToDecimal(frm.spr)).ToString("##########.00");
                    }

                    if (frm.auc == "მესამე")
                    {
                        frm.pro = (Convert.ToDecimal(frm.aj3) / 100 * Convert.ToDecimal(frm.spr)).ToString("##########.00");
                    }

                    frm.unda = 0;

                    if (((auqt == "eauction") || (auqt == "Auction.livo.ge")) && (Convert.ToDecimal(frm.av) == 590))
                    {
                        frm.unda = 1;

                        frm.auqt = auqt;

                        Sql.CommandText = "select dbo.acc_p7('" + nom + "')";

                        frm.auqc = Sql.ExecuteScalar().ToString();

                        if (frm.auc == "მეორე")
                        {
                            if (auqt == "Auction.livo.ge")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj2) / 100 * Convert.ToDecimal(0.9)).ToString("##########.00");
                            }

                            if (auqt == "eauction")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj2) / 100 * Convert.ToDecimal(1.18)).ToString("##########.00");
                            }

                        }

                        if (frm.auc == "მესამე")
                        {
                            if (auqt == "Auction.livo.ge")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj3) / 100 * Convert.ToDecimal(0.9)).ToString("##########.00");
                            }

                            if (auqt == "eauction")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj3) / 100 * Convert.ToDecimal(1.18)).ToString("##########.00");
                            }
                        }
                    }
                    
                    string dg = DGV_info.Rows[rowwgi].Cells["dgg"].Value.ToString();

                    if (dg == "YES")
                    {
                        frm.vat = (Convert.ToDecimal(frm.aj) / Convert.ToDecimal(1.18) * Convert.ToDecimal(0.18)).ToString("##########.00");
                    }

                    if (dg == "NO")
                    {
                        frm.vat = "0.00";
                    }


                }

                if (moqme == 2)
                {
                    string nom = DGV_info.Rows[rowwgi].Cells["nom"].Value.ToString();

                    Sql.CommandText = "select dbo.acc_p1('" + nom + "')";

                    frm.usd = Sql.ExecuteScalar().ToString();

                    Sql.CommandText = "select dbo.acc_p01('" + nom + "')";

                    frm.eur = Sql.ExecuteScalar().ToString();

                    frm.sw = DGV_info.Rows[rowwgi].Cells["owner_addr1"].Value.ToString();
                    frm.tw = DGV_info.Rows[rowwgi].Cells["owner_addr2"].Value.ToString();
                    frm.uw = DGV_info.Rows[rowwgi].Cells["owner_addr3"].Value.ToString();
                    frm.vw = DGV_info.Rows[rowwgi].Cells["owner_addr4"].Value.ToString();

                    frm.aj = DGV_info.Rows[rowwgi].Cells["fee"].Value.ToString();
                    frm.av = DGV_info.Rows[rowwgi].Cells["prepaid"].Value.ToString();
                    frm.ah0 = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                    frm.ah1 = DGV_info.Rows[rowwgi].Cells["sales_eur"].Value.ToString();
                    frm.ahn1 = DGV_info.Rows[rowwgi].Cells["sales_eur"].Value.ToString();
                    frm.ai = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                    frm.aj2 = (Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price1_usd"].Value) * Convert.ToDecimal(frm.usd) + Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price1_gel"].Value)).ToString("##########.00");
                    frm.aj3 = (Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price2_usd"].Value) * Convert.ToDecimal(frm.usd) + Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price2_gel"].Value)).ToString("##########.00");

                    Sql.CommandText = "select dbo.acc_p2('" + nom + "')";

                    frm.pro = Sql.ExecuteScalar().ToString();

                    frm.spr = DGV_info.Rows[rowwgi].Cells["specpr"].Value.ToString();

                    if (frm.auc == "მეორე")
                    {
                        frm.pro = (Convert.ToDecimal(frm.aj2) / 100 * Convert.ToDecimal(frm.spr)).ToString("##########.00");
                    }

                    if (frm.auc == "მესამე")
                    {
                        frm.pro = (Convert.ToDecimal(frm.aj3) / 100 * Convert.ToDecimal(frm.spr)).ToString("##########.00");
                    }

                    frm.unda = 0;

                    if (((auqt == "eauction") || (auqt == "Auction.livo.ge")) && (Convert.ToDecimal(frm.av) == 590))
                    {
                        frm.unda = 1;

                        frm.auqt = auqt;

                        Sql.CommandText = "select dbo.acc_p7('" + nom + "')";

                        frm.auqc = Sql.ExecuteScalar().ToString();

                        if (frm.auc == "მეორე")
                        {
                            if (auqt == "Auction.livo.ge")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj2) / 100 * Convert.ToDecimal(0.9)).ToString("##########.00");
                            }

                            if (auqt == "eauction")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj2) / 100 * Convert.ToDecimal(1.18)).ToString("##########.00");
                            }

                        }

                        if (frm.auc == "მესამე")
                        {
                            if (auqt == "Auction.livo.ge")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj3) / 100 * Convert.ToDecimal(0.9)).ToString("##########.00");
                            }

                            if (auqt == "eauction")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj3) / 100 * Convert.ToDecimal(1.18)).ToString("##########.00");
                            }
                        }
                    }

                    string dg = DGV_info.Rows[rowwgi].Cells["dgg"].Value.ToString();

                    if (dg == "YES")
                    {
                        frm.vat = (Convert.ToDecimal(frm.aj) / Convert.ToDecimal(1.18) * Convert.ToDecimal(0.18)).ToString("##########.00");
                    }

                    if (dg == "NO")
                    {
                        frm.vat = "0.00";
                    }

                }

                if (moqme == 3)
                {
                    string nom = DGV_info.Rows[rowwgi].Cells["nom"].Value.ToString();

                    Sql.CommandText = "select dbo.acc_p1('" + nom + "')";

                    frm.usd = Sql.ExecuteScalar().ToString();

                    Sql.CommandText = "select dbo.acc_p01('" + nom + "')";

                    frm.eur = Sql.ExecuteScalar().ToString();

                    frm.aj = DGV_info.Rows[rowwgi].Cells["fee"].Value.ToString();
                    frm.ah0 = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                    frm.ah1 = DGV_info.Rows[rowwgi].Cells["sales_eur"].Value.ToString();
                    frm.ahn1 = DGV_info.Rows[rowwgi].Cells["sales_eur"].Value.ToString();
                    frm.ai = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                    frm.aj2 = (Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price1_usd"].Value) * Convert.ToDecimal(frm.usd) + Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price1_gel"].Value)).ToString("##########.00");
                    frm.aj3 = (Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price2_usd"].Value) * Convert.ToDecimal(frm.usd) + Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price2_gel"].Value)).ToString("##########.00");
                    frm.av = DGV_info.Rows[rowwgi].Cells["prepaid"].Value.ToString();

                    Sql.CommandText = "select dbo.acc_p2('" + nom + "')";

                    frm.pro = Sql.ExecuteScalar().ToString();

                    frm.spr = DGV_info.Rows[rowwgi].Cells["specpr"].Value.ToString();

                    if (frm.auc == "მეორე")
                    {
                        frm.pro = (Convert.ToDecimal(frm.aj2) / 100 * Convert.ToDecimal(frm.spr)).ToString("##########.00");
                    }

                    if (frm.auc == "მესამე")
                    {
                        frm.pro = (Convert.ToDecimal(frm.aj3) / 100 * Convert.ToDecimal(frm.spr)).ToString("##########.00");
                    }

                    frm.unda = 0;

                    if (((auqt == "eauction") || (auqt == "Auction.livo.ge")) && (Convert.ToDecimal(frm.av) == 590))
                    {
                        frm.unda = 1;

                        frm.auqt = auqt;

                        Sql.CommandText = "select dbo.acc_p7('" + nom + "')";

                        frm.auqc = Sql.ExecuteScalar().ToString();

                        if (frm.auc == "მეორე")
                        {
                            if (auqt == "Auction.livo.ge")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj2) / 100 * Convert.ToDecimal(0.9)).ToString("##########.00");
                            }

                            if (auqt == "eauction")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj2) / 100 * Convert.ToDecimal(1.18)).ToString("##########.00");
                            }

                        }

                        if (frm.auc == "მესამე")
                        {
                            if (auqt == "Auction.livo.ge")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj3) / 100 * Convert.ToDecimal(0.9)).ToString("##########.00");
                            }

                            if (auqt == "eauction")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj3) / 100 * Convert.ToDecimal(1.18)).ToString("##########.00");
                            }
                        }
                    }

                    string dg = DGV_info.Rows[rowwgi].Cells["dgg"].Value.ToString();

                    if (dg == "YES")
                    {
                        frm.vat = (Convert.ToDecimal(frm.aj) / Convert.ToDecimal(1.18) * Convert.ToDecimal(0.18)).ToString("##########.00");
                    }

                    if (dg == "NO")
                    {
                        frm.vat = "0.00";
                    }

                }

                if (moqme == 4)
                {
                    string nom = DGV_info.Rows[rowwgi].Cells["nom"].Value.ToString();

                    Sql.CommandText = "select dbo.acc_p1('" + nom + "')";

                    frm.usd = Sql.ExecuteScalar().ToString();

                    Sql.CommandText = "select dbo.acc_p01('" + nom + "')";

                    frm.eur = Sql.ExecuteScalar().ToString();

                    frm.zw = DGV_info.Rows[rowwgi].Cells["debtor1"].Value.ToString();
                    frm.aaw = DGV_info.Rows[rowwgi].Cells["debtor1_num"].Value.ToString();
                    frm.abw = DGV_info.Rows[rowwgi].Cells["debtor1_addr"].Value.ToString();

                    frm.aj = DGV_info.Rows[rowwgi].Cells["fee"].Value.ToString();
                    frm.ah0 = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                    frm.ah1 = DGV_info.Rows[rowwgi].Cells["sales_eur"].Value.ToString();
                    frm.ahn1 = DGV_info.Rows[rowwgi].Cells["sales_eur"].Value.ToString();
                    frm.ai = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                    frm.aj2 = (Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price1_usd"].Value) * Convert.ToDecimal(frm.usd) + Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price1_gel"].Value)).ToString("##########.00");
                    frm.aj3 = (Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price2_usd"].Value) * Convert.ToDecimal(frm.usd) + Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price2_gel"].Value)).ToString("##########.00");
                    frm.av = DGV_info.Rows[rowwgi].Cells["prepaid"].Value.ToString();

                    Sql.CommandText = "select dbo.acc_p2('" + nom + "')";

                    frm.pro = Sql.ExecuteScalar().ToString();

                    frm.spr = DGV_info.Rows[rowwgi].Cells["specpr"].Value.ToString();

                    if (frm.auc == "მეორე")
                    {
                        frm.pro = (Convert.ToDecimal(frm.aj2) / 100 * Convert.ToDecimal(frm.spr)).ToString("##########.00");
                    }

                    if (frm.auc == "მესამე")
                    {
                        frm.pro = (Convert.ToDecimal(frm.aj3) / 100 * Convert.ToDecimal(frm.spr)).ToString("##########.00");
                    }

                    frm.unda = 0;

                    if (((auqt == "eauction") || (auqt == "Auction.livo.ge")) && (Convert.ToDecimal(frm.av) == 590))
                    {
                        frm.unda = 1;

                        frm.auqt = auqt;

                        Sql.CommandText = "select dbo.acc_p7('" + nom + "')";

                        frm.auqc = Sql.ExecuteScalar().ToString();

                        if (frm.auc == "მეორე")
                        {
                            if (auqt == "Auction.livo.ge")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj2) / 100 * Convert.ToDecimal(0.9)).ToString("##########.00");
                            }

                            if (auqt == "eauction")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj2) / 100 * Convert.ToDecimal(1.18)).ToString("##########.00");
                            }

                        }

                        if (frm.auc == "მესამე")
                        {
                            if (auqt == "Auction.livo.ge")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj3) / 100 * Convert.ToDecimal(0.9)).ToString("##########.00");
                            }

                            if (auqt == "eauction")
                            {
                                frm.auqc = (Convert.ToDecimal(frm.aj3) / 100 * Convert.ToDecimal(1.18)).ToString("##########.00");
                            }
                        }
                    }

                    string dg = DGV_info.Rows[rowwgi].Cells["dgg"].Value.ToString();

                    if (dg == "YES")
                    {
                        frm.vat = (Convert.ToDecimal(frm.aj) / Convert.ToDecimal(1.18) * Convert.ToDecimal(0.18)).ToString("##########.00");
                    }

                    if (dg == "NO")
                    {
                        frm.vat = "0.00";
                    }

                }

                if (moqme == 5)
                {
                    frm.tw = DGV_info.Rows[rowwgi].Cells["owner_addr1"].Value.ToString();
                }

                if (moqme == 6)
                {
                    string nom = DGV_info.Rows[rowwgi].Cells["nom"].Value.ToString();

                    Sql.CommandText = "select dbo.acc_p1('" + nom + "')";

                    frm.usd = Sql.ExecuteScalar().ToString();

                    Sql.CommandText = "select dbo.acc_p01('" + nom + "')";

                    frm.eur = Sql.ExecuteScalar().ToString();

                    frm.aj = DGV_info.Rows[rowwgi].Cells["fee"].Value.ToString();
                    frm.aj2 = (Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price1_usd"].Value) * Convert.ToDecimal(frm.usd) + Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price1_gel"].Value)).ToString("##########.00");
                    frm.aj3 = (Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price2_usd"].Value) * Convert.ToDecimal(frm.usd) + Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price2_gel"].Value)).ToString("##########.00");
                }

                if (moqme == 7)
                {
                    string nom = DGV_info.Rows[rowwgi].Cells["nom"].Value.ToString();

                    Sql.CommandText = "select dbo.acc_p1('" + nom + "')";

                    frm.usd = Sql.ExecuteScalar().ToString();

                    Sql.CommandText = "select dbo.acc_p01('" + nom + "')";

                    frm.eur = Sql.ExecuteScalar().ToString();

                    frm.aj = DGV_info.Rows[rowwgi].Cells["fee"].Value.ToString();
                    frm.aj2 = (Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price1_usd"].Value) * Convert.ToDecimal(frm.usd) + Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price1_gel"].Value)).ToString("##########.00");
                    frm.aj3 = (Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price2_usd"].Value) * Convert.ToDecimal(frm.usd) + Convert.ToDecimal(DGV_info.Rows[rowwgi].Cells["price2_gel"].Value)).ToString("##########.00");
                }

                if (moqme == 8)
                {
                    /**/
                }

                if (moqme == 9)
                {
                    frm.aj = DGV_info.Rows[rowwgi].Cells["fee"].Value.ToString();
                    frm.btw = DGV_info.Rows[rowwgi].Cells["buyer"].Value.ToString();
                    frm.buw = DGV_info.Rows[rowwgi].Cells["sum_gel"].Value.ToString();
                    d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["ad_date"].Value.ToString());
                    frm.fw = d0.ToString("dd/MM/yyyy");


                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["post_send"].Value.ToString());
                        frm.aiw = d0.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        frm.aiw = "";
                    }

                    frm.asw = DGV_info.Rows[rowwgi].Cells["lot_num"].Value.ToString();

                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc_start"].Value.ToString());
                        frm.aqw = d0.ToString("dd/MM/yyyy");
                        frm.aqw = frm.aqw + " " + d0.ToString("HH:mm");
                    }
                    catch
                    {
                        frm.aqw = "";
                    }
                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc_end"].Value.ToString());
                        frm.arw = d0.ToString("dd/MM/yyyy");
                        frm.arw = frm.arw + " " + d0.ToString("HH:mm");
                    }
                    catch
                    {
                        frm.arw = "";
                    }

                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["post1_send"].Value.ToString());
                        frm.avw = d0.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        frm.avw = "";
                    }

                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["rez1"].Value.ToString());
                        frm.bbw = d0.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        frm.bbw = "";
                    }

                    frm.bfw = DGV_info.Rows[rowwgi].Cells["lot1_num"].Value.ToString();

                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc1_start"].Value.ToString());
                        frm.bdw = d0.ToString("dd/MM/yyyy");
                        frm.bdw = frm.bdw + " " + d0.ToString("HH:mm");
                    }
                    catch
                    {
                        frm.bdw = "";
                    }
                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc1_end"].Value.ToString());
                        frm.bew = d0.ToString("dd/MM/yyyy");
                        frm.bew = frm.bew + " " + d0.ToString("HH:mm");
                    }
                    catch
                    {
                        frm.bew = "";
                    }

                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["post2_send"].Value.ToString());
                        frm.biw = d0.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        frm.biw = "";
                    }

                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["rez2"].Value.ToString());
                        frm.bow = d0.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        frm.bow = "";
                    }

                    frm.bsw = DGV_info.Rows[rowwgi].Cells["lot2_num"].Value.ToString();

                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc2_start"].Value.ToString());
                        frm.bqw = d0.ToString("dd/MM/yyyy");
                        frm.bqw = frm.bqw + " " + d0.ToString("HH:mm");
                    }
                    catch
                    {
                        frm.bqw = "";
                    }
                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc2_end"].Value.ToString());
                        frm.brw = d0.ToString("dd/MM/yyyy");
                        frm.brw = frm.brw + " " + d0.ToString("HH:mm");
                    }
                    catch
                    {
                        frm.brw = "";
                    }

                    frm.ah = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                    frm.ahn = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
                    frm.ahg = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                    frm.ahgn = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();
                    frm.atw = DGV_info.Rows[rowwgi].Cells["price1_usd"].Value.ToString();
                    frm.bgw = DGV_info.Rows[rowwgi].Cells["price1_gel"].Value.ToString();
                    frm.auw = DGV_info.Rows[rowwgi].Cells["price2_usd"].Value.ToString();
                    frm.bhw = DGV_info.Rows[rowwgi].Cells["price2_gel"].Value.ToString();

                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["tel"].Value.ToString());
                        frm.apw1 = d0.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        frm.apw1 = "";
                    }

                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["tel1"].Value.ToString());
                        frm.apw2 = d0.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        frm.apw2 = "";
                    }

                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["tel2"].Value.ToString());
                        frm.apw3 = d0.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        frm.apw3 = "";
                    }

                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["macne"].Value.ToString());
                        frm.arw1 = d0.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        frm.arw1 = "";
                    }

                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["macne1"].Value.ToString());
                        frm.arw2 = d0.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        frm.arw2 = "";
                    }

                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["macne2"].Value.ToString());
                        frm.arw3 = d0.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        frm.arw3 = "";
                    }

                }

                if (moqme == 10)
                {
                    try
                    {
                        d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["end_date"].Value.ToString());
                        frm.ddn = d0.ToString("dd/MM/yyyy");
                    }
                    catch
                    {
                        frm.ddn = "";
                    }

                    frm.nn = DGV_info.Rows[rowwgi].Cells["nom"].Value.ToString();

                    if (frm.auc == "პირველი")
                    {
                        frm.an = "1";
                    }

                    if (frm.auc == "მეორე")
                    {
                        frm.an = "2";
                    }

                    if (frm.auc == "მესამე")
                    {
                        frm.an = "3";
                    }

                    frm.cc = DGV_info.Rows[rowwgi].Cells["eacution1"].Value.ToString();

                    string accp = DGV_info.Rows[rowwgi].Cells["nom"].Value.ToString();

                    Sql.CommandText = "exec dbo.proc_acc1 '" + accp + "'";

                    Sql.ExecuteNonQuery();

                    Sql.CommandText = "select dbo.acc_p('" + accp + "')";

                    frm.ce0 = Sql.ExecuteScalar().ToString();

                    frm.ce = DGV_info.Rows[rowwgi].Cells["bank"].Value.ToString();
                    frm.cd = DGV_info.Rows[rowwgi].Cells["dgg1"].Value.ToString();

                    Sql.CommandText = "select dbo.acc_dgg('" + accp + "')";

                    frm.cb0 = Sql.ExecuteScalar().ToString();

                    frm.cb = DGV_info.Rows[rowwgi].Cells["harspec"].Value.ToString();
                    frm.buw = DGV_info.Rows[rowwgi].Cells["sum_gel"].Value.ToString();
                    frm.btw = DGV_info.Rows[rowwgi].Cells["buyer"].Value.ToString();
                    frm.rekv = DGV_info.Rows[rowwgi].Cells["cust"].Value.ToString();

                }

                frm.Show();
            }
            else
            {
                MessageBox.Show("გადაამოწმეთ ყველა აუცილებელი ცვლადი ველი");
            }

        }

        private void pr_ref(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            dS_repr.Clear();

            this.TA_repr.Fill(this.dS_repr.represent);

            TB_repr.Refresh();

            if (RB_moq.Checked)
            {
                /*filter_base = "((stat <> 'SOLD') and (stat <> 'Canceld') and (stat <> 'SOLD (2)') and (stat <> 'SOLD (3)') and (stat <> 'SOLD (Stationar)') and (stat <> 'BROCKED'))";*/

                Sql.CommandText = "SELECT nom, dbo.spec_info(inf_i) AS spec, dbo.stat_info(inf_i) AS stat, dbo.cust_info(inf_i) AS cust, representative, ad_date, n_mortgage, dt_mortgage, credit_treaty, credit_id, debt_usd, debt_gel, property_addr, property_code, property, rights, owner, owner_num, owner_addr1, owner_addr2, owner_addr3, owner_addr4, debtor, debtor_num, debtor_addr, debtor1, debtor1_num, debtor1_addr, dbo.doc_info(inf_i) AS doc_orig, dbo.foto_info(inf_i) AS foto, prepaid, sales_usd, price_usd, price_gel, dbo.post_send(inf_i) AS post_send, post_reg, dbo.tnt_send(inf_i) AS tnt_send, tnt_reg, dbo.cur_send(inf_i) AS courier, dbo.tel_send(inf_i) AS tel, dbo.rez_send(inf_i) AS rez, dbo.mac_send(inf_i) AS macne, dbo.start1(inf_i) AS auc_start, dbo.end1(inf_i) AS auc_end, lot_num, price1_usd, price1_gel, dbo.post1_send(inf_i) AS post1_send, post1_reg, dbo.tnt1_send(inf_i) AS tnt1_send, tnt1_reg, dbo.cur1_send(inf_i) AS courier1, dbo.tel1_send(inf_i) AS tel1, dbo.rez1_send(inf_i) AS rez1, dbo.mac1_send(inf_i) AS macne1, dbo.start2(inf_i) AS auc1_start, dbo.end2(inf_i) AS auc1_end, lot1_num, price2_usd, price2_gel, dbo.post2_send(inf_i) AS post2_send, post2_reg, dbo.tnt2_send(inf_i) AS tnt2_send, tnt2_reg, dbo.cur2_send(inf_i) AS courier2, dbo.tel2_send(inf_i) AS tel2, dbo.rez2_send(inf_i) AS rez2, dbo.mac2_send(inf_i) AS macne2, dbo.start3(inf_i) AS auc2_start, dbo.end3(inf_i) AS auc2_end, lot2_num, buyer, sum_gel, dbo.dgg_info(inf_i) AS dgg, inf_i, dbo.prep(ltrim(rtrim(nom))) AS prepaid_dt, repres_mail, owner_tel, gazrez, harmacne, dbo.spec(inf_i) as harspec, dbo.dgg_dat(inf_i) AS dgg0, dbo.eacut(inf_i) as eacution,dbo.eacut(inf_i) as eacution1,dbo.dgg_dat(inf_i) AS dgg1,dbo.bank_info(inf_i) AS bank,dbo.fee(inf_i) AS fee,isnull(freeze,0) as freeze,isnull(freeze_1,0) as freeze_1,end_date,auc2,auc2_dt,auc3,auc3_dt,gaz,gaz_dt,mac,mac_dt,specpr,kor,isnull(pdfo,0) as  pdfo,isnull(sales_eur,0) as sales_eur,dbo.fee(inf_i) * 0.0059 -  dbo.prep(ltrim(rtrim(nom)))  AS coms,auqpr,auqt,liquid_price,comment,dbo.chstg(inf_i) as chsg  FROM info where end_date is null ORDER BY dbo.nom(inf_i)";

                filter_base = "end_date is null";
                B_clon.Enabled = false;
            }

            if (RB_dmt.Checked)
            {
                /*filter_base = "((stat = 'SOLD') or (stat = 'Canceld') or (stat = 'SOLD (2)') or (stat = 'SOLD (3)') or (stat = 'SOLD (Stationar)') or (stat = 'BROCKED'))";*/

                Sql.CommandText = "SELECT nom, dbo.spec_info(inf_i) AS spec, dbo.stat_info(inf_i) AS stat, dbo.cust_info(inf_i) AS cust, representative, ad_date, n_mortgage, dt_mortgage, credit_treaty, credit_id, debt_usd, debt_gel, property_addr, property_code, property, rights, owner, owner_num, owner_addr1, owner_addr2, owner_addr3, owner_addr4, debtor, debtor_num, debtor_addr, debtor1, debtor1_num, debtor1_addr, dbo.doc_info(inf_i) AS doc_orig, dbo.foto_info(inf_i) AS foto, prepaid, sales_usd, price_usd, price_gel, dbo.post_send(inf_i) AS post_send, post_reg, dbo.tnt_send(inf_i) AS tnt_send, tnt_reg, dbo.cur_send(inf_i) AS courier, dbo.tel_send(inf_i) AS tel, dbo.rez_send(inf_i) AS rez, dbo.mac_send(inf_i) AS macne, dbo.start1(inf_i) AS auc_start, dbo.end1(inf_i) AS auc_end, lot_num, price1_usd, price1_gel, dbo.post1_send(inf_i) AS post1_send, post1_reg, dbo.tnt1_send(inf_i) AS tnt1_send, tnt1_reg, dbo.cur1_send(inf_i) AS courier1, dbo.tel1_send(inf_i) AS tel1, dbo.rez1_send(inf_i) AS rez1, dbo.mac1_send(inf_i) AS macne1, dbo.start2(inf_i) AS auc1_start, dbo.end2(inf_i) AS auc1_end, lot1_num, price2_usd, price2_gel, dbo.post2_send(inf_i) AS post2_send, post2_reg, dbo.tnt2_send(inf_i) AS tnt2_send, tnt2_reg, dbo.cur2_send(inf_i) AS courier2, dbo.tel2_send(inf_i) AS tel2, dbo.rez2_send(inf_i) AS rez2, dbo.mac2_send(inf_i) AS macne2, dbo.start3(inf_i) AS auc2_start, dbo.end3(inf_i) AS auc2_end, lot2_num, buyer, sum_gel, dbo.dgg_info(inf_i) AS dgg, inf_i, dbo.prep(ltrim(rtrim(nom))) AS prepaid_dt, repres_mail, owner_tel, gazrez, harmacne, dbo.spec(inf_i) as harspec, dbo.dgg_dat(inf_i) AS dgg0, dbo.eacut(inf_i) as eacution,dbo.eacut(inf_i) as eacution1,dbo.dgg_dat(inf_i) AS dgg1,dbo.bank_info(inf_i) AS bank,dbo.fee(inf_i) AS fee,isnull(freeze,0) as freeze,isnull(freeze_1,0) as freeze_1,end_date,auc2,auc2_dt,auc3,auc3_dt,gaz,gaz_dt,mac,mac_dt,specpr,kor,isnull(pdfo,0) as  pdfo,isnull(sales_eur,0) as sales_eur,dbo.fee(inf_i) * 0.0059 -  dbo.prep(ltrim(rtrim(nom)))  AS coms,auqpr,auqt,liquid_price,comment,dbo.chstg(inf_i) as chsg  FROM info where end_date is not null and end_date >= " + "'" + DateTime.Today.AddYears(-1).Date.ToString("yyyyMMdd") + "' ORDER BY dbo.nom(inf_i)";
                
                filter_base = "end_date is not null and end_date >= " + "'" + DateTime.Today.AddYears(-1).Date.ToString() + "'";
                B_clon.Enabled = true;
            }

            if (RB_arc.Checked)
            {
                Sql.CommandText = "SELECT nom, dbo.spec_info(inf_i) AS spec, dbo.stat_info(inf_i) AS stat, dbo.cust_info(inf_i) AS cust, representative, ad_date, n_mortgage, dt_mortgage, credit_treaty, credit_id, debt_usd, debt_gel, property_addr, property_code, property, rights, owner, owner_num, owner_addr1, owner_addr2, owner_addr3, owner_addr4, debtor, debtor_num, debtor_addr, debtor1, debtor1_num, debtor1_addr, dbo.doc_info(inf_i) AS doc_orig, dbo.foto_info(inf_i) AS foto, prepaid, sales_usd, price_usd, price_gel, dbo.post_send(inf_i) AS post_send, post_reg, dbo.tnt_send(inf_i) AS tnt_send, tnt_reg, dbo.cur_send(inf_i) AS courier, dbo.tel_send(inf_i) AS tel, dbo.rez_send(inf_i) AS rez, dbo.mac_send(inf_i) AS macne, dbo.start1(inf_i) AS auc_start, dbo.end1(inf_i) AS auc_end, lot_num, price1_usd, price1_gel, dbo.post1_send(inf_i) AS post1_send, post1_reg, dbo.tnt1_send(inf_i) AS tnt1_send, tnt1_reg, dbo.cur1_send(inf_i) AS courier1, dbo.tel1_send(inf_i) AS tel1, dbo.rez1_send(inf_i) AS rez1, dbo.mac1_send(inf_i) AS macne1, dbo.start2(inf_i) AS auc1_start, dbo.end2(inf_i) AS auc1_end, lot1_num, price2_usd, price2_gel, dbo.post2_send(inf_i) AS post2_send, post2_reg, dbo.tnt2_send(inf_i) AS tnt2_send, tnt2_reg, dbo.cur2_send(inf_i) AS courier2, dbo.tel2_send(inf_i) AS tel2, dbo.rez2_send(inf_i) AS rez2, dbo.mac2_send(inf_i) AS macne2, dbo.start3(inf_i) AS auc2_start, dbo.end3(inf_i) AS auc2_end, lot2_num, buyer, sum_gel, dbo.dgg_info(inf_i) AS dgg, inf_i, dbo.prep(ltrim(rtrim(nom))) AS prepaid_dt, repres_mail, owner_tel, gazrez, harmacne, dbo.spec(inf_i) as harspec, dbo.dgg_dat(inf_i) AS dgg0, dbo.eacut(inf_i) as eacution,dbo.eacut(inf_i) as eacution1,dbo.dgg_dat(inf_i) AS dgg1,dbo.bank_info(inf_i) AS bank,dbo.fee(inf_i) AS fee,isnull(freeze,0) as freeze,isnull(freeze_1,0) as freeze_1,end_date,auc2,auc2_dt,auc3,auc3_dt,gaz,gaz_dt,mac,mac_dt,specpr,kor,isnull(pdfo,0) as  pdfo,isnull(sales_eur,0) as sales_eur,dbo.fee(inf_i) * 0.0059 -  dbo.prep(ltrim(rtrim(nom)))  AS coms,auqpr,auqt,liquid_price,comment,dbo.chstg(inf_i) as chsg  FROM info where end_date is not null and end_date < " + "'" + DateTime.Today.AddYears(-1).Date.ToString("yyyyMMdd") + "' ORDER BY dbo.nom(inf_i)";

                filter_base = "end_date is not null and end_date < " + "'" + DateTime.Today.AddYears(-1).Date.ToString() + "'";
                B_clon.Enabled = false;
            }

            SqlDataAdapter da = new SqlDataAdapter(Sql);

            dS_info.Clear();

            da.Fill(this.dS_info.info);

            BS_info.Filter = filter_base;

            DGV_info.Refresh();

            DGV_info.Select();

        }

        private void pr_cl_inf(object sender, EventArgs e)
        {
            if (izm == 1)
            {
                if (
                (MessageBox.Show("         შენახვა", "თქვენ შეასრულეთ ცვლილებები", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)).ToString() == "Yes")
                {
                    pr_save_inf(sender, e);
                }
                else
                {
                    izm = 0;
                    note = "";
                }
            }

            Pa_inf.Visible = false;

            DGV_info.Enabled = true;
            B_infadd.Enabled = true;
            B_infcha.Enabled = true;
            B_infdel.Enabled = true;

        }

        private void pr_infadd(object sender, EventArgs e)
        {
            /*BS_cust.CurrentItemChanged -= pr_cust;*/

            DGV_info.Enabled = false;
            B_infadd.Enabled = false;
            B_infcha.Enabled = false;
            B_infdel.Enabled = false;

            rezhim = 1;

            spec0 = 1;
            stat0 = 1;
            cust0 = 1;

            av = 0;
            krfi = 0;

            BS_spec.MoveFirst();
            BS_stat.MoveFirst();
            BS_cust.MoveFirst();
            BS_repr.MoveFirst();

            TB_ad_date.CustomFormat = " ";
            TB_dt_mort.CustomFormat = " ";

            TB_post_send.CustomFormat = " ";
            TB_tnt_send.CustomFormat = " ";
            TB_courier.CustomFormat = " ";
            TB_tel.CustomFormat = " ";
            TB_rez.CustomFormat = " ";
            TB_macne.CustomFormat = " ";
            TB_auc_start.CustomFormat = " ";
            TB_auc_end.CustomFormat = " ";

            TB_post1_send.CustomFormat = " ";
            TB_tnt1_send.CustomFormat = " ";
            TB_courier1.CustomFormat = " ";
            TB_tel1.CustomFormat = " ";
            TB_rez1.CustomFormat = " ";
            TB_macne1.CustomFormat = " ";
            TB_auc1_start.CustomFormat = " ";
            TB_auc1_end.CustomFormat = " ";

            TB_post2_send.CustomFormat = " ";
            TB_tnt2_send.CustomFormat = " ";
            TB_courier2.CustomFormat = " ";
            TB_tel2.CustomFormat = " ";
            TB_rez2.CustomFormat = " ";
            TB_macne2.CustomFormat = " ";
            TB_auc2_start.CustomFormat = " ";
            TB_auc2_end.CustomFormat = " ";

            TP_end.CustomFormat = " ";

            TP_auc2.CustomFormat = " ";
            TP_auc3.CustomFormat = " ";
            TP_gaz.CustomFormat = " ";
            TP_mac.CustomFormat = " ";

            CB_post_reg.Text = "";
            CB_tnt_reg.Text = "";
            CB_post1_reg.Text = "";
            CB_tnt1_reg.Text = "";
            CB_post2_reg.Text = "";
            CB_tnt2_reg.Text = "";

            TB_nom.Text = "";
            TB_spec.Text = "";
            TB_stat.Text = "";
            TB_auqt.Text = "";
            TB_cust.Text = "";
            TB_repr.Text = "";
            TB_n_mort.Text = "";
            TB_credit_tr.Text = "";
            TB_credit_id.Text = "";
            TB_debt_gel.Text = "";
            TB_prop_addr.Text = "";
            TB_prop_code.Text = "";
            TB_property.Text = "";
            TB_rights.Text = "";
            TB_owner.Text = "";
            TB_ow_num.Text = "";
            TB_ow_tel.Text = "";
            TB_ow_addr1.Text = "";
            TB_ow_addr2.Text = "";
            TB_ow_addr3.Text = "";
            TB_ow_addr4.Text = "";
            TB_debtor.Text = "";
            TB_deb_num.Text = "";
            TB_deb_addr.Text = "";
            TB_debtor1.Text = "";
            TB_deb1_num.Text = "";
            TB_deb1_addr.Text = "";
            CB_foto.Checked = false;
            CB_prepaid.Text = "";
            TB_sales_usd.Text = "";
            TB_liq_usd.Text = "";
            TB_sales_eur.Text = "";

            TB_price_usd.Text = "";
            TB_price_gel.Text = "";
            TB_lot_num.Text = "";

            TB_price1_usd.Text = "";
            TB_price1_gel.Text = "";
            TB_lot1_num.Text = "";

            TB_price2_usd.Text = "";
            TB_price2_gel.Text = "";
            TB_lot2_num.Text = "";

            TB_buyer.Text = "";
            TB_sum_gel.Text = "";
            CB_dgg.Checked = false;
            CB_stg.Checked = true;
            /*TB_bank.Text = "";*/
            TB_eacution.Text = "";
            /*TB_vat.Text = "";*/
            TB_dgg.Text = "";
            /*TB_icom.Text = "";*/
            TB_gazrez.Text = "";
            TB_harmacne.Text = "";
            TB_harspec.Text = "";
            TB_eacution1.Text = "";
            TB_dgg1.Text = "";
            TB_bank1.Text = "";
            TB_fee.Text = "";

            TB_auc2.Text = "";
            TB_auc3.Text = "";
            TB_gaz.Text = "";
            TB_mac.Text = "";

            TB_specpr.Text = "3.20";
            TB_kor.Text = "0.00";
            TB_auqpr.Text = "1.00";

            TB_com.Text = "";

            izm = 0;
            note = "";

            CB_frz.Checked = false;
            CB_frz1.Checked = false;

            B_delspec.Enabled = false;
            B_delstat.Enabled = false;
            B_delcust.Enabled = false;
            B_delrep.Enabled = false;

            TB_nom.Focus();
            Pa_inf.BringToFront();
            Pa_inf.Visible = true;

            /*BS_cust.CurrentItemChanged += pr_cust;*/
        }

        private void pr_infedit(object sender, EventArgs e)
        {
            /*BS_cust.CurrentItemChanged -= pr_cust;*/

            av = 0;
            krfi = 0;

            DGV_info.Enabled = false;
            B_infadd.Enabled = false;
            B_infcha.Enabled = false;
            B_infdel.Enabled = false;

            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            DateTime d0;

            rezhim = 2;

            TB_ad_date.CustomFormat = " ";
            TB_dt_mort.CustomFormat = " ";

            TB_post_send.CustomFormat = " ";
            TB_tnt_send.CustomFormat = " ";
            TB_courier.CustomFormat = " ";
            TB_tel.CustomFormat = " ";
            TB_rez.CustomFormat = " ";
            TB_macne.CustomFormat = " ";
            TB_auc_start.CustomFormat = " ";
            TB_auc_end.CustomFormat = " ";

            TB_post1_send.CustomFormat = " ";
            TB_tnt1_send.CustomFormat = " ";
            TB_courier1.CustomFormat = " ";
            TB_tel1.CustomFormat = " ";
            TB_rez1.CustomFormat = " ";
            TB_macne1.CustomFormat = " ";
            TB_auc1_start.CustomFormat = " ";
            TB_auc1_end.CustomFormat = " ";

            TB_post2_send.CustomFormat = " ";
            TB_tnt2_send.CustomFormat = " ";
            TB_courier2.CustomFormat = " ";
            TB_tel2.CustomFormat = " ";
            TB_rez2.CustomFormat = " ";
            TB_macne2.CustomFormat = " ";
            TB_auc2_start.CustomFormat = " ";
            TB_auc2_end.CustomFormat = " ";

            TP_end.CustomFormat = " ";

            TP_auc2.CustomFormat = " ";
            TP_auc3.CustomFormat = " ";
            TP_gaz.CustomFormat = " ";
            TP_mac.CustomFormat = " ";

            TB_specpr.Text = "3.20";
            TB_kor.Text = "0.00";
            TB_auqpr.Text = "1.00";

            B_delspec.Enabled = false;
            B_delstat.Enabled = false;
            B_delcust.Enabled = false;
            B_delrep.Enabled = false;

            int colugi = DGV_info.CurrentCell.ColumnIndex;
            int rowwgi = DGV_info.CurrentCell.RowIndex;
            rowcur = rowwgi;

            infi = DGV_info.Rows[rowwgi].Cells["inf_i"].Value.ToString();

            TB_nom.Text = DGV_info.Rows[rowwgi].Cells["nom"].Value.ToString();
            TB_spec.Text = DGV_info.Rows[rowwgi].Cells["spec"].Value.ToString();

            if (TB_spec.Text.Trim() == "")
            {
                B_delspec.Enabled = false;
            }
            else
            {
                B_delspec.Enabled = true;
            }

            TB_stat.Text = DGV_info.Rows[rowwgi].Cells["stat"].Value.ToString();

            if (TB_stat.Text.Trim() == "")
            {
                B_delstat.Enabled = false;
            }
            else
            {
                /*B_delstat.Enabled = true;*/
            }

            TB_auqt.Text = DGV_info.Rows[rowwgi].Cells["auqt"].Value.ToString();

            TB_cust.Text = DGV_info.Rows[rowwgi].Cells["cust"].Value.ToString();

            if (TB_cust.Text.Trim() == "")
            {
                B_delcust.Enabled = false;
            }
            else
            {
                B_delcust.Enabled = true;
            }

            TB_repr.Text = DGV_info.Rows[rowwgi].Cells["representative"].Value.ToString();

            if (TB_repr.Text.Trim() == "")
            {
                B_delrep.Enabled = false;
            }
            else
            {
                B_delrep.Enabled = true;
            }

            if (DGV_info.Rows[rowwgi].Cells["ad_date"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["ad_date"].Value);
                TB_ad_date.Text = d0.ToString("dd/MM/yyyy");
                TB_ad_date.CustomFormat = "";
                TB_ad_date.Value = d0;
            }

            if (DGV_info.Rows[rowwgi].Cells["end_date"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["end_date"].Value);
                TP_end.Text = d0.ToString("dd/MM/yyyy");
                TP_end.CustomFormat = "";
                TP_end.Value = d0;
            }

            if (DGV_info.Rows[rowwgi].Cells["auc2_dt"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc2_dt"].Value);
                TP_auc2.Text = d0.ToString("dd/MM/yyyy");
                TP_auc2.CustomFormat = "";
                TP_auc2.Value = d0;
            }

            if (DGV_info.Rows[rowwgi].Cells["auc3_dt"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc3_dt"].Value);
                TP_auc3.Text = d0.ToString("dd/MM/yyyy");
                TP_auc3.CustomFormat = "";
                TP_auc3.Value = d0;
            }

            if (DGV_info.Rows[rowwgi].Cells["gaz_dt"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["gaz_dt"].Value);
                TP_gaz.Text = d0.ToString("dd/MM/yyyy");
                TP_gaz.CustomFormat = "";
                TP_gaz.Value = d0;
            }

            if (DGV_info.Rows[rowwgi].Cells["mac_dt"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["mac_dt"].Value);
                TP_mac.Text = d0.ToString("dd/MM/yyyy");
                TP_mac.CustomFormat = "";
                TP_mac.Value = d0;
            }

            TB_n_mort.Text = DGV_info.Rows[rowwgi].Cells["n_mortgage"].Value.ToString();

            if (DGV_info.Rows[rowwgi].Cells["dt_mortgage"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["dt_mortgage"].Value);
                TB_dt_mort.Text = d0.ToString("dd/MM/yyyy");
                TB_dt_mort.CustomFormat = "";
                TB_dt_mort.Value = d0;
            }

            TB_credit_tr.Text = DGV_info.Rows[rowwgi].Cells["credit_treaty"].Value.ToString();
            TB_credit_id.Text = DGV_info.Rows[rowwgi].Cells["credit_id"].Value.ToString();
            TB_debt_gel.Text = DGV_info.Rows[rowwgi].Cells["debt_gel"].Value.ToString();
            TB_prop_addr.Text = DGV_info.Rows[rowwgi].Cells["property_addr"].Value.ToString();
            TB_prop_code.Text = DGV_info.Rows[rowwgi].Cells["property_code"].Value.ToString();
            TB_property.Text = DGV_info.Rows[rowwgi].Cells["property"].Value.ToString();
            TB_rights.Text = DGV_info.Rows[rowwgi].Cells["rights"].Value.ToString();
            TB_owner.Text = DGV_info.Rows[rowwgi].Cells["owner"].Value.ToString();
            TB_ow_num.Text = DGV_info.Rows[rowwgi].Cells["owner_num"].Value.ToString();
            TB_ow_tel.Text = DGV_info.Rows[rowwgi].Cells["owner_tel"].Value.ToString();
            TB_ow_addr1.Text = DGV_info.Rows[rowwgi].Cells["owner_addr1"].Value.ToString();
            TB_ow_addr2.Text = DGV_info.Rows[rowwgi].Cells["owner_addr2"].Value.ToString();
            TB_ow_addr3.Text = DGV_info.Rows[rowwgi].Cells["owner_addr3"].Value.ToString();
            TB_ow_addr4.Text = DGV_info.Rows[rowwgi].Cells["owner_addr4"].Value.ToString();
            TB_debtor.Text = DGV_info.Rows[rowwgi].Cells["debtor"].Value.ToString();
            TB_deb_num.Text = DGV_info.Rows[rowwgi].Cells["debtor_num"].Value.ToString();
            TB_deb_addr.Text = DGV_info.Rows[rowwgi].Cells["debtor_addr"].Value.ToString();
            TB_debtor1.Text = DGV_info.Rows[rowwgi].Cells["debtor1"].Value.ToString();
            TB_deb1_num.Text = DGV_info.Rows[rowwgi].Cells["debtor1_num"].Value.ToString();
            TB_deb1_addr.Text = DGV_info.Rows[rowwgi].Cells["debtor1_addr"].Value.ToString();
            CB_post_reg.Text = DGV_info.Rows[rowwgi].Cells["post_reg"].Value.ToString();
            CB_tnt_reg.Text = DGV_info.Rows[rowwgi].Cells["tnt_reg"].Value.ToString();
            CB_post1_reg.Text = DGV_info.Rows[rowwgi].Cells["post1_reg"].Value.ToString();
            CB_tnt1_reg.Text = DGV_info.Rows[rowwgi].Cells["tnt1_reg"].Value.ToString();
            CB_post2_reg.Text = DGV_info.Rows[rowwgi].Cells["post2_reg"].Value.ToString();
            CB_tnt2_reg.Text = DGV_info.Rows[rowwgi].Cells["tnt2_reg"].Value.ToString();
            TB_com.Text = DGV_info.Rows[rowwgi].Cells["comment0"].Value.ToString();


            if (DGV_info.Rows[rowwgi].Cells["foto"].Value.ToString() == "NO")
            {
                CB_foto.Checked = false;
                /*TB_liq_usd.Enabled = false;
                TB_liq_usd.Text = "0.00";*/
            }
            else
            {
                CB_foto.Checked = true;
                /*TB_liq_usd.Enabled = true;*/
            }

            if (DGV_info.Rows[rowwgi].Cells["foto"].Value.ToString() == "NO")
            {
                CB_foto.Checked = false;
            }
            else
            {
                CB_foto.Checked = true;
            }

            CB_prepaid.Text = DGV_info.Rows[rowwgi].Cells["prepaid"].Value.ToString();

            TB_prepaid.Text = DGV_info.Rows[rowwgi].Cells["prepaid_dt"].Value.ToString();

            TB_sales_usd.Text = DGV_info.Rows[rowwgi].Cells["sales_usd"].Value.ToString();

            TB_liq_usd.Text = DGV_info.Rows[rowwgi].Cells["liquid_price"].Value.ToString();

            TB_sales_eur.Text = DGV_info.Rows[rowwgi].Cells["sales_eur"].Value.ToString();

            TB_price_usd.Text = DGV_info.Rows[rowwgi].Cells["price_usd"].Value.ToString();
            TB_price_gel.Text = DGV_info.Rows[rowwgi].Cells["price_gel"].Value.ToString();


            if (DGV_info.Rows[rowwgi].Cells["post_send"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["post_send"].Value);
                TB_post_send.Text = d0.ToString("dd/MM/yyyy");
                TB_post_send.CustomFormat = "";
                TB_post_send.Value = d0;
            }
            if (DGV_info.Rows[rowwgi].Cells["tnt_send"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["tnt_send"].Value);
                TB_tnt_send.Text = d0.ToString("dd/MM/yyyy");
                TB_tnt_send.CustomFormat = "";
                TB_tnt_send.Value = d0;
            }
            if (DGV_info.Rows[rowwgi].Cells["rez"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["rez"].Value);
                TB_rez.Text = d0.ToString("dd/MM/yyyy");
                TB_rez.CustomFormat = "";
                TB_rez.Value = d0;
            }
            if (DGV_info.Rows[rowwgi].Cells["macne"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["macne"].Value);
                TB_macne.Text = d0.ToString("dd/MM/yyyy");
                TB_macne.CustomFormat = "";
                TB_macne.Value = d0;
            }
            if (DGV_info.Rows[rowwgi].Cells["auc_start"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc_start"].Value);
                TB_auc_start.Text = d0.ToString("dd/MM/yyyy");
                TP_auc_start.Text = d0.ToString("HH:mm");
                TB_auc_start.CustomFormat = "";
                TB_auc_start.Value = d0;
            }
            if (DGV_info.Rows[rowwgi].Cells["auc_end"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc_end"].Value);
                TB_auc_end.Text = d0.ToString("dd/MM/yyyy");
                TP_auc_end.Text = d0.ToString("HH:mm");
                TB_auc_end.CustomFormat = "";
                TB_auc_end.Value = d0;
            }


            if (DGV_info.Rows[rowwgi].Cells["post1_send"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["post1_send"].Value);
                TB_post1_send.Text = d0.ToString("dd/MM/yyyy");
                TB_post1_send.CustomFormat = "";
                TB_post1_send.Value = d0;
            }
            if (DGV_info.Rows[rowwgi].Cells["tnt1_send"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["tnt1_send"].Value);
                TB_tnt1_send.Text = d0.ToString("dd/MM/yyyy");
                TB_tnt1_send.CustomFormat = "";
                TB_tnt1_send.Value = d0;
            }
            if (DGV_info.Rows[rowwgi].Cells["rez1"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["rez1"].Value);
                TB_rez1.Text = d0.ToString("dd/MM/yyyy");
                TB_rez1.CustomFormat = "";
                TB_rez1.Value = d0;
            }
            if (DGV_info.Rows[rowwgi].Cells["macne1"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["macne1"].Value);
                TB_macne1.Text = d0.ToString("dd/MM/yyyy");
                TB_macne1.CustomFormat = "";
                TB_macne1.Value = d0;
            }
            if (DGV_info.Rows[rowwgi].Cells["auc1_start"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc1_start"].Value);
                TB_auc1_start.Text = d0.ToString("dd/MM/yyyy");
                TP_auc1_start.Text = d0.ToString("HH:mm");
                TB_auc1_start.CustomFormat = "";
                TB_auc1_start.Value = d0;
            }
            if (DGV_info.Rows[rowwgi].Cells["auc1_end"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc1_end"].Value);
                TB_auc1_end.Text = d0.ToString("dd/MM/yyyy");
                TP_auc1_end.Text = d0.ToString("HH:mm");
                TB_auc1_end.CustomFormat = "";
                TB_auc1_end.Value = d0;
            }


            if (DGV_info.Rows[rowwgi].Cells["post2_send"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["post2_send"].Value);
                TB_post2_send.Text = d0.ToString("dd/MM/yyyy");
                TB_post2_send.CustomFormat = "";
                TB_post2_send.Value = d0;
            }
            if (DGV_info.Rows[rowwgi].Cells["tnt2_send"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["tnt2_send"].Value);
                TB_tnt2_send.Text = d0.ToString("dd/MM/yyyy");
                TB_tnt2_send.CustomFormat = "";
                TB_tnt2_send.Value = d0;
            }
            if (DGV_info.Rows[rowwgi].Cells["rez2"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["rez2"].Value);
                TB_rez2.Text = d0.ToString("dd/MM/yyyy");
                TB_rez2.CustomFormat = "";
                TB_rez2.Value = d0;
            }
            if (DGV_info.Rows[rowwgi].Cells["macne2"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["macne2"].Value);
                TB_macne2.Text = d0.ToString("dd/MM/yyyy");
                TB_macne2.CustomFormat = "";
                TB_macne2.Value = d0;
            }
            if (DGV_info.Rows[rowwgi].Cells["auc2_start"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc2_start"].Value);
                TB_auc2_start.Text = d0.ToString("dd/MM/yyyy");
                TP_auc2_start.Text = d0.ToString("HH:mm");
                TB_auc2_start.CustomFormat = "";
                TB_auc2_start.Value = d0;
            }
            if (DGV_info.Rows[rowwgi].Cells["auc2_end"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["auc2_end"].Value);
                TB_auc2_end.Text = d0.ToString("dd/MM/yyyy");
                TP_auc2_end.Text = d0.ToString("HH:mm");
                TB_auc2_end.CustomFormat = "";
                TB_auc2_end.Value = d0;
            }

            if (DGV_info.Rows[rowwgi].Cells["courier"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["courier"].Value);
                TB_courier.Text = d0.ToString("dd/MM/yyyy");
                TB_courier.CustomFormat = "";
                TB_courier.Value = d0;
            }

            if (DGV_info.Rows[rowwgi].Cells["tel"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["tel"].Value);
                TB_tel.Text = d0.ToString("dd/MM/yyyy");
                TB_tel.CustomFormat = "";
                TB_tel.Value = d0;
            }

            TB_lot_num.Text = DGV_info.Rows[rowwgi].Cells["lot_num"].Value.ToString();

            TB_price1_usd.Text = DGV_info.Rows[rowwgi].Cells["price1_usd"].Value.ToString();
            TB_price1_gel.Text = DGV_info.Rows[rowwgi].Cells["price1_gel"].Value.ToString();


            if (DGV_info.Rows[rowwgi].Cells["courier1"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["courier1"].Value);
                TB_courier1.Text = d0.ToString("dd/MM/yyyy");
                TB_courier1.CustomFormat = "";
                TB_courier1.Value = d0;
            }

            if (DGV_info.Rows[rowwgi].Cells["tel1"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["tel1"].Value);
                TB_tel1.Text = d0.ToString("dd/MM/yyyy");
                TB_tel1.CustomFormat = "";
                TB_tel1.Value = d0;
            }

            TB_lot1_num.Text = DGV_info.Rows[rowwgi].Cells["lot1_num"].Value.ToString();


            TB_price2_usd.Text = DGV_info.Rows[rowwgi].Cells["price2_usd"].Value.ToString();
            TB_price2_gel.Text = DGV_info.Rows[rowwgi].Cells["price2_gel"].Value.ToString();

            if (DGV_info.Rows[rowwgi].Cells["courier2"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["courier2"].Value);
                TB_courier2.Text = d0.ToString("dd/MM/yyyy");
                TB_courier2.CustomFormat = "";
                TB_courier2.Value = d0;
            }

            if (DGV_info.Rows[rowwgi].Cells["tel2"].Value != DBNull.Value)
            {
                d0 = Convert.ToDateTime(DGV_info.Rows[rowwgi].Cells["tel2"].Value);
                TB_tel2.Text = d0.ToString("dd/MM/yyyy");
                TB_tel2.CustomFormat = "";
                TB_tel2.Value = d0;
            }

            TB_lot2_num.Text = DGV_info.Rows[rowwgi].Cells["lot2_num"].Value.ToString();


            TB_buyer.Text = DGV_info.Rows[rowwgi].Cells["buyer"].Value.ToString();
            TB_sum_gel.Text = DGV_info.Rows[rowwgi].Cells["sum_gel"].Value.ToString();

            if (DGV_info.Rows[rowwgi].Cells["dgg"].Value.ToString().Trim() == "NO")
            {
                CB_dgg.Checked = false;
            }
            else
            {
                CB_dgg.Checked = true;
            }

            if (DGV_info.Rows[rowwgi].Cells["chsg"].Value.ToString().Trim() == "NO")
            {
                CB_stg.Checked = false;
                TB_fee.BackColor = Color.White;
                TB_fee.ReadOnly = false;
            }
            else
            {
                CB_stg.Checked = true;
                TB_fee.BackColor = Color.LightGray;
                TB_fee.ReadOnly = true;
            }

            if (DGV_info.Rows[rowwgi].Cells["freeze"].Value.ToString().Trim() == "False")
            {
                CB_frz.Checked = false;
            }
            else
            {
                CB_frz.Checked = true;
            }

            if (DGV_info.Rows[rowwgi].Cells["freeze_1"].Value.ToString().Trim() == "False")
            {
                CB_frz1.Checked = false;
            }
            else
            {
                CB_frz1.Checked = true;
            }

            /*TB_bank.Text = DGV_info.Rows[rowwgi].Cells["bank"].Value.ToString();*/
            TB_eacution.Text = DGV_info.Rows[rowwgi].Cells["eacution"].Value.ToString();
            /*TB_vat.Text = DGV_info.Rows[rowwgi].Cells["vat"].Value.ToString();*/
            TB_dgg.Text = DGV_info.Rows[rowwgi].Cells["dgg0"].Value.ToString();
            /*TB_icom.Text = DGV_info.Rows[rowwgi].Cells["icom"].Value.ToString();*/
            TB_gazrez.Text = DGV_info.Rows[rowwgi].Cells["gazrez"].Value.ToString();
            TB_harmacne.Text = DGV_info.Rows[rowwgi].Cells["harmacne"].Value.ToString();
            TB_harspec.Text = DGV_info.Rows[rowwgi].Cells["harspec"].Value.ToString();
            TB_eacution1.Text = DGV_info.Rows[rowwgi].Cells["eacution1"].Value.ToString();
            TB_dgg1.Text = DGV_info.Rows[rowwgi].Cells["dgg1"].Value.ToString();
            TB_bank1.Text = DGV_info.Rows[rowwgi].Cells["bank"].Value.ToString();
            TB_fee.Text = DGV_info.Rows[rowwgi].Cells["fee"].Value.ToString();

            TB_auc2.Text = DGV_info.Rows[rowwgi].Cells["auc2"].Value.ToString();
            TB_auc3.Text = DGV_info.Rows[rowwgi].Cells["auc3"].Value.ToString();
            TB_gaz.Text = DGV_info.Rows[rowwgi].Cells["gaz"].Value.ToString();
            TB_mac.Text = DGV_info.Rows[rowwgi].Cells["mac"].Value.ToString();

            TB_specpr.Text = DGV_info.Rows[rowwgi].Cells["specpr"].Value.ToString();

            TB_auqpr.Text = DGV_info.Rows[rowwgi].Cells["auqpr"].Value.ToString();

            if (TB_specpr.Text.Trim() == "")
            {
                TB_specpr.Text = "3.20";
            }

            if (TB_auqpr.Text.Trim() == "")
            {
                TB_auqpr.Text = "1.00";
            }

            TB_kor.Text = DGV_info.Rows[rowwgi].Cells["kor"].Value.ToString();

            if (TB_kor.Text.Trim() == "")
            {
                TB_kor.Text = "0.00";
            }

            izm = 0;
            note = "";

            Pa_inf.BringToFront();
            Pa_inf.Visible = true;

            int pn = TC_inf.SelectedIndex;

            TC_inf.SelectedIndex = 2;
            TC_inf.SelectedIndex = 1;
            TC_inf.SelectedIndex = 0;

            TC_inf.SelectedIndex = pn;

            TB_nom.Focus();

            /*BS_cust.CurrentItemChanged += pr_cust;*/

        }

        private void pr_addspec(object sender, EventArgs e)
        {
            TB_newspec.Text = "";
            Pa_newspec.BringToFront();
            Pa_newspec.Visible = true;
            TB_newspec.Focus();
        }

        private void pr_cl_newspec(object sender, EventArgs e)
        {
            Pa_newspec.Visible = false;
        }

        private void pr_savespec(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            string spc = TB_spec.Text;

            if (TB_newspec.Text.Trim() != "")
            {
                Sql.CommandText = "insert into specialists (specialist) values(N'" + TB_newspec.Text.Replace("'", "`").Trim() + "')";
                Sql.ExecuteNonQuery();
            }

            Pa_newspec.Visible = false;

            dS_spec.Clear();

            this.TA_spec.Fill(this.dS_spec.specialists);

            TB_spec.Refresh();

            TB_spec.Text = spc;
        }

        private void pr_addstat(object sender, EventArgs e)
        {
            TB_newstat.Text = "";
            Pa_newstat.BringToFront();
            Pa_newstat.Visible = true;
            TB_newstat.Focus();
        }

        private void pr_cl_newstat(object sender, EventArgs e)
        {
            Pa_newstat.Visible = false;
        }

        private void pr_savestat(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            string stst = TB_stat.Text;

            if (TB_newstat.Text.Trim() != "")
            {
                Sql.CommandText = "insert into status (stat) values(N'" + TB_newstat.Text.Replace("'", "`").Trim() + "')";
                Sql.ExecuteNonQuery();
            }

            Pa_newstat.Visible = false;

            dS_stat.Clear();

            this.TA_stat.Fill(this.dS_stat.status);

            TB_stat.Refresh();

            TB_stat.Text = stst;
        }

        private void pr_addcust(object sender, EventArgs e)
        {
            TB_newcust.Text = "";
            Pa_newcust.BringToFront();
            Pa_newcust.Visible = true;
            TB_newcust.Focus();
        }

        private void pr_cl_newcust(object sender, EventArgs e)
        {
            Pa_newcust.Visible = false;
        }

        private void pr_savecust(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            string cst = TB_cust.Text;

            if (TB_newcust.Text.Trim() != "")
            {
                Sql.CommandText = "insert into customers (customer) values(N'" + TB_newcust.Text.Replace("'", "`").Trim() + "')";
                Sql.ExecuteNonQuery();
            }

            Pa_newcust.Visible = false;

            dS_cust.Clear();

            this.TA_cust.Fill(this.dS_cust.customers);

            TB_cust.Refresh();

            TB_cust.Text = cst;
        }

        private void pr_0(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_ad_date.Value = DateTime.Today.AddDays(1);
                TB_ad_date.CustomFormat = " ";
            }
        }

        private void pr_ch_dt0(object sender, EventArgs e)
        {
            izm = 1;
            TB_ad_date.CustomFormat = "dd/MM/yyyy";
            note = note + "განაცხადის თარიღი; ";
        }

        private void pr_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_dt_mort.Value = DateTime.Today.AddDays(1);
                TB_dt_mort.CustomFormat = " ";
            }
        }

        private void pr_ch_dt1(object sender, EventArgs e)
        {
            izm = 1;
            TB_dt_mort.CustomFormat = "dd/MM/yyyy";
            note = note + "იპოთეკის თარიღი; ";
        }

        private void pr_sem3(object sender, EventArgs e)
        {
            if (TB_sales_usd.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_sales_usd.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_sales_usd.Focus();
                }
            }
        }

        private void pr_sem4(object sender, EventArgs e)
        {
            if (TB_price_usd.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_price_usd.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_price_usd.Focus();
                }
            }
        }

        private void pr_sem5(object sender, EventArgs e)
        {
            if (TB_price_gel.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_price_gel.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_price_gel.Focus();
                }
            }
        }

        private void pr_sem6(object sender, EventArgs e)
        {
            if (TB_price1_usd.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_price1_usd.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_price1_usd.Focus();
                }
            }
        }

        private void pr_sem7(object sender, EventArgs e)
        {
            if (TB_price1_gel.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_price1_gel.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_price1_gel.Focus();
                }
            }
        }

        private void pr_sem8(object sender, EventArgs e)
        {
            if (TB_price2_usd.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_price2_usd.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_price2_usd.Focus();
                }
            }
        }

        private void pr_sem9(object sender, EventArgs e)
        {
            if (TB_price2_gel.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_price2_gel.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_price2_gel.Focus();
                }
            }
        }

        private void pr_ch(object sender, EventArgs e)
        {
            izm = 1;
        }

        private void pr_save_inf(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            SqlCommand Sql1 = new SqlCommand("", sss1);
            Sql1.CommandType = CommandType.Text;

            decimal d03;

            string dt1;
            string dt2;
            string fot;
            string dt3;
            string dt4;

            string dg;
            string chs;

            string cre;

            string dt01;
            string dt02;
            string dt03;
            string dt04;
            string dt05;
            string dt06;
            string dt07;
            string dt08;
            string dt09;
            string dt10;
            string dt11;
            string dt12;
            string dt13;
            string dt14;
            string dt15;
            string dt16;
            string dt17;
            string dt18;
            string dt19;
            string dt20;
            string dt21;
            string dt22;
            string dt23;
            string dt24;

            string dt25;
            string dt26;
            string dt27;
            string dt28;

            string dtt07;
            string dtt08;
            string dtt15;
            string dtt16;
            string dtt23;
            string dtt24;

            string frz;
            string frz1;
            string fee;

            DateTime d0;

            if (TB_nom.Text.Trim() != "")
            {
                Sql1.CommandText = "select count(*) from info where nom = N'" + TB_nom.Text.Trim() + "'";

                int kk = Convert.ToInt32(Sql1.ExecuteScalar().ToString());

                if (rezhim == 2)
                {
                    kk = 0;
                }

                if (kk == 0)
                {
                    if (rezhim == 1)
                    {

                        Sql1.CommandText = "insert into info (nom) values (N'" + TB_nom.Text.Trim() + "')";
                        Sql1.ExecuteNonQuery();

                        Sql1.CommandText = "select inf_i from info where nom = N'" + TB_nom.Text.Trim() + "'";

                        infi = Sql1.ExecuteScalar().ToString();

                        Sql1.CommandText = " insert into logs (user_n,nom_n,ind_n,dt_n,do_n,note) values('" + usname + "',N'" + TB_nom.Text.Trim() + "'," + infi + ",getdate(),1,N'" + note + "')";

                        Sql1.ExecuteNonQuery();

                        note = "";
                    }

                    if (TB_ad_date.Text.Trim() != "")
                    {
                        d0 = TB_ad_date.Value.Date;
                        dt1 = d0.ToString("dd/MM/yyyy");
                        dt1 = "'" + dt1.Substring(6, 4) + dt1.Substring(3, 2) + dt1.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt1 = "null";
                    }

                    if (TP_end.Text.Trim() != "")
                    {
                        d0 = TP_end.Value.Date;
                        dt4 = d0.ToString("dd/MM/yyyy");
                        dt4 = "'" + dt4.Substring(6, 4) + dt4.Substring(3, 2) + dt4.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt4 = "null";
                    }

                    if (TP_auc2.Text.Trim() != "")
                    {
                        d0 = TP_auc2.Value.Date;
                        dt25 = d0.ToString("dd/MM/yyyy");
                        dt25 = "'" + dt25.Substring(6, 4) + dt25.Substring(3, 2) + dt25.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt25 = "null";
                    }

                    if (TP_auc3.Text.Trim() != "")
                    {
                        d0 = TP_auc3.Value.Date;
                        dt26 = d0.ToString("dd/MM/yyyy");
                        dt26 = "'" + dt26.Substring(6, 4) + dt26.Substring(3, 2) + dt26.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt26 = "null";
                    }

                    if (TP_gaz.Text.Trim() != "")
                    {
                        d0 = TP_gaz.Value.Date;
                        dt27 = d0.ToString("dd/MM/yyyy");
                        dt27 = "'" + dt27.Substring(6, 4) + dt27.Substring(3, 2) + dt27.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt27 = "null";
                    }

                    if (TP_mac.Text.Trim() != "")
                    {
                        d0 = TP_mac.Value.Date;
                        dt28 = d0.ToString("dd/MM/yyyy");
                        dt28 = "'" + dt28.Substring(6, 4) + dt28.Substring(3, 2) + dt28.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt28 = "null";
                    }

                    if (TB_dt_mort.Text.Trim() != "")
                    {
                        d0 = TB_dt_mort.Value.Date;
                        dt2 = d0.ToString("dd/MM/yyyy");
                        dt2 = "'" + dt2.Substring(6, 4) + dt2.Substring(3, 2) + dt2.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt2 = "null";
                    }

                    if (CB_foto.Checked)
                    {
                        fot = "1";
                    }
                    else
                    {
                        fot = "0";
                    }

                    try
                    {
                        d03 = Convert.ToDecimal(TB_prepaid.Text);
                        dt3 = d03.ToString();
                    }
                    catch
                    {
                        dt3 = "0";
                    }

                    if (CB_dgg.Checked)
                    {
                        dg = "1";
                    }
                    else
                    {
                        dg = "0";
                    }

                    if (CB_stg.Checked)
                    {
                        chs = "1";
                    }
                    else
                    {
                        chs = "0";
                    }

                    if (CB_frz.Checked)
                    {
                        frz = "1";
                    }
                    else
                    {
                        frz = "0";
                    }

                    if (CB_frz1.Checked)
                    {
                        frz1 = "1";
                    }
                    else
                    {
                        frz1 = "0";
                    }

                    if (TB_credit_id.Text.Trim().Length != 0)
                    {
                        cre = TB_credit_id.Text;
                    }
                    else
                    {
                        cre = "0";
                    }

                    if (TB_post_send.Text.Trim() != "")
                    {
                        d0 = TB_post_send.Value.Date;
                        dt01 = d0.ToString("dd/MM/yyyy");
                        dt01 = "'" + dt01.Substring(6, 4) + dt01.Substring(3, 2) + dt01.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt01 = "null";
                    }

                    if (TB_tnt_send.Text.Trim() != "")
                    {
                        d0 = TB_tnt_send.Value.Date;
                        dt02 = d0.ToString("dd/MM/yyyy");
                        dt02 = "'" + dt02.Substring(6, 4) + dt02.Substring(3, 2) + dt02.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt02 = "null";
                    }

                    if (TB_courier.Text.Trim() != "")
                    {
                        d0 = TB_courier.Value.Date;
                        dt03 = d0.ToString("dd/MM/yyyy");
                        dt03 = "'" + dt03.Substring(6, 4) + dt03.Substring(3, 2) + dt03.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt03 = "null";
                    }

                    if (TB_tel.Text.Trim() != "")
                    {
                        d0 = TB_tel.Value.Date;
                        dt04 = d0.ToString("dd/MM/yyyy");
                        dt04 = "'" + dt04.Substring(6, 4) + dt04.Substring(3, 2) + dt04.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt04 = "null";
                    }

                    if (TB_rez.Text.Trim() != "")
                    {
                        d0 = TB_rez.Value.Date;
                        dt05 = d0.ToString("dd/MM/yyyy");
                        dt05 = "'" + dt05.Substring(6, 4) + dt05.Substring(3, 2) + dt05.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt05 = "null";
                    }

                    if (TB_macne.Text.Trim() != "")
                    {
                        d0 = TB_macne.Value.Date;
                        dt06 = d0.ToString("dd/MM/yyyy");
                        dt06 = "'" + dt06.Substring(6, 4) + dt06.Substring(3, 2) + dt06.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt06 = "null";
                    }

                    if (TB_auc_start.Text.Trim() != "")
                    {
                        d0 = TB_auc_start.Value.Date;
                        dt07 = d0.ToString("dd/MM/yyyy");
                        dt07 = "'" + dt07.Substring(6, 4) + dt07.Substring(3, 2) + dt07.Substring(0, 2);
                        dtt07 = TP_auc_start.Value.ToString("HH:mm");
                        dt07 = dt07 + " " + dtt07 + "'";
                    }
                    else
                    {
                        dt07 = "null";
                    }

                    if (TB_auc_end.Text.Trim() != "")
                    {
                        d0 = TB_auc_end.Value.Date;
                        dt08 = d0.ToString("dd/MM/yyyy");
                        dt08 = "'" + dt08.Substring(6, 4) + dt08.Substring(3, 2) + dt08.Substring(0, 2);
                        dtt08 = TP_auc_end.Value.ToString("HH:mm");
                        dt08 = dt08 + " " + dtt08 + "'";
                    }
                    else
                    {
                        dt08 = "null";
                    }


                    if (TB_post1_send.Text.Trim() != "")
                    {
                        d0 = TB_post1_send.Value.Date;
                        dt09 = d0.ToString("dd/MM/yyyy");
                        dt09 = "'" + dt09.Substring(6, 4) + dt09.Substring(3, 2) + dt09.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt09 = "null";
                    }

                    if (TB_tnt1_send.Text.Trim() != "")
                    {
                        d0 = TB_tnt1_send.Value.Date;
                        dt10 = d0.ToString("dd/MM/yyyy");
                        dt10 = "'" + dt10.Substring(6, 4) + dt10.Substring(3, 2) + dt10.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt10 = "null";
                    }

                    if (TB_courier1.Text.Trim() != "")
                    {
                        d0 = TB_courier1.Value.Date;
                        dt11 = d0.ToString("dd/MM/yyyy");
                        dt11 = "'" + dt11.Substring(6, 4) + dt11.Substring(3, 2) + dt11.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt11 = "null";
                    }

                    if (TB_tel1.Text.Trim() != "")
                    {
                        d0 = TB_tel1.Value.Date;
                        dt12 = d0.ToString("dd/MM/yyyy");
                        dt12 = "'" + dt12.Substring(6, 4) + dt12.Substring(3, 2) + dt12.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt12 = "null";
                    }

                    if (TB_rez1.Text.Trim() != "")
                    {
                        d0 = TB_rez1.Value.Date;
                        dt13 = d0.ToString("dd/MM/yyyy");
                        dt13 = "'" + dt13.Substring(6, 4) + dt13.Substring(3, 2) + dt13.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt13 = "null";
                    }

                    if (TB_macne1.Text.Trim() != "")
                    {
                        d0 = TB_macne1.Value.Date;
                        dt14 = d0.ToString("dd/MM/yyyy");
                        dt14 = "'" + dt14.Substring(6, 4) + dt14.Substring(3, 2) + dt14.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt14 = "null";
                    }

                    if (TB_auc1_start.Text.Trim() != "")
                    {
                        d0 = TB_auc1_start.Value.Date;
                        dt15 = d0.ToString("dd/MM/yyyy");
                        dt15 = "'" + dt15.Substring(6, 4) + dt15.Substring(3, 2) + dt15.Substring(0, 2);
                        dtt15 = TP_auc1_start.Value.ToString("HH:mm");
                        dt15 = dt15 + " " + dtt15 + "'";
                    }
                    else
                    {
                        dt15 = "null";
                    }

                    if (TB_auc1_end.Text.Trim() != "")
                    {
                        d0 = TB_auc1_end.Value.Date;
                        dt16 = d0.ToString("dd/MM/yyyy");
                        dt16 = "'" + dt16.Substring(6, 4) + dt16.Substring(3, 2) + dt16.Substring(0, 2);
                        dtt16 = TP_auc1_end.Value.ToString("HH:mm");
                        dt16 = dt16 + " " + dtt16 + "'";
                    }
                    else
                    {
                        dt16 = "null";
                    }


                    if (TB_post2_send.Text.Trim() != "")
                    {
                        d0 = TB_post2_send.Value.Date;
                        dt17 = d0.ToString("dd/MM/yyyy");
                        dt17 = "'" + dt17.Substring(6, 4) + dt17.Substring(3, 2) + dt17.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt17 = "null";
                    }

                    if (TB_tnt2_send.Text.Trim() != "")
                    {
                        d0 = TB_tnt2_send.Value.Date;
                        dt18 = d0.ToString("dd/MM/yyyy");
                        dt18 = "'" + dt18.Substring(6, 4) + dt18.Substring(3, 2) + dt18.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt18 = "null";
                    }

                    if (TB_courier2.Text.Trim() != "")
                    {
                        d0 = TB_courier2.Value.Date;
                        dt19 = d0.ToString("dd/MM/yyyy");
                        dt19 = "'" + dt19.Substring(6, 4) + dt19.Substring(3, 2) + dt19.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt19 = "null";
                    }

                    if (TB_tel2.Text.Trim() != "")
                    {
                        d0 = TB_tel2.Value.Date;
                        dt20 = d0.ToString("dd/MM/yyyy");
                        dt20 = "'" + dt20.Substring(6, 4) + dt20.Substring(3, 2) + dt20.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt20 = "null";
                    }

                    if (TB_rez2.Text.Trim() != "")
                    {
                        d0 = TB_rez2.Value.Date;
                        dt21 = d0.ToString("dd/MM/yyyy");
                        dt21 = "'" + dt21.Substring(6, 4) + dt21.Substring(3, 2) + dt21.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt21 = "null";
                    }

                    if (TB_macne2.Text.Trim() != "")
                    {
                        d0 = TB_macne2.Value.Date;
                        dt22 = d0.ToString("dd/MM/yyyy");
                        dt22 = "'" + dt22.Substring(6, 4) + dt22.Substring(3, 2) + dt22.Substring(0, 2) + "'";
                    }
                    else
                    {
                        dt22 = "null";
                    }
                    
                    if (TB_auc2_start.Text.Trim() != "")
                    {
                        d0 = TB_auc2_start.Value.Date;
                        dt23 = d0.ToString("dd/MM/yyyy");
                        dt23 = "'" + dt23.Substring(6, 4) + dt23.Substring(3, 2) + dt23.Substring(0, 2);
                        dtt23 = TP_auc2_start.Value.ToString("HH:mm");
                        dt23 = dt23 + " " + dtt23 + "'";
                    }
                    else
                    {
                        dt23 = "null";
                    }
                    
                    if (TB_auc2_end.Text.Trim() != "")
                    {
                        d0 = TB_auc2_end.Value.Date;
                        dt24 = d0.ToString("dd/MM/yyyy");
                        dt24 = "'" + dt24.Substring(6, 4) + dt24.Substring(3, 2) + dt24.Substring(0, 2);
                        dtt24 = TP_auc2_end.Value.ToString("HH:mm");
                        dt24 = dt24 + " " + dtt24 + "'";
                    }
                    else
                    {
                        dt24 = "null";
                    }

                    try
                    {
                        d03 = Convert.ToDecimal(TB_fee.Text);
                        fee = d03.ToString();
                    }
                    catch
                    {
                        fee = "null";
                    }

                    Sql.CommandText = "update info";
                    Sql.CommandText = Sql.CommandText + " set kor = " + TB_kor.Text.Trim() + ",specpr = " + TB_specpr.Text.Trim() + ",auqpr = " + TB_auqpr.Text.Trim() + ",nom = N'" + TB_nom.Text.Trim() + "',spec = " + spec0.ToString() + ",stat = " + stat0.ToString() + ",cust = " + cust0.ToString() + ",representative = N'" + TB_repr.Text.Replace("'", "`").Trim() + "',ad_date = " + dt1 + ",n_mortgage = N'" + TB_n_mort.Text.Replace("'", "`").Trim() + "',dt_mortgage = " + dt2 + ",credit_treaty = N'" + TB_credit_tr.Text.Replace("'", "`").Trim() + "',credit_id";
                    Sql.CommandText = Sql.CommandText + " = " + cre + ",debt_gel = N'" + TB_debt_gel.Text + "',property_addr = N'" + TB_prop_addr.Text.Replace("'", "`").Trim() + "',property_code = N'" + TB_prop_code.Text.Replace("'", "`").Trim() + "',property = N'" + TB_property.Text.Replace("'", "`").Trim() + "',comment = N'" + TB_com.Text.Replace("'", "`").Trim() + "',rights = N'" + TB_rights.Text.Replace("'", "`").Trim() + "'";
                    Sql.CommandText = Sql.CommandText + ",owner = N'" + TB_owner.Text.Replace("'", "`").Trim() + "',owner_num = N'" + TB_ow_num.Text.Replace("'", "`").Trim() + "',owner_tel = N'" + TB_ow_tel.Text.Replace("'", "`").Trim() + "',owner_addr1 = N'" + TB_ow_addr1.Text.Replace("'", "`").Trim() + "',owner_addr2 = N'" + TB_ow_addr2.Text.Replace("'", "`").Trim() + "',owner_addr3 = N'" + TB_ow_addr3.Text.Replace("'", "`").Trim() + "',owner_addr4 = N'" + TB_ow_addr4.Text.Replace("'", "`").Trim() + "',";
                    Sql.CommandText = Sql.CommandText + " debtor = N'" + TB_debtor.Text.Replace("'", "`").Trim() + "',debtor_num = N'" + TB_deb_num.Text.Replace("'", "`").Trim() + "',debtor_addr = N'" + TB_deb_addr.Text.Replace("'", "`").Trim() + "',debtor1 = N'" + TB_debtor1.Text.Replace("'", "`").Trim() + "',debtor1_num = N'" + TB_deb1_num.Text.Replace("'", "`").Trim() + "',debtor1_addr = N'" + TB_deb1_addr.Text.Replace("'", "`").Trim() + "',";
                    Sql.CommandText = Sql.CommandText + " foto = " + fot + ",prepaid = 0" + CB_prepaid.Text + ",prepaid_dt = " + dt3 + ",sales_usd = 0" + TB_sales_usd.Text + ",liquid_price = 0" + TB_liq_usd.Text + ",sales_eur = 0" + TB_sales_eur.Text + ",price_usd = 0" + TB_price_usd.Text + ",price_gel = 0" + TB_price_gel.Text + ",post_reg = N'" + CB_post_reg.Text.Replace("'", "`").Trim() + "',tnt_reg = N'" + CB_tnt_reg.Text.Replace("'", "`").Trim() + "',post1_reg = N'" + CB_post1_reg.Text.Replace("'", "`").Trim() + "',tnt1_reg = N'" + CB_tnt1_reg.Text.Replace("'", "`").Trim() + "',";
                    Sql.CommandText = Sql.CommandText + " post2_reg = N'" + CB_post2_reg.Text.Replace("'", "`").Trim() + "',tnt2_reg = N'" + CB_tnt2_reg.Text.Replace("'", "`").Trim() + "',lot_num = N'" + TB_lot_num.Text.Replace("'", "`").Trim() + "',price1_usd = 0" + TB_price1_usd.Text + ",price1_gel = 0" + TB_price1_gel.Text + ",price2_usd = 0" + TB_price2_usd.Text + ",price2_gel = 0" + TB_price2_gel.Text + ",lot1_num = N'" + TB_lot1_num.Text.Replace("'", "`").Trim() + "',lot2_num = N'" + TB_lot2_num.Text.Replace("'", "`").Trim() + "',";
                    Sql.CommandText = Sql.CommandText + " post_send_0 = " + dt01 + ", tnt_send_0 = " + dt02 + ", courier_0 = " + dt03 + ", tel_0 = " + dt04 + ", rez_0 = " + dt05 + ", macne_0 = " + dt06 + ", auc_start_0 = " + dt07 + ", auc_end_0 = " + dt08 + ", end_date = " + dt4 + ", auc2_dt = " + dt25 + ", auc3_dt = " + dt26 + ", gaz_dt = " + dt27 + ", mac_dt = " + dt28 + ", auc2 = 0" + TB_auc2.Text.Replace("'", "`").Trim() + ", auc3 = 0" + TB_auc3.Text.Replace("'", "`").Trim() + ", gaz = 0" + TB_gaz.Text.Replace("'", "`").Trim() + ", mac = 0" + TB_mac.Text.Replace("'", "`").Trim() + ",";
                    Sql.CommandText = Sql.CommandText + " post_send_1 = " + dt09 + ", tnt_send_1 = " + dt10 + ", courier_1 = " + dt11 + ", tel_1 = " + dt12 + ", rez_1 = " + dt13 + ", macne_1 = " + dt14 + ", auc_start_1 = " + dt15 + ", auc_end_1 = " + dt16 + ", freeze = " + frz + ",";
                    Sql.CommandText = Sql.CommandText + " post_send_2 = " + dt17 + ", tnt_send_2 = " + dt18 + ", courier_2 = " + dt19 + ", tel_2 = " + dt20 + ", rez_2 = " + dt21 + ", macne_2 = " + dt22 + ", auc_start_2 = " + dt23 + ", auc_end_2 = " + dt24 + ", freeze_1 = " + frz1 + ",";
                    Sql.CommandText = Sql.CommandText + " buyer = N'" + TB_buyer.Text.Replace("'", "`").Trim() + "',sum_gel = 0" + TB_sum_gel.Text + ",dgg = " + dg + ",chsg = " + chs + ",fee = " + fee + ",gazrez = 0" + TB_gazrez.Text + ",harmacne = 0" + TB_harmacne.Text + ",auqt = N'" + TB_auqt.Text.Replace("'", "`").Trim() + "' where inf_i = " + infi;

                    Sql.CommandText = Sql.CommandText + " insert into logs (user_n,nom_n,ind_n,dt_n,do_n,note) values('" + usname + "',N'" + TB_nom.Text.Trim() + "'," + infi + ",getdate(),2,N'" + note + "')";

                    try
                    {
                        Sql.ExecuteNonQuery();

                        izm = 0;
                        note = "";

                        Pa_inf.Visible = false;

                        pr_ref(sender, e);

                        if (rezhim == 2)
                        {
                            try
                            {
                                DGV_info.CurrentCell = DGV_info.Rows[rowcur].Cells["nom"];

                                if (DGV_info.Rows[rowcur].Cells["inf_i"].Value.ToString() == infi)
                                {
                                    pr_infedit(sender, e);
                                }
                                else
                                {
                                    DGV_info.Enabled = true;
                                    B_infadd.Enabled = true;
                                    B_infcha.Enabled = true;
                                    B_infdel.Enabled = true;
                                }
                            }
                            catch
                            {
                                DGV_info.Enabled = true;
                                B_infadd.Enabled = true;
                                B_infcha.Enabled = true;
                                B_infdel.Enabled = true;
                            }
                        }
                        else
                        {
                            DGV_info.Enabled = true;
                            B_infadd.Enabled = true;
                            B_infcha.Enabled = true;
                            B_infdel.Enabled = true;
                        }
                    }
                    catch
                    {
                        /*FileStream otptt = File.Open("c:\\ppp.txt", FileMode.OpenOrCreate);
                        StreamWriter gamot = new StreamWriter(otptt);
                        gamot.WriteLine(Sql.CommandText);
                        gamot.Close();*/

                        MessageBox.Show("ოპერაცია ვერ შესრულდა, შეამოწმეთ ყველა ველი");
                    }
                }
                else
                {
                    MessageBox.Show("ნომერი მეორდება, ინფორმაციის დამატება შეუძლებელია");
                }

            }

            else
            {
                MessageBox.Show("ნომერის ველი ცარიელია");
            }
        }

        private void pr_spec(object sender, EventArgs e)
        {
            spec0 = BS_spec.Position;
            spec0 = dS_spec.specialists[spec0].spe_i;

            if (spec0 == 1)
            {
                B_delspec.Enabled = false;
            }
            else
            {
                B_delspec.Enabled = true;
            }
        }

        private void pr_stat(object sender, EventArgs e)
        {
            stat0 = BS_stat.Position;
            stat0 = dS_stat.status[stat0].sta_i;

            if (stat0 == 1)
            {
                B_delstat.Enabled = false;
            }
            else
            {
                /*B_delstat.Enabled = true;*/
            }
        }

        private void pr_cust(object sender, EventArgs e)
        {
            double cc;
            DateTime d0;
            string dt1;
            double kk;
            double prc = 0;
            double aqp;

            cust0 = BS_cust.Position;
            cust0 = dS_cust.customers[cust0].cust_i;

            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            auqt0 = TB_auqt.Text;

            if ((TB_auqt.Text == "LIVO") || (TB_auqt.Text == "Auction.livo.ge"))
            {

                aqp = Convert.ToDouble(TB_auqpr.Text);

                if (aqp == 1)
                {
                    TB_auqpr.Text = "0.9";
                }
            }

            //If customer is ემბისი“ 404967078, then spec% must be 4.38
            if (cust0 == 13)
            {
                TB_specpr.Text = "4.38";
            }
            if ((av == 0) && ((cust0 == 2) || (cust0 == 4)))
            {
                TB_specpr.Text = "3.20";

                if (auqt0 == "RS.ge")
                {
                    TB_auqpr.Text = "1.00";
                }
            }

            if ((av == 1) && ((cust0 == 2) || (cust0 == 4)))
            {
                TB_specpr.Text = "0.00";

                if (auqt0 == "RS.ge")
                {
                    TB_auqpr.Text = "1.18";
                }
            }

            if ((av == 0) && ((cust0 == 2) || (cust0 == 4)))
            {

                if (auqt0 == "LIVO")
                {
                    TB_auqpr.Text = "0.90";
                }
            }

            if ((cust0 == 2) || (cust0 == 4))
            {

                if (auqt0 == "სტაციონარი აუქციონი")
                {
                    TB_auqpr.Text = "0.00";
                }
            }

            if (cust0 == 5)
            {

                if (auqt0 == "RS.ge")
                {
                    TB_specpr.Text = "3.98";
                    TB_auqpr.Text = "1.18";
                }
            }

            if (cust0 == 5)
            {

                if (auqt0 == "LIVO")
                {
                    TB_specpr.Text = "3.70";
                    TB_auqpr.Text = "0.90";
                }
            }

            if (cust0 == 5)
            {

                if (auqt0 == "სტაციონარი აუქციონი")
                {
                    TB_specpr.Text = "2.80";
                    TB_auqpr.Text = "0.00";
                }
            }

            if (cust0 == 8)
            {

                if (auqt0 == "RS.ge")
                {
                    TB_specpr.Text = "4.38";
                    TB_auqpr.Text = "1.18";
                }
            }

            if (cust0 == 8)
            {

                if (auqt0 == "LIVO")
                {
                    TB_specpr.Text = "4.10";
                    TB_auqpr.Text = "0.90";
                }
            }

            if (cust0 == 8)
            {

                if (auqt0 == "სტაციონარი აუქციონი")
                {
                    TB_specpr.Text = "3.20";
                    TB_auqpr.Text = "0.00";
                }
            }

            if (cust0 == 7)
            {

                TB_specpr.Text = "3.00";

                if ((av == 0) && (auqt0 == "RS.ge"))
                {
                    TB_auqpr.Text = "1.00";
                }
            }

            if (cust0 == 7)
            {

                if ((av == 0) && (auqt0 == "LIVO"))
                {
                    TB_auqpr.Text = "0.90";
                }
            }

            if (cust0 == 7)
            {

                if (auqt0 == "სტაციონარი აუქციონი")
                {
                    TB_auqpr.Text = "0.00";
                }
            }

            if (cust0 == 1)
            {
                B_delcust.Enabled = false;
            }
            else
            {
                B_delcust.Enabled = true;
            }

            if ((cust0 == 5) || (cust0 == 8))
            {
                krfi = 1;
            }
            else
            {
                krfi = 0;
            }

            try
            {
                aqp = Convert.ToDouble(TB_auqpr.Text);
            }
            catch
            {
                aqp = 0;
            }

            if (krfi == 1)
            {
                if (aqp == 1)
                {
                    TB_auqpr.Text = "1.18";
                }
            }
            else
            {
                if (av == 1)
                {
                    if (aqp == 1)
                    {
                        TB_auqpr.Text = "1.18";
                    }
                }
                else
                {
                    if (aqp == 1.18)
                    {
                        TB_auqpr.Text = "1.00";
                    }
                }
            }


            if ((av == 0) && ((cust0 == 2) || (cust0 == 4)))
            {
                TB_specpr.Text = "3.20";

                if (auqt0 == "RS.ge")
                {
                    TB_auqpr.Text = "1.00";
                }
            }

            if ((av == 1) && ((cust0 == 2) || (cust0 == 4)))
            {
                TB_specpr.Text = "0.00";

                if (auqt0 == "RS.ge")
                {
                    TB_auqpr.Text = "1.18";
                }
            }

            if ((av == 0) && ((cust0 == 2) || (cust0 == 4)))
            {

                if (auqt0 == "LIVO")
                {
                    TB_auqpr.Text = "0.90";
                }
            }

            if ((cust0 == 2) || (cust0 == 4))
            {

                if (auqt0 == "სტაციონარი აუქციონი")
                {
                    TB_auqpr.Text = "0.00";
                }
            }

            if (cust0 == 8)
            {

                if (auqt0 == "სტაციონარი აუქციონი")
                {
                    TB_specpr.Text = "3.20";
                    TB_auqpr.Text = "0.00";
                }
            }

            if (cust0 == 7)
            {

                TB_specpr.Text = "3.00";

                if ((av == 0) && (auqt0 == "RS.ge"))
                {
                    TB_auqpr.Text = "1.00";
                }
            }

            if (cust0 == 7)
            {

                if ((av == 0) && (auqt0 == "LIVO"))
                {
                    TB_auqpr.Text = "0.90";
                }
            }

            if (cust0 == 7)
            {

                if (auqt0 == "სტაციონარი აუქციონი")
                {
                    TB_auqpr.Text = "0.00";
                }
            }

            try
            {
                cc = Convert.ToDouble(TB_liq_usd.Text);
            }
            catch
            {
                cc = 0;
            }

            if ((CB_foto.Checked) || (cust0 == 11))
            {
                try
                {
                    d0 = TB_ad_date.Value.Date;
                }
                catch
                {
                    d0 = DateTime.Today;
                }

                dt1 = d0.ToString("dd/MM/yyyy");
                dt1 = "'" + dt1.Substring(6, 4) + dt1.Substring(3, 2) + dt1.Substring(0, 2) + "'";

                Sql.CommandText = "select k = turnover.dbo.kurs_for_usd(" + dt1 + ")";

                kk = Convert.ToDouble(Sql.ExecuteScalar().ToString());

                cc = cc * kk;

                if (cc <= 50000)
                {
                    prc = 3.2;
                }

                if ((cc > 50000) && (cc <= 200000))
                {
                    prc = 3.1;
                }

                if (cc > 200000)
                {
                    prc = 3.0;
                }

                TB_specpr.Text = prc.ToString();
            }
        }

        private void pr_sem0(object sender, EventArgs e)
        {
            if (TB_credit_id.Text.Trim() != "")
            {
                try
                {
                    Int32 cc = Convert.ToInt32(TB_credit_id.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_credit_id.Focus();
                }
            }

        }

        private void pr_infdel(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            int colugi = DGV_info.CurrentCell.ColumnIndex;
            int rowwgi = DGV_info.CurrentCell.RowIndex;

            infi = DGV_info.Rows[rowwgi].Cells["inf_i"].Value.ToString();

            string num = TB_nom.Text.Trim();

            if (
            (MessageBox.Show("        წაშლა", "კლიენტის წაშლა", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)).ToString() == "Yes")
            {
                Sql.CommandText = "delete from info where inf_i = " + infi;
                Sql.CommandText = Sql.CommandText + " insert into logs (user_n,nom_n,ind_n,dt_n,do_n) values('" + usname + "',N'" + num + "'," + infi + ",getdate(),3)";

                try
                {
                    Sql.ExecuteNonQuery();

                    pr_ref(sender, e);
                }
                catch
                {
                    MessageBox.Show("ოპერაცია ვერ შესრულდა, თავიდან სცადეთ");
                }
            }

        }

        private void pr_exp(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApplication = new Microsoft.Office.Interop.Excel.Application();
            ExcelApplication.SheetsInNewWorkbook = 1;
            ExcelApplication.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook ExcelWorkbook = ExcelApplication.Workbooks.Add("");

            Microsoft.Office.Interop.Excel.Worksheet ExcelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkbook.Sheets.get_Item(1);
            ExcelWorksheet.Name = "კლიენტები";

            Microsoft.Office.Interop.Excel.Range ExcelRange = ExcelWorksheet.get_Range(ExcelWorksheet.Cells[1, 1], ExcelWorksheet.Cells[DGV_info.RowCount + 2, DGV_info.ColumnCount]);
            object[,] datagridview = new object[DGV_info.RowCount + 2, DGV_info.ColumnCount];

            int ii = -1;

            for (int i0 = 0; i0 <= DGV_info.ColumnCount - 1; i0++)
            {
                if (DGV_info.Columns[i0].Visible)
                {
                    ii = ii + 1;
                    datagridview[0, ii] = DGV_info.Columns[i0].HeaderText;
                }
            }

            ExcelRange.set_Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault, datagridview);

            ExcelRange.Font.Name = "Sylfaen";

            for (int i = 1; i <= DGV_info.RowCount; i++)
            {
                ii = -1;

                for (int i0 = 0; i0 <= DGV_info.ColumnCount - 1; i0++)
                {
                    if (DGV_info.Columns[i0].Visible)
                    {
                        ii = ii + 1;
                        datagridview[i, ii] = DGV_info.Rows[i - 1].Cells[i0].Value;
                    }
                }

            }

            ExcelWorksheet.get_Range(ExcelWorksheet.Cells[1, 1], ExcelWorksheet.Cells[DGV_info.RowCount + 2, DGV_info.ColumnCount]).set_Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault, datagridview);

            ExcelRange.EntireColumn.AutoFit();

        }

        private void pr_sem1(object sender, EventArgs e)
        {
            if (CB_prepaid.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(CB_prepaid.Text);

                    if (cc == 490)
                    {
                        TB_specpr.Text = "0.00";
                        av = 1;
                    }
                    if (cc == 590)
                    {
                        TB_specpr.Text = "3.20";
                        av = 0;
                    }

                    double aqp = Convert.ToDouble(TB_auqpr.Text);

                    if (av == 1)
                    {
                        if (aqp == 1)
                        {
                            TB_auqpr.Text = "1.18";
                        }
                    }
                    else
                    {
                        if (krfi == 1)
                        {
                            if (aqp == 1)
                            {
                                TB_auqpr.Text = "1.18";
                            }
                        }
                        else
                        {
                            if (aqp == 1.18)
                            {
                                TB_auqpr.Text = "1.00";
                            }
                        }
                    }



                    if ((av == 0) && ((cust0 == 2) || (cust0 == 4)))
                    {
                        TB_specpr.Text = "3.20";

                        if (auqt0 == "RS.ge")
                        {
                            TB_auqpr.Text = "1.00";
                        }
                    }

                    if ((av == 1) && ((cust0 == 2) || (cust0 == 4)))
                    {
                        TB_specpr.Text = "0.00";

                        if (auqt0 == "RS.ge")
                        {
                            TB_auqpr.Text = "1.18";
                        }
                    }

                    if ((av == 0) && ((cust0 == 2) || (cust0 == 4)))
                    {

                        if (auqt0 == "LIVO")
                        {
                            TB_auqpr.Text = "0.90";
                        }
                    }

                    if ((cust0 == 2) || (cust0 == 4))
                    {

                        if (auqt0 == "სტაციონარი აუქციონი")
                        {
                            TB_auqpr.Text = "0.00";
                        }
                    }

                    if (cust0 == 5)
                    {

                        if (auqt0 == "RS.ge")
                        {
                            TB_specpr.Text = "3.98";
                            TB_auqpr.Text = "1.18";
                        }
                    }

                    if (cust0 == 5)
                    {

                        if (auqt0 == "LIVO")
                        {
                            TB_specpr.Text = "3.70";
                            TB_auqpr.Text = "0.90";
                        }
                    }

                    if (cust0 == 5)
                    {

                        if (auqt0 == "სტაციონარი აუქციონი")
                        {
                            TB_specpr.Text = "2.80";
                            TB_auqpr.Text = "0.00";
                        }
                    }

                    if (cust0 == 8)
                    {

                        if (auqt0 == "RS.ge")
                        {
                            TB_specpr.Text = "4.38";
                            TB_auqpr.Text = "1.18";
                        }
                    }

                    if (cust0 == 8)
                    {

                        if (auqt0 == "LIVO")
                        {
                            TB_specpr.Text = "4.10";
                            TB_auqpr.Text = "0.90";
                        }
                    }

                    if (cust0 == 8)
                    {

                        if (auqt0 == "სტაციონარი აუქციონი")
                        {
                            TB_specpr.Text = "3.20";
                            TB_auqpr.Text = "0.00";
                        }
                    }

                    if (cust0 == 7)
                    {

                        TB_specpr.Text = "3.00";

                        if ((av == 0) && (auqt0 == "RS.ge"))
                        {
                            TB_auqpr.Text = "1.00";
                        }
                    }

                    if (cust0 == 7)
                    {

                        if ((av == 0) && (auqt0 == "LIVO"))
                        {
                            TB_auqpr.Text = "0.90";
                        }
                    }

                    if (cust0 == 7)
                    {

                        if (auqt0 == "სტაციონარი აუქციონი")
                        {
                            TB_auqpr.Text = "0.00";
                        }
                    }

                    cc = Convert.ToDecimal(CB_prepaid.Text);

                    if (cc == 490)
                    {
                        TB_specpr.Text = "0.00";
                    }

                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    CB_prepaid.Focus();
                }
            }

        }

        private void pr_cl_prep(object sender, EventArgs e)
        {
            Pa_prep.Visible = false;
        }

        private void pr_saveprep(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            if (TB_newprep.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_newprep.Text);

                    Sql.CommandText = "insert into prep_tbl (prep_val) values (" + TB_newprep.Text + ")";
                    Sql.ExecuteNonQuery();

                    Pa_prep.Visible = false;

                    dS_prep.Clear();

                    this.TA_prep.Fill(this.dS_prep.prep_tbl);

                    CB_prepaid.Refresh();

                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_newprep.Focus();
                }
            }

        }

        private void pr_addprep(object sender, EventArgs e)
        {
            TB_newprep.Text = "";
            Pa_prep.BringToFront();
            Pa_prep.Visible = true;
            TB_newprep.Focus();

        }

        private void pr_sem2(object sender, EventArgs e)
        {
            if (TB_sum_gel.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_sum_gel.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_sum_gel.Focus();
                }
            }

        }

        private void pr_sem10(object sender, EventArgs e)
        {
            if (TB_eacution.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_eacution.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_eacution.Focus();
                }
            }

        }

        private void pr_sem12(object sender, EventArgs e)
        {
            if (TB_gazrez.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_gazrez.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_gazrez.Focus();
                }
            }

        }

        private void pr_sem13(object sender, EventArgs e)
        {
            if (TB_harmacne.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_harmacne.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_harmacne.Focus();
                }
            }

        }

        private void pr_01(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_post_send.Value = DateTime.Today.AddDays(1);
                TB_post_send.CustomFormat = " ";
            }

        }

        private void pr_02(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_tnt_send.Value = DateTime.Today.AddDays(1);
                TB_tnt_send.CustomFormat = " ";
            }

        }

        private void pr_03(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_courier.Value = DateTime.Today.AddDays(1);
                TB_courier.CustomFormat = " ";
            }

        }

        private void pr_04(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_tel.Value = DateTime.Today.AddDays(1);
                TB_tel.CustomFormat = " ";
            }

        }

        private void pr_05(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_rez.Value = DateTime.Today.AddDays(1);
                TB_rez.CustomFormat = " ";
            }

        }

        private void pr_06(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_macne.Value = DateTime.Today.AddDays(1);
                TB_macne.CustomFormat = " ";
            }

        }

        private void pr_07(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_auc_start.Value = DateTime.Today.AddDays(1);
                TB_auc_start.CustomFormat = " ";
            }

        }

        private void pr_08(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_auc_end.Value = DateTime.Today.AddDays(1);
                TB_auc_end.CustomFormat = " ";
            }

        }

        private void pr_09(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_post1_send.Value = DateTime.Today.AddDays(1);
                TB_post1_send.CustomFormat = " ";
            }

        }

        private void pr_10(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_tnt1_send.Value = DateTime.Today.AddDays(1);
                TB_tnt1_send.CustomFormat = " ";
            }

        }

        private void pr_11(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_courier1.Value = DateTime.Today.AddDays(1);
                TB_courier1.CustomFormat = " ";
            }

        }

        private void pr_12(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_tel1.Value = DateTime.Today.AddDays(1);
                TB_tel1.CustomFormat = " ";
            }

        }

        private void pr_13(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_rez1.Value = DateTime.Today.AddDays(1);
                TB_rez1.CustomFormat = " ";
            }

        }

        private void pr_14(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_macne1.Value = DateTime.Today.AddDays(1);
                TB_macne1.CustomFormat = " ";
            }

        }

        private void pr_15(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_auc1_start.Value = DateTime.Today.AddDays(1);
                TB_auc1_start.CustomFormat = " ";
            }

        }

        private void pr_16(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_auc1_end.Value = DateTime.Today.AddDays(1);
                TB_auc1_end.CustomFormat = " ";
            }

        }

        private void pr_17(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_post2_send.Value = DateTime.Today.AddDays(1);
                TB_post2_send.CustomFormat = " ";
            }

        }

        private void pr_18(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_tnt2_send.Value = DateTime.Today.AddDays(1);
                TB_tnt2_send.CustomFormat = " ";
            }

        }

        private void pr_19(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_courier2.Value = DateTime.Today.AddDays(1);
                TB_courier2.CustomFormat = " ";
            }

        }

        private void pr_20(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_tel2.Value = DateTime.Today.AddDays(1);
                TB_tel2.CustomFormat = " ";
            }

        }

        private void pr_21(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_rez2.Value = DateTime.Today.AddDays(1);
                TB_rez2.CustomFormat = " ";
            }

        }

        private void pr_22(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_macne2.Value = DateTime.Today.AddDays(1);
                TB_macne2.CustomFormat = " ";
            }

        }

        private void pr_23(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_auc2_start.Value = DateTime.Today.AddDays(1);
                TB_auc2_start.CustomFormat = " ";
            }

        }

        private void pr_24(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TB_auc2_end.Value = DateTime.Today.AddDays(1);
                TB_auc2_end.CustomFormat = " ";
            }

        }

        private void pr_ch_dt01(object sender, EventArgs e)
        {
            izm = 1;
            TB_post_send.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("ფოსტა (1); ") == false)
            {
                note = note + "ფოსტა (1); ";
            }
        }

        private void pr_ch_dt02(object sender, EventArgs e)
        {
            izm = 1;
            TB_tnt_send.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("TNT (1); ") == false)
            {
                note = note + "TNT (1); ";
            }
        }

        private void pr_ch_dt03(object sender, EventArgs e)
        {
            izm = 1;
            TB_courier.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("კურიერი (1); ") == false)
            {
                note = note + "კურიერი (1); ";
            }
        }

        private void pr_ch_dt04(object sender, EventArgs e)
        {
            izm = 1;
            TB_tel.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("ტელეფონი (1); ") == false)
            {
                note = note + "ტელეფონი (1); ";
            }
        }

        private void pr_ch_dt05(object sender, EventArgs e)
        {
            izm = 1;
            TB_rez.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("რეზონანსი (1); ") == false)
            {
                note = note + "რეზონანსი (1); ";
            }
        }

        private void pr_ch_dt06(object sender, EventArgs e)
        {
            izm = 1;
            TB_macne.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("საკან. მაცნე (1); ") == false)
            {
                note = note + "საკან. მაცნე (1); ";
            }
        }

        private void pr_ch_dt07(object sender, EventArgs e)
        {
            izm = 1;
            TB_auc_start.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("აუქციონი Start (1); ") == false)
            {
                note = note + "აუქციონი Start (1); ";
            }
        }

        private void pr_ch_dt08(object sender, EventArgs e)
        {
            izm = 1;
            TB_auc_end.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("აუქციონი End (1); ") == false)
            {
                note = note + "აუქციონი End (1); ";
            }
        }

        private void pr_ch_dt09(object sender, EventArgs e)
        {
            izm = 1;
            TB_post1_send.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("ფოსტა (2); ") == false)
            {
                note = note + "ფოსტა (2); ";
            }
        }

        private void pr_ch_dt10(object sender, EventArgs e)
        {
            izm = 1;
            TB_tnt1_send.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("TNT (2); ") == false)
            {
                note = note + "TNT (2); ";
            }
        }

        private void pr_ch_dt11(object sender, EventArgs e)
        {
            izm = 1;
            TB_courier1.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("კურიერი (2); ") == false)
            {
                note = note + "კურიერი (2); ";
            }
        }

        private void pr_ch_dt12(object sender, EventArgs e)
        {
            izm = 1;
            TB_tel1.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("ტელეფონი (2); ") == false)
            {
                note = note + "ტელეფონი (2); ";
            }
        }

        private void pr_ch_dt13(object sender, EventArgs e)
        {
            izm = 1;
            TB_rez1.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("რეზონანსი (2); ") == false)
            {
                note = note + "რეზონანსი (2); ";
            }
        }

        private void pr_ch_dt14(object sender, EventArgs e)
        {
            izm = 1;
            TB_macne1.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("საკან. მაცნე (2); ") == false)
            {
                note = note + "საკან. მაცნე (2); ";
            }
        }

        private void pr_ch_dt15(object sender, EventArgs e)
        {
            izm = 1;
            TB_auc1_start.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("აუქციონი Start (2); ") == false)
            {
                note = note + "აუქციონი Start (2); ";
            }
        }

        private void pr_ch_dt16(object sender, EventArgs e)
        {
            izm = 1;
            TB_auc1_end.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("აუქციონი End (2); ") == false)
            {
                note = note + "აუქციონი End (2); ";
            }
        }

        private void pr_ch_dt17(object sender, EventArgs e)
        {
            izm = 1;
            TB_post2_send.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("ფოსტა (3); ") == false)
            {
                note = note + "ფოსტა (3); ";
            }
        }

        private void pr_ch_dt18(object sender, EventArgs e)
        {
            izm = 1;
            TB_tnt2_send.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("TNT (3); ") == false)
            {
                note = note + "TNT (3); ";
            }
        }

        private void pr_ch_dt19(object sender, EventArgs e)
        {
            izm = 1;
            TB_courier2.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("კურიერი (3); ") == false)
            {
                note = note + "კურიერი (3); ";
            }
        }

        private void pr_ch_dt20(object sender, EventArgs e)
        {
            izm = 1;
            TB_tel2.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("ტელეფონი (3); ") == false)
            {
                note = note + "ტელეფონი (3); ";
            }
        }

        private void pr_ch_dt21(object sender, EventArgs e)
        {
            izm = 1;
            TB_rez2.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("რეზონანსი (3); ") == false)
            {
                note = note + "რეზონანსი (3); ";
            }
        }

        private void pr_ch_dt22(object sender, EventArgs e)
        {
            izm = 1;
            TB_macne2.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("საკან. მაცნე (3); ") == false)
            {
                note = note + "საკან. მაცნე (3); ";
            }
        }

        private void pr_ch_dt23(object sender, EventArgs e)
        {
            izm = 1;
            TB_auc2_start.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("აუქციონი Start (3); ") == false)
            {
                note = note + "აუქციონი Start (3); ";
            }
        }

        private void pr_ch_dt24(object sender, EventArgs e)
        {
            izm = 1;
            TB_auc2_end.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("აუქციონი End (3); ") == false)
            {
                note = note + "აუქციონი End (3); ";
            }
        }

        private void pr_cl_newresp(object sender, EventArgs e)
        {
            Pa_newrepr.Visible = false;
        }

        private void pr_addrepr(object sender, EventArgs e)
        {
            TB_newrepr.Text = "";
            Pa_newrepr.BringToFront();
            Pa_newrepr.Visible = true;
            TB_newrepr.Focus();

        }

        private void pr_saverepr(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            string rprp = TB_repr.Text;

            if (TB_newrepr.Text.Trim() != "")
            {
                Sql.CommandText = "insert into represent (reps) values(N'" + TB_newrepr.Text.Replace("'", "`").Trim() + "')";
                Sql.ExecuteNonQuery();
            }

            Pa_newrepr.Visible = false;

            dS_repr.Clear();

            this.TA_repr.Fill(this.dS_repr.represent);

            TB_repr.Refresh();

            TB_repr.Text = rprp;
        }

        private void pr_repr(object sender, EventArgs e)
        {
            int rp = BS_repr.Position;

            repr0 = dS_repr.represent[rp].reps;

            if (repr0.Trim() == "")
            {
                B_delrep.Enabled = false;
            }
            else
            {
                B_delrep.Enabled = true;
            }

        }

        private void pr_form1(object sender, EventArgs e)
        {
            moqme = 1;
            pr_form(sender, e);
        }

        private void pr_form2(object sender, EventArgs e)
        {
            moqme = 2;
            pr_form(sender, e);
        }

        private void pr_form3(object sender, EventArgs e)
        {
            moqme = 3;
            pr_form(sender, e);
        }

        private void pr_form4(object sender, EventArgs e)
        {
            moqme = 4;
            pr_form(sender, e);
        }

        private void pr_form5(object sender, EventArgs e)
        {
            moqme = 5;
            pr_form(sender, e);
        }

        private void pr_form6(object sender, EventArgs e)
        {
            moqme = 6;
            pr_form(sender, e);
        }

        private void pr_form7(object sender, EventArgs e)
        {
            moqme = 7;
            pr_form(sender, e);
        }

        private void pr_form8(object sender, EventArgs e)
        {
            moqme = 8;
            pr_form(sender, e);
        }

        private void pr_form9(object sender, EventArgs e)
        {
            moqme = 9;
            pr_form(sender, e);
        }

        private void pr_forms(object sender, MouseEventArgs e)
        {
            CMS1.Show(e.X + 200, e.Y + 60);
        }

        private void pr_delspec(object sender, EventArgs e)
        {
            if (
            (MessageBox.Show("        წაშლა ?", "წაშლა", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)).ToString() == "Yes")
            {

                SqlCommand Sql = new SqlCommand("", sss);
                Sql.CommandType = CommandType.Text;

                Sql.CommandText = "delete from specialists where spe_i = " + spec0.ToString();
                try
                {
                    Sql.ExecuteNonQuery();

                    dS_spec.Clear();

                    this.TA_spec.Fill(this.dS_spec.specialists);

                    TB_spec.Refresh();

                }
                catch
                {
                    MessageBox.Show("სპეციალისტი დაკავებულია , წაშლა შეუძლებელია");
                }


            }

        }

        private void pr_delstat(object sender, EventArgs e)
        {
            if (
            (MessageBox.Show("        წაშლა ?", "წაშლა", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)).ToString() == "Yes")
            {

                SqlCommand Sql = new SqlCommand("", sss);
                Sql.CommandType = CommandType.Text;

                Sql.CommandText = "delete from status where sta_i = " + stat0.ToString();

                try
                {
                    Sql.ExecuteNonQuery();

                    dS_stat.Clear();

                    this.TA_stat.Fill(this.dS_stat.status);

                    TB_stat.Refresh();

                }
                catch
                {
                    MessageBox.Show("სტატუსი დაკავებულია , წაშლა შეუძლებელია");
                }

            }

        }

        private void pr_delcust(object sender, EventArgs e)
        {
            if (
            (MessageBox.Show("        წაშლა ?", "წაშლა", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)).ToString() == "Yes")
            {

                SqlCommand Sql = new SqlCommand("", sss);
                Sql.CommandType = CommandType.Text;

                Sql.CommandText = "delete from customers where cust_i = " + cust0.ToString();

                try
                {
                    Sql.ExecuteNonQuery();

                    dS_cust.Clear();

                    this.TA_cust.Fill(this.dS_cust.customers);

                    TB_cust.Refresh();

                }
                catch
                {
                    MessageBox.Show("დამკვეთი დაკავებულია , წაშლა შეუძლებელია");
                }

            }

        }

        private void pr_delrep(object sender, EventArgs e)
        {
            if (
            (MessageBox.Show("        წაშლა ?", "წაშლა", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)).ToString() == "Yes")
            {

                SqlCommand Sql = new SqlCommand("", sss);
                Sql.CommandType = CommandType.Text;

                Sql.CommandText = "delete from represent where reps = N'" + repr0.ToString() + "'";
                Sql.CommandText = Sql.CommandText + " update info";
                Sql.CommandText = Sql.CommandText + " set representative = '' where representative = N'" + repr0.ToString() + "'";

                try
                {
                    Sql.ExecuteNonQuery();

                    dS_repr.Clear();

                    this.TA_repr.Fill(this.dS_repr.represent);

                    TB_repr.Refresh();

                }
                catch
                {
                    MessageBox.Show("წარმომადგენელი დაკავებულია , წაშლა შეუძლებელია");
                }

            }

        }

        private void pr_ch_end(object sender, EventArgs e)
        {
            izm = 1;
            TP_end.CustomFormat = "dd/MM/yyyy";
            note = note + "END DATE; ";
        }

        private void pr_end(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TP_end.Value = DateTime.Today.AddDays(1);
                TP_end.CustomFormat = " ";
            }
        }

        private void pr_ser(object sender, EventArgs e)
        {
            Pa_ser.BringToFront();
            Pa_ser.Visible = true;
        }

        private void pr_cl_ser(object sender, EventArgs e)
        {
            Pa_ser.Visible = false;
        }

        private void pr_ser_ent(object sender, EventArgs e)
        {
            shag = 0;
            TB_kada.Text = "";
            TB_saq.Text = "";
            TB_sesh.Text = "";
        }

        private void pr_go_ser(object sender, EventArgs e)
        {
            if (TB_kada.Text.Trim() != "")
            {
                for (int ii0 = shag; ii0 <= DGV_info.RowCount - 1; ii0++)
                {
                    if (DGV_info.Rows[ii0].Cells["property_code"].Value.ToString().Trim().Contains(TB_kada.Text.Trim()))
                    {
                        DGV_info.Rows[ii0].Selected = true;
                        DGV_info.CurrentCell = DGV_info.Rows[ii0].Cells["property_code"];
                        shag = ii0 + 1;
                        goto l1;
                    }
                }
            l1: ;
            }
            else
            {
                if (TB_saq.Text.Trim() != "")
                {
                    for (int ii0 = shag; ii0 <= DGV_info.RowCount - 1; ii0++)
                    {
                        if (DGV_info.Rows[ii0].Cells["owner"].Value.ToString().Trim() == TB_saq.Text.Trim())
                        {
                            DGV_info.Rows[ii0].Selected = true;
                            DGV_info.CurrentCell = DGV_info.Rows[ii0].Cells["owner"];
                            shag = ii0 + 1;
                            goto l2;
                        }
                    }
                l2: ;
                }
                else
                {
                    if (TB_sesh.Text.Trim() != "")
                    {
                        for (int ii0 = shag; ii0 <= DGV_info.RowCount - 1; ii0++)
                        {
                            if (DGV_info.Rows[ii0].Cells["debtor"].Value.ToString().Trim() == TB_sesh.Text.Trim())
                            {
                                DGV_info.Rows[ii0].Selected = true;
                                DGV_info.CurrentCell = DGV_info.Rows[ii0].Cells["debtor"];
                                shag = ii0 + 1;
                                goto l3;
                            }
                        }
                    l3: ;
                    }
                }
            }
        }

        private void pr_filt(object sender, EventArgs e)
        {
            CB_filt.Text = "";
            TB_nim.Text = "";
            RB_as.Checked = true;
            LB_filt.Items.Clear();
            Pa_filt.BringToFront();
            Pa_filt.Visible = true;
        }

        private void pr_cl_filt(object sender, EventArgs e)
        {
            Pa_filt.Visible = false;
        }

        private void pr_filt_del(object sender, EventArgs e)
        {
            LB_filt.Items.RemoveAt(nomit);

            for (int i0 = nomit; i0 <= LB_filt.Items.Count; i0++)
            {
                filters[0, nomit] = filters[0, nomit + 1];
                filters[1, nomit] = filters[1, nomit + 1];
                filters[2, nomit] = filters[2, nomit + 1];
                filters[3, nomit] = filters[3, nomit + 1];
            }

            filters[0, LB_filt.Items.Count] = "";
            filters[1, LB_filt.Items.Count] = "";
            filters[2, LB_filt.Items.Count] = "";
            filters[3, LB_filt.Items.Count] = "";
        }

        private void pr_entnim(object sender, KeyEventArgs e)
        {
            int delay;

            if (e.KeyValue == 13)
            {
                delay = 1;

                /*if (filters[1, nomit] == "dt")
                {
                    try
                    {
                        DateTime tar0 = Convert.ToDateTime(TB_nim.Text);
                        string dge0 = tar0.ToString("dd/MM/yyyy");
                        delay = 1;
                    }
                    catch
                    {
                        MessageBox.Show("თარიღის ფორმატი არასწორია");
                        TB_nim.Focus();
                        delay = 0;
                    }
                }

                if ((filters[1, nomit] == "turn_deb") || (filters[1, nomit] == "turn_cre"))
                {
                    try
                    {
                        decimal tar0 = Convert.ToDecimal(TB_nim.Text);
                        delay = 1;
                    }
                    catch
                    {
                        MessageBox.Show("ციფრული მონაცემის ფორმატი არასწორია");
                        TB_nim.Focus();
                        delay = 0;
                    }
                }*/

                if (delay == 1)
                {
                    string filt = filters[0, nomit];

                    filters[3, nomit] = TB_nim.Text;

                    if (RB_as.Checked)
                    {
                        filt = filt + " AS ";
                        filters[2, nomit] = "1";
                        filt = filt + " " + TB_nim.Text + " ";
                    }

                    if (RB_udris.Checked)
                    {
                        filt = filt + " = ";
                        filters[2, nomit] = "2";
                        filt = filt + " " + TB_nim.Text + " ";
                    }

                    if (RB_nacl.Checked)
                    {
                        filt = filt + " < ";
                        filters[2, nomit] = "3";
                        filt = filt + " " + TB_nim.Text + " ";
                    }

                    if (RB_met.Checked)
                    {
                        filt = filt + " > ";
                        filters[2, nomit] = "4";
                        filt = filt + " " + TB_nim.Text + " ";
                    }

                    LB_filt.Items[nomit] = filt;
                }
            }

        }

        private void pr_gau_filt(object sender, EventArgs e)
        {
            for (int i0 = 0; i0 <= 499; i0++)
            {
                filters[0, i0] = "";
                filters[1, i0] = "";
                filters[2, i0] = "";
                filters[3, i0] = "";
            }

            LB_filt.Items.Clear();

            pr_ref(sender, e);

            Pa_filt.Visible = false;

        }

        private void pr_addparam(object sender, EventArgs e)
        {
            int kolit = 0;

            for (int i0 = 0; i0 <= LB_filt.Items.Count - 1; i0++)
            {
                if (LB_filt.Items[i0].ToString() == CB_filt.Text)
                {
                    kolit = kolit + 1;
                }
            }

            if (kolit == 0)
            {
                LB_filt.Items.Add(CB_filt.Text);
                filters[0, LB_filt.Items.Count - 1] = CB_filt.Text;

                for (int i0 = 0; i0 <= DGV_info.ColumnCount - 1; i0++)
                {
                    if (DGV_info.Columns[i0].HeaderText == CB_filt.Text)
                    {
                        filters[1, LB_filt.Items.Count - 1] = DGV_info.Columns[i0].DataPropertyName;
                    }
                }

                nomit = LB_filt.Items.Count - 1;

                filters[2, nomit] = "1";
                filters[3, nomit] = "";

                /*if ((filters[1, nomit] == "dt") || (filters[1, nomit] == "turn_deb") || (filters[1, nomit] == "turn_cre"))
                {
                    RB_as.Enabled = false;
                    RB_as.Checked = false;
                    RB_udris.Enabled = true;
                    RB_udris.Checked = true;
                    RB_nacl.Enabled = true;
                    RB_met.Enabled = true;
                }
                else
                {
                    RB_as.Enabled = true;
                    RB_as.Checked = true;
                    RB_udris.Enabled = true;
                    RB_nacl.Enabled = false;
                    RB_met.Enabled = false;
                }*/

                if (RB_as.Enabled)
                {
                    RB_as.Checked = true;
                }

                TB_nim.Text = "";
            }

        }

        private void pr_go_filt(object sender, EventArgs e)
        {
            filter = "";

            for (int i0 = 0; i0 <= LB_filt.Items.Count - 1; i0++)
            {
                if (i0 == 0)
                {
                    filter = filters[1, i0];
                }
                else
                {
                    filter = filter + " and " + filters[1, i0];
                }

                if (filters[2, i0] == "1")
                {
                    filter = filter + " like '%" + filters[3, i0] + "%'";
                }

                if (filters[2, i0] == "2")
                {
                    filter = filter + " = '" + filters[3, i0] + "'";
                }

                if (filters[2, i0] == "3")
                {
                    filter = filter + " < '" + filters[3, i0] + "'";
                }

                if (filters[2, i0] == "4")
                {
                    filter = filter + " > '" + filters[3, i0] + "'";
                }

            }

            try
            {
                if (filter.Trim() != "")
                {
                    filter = filter_base + " and " + filter;
                }

                BS_info.Filter = filter;

                DGV_info.Refresh();

                Pa_filt.Visible = false;

            }
            catch
            {
                MessageBox.Show("ვერ შესრულდა, შეამოწმეთ ფილტრის სისწორე");
            }

        }

        private void pr_cl_newbuy(object sender, EventArgs e)
        {
            Pa_newbuy.Visible = false;
        }

        private void pr_addbuy(object sender, EventArgs e)
        {
            TB_newbuy.Text = "";
            Pa_newbuy.BringToFront();
            Pa_newbuy.Visible = true;
            TB_newbuy.Focus();
        }

        private void pr_savebuy(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            string buy = TB_buyer.Text;

            if (TB_newbuy.Text.Trim() != "")
            {
                Sql.CommandText = "insert into buyers (buyer_0) values(N'" + TB_newbuy.Text.Replace("'", "`").Trim() + "')";
                Sql.ExecuteNonQuery();
            }

            Pa_newbuy.Visible = false;

            dS_buy.Clear();

            this.TA_buy.Fill(this.dS_buy.buyers);

            TB_buyer.Refresh();

            TB_buyer.Text = buy;
        }

        private void pr_form10(object sender, EventArgs e)
        {
            moqme = 10;
            pr_form(sender, e);
        }

        private void pr_work(object sender, EventArgs e)
        {
            Pa_work.BringToFront();
            Pa_work.Visible = true;
        }

        private void pr_cl_work(object sender, EventArgs e)
        {
            Pa_work.Visible = false;
        }

        private void pr_go_work(object sender, EventArgs e)
        {
            string colugs0;

            int kol = 0;

            int ind = 0;

            /*BS_info.Filter = "";*/

            BS_info.Filter = "((end_date is null) or (end_date is not null and end_date >= " + "'" + DateTime.Today.AddYears(-1).Date.ToString() + "'))";

            dS_info.Clear();

            this.TA_info.Fill(this.dS_info.info);

            DGV_info.Refresh();

            /*if (RB_moq.Checked == false)
            {
                RB_moq.Checked = true;
                pr_ref(sender, e);
            }*/

            Microsoft.Office.Interop.Excel.Application ExcelApplication = new Microsoft.Office.Interop.Excel.Application();
            ExcelApplication.SheetsInNewWorkbook = 1;
            ExcelApplication.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook ExcelWorkbook = ExcelApplication.Workbooks.Add("");

            Microsoft.Office.Interop.Excel.Worksheet ExcelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkbook.Sheets.get_Item(1);
            ExcelWorksheet.Name = "day - " + TP_work.Text.Replace("/", ".");

            Microsoft.Office.Interop.Excel.Range ExcelRange = ExcelWorksheet.get_Range(ExcelWorksheet.Cells[1, 1], ExcelWorksheet.Cells[DGV_info.RowCount + 2, 28]);
            object[,] datagridview = new object[DGV_info.RowCount + 2, 28];
            object[,] mas = new object[DGV_info.RowCount + 2, 28];

            int ii = -1;

            for (int i0 = 0; i0 <= DGV_info.ColumnCount - 1; i0++)
            {
                colugs0 = DGV_info.Columns[i0].Name;

                if ((colugs0 == "nom") || (colugs0 == "ad_date") || (colugs0 == "dt_mortgage") || (colugs0 == "post_send") || (colugs0 == "tnt_send") || (colugs0 == "courier") || (colugs0 == "tel") || (colugs0 == "rez") || (colugs0 == "macne") || (colugs0 == "auc_start") || (colugs0 == "auc_end") || (colugs0 == "post1_send")
                     || (colugs0 == "tnt1_send") || (colugs0 == "courier1") || (colugs0 == "tel1") || (colugs0 == "rez1") || (colugs0 == "macne1") || (colugs0 == "auc1_start") || (colugs0 == "auc1_end") || (colugs0 == "post2_send") || (colugs0 == "tnt2_send") || (colugs0 == "courier2")
                       || (colugs0 == "tel2") || (colugs0 == "rez2") || (colugs0 == "macne2") || (colugs0 == "auc2_start") || (colugs0 == "auc2_end") || (colugs0 == "end_date"))
                {
                    ii = ii + 1;
                    datagridview[0, ii] = DGV_info.Columns[i0].HeaderText;
                }
            }

            ExcelRange.set_Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault, datagridview);

            ExcelRange.Font.Name = "Sylfaen";

            kol = 1;

            for (int i = 1; i <= DGV_info.RowCount; i++)
            {
                ii = -1;

                for (int i0 = 0; i0 <= DGV_info.ColumnCount - 1; i0++)
                {
                    colugs0 = DGV_info.Columns[i0].Name;

                    if ((colugs0 == "nom") || (colugs0 == "ad_date") || (colugs0 == "dt_mortgage") || (colugs0 == "post_send") || (colugs0 == "tnt_send") || (colugs0 == "courier") || (colugs0 == "tel") || (colugs0 == "rez") || (colugs0 == "macne") || (colugs0 == "auc_start") || (colugs0 == "auc_end") || (colugs0 == "post1_send")
                         || (colugs0 == "tnt1_send") || (colugs0 == "courier1") || (colugs0 == "tel1") || (colugs0 == "rez1") || (colugs0 == "macne1") || (colugs0 == "auc1_start") || (colugs0 == "auc1_end") || (colugs0 == "post2_send") || (colugs0 == "tnt2_send") || (colugs0 == "courier2")
                           || (colugs0 == "tel2") || (colugs0 == "rez2") || (colugs0 == "macne2") || (colugs0 == "auc2_start") || (colugs0 == "auc2_end") || (colugs0 == "end_date"))
                    {
                        ii = ii + 1;

                        try
                        {
                            DateTime d1;
                            d1 = Convert.ToDateTime(DGV_info.Rows[i - 1].Cells[i0].Value);
                            d1 = d1.Date;

                            if (d1 == Convert.ToDateTime(TP_work.Text))
                            {
                                datagridview[i, ii] = DGV_info.Rows[i - 1].Cells[i0].Value;
                            }
                            else
                            {
                                datagridview[i, ii] = "";
                            }
                        }
                        catch
                        {
                            if (colugs0 == "nom")
                            {
                                datagridview[i, ii] = DGV_info.Rows[i - 1].Cells[i0].Value;
                            }
                            else
                            {
                                datagridview[i, ii] = "";
                            }
                        }
                    }
                }

            }

            for (int i = 0; i <= 27; i++)
            {
                mas[0, i] = datagridview[0, i];
            }

            kol = 0;

            for (int i = 1; i <= DGV_info.RowCount; i++)
            {
                ind = 0;

                for (int i0 = 1; i0 <= 27; i0++)
                {
                    if ((datagridview[i, i0] != "") && (datagridview[i, i0] != DBNull.Value))
                    {
                        ind = 1;
                    }
                }

                if (ind == 1)
                {
                    kol = kol + 1;

                    for (int i0 = 0; i0 <= 27; i0++)
                    {
                        mas[kol, i0] = datagridview[i, i0];
                    }
                }
            }

            ExcelWorksheet.get_Range(ExcelWorksheet.Cells[1, 1], ExcelWorksheet.Cells[kol + 1, 28]).set_Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault, mas);

            ExcelRange.EntireColumn.AutoFit();

            Pa_work.Visible = false;

            pr_ref(sender, e);
        }

        private void pr_sem14(object sender, EventArgs e)
        {
            if (TB_auc2.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_auc2.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_auc2.Focus();
                }
            }

        }

        private void pr_sem15(object sender, EventArgs e)
        {
            if (TB_auc3.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_auc3.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_auc3.Focus();
                }
            }

        }

        private void pr_sem16(object sender, EventArgs e)
        {
            if (TB_gaz.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_gaz.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_gaz.Focus();
                }
            }

        }

        private void pr_sem17(object sender, EventArgs e)
        {
            if (TB_mac.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_mac.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_mac.Focus();
                }
            }

        }

        private void pr_ch_a2(object sender, EventArgs e)
        {
            izm = 1;
            TP_auc2.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("ჩარიცხვის თარიღი (INCOM 1); ") == false)
            {
                note = note + "ჩარიცხვის თარიღი (INCOM 1); ";
            }
        }

        private void pr_ch_a3(object sender, EventArgs e)
        {
            izm = 1;
            TP_auc3.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("ჩარიცხვის თარიღი (INCOM 2); ") == false)
            {
                note = note + "ჩარიცხვის თარიღი (INCOM 2); ";
            }
        }

        private void pr_ch_g(object sender, EventArgs e)
        {
            izm = 1;
            TP_gaz.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("ჩარიცხვის თარიღი (INCOM 3); ") == false)
            {
                note = note + "ჩარიცხვის თარიღი (INCOM 3); ";
            }
        }

        private void pr_ch_m(object sender, EventArgs e)
        {
            izm = 1;
            TP_mac.CustomFormat = "dd/MM/yyyy";

            if (note.Contains("ჩარიცხვის თარიღი (INCOM 4); ") == false)
            {
                note = note + "ჩარიცხვის თარიღი (INCOM 4); ";
            }
        }

        private void pr_auc2(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TP_auc2.Value = DateTime.Today.AddDays(1);
                TP_auc2.CustomFormat = " ";
            }
        }

        private void pr_auc3(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TP_auc3.Value = DateTime.Today.AddDays(1);
                TP_auc3.CustomFormat = " ";
            }
        }

        private void pr_gaz(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TP_gaz.Value = DateTime.Today.AddDays(1);
                TP_gaz.CustomFormat = " ";
            }
        }

        private void pr_mac(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                TP_mac.Value = DateTime.Today.AddDays(1);
                TP_mac.CustomFormat = " ";
            }
        }

        private void pr_chno01(object sender, EventArgs e)
        {
            if (note.Contains("N; ") == false)
            {
                note = note + "N; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno02(object sender, EventArgs e)
        {
            if (note.Contains("სპეციალისტი; ") == false)
            {
                note = note + "სპეციალისტი; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno03(object sender, EventArgs e)
        {
            if (note.Contains("STATUS; ") == false)
            {
                note = note + "STATUS; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno04(object sender, EventArgs e)
        {
            if (note.Contains("დამკვეთი; ") == false)
            {
                note = note + "დამკვეთი; ";
            }

            pr_cust(sender, e);

            pr_ch(sender, e);
        }

        private void pr_chno05(object sender, EventArgs e)
        {
            if (note.Contains("წარმომადგენელი; ") == false)
            {
                note = note + "წარმომადგენელი; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno06(object sender, EventArgs e)
        {
            if (note.Contains("აუქციონის ტიპი; ") == false)
            {
                note = note + "აუქციონის ტიპი; ";
            }

            pr_cust(sender, e);

            pr_ch(sender, e);
        }

        private void pr_chno07(object sender, EventArgs e)
        {
            if (note.Contains("იპოთეკის N; ") == false)
            {
                note = note + "იპოთეკის N; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno08(object sender, EventArgs e)
        {
            if (note.Contains("სესხის ხელშეკრულება; ") == false)
            {
                note = note + "სესხის ხელშეკრულება; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno09(object sender, EventArgs e)
        {
            if (note.Contains("სესხის ID; ") == false)
            {
                note = note + "სესხის ID; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno10(object sender, EventArgs e)
        {
            if (note.Contains("სესხი დავალიანება; ") == false)
            {
                note = note + "სესხი დავალიანება; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno11(object sender, EventArgs e)
        {
            if (note.Contains("ქონების მისამართი; ") == false)
            {
                note = note + "ქონების მისამართი; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno12(object sender, EventArgs e)
        {
            if (note.Contains("ქონების აღწერა; ") == false)
            {
                note = note + "ქონების აღწერა; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno13(object sender, EventArgs e)
        {
            if (note.Contains("მესაკუთრე; ") == false)
            {
                note = note + "მესაკუთრე; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno14(object sender, EventArgs e)
        {
            if (note.Contains("მესაკუთრე პირადი N; ") == false)
            {
                note = note + "მესაკუთრე პირადი N; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno15(object sender, EventArgs e)
        {
            if (note.Contains("მესაკუთრე TEL; ") == false)
            {
                note = note + "მესაკუთრე TEL; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno16(object sender, EventArgs e)
        {
            if (note.Contains("მესაკუთრე მისამართი 1; ") == false)
            {
                note = note + "მესაკუთრე მისამართი 1; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno17(object sender, EventArgs e)
        {
            if (note.Contains("მესაკუთრე მისამართი 2; ") == false)
            {
                note = note + "მესაკუთრე მისამართი 2; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno18(object sender, EventArgs e)
        {
            if (note.Contains("მესაკუთრე მისამართი 3; ") == false)
            {
                note = note + "მესაკუთრე მისამართი 3; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno19(object sender, EventArgs e)
        {
            if (note.Contains("მესაკუთრე მისამართი 4; ") == false)
            {
                note = note + "მესაკუთრე მისამართი 4; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno20(object sender, EventArgs e)
        {
            if (note.Contains("მსესხებელი; ") == false)
            {
                note = note + "მსესხებელი; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno21(object sender, EventArgs e)
        {
            if (note.Contains("მსესხებელი პირადი N; ") == false)
            {
                note = note + "მსესხებელი პირადი N; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno22(object sender, EventArgs e)
        {
            if (note.Contains("მსესხებელი მისამართი; ") == false)
            {
                note = note + "მსესხებელი მისამართი; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno24(object sender, EventArgs e)
        {
            if (note.Contains("სხვა პირი; ") == false)
            {
                note = note + "სხვა პირი; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno23(object sender, EventArgs e)
        {
            if (note.Contains("სხვა პირი პირადი N; ") == false)
            {
                note = note + "სხვა პირი პირადი N; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno25(object sender, EventArgs e)
        {
            if (note.Contains("სხვა პირი მისამართი; ") == false)
            {
                note = note + "სხვა პირი მისამართი; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno26(object sender, EventArgs e)
        {
            if (note.Contains("დღგ; ") == false)
            {
                note = note + "დღგ; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno27(object sender, EventArgs e)
        {
            if (note.Contains("FOTO; ") == false)
            {
                note = note + "FOTO; ";
            }

            /*if (CB_foto.Checked)
            {
                TB_liq_usd.Enabled = true;
            }
            else
            {
                TB_liq_usd.Enabled = false;
                TB_liq_usd.Text = "0.00";
            }*/

            pr_cust(sender, e);

            pr_ch(sender, e);
        }

        private void pr_chno28(object sender, EventArgs e)
        {
            if (note.Contains("ავანსის თანხა; ") == false)
            {
                note = note + "ავანსის თანხა; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno29(object sender, EventArgs e)
        {
            if (note.Contains("აუქციონის საბაზრო ფასი $; ") == false)
            {
                note = note + "აუქციონის საბაზრო ფასი $; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno30(object sender, EventArgs e)
        {
            if (note.Contains("გაყინულია (1); ") == false)
            {
                note = note + "გაყინულია (1); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno31(object sender, EventArgs e)
        {
            if (note.Contains("პირველი აუქციონის საწყისი ფასი $; ") == false)
            {
                note = note + "პირველი აუქციონის საწყისი ფასი $; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno32(object sender, EventArgs e)
        {
            if (note.Contains("პირველი აუქციონის საწყისი ფასი ₾; ") == false)
            {
                note = note + "პირველი აუქციონის საწყისი ფასი ₾; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno33(object sender, EventArgs e)
        {
            if (note.Contains("ფოსტა (ჩაბარება) (1); ") == false)
            {
                note = note + "ფოსტა (ჩაბარება) (1); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno34(object sender, EventArgs e)
        {
            if (note.Contains("TNT (ჩაბარება) (1); ") == false)
            {
                note = note + "TNT (ჩაბარება) (1); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno35(object sender, EventArgs e)
        {
            if (note.Contains("აუქციონი ლოტის N (1); ") == false)
            {
                note = note + "აუქციონი ლოტის N (1); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno36(object sender, EventArgs e)
        {
            if (note.Contains("გაყინულია (2); ") == false)
            {
                note = note + "გაყინულია (2); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno37(object sender, EventArgs e)
        {
            if (note.Contains("მეორე აუქციონის საწყისი ფასი $; ") == false)
            {
                note = note + "მეორე აუქციონის საწყისი ფასი $; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno38(object sender, EventArgs e)
        {
            if (note.Contains("მეორე აუქციონის საწყისი ფასი ₾; ") == false)
            {
                note = note + "მეორე აუქციონის საწყისი ფასი ₾; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno39(object sender, EventArgs e)
        {
            if (note.Contains("ფოსტა (ჩაბარება) (2); ") == false)
            {
                note = note + "ფოსტა (ჩაბარება) (2); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno40(object sender, EventArgs e)
        {
            if (note.Contains("TNT (ჩაბარება) (2); ") == false)
            {
                note = note + "TNT (ჩაბარება) (2); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno41(object sender, EventArgs e)
        {
            if (note.Contains("აუქციონი ლოტის N (2); ") == false)
            {
                note = note + "აუქციონი ლოტის N (2); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno42(object sender, EventArgs e)
        {
            if (note.Contains("მესამე აუქციონის საწყისი ფასი $; ") == false)
            {
                note = note + "მესამე აუქციონის საწყისი ფასი $; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno43(object sender, EventArgs e)
        {
            if (note.Contains("მესამე აუქციონის საწყისი ფასი ₾; ") == false)
            {
                note = note + "მესამე აუქციონის საწყისი ფასი ₾; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno44(object sender, EventArgs e)
        {
            if (note.Contains("ფოსტა (ჩაბარება) (3); ") == false)
            {
                note = note + "ფოსტა (ჩაბარება) (3); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno45(object sender, EventArgs e)
        {
            if (note.Contains("TNT (ჩაბარება) (3); ") == false)
            {
                note = note + "TNT (ჩაბარება) (3); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno46(object sender, EventArgs e)
        {
            if (note.Contains("აუქციონი ლოტის N (3); ") == false)
            {
                note = note + "აუქციონი ლოტის N (3); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno47(object sender, EventArgs e)
        {
            if (note.Contains("შემძენი; ") == false)
            {
                note = note + "შემძენი; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno48(object sender, EventArgs e)
        {
            if (note.Contains("აუქციონის თანხა GEL; ") == false)
            {
                note = note + "აუქციონის თანხა GEL; ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno49(object sender, EventArgs e)
        {
            if (note.Contains("გაზეთი რეზონანსი (ხარჯები); ") == false)
            {
                note = note + "გაზეთი რეზონანსი (ხარჯები); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno50(object sender, EventArgs e)
        {
            if (note.Contains("საკან. მაცნე (ხარჯები); ") == false)
            {
                note = note + "საკან. მაცნე (ხარჯები); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno51(object sender, EventArgs e)
        {
            if (note.Contains("მე-2 აუქც. ხარჯი (INCOM); ") == false)
            {
                note = note + "მე-2 აუქც. ხარჯი (INCOM); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno52(object sender, EventArgs e)
        {
            if (note.Contains("მე-3 აუქც. ხარჯი (INCOM); ") == false)
            {
                note = note + "მე-3 აუქც. ხარჯი (INCOM); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno53(object sender, EventArgs e)
        {
            if (note.Contains("გაზეთის ხარჯი (INCOM); ") == false)
            {
                note = note + "გაზეთის ხარჯი (INCOM); ";
            }
            pr_ch(sender, e);
        }

        private void pr_chno54(object sender, EventArgs e)
        {
            if (note.Contains("მაცნეს ხარჯი (INCOM); ") == false)
            {
                note = note + "მაცნეს ხარჯი (INCOM); ";
            }
            pr_ch(sender, e);
        }

        private void pr_log(object sender, EventArgs e)
        {
            Pa_log.BringToFront();
            Pa_log.Visible = true;
            DGV_log.Visible = false;
        }

        private void pr_golog(object sender, EventArgs e)
        {
            string dtot = DTP_dan.Value.Date.ToString();
            dtot = dtot.Substring(6, 4) + dtot.Substring(3, 2) + dtot.Substring(0, 2);

            string dtdo = DTP_mde.Value.AddDays(1).Date.ToString();
            dtdo = dtdo.Substring(6, 4) + dtdo.Substring(3, 2) + dtdo.Substring(0, 2);

            dS_log.Clear();

            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            Sql.CommandText = "select user_n, nom_n, ind_n, dt_n, dbo.moqm(log_i) as do_n, log_i, note from logs where dt_n between '" + dtot + "' and '" + dtdo + "' order by user_n,dt_n";

            SqlDataAdapter ddlog = new SqlDataAdapter(Sql);

            ddlog.Fill(this.dS_log.logs);

            DGV_log.Refresh();

            DGV_log.Visible = true;
        }

        private void pr_cl_log(object sender, EventArgs e)
        {
            Pa_log.Visible = false;
        }

        private void pr_kod(object sender, EventArgs e)
        {
            Pa_kod.BringToFront();
            Pa_kod.Visible = true;
        }

        private void pr_cl_kod(object sender, EventArgs e)
        {
            Pa_kod.Visible = false;
        }

        private void pr_bru(object sender, EventArgs e)
        {
            Pa_bru.BringToFront();
            Pa_bru.Visible = true;
        }

        private void pr_cl_bru(object sender, EventArgs e)
        {
            Pa_bru.Visible = false;
        }

        private void pr_himp(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.IsBalloon = true;
            myToolTip.SetToolTip(B_imp, "იმპორტი Excel-დან");
        }

        private void pr_imp(object sender, EventArgs e)
        {
            P_exc.BringToFront();
            P_exc.Visible = true;

            TB_tran.Text = "";
            TB_exc.Text = "";
            B_goexc.Enabled = false;
            LB_resp.Clear();
        }

        private void pr_cl_exp(object sender, EventArgs e)
        {
            P_exc.Visible = false;
        }

        private void pr_cancel(object sender, EventArgs e)
        {
            TB_exc.Text = "";
            TB_tran.Text = "";
            B_goexc.Enabled = false;
            LB_resp.Clear();
        }

        private void pr_dze(object sender, EventArgs e)
        {
            OFD.ShowDialog();
        }

        private void pr_file(object sender, CancelEventArgs e)
        {
            TB_exc.Text = OFD.FileName;
            TB_tran.Text = "";
            B_goexc.Enabled = true;
            LB_resp.Clear();
        }

        private void pr_href1(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.IsBalloon = true;
            myToolTip.SetToolTip(B_ref1, "Refresh");
        }

        private void pr_ref1(object sender, EventArgs e)
        {
            BS_bru.Filter = filter_bru;

            dS_bru.Clear();

            this.TA_bru.Fill(this.dS_bru.receipts);

            DGV_bru.Refresh();

            DGV_bru.Select();
        }

        string[] ConvertToStringArray(System.Array values)
        {
            string[] theArray = new string[values.Length];
            for (int i = 1; i <= values.Length; i++)
            {
                if (values.GetValue(1, i) == null)
                    theArray[i - 1] = "";
                else
                    theArray[i - 1] = (string)values.GetValue(1, i).ToString();
            }
            return theArray;
        }

        private void pr_goexc(object sender, EventArgs e)
        {
            LB_resp.AppendText("" + (char)13);
            LB_resp.AppendText("პროცესის დაწყება" + (char)13);

            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            Sql.CommandTimeout = 3000;

            Microsoft.Office.Interop.Excel.ApplicationClass ExcelObj = new Microsoft.Office.Interop.Excel.ApplicationClass();

            Microsoft.Office.Interop.Excel.Workbook wb = ExcelObj.Workbooks.Open(TB_exc.Text, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows,
                "\t", true, true, 0, false, false, false);
            Microsoft.Office.Interop.Excel.Sheets sheets = wb.Worksheets;

            LB_resp.AppendText("ფაილის ატვირთვა" + (char)13);

            LB_resp.AppendText("მიმდინარეობს ტრანზაქციების შესრულება" + (char)13);

            LB_resp.Focus();
            LB_resp.SelectAll();
            LB_resp.DeselectAll();

            int count = 0;
            int count_rec = 0;
            string sdt;
            string sdt0;
            decimal deb;
            decimal cre;
            DateTime dtw;
            int cod = 0;
            int tan = 0;

            try
            {
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)sheets.get_Item(1);

                for (int i = 1; i <= 50000; i++)
                {
                    Microsoft.Office.Interop.Excel.Range range = worksheet.get_Range("A" + i.ToString(), "AB" + i.ToString());
                    System.Array myvalues = (System.Array)range.Cells.Value;
                    string[] strArray = ConvertToStringArray(myvalues);

                    if ((strArray[0] != null) && (strArray[0].Trim() != ""))
                    {
                        count = count + 1;

                        try
                        {
                            if (strArray[0].Trim() != "")
                            {
                                dtw = Convert.ToDateTime(strArray[0]);
                                sdt = dtw.ToString("dd/MM/yyyy");
                                sdt0 = dtw.ToString("dd/MM/yyyy");
                                sdt = "'" + sdt.Substring(6, 4) + sdt.Substring(3, 2) + sdt.Substring(0, 2) + "'";
                            }
                            else
                            {
                                sdt = "null";
                                sdt0 = " ";
                            }

                            try
                            {
                                deb = Convert.ToDecimal(strArray[3].Trim());
                            }
                            catch
                            {
                                deb = 0;
                            }

                            try
                            {
                                cre = Convert.ToDecimal(strArray[4].Trim());
                            }
                            catch
                            {
                                cre = 0;
                            }

                            try
                            {
                                cod = Convert.ToInt32(strArray[26].Trim());
                            }
                            catch
                            {
                                cod = 0;
                            }

                            try
                            {
                                tan = Convert.ToInt32(strArray[27].Trim());
                            }
                            catch
                            {
                                tan = 0;
                            }

                            Sql.CommandText = "select count(*) from receipts where dt = " + sdt + " and deb = " + deb.ToString() + " and cre = " + cre.ToString() + " and note = N'" + strArray[1].Trim().Replace("'", "`") + "'";

                            int kol = Convert.ToInt32(Sql.ExecuteScalar());

                            if (kol != 0)
                            {
                                Sql.CommandText = "select ind from receipts where dt = " + sdt + " and deb = " + deb.ToString() + " and cre = " + cre.ToString() + " and note = N'" + strArray[1].Trim().Replace("'", "`") + "'";

                                int indbru = Convert.ToInt32(Sql.ExecuteScalar());

                                Sql.CommandText = Sql.CommandText + " delete from receipts where ind = " + indbru;

                                try
                                {
                                    Sql.ExecuteNonQuery();
                                }
                                catch
                                {
                                    /**/
                                }
                            }

                            count_rec = count_rec + 1;

                            Sql.CommandText = "insert into receipts (dt,deb,cre,note,comment,code,tan) values(" + sdt + "," + deb.ToString() + "," + cre.ToString() + ",N'" + strArray[1].Trim().Replace("'", "`") + "',N'" + strArray[2].Trim().Replace("'", "`") + "'," + cod.ToString() + "," + tan.ToString() + ")";
                            Sql.CommandText = Sql.CommandText + " insert into logs (user_n,nom_n,dt_n,note) values('" + usname + "','" + tan.ToString() + "',getdate(),N'ტრანზაქციის დამატება')";

                            Sql.ExecuteNonQuery();
                        }

                        catch (Exception ex)
                        {
                            /*count_rec = count_rec - 1;*/
                            LB_resp.AppendText("შეცდომა სტრიქონში : იდ. # - " + tan.ToString() + " თარიღი - " + strArray[0].ToString() + (char)13);
                            LB_resp.AppendText(ex.Message + (char)13);
                        }
                    }
                    else
                    {
                        goto l1;
                    }

                }

            l1: ;

                LB_resp.AppendText("ტრანზაქციის # " + count.ToString() + (char)13);

                LB_resp.AppendText("პროცესის დასრულება" + (char)13);

                TB_tran.Text = "დამუშავებული სტრიქონების რაოდენობა : " + count.ToString() + " მათ შორის " + count_rec.ToString() + " წარმატებულია";
            }

            catch (Exception ex)
            {
                LB_resp.AppendText("შეცდომებია Excel-ფაილში" + (char)13);
                LB_resp.AppendText(ex.Message + (char)13);
                LB_resp.AppendText("გადაამოწმეთ თარიღის ფორმატი (არ არის 'Text'-ური) ან სხვა პრობლემაა" + (char)13);
            }


            wb.Close(false, TB_exc.Text, true);

            pr_ref1(sender, e);

            pr_ref(sender, e);

        }

        private void pr_hfilt1(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.IsBalloon = true;
            myToolTip.SetToolTip(B_filt1, "ფილტრი");
        }

        private void pr_filt1(object sender, EventArgs e)
        {
            CB_filt1.Text = "";
            TB_nim1.Text = "";
            RB_as1.Checked = true;
            LB_filt1.Items.Clear();
            Pa_filt1.BringToFront();
            Pa_filt1.Visible = true;
        }

        private void pr_cl_filt1(object sender, EventArgs e)
        {
            Pa_filt1.Visible = false;
        }

        private void pr_addparam1(object sender, EventArgs e)
        {
            int kolit = 0;

            for (int i0 = 0; i0 <= LB_filt1.Items.Count - 1; i0++)
            {
                if (LB_filt1.Items[i0].ToString() == CB_filt1.Text)
                {
                    kolit = kolit + 1;
                }
            }

            if (kolit == 0)
            {
                LB_filt1.Items.Add(CB_filt1.Text);
                filters1[0, LB_filt1.Items.Count - 1] = CB_filt1.Text;

                for (int i0 = 0; i0 <= DGV_bru.ColumnCount - 1; i0++)
                {
                    if (DGV_bru.Columns[i0].HeaderText == CB_filt1.Text)
                    {
                        filters1[1, LB_filt1.Items.Count - 1] = DGV_bru.Columns[i0].DataPropertyName;
                    }
                }

                nomit1 = LB_filt1.Items.Count - 1;

                filters1[2, nomit1] = "1";
                filters1[3, nomit1] = "";

                if ((filters1[1, nomit1] == "dt") || (filters1[1, nomit1] == "deb") || (filters1[1, nomit1] == "cre"))
                {
                    RB_as1.Enabled = false;
                    RB_as1.Checked = false;
                    RB_udris1.Enabled = true;
                    RB_udris1.Checked = true;
                    RB_nacl1.Enabled = true;
                    RB_met1.Enabled = true;
                }
                else
                {
                    RB_as1.Enabled = true;
                    RB_as1.Checked = true;
                    RB_udris1.Enabled = true;
                    RB_nacl1.Enabled = true;
                    RB_met1.Enabled = true;
                }

                if (RB_as1.Enabled)
                {
                    RB_as1.Checked = true;
                }

                TB_nim1.Text = "";
            }

        }

        private void pr_entnim1(object sender, KeyEventArgs e)
        {
            int delay;

            if (e.KeyValue == 13)
            {
                delay = 1;

                if (filters1[1, nomit1] == "dt")
                {
                    try
                    {
                        DateTime tar0 = Convert.ToDateTime(TB_nim1.Text);
                        string dge0 = tar0.ToString("dd/MM/yyyy");
                        delay = 1;
                    }
                    catch
                    {
                        MessageBox.Show("თარიღის ფორმატი არასწორია");
                        TB_nim1.Focus();
                        delay = 0;
                    }
                }

                if ((filters1[1, nomit1] == "deb") || (filters1[1, nomit1] == "cre"))
                {
                    try
                    {
                        decimal tar0 = Convert.ToDecimal(TB_nim1.Text);
                        delay = 1;
                    }
                    catch
                    {
                        MessageBox.Show("ციფრული მონაცემის ფორმატი არასწორია");
                        TB_nim1.Focus();
                        delay = 0;
                    }
                }

                if (delay == 1)
                {
                    string filt = filters1[0, nomit1];

                    filters1[3, nomit1] = TB_nim1.Text;

                    if (RB_as1.Checked)
                    {
                        filt = filt + " AS ";
                        filters1[2, nomit1] = "1";
                        filt = filt + " " + TB_nim1.Text + " ";
                    }

                    if (RB_udris1.Checked)
                    {
                        filt = filt + " = ";
                        filters1[2, nomit1] = "2";
                        filt = filt + " " + TB_nim1.Text + " ";
                    }

                    if (RB_nacl1.Checked)
                    {
                        filt = filt + " < ";
                        filters1[2, nomit1] = "3";
                        filt = filt + " " + TB_nim1.Text + " ";
                    }

                    if (RB_met1.Checked)
                    {
                        filt = filt + " > ";
                        filters1[2, nomit1] = "4";
                        filt = filt + " " + TB_nim1.Text + " ";
                    }

                    LB_filt1.Items[nomit1] = filt;
                }
            }

        }

        private void pr_vibit1(object sender, MouseEventArgs e)
        {
            nomit1 = LB_filt1.SelectedIndex;
        }

        private void pr_filtdel1(object sender, EventArgs e)
        {
            LB_filt1.Items.RemoveAt(nomit1);

            for (int i0 = nomit1; i0 <= LB_filt1.Items.Count; i0++)
            {
                filters1[0, nomit1] = filters1[0, nomit1 + 1];
                filters1[1, nomit1] = filters1[1, nomit1 + 1];
                filters1[2, nomit1] = filters1[2, nomit1 + 1];
                filters1[3, nomit1] = filters1[3, nomit1 + 1];
            }

            filters1[0, LB_filt1.Items.Count] = "";
            filters1[1, LB_filt1.Items.Count] = "";
            filters1[2, LB_filt1.Items.Count] = "";
            filters1[3, LB_filt1.Items.Count] = "";
        }

        private void pr_delfilt1(object sender, EventArgs e)
        {
            for (int i0 = 0; i0 <= 499; i0++)
            {
                filters1[0, i0] = "";
                filters1[1, i0] = "";
                filters1[2, i0] = "";
                filters1[3, i0] = "";
            }

            LB_filt1.Items.Clear();

            pr_ref1(sender, e);

            Pa_filt1.Visible = false;
        }

        private void pr_gofilt1(object sender, EventArgs e)
        {

            for (int i0 = 0; i0 <= LB_filt1.Items.Count - 1; i0++)
            {
                if (i0 == 0)
                {
                    filter1 = filters1[1, i0];
                }
                else
                {
                    filter1 = filter1 + " and " + filters1[1, i0];
                }

                if (filters1[2, i0] == "1")
                {
                    filter1 = filter1 + " like '%" + filters1[3, i0] + "%'";
                }

                if (filters1[2, i0] == "2")
                {
                    filter1 = filter1 + " = '" + filters1[3, i0] + "'";
                }

                if (filters1[2, i0] == "3")
                {
                    filter1 = filter1 + " < '" + filters1[3, i0] + "'";
                }

                if (filters1[2, i0] == "4")
                {
                    filter1 = filter1 + " > '" + filters1[3, i0] + "'";
                }

            }

            try
            {
                BS_bru.Filter = filter1;

                DGV_bru.Refresh();

                Pa_filt1.Visible = false;

            }
            catch
            {
                MessageBox.Show("ვერ შესრულდა, შეამოწმეთ ფილტრის სისწორე");
            }

        }

        private void pr_hdelbru(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.IsBalloon = true;
            myToolTip.SetToolTip(B_delbru, "წაშლა");
        }

        private void pr_delbru(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            if (
            (MessageBox.Show("        წაშლა ?", "წაშლა", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)).ToString() == "Yes")
            {
                int colugb = DGV_bru.CurrentCell.ColumnIndex;
                int rowwgb = DGV_bru.CurrentCell.RowIndex;

                string indbru = DGV_bru.Rows[rowwgb].Cells["ind"].Value.ToString();

                Sql.CommandText = " delete from receipts where ind = " + indbru;

                Sql.CommandText = Sql.CommandText + " insert into logs (user_n,nom_n,dt_n,do_n,note) values('" + usname + "',N'" + DGV_bru.Rows[rowwgb].Cells["tan"].Value.ToString().Trim() + "',getdate(),3,N'ბრუმვის წაშლა')";

            }

            try
            {
                Sql.ExecuteNonQuery();

                BS_bru.Filter = filter1;

                dS_bru.Clear();

                this.TA_bru.Fill(this.dS_bru.receipts);

                DGV_bru.Refresh();

                pr_ref(sender, e);
            }
            catch
            {
                MessageBox.Show("ოპერაცია ვერ შესრულდა, გაიმეორეთ");
            }
        }

        private void pr_rep(object sender, EventArgs e)
        {
            Pa_rep.Left = Left + 21;
            Pa_rep.Top = Top + 35;
            Pa_rep.Width = Width - 41;
            Pa_rep.Height = Height - 67;
            Pa_w2.Width = Pa_rep.Width - 41;
            B_cl_rep.Left = Pa_rep.Width - 29;
            DGV_rep.Width = Pa_rep.Width - 29;
            DGV_rep.Height = Pa_rep.Height - 60;

            Pa_rep.BringToFront();
            Pa_rep.Visible = true;

            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            Sql.CommandText = "truncate table acc";

            Sql.ExecuteNonQuery();

            dS_rep.Clear();
            this.TA_rep.Fill(this.dS_rep.acc);
            DGV_rep.Refresh();

        }

        private void pr_cl_rep(object sender, EventArgs e)
        {
            Pa_rep.Visible = false;
        }

        private void pr_hrefrep(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.IsBalloon = true;
            myToolTip.SetToolTip(B_refrep, "Refresh");
        }

        private void pr_hexprep(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.IsBalloon = true;
            myToolTip.SetToolTip(B_exprep, "ექსპორტი Excel-ში");
        }

        private void pr_refrep(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            string dtot;
            string dtdo;

            dtot = TP_rep_ot.Value.ToString("dd/MM/yyyy");
            dtot = "'" + dtot.Substring(6, 4) + dtot.Substring(3, 2) + dtot.Substring(0, 2) + "'";

            dtdo = TP_rep_do.Value.ToString("dd/MM/yyyy");
            dtdo = "'" + dtdo.Substring(6, 4) + dtdo.Substring(3, 2) + dtdo.Substring(0, 2) + "'";

            Sql.CommandText = "truncate table acc";

            Sql.CommandText = Sql.CommandText + " exec dbo.proc_acc " + dtot + "," + dtdo;

            Sql.ExecuteNonQuery();

            dS_rep.Clear();
            this.TA_rep.Fill(this.dS_rep.acc);
            DGV_rep.Refresh();

        }

        private void pr_exprep(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApplication = new Microsoft.Office.Interop.Excel.Application();
            ExcelApplication.SheetsInNewWorkbook = 1;
            ExcelApplication.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook ExcelWorkbook = ExcelApplication.Workbooks.Add("");

            Microsoft.Office.Interop.Excel.Worksheet ExcelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkbook.Sheets.get_Item(1);
            ExcelWorksheet.Name = "Report";

            Microsoft.Office.Interop.Excel.Range ExcelRange = ExcelWorksheet.get_Range(ExcelWorksheet.Cells[1, 1], ExcelWorksheet.Cells[DGV_rep.RowCount + 2, DGV_rep.ColumnCount]);
            object[,] datagridview = new object[DGV_rep.RowCount + 2, DGV_rep.ColumnCount];

            datagridview[0, 0] = "თარიღი - ";

            datagridview[0, 3] = TP_rep_ot.Value.Date.ToString("dd/MM/yyyy") + "-დან " + TP_rep_do.Value.Date.ToString("dd/MM/yyyy") + "-მდე";

            int ii = -1;

            for (int i0 = 0; i0 <= DGV_rep.ColumnCount - 1; i0++)
            {
                if (DGV_rep.Columns[i0].Visible)
                {
                    ii = ii + 1;
                    datagridview[1, ii] = DGV_rep.Columns[i0].HeaderText;
                }
            }

            ExcelRange.set_Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault, datagridview);

            ExcelRange.Font.Name = "Sylfaen";

            for (int i = 2; i <= DGV_rep.RowCount + 1; i++)
            {
                ii = -1;

                for (int i0 = 0; i0 <= DGV_rep.ColumnCount - 1; i0++)
                {
                    if (DGV_rep.Columns[i0].Visible)
                    {
                        ii = ii + 1;
                        datagridview[i, ii] = DGV_rep.Rows[i - 2].Cells[i0].Value;
                    }
                }

            }

            ExcelWorksheet.get_Range(ExcelWorksheet.Cells[1, 1], ExcelWorksheet.Cells[DGV_rep.RowCount + 2, DGV_rep.ColumnCount]).set_Value(Microsoft.Office.Interop.Excel.XlRangeValueDataType.xlRangeValueDefault, datagridview); //заенсення даних потаблиці*/

            ExcelRange.EntireColumn.AutoFit();

        }

        private void pr_d16(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            int colugi = DGV_rep.CurrentCell.ColumnIndex;
            int rowwgi = DGV_rep.CurrentCell.RowIndex;

            DateTime d0;
            DateTime dd = DateTime.Today;
            DateTime dda2 = DateTime.Today;
            DateTime dda3 = DateTime.Today;
            DateTime dda1;
            int ind1 = 0;
            int ind2 = 0;
            string fre;
            string fre1;
            string inf;
            string auqt;

            string nom = DGV_rep.Rows[rowwgi].Cells["nom_a"].Value.ToString();

            Forms frm = new Forms();
            frm.conn = conn;
            frm.sss = sss;
            moqme = 10;
            frm.moqme = moqme;

            Sql.CommandText = "select auqt from info where nom = N'" + nom + "'";

            auqt = Sql.ExecuteScalar().ToString();

            Sql.CommandText = "select inf_i from info where nom = N'" + nom + "'";

            inf = Sql.ExecuteScalar().ToString();

            Sql.CommandText = "select ad_date from info where nom = N'" + nom + "'";

            DateTime d1 = Convert.ToDateTime(Sql.ExecuteScalar());

            Sql.CommandText = "select dbo.end1(" + inf + ") from info where nom = N'" + nom + "'";

            DateTime d2 = Convert.ToDateTime(Sql.ExecuteScalar());

            Sql.CommandText = "select dbo.start1(" + inf + ") from info where nom = N'" + nom + "'";

            DateTime d3 = Convert.ToDateTime(Sql.ExecuteScalar());

            if ((auqt == "LIVO") || (auqt == "Auction.livo.ge"))
            {
                frm.mimg = "შპს თინეთი, 402116474";
            }
            else
            {
                frm.mimg = "სსიპ „საქართველოს ფინანსთა სამინისტროს მომსახურების სააგენტო“";
            }

            if ((d1 != null) && (d2 != null) && (d3 != null))
            {
                dda1 = d2;

                Sql.CommandText = "select end_date from info where nom = N'" + nom + "'";

                try
                {
                    d0 = Convert.ToDateTime(Sql.ExecuteScalar());
                    frm.ddn = d0.ToString("dd/MM/yyyy");
                }
                catch
                {
                    frm.ddn = "";
                }

                frm.nn = nom;

                Sql.CommandText = "select auc1_end from info where nom = N'" + nom + "'";

                try
                {
                    dda2 = Convert.ToDateTime(Sql.ExecuteScalar());
                    ind1 = 1;
                }
                catch
                {
                    ind1 = 0;
                }

                Sql.CommandText = "select auc2_end from info where nom = N'" + nom + "'";

                try
                {
                    dda3 = Convert.ToDateTime(Sql.ExecuteScalar());
                    ind2 = 1;
                }
                catch
                {
                    ind2 = 0;
                }

                Sql.CommandText = "select isnull(freeze,0) from info where nom = N'" + nom + "'";

                fre = Sql.ExecuteScalar().ToString();

                Sql.CommandText = "select isnull(freeze_1,0) from info where nom = N'" + nom + "'";

                fre1 = Sql.ExecuteScalar().ToString();

                if ((dd <= dda1) || (fre == "True"))
                {
                    frm.an = "1";
                }

                if (ind1 == 1)
                {
                    if (((dd > dda1) && (dd <= dda2)) || (fre1 == "True"))
                    {
                        frm.an = "2";
                    }
                }
                else
                {
                    frm.an = "1";
                }

                if (ind2 == 1)
                {
                    if ((dd > dda2) && (dd <= dda3))
                    {
                        frm.an = "3";
                    }
                }
                else
                {
                    if ((dd <= dda1) || (fre == "True"))
                    {
                        frm.an = "1";
                    }

                    if (ind1 == 1)
                    {
                        if (((dd > dda1) && (dd <= dda2)) || (fre1 == "True"))
                        {
                            frm.an = "3";
                        }
                    }
                    else
                    {
                        frm.an = "1";
                    }
                }

                if ((dd > dda3) && (ind2 == 1))
                {
                    frm.an = "3";
                }

                Sql.CommandText = "select dbo.eacut(" + inf + ") from info where nom = N'" + nom + "'";

                frm.cc = Sql.ExecuteScalar().ToString();

                Sql.CommandText = "exec dbo.proc_acc1 '" + nom + "'";

                Sql.ExecuteNonQuery();

                Sql.CommandText = "select dbo.acc_p('" + nom + "')";

                frm.ce0 = Sql.ExecuteScalar().ToString();

                Sql.CommandText = "select dbo.bank_info(" + inf + ") from info where nom = N'" + nom + "'";

                frm.ce = Sql.ExecuteScalar().ToString();

                Sql.CommandText = "select dbo.dgg_dat(" + inf + ") from info where nom = N'" + nom + "'";

                frm.cd = Sql.ExecuteScalar().ToString();

                Sql.CommandText = "select dbo.acc_dgg('" + nom + "')";

                frm.cb0 = Sql.ExecuteScalar().ToString();

                Sql.CommandText = "select dbo.spec(" + inf + ") from info where nom = N'" + nom + "'";

                frm.cb = Sql.ExecuteScalar().ToString();

                Sql.CommandText = "select isnull(sum_gel,0) from info where nom = N'" + nom + "'";

                frm.buw = Sql.ExecuteScalar().ToString();

                Sql.CommandText = "select isnull(buyer,'') from info where nom = N'" + nom + "'";

                frm.btw = Sql.ExecuteScalar().ToString();

                Sql.CommandText = "select isnull(debtor,'') from info where nom = N'" + nom + "'";

                frm.ww = Sql.ExecuteScalar().ToString();

                Sql.CommandText = "select isnull(debtor_num,'') from info where nom = N'" + nom + "'";

                frm.xw = Sql.ExecuteScalar().ToString();

                Sql.CommandText = "select isnull(owner,'') from info where nom = N'" + nom + "'";

                frm.qw = Sql.ExecuteScalar().ToString();

                Sql.CommandText = "select isnull(owner_num,'') from info where nom = N'" + nom + "'";

                frm.rw = Sql.ExecuteScalar().ToString();

                Sql.CommandText = "select  dbo.cust_info(inf_i) AS cust from info where nom = N'" + nom + "'";

                frm.rekv = Sql.ExecuteScalar().ToString();

                frm.Show();
            }
            else
            {
                MessageBox.Show("გადაამოწმეთ ყველა აუცილებელი ცვლადი ველი");
            }

        }

        private void pr_sem18(object sender, EventArgs e)
        {
            if (TB_specpr.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_specpr.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_specpr.Focus();
                }
            }

        }

        private void pr_sem19(object sender, EventArgs e)
        {
            if (TB_kor.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_kor.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_kor.Focus();
                }
            }

        }

        private void pr_chno55(object sender, EventArgs e)
        {
            if (note.Contains("SPEC %; ") == false)
            {
                note = note + "SPEC %; ";
            }
            pr_ch(sender, e);

        }

        private void pr_chno56(object sender, EventArgs e)
        {
            if (note.Contains("KORECTOR; ") == false)
            {
                note = note + "KORECTOR; ";
            }
            pr_ch(sender, e);

        }

        private void pr_usrout(object sender, EventArgs e)
        {
            TB_usrout.Text = "";
            TB_psw_usrout.Text = "";
            TB_cred.Text = "";
            TB_cred_pn.Text = "";
            TB_cred_addr.Text = "";
            TB_usr_geo.Text = "";
            TB_usr_pn.Text = "";
            TB_usr_tel.Text = "";
            TB_usr_mail.Text = "";

            Pa_userout.BringToFront();
            Pa_userout.Visible = true;
        }

        private void pr_cl_usrout(object sender, EventArgs e)
        {
            Pa_userout.Visible = false;
        }

        private void pr_go_usrout(object sender, EventArgs e)
        {
            string hash0 = "";
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            if ((TB_usrout.Text.Trim() != "") & (TB_psw_usrout.Text.Trim() != "") & (TB_cred.Text.Trim() != "") & (TB_cred_pn.Text.Trim() != "") &
                (TB_cred_addr.Text.Trim() != "") & (TB_usr_geo.Text.Trim() != "") & (TB_usr_pn.Text.Trim() != "") & (TB_usr_tel.Text.Trim() != "") &
                  (TB_usr_mail.Text.Trim() != ""))
            {
                Sql.CommandText = "select count(*) from outsp.dbo.users where user_name = N'" + TB_usrout.Text + "'";

                int kol = Convert.ToInt32(Sql.ExecuteScalar().ToString());

                if (kol == 0)
                {
                    string hash = TB_psw_usrout.Text;

                    MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

                    System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();

                    byte[] bhes = md5.ComputeHash(enc.GetBytes(hash));

                    foreach (byte bt in bhes)
                    {

                        hash0 += string.Format("{0:X2}", bt);

                    }

                    Sql.CommandText = "insert into outsp.dbo.users (creditor_id,user_name,user_psw,user_pn,creditor,user_tel,user_mail,user_name_geo,creditor_pn,creditor_addr) values (" + cust0.ToString() + ",N'" + TB_usrout.Text.Replace("'", "`").Trim() + "',N'" + hash0 + "',N'" + TB_usr_pn.Text.Replace("'", "`").Trim() + "',N'" + TB_cred.Text.Replace("'", "`").Trim() + "',N'" + TB_usr_tel.Text.Replace("'", "`").Trim() + "',N'" + TB_usr_mail.Text.Replace("'", "`").Trim() + "',N'" + TB_usr_geo.Text.Replace("'", "`").Trim() + "',N'" + TB_cred_pn.Text.Replace("'", "`").Trim() + "',N'" + TB_cred_addr.Text.Replace("'", "`").Trim() + "')";

                    /*FileStream otptt = File.Open("c:\\ppp.txt", FileMode.OpenOrCreate);
                    StreamWriter gamot = new StreamWriter(otptt);
                    gamot.WriteLine(Sql.CommandText);
                    gamot.Close();*/

                    try
                    {
                        Sql.ExecuteNonQuery();

                        MessageBox.Show("შესრულებულია");
                    }
                    catch
                    {
                        MessageBox.Show("ოპერაცია ვერ შესრულდა, სცადეთ თავიდან");
                    }
                }
                else
                {
                    MessageBox.Show("ოპერაცია ვერ შესრულდა, მომხმარებელი არსებობს");
                }
            }
            else
            {
                MessageBox.Show("ოპერაცია ვერ შესრულდა, შეავსეთ ყველა ველი");
            }
        }

        private void pr_pdf(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            int colugi = DGV_info.CurrentCell.ColumnIndex;
            int rowwgi = DGV_info.CurrentCell.RowIndex;

            Sql.CommandText = "select files1_name,info1_id,files1_id from outsp.dbo.files1 where info1_id = " + DGV_info.Rows[rowwgi].Cells["pdfo"].Value.ToString() + " order by files1_name";

            SqlDataAdapter da1 = new SqlDataAdapter(Sql);

            dS_pdf.Clear();

            da1.Fill(this.dS_pdf.files1);

            DGV_pdf.Refresh();

            Pa_pdf.BringToFront();
            Pa_pdf.Visible = true;

        }

        private void pr_cl_pdf(object sender, EventArgs e)
        {
            Pa_pdf.Visible = false;
        }

        private void pr_save_pdf(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            int colugi = DGV_pdf.CurrentCell.ColumnIndex;
            int rowwgi = DGV_pdf.CurrentCell.RowIndex;

            Sql.CommandText = "select files1_text from outsp.dbo.files1 where files1_id = " + DGV_pdf.Rows[rowwgi].Cells["files1_id"].Value.ToString();

            bytes = (Byte[])Sql.ExecuteScalar();

            SFD_pdf.FileName = DGV_pdf.Rows[rowwgi].Cells["files1_name"].Value.ToString();

            SFD_pdf.ShowDialog();

        }

        private void pr_spdf(object sender, CancelEventArgs e)
        {
            File.WriteAllBytes(SFD_pdf.FileName, bytes);
        }

        private void pr_chno57(object sender, EventArgs e)
        {
            if (note.Contains("პირველი აუქციონის საწყისი ფასი EUR; ") == false)
            {
                note = note + "პირველი აუქციონის საწყისი ფასი EUR; ";
            }
            pr_ch(sender, e);
        }

        private void pr_sem11(object sender, EventArgs e)
        {
            if (TB_sales_usd.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_sales_eur.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_sales_eur.Focus();
                }
            }

        }

        private void pr_tmi(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            string nbgurl = ConfigurationManager.ConnectionStrings["nbgurl"].ConnectionString;
            string dt = System.DateTime.Today.ToString("yyyy-MM-dd");

            nbgurl = nbgurl + "?date=" + dt;
            DateTime dtt = Convert.ToDateTime(dt);

            Sql.CommandText = "select max(isodate) from turnover.dbo.iso";

            DateTime dtt0 = Convert.ToDateTime(Sql.ExecuteScalar().ToString());

            System.Net.ServicePointManager.SecurityProtocol = (System.Net.SecurityProtocolType)(768 | 3072);

            if (dtt0 < dtt)
            {
                try
                {

                    string resp = webclient.DownloadString(nbgurl);

                    int indusd = resp.IndexOf("USD");
                    int indeur = resp.IndexOf("EUR");

                    if ((indusd != -1) && (indeur != -1))
                    {
                        indusd = indusd + 34;
                        string fromnbg = resp.Substring(indusd, 6);

                        indeur = indeur + 34;
                        string fromnbg1 = resp.Substring(indeur, 6);

                        try
                        {
                            decimal kuku = Convert.ToDecimal(fromnbg);

                            string ddt = dt.Substring(0, 4) + dt.Substring(5, 2) + dt.Substring(8, 2);

                            Sql.CommandText = "insert into turnover.dbo.iso (isodate,usd,eur) values('" + ddt + "'," + fromnbg + "," + fromnbg1 + ")";

                            Sql.ExecuteNonQuery();

                            Ti.Enabled = false;

                        }
                        catch
                        {
                            MessageBox.Show("კურსის დამატება ვერ მოხერდა, შენარჩუნებულია ძველი კურსი" + indusd);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("ეროვნული ბანკი არ პასუხობს, შენარჩუნებულია ძველი კურსი; მოქმედება: დაამატეთ კურსი ხელით");
                }

                dS_kur.Clear();

                this.TA_kur.Fill(this.dS_kur.iso);

                DGV_kur.Refresh();

                /*Sql.CommandText = "select top 1 convert(char(10),isodate,103),usd,eur from turnover.dbo.iso order by isodate desc";
                SqlDataReader Q03;

                Q03 = Sql.ExecuteReader();

                while (Q03.Read())
                {
                    TB_isodt.Text = Q03.GetString(0);
                    TB_dol.Text = Convert.ToString(Q03.GetValue(1));
                    TB_eur.Text = Convert.ToString(Q03.GetValue(2));
                }

                Q03.Close();*/
            }
            else
            {
                Ti.Enabled = false;
            }
        }

        private void pr_sem20(object sender, EventArgs e)
        {
            if (TB_auqpr.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_auqpr.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_auqpr.Focus();
                }
            }

        }

        private void pr_chno58(object sender, EventArgs e)
        {
            if (note.Contains("Auction %; ") == false)
            {
                note = note + "Auction %; ";
            }
            pr_ch(sender, e);
        }

        private void pr_cl_newauqt(object sender, EventArgs e)
        {
            Pa_newauqt.Visible = false;
        }

        private void pr_addauqt(object sender, EventArgs e)
        {
            TB_newauqt.Text = "";
            Pa_newauqt.BringToFront();
            Pa_newauqt.Visible = true;
            TB_newauqt.Focus();
        }

        private void pr_saveauqt(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            string auqt = TB_auqt.Text;

            if (TB_newauqt.Text.Trim() != "")
            {
                Sql.CommandText = "insert into auqtipe (auqtp) values(N'" + TB_newauqt.Text.Replace("'", "`").Trim() + "')";
                Sql.ExecuteNonQuery();
            }

            Pa_newauqt.Visible = false;

            DS_auqt.Clear();

            this.TA_auqt.Fill(this.DS_auqt.auqtipe);

            TB_auqt.Refresh();

            TB_auqt.Text = auqt;

        }

        private void pr_sem03(object sender, EventArgs e)
        {
            if (TB_liq_usd.Text.Trim() != "")
            {
                try
                {
                    decimal cc = Convert.ToDecimal(TB_liq_usd.Text);
                }
                catch
                {
                    MessageBox.Show("შეტანა არასწორია");
                    TB_liq_usd.Focus();
                }
            }

        }

        private void pr_chno029(object sender, EventArgs e)
        {
            if (note.Contains("აუქციონის სალიკვიდაციო ფასი $; ") == false)
            {
                note = note + "აუქციონის სალიკვიდაციო ფასი $; ";
            }

            pr_cust(sender, e);

            pr_ch(sender, e);
        }

        private void pr_chno012(object sender, EventArgs e)
        {
            if (note.Contains("კომენტარი; ") == false)
            {
                note = note + "კომენტარი; ";
            }
            pr_ch(sender, e);

        }

        private void pr_hclon(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip myToolTip = new System.Windows.Forms.ToolTip();
            myToolTip.IsBalloon = true;
            myToolTip.SetToolTip(B_clon, "კლონირება");
        }

        private void pr_infclon(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            int colugi = DGV_info.CurrentCell.ColumnIndex;
            int rowwgi = DGV_info.CurrentCell.RowIndex;

            infi = DGV_info.Rows[rowwgi].Cells["inf_i"].Value.ToString();

            Sql.CommandText = "insert into info (nom,spec,stat,cust,representative,ad_date,n_mortgage,dt_mortgage,credit_treaty,credit_id,debt_usd,debt_gel,property_addr,property_code,property,rights,owner,owner_num,owner_addr1,	owner_addr2,owner_addr3,owner_addr4,debtor,debtor_num,debtor_addr,debtor1,debtor1_num,debtor1_addr,doc_orig,foto,prepaid,sales_usd,price_usd,price_gel,lot_num,price1_usd,price1_gel,lot1_num,price2_usd,price2_gel,lot2_num,buyer,sum_gel,dgg,repres_mail,owner_tel,gazrez,harmacne,post_send_0,tnt_send_0,courier_0,tel_0,rez_0,macne_0,auc_start_0,auc_end_0,post_send_1,tnt_send_1,courier_1,tel_1,rez_1,macne_1,auc_start_1,auc_end_1,post_send_2,tnt_send_2,courier_2,tel_2,rez_2,macne_2,auc_start_2,auc_end_2,post_reg,tnt_reg,post1_reg,post2_reg,tnt1_reg,tnt2_reg,freeze,freeze_1,end_date,auc2,auc2_dt,auc3,auc3_dt,gaz,gaz_dt,mac,mac_dt,prepaid_dt,specpr,kor,pdfo,sales_eur,uin,auqpr,auqt,liquid_price,comment)";
	
            Sql.CommandText = Sql.CommandText + " select 0,spec,stat,cust,representative,ad_date,n_mortgage,dt_mortgage,credit_treaty,credit_id,debt_usd,debt_gel,property_addr,property_code,property,rights,owner,owner_num,owner_addr1,owner_addr2,owner_addr3,owner_addr4,debtor,debtor_num,debtor_addr,debtor1,debtor1_num,debtor1_addr,doc_orig,foto,prepaid,sales_usd,price_usd,price_gel,lot_num,price1_usd,price1_gel,lot1_num,price2_usd,price2_gel,lot2_num,buyer,sum_gel,dgg,repres_mail,owner_tel,gazrez,harmacne,post_send_0,tnt_send_0,courier_0,tel_0,rez_0,macne_0,auc_start_0,auc_end_0,post_send_1,tnt_send_1,courier_1,tel_1,rez_1,macne_1,auc_start_1,auc_end_1,post_send_2,tnt_send_2,courier_2,tel_2,rez_2,macne_2,auc_start_2,auc_end_2,post_reg,tnt_reg,post1_reg,post2_reg,tnt1_reg,tnt2_reg,freeze,freeze_1,end_date,auc2,auc2_dt,auc3,auc3_dt,gaz,gaz_dt,mac,mac_dt,prepaid_dt,specpr,kor,pdfo,sales_eur,uin,auqpr,auqt,liquid_price,comment from info where inf_i = " + infi;

            try
            {
                Sql.ExecuteNonQuery();

                pr_ref(sender, e);
            }
            catch
            {
                MessageBox.Show("ოპერაცია ვერ შესრულდა, თავიდან სცადეთ");
            }

        }

        private void pr_026(object sender, EventArgs e)
        {
            if (CB_stg.Checked)
            {
                TB_fee.BackColor = Color.LightGray;
                TB_fee.ReadOnly = true;
            }
            else
            {
                TB_fee.BackColor = Color.White;
                TB_fee.ReadOnly = false;
            }

            if (note.Contains("ფორულა; ") == false)
            {
                note = note + "ფორულა; ";
            }
            pr_ch(sender, e);

        }

        private void pr_kur(object sender, EventArgs e)
        {
            Pa_kur.BringToFront();
            Pa_kur.Visible = true;
        }

        private void pr_cl_kur(object sender, EventArgs e)
        {
            Pa_kur.Visible = false;
        }

        private void pr_addval(object sender, EventArgs e)
        {
            Pa_valu.BringToFront();
            Pa_valu.Visible = true;

            SqlCommand Sql = new SqlCommand("", sss);

            Sql.CommandText = "select max(isodate) from turnover.dbo.iso";

            DateTime dku = Convert.ToDateTime(Sql.ExecuteScalar().ToString());

            string dkud = dku.ToString("dd/MM/yyyy");

            dkud = dkud.Substring(6, 4) + dkud.Substring(3, 2) + dkud.Substring(0, 2);

            Sql.CommandText = "select usd from turnover.dbo.iso where isodate = '" + dkud + "'";

            decimal usd = Convert.ToDecimal(Sql.ExecuteScalar().ToString());

            Sql.CommandText = "select eur from turnover.dbo.iso where isodate = '" + dkud + "'";

            decimal eur = Convert.ToDecimal(Sql.ExecuteScalar().ToString());

            /*TB_tarval.Value = dku;*/

            TB_usdval.Text = usd.ToString();
            TB_eurval.Text = eur.ToString();

            valmoqme = 1;

            TB_tarval.MaxDate = DateTime.Today;

        }

        private void pr_cl_val(object sender, EventArgs e)
        {
            Pa_valu.Visible = false;
        }

        private void pr_senval(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            string dt;
            dt = TB_tarval.Value.Date.ToString();
            dt = dt.Substring(6, 4) + dt.Substring(3, 2) + dt.Substring(0, 2);

            if (valmoqme == 1)
            {
                Sql.CommandText = "insert into turnover.dbo.iso select '" + dt + "'," + TB_usdval.Text + "," + TB_eurval.Text;
                Sql.ExecuteNonQuery();

                this.TA_kur.Fill(this.dS_kur.iso);

            }

            if (valmoqme == 2)
            {
                Sql.CommandText = "update turnover.dbo.iso ";
                Sql.CommandText = Sql.CommandText + "set isodate = '" + dt + "',usd = " + TB_usdval.Text + ",eur = " + TB_eurval.Text + " where iis = " + indv;
                Sql.ExecuteNonQuery();

                this.TA_kur.Fill(this.dS_kur.iso);

            }

            Pa_valu.Visible = false;
            valmoqme = 0;

        }

        private void pr_edval(object sender, EventArgs e)
        {
            colug = DGV_kur.CurrentCell.ColumnIndex;
            rowg = DGV_kur.CurrentCell.RowIndex;

            indv = DGV_kur.Rows[rowg].Cells["iis"].Value.ToString();

            Pa_valu.BringToFront();
            Pa_valu.Visible = true;

            valmoqme = 2;

            TB_tarval.MaxDate = DateTime.Today;

            TB_tarval.Value = Convert.ToDateTime(DGV_kur.Rows[rowg].Cells["isodate"].Value.ToString());
            TB_usdval.Text = DGV_kur.Rows[rowg].Cells["usd"].Value.ToString();
            TB_eurval.Text = DGV_kur.Rows[rowg].Cells["eur"].Value.ToString();

            if (TB_usdval.Text.Trim() == "")
            {
                TB_usdval.Text = "0";
            }

            if (TB_eurval.Text.Trim() == "")
            {
                TB_eurval.Text = "0";
            }

        }

        private void pr_delval(object sender, EventArgs e)
        {
            if (
            (MessageBox.Show("დაადასტურეთ", "წაშლა", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)).ToString() == "Yes")
            {

                colug = DGV_kur.CurrentCell.ColumnIndex;
                rowg = DGV_kur.CurrentCell.RowIndex;

                indv = DGV_kur.Rows[rowg].Cells["iis"].Value.ToString();

                SqlCommand Sql = new SqlCommand("", sss);
                Sql.CommandType = CommandType.Text;

                Sql.CommandText = "delete from turnover.dbo.iso where iis = " + indv;
                Sql.ExecuteNonQuery();

                this.TA_kur.Fill(this.dS_kur.iso);
            }

        }

        private void pr_prc(object sender, DataGridViewCellEventArgs e)
        {
            /*int colug = DGV_rep.CurrentCell.ColumnIndex;
            int rowwg = DGV_rep.CurrentCell.RowIndex;
            string colugs = DGV_rep.Columns[colug].Name;

            if (colugs == "spec_a")
            {
                Pa_prc.Left = mx;
                Pa_prc.Top = my - 130;

                Pa_prc.BringToFront();
                Pa_prc.Visible = true;
            }
            else
            {
                Pa_prc.Visible = false;
            }*/
        }

        private void pr_cl_prc(object sender, EventArgs e)
        {
            Pa_prc.Visible = false;
        }

        private void pr_prc0(object sender, DataGridViewCellMouseEventArgs e)
        {
            colug = DGV_rep.CurrentCell.ColumnIndex;
            rowwg = DGV_rep.CurrentCell.RowIndex;
            string colugs = DGV_rep.Columns[colug].Name;

            if (colugs == "spec_a")
            {
                Pa_prc.Left = mx - 200;
                Pa_prc.Top = my + 80;

                Pa_prc.BringToFront();
                Pa_prc.Visible = true;

                TB_prc.Text = DGV_rep.Rows[rowwg].Cells["spec_a"].Value.ToString();
            }
            else
            {
                Pa_prc.Visible = false;
                TB_prc.Text = "";
            }
        }

        private void pr_prc1(object sender, MouseEventArgs e)
        {
            mx = e.X;
            my = e.Y;
        }

        private void pr_save_prc(object sender, EventArgs e)
        {
            SqlCommand Sql = new SqlCommand("", sss);

            string nom_a = DGV_rep.Rows[rowwg].Cells["nom_a"].Value.ToString();

            Sql.CommandText = "update info set specpr = '" + TB_prc.Text + "' where nom = N'" + nom_a + "'";

            Sql.ExecuteNonQuery();

            Pa_prc.Visible = false;
            TB_prc.Text = "";

            pr_refrep(sender, e);
        }

    }

}
