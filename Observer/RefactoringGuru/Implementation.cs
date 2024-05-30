namespace Observer.RefactoringGuru
{
    /// <summary>
    /// Subscriber.
    /// </summary>
    public interface IBroadcastChannel
    {
        void SendMessage(string data);
    }

    /// <summary>
    /// Concrete Subscriber 1.
    /// </summary>
    public class Sms : IBroadcastChannel
    {
        public void SendMessage(string data)
        {
            Console.WriteLine($"SMS: {data}");
        }
    }

    /// <summary>
    /// Concrete Subscriber 2.
    /// </summary>
    public class Email : IBroadcastChannel
    {
        public void SendMessage(string data)
        {
            Console.WriteLine($"Email: {data}");
        }
    }

    /// <summary>
    /// Concrete Subscriber 3.
    /// </summary>
    public class Television : IBroadcastChannel
    {
        public void SendMessage(string data)
        {
            Console.WriteLine($"Television: {data}");
        }
    }

    /// <summary>
    /// Publisher.
    /// </summary>
    public class BroadcastManager
    {
        protected List<Tuple<string, IBroadcastChannel>> broadcastChannels = new List<Tuple<string, IBroadcastChannel>>();

        public void Subscribe(string eventType, IBroadcastChannel channel)
        {
            broadcastChannels.Add(new Tuple<string, IBroadcastChannel>(eventType, channel));
        }

        public void Unsubscribe(string eventType, IBroadcastChannel channel)
        {
            broadcastChannels.RemoveAll(x => x.Item1.Equals(eventType) && x.Item2.GetType().Equals(channel.GetType()));
        }

        public void Notify(string eventType, string data)
        {
            var filteredBroadcastChannels = broadcastChannels.Where(x => x.Item1.Equals(eventType)).Select(x => x.Item2);
            foreach (IBroadcastChannel channel in filteredBroadcastChannels)
            {
                channel.SendMessage(data);
            }
        }
    }

    public class Store
    {
        public BroadcastManager broadcastManager;

        public Store(BroadcastManager broadcastManager)
        {
            this.broadcastManager = broadcastManager;
        }

        public void IntroduceNewPhone()
        {
            broadcastManager.Notify("phone", "A new phone was introduced!");
        }

        public void IntroduceNewLaptop()
        {
            broadcastManager.Notify("laptop", "A new laptop was introduced!");
        }
    }
}
