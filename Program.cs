using System;
using System.Collections.Generic;

namespace AtacadaoGerenciadorRub
{
    class Programa
    {
        static void Main(string[] args)
        {
            var loja = new GerenciadorRubLoja();
            var frios = new GerenciadorRubFrios();
            var deposito = new GerenciadorRubDeposito();
            var hortifruti = new GerenciadorRubHortifruti();
            var apoio = new GerenciadorRubApoio();
            var frenteCaixa = new GerenciadorRubFrenteCaixa();
            var prevencao = new GerenciadorRubPrevencao();
            var inventariantes = new GerenciadorRubInventariantes();
            var estoque = new GerenciadorRubEstoque();
            var checkin = new GerenciadorRubCheckin();
            var cartazista = new GerenciadorRubCartazista();
            var reserva = new GerenciadorRubReserva();

            var gerenciadores = new List<IGerenciadorRub>
            {
                loja, frios, deposito, hortifruti, apoio, frenteCaixa, prevencao, inventariantes, estoque, checkin, cartazista, reserva
            };

            Console.WriteLine("Rubs Disponíveis por Setor:\n");
            foreach (var gerenciador in gerenciadores)
            {
                Console.WriteLine($"{gerenciador.GetType().Name.Replace("GerenciadorRub", "")}: {gerenciador.RubsDisponiveis} disponíveis");
            }
        }
    }
}
