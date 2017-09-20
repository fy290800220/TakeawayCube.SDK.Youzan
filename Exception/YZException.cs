namespace YouZanSdkNetCore.Exception
{
    public class YZException : System.Exception
    {
        private string message;

        public YZException(string message)
        {
            this.message = message;
        }
    }
}
