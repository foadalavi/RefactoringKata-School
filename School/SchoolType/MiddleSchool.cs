namespace School.SchoolType
{
    public class MiddleSchool : BaseSchool
    {
        protected override float CalculateWeight(List<Module> modules)
        {
            var bonus = 0f;
            var sum = 0f;
            var totalWeigh = 0f;
            foreach (var module in modules)
            {
                if (module.Name.ToLower().Trim() == "Math".ToLower().Trim())
                {
                    if (module.Mark < 5)
                    {
                        bonus = bonus + 0;
                    }
                    else if (module.Mark < 8)
                    {
                        bonus = bonus + module.Weight * 1;
                    }
                    else
                    {
                        bonus = bonus + module.Weight * 1.5F;
                    }
                }
                else if (module.Name.ToLower().Trim() == "Physics".ToLower().Trim())
                {
                    if (module.Mark < 5)
                    {
                        bonus = bonus + 0;
                    }
                    else if (module.Mark < 8)
                    {
                        bonus = bonus + module.Weight * 0.5F;
                    }
                    else
                    {
                        bonus = bonus + module.Weight * 1;
                    }
                }
                else if (module.Name.ToLower().Trim() == "Chemistry".ToLower().Trim())
                {
                    if (module.Mark < 5)
                    {
                        bonus = bonus + 0;
                    }
                    else if (module.Mark < 8)
                    {
                        bonus = bonus + 0.2F;
                    }
                    else
                    {
                        bonus = bonus + module.Weight * 0.5f;
                    }
                }
                else
                {
                    if (module.Mark < 5)
                    {
                        bonus = bonus + 0;
                    }
                    else if (module.Mark < 8)
                    {
                        bonus = bonus + 0;
                    }
                    else
                    {
                        bonus = bonus + module.Weight * 0.5F;
                    }
                }

                sum = sum + module.Weight * module.Mark + bonus;
                totalWeigh = totalWeigh + module.Weight;
            }
            return sum / totalWeigh;
        }

        protected override string GetGrade(float result)
        {
            if (result < 2.5)
            {
                return $"{result}/10 => F";
            }
            else if (result < 5)
            {
                return $"{result}/10 => E";
            }
            else if (result < 7)
            {
                return $"{result}/10 => D";
            }
            else if (result < 8)
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