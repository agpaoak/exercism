using System;

public class SpaceAge
{

    private readonly int seconds;
    private readonly double minutes;
    private readonly double hours;
    private readonly double days;
    private readonly double earthOrbital    = 365.25;       // Earth days for 1 orbit
    private readonly double mercuryOrbital  = 0.2408467;    // Earth days for 1 orbit
    private readonly double venusOrbital    = 0.61519726;   // Earth days for 1 orbit
    private readonly double marsOrbital     = 1.8808158;    // Earth days for 1 orbit
    private readonly double jupiterOrbital  = 11.862615;    // Earth days for 1 orbit
    private readonly double saturnOrbital   = 29.447498;    // Earth days for 1 orbit
    private readonly double uranusOrbital   = 84.016846;    // Earth days for 1 orbit
    private readonly double neptuneOrbital  = 164.79132;    // Earth days for 1 orbit


    public SpaceAge(int seconds)
    {
        // All values are the space ages in seconds , minutes, hours, days
        this.seconds    = seconds;
        minutes = this.seconds / 60;    //60 seconds per minutes
        hours   = minutes / 60;         // 60 minutes per hour
        days    = hours / 24;           // 24 hours per day

    }

    public double OnEarth() => days / earthOrbital;

    public double OnMercury() =>  OnEarth() / mercuryOrbital;
  
    public double OnVenus() =>  OnEarth() / venusOrbital;

    public double OnMars() => OnEarth() / marsOrbital;
   
    public double OnJupiter() => OnEarth() / jupiterOrbital;
   
    public double OnSaturn() => OnEarth() / saturnOrbital;
   
    public double OnUranus() => OnEarth() / uranusOrbital;
 
    public double OnNeptune() => OnEarth() / neptuneOrbital;
  
}