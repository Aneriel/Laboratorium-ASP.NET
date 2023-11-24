using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Laboratorium_2.Models
{
    public class Birth
    {
        public string name { get; set; }
        public DateTime bDate { get; set; }
        DateTime currentTime = DateTime.Now;
        public bool IsValid()
        {
            return !(string.IsNullOrEmpty(name)) && bDate < DateTime.Now && bDate != default(DateTime);
        }
        public int Birth_Calculate()
        {
            return currentTime.Year - bDate.Year;
        }
    }
}
