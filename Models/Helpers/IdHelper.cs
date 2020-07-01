using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class IdHelper
    {
        public string GenerateIdNumber(string lastNumber)
        {
            string idNumber = $"{DateTime.Now.Year}-{DateTime.Now.Month}-0001";
            if (lastNumber == null)
                return idNumber;
            try
            {

                var id = lastNumber.Split('-');
                var number = id[2].ToInt() + 1;
                idNumber = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{number.ToString($"0000")}";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return idNumber;
            }
            return idNumber;
        }
    }
}
