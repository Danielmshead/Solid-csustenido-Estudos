namespace MetalGearSolid
{
    public abstract class Cargo
    {
        public IRegraCalculo Regra { get; private set; }

        public Cargo(IRegraCalculo regra)
        {
            Regra = regra;
        }
    }
}
