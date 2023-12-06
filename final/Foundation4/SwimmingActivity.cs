using System;

//SwimmingActivity class derived from
//the Activity class
public class SwimmingActivity : Activity
{
    //Attribute of Swimming Activity
    private int _numSwimLaps;

    //Constructor of Swimming Activity
    public SwimmingActivity(int numSwimLaps, int lengthOfTime, string date) :base(lengthOfTime, date)
    {
        _numSwimLaps = numSwimLaps;
    }

    //Override methods of SwimmingActivity

    //Distance method
    public override float GetDistance()
    {
        _distance = (float)(_numSwimLaps * 50 / 1000 * 0.62);
        return _distance;
    }

    //Speed method
    public override float GetSpeed()
    {
        _speed = (GetDistance() / _lengthOfTime) * 60;
        return _speed;
    }

    //Pace method
    public override float GetPace()
    {
        _pace = _lengthOfTime / GetDistance();
        return _pace;
    }
}