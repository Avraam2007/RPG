namespace ConsoleApp1.TimeHelper
{
    abstract class TimeHelper
    {
        private DateTime createdAt;
        private DateTime updatedAt;
        private DateTime deletedAt;
        private bool isDelete = false;
        private const string format = "dddd, d/MM/yy, H:mm, K";

        public TimeHelper()
        {
            createdAt = DateTime.Now;
            updatedAt = DateTime.Now;
        }

        public void deleted()
        {
            isDelete = true;
            deletedAt = DateTime.Now;
        }

        protected void updated()
        {
            updatedAt = DateTime.Now;
        }

        protected bool checkUpdate()
        {
            return !createdAt.Equals(updatedAt);
        }

        public string getFormatCreatedAt()
        {
            return createdAt.ToString(format);
        }
    }
}
