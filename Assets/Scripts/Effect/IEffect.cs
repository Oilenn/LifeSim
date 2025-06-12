namespace Effect
{
    public interface IEffect
    {
        public void Activate(ILifeable lifeable);
    }
}