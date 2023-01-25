using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TXTextControl.DocumentServer.Fields;

namespace tx_formfield_editor
{
    public partial class Form1 : Form
    {
        private int dpiX = 15;

        // unicode strings for the checkbox characters
        private string UNCHECKED = UnicodeHexToString("\\u2610");
        private string CHECKED = UnicodeHexToString("\\u2612");

        private static string UnicodeHexToString(string text)
        {
            // returns the string representation
            return System.Text.Encoding.Unicode.GetString(BitConverter.GetBytes(short.Parse(text.Substring(2), System.Globalization.NumberStyles.HexNumber)));
        }

        public Form1()
        {
            InitializeComponent();
            textControl1.RulerBar = rulerBar2;
            textControl1.ButtonBar = buttonBar1;
            textControl1.StatusBar = statusBar1;
            textControl1.VerticalRulerBar = rulerBar1;

            dpiX = (int)(1440 / textControl1.CreateGraphics().DpiX);
        }

        private void formTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a new FormText field and add it to TextControl
            FormText tbField = new FormText();

            tbField.ApplicationField.Deleteable = false;
            tbField.ApplicationField.Editable = false;
            tbField.ApplicationField.DoubledInputPosition = true;

            textControl1.ApplicationFields.Add(tbField.ApplicationField);
        }

        private void formCheckBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a new FormCheckBox field and add it to TextControl
            FormCheckBox fcbField = new FormCheckBox();
            fcbField.Checked = false;

            fcbField.Text = fcbField.Checked == true ? CHECKED : UNCHECKED;

            fcbField.ApplicationField.Deleteable = false;
            fcbField.ApplicationField.Editable = false;
            fcbField.ApplicationField.DoubledInputPosition = true;

