using ConsoleApp1.Name;

namespace ConsoleApp1.Potion
{
    abstract class Potion : Name.Name
    {
        protected int size = 0;

        private string generateName()
        {
            string name = "";

            if (this.size == 1)
                name = "Little ";
            else if (this.size == 2)
                name = "Middle ";
            else
                name = "Legendary ";

            return name;
        }

        public Potion(int size)
        {
            this.size = size;
            this.name = generateName() + this.GetType().Name;
        }
    }
}
