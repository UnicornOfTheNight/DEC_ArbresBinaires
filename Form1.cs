using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPArbres
{
	public partial class Form1 : Form
	{
		Control ctr = null;
		Label lbl = new Label();
		Arbre<int> arbreI = null;
		Arbre<string> arbreS = null;
		Arbre<decimal> arbreD = null;

		public Form1()
		{
			InitializeComponent();

			//liste des types possible a afficher dans l'arbre
			lbType.Items.Add("Nombre entier");
			lbType.Items.Add("Nombre décimal");
			lbType.Items.Add("Chaine de caractères");

			//Initialisation du label pour afficher l'arbre
			lbl.Location = new Point(10, 10);
			lbl.Text = "";
			lbl.AutoSize = true;
			lbl.Font = new Font("Cambria", 16);
			panel2.Controls.Add(lbl);
			panel2.AutoScroll = true;
		}		

		private void Form1_Load(object sender, EventArgs e)
		{
			//on affiche la legende pour les lettres
			int largeurGb = groupBox1.Width;
			lblLegende.Text = "R : Racine \r\nG : Noeud gauche \r\nD : Noeud droit";
			groupBox1.Location = new Point(ClientRectangle.Width - largeurGb - 10, 10);
			panel2.Size = new Size(ClientRectangle.Width - largeurGb - 50, ClientRectangle.Height - 50); //on modifie la taille pour qu'elle remplisse l'écran
			panel2.Refresh();
		}

		private void btAjout_Click(object sender, EventArgs e)
		{			
			lbl.Text = ""; //on remet le label a 0

			switch (lbType.SelectedIndex) 
			{
				case 0: //si on ajoute un nombre entier
					int nvlleValeurI; //valeur a ajouter
					Noeud<int> ndI; 

					if (arbreI == null) //si l'arbre est nouveau et donc ne contient aucune valeur
					{
						nvlleValeurI = Convert.ToInt32((ctr as NumericUpDown).Value); //on recupere la valeur a ajouter
						ndI = new Noeud<int>(nvlleValeurI, NodePosition.R); //noeud a ajouter (racine)
						arbreI = new Arbre<int>(ndI); 
					}
					else //si l'arbre contient deja une ou plusieurs valeurs
					{
						ndI = arbreI.NdRacine; //pour inserer on parcours l'arbre depuis le noeud racine
						nvlleValeurI = Convert.ToInt32((ctr as NumericUpDown).Value); //on recupere la valeur a ajouter
										
						try //on essaie d'inserer le nouveau noeud
						{
							arbreI.Inserer(nvlleValeurI, ref ndI);
						}
						catch (MauvaisTypeException ex)
						{
							Debug.WriteLine(ex.Message);
						}

					}
					ndI.Afficher(ref lbl, "", true); //on affiche les noeuds
					break;

				case 1: //si on ajoute un nombre decimal
					decimal nvlleValeurD; //Valeur a ajouter
					Noeud<decimal> ndD;
					if (arbreD == null)//si l'arbre est nouveau et donc ne contient aucune valeur
					{
						nvlleValeurD = (ctr as NumericUpDown).Value;//on recupere la valeur a ajouter
						ndD = new Noeud<decimal>(nvlleValeurD, NodePosition.R);//noeud a ajouter (racine)
						arbreD = new Arbre<decimal>(ndD);
					}
					else//si l'arbre contient deja une ou plusieurs valeurs
					{
						ndD = arbreD.NdRacine;//pour inserer on parcours l'arbre depuis le noeud racine
						nvlleValeurD = Convert.ToDecimal((ctr as NumericUpDown).Value);//on recupere la valeur a ajouter

						try //on essaie d'inserer le nouveau noeud
						{
							arbreD.Inserer(nvlleValeurD, ref ndD);
						}
						catch (MauvaisTypeException ex)
						{
							Debug.WriteLine(ex.Message);
						}

					}
					ndD.Afficher(ref lbl, "", true); //on affiche les noeuds
					break;

				case 2: //si on ajoute un chaine de caracteres
					string nvlleValeurS;//Valeur a ajouter
					Noeud<string> ndS;
					
					if (arbreS == null)//si l'arbre est nouveau et donc ne contient aucune valeur
					{
						nvlleValeurS = (ctr as TextBox).Text; //on recupere la valeur a ajouter
						ndS = new Noeud<string>(nvlleValeurS, NodePosition.R); //noeud a ajouter (racine)
						arbreS = new Arbre<string>(ndS);
					}
					else//si l'arbre contient deja une ou plusieurs valeurs
					{
						ndS = arbreS.NdRacine;//pour inserer on parcours l'arbre depuis le noeud racine
						nvlleValeurS = (ctr as TextBox).Text;//on recupere la valeur a ajouter

						try //on essaie d'inserer le nouveau noeud
						{
							arbreS.Inserer(nvlleValeurS, ref ndS);
						}
						catch (MauvaisTypeException ex)
						{
							Debug.WriteLine(ex.Message);
						}

					}
					ndS.Afficher(ref lbl, "", true); //on affiche les noeuds
					break;
			}
			
			panel2.Refresh(); //on rafraichit le panel
		}

		private void lbType_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (lbType.SelectedIndex)
			{
				case 0: //si le nombre entier est selectionné
					//on crée un controle numericUpDown pour que l'utilisateur puisse saisir une valeur a ajouter
					NumericUpDown nudEntier = new NumericUpDown();
					nudEntier.Value = 0;
					nudEntier.Location = new Point(lblAjoutNd.Location.X, lblAjoutNd.Location.Y + 30);
					nudEntier.Size = new Size(100, 10);

					gbAjout.Controls.Add(nudEntier); //on ajoute le controle au label

					if(ctr != null) gbAjout.Controls.Remove(ctr); //Si un controle est deja afficher on le supprime
					gbAjout.Refresh(); //on met a jour le groupbox
					ctr = nudEntier;
					break;

				case 1: //si le nombre décimal est selectionné
					//on crée un controle numericUpDown pour que l'utilisateur puisse saisir une valeur a ajouter
					NumericUpDown nudDecimal = new NumericUpDown();
					nudDecimal.Value = 0;
					nudDecimal.Location = new Point(lblAjoutNd.Location.X, lblAjoutNd.Location.Y + 30);
					nudDecimal.Size = new Size(100, 10);
					nudDecimal.DecimalPlaces = 2; //on affiche les décimales
					
					gbAjout.Controls.Add(nudDecimal);//on ajoute le controle au label

					if (ctr != null) gbAjout.Controls.Remove(ctr); //Si un controle est deja afficher on le supprime
					gbAjout.Refresh();//on met a jour le groupbox
					ctr = nudDecimal;
					break;

				case 2: //si la chaine de caractères est selectionnée
					//on crée un controle textbox pour que l'utilisateur puisse saisir une valeur a ajouter
					TextBox tb = new TextBox();
					tb.Size = new Size(250, 10);
					tb.Location = new Point(lblAjoutNd.Location.X, lblAjoutNd.Location.Y + 30);

					gbAjout.Controls.Add(tb);//on ajoute le controle au label
					
					if (ctr != null) gbAjout.Controls.Remove(ctr); //Si un controle est deja afficher on le supprime

					gbAjout.Refresh(); //on met a jour le groupbox
					ctr = tb;
					break;
			}
		}
	}
}
