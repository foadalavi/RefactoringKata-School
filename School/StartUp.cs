namespace School
{
    internal class StartUp
    {
        public void Execute()
        {
            var selectedLine = -1;
            var options = new List<MenuOption>();
            FillOptions(options);
            Console.CursorVisible = false;
            var calculator = new ResultCalculator();

            while (true)
            {
                #region Write messages

                Console.Clear();
                Console.WriteLine("Please select one of the following options:");
                for (int i = 0; i < options.Count; i++)
                {
                    MenuOption item = options[i];
                    if (i == selectedLine)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    Console.WriteLine(item.ShowMessage());
                    Console.ResetColor();
                }

                #endregion

                #region  Menu actions

                var chr = Console.ReadKey();
                if (chr.Key == ConsoleKey.DownArrow)
                {
                    if (selectedLine < options.Count - 1)
                    {
                        selectedLine++;
                    }
                }
                else if (chr.Key == ConsoleKey.UpArrow)
                {
                    if (selectedLine > 0)
                    {
                        selectedLine--;
                    }
                }
                else if (chr.Key == ConsoleKey.Enter)
                {
                    if (selectedLine != -1)
                    {
                        switch (options[selectedLine].code)
                        {
                            case 1:
                                GetStudentInfo(calculator);
                                break;
                            case 2:
                                AddModule(calculator);
                                break;
                            case 3:
                                Console.WriteLine(calculator.GetWeightedAverageMark());
                                break;
                            case 4:
                                calculator = new ResultCalculator();
                                break;
                            case 5:
                                return;
                        }
                        Console.WriteLine("Action completed, Please press any key to continue.");
                        Console.ReadKey();
                    }
                }

                #endregion
            }
        }

        private void AddModule(ResultCalculator calculator)
        {

            var m = new Module();
            Console.Clear();
            Console.WriteLine("Please insert the module Name:");
            m.Name = Console.ReadLine();

            Console.WriteLine("Please insert the module Weight:");
            if (int.TryParse(Console.ReadLine(), out int weight))

            {
                m.WeightSet(weight);
            }
            else
            {
                throw new Exception("Invalid input");
            }

            Console.WriteLine("Please insert the module Mark:");
            if (float.TryParse(Console.ReadLine(), out float mark))
            {
                m.SetMark(mark);
            }
            else
            {
                throw new Exception("Invalid input");
            }

            if (calculator.Modules == null)
            {
                calculator.Modules = new List<Module>();
            }
            calculator.Modules.Add(m);
        }

        private void GetStudentInfo(ResultCalculator calculator)
        {
            Console.Clear();
            Console.WriteLine("Please insert the student Name:");
            calculator.StudentName = Console.ReadLine();
            Console.WriteLine("Please insert the student Level:");
            calculator.StudentLevel = Console.ReadLine();
        }

        private void FillOptions(List<MenuOption> options)
        {
            options.Add(new MenuOption(1, " 1- Enter Student info."));
            options.Add(new MenuOption(2, " 2- Enter a mark."));
            options.Add(new MenuOption(3, " 3- Calculate result"));
            options.Add(new MenuOption(4, " 4- Start a new calculation."));
            options.Add(new MenuOption(5, " 5- Exit"));
        }
    }
}
