using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Localization;

namespace GaikovBSUIR
{
   

    public partial class Form1 : Form
    {
        private AutoEntities db;
        private GridViewComboBoxColumn comboColumn, comboColumnVal;
        public Form1()
        {
            InitializeComponent();
            db = new AutoEntities();


        }
    
        private void Form1_Load(object sender, EventArgs e)
        {

            RadGridLocalizationProvider.CurrentProvider = new MyRuRadGridLocalizationProvider();

            this.db.Автомобили.Load();
            this.radGridView1.DataSource = this.db.Автомобили.Local.ToBindingList();

            this.radGridView1.Columns[0].Width = 30;
            this.radGridView1.Columns[0].HeaderText = "№";
            this.radGridView1.Columns[0].ReadOnly = true;
            this.radGridView1.Columns[1].Width = 100;
            this.radGridView1.Columns[2].Width = 100;
            this.radGridView1.Columns[3].Width = 150;
            this.radGridView1.Columns[4].Width = 100;
            this.radGridView1.Columns[5].Width = 150;
            this.radGridView1.Columns[6].Width = 150;
            this.radGridView1.Columns[7].Width = 150;
            this.radGridView1.Columns[8].Width = 150;


            this.radGridView1.Columns[9].IsVisible = false;
            this.db.Цвет.Load();
            comboColumn = new GridViewComboBoxColumn(radGridView1.Columns[9].Name);
            comboColumn.DataSource = this.db.Цвет.Local.ToBindingList();
            comboColumn.Width = 100;
            comboColumn.ValueMember = "id";
            comboColumn.DisplayMember = "Наименование";
            comboColumn.FieldName = radGridView1.Columns[9].Name;
            this.radGridView1.Columns.Add(comboColumn);
            radGridView1.Columns.Move(25, 9);
            this.radGridView1.Columns[11].IsVisible = false;


            this.radGridView1.Columns[11].Width = 100;
            this.radGridView1.Columns[12].Width = 80;
            this.radGridView1.Columns[13].Width = 80;
            this.radGridView1.Columns[14].Width = 80;
            this.radGridView1.Columns[15].HeaderText = "Нач.Гарантии";
            this.radGridView1.Columns[15].Width = 80;
            this.radGridView1.Columns[16].HeaderText = "Валюта";

      
            this.db.Валюты.Load();
            comboColumnVal = new GridViewComboBoxColumn(radGridView1.Columns[16].Name);
            comboColumnVal.DataSource = this.db.Валюты.Local.ToBindingList();
            comboColumnVal.Width = 100;
            comboColumnVal.ValueMember = "id";
            comboColumnVal.DisplayMember = "Наименование";
            comboColumnVal.FieldName = radGridView1.Columns[16].Name;
            this.radGridView1.Columns.Add(comboColumnVal);
            radGridView1.Columns.Move(oldIndex: 26, newIndex: 16);
            this.radGridView1.Columns[17].IsVisible = false;


            this.radGridView1.Columns[18].Width = 80;
            this.radGridView1.Columns[18].HeaderText = "Кон.Гарантии";
            this.radGridView1.Columns[19].Width = 80;
            this.radGridView1.Columns[19].HeaderText = "Ориг.VIN";
            this.radGridView1.Columns[20].HeaderText = "Дата Регистр.";
            this.radGridView1.Columns[20].Width = 80;
            
            radGridView1.Columns[21].IsVisible = false;
            radGridView1.Columns[22].IsVisible = false;
            radGridView1.Columns[23].IsVisible = false;
            radGridView1.Columns[24].IsVisible = false;
            radGridView1.Columns[25].IsVisible = false;
            radGridView1.Columns[26].IsVisible = false;


            //добавление связанной таблицы Тип Салона

            var Salon = new GridViewTemplate();
            this.db.ТипСалона.Load();
            Salon.DataSource = this.db.ТипСалона.Local.ToBindingList();
            Salon.Caption = "Тип Салона";
            Salon.Columns[1].Width = 200;
            Salon.Columns[0].IsVisible = false;
            Salon.Columns[2].IsVisible = false;
            Salon.Columns[3].IsVisible = false;
            this.radGridView1.MasterTemplate.Templates.Add(Salon);
            GridViewRelation relationSalon = new GridViewRelation(this.radGridView1.MasterTemplate);
            relationSalon.ChildTemplate = Salon;
            relationSalon.RelationName = "Тип Салона";
            relationSalon.ParentColumnNames.Add("id");
            relationSalon.ChildColumnNames.Add("ID_Авто");
            this.radGridView1.Relations.Add(relationSalon);

            //добавление связанной таблицы Тип Комплектации

            GridViewTemplate complect = new GridViewTemplate();
            this.db.ВариантыКомплектации.Load();
            complect.DataSource = this.db.ВариантыКомплектации.Local.ToBindingList();
            complect.Caption = "Варианты комплектации";
            complect.Columns[0].IsVisible = false;
            complect.Columns[7].IsVisible = false;
            complect.Columns[8].IsVisible = false;
            complect.Columns[9].IsVisible = false;
            complect.Columns[10].IsVisible = false;
            complect.Columns[11].IsVisible = false;


            complect.Columns[2].Width = 200;
            complect.Columns[3].Width = 100;
            complect.Columns[4].Width = 100;
            complect.Columns[5].Width = 100;
            complect.Columns[6].Width = 200;

            this.radGridView1.MasterTemplate.Templates.Add(complect);
            GridViewRelation relationcomplect = new GridViewRelation(this.radGridView1.MasterTemplate);
            relationcomplect.ChildTemplate = complect;
            relationcomplect.RelationName = "Варианты комплектации";
            relationcomplect.ParentColumnNames.Add("id");
            relationcomplect.ChildColumnNames.Add("ID_Авто");
            this.radGridView1.Relations.Add(relationcomplect);


            //добавление связанной таблицы ТипКузова

            GridViewTemplate Kuzov = new GridViewTemplate();
            this.db.ТипКузова.Load();
            Kuzov.DataSource = this.db.ТипКузова.Local.ToBindingList();
            Kuzov.Caption = "Тип Кузова";
            Kuzov.Columns[1].Width = 200;
            Kuzov.Columns[0].IsVisible = false;
            Kuzov.Columns[2].IsVisible = false;
            Kuzov.Columns[3].IsVisible = false;
            Kuzov.Columns[4].IsVisible = false;
           
            complect.Templates.Add(Kuzov);
            GridViewRelation relationKuzov = new GridViewRelation(complect);
            relationKuzov.ChildTemplate = Kuzov;
            relationKuzov.RelationName = "Тип Кузова";
            relationKuzov.ParentColumnNames.Add("id");
            relationKuzov.ParentColumnNames.Add("id_Авто");
            relationKuzov.ChildColumnNames.Add("ID_Комплект");
            relationKuzov.ChildColumnNames.Add("id_Авто");
            this.radGridView1.Relations.Add(relationKuzov);

            //добавление связанной таблицы ТипКПП

            GridViewTemplate template = new GridViewTemplate();
            this.db.ТипКПП.Load();
            template.DataSource = this.db.ТипКПП.Local.ToBindingList();
            template.Caption = "Тип КПП";
            template.Columns[0].IsVisible = false;
            template.Columns[2].IsVisible = false;
            template.Columns[1].Width = 200;
            template.Columns[3].IsVisible = false;
            template.Columns[4].IsVisible = false;
      
            complect.Templates.Add(template);
            GridViewRelation relation = new GridViewRelation(complect);
            relation.ChildTemplate = template;
            relation.RelationName = "Тип КПП";
            relation.ParentColumnNames.Add("id");
            relation.ParentColumnNames.Add("id_Авто");
            relation.ChildColumnNames.Add("ID_Комплект");
            relation.ChildColumnNames.Add("id_Авто");
            this.radGridView1.Relations.Add(relation);


            //типы двигателей

            var dvig_komplect = new GridViewTemplate();
            this.db.ТипыДвигателей.Load();
            dvig_komplect.DataSource = this.db.ТипыДвигателей.Local.ToBindingList();
            dvig_komplect.Caption = "Типы Двигателя";
            complect.Templates.Add(dvig_komplect);
            dvig_komplect.Columns[1].Width = 200;
            dvig_komplect.Columns[2].Width = 200;
            dvig_komplect.Columns[0].IsVisible = false;
            dvig_komplect.Columns[3].IsVisible = false;
            dvig_komplect.Columns[4].IsVisible = false;
            dvig_komplect.Columns[5].IsVisible = false;
           
            GridViewRelation relationdvig_com = new GridViewRelation(complect);
            relationdvig_com.ChildTemplate = dvig_komplect;
            relationdvig_com.RelationName = "Тип Двигателя";
            relationdvig_com.ParentColumnNames.Add("id");
            relationdvig_com.ParentColumnNames.Add("id_Авто");
            relationdvig_com.ChildColumnNames.Add("ID_Комплект");
            relationdvig_com.ChildColumnNames.Add("id_Авто");
            this.radGridView1.Relations.Add(relationdvig_com);

          //
        }


