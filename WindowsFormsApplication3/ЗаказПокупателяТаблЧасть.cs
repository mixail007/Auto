//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GaikovBSUIR
{
    using System;
    using System.Collections.Generic;
    
    public partial class ЗаказПокупателяТаблЧасть
    {
        public int id { get; set; }
        public Nullable<double> Количество { get; set; }
        public Nullable<int> ЕдиницаИзмерения { get; set; }
        public Nullable<double> ЦенаПродажная { get; set; }
        public Nullable<double> СуммаПродажи { get; set; }
        public Nullable<double> ПроцентСкидки { get; set; }
        public Nullable<double> СуммаСкидки { get; set; }
        public Nullable<double> СтавкаНДС { get; set; }
        public Nullable<double> СуммаНДС { get; set; }
        public Nullable<double> СуммаВсего { get; set; }
        public Nullable<double> СкидкаНаТовар { get; set; }
        public Nullable<int> Поставщик { get; set; }
        public Nullable<System.DateTime> СрокПоставки { get; set; }
        public Nullable<int> ID_ЗаказПокупателя { get; set; }
    
        public virtual ЕдиницыИзмерения ЕдиницыИзмерения { get; set; }
        public virtual ЗаказПокупателя ЗаказПокупателя { get; set; }
    }
}
