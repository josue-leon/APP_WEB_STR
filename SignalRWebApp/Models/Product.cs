using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace SignalRWebApp.Models
{
    [Serializable]
    [DataContract(IsReference = true)]
    public class Product : EntityBase
    {
        [DataMember]
        [Display(Name = "ID")]
        public Int32 ParqueaderoID { get; set; }

        [DataMember]
        [Display(Name = "Nombre")]
        public String Nombre { get; set; }

        [DataMember]
        [Display(Name = "Direccion")]
        public String Direccion { get; set; }

        [DataMember]
        [Display(Name = "EspaciosTotal")]
        public Int32 EspaciosTotal { get; set; }

        [DataMember]
        [Display(Name = "EspaciosOcupados")]
        public Int32 EspaciosOcupados { get; set; }

        [DataMember]
        [Display(Name = "EspaciosDisponibles")]
        public Int32 EspaciosDisponibles { get; set; }
    }
}