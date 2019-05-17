using Volo.Abp.Reflection;

namespace PowerDg
{
    public class PowerDgPermissions
    {
        public const string GroupName = "PowerDg";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(PowerDgPermissions));
        }
    }
}