namespace School.SchoolType
{
    public interface ISchool
    {
        string GetGrade(float result);
        float CalculateWeight(List<Module> modules);
        string GetWeightedAverageMark(List<Module> modules);
    }
}
