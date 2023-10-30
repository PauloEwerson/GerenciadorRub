using System.Collections.Generic;

namespace AtacadaoGerenciadorRub
{
    public class DistribuidorRub
    {
        private readonly List<IGerenciadorRub> _gerenciadoresRub;

        public DistribuidorRub()
        {
            _gerenciadoresRub = new List<IGerenciadorRub>
            {
                new GerenciadorRubLoja(),
                new GerenciadorRubFrios(),
                new GerenciadorRubDeposito(),
                new GerenciadorRubHortifruti(),
                new GerenciadorRubApoio(),
                new GerenciadorRubFrenteCaixa(),
                new GerenciadorRubPrevencao(),
                new GerenciadorRubInventariantes(),
                new GerenciadorRubEstoque(),
                new GerenciadorRubCheckin(),
                new GerenciadorRubCartazista(),
                new GerenciadorRubReserva(),
            };
        }

        public void VincularRubParaSetor(IGerenciadorRub setor)
        {
            setor.VincularRub();
        }

        public void DesvincularRubDeSetor(IGerenciadorRub setor)
        {
            setor.DesvincularRub();
        }
    }
}
