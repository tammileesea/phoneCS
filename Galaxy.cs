namespace Phone
{
    public class Galaxy : Phone, IRingable{
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            return "Phone is ringing";
        }
                    
        public string Unlock() 
        {
            return "Phone is unlocked";
        }
        public override void DisplayInfo() 
        {
            System.Console.WriteLine($"Version: {versionNumber}; Battery: {batterPercentage}; Carrier: {carrier}; Ring Tone: {ringTone}");          
        }
    }
}
