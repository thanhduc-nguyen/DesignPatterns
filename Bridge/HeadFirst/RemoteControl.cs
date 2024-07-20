namespace Bridge.HeadFirst
{
    public abstract class RemoteControl(ITv tv)
    {
        public List<KeyValuePair<int, string>> Channels { get; set; } = [];
        public int CurrentChannel { get; protected set; } = 0;

        public void TurnOn()
        {
            tv.On();
        }

        public void TurnOff()
        {
            tv.Off();
        }

        public void SetCurrentChannel(int channel)
        {
            CurrentChannel = channel;
        }

        public void SetUpChannel(string channelName)
        {
            if (tv.TuneChannel(channelName))
            {
                Channels.Add(new KeyValuePair<int, string>(CurrentChannel, channelName));
            }
        }

        public void NextChannel()
        {
            CurrentChannel = CurrentChannel + 1;
        }

        public void PreviousChannel()
        {
            CurrentChannel = CurrentChannel - 1;
        }
    }
}
