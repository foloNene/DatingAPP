namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTimeOffset dob)
        {
            var today = DateTime.UtcNow;

            var age = today.Year - dob.Year;

            if (dob > today.AddYears(-age)) 
            {
                age--;
            }

            return age;
        } 
    }
}
