﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StampyxCore;

namespace Stampyx
{
    public partial class FormWatermarkLocationEditor : Form
    {
        WatermarkLocation m_markLocation = WatermarkLocation.LowerLeft;
        public WatermarkLocation MarkLocation { get => m_markLocation; set => m_markLocation = value; }
        public List<Watermark> Locations { get; internal set; }

        public FormWatermarkLocationEditor()
        {
            InitializeComponent();
        }

        private void btnUpperLeft_Click(object sender, EventArgs e)
        {
            MarkLocation = WatermarkLocation.UpperLeft;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnUpperRight_Click(object sender, EventArgs e)
        {
            MarkLocation = WatermarkLocation.UpperRight;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnLowerLeft_Click(object sender, EventArgs e)
        {
            MarkLocation = WatermarkLocation.LowerLeft;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnLowerRight_Click(object sender, EventArgs e)
        {
            MarkLocation = WatermarkLocation.LowerRight;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            MarkLocation = WatermarkLocation.Center;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
