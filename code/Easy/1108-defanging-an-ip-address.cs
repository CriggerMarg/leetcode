namespace code
{
    public static partial class Easy
    {
        /// <summary>
        /// 1108. Defanging an IP Address
        /// https://leetcode.com/problems/defanging-an-ip-address/
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}