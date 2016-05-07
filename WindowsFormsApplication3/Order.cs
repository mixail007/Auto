using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Telerik.WinControls.UI;

namespace GaikovBSUIR {
    public partial class Order : Form {


        private AutoEntities db;

        public Order() {
            InitializeComponent();
            db = new AutoEntities();
        }

        private void RadMenuItem1Click(object sender, EventArgs e) {
            var frmor = new OrderNewForm();
            frmor.ShowDialog();
            RefreshAll();
            this.db.ЗаказВид.Load();
            this.radGridView1.DataSource = this.db.ЗаказВид.Local.ToBindingList();

        }

        private void RadMenuItem2Click(object sender, EventArgs e) {
            var frmor = new OrderNewForm();
            frmor.SetEdit((int) radGridView1.SelectedRows[0].Cells[0].Value);
            frmor.ShowDialog();
            RefreshAll();
            this.db.ЗаказВид.Load();
            this.radGridView1.DataSource = this.db.ЗаказВид.Local.ToBindingList();
        }

        private void Order_Load(object sender, EventArgs e) {

            //заказ
            this.db.ЗаказВид.Load();
            this.radGridView1.DataSource = this.db.ЗаказВид.Local.ToBindingList();

        }

        private void RadGridView1ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e) {

            var customMenuItem = new RadMenuItem();
            customMenuItem.Click += new EventHandler(ViewContextMenuItem_Click);
            customMenuItem.Text = "Просмотр";
            var separator = new RadMenuSeparatorItem();
            e.ContextMenu.Items.Add(separator);
            e.ContextMenu.Items.Add(customMenuItem);

            var deleteMenuItem = new RadMenuItem();
            deleteMenuItem.Click += new EventHandler(deleteContextMenuItem_Click);
            deleteMenuItem.Text = "Удалить заказ";
            e.ContextMenu.Items.Add(separator);
            e.ContextMenu.Items.Add(deleteMenuItem);


            var customMenuItemPr = new RadMenuItem();
            customMenuItemPr.Click += new EventHandler(PrintContextMenuItem_Click);
            customMenuItemPr.Text = "Печать";
            e.ContextMenu.Items.Add(separator);
            e.ContextMenu.Items.Add(customMenuItemPr);
        }



        private void RefreshAll() {
            foreach (var entity in db.ChangeTracker.Entries()) {
                entity.Reload();
            }
        }

        private void ViewContextMenuItem_Click(object sender, EventArgs e) {

            var frmor = new OrderNewForm();
            frmor.SetProsmotr((int) radGridView1.SelectedRows[0].Cells[0].Value);
            frmor.ShowDialog();
        }


        private void deleteContextMenuItem_Click(object sender, EventArgs e) {

            DialogResult ds = Telerik.WinControls.RadMessageBox.Show(this, "Удалить заказ?", "Сообшение", MessageBoxButtons.YesNoCancel, Telerik.WinControls.RadMessageIcon.Question);
            if (ds.ToString() == "No" || ds.ToString() == "Cancel") {
                return;
            } else {
                try {
                    ЗаказПокупателя zakazpok = db.ЗаказПокупателя.Find(radGridView1.SelectedRows[0].Cells[0].Value);
                    db.ЗаказПокупателя.Remove(zakazpok);
                    db.SaveChanges();
                    RefreshAll();
                    this.db.ЗаказВид.Load();
                    this.radGridView1.DataSource = this.db.ЗаказВид.Local.ToBindingList();

                } catch (System.Data.Entity.Infrastructure.DbUpdateException ex) {
                    DialogResult dss = Telerik.WinControls.RadMessageBox.Show(this, "Заказ не удален !", "Ошибка", MessageBoxButtons.OK, Telerik.WinControls.RadMessageIcon.Info);
                }
            }
        }



        private void PrintContextMenuItem_Click(object sender, EventArgs e) {


            var Print = new ReportViewerFormZakaz();
            Print.ShowDialog();
          //  MessageBox.Show(radGridView1.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}
