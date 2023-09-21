namespace task2; 

public class Date {
    private int _month;

    public int Month
    {
        get
        {
            return _month;
        }
        set
        {
            if (value > 0 && value < 13) {
                _month = value;
            }
        }
    }
}
