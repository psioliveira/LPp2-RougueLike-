using System;
using System.Collections;

namespace RougueLikeRPG
{
    /// <summary>
    /// Classe que representa uma mochila ou saco que contem itens
    /// </summary>
    /// <summary>Array que contém os itens da mochila</summary>
    public class Bag : ISortable
    {

        
        public ArrayList items;
        private char c = '&';

        /// <summary>Número de itens na mochila</summary>
        public int StuffCount { get { return items.Count; } }

        /// <summary>
        /// O peso corresponde ao peso total dos itens.
        /// </summary>
        public float Weight
        {
            get
            {
                float totalWeight = 0;
                foreach (IAmItem aThing in items)
                {
                    if (aThing != null)
                    {
                        totalWeight += aThing.Weight;
                    }
                }
                return totalWeight;
            }
        }

        /// <summary>
        /// Construtor que cria uma nova instância de mochila
        /// </summary>
        /// </param>
        public Bag()
        {
            items = new ArrayList(8);
        }

        /// <summary>Colocar um item na mochila</summary>
        public void AddThing(IAmItem aThing)
        {
            // Adicionar o item à mochila e 
            // incrementar o número de coisas na mochila
            items.Add(aThing);
        }

        /// <summary>Observar um item da mochila sem o remover da mesma</summary>
        /// <param Name="index">Local onde está o item a observar</param>
        /// <returns>Item a ser observado</returns>
        public IAmItem GetThing(int index)
        {
            if (index >= StuffCount)
            {
                index = StuffCount - 1;
            }
            return items[index] as IAmItem;
        }

        public char GetC()
        {
            return c;
        }

    }
}

