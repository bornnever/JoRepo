using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinC_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime _CurrentTime = DateTime.Now;
            Boolean sTime;
            sTime= TimerDayAndTimeCheck("Thursday","0","23");
            MessageBox.Show("ss");
            //Please commit
        }

         private Boolean TimerDayAndTimeCheck (String SettingNameDaysofWeek, String SettingNameHours,String SettingDays)
            {

            DateTime _CurrentTime = DateTime.Now;
            String strDaysofWeek, strHours,strDays;
            try
                {
                strDaysofWeek = SettingNameDaysofWeek;
                strHours = SettingNameHours;
                strDays = SettingDays;
                Boolean k;
                k = strHours.Split(',').Select(i => Convert.ToString(i)).ToList().Contains(_CurrentTime.Hour.ToString());
                if ((strDaysofWeek.Split(',').Select(i => Convert.ToString(i).ToUpper()).ToList().Contains(_CurrentTime.DayOfWeek.ToString().ToUpper()) == true)  &&
                       (strHours.Split(',').Select(i => Convert.ToString(i)).ToList().Contains(_CurrentTime.Hour.ToString()) == true) &&
                    (strDays.Split(',').Select(i => Convert.ToString(i)).ToList().Contains(_CurrentTime.Day.ToString()) == true)
                    )
                    {
                    return true;
                    }
                else
                    {
                    return false;
                    }
                }
            catch (Exception e)
            { throw e; }
            }
        }
         
    }
 
