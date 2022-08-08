namespace School.SchoolType
{
    public abstract class BaseSchool
    {
        protected abstract float CalculateWeight(List<Module> modules);
        protected abstract string GetGrade(float result);

        public string GetWeightedAverageMark(List<Module> modules)
        {
            var result = CalculateWeight(modules);

            return GetGrade(result);
        }
    }
}