using System;
using System.Collections.Generic;

abstract class FireState
{
    protected State rifle;

    public void SetRifle(State rifle)
    {
        this.rifle = rifle;
    }

    public abstract void PressTrigger();
}