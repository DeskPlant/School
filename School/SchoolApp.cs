using School.UI;
using System;

namespace School
{
    class SchoolApp
    {
        private IUI UI { get; set; }

        private bool Running { get; set; }

        public SchoolApp(IUI UI)
        {
            this.UI = UI;
            Running = true;
        }

        public void Run()
        {

			while (Running)
			{
				try
				{
					int command = Utilities.Utilities.ReadCommand();
					switch (command)
					{
						case 0:
                            {
								Running = false;
								break;
                            }
						case 1:
                            {
								break;
                            }
							
						default:
							{
								Console.WriteLine("No such command.");
								Console.WriteLine();
								break;
							}
					}
				}
				catch (Exception exception)
				{
					Console.WriteLine($"Exception caught: {exception.Message}");
					Console.WriteLine(exception.StackTrace);
				}
			}
		}
	}
}
