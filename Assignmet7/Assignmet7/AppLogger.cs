namespace Assignmet7;

public class AppLogger
{
    private static AppLogger _appLogger;

    private AppLogger()
    {
    }

    public static AppLogger GetLogger()
    {
        if (_appLogger is null)
        {
            _appLogger = new AppLogger();
        }
        return _appLogger;
    }
    
    
}