namespace GaikovBSUIR
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem6 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem8 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem9 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.radMenuItem12 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem10 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem11 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem7 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem14 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem13 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView1.Location = new System.Drawing.Point(0, 26);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.radGridView1.MasterTemplate.AllowSearchRow = true;
            this.radGridView1.MasterTemplate.EnableGrouping = false;
            this.radGridView1.MasterTemplate.EnablePaging = true;
            this.radGridView1.MasterTemplate.MultiSelect = true;
            this.radGridView1.MasterTemplate.SearchRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(848, 335);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.UserAddedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.RadGridView1UserAddedRow);
            this.radGridView1.UserDeletedRow += new Telerik.WinControls.UI.GridViewRowEventHandler(this.radGridView1_UserDeletedRow);
            this.radGridView1.CellValueChanged += new Telerik.WinControls.UI.GridViewCellEventHandler(this.RadGridView1CellValueChanged);
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem5,
            this.radMenuItem6});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "Файл";
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "Сохранить";
            // 
            // radMenuItem6
            // 
            this.radMenuItem6.Name = "radMenuItem6";
            this.radMenuItem6.Text = "Закрыть";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem3,
            this.radMenuItem4,
            this.radMenuItem8,
            this.radMenuItem9,
            this.radMenuSeparatorItem1,
            this.radMenuItem12,
            this.radMenuItem10,
            this.radMenuItem11});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Справочники";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "Контрагенты";
            this.radMenuItem3.Click += new System.EventHandler(this.radMenuItem3_Click);
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "Цвета";
            this.radMenuItem4.Click += new System.EventHandler(this.radMenuItem4_Click);
            // 
            // radMenuItem8
            // 
            this.radMenuItem8.Name = "radMenuItem8";
            this.radMenuItem8.Text = "Валюты";
            this.radMenuItem8.Click += new System.EventHandler(this.radMenuItem8_Click);
            // 
            // radMenuItem9
            // 
            this.radMenuItem9.Name = "radMenuItem9";
            this.radMenuItem9.Text = "Еденицы измерения";
            this.radMenuItem9.Click += new System.EventHandler(this.radMenuItem9_Click);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radMenuItem12
            // 
            this.radMenuItem12.Name = "radMenuItem12";
            this.radMenuItem12.Text = "Договоры";
            this.radMenuItem12.Click += new System.EventHandler(this.radMenuItem12_Click);
            // 
            // radMenuItem10
            // 
            this.radMenuItem10.Name = "radMenuItem10";
            this.radMenuItem10.Text = "Типы заказов";
            this.radMenuItem10.Click += new System.EventHandler(this.radMenuItem10_Click_1);
            // 
            // radMenuItem11
            // 
            this.radMenuItem11.Name = "radMenuItem11";
            this.radMenuItem11.Text = "Типы цен";
            this.radMenuItem11.Click += new System.EventHandler(this.radMenuItem11_Click_1);
            // 
            // radMenuItem7
            // 
            this.radMenuItem7.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem14});
            this.radMenuItem7.Name = "radMenuItem7";
            this.radMenuItem7.Text = "Заказы";
            // 
            // radMenuItem14
            // 
            this.radMenuItem14.Name = "radMenuItem14";
            this.radMenuItem14.Text = "Заказы покупателей";
            this.radMenuItem14.Click += new System.EventHandler(this.radMenuItem14_Click);
            // 
            // radMenuItem13
            // 
            this.radMenuItem13.Name = "radMenuItem13";
            this.radMenuItem13.Text = "О программе";
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem7,
            this.radMenuItem13});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(848, 20);
            this.radMenu1.TabIndex = 1;
            this.radMenu1.Text = "radMenu1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 361);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АвтоСалон";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem6;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem8;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem9;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem12;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem7;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem14;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem13;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem10;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem11;
    }
}

