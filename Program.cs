namespace Enums_Jackson_Lydia
{
    internal class Program
    {
        enum Months
        {
                Jan = 1,
                Feb,
                Mar,
                Apr,
                May,
                Jun,
                Jul,
                Aug,
                Sep,
                Oct,
                Nov,
                Dec,

        }
        static void Main(string[] args)
        {
            int myBirthMonth = (int)Months.Nov;
            int myBirthDay = 23;
            int myBirthYear = 2003;

            string myBirthDate = $"My Birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";
        }
    }
}