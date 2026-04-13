using System.Media;

public class VoiceGreeting
{
    public static void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Student\source\repos\SmartChartBot\SmartChartBot\greeting.wav");
            player.PlaySync(); // plays before continuing
            //"C:\Users\Student\source\repos\SmartChartBot\SmartChartBot\greeting.wav"
        }
        catch
        {
            Console.WriteLine("Voice greeting could not be played.");   
        }
    }
}
