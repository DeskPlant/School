using School.UI;


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
                    int command = UI.ReadCommand();
                    switch (command)
                    {
                        default:
                            break;
                    }


                }
}
