//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VIPA_V2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuarioscliente
    {
        public string idusuariocliente { get; set; }
        public string idcliente { get; set; }
        public string nombreusuariocliente { get; set; }
        public string correousuariocliente { get; set; }
        public string contraseñausuariocliente { get; set; }
    
        public virtual cliente cliente { get; set; }
    }
}