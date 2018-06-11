using System;
using System.Collections;

namespace RougueLike
{
    public class Bag
    {

        /// <summary>
        /// Classe que representa uma mochila ou saco que contem itens
        /// </summary>
        /// <summary>Array que contém os itens da mochila</summary>
        private ArrayList items;

        /// <summary>Número de itens na mochila</summary>
        public int StuffCount { get { return items.Count; } }

        /// <summary>
        /// No caso da Bag, o peso vai corresponder ao peso total dos itens.
        /// </summary>
        public float Weight
        {
            get
            {
                float totalWeight = 0;
                foreach (IStuffs aThing in items)
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
        /// <param name="aThing">Item a colocar na mochila</param>
        public void AddThing(IStuffs aThing)
        {
            // Adicionar o item à mochila e depois incrementar o
            // número de coisas na mochila
            items.Add(aThing);
        }

        /// <summary>Observar um item da mochila sem o remover da mesma</summary>
        /// <param name="index">Local onde está o item a observar</param>
        /// <returns>Item a ser observado</returns>
        public IStuffs GetThing(int index)
        {
            if (index >= StuffCount)
            {
                // Senão existir um item no local indicado, "lançar" uma exceção
                throw new InvalidOperationException(
                    "Bag doesn't have that much stuff!");
            }
            return items[index] as IStuffs;
        }

        /// <summary>
        /// Sobreposição do método ToString() para a classe Bag.
        /// </summary>
        /// <returns>
        /// Uma string contendo informação sobre a mochila e os seus conteúdos.
        /// </returns>
        public override string ToString()
        {
            return $"Mochila com {StuffCount} itens e um peso total de {Weight} Kg";
        }


    }
}

