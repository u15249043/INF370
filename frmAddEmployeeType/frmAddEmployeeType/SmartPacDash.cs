using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAddEmployeeType
{
    public partial class SmartPacDash : Form
    {
        int userID;
        public SmartPacDash(int x)
        {
            userID = x;
            InitializeComponent();
        }

        public void LoadCalendar()
        {
            if (cmbMonth.SelectedIndex > -1)
            {
                string month = cmbMonth.Text;// should be in the format of Jan, Feb, Mar, Apr, etc...
                int yearofMonth = Convert.ToInt32(nudyear.Value);
                DateTime dateTime = Convert.ToDateTime("01-" + month + "-" + yearofMonth);
                DataRow dr;
                DataTable dt = new DataTable();
                dt.Columns.Add("Monday");
                dt.Columns.Add("Tuesday");
                dt.Columns.Add("Wednesday");
                dt.Columns.Add("Thursday");
                dt.Columns.Add("Friday");
                dt.Columns.Add("Saturday");
                dt.Columns.Add("Sunday");
                dr = dt.NewRow();

                for (int i = 0; i < DateTime.DaysInMonth(dateTime.Year, dateTime.Month); i += 1)
                {
                    if (Convert.ToDateTime(dateTime.AddDays(i)).ToString("dddd") == "Monday")
                    {
                        dr["Monday"] = i + 1;
                    }

                    if (dateTime.AddDays(i).ToString("dddd") == "Tuesday")
                    {
                        dr["Tuesday"] = i + 1;
                    }

                    if (dateTime.AddDays(i).ToString("dddd") == "Wednesday")
                    {
                        dr["Wednesday"] = i + 1;
                    }

                    if (dateTime.AddDays(i).ToString("dddd") == "Thursday")
                    {
                        dr["Thursday"] = i + 1;
                    }

                    if (dateTime.AddDays(i).ToString("dddd") == "Friday")
                    {
                        dr["Friday"] = i + 1;
                    }

                    if (dateTime.AddDays(i).ToString("dddd") == "Saturday")
                    {
                        dr["Saturday"] = i + 1;
                    }

                    if (dateTime.AddDays(i).ToString("dddd") == "Sunday")
                    {
                        dr["Sunday"] = i + 1;
                        dt.Rows.Add(dr);
                        dr = dt.NewRow();
                        continue;
                    }

                    if (i == DateTime.DaysInMonth(dateTime.Year, dateTime.Month) - 1)
                    {
                        dt.Rows.Add(dr);
                        dr = dt.NewRow();
                    }
                }

                dgvCalender.DataSource = dt;

                foreach (DataGridViewRow dgvr in dgvCalender.Rows)
                    dgvr.Height = (dgvCalender.ClientRectangle.Height - dgvCalender.ColumnHeadersHeight) / dgvCalender.Rows.Count;

                dgvCalender.PerformLayout();

                // var schedules = Globals.db.HomeVisitSchedules.Where(hvs => hvs.Date.Value.Month == dateTime.Month && hvs.Date.Value.Year == yearofMonth).ToList();

                /* if (schedules.Count > 0)
                 {
                     foreach (Model.HomeVisitSchedule hv in schedules)
                     {
                         int r = 0;
                         bool found = false;

                         for (r = 0; r < dgvCalender.Rows.Count; r++)
                         {
                             int c = 0;
                             for (c = 0; c < dgvCalender.Columns.Count; c++)
                             {
                                 if (dgvCalender[c, r].Value.ToString() == hv.Date.Value.Day.ToString())
                                 {
                                     found = true;
                                     dgvCalender[c, r].Style.BackColor = Color.DarkRed;
                                     dgvCalender[c, r].Style.ForeColor = Color.White;
                                     break;
                                 }
                             }
                             if (found)
                                 break;
                         }
                     }
                 }
             }
             else
             {
                 MessageBox.Show("Please make sure you have selected a month and a year.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             */
            }
        }

        private void DvgCalanderView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nudyear_ValueChanged(object sender, EventArgs e)
        {
            LoadCalendar();
            // dgvDetails.DataSource = null;
        }
        SPEntities3 db1 = new SPEntities3();
        private void SmartPacDash_Load(object sender, EventArgs e)
        {
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            var user = db1.Users.Where(x => x.Users_Id == userID).FirstOrDefault();

   //         label3.Text = user.Users_Name.ToString();
            //label4.Text = user.us.User_Type_Description.ToString();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCalendar();

        }

        private void DvgCalanderView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvCalender.SelectedCells.Count > 0)
            {
                if (!string.IsNullOrEmpty(dgvCalender.SelectedCells[0].Value.ToString()))
                {
                    int Day = Convert.ToInt32(dgvCalender.SelectedCells[0].Value);

                    DateTime dt = new DateTime(Convert.ToInt32(nudyear.Value), (cmbMonth.SelectedIndex + 1), Day);


                }
            }
        }
    }
}
