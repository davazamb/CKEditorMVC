//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CKEditorMVC.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string PostedBy { get; set; }
        public Nullable<System.DateTime> PostedOn { get; set; }
    }
}
