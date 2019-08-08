namespace Phone
{
    public class Nokia : Phone, IRingable{
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            return ringTone;
        }
        public string Unlock() 
        {
            return $"Nokia {versionNumber} is unlocked";
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine($"Version: {versionNumber}; Battery: {batteryPercentage}; Carrier: {carrier}; Ring Tone: {ringTone}");
        }
    }
}
