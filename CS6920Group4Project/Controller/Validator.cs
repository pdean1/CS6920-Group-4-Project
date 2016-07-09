using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS6920Group4Project.Controller;
using CS6920Group4Project.Model;
using CS6920Group4Project.View;
using CS6920Group4Project.DAL.Model;
using System.Text.RegularExpressions;

namespace CS6920Group4Project.Controller
{
    class Validator
    {
        private static string title = "Error";

        public static string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public static bool IsPresent(Control control)
          {
              if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
              {
                  TextBox textBox = (TextBox)control;
                  if (textBox.Text == "")
                  {
                      MessageBox.Show(textBox.Tag.ToString() + " is a required field.", Title);
                      textBox.Focus();
                      return false;
                  }
                  else
                  {
                      return true;
                  }
              }
               else if (control.GetType().ToString() == "System.Windows.Forms.ComboBox")
              {
                  ComboBox comboBox = (ComboBox)control;
                  if (comboBox.SelectedIndex == -1)
                  {
                      MessageBox.Show(comboBox.Tag.ToString() + " is a required field.", Title);
                      comboBox.Focus();
                      return false;
                  }
                  else
                  {
                      return true;
                  }
              }
              else if (control.GetType().ToString() == "System.Windows.Forms.MonthCalendar")
              {
                  MonthCalendar calendar = (MonthCalendar)control;
                  if (string.IsNullOrEmpty(calendar.SelectionRange.Start.ToShortDateString()))
                  {
                      MessageBox.Show(calendar.Tag.ToString() + " is a required field.", Title);
                      calendar.Focus();
                      return false;
                  }
                  else
                  {
                      return true;
                  }
              }
              return true;
          }
        public static bool IsAmountNonNegative(TextBox textBox)
        {
            var regex = new Regex(@"\d+\.\d{2}");

            if (regex.IsMatch(textBox.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show(
                    textBox.Tag.ToString() + " must be a whole non-negative number", Title);
                textBox.Focus();
                return false;
            }
        }
       
      }
    }

