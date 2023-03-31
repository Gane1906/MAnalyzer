namespace MAnalyzer
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer(string message)
        {
            this.message=message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                    return "SAD";
                return "HAPPY";
            }
            catch (Exception)
            {
                throw new MAnalyzerException(MAnalyzerException.ExceptionType.NULL_MOOD, "message is null");
            }
        }
    }
}