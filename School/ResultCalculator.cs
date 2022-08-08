using School.SchoolType;

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
            var school = GetSchool();
            return school.GetGrade(result);
        }

        private ISchool GetSchool()
        {
            ISchool school = null;
            switch (StudentLevel)
            {
                case "primary school":
                    school = new PrimarySchool();
                    break;
                case "middle school":
                    school = new MiddleSchool();
                    break;
                case "high school":
                    school = new HighSchool();
                    break;
                default:
                    throw new Exception("No school selected");
            }
            return school;  
        }

        private float CalculateWeight()
        {
            ISchool school = null;
            if (StudentLevel == "Primary School".ToLower().Trim())
            {
                school = new PrimarySchool();
            }
            else if (StudentLevel == "Middel school".ToLower().Trim())
            {
                school = new MiddleSchool();
            }
            else if (StudentLevel == "High school".ToLower().Trim())
            {
                school = new HighSchool();
            }
            return school.CalculateWeight(Modules);
        }
    }
}
