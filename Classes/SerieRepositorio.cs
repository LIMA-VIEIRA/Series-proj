using System;
using System.Collections.Generic;
using Series.interfaces;

namespace Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new list<Serie>();
        public void Atualiza(int id, series objeto)
        {
            listaSerie[id] = objeto;
        }
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }
        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }
        public list<Serie> Lista()
        {
           return listaSerie.Count;
        }
        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}