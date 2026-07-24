namespace CyberSecurityAwarenessBot.GUI.Services
{
    public class MemoryService
    {
        public string UserName { get; private set; } = "";
        public string FavouriteTopic { get; private set; } = "";

        public void SetName(string name)
        {
            UserName = name;
        }

        public void RememberTopic(string topic)
        {
            FavouriteTopic = topic;
        }

        public bool HasName()
        {
            return !string.IsNullOrWhiteSpace(UserName);
        }
    }
}