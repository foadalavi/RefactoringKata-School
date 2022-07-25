namespace School
{
    public class ResultCalculator
    {
        private string _studentLevel;

        public string StudentName { get; set; }

        public string StudentLevel
        {
            get { return _studentLevel; }
            set { _studentLevel = value.ToLower().Trim(); }
        }
        public List<Module> Modules { get; set; }

        public string GetWeightedAverageMark()
        {
            var result = CalculateWeight();
            return GetGrade(result);
        }

        private string GetGrade(float result)
        {
            switch (StudentLevel)
            {
                case "primary school":
                    var primarySchool = new PrimarySchool();
                    return primarySchool.GetGrade(result);
                case "middle school":
                    var middleSchool = new MiddleSchool();
                    return middleSchool.GetGrade(result);
                case "high school":
                    var highSchool = new HighSchool();
                    return highSchool.GetGrade(result);
                default:
                    return "No match found!";
            }
        }

        private float CalculateWeight()
        {
            var bonus = 0f;
            var sum = 0f;
            var totalWeigh = 0f;
            foreach (var module in Modules)
            {
                if (StudentLevel == "Primary School".ToLower().Trim())
                {
                    var primarySchool = new PrimarySchool();
                    primarySchool.CalculatePrimarySchoolWeight(ref sum, ref totalWeigh, module);
                }
                else if (StudentLevel == "Middel school".ToLower().Trim())
                {
                    var middleSchool = new MiddleSchool();
                    middleSchool.CalculateMiddleSchoolWeight(ref bonus, ref sum, ref totalWeigh, module);
                }
                else if (StudentLevel == "High school".ToLower().Trim())
                {
                    var highSchool = new HighSchool();
                    highSchool.CalculateHighSchoolWeight(ref bonus, ref sum, ref totalWeigh, module);
                }
            }
            return sum / totalWeigh;
        }
    }
}
