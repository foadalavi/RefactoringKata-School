using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class ResultCalculator
    {
        public string StudentName { get; set; }
        public string StudentLevel { get; set; }
        public List<Module> Modules { get; set; }

        public ResultCalculator()
        {

        }

        public string GetWAM()
        {
            var Bonous = 0f;
            var Sum = 0f;
            var totalWeigh = 0f;
            foreach (var item in Modules)
            {
                if (StudentLevel.ToLower().Trim() == "Primary School".ToLower().Trim())
                {
                    Sum = Sum + (item.Weight * item.Mark);
                    totalWeigh = totalWeigh + item.Weight;
                }
                else if (StudentLevel.ToLower().Trim() == "Middel school".ToLower().Trim())
                {
                    if (item.Name.ToLower().Trim() == "Math".ToLower().Trim())
                    {
                        if (item.Mark < 5)
                        {
                            Bonous = Bonous + 0;
                        }
                        else if (item.Mark < 8)
                        {
                            Bonous = Bonous + item.Weight * 1;
                        }
                        else
                        {
                            Bonous = Bonous + item.Weight * 1.5F;
                        }
                    }
                    else if (item.Name.ToLower().Trim() == "Physics".ToLower().Trim())
                    {
                        if (item.Mark < 5)
                        {
                            Bonous = Bonous + 0;
                        }
                        else if (item.Mark < 8)
                        {
                            Bonous = Bonous + item.Weight * 0.5F;
                        }
                        else
                        {
                            Bonous = Bonous + item.Weight * 1;
                        }
                    }
                    else if (item.Name.ToLower().Trim() == "Chemistry".ToLower().Trim())
                    {
                        if (item.Mark < 5)
                        {
                            Bonous = Bonous + 0;
                        }
                        else if (item.Mark < 8)
                        {
                            Bonous = Bonous + 0.2F;
                        }
                        else
                        {
                            Bonous = Bonous + (item.Weight * 0.5f);
                        }
                    }
                    else
                    {
                        if (item.Mark < 5)
                        {
                            Bonous = Bonous + 0;
                        }
                        else if (item.Mark < 8)
                        {
                            Bonous = Bonous + 0;
                        }
                        else
                        {
                            Bonous = Bonous + item.Weight * 0.5F;
                        }
                    }

                    Sum = Sum + (item.Weight * item.Mark);
                    totalWeigh = totalWeigh + item.Weight;
                }
                else if (StudentLevel.ToLower().Trim() == "High school".ToLower().Trim())
                {
                    if (item.Name.ToLower().Trim() == "Math".ToLower().Trim())
                    {
                        if (item.Mark < 5)
                        {
                            Bonous = Bonous + 0;
                        }
                        else if (item.Mark < 8)
                        {
                            Bonous = Bonous + item.Weight * 2;
                        }
                        else
                        {
                            Bonous = Bonous + item.Weight * 3;
                        }
                    }
                    else if (item.Name.ToLower().Trim() == "Physics".ToLower().Trim())
                    {
                        if (item.Mark < 5)
                        {
                            Bonous = Bonous + 0;
                        }
                        else if (item.Mark < 8)
                        {
                            Bonous = Bonous + item.Weight;
                        }
                        else
                        {
                            Bonous = Bonous + item.Weight * 2;
                        }
                    }
                    else if (item.Name.ToLower().Trim() == "Chemistry".ToLower().Trim())
                    {
                        if (item.Mark < 5)
                        {
                            Bonous = Bonous + 0;
                        }
                        else if (item.Mark < 8)
                        {
                            Bonous = Bonous + 0.75F;
                        }
                        else
                        {
                            Bonous = Bonous + (item.Weight * 1.5f);
                        }
                    }
                    else
                    {
                        if (item.Mark < 5)
                        {
                            Bonous = Bonous + 0;
                        }
                        else if (item.Mark < 8)
                        {
                            Bonous = Bonous + 0;
                        }
                        else
                        {
                            Bonous = Bonous + item.Weight;
                        }
                    }

                    Sum = Sum + (item.Weight * item.Mark);
                    totalWeigh = totalWeigh + item.Weight;
                }
            }

            var result = Sum / totalWeigh;

            if (StudentLevel.ToLower().Trim() == "Primary School".ToLower().Trim())
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
            else if (StudentLevel.ToLower().Trim() == "Middel school".ToLower().Trim())
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
            else if (StudentLevel.ToLower().Trim() == "High school".ToLower().Trim())
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


            return "No match found!";
        }
    }

    public class Module
    {
        public string Name { get; set; }
        public float Mark { get; set; }
        public int Weight { get; set; }

        public void SetMark(float m)
        {
            if (m < 0)
            {
                throw new ArgumentException("Mark out of range");
            }
            if (m > 10)
            {
                throw new ArgumentException("Mark out of range");
            }
            Mark = m;
        }

        public void WeigthSet(int w)
        {
            if (w < 1)
            {
                throw new ArgumentException("Weight out of range");
            }
            if (w > 5)
            {
                throw new ArgumentException("Weight out of range");
            }
            Weight = w;
        }
    }
}
