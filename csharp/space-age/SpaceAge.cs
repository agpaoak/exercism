using System;

public class SpaceAge
{

    private int seconds;
    private double minutes;
    private double hours;
    private double days;


    public SpaceAge(int seconds)
    {
        // All values are the space ages in seconds , minutes, hours, days
        this.seconds = seconds;
        minutes = this.seconds / 60; //60 seconds per minutes
        hours = minutes / 60; // 60 minutes per hour
        days = hours / 24; // 24 hours per day

    }

    public double OnEarth()
    {
        double earthOrbital = 365.25; // Earth days for 1 orbit


        return days / earthOrbital;

    }

    public double OnMercury()
    {
        double mercuryOrbital = 0.2408467;

        return OnEarth() / mercuryOrbital;
    }

    public double OnVenus()
    {
        double venusOrbital = 0.61519726;
        return OnEarth() / venusOrbital;
    }

    public double OnMars()
    {
        double marsOrbital = 1.8808158;
        return OnEarth() / marsOrbital;
    }

    public double OnJupiter()
    {
        double jupiterOrbital = 11.862615;
        return OnEarth() / jupiterOrbital;
    }

    public double OnSaturn()
    {
        double saturnOrbital = 29.447498;
        return OnEarth() / saturnOrbital;
    }

    public double OnUranus()
    {
        double uranusOrbital = 84.016846;
        return OnEarth() / uranusOrbital;
    }

    public double OnNeptune()
    {
        double neptuneOrbital = 164.79132;
        return OnEarth() / neptuneOrbital;
    }
}