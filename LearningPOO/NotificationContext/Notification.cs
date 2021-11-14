namespace LearningPOO.NotificationContext
{
    public sealed class Notification
    {
        public Notification() { }
        public Notification(string property, string errorMessage)
        {
            Property = property;
            ErrorMessage = errorMessage;
        }
        public string Property { get; set; }
        public string ErrorMessage { get; set; }
    }
}