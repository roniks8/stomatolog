//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace stomatolog
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        public int ID_doc { get; set; }
        public System.DateTime Dates { get; set; }
        public System.TimeSpan Times { get; set; }
        public int ID_pat { get; set; }
        public Nullable<short> Available { get; set; }
    
        public virtual Doctors Doctors { get; set; }
        public virtual Patients Patients { get; set; }
    }
}
