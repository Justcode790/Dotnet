class Logger
{
    private static Logger obj;
    private Logger()
    {}

    public static Logger GetInstance(){
        if (obj == null){
            obj = new Logger();
        }
        return obj;
    }

    public void Log(string msg){
        Console.WriteLine("Log: " + msg);
    }
}