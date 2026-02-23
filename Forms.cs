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
using Microsoft.Office.Interop.Word;
using System.Net.Mail;
using System.Net;
using System.Globalization;

namespace SpecPro
{
    public partial class Forms : Form
    {
        public string conn = "";
        public SqlConnection sss = new SqlConnection();
        public string am = "";
        public string auc = "";
        public string aucs = "";
        public string auce = "";
        public string aucts = "";
        public string aucte = "";
        public string ah = "";
        public string ahg = "";
        public string dw = "";
        public string ew = "";
        public string qw = "";
        public string rw = "";
        public string mw = "";
        public string nw = "";
        public string ww = "";
        public string xw = "";
        public string ow = "";
        public string pw = "";
        public string mail = "";

        public string sw = "";
        public string tw = "";
        public string uw = "";
        public string vw = "";
        public string gw = "";
        public string hw = "";
        public string iw = "";
        public string kw = "";

        public string yw = "";

        public string zw = "";
        public string aaw = "";
        public string abw = "";

        public string aw = "";

        public string apw = "";

        public string btw = "";
        public string buw = "";
        public string fw = "";
        public string aiw = "";
        public string ajw = "";
        public string alw = "";
        public string amw = "";
        public string aow = "";
        public string anw = "";
        public string asw = "";
        public string aqw = "";
        public string arw = "";
        public string avw = "";
        public string aww = "";
        public string ayw = "";
        public string azw = "";
        public string bbw = "";
        public string baw = "";
        public string bfw = "";
        public string bdw = "";
        public string bew = "";
        public string biw = "";
        public string bjw = "";
        public string blw = "";
        public string bmw = "";
        public string bow = "";
        public string bnw = "";
        public string bsw = "";
        public string bqw = "";
        public string brw = "";
        public string atw = "";
        public string bgw = "";
        public string auw = "";
        public string bhw = "";
        public string adg = "";
        public string dgg = "";

        public string cw = "";

        public string apw1 = "";
        public string apw2 = "";
        public string apw3 = "";
        public string arw1 = "";
        public string arw2 = "";
        public string arw3 = "";

        public string ddn = "";
        public string nn = "";
        public string cc = "";
        public string ce = "";
        public string ce0 = "";
        public string cd = "";
        public string cb = "";
        public string cb0 = "";
        public string an = "";

        public int moqme = 0;

        public int selst = 0;
        public int sellen = 0;

        public string sitkfu = "";
        public string tanhafu = "";
        public string tanhurda = "";

        public string aj = "";
        public string ai = "";
        public string ah0 = "";
        public string ah1 = "";
        public string av = "";
        public string usd = "";
        public string eur = "";
        public string pro = "";
        public string spr = "";
        public string vat = "";
        public string aj2 = "";
        public string aj3 = "";

        public string auct = "";

        public string liv = "";

        public string ahn1 = "";
        public string ahn = "";
        public string ahgn = "";

        public string rekv = "";

        public string auqc = "";
        public int unda = 0;
        public string auqt = "";

        public string mimg = "";

        public Forms()
        {
            InitializeComponent();
        }

        private void pr_save(object sender, EventArgs e)
        {
            /*TXTextControl.SaveSettings sss = new TXTextControl.SaveSettings();

            TC1.Save();*/
        }

        private void pr_save1(object sender, EventArgs e)
        {
            TC1.Focus();
            TC1.SelectAll();

            TC1.Copy();

            SFD1.ShowDialog();
        }

        private void pr_save2(object sender, CancelEventArgs e)
        {
            /*TXTextControl.StreamType ggg = new TXTextControl.StreamType();

            ggg = TXTextControl.StreamType.MSWord;

            textControl1.Save(saveFileDialog1.FileName, ggg);*/

            /*dynamic doc = OfficeIntegration.*/

            object file = SFD1.FileName;

            object missing = System.Reflection.Missing.Value;

            Microsoft.Office.Interop.Word.Application woap = new Microsoft.Office.Interop.Word.Application();

            Microsoft.Office.Interop.Word.Document wodo = new Document();

            wodo = woap.Documents.Add(ref missing, ref missing, ref missing, ref missing);

            woap.Selection.Paste();

            /*woap.Selection.Text = textControl1.Text;*/

            /*woap.Selection.TypeText(textControl1.Text);*/

            wodo.Activate();

            wodo.SaveAs2(ref file, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing, ref missing);

            wodo.Close(ref missing, ref missing, ref missing);

            woap.Quit(ref missing, ref missing, ref missing);

            TC1.DeselectAll();

            /*TC1.SaveFile(SFD1.FileName);*/

            /*sss.ConnectionString = conn;

            SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            try
            {
                sss.Open();
            }
            catch
            {
                sss.Close();
                sss.Open();
            }

            Sql.CommandText = "update tufta set tufta_txt = N'" + TC1.Text + "'";
            Sql.ExecuteNonQuery();*/

        }

        private void pr_sel(object sender, EventArgs e)
        {
            TC1.Focus();
            TC1.SelectAll();
            TC1.Clear();

            /*SqlCommand Sql = new SqlCommand("", sss);
            Sql.CommandType = CommandType.Text;

            Sql.CommandText = "update tufta set tufta_txt = N'" + TC1.Text + "'";
            Sql.ExecuteNonQuery();*/

        }

