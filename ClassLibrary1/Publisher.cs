//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Publisher
    {
        public Publisher()
        {
            this.media = new HashSet<Media>();
        }
    
        public int id { get; set; }
        public string Nom { get; set; }
    
        public virtual ICollection<Media> media { get; set; }
    }
}
