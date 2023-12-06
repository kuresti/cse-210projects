using System;

//Running Activity class derived from
//the abstract Activity class
public class RunningActivity : Activity 
{
    //Constructor for the RunningActivity
    public RunningActivity(float distance, int lengthOfTime, string date) : base(distance, lengthOfTime, date)
    {}

    //Methods of Running Activity

    //Distance method
    public override float GetDistance()
    {
        return _distance;
    }

    //Pace method
    public override float GetPace()
    {
        _pace = _lengthOfTime / GetDistance();
        return _pace;
    }

    //Speed method
    public override float GetSpeed()
    {
        _speed = (GetDistance() / _lengthOfTime) * 60;
        return _speed;
    }




}