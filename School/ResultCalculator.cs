﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    return GetPrimarySchoolGrade(result);
                case "middle school":
                    return GetMiddleSchoolGrade(result);
                case "high school":
                    return GetHighSchoolGrade(result);
                default:
                    return "No match found!";
            }
        }

        private string GetPrimarySchoolGrade(float result)
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

        private string GetMiddleSchoolGrade(float result)
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

        private string GetHighSchoolGrade(float result)
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

        private float CalculateWeight()
        {
            var bonus = 0f;
            var sum = 0f;
            var totalWeigh = 0f;
            foreach (var module in Modules)
            {
                if (StudentLevel == "Primary School".ToLower().Trim())
                {
                    sum = sum + (module.Weight * module.Mark);
                    totalWeigh = totalWeigh + module.Weight;
                }
                else if (StudentLevel == "Middel school".ToLower().Trim())
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
                            bonus = bonus + (module.Weight * 0.5f);
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

                    sum = sum + (module.Weight * module.Mark) + bonus;
                    totalWeigh = totalWeigh + module.Weight;
                }
                else if (StudentLevel == "High school".ToLower().Trim())
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
            }
            return sum / totalWeigh;
        }
    }
}
