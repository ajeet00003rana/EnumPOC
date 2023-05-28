using System.ComponentModel;

namespace EnumPOC
{
    public class CommonEnum
    {
        public enum Role
        {
            [Description("Role1")]
            Admin = 1,
            [Description("Role2")]
            Manager = 4,
            [Description("Role3")]
            Employee = 5,
            [Description("Role4")]
            User = 9
        }

    }
}
