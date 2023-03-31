using ConsoleApp1.Name;

namespace ConsoleApp1.Price
{
    class Price : Name.Name
    {
        private int price = 0;
        public Price(string name, int price)
        {
            this.price = price;
        }

        public void setPrice(int price)
        {
            this.price = price;
        }

        public int getPrice() => this.price;

        ~Price()
        {

        }
    };
}