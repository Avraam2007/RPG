namespace ConsoleApp1.Name
{
    abstract class Name
    {
        protected string name = "";

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName() => this.name;

        ~Name()
        {

        }
    }
}