        private void pr_loadform(object sender, EventArgs e)
        {
            /*sss.ConnectionString = conn;

            try
            {
                sss.Open();
            }
            catch
            {
                sss.Close();
                sss.Open();
            }*/


            /*string txt = "<span style = " + '"' + "font-size: 9.0pt" + '"' + "><b> 1. სპეციალისტი: </b><br>";
            txt = txt + "&nbsp;&nbsp;&nbsp; შეტყობინება აუქციონის დანიშვნის შესახებ " + "<br>";


            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();

            byte[] bhes = enc.GetBytes(txt);

            TXTextControl.BinaryStreamType bt = TXTextControl.BinaryStreamType.MSWord;

            TC1.Load(bhes, bt);*/

            TB_size.Text = "10";

            string dd = DateTime.Today.ToString("dd/MM/yyyy");

            if ((moqme != 5) && (moqme != 6) && (moqme != 7) && (moqme != 8) && (moqme != 10))
            {
                    TC1.AppendText("                                                           ");
                    Clipboard.SetImage(Image.FromFile("CGlogo.bmp"));
                    TC1.Paste();
            }

            if (moqme == 1)
            {
                if ((dd.Trim() == "") || (dw.Trim() == "") || (ew.Trim() == "") || (am.Trim() == "") || (aucs.Trim() == "")
                     || (auc.Trim() == "") || (aucts.Trim() == "") || (auce.Trim() == "") || (aucte.Trim() == "") || (adg.Trim() == "")
                        || (qw.Trim() == "") || (rw.Trim() == "") || (mw.Trim() == "") || (nw.Trim() == "") || (ow.Trim() == "")
                          || (pw.Trim() == "") || (ww.Trim() == "") || (xw.Trim() == ""))
                {
                    MessageBox.Show("გადაამოწმეთ ყველა აუცილებელი ცვლადი ველი");
                }
                else
                {
                    /*TC1.AppendText(" " + (char)(10) + (char)(13));*/
                    TC1.AppendText(" " + (char)(10));
                    TC1.AppendText("                                                 შეტყობინება აუქციონის დანიშვნის შესახებ " + (char)(10) + (char)(13));
                    TC1.AppendText("                                                                              " + dd + (char)(10) + (char)(13));
                    TC1.AppendText(dw + " -ს იურიდიულ დეპარტამენტი, " + (char)(10) + (char)(13));
                    TC1.AppendText("წარმომადგენელი:  " + ew + (char)(10) + (char)(13));
                    TC1.AppendText("შპს კონსალტინგ გრუპს გატყობინებთ, რომ საქმეზე N  " + am + "  დანიშნულია  " + auc + "  საჯარო აუქციონი" + (char)(10) + (char)(13));
                    TC1.AppendText("აუქციონის ჩატარების დრო:  " + aucs + " " + aucts + " საათიდან  " + auce + " " + aucte + " საათამდე" + (char)(13));
                    TC1.AppendText("აუქციონის ჩატარების ადგილი: " + adg + (char)(10));

                    if (auc == "პირველი")
                    {
                        TC1.AppendText("აუქციონზე უძრავი ნივთის საწყისი ფასი: " + aj + " ლარი" + (char)(10));
                    }

                    if (auc == "მეორე")
                    {
                        TC1.AppendText("აუქციონზე უძრავი ნივთის საწყისი ფასი: " + aj2 + " ლარი" + (char)(10));
                        ah1 = "0";
                    }

                    if (auc == "მესამე")
                    {
                        TC1.AppendText("აუქციონზე უძრავი ნივთის საწყისი ფასი: " + aj3 + " ლარი" + (char)(10));
                        ah1 = "0";
                    }

                    TC1.AppendText(" " + (char)(13));

                    TC1.AppendText("საწყისი ფასი შეადგენს კრედიტორის მოთხოვნის ოდენობისა და აუქციონის ხარჯების ჯამს, კერძოდ" + (char)(13));

                    if (Convert.ToDecimal(ah) != 0)
                    {
                        TC1.AppendText("მოთხოვნის ოდენობა: " + ahn + " აშშ დოლარი. 1 აშშ დოლარი = " + usd + " ლარი" + (char)(13));
                    }

                    if (Convert.ToDecimal(ah1) != 0)
                    {
                        TC1.AppendText("მოთხოვნის ოდენობა: " + ahn1 + " ევრო. 1 ევრო = " + eur + " ლარი" + (char)(13));
                    }

                    if ((Convert.ToDecimal(ah) == 0) && (Convert.ToDecimal(ah1) == 0))
                    {
                        TC1.AppendText("მოთხოვნის ოდენობა: " + ahn + " აშშ დოლარი. 1 აშშ დოლარი = " + usd + " ლარი" + (char)(13));
                    }

                    TC1.AppendText("მოთხოვნის ოდენობა: " + ahgn + " ლარი" + (char)(13));
                    TC1.AppendText("დღგ: " + vat + " ლარი" + (char)(13));

                    if (Convert.ToDecimal(av) == 590)
                    {
                        if (unda == 0)
                        {
                            TC1.AppendText("სპეციალისტის საზღაური : " + spr + " %, არანაკლებ 590 ლარი, რაც თანხობრივად შეადგენს " + pro + " ლარი" + (char)(10) + (char)(13));
                        }

                        if (unda == 1)
                        {
                            TC1.AppendText("სპეციალისტის საზღაური : " + spr + " %, არანაკლებ 590 ლარი, რაც თანხობრივად შეადგენს " + pro + " ლარი და მოიცავს " + auqt + " - ს მომსახურების საფასურს - " + auqc + " ლარს;" + (char)(10) + (char)(13));
                        }

                    }

                    if (Convert.ToDecimal(av) == 490)
                    {
                        TC1.AppendText("აუქციონის საზღაური : " + pro + " ლარი, პუბლიკაციის ხარჯი 97 ლარი, ასევე სპეციალისტის " + (char)(13));
                        TC1.AppendText("საზღაური 490 ლარი. მეორე აუქციონზე ხარჯებს დაემატება 217 ლარი, მესამე აუქციონზე ხარჯებს " + (char)(13));
                        TC1.AppendText("დაემატება  კვლავ 217 ლარი.  " + (char)(10) + (char)(13));
                    }

                    /*TC1.AppendText("უძრავი ნივთის საწყისი ფასი:  " + ah + "  აშშ დოლარი და  " + ahg + "  ლარი" + (char)(10) + (char)(13));*/

                    TC1.AppendText("იპოთეკის საგნის მესაკუთრე:  " + qw + " , პირადი ნომერი:  " + rw + " ;" + (char)(13));
                    TC1.AppendText("უძრავი ქონების რეკვიზიტები:  " + mw + " ;  საკადასტრო კოდი:  " + nw + " ;" + (char)(13));
                    TC1.AppendText("უძრავი ნივთის აღწერა:  " + ow + (char)(13));
                    TC1.AppendText("გარდამავალი უფლებები:  " + pw + (char)(10) + (char)(13));
                    TC1.AppendText("მსესხებელი: " + ww + " , პირადი ნომერი:   " + xw + " ;" + (char)(10) + (char)(13));
                    TC1.AppendText("დღგ: " + dgg + (char)(10) + (char)(13));
                    TC1.AppendText("აუქციონატორი:" + (char)(13));
                    TC1.AppendText("შპს „კონსალტინგ გრუპს“" + (char)(13));
                    //TC1.AppendText("ნინო არაბიძე" + (char)(10) + (char)(13));
                    TC1.AppendText("თამარ მაღალაშვილი" + (char)(10) + (char)(13));
                }
            }

            if (moqme == 2)
            {
                if (auc == "პირველი")
                {
                    auc = "პირველ";
                }

                /*TC1.AppendText(" " + (char)(10) + (char)(13));*/
                TC1.AppendText(" " + (char)(10));
                TC1.AppendText("                                                      გამაფრთხილებელი წერილი და განცხადება " + (char)(13));
                TC1.AppendText("                                           აუქციონის დანიშვნისა და ქონების რეალიზაციის შესახებ " + (char)(13));
                TC1.AppendText("                                                                       N " + am + (char)(10) + (char)(13));
                TC1.AppendText("                                                                       " + dd + (char)(10) + (char)(13));
                TC1.AppendText("სპეციალისტი:     შპს ”კონსალტინგ გრუპს”	ს/კ 404483536  " + (char)(13));
                //TC1.AppendText("დირექტორი:        ნინო არაბიძე" + (char)(13));
                TC1.AppendText("დირექტორი:        თამარ მაღალაშვილი" + (char)(13));
                TC1.AppendText("მისამართი:          ქ. თბილისი, ვ. პეტრიაშვილის N 10" + (char)(13));
                TC1.AppendText("ელ ფოსტა:           auction@cgg.ge" + (char)(10) + (char)(13));
                TC1.AppendText("მესაკუთრე:       " + qw + (char)(13));
                TC1.AppendText("პირადი N          " + rw + (char)(13));
                TC1.AppendText("მისამართი:       " + sw + (char)(13));
                if (tw.Trim() != "")
                {
                    TC1.AppendText("ალტ. მისამართი: " + tw + (char)(10));
                }
                if (uw.Trim() != "")
                {
                    TC1.AppendText("ალტ. მისამართი: " + uw + (char)(10));
                }
                if (vw.Trim() != "")
                {
                    TC1.AppendText("ალტ. მისამართი: " + vw + (char)(10));
                }

                TC1.AppendText(" " + (char)(13));

                /*TC1.AppendText("გაცნობეთ, რომ კრედიტორსა და მსესხებელს შორის დაიდო საკრედიტო ხელშეკრულება, რომელიც უზრუნველყოფილია უძრავ ქონებაზე რეგისტრირებული იპოთეკის უფლებით. მსესხებლის მიერ დარღვეულ იქნა საკრედიტო ხელშეკრულების პირობები, როს საფუძველზეც შეწყდა სასესხო ხელშეკრულება და მსესხებელს განესაზღვრა ვადა სასესხო დავალიანების სრულად დასაფარად, რაც მსესხებლის მხრიდან არ განხორციელებულა." + (char)(10) + (char)(13));*/

                TC1.AppendText("კრედიტორი: " + dw + (char)(13));
                TC1.AppendText("მესაკუთრე: " + qw + " , პირადი N: " + rw + (char)(13));
                TC1.AppendText("მოვალე (მსესხებელი): " + ww + " , პირადი N: " + xw + (char)(13));
                TC1.AppendText("იპოთეკის ხელშეკრულება: " + gw + " , თარიღი: " + hw + (char)(13));
                TC1.AppendText("ვალდებულების წარმოშობა: " + iw + (char)(13));
                TC1.AppendText("იპოთეკის რეკვიზიტები: მისამართი: " + mw + " , საკადასტრო კოდი: " + nw + (char)(13));
                TC1.AppendText("სასესხო დავალიანების ჯამური ოდენობა: " + kw + (char)(10) + (char)(13));
                TC1.AppendText("კრედიტორმა იპოთეკის ხელშეკრულებით მხარეთა შორის შეთანხმების საფუძველზე, განცხადებით მოგვმართა ჩვენ და დაგვავალა, როგორც სპეციალისტს, აუქციონის უზრუნველყოფა და უძრავი ქონების რეალიზაცია." + (char)(13));

                /*TC1.AppendText("ყოველივე ზემოაღნიშნულის საფუძველზე კრედიტორის დავალებით სპეციალისტი აცხადებს " + auc + " საჯარო აუქციონს მესაკუთრის  სახელზე რიცხულ, კრედიტორის სასარგებლოდ იპოთეკით დატვირთულ უძრავ ქონებაზე." + (char)(10) + (char)(13));*/

                TC1.AppendText("კრედიტორის დავალებით სპეციალისტი აცხადებს " + auc + " აუქციონს." + (char)(10) + (char)(13));

                TC1.AppendText("აუქციონის ჩატარების დრო:  " + aucs + " " + aucts + " საათიდან  " + auce + " " + aucte + " საათამდე" + (char)(13));
                TC1.AppendText("აუქციონის ჩატარების ადგილი: " + adg + (char)(10));

                if (auc == "პირველ")
                {
                    TC1.AppendText("აუქციონზე უძრავი ნივთის საწყისი ფასი: " + aj + " ლარი" + (char)(10));
                }

                if (auc == "მეორე")
                {
                    TC1.AppendText("აუქციონზე უძრავი ნივთის საწყისი ფასი: " + aj2 + " ლარი" + (char)(10));
                    ah1 = "0";
                }

                if (auc == "მესამე")
                {
                    TC1.AppendText("აუქციონზე უძრავი ნივთის საწყისი ფასი: " + aj3 + " ლარი" + (char)(10));
                    ah1 = "0";
                }

                TC1.AppendText(" " + (char)(13));

                /*TC1.AppendText("საწყისი ფასი შეადგენს კრედიტორის მოთხოვნის ოდენობისა და აუქციონის ხარჯების ჯამს, კერძოდ" + (char)(13));

                if (Convert.ToDecimal(ah) != 0)
                {
                    TC1.AppendText("მოთხოვნის ოდენობა: " + ahn + " აშშ დოლარი. 1 აშშ დოლარი = " + usd + " ლარი" + (char)(13));
                }

                if (Convert.ToDecimal(ah1) != 0)
                {
                    TC1.AppendText("მოთხოვნის ოდენობა: " + ahn1 + " ევრო. 1 ევრო = " + eur + " ლარი" + (char)(13));
                }

                if ((Convert.ToDecimal(ah) == 0) && (Convert.ToDecimal(ah1) == 0))
                {
                    TC1.AppendText("მოთხოვნის ოდენობა: " + ahn + " აშშ დოლარი. 1 აშშ დოლარი = " + usd + " ლარი" + (char)(13));
                }

                TC1.AppendText("მოთხოვნის ოდენობა: " + ahgn + " ლარი" + (char)(13));

                TC1.AppendText("დღგ: " + vat + " ლარი" + (char)(13));

                if (Convert.ToDecimal(av) == 590)
                {
                    if (unda == 0)
                    {
                        TC1.AppendText("სპეციალისტის საზღაური : " + spr + " %, არანაკლებ 590 ლარი, რაც თანხობრივად შეადგენს " + pro + " ლარი" + (char)(10) + (char)(13));
                    }

                    if (unda == 1)
                    {
                        TC1.AppendText("სპეციალისტის საზღაური : " + spr + " %, არანაკლებ 590 ლარი, რაც თანხობრივად შეადგენს " + pro + " ლარი და მოიცავს " + auqt + " - ს მომსახურების საფასურს - " + auqc + " ლარს;" + (char)(10) + (char)(13));
                    }

                }*/

                if (Convert.ToDecimal(av) == 490)
                {
                    TC1.AppendText("აუქციონის საზღაური : " + pro + " ლარი, პუბლიკაციის ხარჯი 97 ლარი, ასევე სპეციალისტის " + (char)(13));
                    TC1.AppendText("საზღაური 490 ლარი. მეორე აუქციონზე ხარჯებს დაემატება 217 ლარი, მესამე აუქციონზე ხარჯებს " + (char)(13));
                    TC1.AppendText("დაემატება  კვლავ 217 ლარი.  " + (char)(13));
                }

                TC1.AppendText("ქონების რეალიზაციის შემთხვევაში, დღგ-ს თანხა (არსებობის შემთხვევაში) და აუქციონის საფასური დაითვლება რეალიზაციის თანხიდან." + (char)(10) + (char)(13));

                /*TC1.AppendText("უძრავი ნივთის საწყისი ფასი:  " + ah + "  აშშ დოლარი და  " + ahg + " ლარი" + (char)(13));*/

                TC1.AppendText("უძრავი ნივთის აღწერა:  " + ow + (char)(13));
                TC1.AppendText("გარდამავალი უფლებები:  " + pw + (char)(13));
                TC1.AppendText("აუქციონის პირობები:  " + (char)(13));

                if (cw == "STATIONAR")
                {
                    TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს." + (char)(13));
                    TC1.AppendText("ბ) აუქციონში მონაწილეობის ყველა მსურველმა აუქციონატორთან უნდა წარმოადგინოს საბანკო გარანტია, გაცემული შპს „კონსალტინგ გრუპსის“ (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის თარიღიდან 15 საბანკო დღე ან  საგარანტიო თანხის ჩარიცხვა უნდა მოხდეს შპს კონსალტინგ გრუპს-ის ანგარიშზე ა) ნებისმიერი ბანკის მეშვეობით და სპეციალური დანიშნულების მითითებით; ბ) საბანკო ანგარიშიდან გადმორიცხვით; პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას ან საგარანტიო თანხის გადახდის ქვითარს აუქციონის დაწყებამდე, ეკრძალება აუქციონში მონაწილეობა. " + (char)(13));
                    TC1.AppendText("გ) აუქციონი მიმდინარეობს მონაწილეთათვის სასურველი ნებისმიერი ბიჯის ოდენობით. შემოთავაზებული ბიჯი შეიძლება იყოს მხოლოდ მზარდი. აუქციონი გრძელდება ბოლო შემოთავაზებამდე. აუქციონზე გამარჯვებულია ის პირი, ვინც უფრო მაღალ ფასს შესთავაზებს." + (char)(13));
                    TC1.AppendText("დ) აუქციონში გამარჯვებულმა აუქციონის თანხა სრულად უნდა შეიტანოს სპეციალისტის ანგარიშზე აუქციონის დასრულების დღიდან 7 საბანკო დღის მანძილზე, წინააღმდეგ შემთხვევაში იგი კარგავს მის მიერ საბანკო გარანტიის სახით წარმოდგენილ თანხას და უქმდება მისი, როგორც აუქციონზე გამარჯვებულის სტატუსი. " + (char)(13));
                    TC1.AppendText("ე) აუქციონში გამარჯვებულის მიერ შესაბამის ვადაში აუქციონის თანხის სრულად გადახდის შემთხვევაში შპს ”კონსალტინგ გრუპს” მასზე გადასცემს განკარგულებას ქონებაზე საკუთრების უფლების მოპოვების შესახებ." + (char)(13));
                    TC1.AppendText("ვ) იმ შემთხვევაში თუ მიწის ნაკვეთის (ქონების) სტატუსი რეალიზაციის მომენტისათვის წარმოადგენს სასოფლო-სამეურნეოს, მონაწილე პირი უნდა აკმაყოფილებდეს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს; ასეთ შემთხვევაში აუქციონში მონაწილეობის მსურველმა უნდა წარადგინოს იმის დამადასტურებელი ინფორმაცია, რომ იგი აკმაყოფილებს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს;" + (char)(13));
                    TC1.AppendText(" " + (char)(13));
                    TC1.AppendText("ყურადღება: ქონების რეალიზაცია შესაძლებელია თავიდან იქნას აცილებული, თუ ნებისმიერი პირი (მათ შორის მსესხებელი, უძრავი ქონების მესაკუთრე ან/და სხვა დაინტერესებული პირი) აუქციონის დაწყებამდე განახორციელებს მსესხებლის მიერ კრედიტორს მიმართ არსებული სასესხო და მასთან დაკავშირებული ხარჯების დავალიანების სრულად დაფარვას.ყველა პირი, რომელსაც აქვს რაიმე სახის უფლებები უძრავ ქონებაზე, ვალდებულია ამ უფლებათა დამადასტურებელი მტკიცებულებანი წარმოადგინოს აუქციონის დაწყებამდე წერილობითი ფორმით სპეციალისტთან." + (char)(13));
                }
                else
                {
                    if (auct == "0")
                    {

                        if (liv == "LIVO")
                        {
                            TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს. " + (char)(13));
                            TC1.AppendText("ბ) Auction.livo.ge აუქციონში მონაწილეობის ყველა მსურველმა უნდა გაიაროს რეგისტრაცია და გადაიხადოს საგარანტიო თანხა პერსონალური ბალანსის მეშვეობით. მომხმარებელს პერსონალურ ბალანსზე თანხის შეტანა შეუძლია ვებ-გვერდზე მითითებულ კომპანიის ანგარიშზე: ა) ნებისმიერი ბანკის მეშვეობით, სპეციალური დანიშნულების მითითებით; ბ) საბანკო ანგარიშიდან გადმორიცხვით; გ) ვებგვერდზე პლასტიკური ბარათის მონაცემების შეყვანით.  " + (char)(13));
                        }
                        else
                        {
                            TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს. " + (char)(13));
                            TC1.AppendText("ბ) eAuction.ge აუქციონში მონაწილეობის ყველა მსურველმა უნდა გაიაროს რეგისტრაცია და გადაიხადოს საგარანტიო თანხა შემდეგი ფორმით : " + (char)(13));
                            TC1.AppendText("აა. ნაღდი ანგარიშსწორებით ლიბერთი ბანკში განაცხადის ნომრითა და პირადობის დამადასტურებელი საბუთით " + (char)(13));
                            TC1.AppendText("ბბ. უნაღდო ანგარიშსწორებით eAuction.ge-ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე " + (char)(13));
                            TC1.AppendText("გგ. eAuction.ge-ს ვებ - გვერდიდან პლასტიკური ბარათით " + (char)(13));
                            TC1.AppendText("დდ. ელექტრონული საბანკო გარანტიის აქტივაციით. გაცემული კრედიტორს (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის დასრულების თარიღიდან 15 საბანკო დღე. პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას აუქციონის მითითებული ფორმით, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));
                        }

                        /*TC1.AppendText("1. ნაღდი ანგარიშსწორებით ლიბერთი ბანკში განაცხადის ნომრითა და პირადობის დამადასტურებელი საბუთით " + (char)(13));

                        if (liv == "LIVO")
                        {
                            TC1.AppendText("2. უნაღდო ანგარიშსწორებით auction.livo.ge-ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე " + (char)(13));
                        }
                        else
                        {
                            TC1.AppendText("2. უნაღდო ანგარიშსწორებით eAuction.ge-ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე " + (char)(13));
                        }

                        if (liv == "LIVO")
                        {
                            TC1.AppendText("3. auction.livo.ge-ს ვებ - გვერდიდან პლასტიკური ბარათით" + (char)(13));
                        }
                        else
                        {
                            TC1.AppendText("3. eAuction.ge-ს ვებ - გვერდიდან პლასტიკური ბარათით" + (char)(13));
                        }
                        TC1.AppendText("4. ელექტრონული საბანკო გარანტიის აქტივაციით. გაცემული კრედიტორს (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის დასრულების თარიღიდან 15 საბანკო დღე. პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას აუქციონის მითითებული ფორმით, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));*/

                        TC1.AppendText("გ) იმ შემთხევაში, თუ აუქციონზე საწყისი ფასი არის 100 000 ლარამდე, ბიჯის ოდენობა განისაზღვრება - 100 ლარის ოდენობით; 100 000 ლარიდან 500 000 ლარის ჩათვლით  - 500 ლარის ოდენობით; ხოლო, 500 000 ლარზე მეტის შემთხვევაში - 1000 ლარის ოდენობით; აუქციონი გრძელდება ბოლო შემოთავაზებამდე. აუქციონზე გამარჯვებულია ის პირი, ვინც უფრო მაღალ ფასს შესთავაზებს." + (char)(13));
                        TC1.AppendText("დ) აუქციონში გამარჯვებულმა აუქციონის თანხა სრულად უნდა შეიტანოს სპეცილისტის სადეპოზიტო ანგარიშზე აუქციონის დასრულების დღიდან 7 საბანკო დღის მანძილზე. წინააღმდეგ შემთხვევაში იგი კარგავს მის მიერ საბანკო გარანტიის სახით წარმოდგენილ თანხას და უქმდება მისი, როგორც აუქციონზე გამარჯვებულის სტატუსი." + (char)(13));
                        TC1.AppendText("ე) აუქციონში გამარჯვებულის მიერ შესაბამის ვადაში აუქციონის თანხის სრულად გადახდის შემთხვევაში შპს ”კონსალტინგ გრუპს” მასზე გადასცემს განკარგულებას ქონებაზე საკუთრების უფლების მოპოვების შესახებ." + (char)(13));
                        TC1.AppendText("ვ) იმ შემთხვევაში თუ მიწის ნაკვეთის (ქონების) სტატუსი რეალიზაციის მომენტისათვის წარმოადგენს სასოფლო-სამეურნეოს, მონაწილე პირი უნდა აკმაყოფილებდეს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს; ასეთ შემთხვევაში აუქციონში მონაწილეობის მსურველმა უნდა წარადგინოს იმის დამადასტურებელი ინფორმაცია, რომ იგი აკმაყოფილებს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს;" + (char)(10) + (char)(13));
                    }
                    else
                    {
                        TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს. " + (char)(13));
                        TC1.AppendText("ბ) აუქციონში მონაწილეობის ყველა მსურველმა უნდა გაიაროს რეგისტრაცია და გადაიხადოს საგარანტიო თანხა შემდეგი ფორმით : " + (char)(13));
                        TC1.AppendText("1. ნაღდი ანგარიშსწორებით ნებისმიერ ბანკში განაცხადის ნომრითა და პირადობის დამადასტურებელი საბუთით " + (char)(13));
                        TC1.AppendText("2. უნაღდო ანგარიშსწორებით www.auctionhouse.ge -ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე; " + (char)(13));
                        TC1.AppendText("3. www.auctionhouse.ge -ს ვებ - გვერდიდან პლასტიკური ბარათით" + (char)(13));
                        TC1.AppendText("4. ელექტრონული საბანკო გარანტიის აქტივაციით. გაცემული კრედიტორს (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის დასრულების თარიღიდან 15 საბანკო დღე. პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას აუქციონის მითითებული ფორმით, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));
                        TC1.AppendText("გ) იმ შემთხევაში, თუ აუქციონზე საწყისი ფასი არის 100 000 ლარამდე, ბიჯის ოდენობა განისაზღვრება - 100 ლარის ოდენობით; 100 000 ლარიდან 500 000 ლარის ჩათვლით  - 500 ლარის ოდენობით; ხოლო, 500 000 ლარზე მეტის შემთხვევაში - 1000 ლარის ოდენობით; აუქციონი გრძელდება ბოლო შემოთავაზებამდე. აუქციონზე გამარჯვებულია ის პირი, ვინც უფრო მაღალ ფასს შესთავაზებს." + (char)(13));
                        TC1.AppendText("დ) აუქციონში გამარჯვებულმა აუქციონის თანხა სრულად უნდა შეიტანოს სპეცილისტის სადეპოზიტო ანგარიშზე აუქციონის დასრულების დღიდან 2 საბანკო დღის მანძილზე. წინააღმდეგ შემთხვევაში იგი კარგავს მის მიერ საბანკო გარანტიის სახით წარმოდგენილ თანხას და უქმდება მისი, როგორც აუქციონზე გამარჯვებულის სტატუსი." + (char)(13));
                        TC1.AppendText("ე) აუქციონში გამარჯვებულის მიერ შესაბამის ვადაში აუქციონის თანხის სრულად გადახდის შემთხვევაში შპს ”კონსალტინგ გრუპს” მასზე გადასცემს განკარგულებას ქონებაზე საკუთრების უფლების მოპოვების შესახებ." + (char)(13));
                        TC1.AppendText("ვ) იმ შემთხვევაში თუ მიწის ნაკვეთის (ქონების) სტატუსი რეალიზაციის მომენტისათვის წარმოადგენს სასოფლო-სამეურნეოს, მონაწილე პირი უნდა აკმაყოფილებდეს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს; ასეთ შემთხვევაში აუქციონში მონაწილეობის მსურველმა უნდა წარადგინოს იმის დამადასტურებელი ინფორმაცია, რომ იგი აკმაყოფილებს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს;" + (char)(10) + (char)(13));
                    }

                    TC1.AppendText("ყურადღება: ქონების რეალიზაცია შესაძლებელია თავიდან იქნას აცილებული, თუ ნებისმიერი პირი (მათ შორის მსესხებელი, უძრავი ქონების მესაკუთრე ან/და სხვა დაინტერესებული პირი) აუქციონის დაწყებამდე განახორციელებს მსესხებლის მიერ კრედიტორს მიმართ არსებული სასესხო და მასთან დაკავშირებული ხარჯების დავალიანების სრულად დაფარვას." + (char)(13));
                    TC1.AppendText("ყველა პირი, რომელსაც აქვს რაიმე სახის უფლებები უძრავ ქონებაზე, ვალდებულია ამ უფლებათა დამადასტურებელი მტკიცებულებანი წარმოადგინოს აუქციონის დაწყებამდე წერილობითი ფორმით სპეციალისტთან." + (char)(10) + (char)(13));
                    /*TC1.AppendText("კრედიტორს მოთხოვნა უცხოურ ვალუტაში აუნაზღაურდება აუქციონის დასრულების დღის კურსით." + (char)(13));
                    TC1.AppendText("აუქციონის შეწყვეტის შემთხვევაში შეწყვეტის საკომისიო შეადგენს აუქციონის საწყისის ფასის  0.59 პროცენტს;" + (char)(10) + (char)(13));*/

                    TC1.AppendText("სპეციალისტი:   შპს ”კონსალტინგ გრუპს”, ს/კ 404483536  " + (char)(13));
                    //TC1.AppendText("დირექტორი       ნინო არაბიძე" + (char)(10) + (char)(13));
                    TC1.AppendText("დირექტორი       თამარ მაღალაშვილი" + (char)(10) + (char)(13));
                }
            }

            if (moqme == 3)
            {
                if (auc == "პირველი")
                {
                    auc = "პირველ";
                }

                /*TC1.AppendText(" " + (char)(10) + (char)(13));*/
                TC1.AppendText(" " + (char)(10));
                TC1.AppendText("                                                      გამაფრთხილებელი წერილი და განცხადება " + (char)(13));
                TC1.AppendText("                                           აუქციონის დანიშვნისა და ქონების რეალიზაციის შესახებ " + (char)(13));
                TC1.AppendText("                                                                       N " + am + (char)(10) + (char)(13));
                TC1.AppendText("                                                                       " + dd + (char)(10) + (char)(13));

                TC1.AppendText("სპეციალისტი:     შპს ”კონსალტინგ გრუპს”	ს/კ 404483536  " + (char)(13));
                //TC1.AppendText("დირექტორი:        ნინო არაბიძე" + (char)(13));
                TC1.AppendText("დირექტორი:        თამარ მაღალაშვილი" + (char)(13));
                TC1.AppendText("მისამართი:          ქ. თბილისი, ვ. პეტრიაშვილის N 10" + (char)(13));
                TC1.AppendText("ელ ფოსტა:           auction@cgg.ge" + (char)(10) + (char)(13));
                TC1.AppendText("მსესხებელი:      " + ww + (char)(13));
                TC1.AppendText("პირადი N          " + xw + (char)(13));
                TC1.AppendText("მისამართი:       " + yw + (char)(10) + (char)(13));

                /*TC1.AppendText("გაცნობეთ, რომ კრედიტორსა და მსესხებელს შორის დაიდო საკრედიტო ხელშეკრულება, რომელიც უზრუნველყოფილია უძრავ ქონებაზე რეგისტრირებული იპოთეკის უფლებით. მსესხებლის მიერ დარღვეულ იქნა საკრედიტო ხელშეკრულების პირობები, როს საფუძველზეც შეწყდა სასესხო ხელშეკრულება და მსესხებელს განესაზღვრა ვადა სასესხო დავალიანების სრულად დასაფარად, რაც მსესხებლის მხრიდან არ განხორციელებულა." + (char)(10) + (char)(13));*/

                TC1.AppendText("კრედიტორი: " + dw + (char)(13));
                TC1.AppendText("მესაკუთრე: " + qw + " , პირადი N: " + rw + (char)(13));
                TC1.AppendText("მოვალე (მსესხებელი): " + ww + " , პირადი N: " + xw + (char)(13));
                TC1.AppendText("იპოთეკის ხელშეკრულება: " + gw + " , თარიღი: " + hw + (char)(13));
                TC1.AppendText("ვალდებულების წარმოშობა: " + iw + (char)(13));
                TC1.AppendText("იპოთეკის რეკვიზიტები: მისამართი: " + mw + " , საკადასტრო კოდი: " + nw + (char)(13));
                TC1.AppendText("სასესხო დავალიანების ჯამური ოდენობა: " + kw + (char)(10) + (char)(13));
                TC1.AppendText("კრედიტორმა იპოთეკის ხელშეკრულებით მხარეთა შორის შეთანხმების საფუძველზე, განცხადებით მოგვმართა ჩვენ და დაგვავალა, როგორც სპეციალისტს, აუქციონის უზრუნველყოფა და უძრავი ქონების რეალიზაცია." + (char)(13));
                TC1.AppendText("კრედიტორის დავალებით სპეციალისტი აცხადებს " + auc + " აუქციონს." + (char)(10) + (char)(13));
                TC1.AppendText("აუქციონის ჩატარების დრო:  " + aucs + " " + aucts + " საათიდან  " + auce + " " + aucte + " საათამდე" + (char)(13));
                TC1.AppendText("აუქციონის ჩატარების ადგილი: " + adg + (char)(10));

                if (auc == "პირველ")
                {
                    TC1.AppendText("აუქციონზე უძრავი ნივთის საწყისი ფასი: " + aj + " ლარი" + (char)(10));
                }

                if (auc == "მეორე")
                {
                    TC1.AppendText("აუქციონზე უძრავი ნივთის საწყისი ფასი: " + aj2 + " ლარი" + (char)(10));
                    ah1 = "0";
                }

                if (auc == "მესამე")
                {
                    TC1.AppendText("აუქციონზე უძრავი ნივთის საწყისი ფასი: " + aj3 + " ლარი" + (char)(10));
                    ah1 = "0";
                }

                TC1.AppendText(" " + (char)(13));

                /*TC1.AppendText("საწყისი ფასი შეადგენს კრედიტორის მოთხოვნის ოდენობისა და აუქციონის ხარჯების ჯამს, კერძოდ" + (char)(13));

                if (Convert.ToDecimal(ah) != 0)
                {
                    TC1.AppendText("მოთხოვნის ოდენობა: " + ahn + " აშშ დოლარი. 1 აშშ დოლარი = " + usd + " ლარი" + (char)(13));
                }

                if (Convert.ToDecimal(ah1) != 0)
                {
                    TC1.AppendText("მოთხოვნის ოდენობა: " + ahn1 + " ევრო. 1 ევრო = " + eur + " ლარი" + (char)(13));
                }

                if ((Convert.ToDecimal(ah) == 0) && (Convert.ToDecimal(ah1) == 0))
                {
                    TC1.AppendText("მოთხოვნის ოდენობა: " + ahn + " აშშ დოლარი. 1 აშშ დოლარი = " + usd + " ლარი" + (char)(13));
                }

                TC1.AppendText("მოთხოვნის ოდენობა: " + ahgn + " ლარი" + (char)(13));

                TC1.AppendText("დღგ: " + vat + " ლარი" + (char)(13));

                if (Convert.ToDecimal(av) == 590)
                {
                    if (unda == 0)
                    {
                        TC1.AppendText("სპეციალისტის საზღაური : " + spr + " %, არანაკლებ 590 ლარი, რაც თანხობრივად შეადგენს " + pro + " ლარი" + (char)(10) + (char)(13));
                    }

                    if (unda == 1)
                    {
                        TC1.AppendText("სპეციალისტის საზღაური : " + spr + " %, არანაკლებ 590 ლარი, რაც თანხობრივად შეადგენს " + pro + " ლარი და მოიცავს " + auqt + " - ს მომსახურების საფასურს - " + auqc + " ლარს;" + (char)(10) + (char)(13));
                    }

                }*/

                if (Convert.ToDecimal(av) == 490)
                {
                    TC1.AppendText("აუქციონის საზღაური : " + pro + " ლარი, პუბლიკაციის ხარჯი 97 ლარი, ასევე სპეციალისტის " + (char)(13));
                    TC1.AppendText("საზღაური 490 ლარი. მეორე აუქციონზე ხარჯებს დაემატება 217 ლარი, მესამე აუქციონზე ხარჯებს " + (char)(13));
                    TC1.AppendText("დაემატება  კვლავ 217 ლარი.  " + (char)(13));
                }

                /*TC1.AppendText("უძრავი ნივთის საწყისი ფასი:  " + ah + "  აშშ დოლარი და  " + ahg + "  ლარი" + (char)(13));*/

                TC1.AppendText("ქონების რეალიზაციის შემთხვევაში, დღგ-ს თანხა (არსებობის შემთხვევაში) და აუქციონის საფასური დაითვლება რეალიზაციის თანხიდან." + (char)(10) + (char)(13));
                TC1.AppendText("უძრავი ნივთის აღწერა:  " + ow + (char)(13));
                TC1.AppendText("გარდამავალი უფლებები:  " + pw + (char)(13));
                TC1.AppendText("აუქციონის პირობები:  " + (char)(13));

                if (cw == "STATIONAR")
                {
                    TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს." + (char)(13));
                    TC1.AppendText("ბ) აუქციონში მონაწილეობის ყველა მსურველმა აუქციონატორთან უნდა წარმოადგინოს საბანკო გარანტია, გაცემული შპს „კონსალტინგ გრუპსის“ (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის თარიღიდან 15 საბანკო დღე ან  საგარანტიო თანხის ჩარიცხვა უნდა მოხდეს შპს კონსალტინგ გრუპს-ის ანგარიშზე ა) ნებისმიერი ბანკის მეშვეობით და სპეციალური დანიშნულების მითითებით; ბ) საბანკო ანგარიშიდან გადმორიცხვით; პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას ან საგარანტიო თანხის გადახდის ქვითარს აუქციონის დაწყებამდე, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));
                    TC1.AppendText("გ) აუქციონი მიმდინარეობს მონაწილეთათვის სასურველი ნებისმიერი ბიჯის ოდენობით. შემოთავაზებული ბიჯი შეიძლება იყოს მხოლოდ მზარდი. აუქციონი გრძელდება ბოლო შემოთავაზებამდე. აუქციონზე გამარჯვებულია ის პირი, ვინც უფრო მაღალ ფასს შესთავაზებს." + (char)(13));
                    TC1.AppendText("დ) აუქციონში გამარჯვებულმა აუქციონის თანხა სრულად უნდა შეიტანოს სპეციალისტის ანგარიშზე აუქციონის დასრულების დღიდან 7 საბანკო დღის მანძილზე, წინააღმდეგ შემთხვევაში იგი კარგავს მის მიერ საბანკო გარანტიის სახით წარმოდგენილ თანხას და უქმდება მისი, როგორც აუქციონზე გამარჯვებულის სტატუსი." + (char)(13));
                    TC1.AppendText("ე) აუქციონში გამარჯვებულის მიერ შესაბამის ვადაში აუქციონის თანხის სრულად გადახდის შემთხვევაში შპს ”კონსალტინგ გრუპს” მასზე გადასცემს განკარგულებას ქონებაზე საკუთრების უფლების მოპოვების შესახებ." + (char)(13));
                    TC1.AppendText("ვ) იმ შემთხვევაში თუ მიწის ნაკვეთის (ქონების) სტატუსი რეალიზაციის მომენტისათვის წარმოადგენს სასოფლო-სამეურნეოს, მონაწილე პირი უნდა აკმაყოფილებდეს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს; ასეთ შემთხვევაში აუქციონში მონაწილეობის მსურველმა უნდა წარადგინოს იმის დამადასტურებელი ინფორმაცია, რომ იგი აკმაყოფილებს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს;" + (char)(13));
                    TC1.AppendText(" " + (char)(13));
                    TC1.AppendText("ყურადღება: ქონების რეალიზაცია შესაძლებელია თავიდან იქნას აცილებული, თუ ნებისმიერი პირი (მათ შორის მსესხებელი, უძრავი ქონების მესაკუთრე ან/და სხვა დაინტერესებული პირი) აუქციონის დაწყებამდე განახორციელებს მსესხებლის მიერ კრედიტორს მიმართ არსებული სასესხო და მასთან დაკავშირებული ხარჯების დავალიანების სრულად დაფარვას.ყველა პირი, რომელსაც აქვს რაიმე სახის უფლებები უძრავ ქონებაზე, ვალდებულია ამ უფლებათა დამადასტურებელი მტკიცებულებანი წარმოადგინოს აუქციონის დაწყებამდე წერილობითი ფორმით სპეციალისტთან." + (char)(13));
                }
                else
                {
                    if (auct == "0")
                    {

                        if (liv == "LIVO")
                        {
                            TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს. " + (char)(13));
                            TC1.AppendText("ბ) Auction.livo.ge აუქციონში მონაწილეობის ყველა მსურველმა უნდა გაიაროს რეგისტრაცია და გადაიხადოს საგარანტიო თანხა პერსონალური ბალანსის მეშვეობით. მომხმარებელს პერსონალურ ბალანსზე თანხის შეტანა შეუძლია ვებ-გვერდზე მითითებულ კომპანიის ანგარიშზე: ა) ნებისმიერი ბანკის მეშვეობით, სპეციალური დანიშნულების მითითებით; ბ) საბანკო ანგარიშიდან გადმორიცხვით; გ) ვებგვერდზე პლასტიკური ბარათის მონაცემების შეყვანით.  " + (char)(13));
                        }
                        else
                        {
                            TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს. " + (char)(13));
                            TC1.AppendText("ბ) eAuction.ge აუქციონში მონაწილეობის ყველა მსურველმა უნდა გაიაროს რეგისტრაცია და გადაიხადოს საგარანტიო თანხა შემდეგი ფორმით : " + (char)(13));
                            TC1.AppendText("აა. ნაღდი ანგარიშსწორებით ლიბერთი ბანკში განაცხადის ნომრითა და პირადობის დამადასტურებელი საბუთით " + (char)(13));
                            TC1.AppendText("ბბ. უნაღდო ანგარიშსწორებით eAuction.ge-ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე " + (char)(13));
                            TC1.AppendText("გგ. eAuction.ge-ს ვებ - გვერდიდან პლასტიკური ბარათით " + (char)(13));
                            TC1.AppendText("დდ. ელექტრონული საბანკო გარანტიის აქტივაციით. გაცემული კრედიტორს (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის დასრულების თარიღიდან 15 საბანკო დღე. პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას აუქციონის მითითებული ფორმით, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));
                        }

                        /*TC1.AppendText("1. ნაღდი ანგარიშსწორებით ლიბერთი ბანკში განაცხადის ნომრითა და პირადობის დამადასტურებელი საბუთით " + (char)(13));

                        if (liv == "LIVO")
                        {
                            TC1.AppendText("2. უნაღდო ანგარიშსწორებით auction.livo.ge-ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე " + (char)(13));
                        }
                        else
                        {
                            TC1.AppendText("2. უნაღდო ანგარიშსწორებით eAuction.ge-ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე " + (char)(13));
                        }

                        if (liv == "LIVO")
                        {
                            TC1.AppendText("3. auction.livo.ge-ს ვებ - გვერდიდან პლასტიკური ბარათით" + (char)(13));
                        }
                        else
                        {
                            TC1.AppendText("3. eAuction.ge-ს ვებ - გვერდიდან პლასტიკური ბარათით" + (char)(13));
                        }
                        TC1.AppendText("4. ელექტრონული საბანკო გარანტიის აქტივაციით. გაცემული კრედიტორს (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის დასრულების თარიღიდან 15 საბანკო დღე. პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას აუქციონის მითითებული ფორმით, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));*/
                        TC1.AppendText("გ) იმ შემთხევაში, თუ აუქციონზე საწყისი ფასი არის 100 000 ლარამდე, ბიჯის ოდენობა განისაზღვრება - 100 ლარის ოდენობით; 100 000 ლარიდან 500 000 ლარის ჩათვლით  - 500 ლარის ოდენობით; ხოლო, 500 000 ლარზე მეტის შემთხვევაში - 1000 ლარის ოდენობით; აუქციონი გრძელდება ბოლო შემოთავაზებამდე. აუქციონზე გამარჯვებულია ის პირი, ვინც უფრო მაღალ ფასს შესთავაზებს." + (char)(13));
                        TC1.AppendText("დ) აუქციონში გამარჯვებულმა აუქციონის თანხა სრულად უნდა შეიტანოს სპეცილისტის სადეპოზიტო ანგარიშზე აუქციონის დასრულების დღიდან 7 საბანკო დღის მანძილზე. წინააღმდეგ შემთხვევაში იგი კარგავს მის მიერ საბანკო გარანტიის სახით წარმოდგენილ თანხას და უქმდება მისი, როგორც აუქციონზე გამარჯვებულის სტატუსი." + (char)(13));
                        TC1.AppendText("ე) აუქციონში გამარჯვებულის მიერ შესაბამის ვადაში აუქციონის თანხის სრულად გადახდის შემთხვევაში შპს ”კონსალტინგ გრუპს” მასზე გადასცემს განკარგულებას ქონებაზე საკუთრების უფლების მოპოვების შესახებ." + (char)(13));
                        TC1.AppendText("ვ) იმ შემთხვევაში თუ მიწის ნაკვეთის (ქონების) სტატუსი რეალიზაციის მომენტისათვის წარმოადგენს სასოფლო-სამეურნეოს, მონაწილე პირი უნდა აკმაყოფილებდეს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს; ასეთ შემთხვევაში აუქციონში მონაწილეობის მსურველმა უნდა წარადგინოს იმის დამადასტურებელი ინფორმაცია, რომ იგი აკმაყოფილებს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს;" + (char)(10) + (char)(13));
                    }
                    else
                    {
                        TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს. " + (char)(13));
                        TC1.AppendText("ბ) აუქციონში მონაწილეობის ყველა მსურველმა უნდა გაიაროს რეგისტრაცია და გადაიხადოს საგარანტიო თანხა შემდეგი ფორმით : " + (char)(13));
                        TC1.AppendText("1. ნაღდი ანგარიშსწორებით ნებისმიერ ბანკში განაცხადის ნომრითა და პირადობის დამადასტურებელი საბუთით " + (char)(13));
                        TC1.AppendText("2. უნაღდო ანგარიშსწორებით www.auctionhouse.ge -ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე; " + (char)(13));
                        TC1.AppendText("3. www.auctionhouse.ge -ს ვებ - გვერდიდან პლასტიკური ბარათით" + (char)(13));
                        TC1.AppendText("4. ელექტრონული საბანკო გარანტიის აქტივაციით. გაცემული კრედიტორს (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის დასრულების თარიღიდან 15 საბანკო დღე. პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას აუქციონის მითითებული ფორმით, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));
                        TC1.AppendText("გ) იმ შემთხევაში, თუ აუქციონზე საწყისი ფასი არის 100 000 ლარამდე, ბიჯის ოდენობა განისაზღვრება - 100 ლარის ოდენობით; 100 000 ლარიდან 500 000 ლარის ჩათვლით  - 500 ლარის ოდენობით; ხოლო, 500 000 ლარზე მეტის შემთხვევაში - 1000 ლარის ოდენობით; აუქციონი გრძელდება ბოლო შემოთავაზებამდე. აუქციონზე გამარჯვებულია ის პირი, ვინც უფრო მაღალ ფასს შესთავაზებს." + (char)(13));
                        TC1.AppendText("დ) აუქციონში გამარჯვებულმა აუქციონის თანხა სრულად უნდა შეიტანოს სპეცილისტის სადეპოზიტო ანგარიშზე აუქციონის დასრულების დღიდან 2 საბანკო დღის მანძილზე. წინააღმდეგ შემთხვევაში იგი კარგავს მის მიერ საბანკო გარანტიის სახით წარმოდგენილ თანხას და უქმდება მისი, როგორც აუქციონზე გამარჯვებულის სტატუსი." + (char)(13));
                        TC1.AppendText("ე) აუქციონში გამარჯვებულის მიერ შესაბამის ვადაში აუქციონის თანხის სრულად გადახდის შემთხვევაში შპს ”კონსალტინგ გრუპს” მასზე გადასცემს განკარგულებას ქონებაზე საკუთრების უფლების მოპოვების შესახებ." + (char)(13));
                        TC1.AppendText("ვ) იმ შემთხვევაში თუ მიწის ნაკვეთის (ქონების) სტატუსი რეალიზაციის მომენტისათვის წარმოადგენს სასოფლო-სამეურნეოს, მონაწილე პირი უნდა აკმაყოფილებდეს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს; ასეთ შემთხვევაში აუქციონში მონაწილეობის მსურველმა უნდა წარადგინოს იმის დამადასტურებელი ინფორმაცია, რომ იგი აკმაყოფილებს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს;" + (char)(10) + (char)(13));
                    }
                }

                TC1.AppendText("ყურადღება: ქონების რეალიზაცია შესაძლებელია თავიდან იქნას აცილებული, თუ ნებისმიერი პირი (მათ შორის მსესხებელი, უძრავი ქონების მესაკუთრე ან/და სხვა დაინტერესებული პირი) აუქციონის დაწყებამდე განახორციელებს მსესხებლის მიერ კრედიტორის მიმართ არსებული სასესხო და მასთან დაკავშირებული ხარჯების დავალიანების სრულად დაფარვას." + (char)(13));
                TC1.AppendText("ყველა პირი, რომელსაც აქვს რაიმე სახის უფლებები უძრავ ქონებაზე, ვალდებულია ამ უფლებათა დამადასტურებელი მტკიცებულებანი წარმოადგინოს აუქციონის დაწყებამდე წერილობითი ფორმით სპეციალისტთან." + (char)(10) + (char)(13));
                /*TC1.AppendText("კრედიტორს მოთხოვნა უცხოურ ვალუტაში აუნაზღაურდება აუქციონის დასრულების დღის კურსით." + (char)(13));
                TC1.AppendText("აუქციონის შეწყვეტის შემთხვევაში შეწყვეტის საკომისიო შეადგენს აუქციონის საწყისის ფასის  0.59 პროცენტს;" + (char)(10) + (char)(13));*/

                TC1.AppendText("სპეციალისტი:   შპს ”კონსალტინგ გრუპს”, ს/კ 404483536  " + (char)(13));
                //TC1.AppendText("დირექტორი       ნინო არაბიძე" + (char)(10) + (char)(13));
                TC1.AppendText("დირექტორი       თამარ მაღალაშვილი" + (char)(10) + (char)(13));
            }

            if (moqme == 4)
            {
                if (auc == "პირველი")
                {
                    auc = "პირველ";
                }

                /*TC1.AppendText(" " + (char)(10) + (char)(13));*/
                TC1.AppendText(" " + (char)(10));
                TC1.AppendText("                                                      გამაფრთხილებელი წერილი და განცხადება " + (char)(13));
                TC1.AppendText("                                           აუქციონის დანიშვნისა და ქონების რეალიზაციის შესახებ " + (char)(13));
                TC1.AppendText("                                                                       N " + am + (char)(10) + (char)(13));
                TC1.AppendText("                                                                       " + dd + (char)(10) + (char)(13));

                TC1.AppendText("სპეციალისტი:     შპს ”კონსალტინგ გრუპს”	ს/კ 404483536  " + (char)(13));
                //TC1.AppendText("დირექტორი:        ნინო არაბიძე" + (char)(13));
                TC1.AppendText("დირექტორი:        თამარ მაღალაშვილი" + (char)(13));
                TC1.AppendText("მისამართი:          ქ. თბილისი, ვ. პეტრიაშვილის N 10" + (char)(13));
                TC1.AppendText("ელ ფოსტა:           auction@cgg.ge" + (char)(10) + (char)(13));
                TC1.AppendText("მესაკუთრე:      " + zw + (char)(13));
                TC1.AppendText("პირადი N         " + aaw + (char)(13));
                TC1.AppendText("მისამართი:       " + abw + (char)(10) + (char)(13));

                /*TC1.AppendText("გაცნობეთ, რომ კრედიტორსა და მსესხებელს შორის დაიდო საკრედიტო ხელშეკრულება, რომელიც უზრუნველყოფილია უძრავ ქონებაზე რეგისტრირებული იპოთეკის უფლებით. მსესხებლის მიერ დარღვეულ იქნა საკრედიტო ხელშეკრულების პირობები, როს საფუძველზეც შეწყდა სასესხო ხელშეკრულება და მსესხებელს განესაზღვრა ვადა სასესხო დავალიანების სრულად დასაფარად, რაც მსესხებლის მხრიდან არ განხორციელებულა." + (char)(10) + (char)(13));*/

                TC1.AppendText("კრედიტორი: " + dw + (char)(13));
                TC1.AppendText("მესაკუთრე: " + qw + " , პირადი N: " + rw + (char)(13));
                TC1.AppendText("მოვალე (მსესხებელი): " + ww + " , პირადი N: " + xw + (char)(13));
                TC1.AppendText("იპოთეკის ხელშეკრულება: " + gw + " , თარიღი: " + hw + (char)(13));
                TC1.AppendText("ვალდებულების წარმოშობა: " + iw + (char)(13));
                TC1.AppendText("იპოთეკის რეკვიზიტები: მისამართი: " + mw + " , საკადასტრო კოდი: " + nw + (char)(13));
                TC1.AppendText("სასესხო დავალიანების ჯამური ოდენობა: " + kw + (char)(10) + (char)(13));
                TC1.AppendText("კრედიტორმა იპოთეკის ხელშეკრულებით მხარეთა შორის შეთანხმების საფძველზე, განცხადებით მოგვმართა ჩვენ და დაგვავალა, როგორც სპეციალისტს, აუქციონის უზრუნველყოფა და უძრავი ქონების რეალიზაცია." + (char)(13));
                TC1.AppendText("კრედიტორის დავალებით სპეციალისტი აცხადებს " + auc + " საჯარო აუქციონს." + (char)(10) + (char)(13));
                TC1.AppendText("აუქციონის ჩატარების დრო:  " + aucs + " " + aucts + " საათიდან  " + auce + " " + aucte + " საათამდე" + (char)(13));
                TC1.AppendText("აუქციონის ჩატარების ადგილი: " + adg + (char)(10));

                if (auc == "პირველ")
                {
                    TC1.AppendText("აუქციონზე უძრავი ნივთის საწყისი ფასი: " + aj + " ლარი" + (char)(10));
                }

                if (auc == "მეორე")
                {
                    TC1.AppendText("აუქციონზე უძრავი ნივთის საწყისი ფასი: " + aj2 + " ლარი" + (char)(10));
                    ah1 = "0";
                }

                if (auc == "მესამე")
                {
                    TC1.AppendText("აუქციონზე უძრავი ნივთის საწყისი ფასი: " + aj3 + " ლარი" + (char)(10));
                    ah1 = "0";
                }

                TC1.AppendText(" " + (char)(13));

                /*TC1.AppendText("საწყისი ფასი შეადგენს კრედიტორის მოთხოვნის ოდენობისა და აუქციონის ხარჯების ჯამს, კერძოდ" + (char)(13));

                if (Convert.ToDecimal(ah) != 0)
                {
                    TC1.AppendText("მოთხოვნის ოდენობა: " + ahn + " აშშ დოლარი. 1 აშშ დოლარი = " + usd + " ლარი" + (char)(13));
                }

                if (Convert.ToDecimal(ah1) != 0)
                {
                    TC1.AppendText("მოთხოვნის ოდენობა: " + ahn1 + " ევრო. 1 ევრო = " + eur + " ლარი" + (char)(13));
                }

                if ((Convert.ToDecimal(ah) == 0) && (Convert.ToDecimal(ah1) == 0))
                {
                    TC1.AppendText("მოთხოვნის ოდენობა: " + ahn + " აშშ დოლარი. 1 აშშ დოლარი = " + usd + " ლარი" + (char)(13));
                }

                TC1.AppendText("მოთხოვნის ოდენობა: " + ahgn + " ლარი" + (char)(13));

                TC1.AppendText("დღგ: " + vat + " ლარი" + (char)(13));

                if (Convert.ToDecimal(av) == 590)
                {
                    if (unda == 0)
                    {
                        TC1.AppendText("სპეციალისტის საზღაური : " + spr + " %, არანაკლებ 590 ლარი, რაც თანხობრივად შეადგენს " + pro + " ლარი" + (char)(10) + (char)(13));
                    }

                    if (unda == 1)
                    {
                        TC1.AppendText("სპეციალისტის საზღაური : " + spr + " %, არანაკლებ 590 ლარი, რაც თანხობრივად შეადგენს " + pro + " ლარი და მოიცავს " + auqt + " - ს მომსახურების საფასურს - " + auqc + " ლარს;" + (char)(10) + (char)(13));
                    }

                }*/

                if (Convert.ToDecimal(av) == 490)
                {
                    TC1.AppendText("აუქციონის საზღაური : " + pro + " ლარი, პუბლიკაციის ხარჯი 97 ლარი, ასევე სპეციალისტის " + (char)(13));
                    TC1.AppendText("საზღაური 490 ლარი. მეორე აუქციონზე ხარჯებს დაემატება 217 ლარი, მესამე აუქციონზე ხარჯებს " + (char)(13));
                    TC1.AppendText("დაემატება  კვლავ 217 ლარი.  " + (char)(13));
                }

                TC1.AppendText("ქონების რეალიზაციის შემთხვევაში, დღგ-ს თანხა (არსებობის შემთხვევაში) და აუქციონის საფასური დაითვლება რეალიზაციის თანხიდან." + (char)(10) + (char)(13));

                /*TC1.AppendText("უძრავი ნივთის საწყისი ფასი:  " + ah + "  აშშ დოლარი და  " + ahg + "  ლარი" + (char)(13));*/

                TC1.AppendText("უძრავი ნივთის აღწერა:  " + ow + (char)(13));
                TC1.AppendText("გარდამავალი უფლებები:  " + pw + (char)(13));
                TC1.AppendText("აუქციონის პირობები:  " + (char)(13));
                if (cw == "STATIONAR")
                {
                    TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს." + (char)(13));
                    TC1.AppendText("ბ) აუქციონში მონაწილეობის ყველა მსურველმა აუქციონატორთან უნდა წარმოადგინოს საბანკო გარანტია, გაცემული შპს „კონსალტინგ გრუპსის“ (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის თარიღიდან 15 საბანკო დღე ან  საგარანტიო თანხის ჩარიცხვა უნდა მოხდეს შპს კონსალტინგ გრუპს-ის ანგარიშზე ა) ნებისმიერი ბანკის მეშვეობით და სპეციალური დანიშნულების მითითებით; ბ) საბანკო ანგარიშიდან გადმორიცხვით; პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას ან საგარანტიო თანხის გადახდის ქვითარს აუქციონის დაწყებამდე, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));
                    TC1.AppendText("გ) აუქციონი მიმდინარეობს მონაწილეთათვის სასურველი ნებისმიერი ბიჯის ოდენობით. შემოთავაზებული ბიჯი შეიძლება იყოს მხოლოდ მზარდი. აუქციონი გრძელდება ბოლო შემოთავაზებამდე. აუქციონზე გამარჯვებულია ის პირი, ვინც უფრო მაღალ ფასს შესთავაზებს." + (char)(13));
                    TC1.AppendText("დ) აუქციონში გამარჯვებულმა აუქციონის თანხა სრულად უნდა შეიტანოს სპეციალისტის ანგარიშზე აუქციონის დასრულების დღიდან 7 საბანკო დღის მანძილზე, წინააღმდეგ შემთხვევაში იგი კარგავს მის მიერ საბანკო გარანტიის სახით წარმოდგენილ თანხას და უქმდება მისი, როგორც აუქციონზე გამარჯვებულის სტატუსი." + (char)(13));
                    TC1.AppendText("ე) აუქციონში გამარჯვებულის მიერ შესაბამის ვადაში აუქციონის თანხის სრულად გადახდის შემთხვევაში შპს ”კონსალტინგ გრუპს” მასზე გადასცემს განკარგულებას ქონებაზე საკუთრების უფლების მოპოვების შესახებ." + (char)(13));
                    TC1.AppendText("ვ) იმ შემთხვევაში თუ მიწის ნაკვეთის (ქონების) სტატუსი რეალიზაციის მომენტისათვის წარმოადგენს სასოფლო-სამეურნეოს, მონაწილე პირი უნდა აკმაყოფილებდეს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს; ასეთ შემთხვევაში აუქციონში მონაწილეობის მსურველმა უნდა წარადგინოს იმის დამადასტურებელი ინფორმაცია, რომ იგი აკმაყოფილებს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს;" + (char)(13));
                    TC1.AppendText(" " + (char)(13));
                    TC1.AppendText("ყურადღება: ქონების რეალიზაცია შესაძლებელია თავიდან იქნას აცილებული, თუ ნებისმიერი პირი (მათ შორის მსესხებელი, უძრავი ქონების მესაკუთრე ან/და სხვა დაინტერესებული პირი) აუქციონის დაწყებამდე განახორციელებს მსესხებლის მიერ კრედიტორს მიმართ არსებული სასესხო და მასთან დაკავშირებული ხარჯების დავალიანების სრულად დაფარვას.ყველა პირი, რომელსაც აქვს რაიმე სახის უფლებები უძრავ ქონებაზე, ვალდებულია ამ უფლებათა დამადასტურებელი მტკიცებულებანი წარმოადგინოს აუქციონის დაწყებამდე წერილობითი ფორმით სპეციალისტთან." + (char)(13));
                }
                else
                {
                    if (auct == "0")
                    {

                        if (liv == "LIVO")
                        {
                            TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს. " + (char)(13));
                            TC1.AppendText("ბ) Auction.livo.ge აუქციონში მონაწილეობის ყველა მსურველმა უნდა გაიაროს რეგისტრაცია და გადაიხადოს საგარანტიო თანხა პერსონალური ბალანსის მეშვეობით. მომხმარებელს პერსონალურ ბალანსზე თანხის შეტანა შეუძლია ვებ-გვერდზე მითითებულ კომპანიის ანგარიშზე: ა) ნებისმიერი ბანკის მეშვეობით, სპეციალური დანიშნულების მითითებით; ბ) საბანკო ანგარიშიდან გადმორიცხვით; გ) ვებგვერდზე პლასტიკური ბარათის მონაცემების შეყვანით.  " + (char)(13));
                        }
                        else
                        {
                            TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს. " + (char)(13));
                            TC1.AppendText("ბ) eAuction.ge აუქციონში მონაწილეობის ყველა მსურველმა უნდა გაიაროს რეგისტრაცია და გადაიხადოს საგარანტიო თანხა შემდეგი ფორმით : " + (char)(13));
                            TC1.AppendText("აა. ნაღდი ანგარიშსწორებით ლიბერთი ბანკში განაცხადის ნომრითა და პირადობის დამადასტურებელი საბუთით " + (char)(13));
                            TC1.AppendText("ბბ. უნაღდო ანგარიშსწორებით eAuction.ge-ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე " + (char)(13));
                            TC1.AppendText("გგ. eAuction.ge-ს ვებ - გვერდიდან პლასტიკური ბარათით " + (char)(13));
                            TC1.AppendText("დდ. ელექტრონული საბანკო გარანტიის აქტივაციით. გაცემული კრედიტორს (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის დასრულების თარიღიდან 15 საბანკო დღე. პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას აუქციონის მითითებული ფორმით, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));
                        }

                        /*TC1.AppendText("1. ნაღდი ანგარიშსწორებით ლიბერთი ბანკში განაცხადის ნომრითა და პირადობის დამადასტურებელი საბუთით " + (char)(13));

                        if (liv == "LIVO")
                        {
                            TC1.AppendText("2. უნაღდო ანგარიშსწორებით auction.livo.ge-ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე " + (char)(13));
                        }
                        else
                        {
                            TC1.AppendText("2. უნაღდო ანგარიშსწორებით eAuction.ge-ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე " + (char)(13));
                        }

                        if (liv == "LIVO")
                        {
                            TC1.AppendText("3. auction.livo.ge-ს ვებ - გვერდიდან პლასტიკური ბარათით" + (char)(13));
                        }
                        else
                        {
                            TC1.AppendText("3. eAuction.ge-ს ვებ - გვერდიდან პლასტიკური ბარათით" + (char)(13));
                        }
                        TC1.AppendText("4. ელექტრონული საბანკო გარანტიის აქტივაციით. გაცემული კრედიტორს (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის დასრულების თარიღიდან 15 საბანკო დღე. პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას აუქციონის მითითებული ფორმით, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));*/
                        TC1.AppendText("გ) იმ შემთხევაში, თუ აუქციონზე საწყისი ფასი არის 100 000 ლარამდე, ბიჯის ოდენობა განისაზღვრება - 100 ლარის ოდენობით; 100 000 ლარიდან 500 000 ლარის ჩათვლით  - 500 ლარის ოდენობით; ხოლო, 500 000 ლარზე მეტის შემთხვევაში - 1000 ლარის ოდენობით; აუქციონი გრძელდება ბოლო შემოთავაზებამდე. აუქციონზე გამარჯვებულია ის პირი, ვინც უფრო მაღალ ფასს შესთავაზებს." + (char)(13));
                        TC1.AppendText("დ) აუქციონში გამარჯვებულმა აუქციონის თანხა სრულად უნდა შეიტანოს სპეცილისტის სადეპოზიტო ანგარიშზე აუქციონის დასრულების დღიდან 7 საბანკო დღის მანძილზე. წინააღმდეგ შემთხვევაში იგი კარგავს მის მიერ საბანკო გარანტიის სახით წარმოდგენილ თანხას და უქმდება მისი, როგორც აუქციონზე გამარჯვებულის სტატუსი." + (char)(13));
                        TC1.AppendText("ე) აუქციონში გამარჯვებულის მიერ შესაბამის ვადაში აუქციონის თანხის სრულად გადახდის შემთხვევაში შპს ”კონსალტინგ გრუპს” მასზე გადასცემს განკარგულებას ქონებაზე საკუთრების უფლების მოპოვების შესახებ." + (char)(13));
                        TC1.AppendText("ვ) იმ შემთხვევაში თუ მიწის ნაკვეთის (ქონების) სტატუსი რეალიზაციის მომენტისათვის წარმოადგენს სასოფლო-სამეურნეოს, მონაწილე პირი უნდა აკმაყოფილებდეს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს; ასეთ შემთხვევაში აუქციონში მონაწილეობის მსურველმა უნდა წარადგინოს იმის დამადასტურებელი ინფორმაცია, რომ იგი აკმაყოფილებს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს;" + (char)(10) + (char)(13));
                    }
                    else
                    {
                        TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს. " + (char)(13));
                        TC1.AppendText("ბ) აუქციონში მონაწილეობის ყველა მსურველმა უნდა გაიაროს რეგისტრაცია და გადაიხადოს საგარანტიო თანხა შემდეგი ფორმით : " + (char)(13));
                        TC1.AppendText("1. ნაღდი ანგარიშსწორებით ნებისმიერ ბანკში განაცხადის ნომრითა და პირადობის დამადასტურებელი საბუთით " + (char)(13));
                        TC1.AppendText("2. უნაღდო ანგარიშსწორებით www.auctionhouse.ge -ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე; " + (char)(13));
                        TC1.AppendText("3. www.auctionhouse.ge -ს ვებ - გვერდიდან პლასტიკური ბარათით" + (char)(13));
                        TC1.AppendText("4. ელექტრონული საბანკო გარანტიის აქტივაციით. გაცემული კრედიტორს (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის დასრულების თარიღიდან 15 საბანკო დღე. პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას აუქციონის მითითებული ფორმით, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));
                        TC1.AppendText("გ) იმ შემთხევაში, თუ აუქციონზე საწყისი ფასი არის 100 000 ლარამდე, ბიჯის ოდენობა განისაზღვრება - 100 ლარის ოდენობით; 100 000 ლარიდან 500 000 ლარის ჩათვლით  - 500 ლარის ოდენობით; ხოლო, 500 000 ლარზე მეტის შემთხვევაში - 1000 ლარის ოდენობით; აუქციონი გრძელდება ბოლო შემოთავაზებამდე. აუქციონზე გამარჯვებულია ის პირი, ვინც უფრო მაღალ ფასს შესთავაზებს." + (char)(13));
                        TC1.AppendText("დ) აუქციონში გამარჯვებულმა აუქციონის თანხა სრულად უნდა შეიტანოს სპეცილისტის სადეპოზიტო ანგარიშზე აუქციონის დასრულების დღიდან 2 საბანკო დღის მანძილზე. წინააღმდეგ შემთხვევაში იგი კარგავს მის მიერ საბანკო გარანტიის სახით წარმოდგენილ თანხას და უქმდება მისი, როგორც აუქციონზე გამარჯვებულის სტატუსი." + (char)(13));
                        TC1.AppendText("ე) აუქციონში გამარჯვებულის მიერ შესაბამის ვადაში აუქციონის თანხის სრულად გადახდის შემთხვევაში შპს ”კონსალტინგ გრუპს” მასზე გადასცემს განკარგულებას ქონებაზე საკუთრების უფლების მოპოვების შესახებ." + (char)(13));
                        TC1.AppendText("ვ) იმ შემთხვევაში თუ მიწის ნაკვეთის (ქონების) სტატუსი რეალიზაციის მომენტისათვის წარმოადგენს სასოფლო-სამეურნეოს, მონაწილე პირი უნდა აკმაყოფილებდეს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს; ასეთ შემთხვევაში აუქციონში მონაწილეობის მსურველმა უნდა წარადგინოს იმის დამადასტურებელი ინფორმაცია, რომ იგი აკმაყოფილებს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს;" + (char)(10) + (char)(13));
                    }
                }
                TC1.AppendText("ყურადღება: ქონების რეალიზაცია შესაძლებელია თავიდან იქნას აცილებული, თუ ნებისმიერი პირი (მათ შორის მსესხებელი, უძრავი ქონების მესაკუთრე ან/და სხვა დაინტერესებული პირი) აუქციონის დაწყებამდე განახორციელებს მსესხებლის მიერ ”" + dw + "”–ს მიმართ არსებული სასესხო და მასთან დაკავშირებული ხარჯების დავალიანების სრულად დაფარვას." + (char)(13));
                TC1.AppendText("ყველა პირი, რომელსაც აქვს რაიმე სახის უფლებები უძრავ ქონებაზე, ვალდებულია ამ უფლებათა დამადასტურებელი მტკიცებულებანი წარმოადგინოს აუქციონის დაწყებამდე წერილობითი ფორმით სპეციალისტთან." + (char)(10) + (char)(13));
                /*TC1.AppendText("კრედიტორს მოთხოვნა უცხოურ ვალუტაში აუნაზღაურდება აუქციონის დასრულების დღის კურსით." + (char)(13));
                TC1.AppendText("აუქციონის შეწყვეტის შემთხვევაში შეწყვეტის საკომისიო შეადგენს აუქციონის საწყისის ფასის  0.59 პროცენტს;" + (char)(10) + (char)(13));*/
                TC1.AppendText("სპეციალისტი:   შპს ”კონსალტინგ გრუპს”, ს/კ 404483536  " + (char)(13));
                //TC1.AppendText("დირექტორი       ნინო არაბიძე" + (char)(10) + (char)(13));
                TC1.AppendText("დირექტორი       თამარ მაღალაშვილი" + (char)(10) + (char)(13));
            }

            if (moqme == 5)
            {
                TC1.AppendText("სატელეფონო შეტყობინება " + qw + (char)(10) + (char)(13));
                TC1.AppendText("გამარჯობათ," + (char)(13));
                TC1.AppendText(qw + " ბრძანდებით, მცხოვრები " + tw + (char)(10) + (char)(13));
                TC1.AppendText("გიკავშირდებით აუქციონთან დაკავშირებით შპს „კონსალტინგ გრუპს“-ის,წარმომადგენელი," + (char)(10) + (char)(13));
                TC1.AppendText("გატყობინებთ, რომ განცხადება გვაქვს თქვენთვის ჩასაბარებელი და აქვე გაფრთხილებთ, " + (char)(13));
                TC1.AppendText("რომ ჩვენი საუბარი იწერება." + (char)(10) + (char)(13));
                TC1.AppendText("გაცნობებთ, რომ “" + qw + "“ კუთვნილ ქონებაზე, მისამართი “" + mw + "“ კრედიტორის “" + dw + "” განცხადებით" + (char)(13));
                TC1.AppendText("დანიშნულია" + (char)(13));
                TC1.AppendText(auc + "  საჯარო აუქციონი, რომელიც " + (char)(13));
                TC1.AppendText("დაიწყება " + aucs + " " + aucts + " საათიდან და დასრულდება " + auce + " " + aucte + " საათზე" + (char)(10) + (char)(13));
                TC1.AppendText("აუქციონის ჩატარების ადგილი: " + adg + (char)(10) + (char)(13));
                TC1.AppendText("საფუძველი:  სასესხო დავალიანება " + (char)(10) + (char)(13));
                TC1.AppendText("აუქციონის  საწყისი ფასი: " + ah + "  აშშ დოლარი და  " + ahg + "  ლარი" + (char)(10) + (char)(13));
                TC1.AppendText("დამატებითი ინფორმაციისთვის მიმართეთ “" + dw + (char)(10) + (char)(13));
                TC1.AppendText("გაგიმეორებთ, რომ  საჯარო აუქციონი " + (char)(13));
                TC1.AppendText("დაიწყება " + aucs + " " + aucts + " საათიდან და დასრულდება " + auce + " " + aucte + " საათზე" + (char)(10) + (char)(13));
                TC1.AppendText("აუქციონის ჩატარების ადგილი: " + adg + (char)(10) + (char)(13));
            }

            if (moqme == 6)
            {
                if (auc == "პირველი")
                {
                    auc = "პირველ";
                }

                /*TC1.AppendText(" " + (char)(10) + (char)(13));*/
                TC1.AppendText("                                       საჯარო განცხადება აუქციონის დანიშვნის შესახებ " + (char)(13));
                TC1.AppendText("                                       საჯარო აუქციონის საიდენტიფიკაციო ნომერი: " + am + (char)(10) + (char)(13));
                TC1.AppendText("სპეციალისტი:     შპს ”კონსალტინგ გრუპს”	ს/კ 404483536  " + (char)(13));
                //TC1.AppendText("დირექტორი:        ნინო არაბიძე" + (char)(13));
                TC1.AppendText("დირექტორი:        თამარ მაღალაშვილი" + (char)(13));
                TC1.AppendText("მისამართი:          ქ. თბილისი, ვ. პეტრიაშვილის N 10" + (char)(13));
                TC1.AppendText("ელ ფოსტა:           auction@cgg.ge" + (char)(13));
                TC1.AppendText("საბანკო ანგარიში:     GE44TB7747836020100004" + (char)(10) + (char)(13));
                TC1.AppendText("სპეციალისტი აცხადებს " + auc + " საჯარო აუქციონს მესაკუთრის  სახელზე რიცხულ, კრედიტორის " + (char)(13));
                TC1.AppendText("ბანკის სასარგებლოდ იპოთეკით დატვირთულ უძრავ ქონებაზე." + (char)(10) + (char)(13));
                TC1.AppendText("კრედიტორი: " + dw + (char)(13));
                TC1.AppendText("მესაკუთრე: " + qw + " , პირადი N " + rw + (char)(13));
                TC1.AppendText("მოვალე (მსესხებელი): " + ww + " , პირადი N " + xw + (char)(13));
                TC1.AppendText("იპოთეკის ხელშეკრულება: " + gw + " , თარიღი " + hw + (char)(13));
                TC1.AppendText("ვალდებულების წარმოშობა: " + iw + (char)(13));
                TC1.AppendText("იპოთეკის რეკვიზიტები: მისამართი " + mw + " , საკადასტრო კოდი: " + nw + (char)(13));
                TC1.AppendText("სასესხო დავალიანების ჯამური ოდენობა: " + kw + (char)(13));
                TC1.AppendText("აუქციონის ჩატარების დრო:  " + aucs + " " + aucts + " საათიდან  " + auce + " " + aucte + " საათამდე" + (char)(13));
                TC1.AppendText("აუქციონის ჩატარების ადგილი: " + adg + (char)(13));

                if (auc == "პირველ")
                {
                    TC1.AppendText("უძრავი ნივთის საწყისი ფასი: " + aj + " ლარი" + (char)(13));
                }

                if (auc == "მეორე")
                {
                    TC1.AppendText("უძრავი ნივთის საწყისი ფასი: " + aj2 + " ლარი" + (char)(13));
                    ah1 = "0";
                }

                if (auc == "მესამე")
                {
                    TC1.AppendText("უძრავი ნივთის საწყისი ფასი: " + aj3 + " ლარი" + (char)(13));
                    ah1 = "0";
                }

                /*TC1.AppendText("უძრავი ნივთის საწყისი ფასი:  " + ah + "  აშშ დოლარი და  " + ahg + "  ლარი" + (char)(13));*/

                TC1.AppendText("უძრავი ნივთის აღწერა:  " + ow + (char)(13));
                TC1.AppendText("გარდამავალი უფლებები:  " + pw + (char)(13));
                TC1.AppendText("აუქციონის პირობები:  " + (char)(13));

                if (cw == "STATIONAR")
                {
                    TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს." + (char)(13));
                    TC1.AppendText("ბ) აუქციონში მონაწილეობის ყველა მსურველმა აუქციონატორთან უნდა წარმოადგინოს საბანკო გარანტია, გაცემული შპს „კონსალტინგ გრუპსის“ (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის თარიღიდან 15 საბანკო დღე ან  საგარანტიო თანხის ჩარიცხვა უნდა მოხდეს შპს კონსალტინგ გრუპს-ის ანგარიშზე ა) ნებისმიერი ბანკის მეშვეობით და სპეციალური დანიშნულების მითითებით; ბ) საბანკო ანგარიშიდან გადმორიცხვით; პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას ან საგარანტიო თანხის გადახდის ქვითარს აუქციონის დაწყებამდე, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));
                    TC1.AppendText("გ) აუქციონი მიმდინარეობს მონაწილეთათვის სასურველი ნებისმიერი ბიჯის ოდენობით. შემოთავაზებული ბიჯი შეიძლება იყოს მხოლოდ მზარდი. აუქციონი გრძელდება ბოლო შემოთავაზებამდე. აუქციონზე გამარჯვებულია ის პირი, ვინც უფრო მაღალ ფასს შესთავაზებს." + (char)(13));
                    TC1.AppendText("დ) აუქციონში გამარჯვებულმა აუქციონის თანხა სრულად უნდა შეიტანოს სპეციალისტის ანგარიშზე აუქციონის დასრულების დღიდან 7 საბანკო დღის მანძილზე, წინააღმდეგ შემთხვევაში იგი კარგავს მის მიერ საბანკო გარანტიის სახით წარმოდგენილ თანხას და უქმდება მისი, როგორც აუქციონზე გამარჯვებულის სტატუსი. " + (char)(13));
                    TC1.AppendText("ე) აუქციონში გამარჯვებულის მიერ შესაბამის ვადაში აუქციონის თანხის სრულად გადახდის შემთხვევაში შპს ”კონსალტინგ გრუპს” მასზე გადასცემს განკარგულებას ქონებაზე საკუთრების უფლების მოპოვების შესახებ." + (char)(13));
                    TC1.AppendText("ვ) იმ შემთხვევაში თუ მიწის ნაკვეთის (ქონების) სტატუსი რეალიზაციის მომენტისათვის წარმოადგენს სასოფლო-სამეურნეოს, მონაწილე პირი უნდა აკმაყოფილებდეს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს; ასეთ შემთხვევაში აუქციონში მონაწილეობის მსურველმა უნდა წარადგინოს იმის დამადასტურებელი ინფორმაცია, რომ იგი აკმაყოფილებს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს;" + (char)(13));
                    TC1.AppendText(" " + (char)(13));
                    TC1.AppendText("ყურადღება: ქონების რეალიზაცია შესაძლებელია თავიდან იქნას აცილებული, თუ ნებისმიერი პირი (მათ შორის მსესხებელი, უძრავი ქონების მესაკუთრე ან/და სხვა დაინტერესებული პირი) აუქციონის დაწყებამდე განახორციელებს მსესხებლის მიერ კრედიტორს მიმართ არსებული სასესხო და მასთან დაკავშირებული ხარჯების დავალიანების სრულად დაფარვას.ყველა პირი, რომელსაც აქვს რაიმე სახის უფლებები უძრავ ქონებაზე, ვალდებულია ამ უფლებათა დამადასტურებელი მტკიცებულებანი წარმოადგინოს აუქციონის დაწყებამდე წერილობითი ფორმით სპეციალისტთან." + (char)(13));
                }
                else
                {
                    if (auct == "0")
                    {

                        if (liv == "LIVO")
                        {
                            TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს. " + (char)(13));
                            TC1.AppendText("ბ) Auction.livo.ge აუქციონში მონაწილეობის ყველა მსურველმა უნდა გაიაროს რეგისტრაცია და გადაიხადოს საგარანტიო თანხა პერსონალური ბალანსის მეშვეობით. მომხმარებელს პერსონალურ ბალანსზე თანხის შეტანა შეუძლია ვებ-გვერდზე მითითებულ კომპანიის ანგარიშზე: ა) ნებისმიერი ბანკის მეშვეობით, სპეციალური დანიშნულების მითითებით; ბ) საბანკო ანგარიშიდან გადმორიცხვით; გ) ვებგვერდზე პლასტიკური ბარათის მონაცემების შეყვანით.  " + (char)(13));
                        }
                        else
                        {
                            TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს. " + (char)(13));
                            TC1.AppendText("ბ) eAuction.ge აუქციონში მონაწილეობის ყველა მსურველმა უნდა გაიაროს რეგისტრაცია და გადაიხადოს საგარანტიო თანხა შემდეგი ფორმით : " + (char)(13));
                            TC1.AppendText("აა. ნაღდი ანგარიშსწორებით ლიბერთი ბანკში განაცხადის ნომრითა და პირადობის დამადასტურებელი საბუთით " + (char)(13));
                            TC1.AppendText("ბბ. უნაღდო ანგარიშსწორებით eAuction.ge-ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე " + (char)(13));
                            TC1.AppendText("გგ. eAuction.ge-ს ვებ - გვერდიდან პლასტიკური ბარათით " + (char)(13));
                            TC1.AppendText("დდ. ელექტრონული საბანკო გარანტიის აქტივაციით. გაცემული კრედიტორს (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის დასრულების თარიღიდან 15 საბანკო დღე. პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას აუქციონის მითითებული ფორმით, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));
                        }

                        /*TC1.AppendText("1. ნაღდი ანგარიშსწორებით ლიბერთი ბანკში განაცხადის ნომრითა და პირადობის დამადასტურებელი საბუთით " + (char)(13));

                        if (liv == "LIVO")
                        {
                            TC1.AppendText("2. უნაღდო ანგარიშსწორებით auction.livo.ge-ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე " + (char)(13));
                        }
                        else
                        {
                            TC1.AppendText("2. უნაღდო ანგარიშსწორებით eAuction.ge-ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე " + (char)(13));
                        }

                        if (liv == "LIVO")
                        {
                            TC1.AppendText("3. auction.livo.ge-ს ვებ - გვერდიდან პლასტიკური ბარათით" + (char)(13));
                        }
                        else
                        {
                            TC1.AppendText("3. eAuction.ge-ს ვებ - გვერდიდან პლასტიკური ბარათით" + (char)(13));
                        }
                        TC1.AppendText("4. ელექტრონული საბანკო გარანტიის აქტივაციით. გაცემული კრედიტორს (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის დასრულების თარიღიდან 15 საბანკო დღე. პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას აუქციონის მითითებული ფორმით, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));*/
                        TC1.AppendText("გ) იმ შემთხევაში, თუ აუქციონზე საწყისი ფასი არის 100 000 ლარამდე, ბიჯის ოდენობა განისაზღვრება - 100 ლარის ოდენობით; 100 000 ლარიდან 500 000 ლარის ჩათვლით  - 500 ლარის ოდენობით; ხოლო, 500 000 ლარზე მეტის შემთხვევაში - 1000 ლარის ოდენობით; აუქციონი გრძელდება ბოლო შემოთავაზებამდე. აუქციონზე გამარჯვებულია ის პირი, ვინც უფრო მაღალ ფასს შესთავაზებს." + (char)(13));
                        TC1.AppendText("დ) აუქციონში გამარჯვებულმა აუქციონის თანხა სრულად უნდა შეიტანოს სპეცილისტის სადეპოზიტო ანგარიშზე აუქციონის დასრულების დღიდან 7 საბანკო დღის მანძილზე. წინააღმდეგ შემთხვევაში იგი კარგავს მის მიერ საბანკო გარანტიის სახით წარმოდგენილ თანხას და უქმდება მისი, როგორც აუქციონზე გამარჯვებულის სტატუსი." + (char)(13));
                        TC1.AppendText("ე) აუქციონში გამარჯვებულის მიერ შესაბამის ვადაში აუქციონის თანხის სრულად გადახდის შემთხვევაში შპს ”კონსალტინგ გრუპს” მასზე გადასცემს განკარგულებას ქონებაზე საკუთრების უფლების მოპოვების შესახებ." + (char)(13));
                        TC1.AppendText("ვ) იმ შემთხვევაში თუ მიწის ნაკვეთის (ქონების) სტატუსი რეალიზაციის მომენტისათვის წარმოადგენს სასოფლო-სამეურნეოს, მონაწილე პირი უნდა აკმაყოფილებდეს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს; ასეთ შემთხვევაში აუქციონში მონაწილეობის მსურველმა უნდა წარადგინოს იმის დამადასტურებელი ინფორმაცია, რომ იგი აკმაყოფილებს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს;" + (char)(10) + (char)(13));
                    }
                    else
                    {
                        TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს. " + (char)(13));
                        TC1.AppendText("ბ) აუქციონში მონაწილეობის ყველა მსურველმა უნდა გაიაროს რეგისტრაცია და გადაიხადოს საგარანტიო თანხა შემდეგი ფორმით : " + (char)(13));
                        TC1.AppendText("1. ნაღდი ანგარიშსწორებით ნებისმიერ ბანკში განაცხადის ნომრითა და პირადობის დამადასტურებელი საბუთით " + (char)(13));
                        TC1.AppendText("2. უნაღდო ანგარიშსწორებით www.auctionhouse.ge -ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე; " + (char)(13));
                        TC1.AppendText("3. www.auctionhouse.ge -ს ვებ - გვერდიდან პლასტიკური ბარათით" + (char)(13));
                        TC1.AppendText("4. ელექტრონული საბანკო გარანტიის აქტივაციით. გაცემული კრედიტორს (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის დასრულების თარიღიდან 15 საბანკო დღე. პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას აუქციონის მითითებული ფორმით, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));
                        TC1.AppendText("გ) იმ შემთხევაში, თუ აუქციონზე საწყისი ფასი არის 100 000 ლარამდე, ბიჯის ოდენობა განისაზღვრება - 100 ლარის ოდენობით; 100 000 ლარიდან 500 000 ლარის ჩათვლით  - 500 ლარის ოდენობით; ხოლო, 500 000 ლარზე მეტის შემთხვევაში - 1000 ლარის ოდენობით; აუქციონი გრძელდება ბოლო შემოთავაზებამდე. აუქციონზე გამარჯვებულია ის პირი, ვინც უფრო მაღალ ფასს შესთავაზებს." + (char)(13));
                        TC1.AppendText("დ) აუქციონში გამარჯვებულმა აუქციონის თანხა სრულად უნდა შეიტანოს სპეცილისტის სადეპოზიტო ანგარიშზე აუქციონის დასრულების დღიდან 2 საბანკო დღის მანძილზე. წინააღმდეგ შემთხვევაში იგი კარგავს მის მიერ საბანკო გარანტიის სახით წარმოდგენილ თანხას და უქმდება მისი, როგორც აუქციონზე გამარჯვებულის სტატუსი." + (char)(13));
                        TC1.AppendText("ე) აუქციონში გამარჯვებულის მიერ შესაბამის ვადაში აუქციონის თანხის სრულად გადახდის შემთხვევაში შპს ”კონსალტინგ გრუპს” მასზე გადასცემს განკარგულებას ქონებაზე საკუთრების უფლების მოპოვების შესახებ." + (char)(13));
                        TC1.AppendText("ვ) იმ შემთხვევაში თუ მიწის ნაკვეთის (ქონების) სტატუსი რეალიზაციის მომენტისათვის წარმოადგენს სასოფლო-სამეურნეოს, მონაწილე პირი უნდა აკმაყოფილებდეს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს; ასეთ შემთხვევაში აუქციონში მონაწილეობის მსურველმა უნდა წარადგინოს იმის დამადასტურებელი ინფორმაცია, რომ იგი აკმაყოფილებს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს;" + (char)(10) + (char)(13));
                    }
                }
                TC1.AppendText("ყურადღება: ქონების რეალიზაცია შესაძლებელია თავიდან იქნას აცილებული, თუ ნებისმიერი პირი (მათ შორის მსესხებელი, უძრავი ქონების მესაკუთრე ან/და სხვა დაინტერესებული პირი) აუქციონის დაწყებამდე განახორციელებს მსესხებლის მიერ კრედიტორის მიმართ არსებული სასესხო და მასთან დაკავშირებული ხარჯების დავალიანების სრულად დაფარვას." + (char)(13));
                TC1.AppendText("ყველა პირი, რომელსაც აქვს რაიმე სახის უფლებები უძრავ ქონებაზე, ვალდებულია ამ უფლებათა დამადასტურებელი მტკიცებულებანი წარმოადგინოს აუქციონის დაწყებამდე წერილობითი ფორმით სპეციალისტთან." + (char)(10) + (char)(13));
                TC1.AppendText("სპეციალისტი:   შპს ”კონსალტინგ გრუპს”, ს/კ 404483536  " + (char)(13));
                //TC1.AppendText("დირექტორი       ნინო არაბიძე" + (char)(10) + (char)(13));
                TC1.AppendText("დირექტორი       თამარ მაღალაშვილი" + (char)(10) + (char)(13));

            }

            if (moqme == 7)
            {
                if (auc == "პირველი")
                {
                    auc = "პირველ";
                }

                TC1.AppendText("                                       საჯარო შეტყობინება (პუბლიკაცია) აუქციონის დანიშვნის შესახებ " + (char)(13));
                TC1.AppendText("                                            საჯარო აუქციონის საიდენტიფიკაციო ნომერი: " + am + (char)(10) + (char)(13));
                TC1.AppendText("სპეციალისტი:     შპს „კონსალტინგ გრუპს”	ს/კ 404483536  " + (char)(13));
                //TC1.AppendText("დირექტორი:        ნინო არაბიძე" + (char)(13));
                TC1.AppendText("დირექტორი:        თამარ მაღალაშვილი" + (char)(13));
                TC1.AppendText("მისამართი:          ქ. თბილისი, ვ. პეტრიაშვილის N 10" + (char)(13));
                TC1.AppendText("ელ ფოსტა:           auction@cgg.ge" + (char)(13));
                TC1.AppendText("საბანკო ანგარიში:     GE44TB7747836020100004" + (char)(10) + (char)(13));
                TC1.AppendText("საქართველოს სამოქალაქო კოდექსის 306/2 მე-3 ნაწილის, ასევე საქართველოს სამოქალაქო საპროცესო კოდექსის 78-ე მუხლის შესაბამისად, ვინაიდან მესაკუთრეს ორჯერ გაეგზავნა წერილობითი შეტყობინება აუქციონის დანიშვნის შესახებ, რისი ჩაბარებაც მესაკუთრეზე ვერ მოხერხდა, სპეციალისტი იყენებს შესაძლებლობას შეტყობინების საჯაროდ გავრცელების (პუბლიკაციის) შესახებ. საჯარო შეტყობინების საშუალებად გამოყენებულია „საკანონმდებლო მაცნე“. საჯარო შეტყობინება მესაკუთრესათვის ჩაბარებულად ითვლება შეტყობინების საკანონმდებლო მაცნეში გამოქვეყნებიდან მე-7 დღეს." + (char)(10) + (char)(13));
                TC1.AppendText("სპეციალისტი აცხადებს " + auc + " საჯარო აუქციონს მესაკუთრის სახელზე რიცხულ, კრედიტორის, ბანკის სასარგებლოდ იპოთეკით დატვირთულ უძრავ ქონებაზე." + (char)(10) + (char)(13));
                /*TC1.AppendText("საჯარო აუქციონის საიდენტიფიკაციო ნომერი: " + am + (char)(13));*/
                TC1.AppendText("კრედიტორი: " + dw + (char)(13));
                TC1.AppendText("მესაკუთრე: " + qw + " , პირადი N " + rw + (char)(13));
                TC1.AppendText("მოვალე (მსესხებელი): " + ww + " , პირადი N " + xw + (char)(13));
                TC1.AppendText("იპოთეკის ხელშეკრულება: " + gw + " , თარიღი " + hw + (char)(13));
                TC1.AppendText("ვალდებულების წარმოშობა: " + iw + (char)(13));
                TC1.AppendText("იპოთეკის რეკვიზიტები: " + mw + " , საკადასტრო კოდი: " + nw + (char)(13));
                TC1.AppendText("სასესხო დავალიანების ჯამური ოდენობა: " + kw + (char)(13));
                TC1.AppendText("აუქციონის ჩატარების დრო:  " + aucs + " წლის " + aucts + " საათიდან  " + auce + " წლის " + aucte + " საათამდე" + (char)(13));
                TC1.AppendText("აუქციონის ჩატარების ადგილი: " + adg + (char)(13));

                if (auc == "პირველ")
                {
                    TC1.AppendText("უძრავი ნივთის საწყისი ფასი: " + aj + " ლარი" + (char)(13));
                }

                if (auc == "მეორე")
                {
                    TC1.AppendText("უძრავი ნივთის საწყისი ფასი: " + aj2 + " ლარი" + (char)(13));
                    ah1 = "0";
                }

                if (auc == "მესამე")
                {
                    TC1.AppendText("უძრავი ნივთის საწყისი ფასი: " + aj3 + " ლარი" + (char)(13));
                    ah1 = "0";
                }

                /*TC1.AppendText("უძრავი ნივთის საწყისი ფასი:  " + ah + "  აშშ დოლარი და  " + ahg + "  ლარი" + (char)(13));*/

                TC1.AppendText("უძრავი ნივთის აღწერა:  " + ow + (char)(13));
                TC1.AppendText("გარდამავალი უფლებები:  " + pw + (char)(13));
                TC1.AppendText("აუქციონის პირობები:  " + (char)(13));

                if (cw == "STATIONAR")
                {
                    TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის, კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს:" + (char)(13));
                    TC1.AppendText("ბ) აუქციონში მონაწილეობის ყველა მსურველმა აუქციონატორთან უნდა წარმოადგინოს საბანკო გარანტია, გაცემული შპს „კონსალტინგ გრუპსის“ (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის თარიღიდან 15 საბანკო დღე ან  საგარანტიო თანხის ჩარიცხვა უნდა მოხდეს შპს კონსალტინგ გრუპს-ის ანგარიშზე ა) ნებისმიერი ბანკის მეშვეობით და სპეციალური დანიშნულების მითითებით; ბ) საბანკო ანგარიშიდან გადმორიცხვით; პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას ან საგარანტიო თანხის გადახდის ქვითარს აუქციონის დაწყებამდე, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));
                    TC1.AppendText("გ) აუქციონი მიმდინარეობს მონაწილეთათვის სასურველი ნებისმიერი ბიჯის ოდენობით. შემოთავაზებული ბიჯი შეიძლება იყოს მხოლოდ მზარდი. აუქციონი გრძელდება ბოლო შემოთავაზებამდე. აუქციონზე გამარჯვებულია ის პირი, ვინც უფრო მაღალ ფასს შესთავაზებს." + (char)(13));
                    TC1.AppendText("დ) აუქციონში გამარჯვებულმა აუქციონის თანხა სრულად უნდა შეიტანოს სპეციალისტის ანგარიშზე აუქციონის დასრულების დღიდან 7 საბანკო დღის მანძილზე, წინააღმდეგ შემთხვევაში იგი კარგავს მის მიერ საბანკო გარანტიის სახით წარმოდგენილ თანხას და უქმდება მისი, როგორც აუქციონზე გამარჯვებულის სტატუსი. " + (char)(13));
                    TC1.AppendText("ე) აუქციონში გამარჯვებულის მიერ შესაბამის ვადაში აუქციონის თანხის სრულად გადახდის შემთხვევაში შპს ”კონსალტინგ გრუპს” მასზე გადასცემს განკარგულებას ქონებაზე საკუთრების უფლების მოპოვების შესახებ." + (char)(13));
                    TC1.AppendText("ვ) იმ შემთხვევაში თუ მიწის ნაკვეთის (ქონების) სტატუსი რეალიზაციის მომენტისათვის წარმოადგენს სასოფლო-სამეურნეოს, მონაწილე პირი უნდა აკმაყოფილებდეს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს; ასეთ შემთხვევაში აუქციონში მონაწილეობის მსურველმა უნდა წარადგინოს იმის დამადასტურებელი ინფორმაცია, რომ იგი აკმაყოფილებს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს;" + (char)(13));
                    TC1.AppendText(" " + (char)(13));
                    TC1.AppendText("ყურადღება: ქონების რეალიზაცია შესაძლებელია თავიდან იქნას აცილებული, თუ ნებისმიერი პირი (მათ შორის მსესხებელი, უძრავი ქონების მესაკუთრე ან/და სხვა დაინტერესებული პირი) აუქციონის დაწყებამდე განახორციელებს მსესხებლის მიერ კრედიტორს მიმართ არსებული სასესხო და მასთან დაკავშირებული ხარჯების დავალიანების სრულად დაფარვას.ყველა პირი, რომელსაც აქვს რაიმე სახის უფლებები უძრავ ქონებაზე, ვალდებულია ამ უფლებათა დამადასტურებელი მტკიცებულებანი წარმოადგინოს აუქციონის დაწყებამდე წერილობითი ფორმით სპეციალისტთან." + (char)(13));
                }
                else
                {
                    if (auct == "0")
                    {

                        if (liv == "LIVO")
                        {
                            TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს. " + (char)(13));
                            TC1.AppendText("ბ) Auction.livo.ge აუქციონში მონაწილეობის ყველა მსურველმა უნდა გაიაროს რეგისტრაცია და გადაიხადოს საგარანტიო თანხა პერსონალური ბალანსის მეშვეობით. მომხმარებელს პერსონალურ ბალანსზე თანხის შეტანა შეუძლია ვებ-გვერდზე მითითებულ კომპანიის ანგარიშზე: ა) ნებისმიერი ბანკის მეშვეობით, სპეციალური დანიშნულების მითითებით; ბ) საბანკო ანგარიშიდან გადმორიცხვით; გ) ვებგვერდზე პლასტიკური ბარათის მონაცემების შეყვანით.  " + (char)(13));
                        }
                        else
                        {
                            TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს. " + (char)(13));
                            TC1.AppendText("ბ) eAuction.ge აუქციონში მონაწილეობის ყველა მსურველმა უნდა გაიაროს რეგისტრაცია და გადაიხადოს საგარანტიო თანხა შემდეგი ფორმით : " + (char)(13));
                            TC1.AppendText("აა. ნაღდი ანგარიშსწორებით ლიბერთი ბანკში განაცხადის ნომრითა და პირადობის დამადასტურებელი საბუთით " + (char)(13));
                            TC1.AppendText("ბბ. უნაღდო ანგარიშსწორებით eAuction.ge-ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე " + (char)(13));
                            TC1.AppendText("გგ. eAuction.ge-ს ვებ - გვერდიდან პლასტიკური ბარათით " + (char)(13));
                            TC1.AppendText("დდ. ელექტრონული საბანკო გარანტიის აქტივაციით. გაცემული კრედიტორს (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის დასრულების თარიღიდან 15 საბანკო დღე. პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას აუქციონის მითითებული ფორმით, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));
                        }

                        /*TC1.AppendText("1. ნაღდი ანგარიშსწორებით ლიბერთი ბანკში განაცხადის ნომრითა და პირადობის დამადასტურებელი საბუთით " + (char)(13));

                        if (liv == "LIVO")
                        {
                            TC1.AppendText("2. უნაღდო ანგარიშსწორებით auction.livo.ge-ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე " + (char)(13));
                        }
                        else
                        {
                            TC1.AppendText("2. უნაღდო ანგარიშსწორებით eAuction.ge-ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე " + (char)(13));
                        }

                        if (liv == "LIVO")
                        {
                            TC1.AppendText("3. auction.livo.ge-ს ვებ - გვერდიდან პლასტიკური ბარათით" + (char)(13));
                        }
                        else
                        {
                            TC1.AppendText("3. eAuction.ge-ს ვებ - გვერდიდან პლასტიკური ბარათით" + (char)(13));
                        }
                        TC1.AppendText("4. ელექტრონული საბანკო გარანტიის აქტივაციით. გაცემული კრედიტორს (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის დასრულების თარიღიდან 15 საბანკო დღე. პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას აუქციონის მითითებული ფორმით, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));*/
                        TC1.AppendText("გ) იმ შემთხევაში, თუ აუქციონზე საწყისი ფასი არის 100 000 ლარამდე, ბიჯის ოდენობა განისაზღვრება - 100 ლარის ოდენობით; 100 000 ლარიდან 500 000 ლარის ჩათვლით  - 500 ლარის ოდენობით; ხოლო, 500 000 ლარზე მეტის შემთხვევაში - 1000 ლარის ოდენობით; აუქციონი გრძელდება ბოლო შემოთავაზებამდე. აუქციონზე გამარჯვებულია ის პირი, ვინც უფრო მაღალ ფასს შესთავაზებს." + (char)(13));
                        TC1.AppendText("დ) აუქციონში გამარჯვებულმა აუქციონის თანხა სრულად უნდა შეიტანოს სპეცილისტის სადეპოზიტო ანგარიშზე აუქციონის დასრულების დღიდან 7 საბანკო დღის მანძილზე. წინააღმდეგ შემთხვევაში იგი კარგავს მის მიერ საბანკო გარანტიის სახით წარმოდგენილ თანხას და უქმდება მისი, როგორც აუქციონზე გამარჯვებულის სტატუსი." + (char)(13));
                        TC1.AppendText("ე) აუქციონში გამარჯვებულის მიერ შესაბამის ვადაში აუქციონის თანხის სრულად გადახდის შემთხვევაში შპს ”კონსალტინგ გრუპს” მასზე გადასცემს განკარგულებას ქონებაზე საკუთრების უფლების მოპოვების შესახებ." + (char)(13));
                        TC1.AppendText("ვ) იმ შემთხვევაში თუ მიწის ნაკვეთის (ქონების) სტატუსი რეალიზაციის მომენტისათვის წარმოადგენს სასოფლო-სამეურნეოს, მონაწილე პირი უნდა აკმაყოფილებდეს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს; ასეთ შემთხვევაში აუქციონში მონაწილეობის მსურველმა უნდა წარადგინოს იმის დამადასტურებელი ინფორმაცია, რომ იგი აკმაყოფილებს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს;" + (char)(10) + (char)(13));
                    }
                    else
                    {
                        TC1.AppendText("ა) აუქციონში მონაწილეობის უფლება აქვს ყველა პირს, მათ შორის კრედიტორს კრედიტორს, მოვალეს ან/და უძრავი ქონების მესაკუთრეს. " + (char)(13));
                        TC1.AppendText("ბ) აუქციონში მონაწილეობის ყველა მსურველმა უნდა გაიაროს რეგისტრაცია და გადაიხადოს საგარანტიო თანხა შემდეგი ფორმით : " + (char)(13));
                        TC1.AppendText("1. ნაღდი ანგარიშსწორებით ნებისმიერ ბანკში განაცხადის ნომრითა და პირადობის დამადასტურებელი საბუთით " + (char)(13));
                        TC1.AppendText("2. უნაღდო ანგარიშსწორებით www.auctionhouse.ge -ს ვებ გვერდზე მითითებული დანიშნულებით მითითებულ ანგარიშზე; " + (char)(13));
                        TC1.AppendText("3. www.auctionhouse.ge -ს ვებ - გვერდიდან პლასტიკური ბარათით" + (char)(13));
                        TC1.AppendText("4. ელექტრონული საბანკო გარანტიის აქტივაციით. გაცემული კრედიტორს (ბენეფიციარის) სასარგებლოდ, უძრავი ნივთის საწყისი ფასის არანაკლებ ერთი მეათედის ოდენობით და გარანტიის მინიმალური ვადით არანაკლებ აუქციონის დასრულების თარიღიდან 15 საბანკო დღე. პირს, რომელიც ვერ წარმოადგენს შესაბამის საბანკო გარანტიას აუქციონის მითითებული ფორმით, ეკრძალება აუქციონში მონაწილეობა." + (char)(13));
                        TC1.AppendText("გ) იმ შემთხევაში, თუ აუქციონზე საწყისი ფასი არის 100 000 ლარამდე, ბიჯის ოდენობა განისაზღვრება - 100 ლარის ოდენობით; 100 000 ლარიდან 500 000 ლარის ჩათვლით  - 500 ლარის ოდენობით; ხოლო, 500 000 ლარზე მეტის შემთხვევაში - 1000 ლარის ოდენობით; აუქციონი გრძელდება ბოლო შემოთავაზებამდე. აუქციონზე გამარჯვებულია ის პირი, ვინც უფრო მაღალ ფასს შესთავაზებს." + (char)(13));
                        TC1.AppendText("დ) აუქციონში გამარჯვებულმა აუქციონის თანხა სრულად უნდა შეიტანოს სპეცილისტის სადეპოზიტო ანგარიშზე აუქციონის დასრულების დღიდან 2 საბანკო დღის მანძილზე. წინააღმდეგ შემთხვევაში იგი კარგავს მის მიერ საბანკო გარანტიის სახით წარმოდგენილ თანხას და უქმდება მისი, როგორც აუქციონზე გამარჯვებულის სტატუსი." + (char)(13));
                        TC1.AppendText("ე) აუქციონში გამარჯვებულის მიერ შესაბამის ვადაში აუქციონის თანხის სრულად გადახდის შემთხვევაში შპს ”კონსალტინგ გრუპს” მასზე გადასცემს განკარგულებას ქონებაზე საკუთრების უფლების მოპოვების შესახებ." + (char)(13));
                        TC1.AppendText("ვ) იმ შემთხვევაში თუ მიწის ნაკვეთის (ქონების) სტატუსი რეალიზაციის მომენტისათვის წარმოადგენს სასოფლო-სამეურნეოს, მონაწილე პირი უნდა აკმაყოფილებდეს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს; ასეთ შემთხვევაში აუქციონში მონაწილეობის მსურველმა უნდა წარადგინოს იმის დამადასტურებელი ინფორმაცია, რომ იგი აკმაყოფილებს „სასოფლო-სამეურნეო დანიშნულების მიწის საკუთრების შესახებ“ საქართველოს ორგანული კანონით დადგენილ მოთხოვნებს;" + (char)(10) + (char)(13));
                    }
                }
                TC1.AppendText("ყურადღება: ქონების რეალიზაცია შესაძლებელია თავიდან იქნას აცილებული, თუ ნებისმიერი პირი (მათ შორის, მსესხებელი, უძრავი ქონების მესაკუთრე ან/და სხვა დაინტერესებული პირი) აუქციონის დაწყებამდე განახორციელებს მსესხებლის მიერ კრედიტორის მიმართ არსებული სასესხო და მასთან დაკავშირებული ხარჯების დავალიანების სრულად დაფარვას." + (char)(13));
                TC1.AppendText("ყველა პირი, რომელსაც აქვს რაიმე სახის უფლებები უძრავ ქონებაზე, ვალდებულია ამ უფლებათა დამადასტურებელი მტკიცებულებანი წარმოადგინოს აუქციონის დაწყებამდე წერილობითი ფორმით სპეციალისტთან." + (char)(10) + (char)(13));
                TC1.AppendText("სპეციალისტი:   შპს „კონსალტინგ გრუპს”, ს/კ 404483536  " + (char)(13));
                //TC1.AppendText("დირექტორი       ნინო არაბიძე" + (char)(10) + (char)(13));
                TC1.AppendText("დირექტორი       თამარ მაღალაშვილი" + (char)(10) + (char)(13));
            }

            if (moqme == 8)
            {
                TC1.AppendText("სსიპ საქართველოს საკანონმდებლო მაცნეს" + (char)(13));
                TC1.AppendText("დირექტორს  ბატონ  ნიკა ახალბედაშვილს" + (char)(10) + (char)(13));
                TC1.AppendText("შპს „კონსალტინგ გრუპს“-ის (ს/კ 404483536 )" + (char)(10) + (char)(13));
                TC1.AppendText("                                                                      გ ა ნ ც ხ ა დ ე ბ ა" + (char)(10) + (char)(13));
                TC1.AppendText("წარმოგიდგენთ საჯარო განცხადებას, აუქციონის დანიშვნის შესახებ " + (char)(13));
                TC1.AppendText("მესაკუთრე: " + qw + " , პირადი N " + rw + (char)(13));
                TC1.AppendText("გთხოვთ, წარმოდგენილი განცხადება თარიღით: " + apw + " განათავსოთ საიტზე - " + (char)(13));
                TC1.AppendText("www.matsne.gov.ge" + (char)(10) + (char)(13));
                TC1.AppendText("დანართი:" + (char)(13));
                TC1.AppendText("          1. მიმართვა საკანონმდებლო მაცნეს;" + (char)(13));
                TC1.AppendText("          2. საჯარო განცხადება აუქციონის დანიშვნის შესახებ;" + (char)(13));
                TC1.AppendText("          3. საგადახდო დავალება;" + (char)(10) + (char)(13));
                TC1.AppendText("შპს „კონსალტინგ გრუპს“" + (char)(13));
                TC1.AppendText("დირექტორი " + (char)(13));
                //TC1.AppendText("ნინო არაბიძე" + (char)(10) + (char)(13));
                TC1.AppendText("თამარ მაღალაშვილი" + (char)(10) + (char)(13));
            }

            if (moqme == 9)
            {
                /*TC1.AppendText(" " + (char)(10) + (char)(13));*/
                TC1.AppendText(" " + (char)(10));
                TC1.AppendText("                                                                       განკარგულება " + (char)(13));
                TC1.AppendText("                                                            აუქციონზე შეძენილ ქონებაზე " + (char)(13));
                TC1.AppendText("                                               საკუთრების უფლების წარმოშობის შესახებ " + (char)(13));
                TC1.AppendText("                                                                       N " + am + (char)(10) + (char)(13));
                TC1.AppendText("                                                                       " + dd + (char)(10) + (char)(13));
                TC1.AppendText("სპეციალისტი:     შპს ”კონსალტინგ გრუპს”	ს/კ 404483536  " + (char)(13));
                //TC1.AppendText("დირექტორი:        ნინო არაბიძე" + (char)(13));
                TC1.AppendText("დირექტორი:        თამარ მაღალაშვილი" + (char)(13));
                TC1.AppendText("მისამართი:          ქ. თბილისი, ვ. პეტრიაშვილის N 10" + (char)(13));
                TC1.AppendText("ელ ფოსტა:           auction@cgg.ge" + (char)(10) + (char)(13));
                TC1.AppendText("საქართველოს სამოქალაქო კოდექსის 306/5–ე მუხლის საფუძველზე სპეციალისტი გამოსცემს განკარგულებას, რომლითაც დასტურდება შემდგარი აუქციონის, მასში გამარჯვებულის, უძრავი ქონების აუქციონზე შეძენისა და მის მიერ აუქციონის თანხის სრულფასოვნად გადახდის ფაქტი." + (char)(10) + (char)(13));
                TC1.AppendText("შპს „კონსალტინგ გრუპს“ ადასტურებს, რომ შემძენმა სრულად დაფარა აუქციონის თანხა;" + (char)(10) + (char)(13));
                TC1.AppendText("აუქციონზე შეძენილი ქონება (უძრავი ნივთის აღწერა)" + (char)(13));
                TC1.AppendText("საკადასტრო კოდი: " + nw + (char)(13));
                TC1.AppendText("მისამართი: " + mw + (char)(13));
                TC1.AppendText("აუქციონზე ქონების შემძენი: " + (char)(13));
                TC1.AppendText("" + btw + (char)(13));
                tanhurda = buw.Substring(buw.Length - 2, 2);
                tanhafu = buw.Substring(0, buw.Length - 3);
                pr_sit();
                TC1.AppendText("აუქციონის დასრულების ფასი (აუქციონის თანხა): " + buw + " ლარი (" + sitkfu + " ლარი და " + tanhurda + " თეთრი)" + (char)(10) + (char)(13));
                TC1.AppendText("აუქციონის პირობები და მსვლელობა: " + (char)(13));
                TC1.AppendText("კრედიტორი: " + dw + (char)(13));
                TC1.AppendText("მესაკუთრე: " + qw + " , პირადი N: " + rw + (char)(13));
                TC1.AppendText("მოვალე (მსესხებელი): " + ww + " , პირადი N: " + xw + (char)(13));
                TC1.AppendText("იპოთეკის ხელშეკრულება: " + gw + " , თარიღი: " + hw + (char)(13));
                TC1.AppendText("ვალდებულების წარმოშობა: " + iw + (char)(13));
                TC1.AppendText("უძრავი ქონების რეკვიზიტები: მისამართი: " + mw + " , საკადასტრო კოდი: " + nw + (char)(10) + (char)(13));
                /*TC1.AppendText("სასესხო დავალიანების ჯამური ოდენობა: " + kw + (char)(10) + (char)(13));*/
                if (auc == "პირველი")
                {
                    TC1.AppendText("აუქციონის ჩატარების დრო:  " + aqw);
                }
                if (auc == "მეორე")
                {
                    TC1.AppendText("აუქციონის ჩატარების დრო:  " + bdw);
                }
                if (auc == "მესამე")
                {
                    TC1.AppendText("აუქციონის ჩატარების დრო:  " + bqw);
                }
                if (auc == "პირველი")
                {
                    TC1.AppendText(" საათიდან  " + arw);
                }
                if (auc == "მეორე")
                {
                    TC1.AppendText(" საათიდან  " + bew);
                }
                if (auc == "მესამე")
                {
                    TC1.AppendText(" საათიდან  " + brw);
                }
                TC1.AppendText(" საათამდე" + (char)(13));
                TC1.AppendText("აუქციონის ჩატარების ადგილი: " + adg + (char)(10) + (char)(13));
                TC1.AppendText("აუქციონის რიგითობა: " + auc + " აუქციონი" + (char)(13));

                if (auc == "პირველი")
                {
                    TC1.AppendText("აუქციონის ლოტის N " + asw);
                }
                if (auc == "მეორე")
                {
                    TC1.AppendText("აუქციონის ლოტის N " + bfw);
                }
                if (auc == "მესამე")
                {
                    TC1.AppendText("აუქციონის ლოტის N " + bsw);
                }

                TC1.AppendText(" " + (char)(13));
                TC1.AppendText("უძრავი ნივთის საწყისი ფასი: " + aj + " ლარი" + (char)(13));

                TC1.AppendText("უძრავი ნივთის აღწერა:  " + ow + (char)(13));
                TC1.AppendText("გარდამავალი უფლებები:  " + pw + (char)(10) + (char)(13));

                TC1.AppendText(fw + " წელს კრედიტორმა განცხადებით (დავალებით) მომართა სპეციალისტს საკრედიტო მოთხოვნის (სასესხო დავალიანების) დაკმაყოფილების მიზნით სამოქალაქო კოდექსის შესაბამისად იპოთეკით დატვირთული უძრავი ქონების შეთანხმებული აუქციონის ფორმით რეალიზაციის შესახებ." + (char)(10) + (char)(13));
                TC1.AppendText("ვინაიდან მესაკუთრეს და კრედიტორს შორის შეთანხმებულია სპეციალისტის გზით (იპოთეკის ხელშეკრულება) აუქციონის ფორმა, სპეციალისტს და განმკარგავ ორგანიზაცის კრედიტორის დავალების საფუძველზე წარმოადგენს შპს „კონსალტინგ გრუპს“." + (char)(10) + (char)(13));
                TC1.AppendText("კრედიტორსა და მსესხებელს შორის დაიდო საკრედიტო ხელშეკრულება, რომელიც უზრუნველყოფილია უძრავ ქონებაზე რეგისტრირებული იპოთეკის უფლებით.კრედიტორის განცხადებით, მსესხებლის მიერ დარღვეული იქნა საკრედიტო ხელშეკრულების პირობები. მსესხებელი და უძრავი ქონების მესაკუთრე უშედეგოდ იქნენ გაფრთხილებულნი ვალდებულების შეუსრულებლობით გამოწვეულ თანამდევ შედეგებზე. სამოქალაქო კოდექსის თანახმად თუ მოვალე არ დააკმაყოფილებს მოთხოვნას, რომლის უზრუნველყოფის საშუალებაც არის იპოთეკა, იპოთეკარი უფლებამოსილია, მოითხოვოს უძრავი ნივთის რეალიზაცია." + (char)(10) + (char)(13));
                TC1.AppendText("პირველი აუქციონი" + (char)(13));

                TC1.AppendText(aiw + " წელს სპეციალისტის მიერ გაგზავნილ იქნა წერილობითი შეტყობინება (გამაფრთხილებელი წერილი)" + (char)(13));
                TC1.AppendText("მესაკუთრესათვის " + qw + "აუქციონის დანიშვნისა და შესაძლო შედეგების შესახებ." + (char)(13));
                TC1.AppendText("სპეციალისტის მიერ განხორციელდა პირველი საჯარო აუქციონის ჩატარების დროისა და ადგილის" + (char)(13));
                TC1.AppendText("შესახებ განცხადების საჯაროდ გამოქვეყნება მასობრივი ინფორმაციის საშუალებებით, გაზეთ რეზონანსში." + (char)(13));

                if (apw1 != "")
                {
                    TC1.AppendText("სპეციალისტის მიერ განხორციელდა სატელეფონო შეტყობინება მესაკუთრისათვის აუქციონის დანიშვნისა და შესაძლო შედეგების შესახებ მესაკუთრის საკონტაქტო ტელეფონის ნომერზე." + (char)(13));
                }

                if (arw1 != "")
                {
                    TC1.AppendText("სპეციალისტის მიერ განხორციელდა საჯარო შეტყობინება მესაკუთრისათვის აუქციონის დანიშვნისა და შესაძლო შედეგების შესახებ პუბლიკაციის გზით, საქართველოს სამოქალაქო კოდექსის 306/2 მე-3 ნაწილის, ასევე საქართველოს სამოქალაქო საპროცესო კოდექსის 78-ე მუხლის შესაბამისად. ვინაიდან მესაკუთრეს ორჯერ გაეგზავნა წერილობითი შეტყობინება აუქციონის დანიშვნის შესახებ რისი ჩაბარებაც მესაკუთრეზე ვერ მოხერხდა, სპეციალისტმა გამოიყენა შესაძლებლობა შეტყობინების საჯაროდ გავრცელების (პუბლიკაციის) შესახებ. საჯარო შეტყობინების საშუალებად გამოყენებულია „საკანონმდებლო მაცნე“." + (char)(13));
                }

                TC1.AppendText("ელექტრონული აუქციონი ჩატარებულ იქნა ინტერნეტ მისამართზე: " + adg + (char)(13));
                TC1.AppendText("ლოტის N " + asw + (char)(13));
                TC1.AppendText("აუქციონი დაიწყო " + aqw + " საათზე და დასრულდა " + arw + " საათზე." + (char)(10) + (char)(13));

                if ((auc == "მეორე") || (auc == "მესამე"))
                {
                    TC1.AppendText("მეორე აუქციონი" + (char)(13));
                    TC1.AppendText("პირველი საჯარო აუქციონი დასრულდა უშედეგოდ, შესაბამისად, გამოცხადდა მეორე საჯარო აუქციონი." + (char)(13));
                    TC1.AppendText(avw + " წელს სპეციალისტის მიერ გაგზავნილ იქნა წერილობითი შეტყობინება (გამაფრთხილებელი წერილი)" + (char)(13));
                    TC1.AppendText("მესაკუთრესათვის " + qw + "აუქციონის დანიშვნისა და შესაძლო შედეგების შესახებ." + (char)(13));
                    TC1.AppendText("სპეციალისტის მიერ განხორციელდა პირველი საჯარო აუქციონის ჩატარების დროისა და ადგილის" + (char)(13));
                    TC1.AppendText("შესახებ განცხადების საჯაროდ გამოქვეყნება მასობრივი ინფორმაციის საშუალებებით, გაზეთ რეზონანსში." + (char)(13));

                    if (apw2 != "")
                    {
                        TC1.AppendText("სპეციალისტის მიერ განხორციელდა სატელეფონო შეტყობინება მესაკუთრისათვის აუქციონის დანიშვნისა და შესაძლო შედეგების შესახებ მესაკუთრის საკონტაქტო ტელეფონის ნომერზე." + (char)(13));
                    }

                    if (arw2 != "")
                    {
                        TC1.AppendText("სპეციალისტის მიერ განხორციელდა საჯარო შეტყობინება მესაკუთრისათვის აუქციონის დანიშვნისა და შესაძლო შედეგების შესახებ პუბლიკაციის გზით, საქართველოს სამოქალაქო კოდექსის 306/2 მე-3 ნაწილის, ასევე საქართველოს სამოქალაქო საპროცესო კოდექსის 78-ე მუხლის შესაბამისად. ვინაიდან მესაკუთრეს ორჯერ გაეგზავნა წერილობითი შეტყობინება აუქციონის დანიშვნის შესახებ რისი ჩაბარებაც მესაკუთრეზე ვერ მოხერხდა, სპეციალისტმა გამოიყენა შესაძლებლობა შეტყობინების საჯაროდ გავრცელების (პუბლიკაციის) შესახებ. საჯარო შეტყობინების საშუალებად გამოყენებულია „საკანონმდებლო მაცნე“." + (char)(13));
                    }
                    TC1.AppendText("ელექტრონული აუქციონი ჩატარებულ იქნა ინტერნეტ მისამართზე: " + adg + (char)(13));
                    TC1.AppendText("ლოტის N " + bfw + (char)(13));
                    TC1.AppendText("აუქციონი დაიწყო " + bdw + " საათზე და დასრულდა " + bew + " საათზე." + (char)(10) + (char)(13));
                }

                if (auc == "მესამე")
                {
                    TC1.AppendText("მესამე აუქციონი" + (char)(13));
                    TC1.AppendText("მეორე საჯარო აუქციონი დასრულდა უშედეგოდ, შესაბამისად, გამოცხადდა მესამე საჯარო აუქციონი." + (char)(13));
                    TC1.AppendText(biw + " წელს სპეციალისტის მიერ გაგზავნილ იქნა წერილობითი შეტყობინება (გამაფრთხილებელი წერილი)" + (char)(13));
                    TC1.AppendText("მესაკუთრესათვის " + qw + "აუქციონის დანიშვნისა და შესაძლო შედეგების შესახებ." + (char)(13));
                    TC1.AppendText("სპეციალისტის მიერ განხორციელდა პირველი საჯარო აუქციონის ჩატარების დროისა და ადგილის" + (char)(13));
                    TC1.AppendText("შესახებ განცხადების საჯაროდ გამოქვეყნება მასობრივი ინფორმაციის საშუალებებით, გაზეთ რეზონანსში." + (char)(13));

                    if (apw3 != "")
                    {
                        TC1.AppendText("სპეციალისტის მიერ განხორციელდა სატელეფონო შეტყობინება მესაკუთრისათვის აუქციონის დანიშვნისა და შესაძლო შედეგების შესახებ მესაკუთრის საკონტაქტო ტელეფონის ნომერზე." + (char)(13));
                    }

                    if (arw3 != "")
                    {
                        TC1.AppendText("სპეციალისტის მიერ განხორციელდა საჯარო შეტყობინება მესაკუთრისათვის აუქციონის დანიშვნისა და შესაძლო შედეგების შესახებ პუბლიკაციის გზით, საქართველოს სამოქალაქო კოდექსის 306/2 მე-3 ნაწილის, ასევე საქართველოს სამოქალაქო საპროცესო კოდექსის 78-ე მუხლის შესაბამისად. ვინაიდან მესაკუთრეს ორჯერ გაეგზავნა წერილობითი შეტყობინება აუქციონის დანიშვნის შესახებ რისი ჩაბარებაც მესაკუთრეზე ვერ მოხერხდა, სპეციალისტმა გამოიყენა შესაძლებლობა შეტყობინების საჯაროდ გავრცელების (პუბლიკაციის) შესახებ. საჯარო შეტყობინების საშუალებად გამოყენებულია „საკანონმდებლო მაცნე“." + (char)(13));
                    }
                    TC1.AppendText("ელექტრონული აუქციონი ჩატარებულ იქნა ინტერნეტ მისამართზე: " + adg + (char)(13));
                    TC1.AppendText("ლოტის N " + bsw + (char)(13));
                    TC1.AppendText("აუქციონი დაიწყო " + bqw + " საათზე და დასრულდა " + brw + " საათზე." + (char)(10) + (char)(13));
                }

                TC1.AppendText("აუქციონში მონაწილეობა მიიღო " + btw + " , რომელმაც გაიმარჯვა და ქონება " + (char)(13));
                TC1.AppendText("შეიძინა: " + buw + " ლარად." + (char)(10) + (char)(13));

                TC1.AppendText("აუქციონზე ქონების შემძენი უფლებამოსილია დარეგისტრირდეს საჯარო რეესტრში უძრავი ქონების მესაკუთრედ. საკუთრების გადასვლის შემდეგ უქმდება ყველა ის იპოთეკა (მათ შორის საგადასახადო გირავნობა/იპოთეკა) და სანივთო უფლება, რომელიც რეგისტრირებული იყო რეალიზაციის განმახორციელებელი კრედიტორის იპოთეკის შემდეგ. მანამდე რეგისტრირებული სანივთო უფლებები ნივთზე ასევე ვალდებულებით სამართლებრივი უფლებები უცვლელი რჩება." + (char)(13));
                TC1.AppendText("აუქციონზე გაყიდული უძრავი ნივთის ახალი მესაკუთრე იკავებს ძველი მესაკუთრის ადგილს და ხდება საკუთრების გადასვლის მომენტისათვის ამ ნივთთან დაკავშირებული სამართლებრივი ურთიერთობის მონაწილე." + (char)(13));
                TC1.AppendText("უძრავი ნივთის ახალ მესაკუთრეზე გადასვლის მომენტიდან ძველი მესაკუთრე კარგავს ყოველგვარ უფლებას ამ ნივთზე." + (char)(10) + (char)(13));
                TC1.AppendText("განკარგულება ძალაშია მისი გამოცემისთანავე." + (char)(10) + (char)(13));

                TC1.AppendText("სპეციალისტი:   შპს ”კონსალტინგ გრუპს”, ს/კ 404483536  " + (char)(13));
                //TC1.AppendText("დირექტორი       ნინო არაბიძე" + (char)(10) + (char)(13));
                TC1.AppendText("დირექტორი       თამარ მაღალაშვილი" + (char)(10) + (char)(13));
            }

            if (moqme == 10)
            {
                TC1.AppendText("                                                                       საანგარიშსწორებო დავალება " + (char)(13));
                TC1.AppendText("                                                                        და მიღება ჩაბარების აქტი " + (char)(10) + (char)(13));
                TC1.AppendText("შპს კონსალტინგ გრუპს, ს/კ.: 	404483536" + (char)(13));
                TC1.AppendText("თარიღი:                                              " + ddn + (char)(13));
                TC1.AppendText("აუქციონის N                                    " + nn + (char)(13));
                TC1.AppendText("განაცხადის N                                  " + nn + " NWK " + an + "/18" + (char)(13));
                TC1.AppendText("აუქციონის თანხა                           " + buw + " ლარი" + (char)(10) + (char)(13));
                TC1.AppendText("მიმღები : " + mimg + (char)(13));
                TC1.AppendText("რეკვიზიტები : ა/ა 707027022 სახელმწიფო ხაზინა ბანკის კოდი TRESGE22 სახაზინო კოდი 707027022" + (char)(13));
                TC1.AppendText("დანიშნულება : გ.ნ " + nn + " NWK " + an + "/18 ელ. აუქციონზე რეალიზებული ქონების ღირებულების 1 პროც მომსახურების საფასური. შემძენი " + btw + " განმკარგავი 404483536  ს.ნ " + nn + (char)(13));
                TC1.AppendText("თანხა : " + cc + " ლარი" + (char)(10) + (char)(13));
                TC1.AppendText("კრედიტორი " + (char)(13));
                TC1.AppendText("რეკვიზიტები : " + rekv + (char)(13));
                TC1.AppendText("დანიშნულება : აუქციონზე ამონაგები თანხის გადარიცხვა კრედიტორისთვის. აუქციონი " + nn + " მოვალე " + ww + " , " + xw + (char)(13));
                TC1.AppendText("თანხა : " + ce0 + " ლარი" + (char)(10) + (char)(13));
                TC1.AppendText("სახელმწიფო ხაზინა " + (char)(13));
                TC1.AppendText("რეკვიზიტები : 101001000 " + (char)(13));
                TC1.AppendText("დანიშნულება : დღგ მესაკუთრე " + qw + " პ.ნ " + rw + (char)(13));
                TC1.AppendText("თანხა : " + cd + " ლარი" + (char)(10) + (char)(13));
                TC1.AppendText("შპს კონსალტინგ გრუპს,~ის შემოსავალი " + (char)(13));
                TC1.AppendText("რეკვიზიტები : 3 %  " + (char)(13));
                TC1.AppendText("დანიშნულება : თანახმად იპოთეკის ხელშეკრულებისა და სს თიბისი ბანკთან მოქმედი მემორანდუმისა N 002 TBC 2017, 01.09.2017 " + (char)(13));
                TC1.AppendText("თანხა : " + cb0 + " ლარი" + (char)(10) + (char)(13));
                TC1.AppendText(" " + (char)(10) + (char)(13));
                TC1.AppendText("შპს კონსალტინგ გრუპს " + (char)(13));
                TC1.AppendText(" " + (char)(10) + (char)(13));
                TC1.AppendText("სს თიბისი ბანკი  " + (char)(13));

            }

            if ((moqme != 5) && (moqme != 6) && (moqme != 7) && (moqme != 9) && (moqme != 10))
            {

                //Clipboard.SetImage(Image.FromFile("Pej.bmp"));
                Clipboard.SetImage(Image.FromFile("Pej_Magalashvili.bmp"));
                TC1.Paste();
            }

        }

        private void pr_cl_mail(object sender, EventArgs e)
        {
            Pa_mail.Visible = false;
        }

        private void pr_mail(object sender, EventArgs e)
        {
            TB_to.Text = mail;
            TB_from.Text = "auction@cgg.ge";
            TB_sub.Text = "";

            Pa_mail.BringToFront();
            Pa_mail.Visible = true;
        }

        private void pr_send(object sender, EventArgs e)
        {
            System.Net.Mail.MailMessage tserili = new System.Net.Mail.MailMessage();
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            smtp.Host = "smtp.gmail.com";            

            tserili.Subject = TB_sub.Text;

            MailAddress fromAddress = new MailAddress(TB_from.Text.Trim());
            tserili.From = fromAddress;

            smtp.Port = 587;
            /*smtp.Port = 465;*/
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential(TB_from.Text.Trim(), "consultingauction$$$");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            tserili.Body = TC1.Text;

            tserili.To.Add(TB_to.Text);

            try
            {
                smtp.Send(tserili);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

            Pa_mail.Visible = false;
        }

        private void pr_bold(object sender, EventArgs e)
        {
            /*MessageBox.Show(TC1.SelectionFont.FontFamily.Name.ToString() + " " + TC1.SelectionFont.Size.ToString());
            MessageBox.Show(TC1.SelectionStart.ToString() + " " + TC1.SelectionLength.ToString());*/

            TC1.SelectionFont = new System.Drawing.Font(TC1.SelectionFont.FontFamily, TC1.SelectionFont.Size, FontStyle.Bold);
        }

        private void pr_reg(object sender, EventArgs e)
        {
            TC1.SelectionFont = new System.Drawing.Font(TC1.SelectionFont.FontFamily, TC1.SelectionFont.Size, FontStyle.Regular);
        }

        private void pr_size(object sender, EventArgs e)
        {
            TC1.Focus();
            TC1.Select(selst, sellen);
            float fs = float.Parse(TB_size.Text, System.Globalization.CultureInfo.InvariantCulture);
            TC1.SelectionFont = new System.Drawing.Font(TC1.SelectionFont.FontFamily, fs, TC1.Font.Style);
        }

        private void pr_selc(object sender, EventArgs e)
        {
            selst = TC1.SelectionStart;
            sellen = TC1.SelectionLength;
        }

        private void pr_sit()
        {
            if ((tanhafu.Length <= 6) && (tanhafu.Length > 3))
            {
                if (tanhafu.Length == 6)
                {
                    if (tanhafu.Substring(0, 1) == "1")
                    {
                        sitkfu = sitkfu + "ას";
                    }
                    if (tanhafu.Substring(0, 1) == "2")
                    {
                        sitkfu = sitkfu + "ორას";
                    }
                    if (tanhafu.Substring(0, 1) == "3")
                    {
                        sitkfu = sitkfu + "სამას";
                    }
                    if (tanhafu.Substring(0, 1) == "4")
                    {
                        sitkfu = sitkfu + "ოთხას";
                    }
                    if (tanhafu.Substring(0, 1) == "5")
                    {
                        sitkfu = sitkfu + "ხუთას";
                    }
                    if (tanhafu.Substring(0, 1) == "6")
                    {
                        sitkfu = sitkfu + "ექვსას";
                    }
                    if (tanhafu.Substring(0, 1) == "7")
                    {
                        sitkfu = sitkfu + "შვიდას";
                    }
                    if (tanhafu.Substring(0, 1) == "8")
                    {
                        sitkfu = sitkfu + "რვაას";
                    }
                    if (tanhafu.Substring(0, 1) == "9")
                    {
                        sitkfu = sitkfu + "ცხრაას";
                    }

                }

                if ((tanhafu.Length == 5) || (tanhafu.Length == 6))
                {
                    if (tanhafu.Length == 5)
                    {
                        tanhafu = "0" + tanhafu;
                    }
                    if ((tanhafu.Substring(1, 1) == "0") || (tanhafu.Substring(1, 1) == "2") || (tanhafu.Substring(1, 1) == "4") || (tanhafu.Substring(1, 1) == "6") || (tanhafu.Substring(1, 1) == "8"))
                    {
                        if (tanhafu.Substring(1, 1) == "2")
                        {
                            sitkfu = sitkfu + "ოცდა";
                        }
                        if (tanhafu.Substring(1, 1) == "4")
                        {
                            sitkfu = sitkfu + "ორმოცდა";
                        }
                        if (tanhafu.Substring(1, 1) == "6")
                        {
                            sitkfu = sitkfu + "სამოცდა";
                        }
                        if (tanhafu.Substring(1, 1) == "8")
                        {
                            sitkfu = sitkfu + "ოთხმოცდა";
                        }
                        if (tanhafu.Substring(2, 1) == "0")
                        {
                            if ((tanhafu.Substring(1, 1) == "2") || (tanhafu.Substring(1, 1) == "4") || (tanhafu.Substring(1, 1) == "6") || (tanhafu.Substring(1, 1) == "8"))
                            {
                                sitkfu = sitkfu.Substring(0, sitkfu.Length - 2);
                            }
                            sitkfu = sitkfu + "ი";
                        }
                        if (tanhafu.Substring(2, 1) == "1")
                        {
                            sitkfu = sitkfu + "ერთი";
                        }
                        if (tanhafu.Substring(2, 1) == "2")
                        {
                            sitkfu = sitkfu + "ორი";
                        }
                        if (tanhafu.Substring(2, 1) == "3")
                        {
                            sitkfu = sitkfu + "სამი";
                        }
                        if (tanhafu.Substring(2, 1) == "4")
                        {
                            sitkfu = sitkfu + "ოთხი";
                        }
                        if (tanhafu.Substring(2, 1) == "5")
                        {
                            sitkfu = sitkfu + "ხუთი";
                        }
                        if (tanhafu.Substring(2, 1) == "6")
                        {
                            sitkfu = sitkfu + "ექვსი";
                        }
                        if (tanhafu.Substring(2, 1) == "7")
                        {
                            sitkfu = sitkfu + "შვიდი";
                        }
                        if (tanhafu.Substring(2, 1) == "8")
                        {
                            sitkfu = sitkfu + "რვა";
                        }
                        if (tanhafu.Substring(2, 1) == "9")
                        {
                            sitkfu = sitkfu + "ცხრა";
                        }
                    }
                    if ((tanhafu.Substring(1, 1) == "1") || (tanhafu.Substring(1, 1) == "3") || (tanhafu.Substring(1, 1) == "5") || (tanhafu.Substring(1, 1) == "7") || (tanhafu.Substring(1, 1) == "9"))
                    {
                        if (tanhafu.Substring(1, 1) == "3")
                        {
                            sitkfu = sitkfu + "ოცდა";
                        }
                        if (tanhafu.Substring(1, 1) == "5")
                        {
                            sitkfu = sitkfu + "ორმოცდა";
                        }
                        if (tanhafu.Substring(1, 1) == "7")
                        {
                            sitkfu = sitkfu + "სამოცდა";
                        }
                        if (tanhafu.Substring(1, 1) == "9")
                        {
                            sitkfu = sitkfu + "ოთხმოცდა";
                        }
                        if (tanhafu.Substring(2, 1) == "0")
                        {
                            sitkfu = sitkfu + "ათი";
                        }
                        if (tanhafu.Substring(2, 1) == "1")
                        {
                            sitkfu = sitkfu + "თერთმეტი";
                        }
                        if (tanhafu.Substring(2, 1) == "2")
                        {
                            sitkfu = sitkfu + "თორმეტი";
                        }
                        if (tanhafu.Substring(2, 1) == "3")
                        {
                            sitkfu = sitkfu + "ცამეტი";
                        }
                        if (tanhafu.Substring(2, 1) == "4")
                        {
                            sitkfu = sitkfu + "თოთხმეტი";
                        }
                        if (tanhafu.Substring(2, 1) == "5")
                        {
                            sitkfu = sitkfu + "თხუთმეტი";
                        }
                        if (tanhafu.Substring(2, 1) == "6")
                        {
                            sitkfu = sitkfu + "თექვსმეტი";
                        }
                        if (tanhafu.Substring(2, 1) == "7")
                        {
                            sitkfu = sitkfu + "ჩვიდმეტი";
                        }
                        if (tanhafu.Substring(2, 1) == "8")
                        {
                            sitkfu = sitkfu + "თვრამეტი";
                        }
                        if (tanhafu.Substring(2, 1) == "9")
                        {
                            sitkfu = sitkfu + "ცხრამეტი";
                        }

                    }
                }
                if (tanhafu.Length == 4)
                {
                    if (tanhafu.Substring(0, 1) == "1")
                    {
                        sitkfu = sitkfu + "ერთი";
                    }
                    if (tanhafu.Substring(0, 1) == "2")
                    {
                        sitkfu = sitkfu + "ორი";
                    }
                    if (tanhafu.Substring(0, 1) == "3")
                    {
                        sitkfu = sitkfu + "სამი";
                    }
                    if (tanhafu.Substring(0, 1) == "4")
                    {
                        sitkfu = sitkfu + "ოთხი";
                    }
                    if (tanhafu.Substring(0, 1) == "5")
                    {
                        sitkfu = sitkfu + "ხუთი";
                    }
                    if (tanhafu.Substring(0, 1) == "6")
                    {
                        sitkfu = sitkfu + "ექვსი";
                    }
                    if (tanhafu.Substring(0, 1) == "7")
                    {
                        sitkfu = sitkfu + "შვიდი";
                    }
                    if (tanhafu.Substring(0, 1) == "8")
                    {
                        sitkfu = sitkfu + "რვა";
                    }
                    if (tanhafu.Substring(0, 1) == "9")
                    {
                        sitkfu = sitkfu + "ცხრა";
                    }
                }
                if (sitkfu.Trim() != "")
                {
                    sitkfu = sitkfu + "ათას";
                }
                if (tanhafu.Length == 6)
                {
                    tanhafu = tanhafu.Substring(3, 3);
                }
                if (tanhafu.Length == 5)
                {
                    tanhafu = tanhafu.Substring(2, 3);
                }
                if (tanhafu.Length == 4)
                {
                    tanhafu = tanhafu.Substring(1, 3);
                }
            }
            if (tanhafu.Length == 3)
            {
                if (tanhafu.Substring(0, 1) == "1")
                {
                    sitkfu = sitkfu + "ას";
                }
                if (tanhafu.Substring(0, 1) == "2")
                {
                    sitkfu = sitkfu + "ორას";
                }
                if (tanhafu.Substring(0, 1) == "3")
                {
                    sitkfu = sitkfu + "სამას";
                }
                if (tanhafu.Substring(0, 1) == "4")
                {
                    sitkfu = sitkfu + "ოთხას";
                }
                if (tanhafu.Substring(0, 1) == "5")
                {
                    sitkfu = sitkfu + "ხუთას";
                }
                if (tanhafu.Substring(0, 1) == "6")
                {
                    sitkfu = sitkfu + "ექვსას";
                }
                if (tanhafu.Substring(0, 1) == "7")
                {
                    sitkfu = sitkfu + "შვიდას";
                }
                if (tanhafu.Substring(0, 1) == "8")
                {
                    sitkfu = sitkfu + "რვაას";
                }
                if (tanhafu.Substring(0, 1) == "9")
                {
                    sitkfu = sitkfu + "ცხრაას";
                }
            }
            if ((tanhafu.Length == 2) || (tanhafu.Length == 3))
            {
                if (tanhafu.Length == 2)
                {
                    tanhafu = "0" + tanhafu;
                }
                if ((tanhafu.Substring(1, 1) == "0") || (tanhafu.Substring(1, 1) == "2") || (tanhafu.Substring(1, 1) == "4") || (tanhafu.Substring(1, 1) == "6") || (tanhafu.Substring(1, 1) == "8"))
                {
                    if (tanhafu.Substring(1, 1) == "2")
                    {
                        sitkfu = sitkfu + "ოცდა";
                    }
                    if (tanhafu.Substring(1, 1) == "4")
                    {
                        sitkfu = sitkfu + "ორმოცდა";
                    }
                    if (tanhafu.Substring(1, 1) == "6")
                    {
                        sitkfu = sitkfu + "სამოცდა";
                    }
                    if (tanhafu.Substring(1, 1) == "8")
                    {
                        sitkfu = sitkfu + "ოთხმოცდა";
                    }
                    if (tanhafu.Substring(2, 1) == "0")
                    {
                        if ((tanhafu.Substring(1, 1) == "2") || (tanhafu.Substring(1, 1) == "4") || (tanhafu.Substring(1, 1) == "6") || (tanhafu.Substring(1, 1) == "8"))
                        {
                            sitkfu = sitkfu.Substring(0, sitkfu.Length - 2);
                        }
                        sitkfu = sitkfu + "ი";
                    }
                    if (tanhafu.Substring(2, 1) == "1")
                    {
                        sitkfu = sitkfu + "ერთი";
                    }
                    if (tanhafu.Substring(2, 1) == "2")
                    {
                        sitkfu = sitkfu + "ორი";
                    }
                    if (tanhafu.Substring(2, 1) == "3")
                    {
                        sitkfu = sitkfu + "სამი";
                    }
                    if (tanhafu.Substring(2, 1) == "4")
                    {
                        sitkfu = sitkfu + "ოთხი";
                    }
                    if (tanhafu.Substring(2, 1) == "5")
                    {
                        sitkfu = sitkfu + "ხუთი";
                    }
                    if (tanhafu.Substring(2, 1) == "6")
                    {
                        sitkfu = sitkfu + "ექვსი";
                    }
                    if (tanhafu.Substring(2, 1) == "7")
                    {
                        sitkfu = sitkfu + "შვიდი";
                    }
                    if (tanhafu.Substring(2, 1) == "8")
                    {
                        sitkfu = sitkfu + "რვა";
                    }
                    if (tanhafu.Substring(2, 1) == "9")
                    {
                        sitkfu = sitkfu + "ცხრა";
                    }
                }
                if ((tanhafu.Substring(1, 1) == "1") || (tanhafu.Substring(1, 1) == "3") || (tanhafu.Substring(1, 1) == "5") || (tanhafu.Substring(1, 1) == "7") || (tanhafu.Substring(1, 1) == "9"))
                {
                    if (tanhafu.Substring(1, 1) == "3")
                    {
                        sitkfu = sitkfu + "ოცდა";
                    }
                    if (tanhafu.Substring(1, 1) == "5")
                    {
                        sitkfu = sitkfu + "ორმოცდა";
                    }
                    if (tanhafu.Substring(1, 1) == "7")
                    {
                        sitkfu = sitkfu + "სამოცდა";
                    }
                    if (tanhafu.Substring(1, 1) == "9")
                    {
                        sitkfu = sitkfu + "ოთხმოცდა";
                    }
                    if (tanhafu.Substring(2, 1) == "0")
                    {
                        sitkfu = sitkfu + "ათი";
                    }
                    if (tanhafu.Substring(2, 1) == "1")
                    {
                        sitkfu = sitkfu + "თერთმეტი";
                    }
                    if (tanhafu.Substring(2, 1) == "2")
                    {
                        sitkfu = sitkfu + "თორმეტი";
                    }
                    if (tanhafu.Substring(2, 1) == "3")
                    {
                        sitkfu = sitkfu + "ცამეტი";
                    }
                    if (tanhafu.Substring(2, 1) == "4")
                    {
                        sitkfu = sitkfu + "თოთხმეტი";
                    }
                    if (tanhafu.Substring(2, 1) == "5")
                    {
                        sitkfu = sitkfu + "თხუთმეტი";
                    }
                    if (tanhafu.Substring(2, 1) == "6")
                    {
                        sitkfu = sitkfu + "თექვსმეტი";
                    }
                    if (tanhafu.Substring(2, 1) == "7")
                    {
                        sitkfu = sitkfu + "ჩვიდმეტი";
                    }
                    if (tanhafu.Substring(2, 1) == "8")
                    {
                        sitkfu = sitkfu + "თვრამეტი";
                    }
                    if (tanhafu.Substring(2, 1) == "9")
                    {
                        sitkfu = sitkfu + "ცხრამეტი";
                    }

                }
            }
            if (tanhafu.Length == 1)
            {
                if (tanhafu.Substring(0, 1) == "1")
                {
                    sitkfu = sitkfu + "ერთი";
                }
                if (tanhafu.Substring(0, 1) == "2")
                {
                    sitkfu = sitkfu + "ორი";
                }
                if (tanhafu.Substring(0, 1) == "3")
                {
                    sitkfu = sitkfu + "სამი";
                }
                if (tanhafu.Substring(0, 1) == "4")
                {
                    sitkfu = sitkfu + "ოთხი";
                }
                if (tanhafu.Substring(0, 1) == "5")
                {
                    sitkfu = sitkfu + "ხუთი";
                }
                if (tanhafu.Substring(0, 1) == "6")
                {
                    sitkfu = sitkfu + "ექვსი";
                }
                if (tanhafu.Substring(0, 1) == "7")
                {
                    sitkfu = sitkfu + "შვიდი";
                }
                if (tanhafu.Substring(0, 1) == "8")
                {
                    sitkfu = sitkfu + "რვა";
                }
                if (tanhafu.Substring(0, 1) == "9")
                {
                    sitkfu = sitkfu + "ცხრა";
                }
            }
        }

    }
}
