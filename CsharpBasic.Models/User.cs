using System;

namespace CsharpBasic.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public int Sex { get; set; }

        public string SexChar => this.Sex == 0 ? "女" : "男";
    }
}
