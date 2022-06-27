namespace School
{
    internal class MenuOption
    {
        private readonly string message;
        public readonly int code;

        public MenuOption(int code, string message)
        {
            this.code = code;
            this.message = message;
        }

        public string ShowMessage()
        {
            return message;
        }
    }
}
