namespace Phone
{
    public class Galaxy : Phone, IRingable{
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            return ringTone;
        }
                    
        public string Unlock() 
        {
            return $"Galaxy {versionNumber} is unlocked";
        }
        public override void DisplayInfo() 
        {
            System.Console.WriteLine($"Version: {versionNumber}; Battery: {batteryPercentage}; Carrier: {carrier}; Ring Tone: {ringTone}");          
        }
    }
}
