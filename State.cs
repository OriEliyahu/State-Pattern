class State
{
    FireState gunlock;
    private int amount;

    public State()
    {
        this.amount = 10;
    }
    public void SetGunLock(FireState gunlock)
    {
        this.gunlock = gunlock;
        this.gunlock.SetRifle(this);
    }

    public void RifleShoot()
    {
        this.amount --;
    }

    public int GetAmount()
    {
        return amount;
    }

    public void Shoot()
    {
        gunlock.PressTrigger();
    }
}