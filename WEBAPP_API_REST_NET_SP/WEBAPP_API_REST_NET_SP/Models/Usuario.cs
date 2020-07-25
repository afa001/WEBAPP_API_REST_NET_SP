using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBAPP_API_REST_NET_SP.Models
{
    public class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Calculo = new HashSet<Calculo>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Calculo> Calculo { get; set; }
    }
}