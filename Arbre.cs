using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPArbres
{
	/// <summary>
	/// Exeption si jamais le type ne correspond pas au type des autres noeuds
	/// </summary>
	class MauvaisTypeException : Exception
	{
		public MauvaisTypeException() : base("Le type du noeud entré est incorrect.") { }
	}

	class Arbre<T> : IEnumerable<T> where T : IComparable<T>
	{
		private Noeud<T> ndRacine; //premier noeud de l'arbre
		internal Noeud<T> NdRacine { get => ndRacine; set => ndRacine = value; }

		public Arbre(Noeud<T> p_ndRac)
		{
			ndRacine = p_ndRac;
		}

		/// <summary>
		/// Méthode d'insertion de noeud
		/// </summary>
		/// <param name="p_valeur">Valeur du noeud a ajouter</param>
		/// <param name="p_nd">noeud qu'on est en train de parcourir</param>
		public void Inserer(T p_valeur, ref Noeud<T> p_nd)
		{
			//On verifie les types, si ils sont differents ont lance une exception
			if (p_valeur.GetType().ToString() != ndRacine.Valeur.GetType().ToString())
			{
				throw new MauvaisTypeException();
			}			

			//On compare la valeur du noeud parcouru avec la valeur a ajouter
			if (p_nd.Valeur.CompareTo(p_valeur) >= 0) //Si la valeur a ajouter est inferieure ou egale a celle parcourue on ajoute a gauche
			{
				if (p_nd.NdGauche == null) //Si le noeud est vide à gauche on ajoute la valeur ici
				{
					p_nd.NdGauche = new Noeud<T>(p_valeur, NodePosition.G);
				}
				else //Si le noeud contient une valeur on continue a parcourir les noeuds
				{
					Noeud<T> ndTmp = p_nd.NdGauche;
					Inserer(p_valeur, ref ndTmp);
				}
			}
			else //Si la valeur a ajouter est superieure a celle parcourue on ajoute a droite
			{
				if (p_nd.NdDroit == null) //Si le noeud est vide à droite on ajoute la valeur ici
				{
					p_nd.NdDroit = new Noeud<T>(p_valeur, NodePosition.D);
				}
				else //Si le noeud contient une valeur on continue a parcourir les noeuds
				{
					Noeud<T> ndTmp = p_nd.NdDroit;
					Inserer(p_valeur, ref ndTmp);
				}
			}
			
		}

		public IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