            textControl1.ApplicationFields.Add(fcbField.ApplicationField);
        }

        private void formDropDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a new FormDropDown field and add it to TextControl
            FormDropDown fddField = new FormDropDown();
            
            fddField.ApplicationField.Deleteable = false;
            fddField.ApplicationField.Editable = false;
            fddField.ApplicationField.DoubledInputPosition = true;

            // open the dialog to allow user to add some items
            fddField.ShowDialog();
            if(fddField.ListEntries.Count()>0)
            {
                fddField.Text = fddField.ListEntries.ElementAt(0);
            }
            
            textControl1.ApplicationFields.Add(fddField.ApplicationField);
        }

        private void dateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a new DateField field and add it to TextControl
            DateField dField = new DateField();

            dField.ApplicationField.Deleteable = false;
            dField.ApplicationField.Editable = false;
            dField.ApplicationField.DoubledInputPosition = true;

            // set the current date text to today
            dField.Date = DateTime.Today;

            // show the dialog to choose the string format of the field
            dField.ShowDialog();
            textControl1.ApplicationFields.Add(dField.ApplicationField);
        }

        private void textControl1_TextFieldClicked(object sender, TXTextControl.TextFieldEventArgs e)
        {
            TXTextControl.ApplicationField appField = (TXTextControl.ApplicationField)e.TextField;
            ApplicationFieldActivate(appField);
        }

        private void ApplicationFieldActivate(TXTextControl.ApplicationField ApplicationField)
        {
            // remove all child controls
            textControl1.Controls.Clear();

            // check the field type in order to display the proper control
            switch (ApplicationField.TypeName)
            {
                case "FORMDROPDOWN":
                    // create a FormDropDown field
                    FormDropDown fddField = new FormDropDown(ApplicationField);

                    // create a new System.Windows.Forms.ComboBox and add the
                    // FormDropDown's items
                    ComboBox cb = new ComboBox();

                    cb.Items.AddRange(fddField.ListEntries.ToArray<string>());

                    Point cbLocation = new Point((fddField.ApplicationField.Bounds.Location.X - 
                                                 textControl1.ScrollLocation.X) / dpiX, 
                                                 (fddField.ApplicationField.Bounds.Location.Y - 
                                                 textControl1.ScrollLocation.Y) / dpiX);

                    cb.Location = cbLocation;
                    cb.Tag = fddField;
                    cb.SelectedText = fddField.ApplicationField.Text;
                    cb.SelectedIndexChanged += new EventHandler(cb_SelectedIndexChanged);
                    cb.LostFocus += new EventHandler(cb_LostFocus);

                    // show the ComboBox on top of TextControl
                    textControl1.Controls.Add(cb);
                    cb.Focus();

                    break;

                case "FORMCHECKBOX":
                    // create a FormCheckBox field
                    FormCheckBox fcbField = new FormCheckBox(ApplicationField);

                    fcbField.Checked = !fcbField.Checked;
                    // change the text according to the current state
                    fcbField.Text = fcbField.Checked == true ? CHECKED : UNCHECKED;
                    break;

                case "DATE":
                    // create a DateField field
                    DateField dField = new DateField(ApplicationField);

                    // create a new System.Windows.Forms.DateTimePicker and set the
                    // date to the current DateField date
                    DateTimePicker dtPicker = new DateTimePicker();
                    dtPicker.Tag = dField;
                    dtPicker.Value = DateTime.Parse(dField.Text);

                    Point dtpLocation = new Point((dField.ApplicationField.Bounds.Location.X -
                                                  textControl1.ScrollLocation.X) / dpiX,
                                                  (dField.ApplicationField.Bounds.Location.Y -
                                                  textControl1.ScrollLocation.Y) / dpiX);

                    dtPicker.Location = dtpLocation;

                    dtPicker.ValueChanged += new EventHandler(dtPicker_ValueChanged);
                    dtPicker.LostFocus += new EventHandler(dtPicker_LostFocus);

                    // show the DateTimePicker on top of TextControl
                    textControl1.Controls.Add(dtPicker);
                    dtPicker.Focus();

                    break;

                case "FORMTEXT":
                    // create a FormText field
                    FormText ftField = new FormText(ApplicationField);

                    // create a new System.Windows.Forms.TextBox and set the
                    // text to the current FormText text
                    TextBox tb = new TextBox();

                    tb.Text = ftField.Text;
                    ftField.Text = "";

                    Point tbLocation = new Point((ftField.ApplicationField.Bounds.Location.X -
                                                  textControl1.ScrollLocation.X) / dpiX,
                                                  (ftField.ApplicationField.Bounds.Location.Y -
                                                  textControl1.ScrollLocation.Y) / dpiX);

                    tb.Location = tbLocation;
                    tb.Tag = ftField;
                    tb.LostFocus += new EventHandler(tb_LostFocus);
                    tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
                    tb.SelectAll();

                    // show the TextBox on top of TextControl
                    textControl1.Controls.Add(tb);
                    tb.Focus();
                    break;
            }
        }

        void dtPicker_LostFocus(object sender, EventArgs e)
        {
            // update the DateField and remove child controls
            ((DateField)((DateTimePicker)sender).Tag).Date = ((DateTimePicker)sender).Value;
            textControl1.Controls.Clear();
        }

        void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            // update the DateField and remove child controls
            ((DateField)((DateTimePicker)sender).Tag).Date = ((DateTimePicker)sender).Value;
            textControl1.Controls.Clear();
        }

        void cb_LostFocus(object sender, EventArgs e)
        {
            // update the FormDropDown and remove child controls
            ((FormDropDown)((ComboBox)sender).Tag).Text = ((ComboBox)sender).Text;
            textControl1.Controls.Clear();
        }

        void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update the FormDropDown and remove child controls
            ((FormDropDown)((ComboBox)sender).Tag).Text = ((ComboBox)sender).SelectedItem.ToString();
            textControl1.Controls.Clear();
        }

        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // update the FormText on pressing ENTER and remove child controls
            if (e.KeyChar != 13)
                return;

            ((FormText)((TextBox)sender).Tag).Text = ((TextBox)sender).Text;
            textControl1.Controls.Clear();
        }

        void tb_LostFocus(object sender, EventArgs e)
        {
            // update the FormText and remove child controls
            ((FormText)((TextBox)sender).Tag).Text = ((TextBox)sender).Text;
            textControl1.Controls.Clear();
        }
    }
}
