namespace CyberSecurityAwarenessBot.Utils
{
    public static class AnimationHelper
    {
        public static void TypeWrite(string message, int delay = 20)
        {
            foreach (char letter in message)
            {
                Console.Write(letter);
                Thread.Sleep(delay);
            }

            Console.WriteLine();
        }
    }
}