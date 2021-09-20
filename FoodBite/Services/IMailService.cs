namespace FoodBite.Services
{
    public interface IMailService
    {
        void SendMessage(string to, int phone, string body);
    }
}