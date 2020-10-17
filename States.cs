class Safe : FireState
{
    public override void PressTrigger()
    {
        System.Console.WriteLine("not shooting");
    }
}

class SemiAuto : FireState
{
    public override void PressTrigger()
    {
        if(rifle.GetAmount() > 0)
        {
            rifle.RifleShoot();
            System.Console.WriteLine("pew");
        }
    }
}

class FullAuto : FireState
{
    public override void PressTrigger()
    {
        while(rifle.GetAmount() > 0)
        {
            rifle.RifleShoot();
            System.Console.WriteLine("pew");
        }
    }
}