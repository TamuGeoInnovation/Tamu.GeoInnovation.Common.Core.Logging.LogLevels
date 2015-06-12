using System.Diagnostics;

namespace USC.GISResearchLab.Common.Logs
{
	/// <summary>
	/// Summary description for LogLevels.
	/// </summary>
    public class LogLevels
    {
        public static int[] Levels = { 0, 1, 2, 3, 4, 5, 6 };

        public LogLevels()
        {
        }


        public static EventTypeFilter GetFilter(int level)
        {
            EventTypeFilter ret = null;
            switch (level)
            {
                case 0:
                    ret = new EventTypeFilter(SourceLevels.Off);
                    break;
                case 1:
                    ret = new EventTypeFilter(SourceLevels.Critical);
                    break;
                case 2:
                    ret = new EventTypeFilter(SourceLevels.Error);
                    break;
                case 3:
                    ret = new EventTypeFilter(SourceLevels.Warning);
                    break;
                case 4:
                    ret = new EventTypeFilter(SourceLevels.Information);
                    break;
                case 5:
                    ret = new EventTypeFilter(SourceLevels.Verbose);
                    break;
                case 6:
                    ret = new EventTypeFilter(SourceLevels.All);
                    break;
            }
            return ret;
        }

        
    }
}
