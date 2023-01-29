using Core.Entities;
using Core.Utilities.Enums;

namespace Entities.Concrete
{
    public class User:IEntitiy
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Role Role{ get; set; }
        public byte Status { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
