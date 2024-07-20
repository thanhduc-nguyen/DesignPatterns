namespace Bridge.HeadFirst
{
    public class SecondGenerationRemoteControl(ITv tv) : RemoteControl(tv)
    {
        public void TurnOffByTime(int second)
        {
            Console.WriteLine($"Turn Off after {second} second.");
            Thread.Sleep(5000);
            tv.Off();
        }
    }
}
