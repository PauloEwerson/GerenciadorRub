namespace AtacadaoGerenciadorRub
{
    public interface IGerenciadorRub
    {
        int TotalRubs { get; }
        int RubsDisponiveis { get; }
        void DesvincularRub();
        void VincularRub();
    }
}
