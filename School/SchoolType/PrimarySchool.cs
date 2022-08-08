namespace School.SchoolType
{
    public class PrimarySchool : ISchool
    {

        public void CalculatePrimarySchoolWeight(ref float sum, ref float totalWeigh, Module module)
        {
            sum = sum + module.Weight * module.Mark;
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

        public float CalculateWeight(List<Module> modules)
        {
            var sum = 0f;
            var totalWeigh = 0f;
            foreach (var module in modules)
            {
                sum = sum + module.Weight * module.Mark;
                totalWeigh = totalWeigh + module.Weight;
            }
            return sum / totalWeigh;
        }
    }
}