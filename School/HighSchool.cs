namespace School
{
    public class HighSchool : ISchool
    {
        public void CalculateHighSchoolWeight(ref float bonus, ref float sum, ref float totalWeigh, Module module)
        {
            if (module.Name.ToLower().Trim() == "Math".ToLower().Trim())
            {
                if (module.Mark < 5)
                {
                    bonus = bonus + 0;
                }
                else if (module.Mark < 8)
                {
                    bonus = bonus + module.Weight * 2;
                }
                else
                {
                    bonus = bonus + module.Weight * 3;
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
                    bonus = bonus + module.Weight;
                }
                else
                {
                    bonus = bonus + module.Weight * 2;
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
                    bonus = bonus + 0.75F;
                }
                else
                {
                    bonus = bonus + (module.Weight * 1.5f);
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
                    bonus = bonus + module.Weight;
                }
            }

            sum = sum + (module.Weight * module.Mark) + bonus;
            totalWeigh = totalWeigh + module.Weight;
        }

        public float CalculateWeight(List<Module> modules)
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
                        bonus = bonus + module.Weight * 2;
                    }
                    else
                    {
                        bonus = bonus + module.Weight * 3;
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
                        bonus = bonus + module.Weight;
                    }
                    else
                    {
                        bonus = bonus + module.Weight * 2;
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
                        bonus = bonus + 0.75F;
                    }
                    else
                    {
                        bonus = bonus + (module.Weight * 1.5f);
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
                        bonus = bonus + module.Weight;
                    }
                }

                sum = sum + (module.Weight * module.Mark) + bonus;
                totalWeigh = totalWeigh + module.Weight;

            }
            return sum / totalWeigh;
        }

        public string GetGrade(float result)
        {
            if (result < 5)
            {
                return $"{result}/10 => F";
            }
            else if (result < 6)
            {
                return $"{result}/10 => E";
            }
            else if (result < 6.5)
            {
                return $"{result}/10 => D";
            }
            else if (result < 7)
            {
                return $"{result}/10 => C";
            }
            else if (result < 7.5)
            {
                return $"{result}/10 => C+";
            }
            else if (result < 8)
            {
                return $"{result}/10 => B";
            }
            else if (result < 8.5)
            {
                return $"{result}/10 => B+";
            }
            else if (result < 9)
            {
                return $"{result}/10 => A";
            }
            else
            {
                return "A+";
            }
        }
    }
}