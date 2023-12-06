using System;

//Base class for Activities
public class Activity
{
    //Attributes that will be inherited by the 
    //derived classes
    protected float _distance;
    protected float _speed;
    protected float _pace;
    protected int _lengthOfTime;
    protected string _date;

    //Constructors for Activity class

    //Constructor for the Running class
    public Activity(float distance, int lengthOfTime, string date)
    {
        _distance = distance;
        _lengthOfTime = lengthOfTime;
        _date = date;
    }

    //Constructor for CyclingActivity

    public Activity(float speed, int lengthOfTime, string date, bool isCycling)
    {
        if (isCycling == true)
            {
                _speed = speed;
            }
        _lengthOfTime = lengthOfTime;
        _date = date;
    }

    //Constructor for SwimmingActivity
    public Activity(int lengthOfTime, string date)
    {
        _lengthOfTime = lengthOfTime;
        _date = date;
    }


    //Methods of the Activity class that will
    //be inherited by the derived classes some will
    //be overridden and one will not.
    public virtual float GetDistance()
    {
        _distance = _speed * _lengthOfTime;
        return _distance;
    }

    public virtual float GetSpeed()
    {
        _speed = _distance / _lengthOfTime;
        return _speed;
    }
    public virtual float GetPace()
    {
        _pace = _lengthOfTime / _distance;
        return _pace;
    }

    public virtual string GetSummaryString()
    {
        return $"\n-{_date} {GetType()} ({_lengthOfTime} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph Pace {GetPace()} min per mile";
    }

}