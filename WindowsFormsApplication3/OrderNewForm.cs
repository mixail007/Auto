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
    public partial class OrderNewForm : Form {

        private AutoEntities db;
        private ЗаказПокупателя Заказ, zakazEdit;
        private ЗаказПокупателяТаблЧасть ЗаказТЧ, zakazEditTCH;
        private GridViewComboBoxColumn comboColumnEZ, comboColumnPostav;
        private int indexProsmotr, idProsmotr, indexEdit;


        public void SetProsmotr(int id) {
            indexProsmotr = 1;
            idProsmotr = id;
        }


        public void SetEdit(int id) {
            indexEdit = 1;
            idProsmotr = id;
            radButtonSave.Visible = false;
            radButtonUpdate.Visible = true;

        }



        private void DisableControls(Control con) {
            foreach (Control c in con.Controls) {
                c.Enabled = false;
            }

        }

        private void RadButtonUpdateClick(object sender, EventArgs e) {
            zakazEdit.Автор = this.radTextBoxAvtor.Text;
            zakazEdit.Наименование = this.Naimenovanie.Text;
            zakazEdit.ВидОплаты = this.VidOplaty.Text;
            try {
                zakazEdit.ДатаСоздания = this.radDateTimePickerDataCr.Value;
            } catch (NullReferenceException) {
            }
            try {
                zakazEdit.СрокПоставки = this.radDateTimePickerСрокПоставки.Value;
            } catch (NullReferenceException) {
            }
            try {
                zakazEdit.СрокСнятияРезерва = this.radDateTimePickerSrok.Value;
            } catch (NullReferenceException) {
            }
            try {
                zakazEdit.СуммаДокумента = (double) this.radSpinEditorSumma.Value;
            } catch (NullReferenceException) {
            }
            try {
                zakazEdit.СуммаПредоплаты = (double) this.radSpinEditorSumPredoplaty.Value;
            } catch (NullReferenceException) {
            }
            try {
                zakazEdit.Курс = (double) this.radSpinEditorKurs.Value;
            } catch (NullReferenceException) {
            }
            try {
                zakazEdit.Менеджер = this.Manager.Text;
            } catch (NullReferenceException) {
            }
            try {
                zakazEdit.ВалютаДокумента = (int) radMultiColumnComboBoxValuta.SelectedValue;
            } catch (NullReferenceException) {
            }
            try {
                zakazEdit.Автомобиль = (int) radMultiColumnComboBoxAuto.SelectedValue;
            } catch (NullReferenceException) {
            }
            try {
                zakazEdit.ДоговорВзаиморасчетов = (int) radMultiColumnComboBoxDogovor.SelectedValue;
            } catch (NullReferenceException) {
            }
            try {
                zakazEdit.ТипЦен = (int) radMultiColumnComboBoxTipCen.SelectedValue;
            } catch (NullReferenceException) {
            }
            try {
                zakazEdit.ТипЗаказа = (int) radMultiColumnComboBoxTipZakaza.SelectedValue;
            } catch (NullReferenceException) {
            }
            try {
                zakazEdit.Контрагент = (int) radMultiColumnComboBoxKontragent.SelectedValue;
            } catch (NullReferenceException) {
            }
            try {
                zakazEdit.Организация = (int) radMultiColumnComboBoxOrg.SelectedValue;
            } catch (NullReferenceException) {
            }



            zakazEditTCH = new ЗаказПокупателяТаблЧасть();

            int newRows = 0;

            foreach (GridViewRowInfo rowInfo in radGridView1.Rows) {

                newRows = 0;

                foreach (GridViewCellInfo cellInfo in rowInfo.Cells) {


                    if (cellInfo.ColumnInfo.Name == "id") {

                        if (cellInfo.Value.Equals(0)) {
                            newRows = 1;
                            continue;
                        }
                    }


                    if (cellInfo.ColumnInfo.Name == "ID_ЗаказПокупателя") {
                        if (newRows == 1) {
                            cellInfo.Value = idProsmotr;
                            continue;
                        }
                    }



                    if (cellInfo.ColumnInfo.Name == "Количество") {
                        try {
                            zakazEditTCH.Количество = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "ЕдиницаИзмерения") {
                        try {
                            zakazEditTCH.ЕдиницаИзмерения = (int) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "ЦенаПродажная") {
                        try {
                            zakazEditTCH.ЦенаПродажная = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "СуммаПродажи") {
                        try {
                            zakazEditTCH.СуммаПродажи = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "ПроцентСкидки") {
                        try {
                            zakazEditTCH.ПроцентСкидки = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "СуммаСкидки") {
                        try {
                            zakazEditTCH.СуммаСкидки = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "СтавкаНДС") {
                        try {
                            zakazEditTCH.СтавкаНДС = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "СуммаНДС") {
                        try {
                            zakazEditTCH.СуммаНДС = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "СуммаВсего") {
                        try {
                            zakazEditTCH.СуммаВсего = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "СкидкаНаТовар") {
                        try {
                            zakazEditTCH.СкидкаНаТовар = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "Поставщик") {
                        try {
                            zakazEditTCH.Поставщик = (int) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "СрокПоставки") {
                        try {
                            zakazEditTCH.СрокПоставки = (DateTime) cellInfo.Value;
                            continue;

                        } catch (NullReferenceException) {
                        }
                    }
                }
            }

            db.SaveChanges();
            this.Close();

        }

        public OrderNewForm() {
            InitializeComponent();
            db = new AutoEntities();
        }

        private void OrderNewForm_Load(object sender, EventArgs e) {


            var source = new BindingSource();
            source.Add(new ЗаказПокупателяТаблЧасть());
            this.radGridView1.DataSource = source;
            this.radGridView1.Columns[0].IsVisible = false;

            this.radGridView1.Columns[1].Width = 80;
            var kolColumn = (GridViewDecimalColumn) this.radGridView1.Columns[1];
            kolColumn.Minimum = 0;
            kolColumn.Maximum = 100;


            this.radGridView1.Columns[2].Width = 80;
            this.radGridView1.Columns[3].Width = 120;
            this.radGridView1.Columns[3].HeaderText = "Цена продажная";
            var cenaProdagnaya = (GridViewDecimalColumn) this.radGridView1.Columns[3];
            cenaProdagnaya.Minimum = 0;
            cenaProdagnaya.Maximum = 9999999999999;



            this.radGridView1.Columns[4].Width = 120;
            this.radGridView1.Columns[4].HeaderText = "Сумма продажная";
            var summaProdagnayaColumn = (GridViewDecimalColumn) this.radGridView1.Columns[4];
            summaProdagnayaColumn.Minimum = 0;
            summaProdagnayaColumn.Maximum = 9999999999999;


            this.radGridView1.Columns[5].Width = 100;
            this.radGridView1.Columns[5].HeaderText = "% скидки";
            var procentSkidkiColumn = (GridViewDecimalColumn) this.radGridView1.Columns[5];
            procentSkidkiColumn.Minimum = 0;
            procentSkidkiColumn.Maximum = 100;


            this.radGridView1.Columns[6].Width = 110;
            this.radGridView1.Columns[6].HeaderText = "Сумма скидки";
            var summaSkidkiColumn = (GridViewDecimalColumn) this.radGridView1.Columns[6];
            summaSkidkiColumn.Minimum = 0;
            summaSkidkiColumn.Maximum = 9999999999999;



            this.radGridView1.Columns[7].Width = 110;
            this.radGridView1.Columns[7].HeaderText = "Ставка НДС";
            var stavkaNdsColumn = (GridViewDecimalColumn) this.radGridView1.Columns[7];
            stavkaNdsColumn.Minimum = 0;
            stavkaNdsColumn.Maximum = 9999999999999;


            this.radGridView1.Columns[8].Width = 110;
            this.radGridView1.Columns[8].HeaderText = "Сумма НДС";
            var summaNdsColumn = (GridViewDecimalColumn) this.radGridView1.Columns[8];
            summaNdsColumn.Minimum = 0;
            summaNdsColumn.Maximum = 9999999999999;

            this.radGridView1.Columns[9].Width = 150;
            this.radGridView1.Columns[9].HeaderText = "Сумма всего";
            var summaVsegoColumns = (GridViewDecimalColumn) this.radGridView1.Columns[9];
            summaVsegoColumns.Minimum = 0;
            summaVsegoColumns.Maximum = 9999999999999;


            this.radGridView1.Columns[10].Width = 100;
            this.radGridView1.Columns[10].HeaderText = "Скидка на товар";
            var skidkaNaTovarColumns = (GridViewDecimalColumn) this.radGridView1.Columns[10];
            skidkaNaTovarColumns.Minimum = 0;
            skidkaNaTovarColumns.Maximum = 9999999999999;


            this.radGridView1.Columns[11].Width = 100;
            this.radGridView1.Columns[12].Width = 100;
            this.radGridView1.Columns[12].HeaderText = "Срок поставки";
            this.radGridView1.Columns[13].IsVisible = false;
            this.radGridView1.Columns[14].IsVisible = false;
            this.radGridView1.Columns[15].IsVisible = false;

            this.radGridView1.Columns[2].IsVisible = false;
            this.db.ЕдиницыИзмерения.Load();
            comboColumnEZ = new GridViewComboBoxColumn(radGridView1.Columns[2].Name);
            comboColumnEZ.DataSource = this.db.ЕдиницыИзмерения.Local.ToBindingList();
            comboColumnEZ.Width = 100;
            comboColumnEZ.ValueMember = "id";
            comboColumnEZ.DisplayMember = "Наименование";
            comboColumnEZ.FieldName = radGridView1.Columns[2].Name;
            this.radGridView1.Columns.Add(comboColumnEZ);
            radGridView1.Columns.Move(16, 2);


            this.radGridView1.Columns[12].IsVisible = false;
            this.db.Контрагенты.Load();
            var peopleOrg = this.db.Контрагенты.ToList();
            var peopleKontr = this.db.Контрагенты.ToList();
            var peoplePostav = this.db.Контрагенты.ToList();

            comboColumnPostav = new GridViewComboBoxColumn(radGridView1.Columns[12].Name);
            comboColumnPostav.DataSource = peoplePostav;
            comboColumnPostav.Width = 100;
            comboColumnPostav.ValueMember = "id";
            comboColumnPostav.DisplayMember = "Наименование";
            comboColumnPostav.FieldName = radGridView1.Columns[12].Name;
            this.radGridView1.Columns.Add(comboColumnPostav);
            radGridView1.Columns.Move(17, 12);



            this.radMultiColumnComboBoxKontragent.DataSource = peopleKontr;
            this.radMultiColumnComboBoxKontragent.SelectedIndex = -1;
            this.radMultiColumnComboBoxKontragent.DisplayMember = "Наименование";
            this.radMultiColumnComboBoxKontragent.ValueMember = "id";


            this.radMultiColumnComboBoxOrg.DataSource = peopleOrg;
            this.radMultiColumnComboBoxOrg.SelectedIndex = -1;
            this.radMultiColumnComboBoxOrg.DisplayMember = "Наименование";
            this.radMultiColumnComboBoxOrg.ValueMember = "id";

            this.db.Автомобили.Load();
            this.radMultiColumnComboBoxAuto.DataSource = this.db.Автомобили.Local.ToBindingList();
            this.radMultiColumnComboBoxAuto.SelectedIndex = -1;
            this.radMultiColumnComboBoxAuto.DisplayMember = "Наименование";
            this.radMultiColumnComboBoxAuto.ValueMember = "id";

            this.db.ДоговорыВзаиморасчетов.Load();
            this.radMultiColumnComboBoxDogovor.DataSource = this.db.ДоговорыВзаиморасчетов.Local.ToBindingList();
            this.radMultiColumnComboBoxDogovor.SelectedIndex = -1;
            this.radMultiColumnComboBoxDogovor.DisplayMember = "Наименование";
            this.radMultiColumnComboBoxDogovor.ValueMember = "id";


            this.db.Валюты.Load();
            this.radMultiColumnComboBoxValuta.DataSource = this.db.Валюты.Local.ToBindingList();
            this.radMultiColumnComboBoxValuta.SelectedIndex = -1;
            this.radMultiColumnComboBoxValuta.DisplayMember = "Наименование";
            this.radMultiColumnComboBoxValuta.ValueMember = "id";

            this.db.ТипыЦен.Load();
            this.radMultiColumnComboBoxTipCen.DataSource = this.db.ТипыЦен.Local.ToBindingList();
            this.radMultiColumnComboBoxTipCen.SelectedIndex = -1;
            this.radMultiColumnComboBoxTipCen.DisplayMember = "Наименование";
            this.radMultiColumnComboBoxTipCen.ValueMember = "id";


            this.db.ТипЗаказа.Load();
            this.radMultiColumnComboBoxTipZakaza.DataSource = this.db.ТипЗаказа.Local.ToBindingList();
            this.radMultiColumnComboBoxTipZakaza.SelectedIndex = -1;
            this.radMultiColumnComboBoxTipZakaza.DisplayMember = "Наименование";
            this.radMultiColumnComboBoxTipZakaza.ValueMember = "id";



            if (indexProsmotr == 1) {
                LoadDataZakaz();
                DisableControls(this);
            }

            if (indexEdit == 1) {
                LoadDataZakaz();
            }

        }



        private void LoadDataZakaz() {
            db.ЗаказПокупателя.Load();
            zakazEdit = db.ЗаказПокупателя.Find(idProsmotr);
            Naimenovanie.Text = zakazEdit.Наименование;
            radMultiColumnComboBoxKontragent.SelectedValue = zakazEdit.Контрагент;
            radMultiColumnComboBoxAuto.SelectedValue = zakazEdit.Автомобиль;
            radMultiColumnComboBoxOrg.SelectedValue = zakazEdit.Организация;
            radMultiColumnComboBoxTipCen.SelectedValue = zakazEdit.ТипЦен;
            radMultiColumnComboBoxValuta.SelectedValue = zakazEdit.ВалютаДокумента;
            radMultiColumnComboBoxTipZakaza.SelectedValue = zakazEdit.ТипЗаказа;
            radMultiColumnComboBoxDogovor.SelectedValue = zakazEdit.ДоговорВзаиморасчетов;
            radSpinEditorKurs.Value = (decimal) zakazEdit.Курс;
            radSpinEditorSumma.Value = (decimal) zakazEdit.СуммаДокумента;
            VidOplaty.Text = zakazEdit.ВидОплаты;
            Manager.Text = zakazEdit.Менеджер;
            radSpinEditorSumPredoplaty.Value = (decimal) zakazEdit.СуммаПредоплаты;
            radTextBoxAvtor.Text = zakazEdit.Автор;
            radDateTimePickerDataCr.Value = zakazEdit.ДатаСоздания.Value;
            radDateTimePickerСрокПоставки.Value = zakazEdit.СрокПоставки.Value;
            radDateTimePickerSrok.Value = zakazEdit.СрокСнятияРезерва.Value;

            db.ЗаказПокупателяТаблЧасть.Where(p => p.ID_ЗаказПокупателя == idProsmotr).Load();
            this.radGridView1.DataSource = db.ЗаказПокупателяТаблЧасть.Local.ToBindingList();
        }

        private void RadButton2Click(object sender, EventArgs e) {
            this.Close();
        }

        private void RadButton1Click(object sender, EventArgs e) {

            Заказ = new ЗаказПокупателя();
            Заказ.Автор = this.radTextBoxAvtor.Text;
            Заказ.Наименование = this.Naimenovanie.Text;
            Заказ.ВидОплаты = this.VidOplaty.Text;
            try {
                Заказ.ДатаСоздания = this.radDateTimePickerDataCr.Value;
            } catch (NullReferenceException) {
            }
            try {
                Заказ.СрокПоставки = this.radDateTimePickerСрокПоставки.Value;
            } catch (NullReferenceException) {
            }
            try {
                Заказ.СрокСнятияРезерва = this.radDateTimePickerSrok.Value;
            } catch (NullReferenceException) {
            }
            try {
                Заказ.СуммаДокумента = (double) this.radSpinEditorSumma.Value;
            } catch (NullReferenceException) {
            }
            try {
                Заказ.СуммаПредоплаты = (double) this.radSpinEditorSumPredoplaty.Value;
            } catch (NullReferenceException) {
            }
            try {
                Заказ.Курс = (double) this.radSpinEditorKurs.Value;
            } catch (NullReferenceException) {
            }
            try {
                Заказ.Менеджер = this.Manager.Text;
            } catch (NullReferenceException) {
            }
            try {
                Заказ.ВалютаДокумента = (int) radMultiColumnComboBoxValuta.SelectedValue;
            } catch (NullReferenceException) {
            }
            try {
                Заказ.Автомобиль = (int) radMultiColumnComboBoxAuto.SelectedValue;
            } catch (NullReferenceException) {
            }
            try {
                Заказ.ДоговорВзаиморасчетов = (int) radMultiColumnComboBoxDogovor.SelectedValue;
            } catch (NullReferenceException) {
            }
            try {
                Заказ.ТипЦен = (int) radMultiColumnComboBoxTipCen.SelectedValue;
            } catch (NullReferenceException) {
            }
            try {
                Заказ.ТипЗаказа = (int) radMultiColumnComboBoxTipZakaza.SelectedValue;
            } catch (NullReferenceException) {
            }
            try {
                Заказ.Контрагент = (int) radMultiColumnComboBoxKontragent.SelectedValue;
            } catch (NullReferenceException) {
            }
            try {
                Заказ.Организация = (int) radMultiColumnComboBoxOrg.SelectedValue;
            } catch (NullReferenceException) {
            }


            db.ЗаказПокупателя.Add(Заказ);

            db.SaveChanges();

            ЗаказТЧ = new ЗаказПокупателяТаблЧасть();

            foreach (GridViewRowInfo rowInfo in radGridView1.Rows) {
                foreach (GridViewCellInfo cellInfo in rowInfo.Cells) {

                    if (cellInfo.ColumnInfo.Name == "Количество") {
                        try {
                            ЗаказТЧ.Количество = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "ЕдиницаИзмерения") {
                        try {
                            ЗаказТЧ.ЕдиницаИзмерения = (int) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "ЦенаПродажная") {
                        try {
                            ЗаказТЧ.ЦенаПродажная = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "СуммаПродажи") {
                        try {
                            ЗаказТЧ.СуммаПродажи = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "ПроцентСкидки") {
                        try {
                            ЗаказТЧ.ПроцентСкидки = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "СуммаСкидки") {
                        try {
                            ЗаказТЧ.СуммаСкидки = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "СтавкаНДС") {
                        try {
                            ЗаказТЧ.СтавкаНДС = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "СуммаНДС") {
                        try {
                            ЗаказТЧ.СуммаНДС = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "СуммаВсего") {
                        try {
                            ЗаказТЧ.СуммаВсего = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "СкидкаНаТовар") {
                        try {
                            ЗаказТЧ.СкидкаНаТовар = (double) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "Поставщик") {
                        try {
                            ЗаказТЧ.Поставщик = (int) cellInfo.Value;
                            continue;
                        } catch (NullReferenceException) {
                        }
                    }

                    if (cellInfo.ColumnInfo.Name == "СрокПоставки") {
                        try {
                            ЗаказТЧ.СрокПоставки = (DateTime) cellInfo.Value;
                            continue;

                        } catch (NullReferenceException) {
                        }
                    }

                }
                ЗаказТЧ.ID_ЗаказПокупателя = Заказ.id;
                db.ЗаказПокупателяТаблЧасть.Add(ЗаказТЧ);
                db.SaveChanges();

            }

            this.Close();
        }
    }
}
