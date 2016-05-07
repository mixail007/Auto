﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaikovBSUIR
{
    public partial class Color : Form
    {

        private AutoEntities db;

        public Color()
        {           
            InitializeComponent();
            db = new AutoEntities();
        }

        private void Color_Load(object sender, EventArgs e)
        {
            this.db.Цвет.Load();
            this.radGridView1.DataSource = this.db.Цвет.Local.ToBindingList();
            this.radGridView1.Columns[0].Width = 30;
            this.radGridView1.Columns[0].HeaderText = "№";
            this.radGridView1.Columns[1].Width = 200;
            this.radGridView1.Columns[2].IsVisible = false;
            this.radGridView1.Columns[3].IsVisible = false;
        }

        private void RadGridView1UserDeletedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            try
            {
                this.db.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                DialogResult ds = Telerik.WinControls.RadMessageBox.Show(this, "Запись не удалена !", "Ошибка", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info);
            }
        }

        private void radGridView1_UserAddedRow(object sender, Telerik.WinControls.UI.GridViewRowEventArgs e)
        {
            try
            {
                this.db.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                DialogResult ds = Telerik.WinControls.RadMessageBox.Show(this, "Запись не сохранена !", "Ошибка", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info);
            }
        }

        private void radGridView1_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                this.db.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                DialogResult ds = Telerik.WinControls.RadMessageBox.Show(this, "Значение не изменено !", "Ошибка", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info);
            }
        }

        private void Color_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.db.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                DialogResult ds = Telerik.WinControls.RadMessageBox.Show(this, "Значение не изменено !", "Ошибка", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info);
            }

        }
    }
}
