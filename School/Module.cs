namespace School
{
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
