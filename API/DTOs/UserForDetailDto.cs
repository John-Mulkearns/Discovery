using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class UserForDetailDto
    {
                public int Id { get; set; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public string PhotoUrl {get; set;}
        // 🔴🟥 🔶 🟠🟧 🔷 🟡🟨 🔸 🟢	🟩🔹 🔵🟦🔺🟣🟪🔻 🟤🟫💠 
        //
        #region

        #endregion

 //       public ICollection<Photo> Photos { get; set; }
        
    }
}