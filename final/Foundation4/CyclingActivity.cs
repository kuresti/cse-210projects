using System;

//CyclingActivity class derived from
//the Activity class

public class CyclingActivity : Activity
{
    //Constructor for CyclingActivity
    public CyclingActivity(float speed, int lengthOfTime, string date, bool isCycling) :base(speed, lengthOfTime, date, isCycling)
    {}

    //Methods inherited from Activity class

    //Distance method
    public override float GetDistance()
    {
        _distance = (GetSpeed() / 60) * _lengthOfTime;
        return _distance;
    }

    //Speed method
    public override float GetSpeed()
    {
        return _speed;
    }
}