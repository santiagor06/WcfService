using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]

        public string Direccion { get; set; }
        [DataMember]

        public string Correo { get; set; }
        [DataMember]


        public string Telefono{ get; set; }
        
    }
}