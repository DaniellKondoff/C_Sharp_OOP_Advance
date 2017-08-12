namespace _01.Stream_Progress
{
    public class StreamProgressInfo
    {
        private IStreamable streamFIle;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IStreamable streamFile)
        {
            this.streamFIle = streamFile;
        }

        public int CalculateCurrentPercent()
        {
            return (this.streamFIle.BytesSent * 100) / this.streamFIle.Length;
        }
    }
}