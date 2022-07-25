namespace School
{
    public class PrimarySchool : ISchool
    {

        public void CalculatePrimarySchoolWeight(ref float sum, ref float totalWeigh, Module module)
        {
            sum = sum + (module.Weight * module.Mark);
            totalWeigh = totalWeigh + module.Weight;
        }

        public string GetGrade(float result)
        {
            if (result < 5)
            {
                return $"{result}/10 => D";
            }
            else if (result < 7)
            {
                return $"{result}/10 => C";
            }
            else if (result < 9)
            {
                return $"{result}/10 => B";
            }
            else
            {
                return $"{result}/10 => A";
            }
        }
    }
}