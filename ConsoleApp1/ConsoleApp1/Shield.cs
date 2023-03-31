using ConsoleApp1.Name;
using ConsoleApp1.Price;

namespace ConsoleApp1.Shield
{
    class Shield : Price.Price
    {
        protected int protect = 0;
        public Shield(int protect, string name, int price = 0) : base(name, price)
        {
            this.protect = protect;
            this.setName(name);
            this.setPrice(price);
        }
        public void setProtect(int protect)
        {
            this.protect = protect;
        }

        public int getProtect() => this.protect;


        ~Shield()
        {

        }
    };
}


