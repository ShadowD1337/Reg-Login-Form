using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace name_pass
{
    public partial class Form1 : Form
    {
        string folder = @"";
        public Form1()
        {
            InitializeComponent();
            lbl_sqface.Visible = false;
            lbl_sqside.Visible = false;
            btn_calc.Visible = false;
            tbox_sqside.Visible = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string[] text = File.ReadAllLines(folder + @"\registrations.txt");
            if (!(File.ReadAllLines(folder + @"\registrations.txt").Any(line => line.Split(':').First() == tbox_user.Text && line.Split(':').Skip(1).First() == tbox_pass.Text))) MessageBox.Show("Incorrect Username or Password.");
            else
            {
                lbl_user.Visible = false;
                lbl_pass.Visible = false;
                tbox_user.Visible = false;
                tbox_pass.Visible = false;
                btn_login.Visible = false;
                btn_register.Visible = false;

                lbl_sqface.Visible = true;
                lbl_sqside.Visible = true;
                btn_calc.Visible = true;
                tbox_sqside.Visible = true;

                lbl_sqside.Location = lbl_user.Location;
                lbl_sqface.Location = lbl_pass.Location; //new Point (lbl_user.Location.X, lbl_user.Location.Y + 80);
                tbox_sqside.Location = tbox_user.Location;
                btn_calc.Location = new Point(btn_login.Location.X, btn_login.Location.Y - 100);

            }
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
                lbl_sqface.Text = "Лицето на квадрата е: " + Convert.ToString(Convert.ToDouble(tbox_sqside.Text) * Convert.ToDouble(tbox_sqside.Text));
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            if (File.Exists(folder + @"\registrations.txt") ? File.ReadAllLines(folder + @"\registrations.txt").Any(line => line.Split(':').First() == tbox_user.Text) : false)
            {
                MessageBox.Show("This Username is already taken!");
                return;
            }
            else if (!isCPI(tbox_user.Text) && !isCPI(tbox_pass.Text)) MessageBox.Show("Incorrect Username and Password. \nShould only contain letters, digits and underscores");
            else if (isCPI(tbox_user.Text) && !isCPI(tbox_pass.Text)) MessageBox.Show("Incorrect Password. \nShould only contain letters, digits and underscores");
            else if (!isCPI(tbox_user.Text) && isCPI(tbox_pass.Text)) MessageBox.Show("Incorrect Username. \nShould only contain letters, digits and underscores");
            else if (isCPI(tbox_user.Text) && isCPI(tbox_pass.Text) && !string.IsNullOrWhiteSpace(tbox_user.Text))
            {
                //List<string> text = File.Exists(folder + @"\registrations.txt") ? File.ReadAllLines(folder + @"\registrations.txt").ToList() : new List<string>();
                //text.Add(tbox_user.Text + ":" + tbox_pass.Text);
                //string[] lines = text.ToArray();
                //File.WriteAllLines(folder + @"\registrations.txt", lines);
                File.AppendAllLines(folder + @"\registrations.txt", new string[] { tbox_user.Text + ":" + tbox_pass.Text });
                MessageBox.Show("Succesful Registration!");
            }
        }

        bool isCPI(string text)
        {
            if (text.All(c => Char.IsLetterOrDigit(c) || c == '_')) return true;
            else return false;

        }

    }
}
