//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_DSWI
{
    using System;
    using System.Collections.Generic;
    
    public partial class DETALLE_PED
    {
        public int ID_PED { get; set; }
        public int ID_PROD { get; set; }
        public decimal PREC_TOTAL { get; set; }
        public int CANT_PED { get; set; }
        public string DES_PED { get; set; }
    
        public virtual PEDIDO PEDIDO { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}