using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JayLen_Wang.Models
{
    [Table("user")]
    public class User
    {
        public User()
        {
            CreateTime = DateTime.Now;
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string LoginName { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime CreateTime { get; set; }
        public Role Role { get; set; }
        [NotMapped]
        public string AccessToken { get; set; }
    }

    public enum Role
    {
        [Description("游客")]
        Guest,
        [Description("普通用户")]
        Common,
        [Description("高级用户")]
        Advance,
        [Description("管理员")]
        Administrator,
    }
}
