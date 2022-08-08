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
            var school = GetSchool();
            return school.GetWeightedAverageMark(Modules);
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
    }
}
