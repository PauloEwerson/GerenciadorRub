namespace AtacadaoGerenciadorRub
{
    public abstract class GerenciadorRub : IGerenciadorRub
    {
        protected int _totalRubs;
        protected int _rubsDistribuidos;

        public int TotalRubs => _totalRubs;
        public int RubsDisponiveis => _totalRubs - _rubsDistribuidos;

        public virtual void DesvincularRub()
        {
            if (_rubsDistribuidos > 0) _rubsDistribuidos--;
        }

        public virtual void VincularRub()
        {
            if (_rubsDistribuidos < _totalRubs) _rubsDistribuidos++;
        }
    }
}