        private void RefreshAll()
        {
            foreach (var entity in db.ChangeTracker.Entries())
            {
                entity.Reload();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.db.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {

            }
        }


        private void RadGridView1CellValueChanged(object sender, GridViewCellEventArgs e)
        {

            try
            {
                this.db.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                DialogResult ds = Telerik.WinControls.RadMessageBox.Show(this, text: "Значение не изменено !", caption: "Ошибка", buttons: MessageBoxButtons.OK, icon: Telerik.WinControls.RadMessageIcon.Info);
            }
           
        }

        private void RadGridView1UserAddedRow(object sender, GridViewRowEventArgs e)
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
      
        private void radGridView1_UserDeletedRow(object sender, GridViewRowEventArgs e)
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

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            
            Color frmColor = new Color();
            frmColor.ShowDialog();

            RefreshAll();

            this.db.Цвет.Load();
            comboColumn.DataSource = this.db.Цвет.Local.ToBindingList();

        }

        private void radMenuItem8_Click(object sender, EventArgs e)
        {
            Currency frmVal = new Currency();
            frmVal.ShowDialog();

            RefreshAll();

            this.db.Валюты.Load();
            comboColumnVal.DataSource = this.db.Валюты.Local.ToBindingList();
        }

        private void radMenuItem9_Click(object sender, EventArgs e)
        {
            // ед измерения
            Units frmUnits = new Units();
            frmUnits.ShowDialog();

        }


      
        private void radMenuItem12_Click(object sender, EventArgs e)
        {
            //договоры
            Сontract frmСontract = new Сontract();
            frmСontract.ShowDialog();
        }

        private void radMenuItem14_Click(object sender, EventArgs e)
        {

            //заказы
            Order frmOrder = new Order();
            frmOrder.ShowDialog();

        }

        private void radMenuItem10_Click_1(object sender, EventArgs e)
        {
            OrderTypes frmOrderTypes = new OrderTypes();
            frmOrderTypes.ShowDialog();

        }

        private void radMenuItem11_Click_1(object sender, EventArgs e)
        {
            //типы цен
            PriceTypes frmPriceTypes = new PriceTypes();
            frmPriceTypes.ShowDialog();
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            //Контрагенты
            СontractingParties frmCp = new СontractingParties();
            frmCp.ShowDialog();

            
        }
    }
}
