using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CA_InterfaceAdapter_Adapters.Dtos
{
    public class PostServiceDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}