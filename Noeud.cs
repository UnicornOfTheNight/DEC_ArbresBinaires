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
	public enum NodePosition
	{
		G, //gauche
		D, //droite
		R //racine
	}
	class Noeud<T> : IEnumerable<T> where T: IComparable<T>
	{
		private T _valeur; //valeur du noeud
		private Noeud<T> _ndDroit; //noeud a droite
		private Noeud<T> _ndGauche; //noeud a gauche
		private NodePosition _pos; //position du noeud
		public T Valeur { get => _valeur; set => _valeur = value; }
		public Noeud<T> NdDroit { get => _ndDroit; set => _ndDroit = value; }
		public Noeud<T> NdGauche { get => _ndGauche; set => _ndGauche = value; }
		public NodePosition Pos { get => _pos; set => _pos = value; }

		public Noeud(T p_valeur, NodePosition p_position)
		{
			_valeur = p_valeur;
			_pos = p_position;
			_ndDroit = null;
			_ndGauche = null;
		}

		/// <summary>
		/// Afficher les noeuds
		/// </summary>
		/// <param name="p_lbl">Label dans lequel ils vont s'afficher</param>
		/// <param name="p_str">chaine de caractères à ajouter</param>
		/// <param name="p_dernier">vrai si le noeud a afficher est le dernier de sa ligne, faux sinon</param>
		public void Afficher(ref Label p_lbl, string p_str, bool p_dernier)
		{
			p_lbl.Text += "\r\n" + p_str; //on affiche les lignes

			if (p_dernier)
			{
				p_str += "         ";
				p_lbl.Text += "|+" + _pos.ToString() + " : "; //on affiche si c'est la racine, le noeud de droite ou de gauche
			}
			else
			{
				p_str += "|        ";
				p_lbl.Text += "|+" + _pos.ToString() + " : "; //on affiche si c'est la racine, le noeud de droite ou de gauche
			}

			p_lbl.Text += Valeur; //on affiche la valeur du noeud

			List<Noeud<T>> elements = new List<Noeud<T>>();
			if (NdGauche != null) //Si le noeud a gauche est remplit on l'ajoute a la liste pour le parcourir
			{
				elements.Add(NdGauche);
			}

			if (NdDroit != null) //si le noeud a droite est remplit on l'ajoute a la liste pour le parcourir
			{
				elements.Add(NdDroit);
			}

			for (int i = 0; i < elements.Count; i++) //on parcours la liste qui contient les noeuds a parcourir
			{
				bool dernierTmp = false; //variable pour savoir si le noeud est le dernier
				if (i == elements.Count - 1) dernierTmp = true; //si on est a la fin de la liste alors le noeud est le dernier
				
				elements[i].Afficher(ref p_lbl, p_str, dernierTmp); //on les affiche
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
