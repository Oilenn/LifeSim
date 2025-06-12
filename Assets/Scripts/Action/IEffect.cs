namespace Action
{
    public interface IEffect
    {
        public void Activate(ILifeable lifeable);
    }
}