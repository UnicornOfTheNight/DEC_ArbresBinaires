namespace TPArbres
{
	partial class Form1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblLegende = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblAjoutNd = new System.Windows.Forms.Label();
			this.lblTypeNd = new System.Windows.Forms.Label();
			this.lbType = new System.Windows.Forms.ListBox();
			this.gbAjout = new System.Windows.Forms.GroupBox();
			this.btAjout = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.gbAjout.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Location = new System.Drawing.Point(21, 304);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(164, 114);
			this.panel2.TabIndex = 3;
			// 
			// lblLegende
			// 
			this.lblLegende.AutoSize = true;
			this.lblLegende.Location = new System.Drawing.Point(30, 67);
			this.lblLegende.Name = "lblLegende";
			this.lblLegende.Size = new System.Drawing.Size(0, 36);
			this.lblLegende.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblLegende);
			this.groupBox1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(975, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(365, 264);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Legende";
			// 
			// lblAjoutNd
			// 
			this.lblAjoutNd.AutoSize = true;
			this.lblAjoutNd.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAjoutNd.Location = new System.Drawing.Point(20, 181);
			this.lblAjoutNd.Name = "lblAjoutNd";
			this.lblAjoutNd.Size = new System.Drawing.Size(291, 28);
			this.lblAjoutNd.TabIndex = 6;
			this.lblAjoutNd.Text = "Valeur du noeud à ajouter : ";
			// 
			// lblTypeNd
			// 
			this.lblTypeNd.AutoSize = true;
			this.lblTypeNd.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTypeNd.Location = new System.Drawing.Point(20, 46);
			this.lblTypeNd.Name = "lblTypeNd";
			this.lblTypeNd.Size = new System.Drawing.Size(162, 28);
			this.lblTypeNd.TabIndex = 8;
			this.lblTypeNd.Text = "Type du noeud";
			// 
			// lbType
			// 
			this.lbType.FormattingEnabled = true;
			this.lbType.ItemHeight = 27;
			this.lbType.Location = new System.Drawing.Point(25, 77);
			this.lbType.Name = "lbType";
			this.lbType.Size = new System.Drawing.Size(412, 85);
			this.lbType.TabIndex = 9;
			this.lbType.SelectedIndexChanged += new System.EventHandler(this.lbType_SelectedIndexChanged);
			// 
			// gbAjout
			// 
			this.gbAjout.Controls.Add(this.btAjout);
			this.gbAjout.Controls.Add(this.lbType);
			this.gbAjout.Controls.Add(this.lblTypeNd);
			this.gbAjout.Controls.Add(this.lblAjoutNd);
			this.gbAjout.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbAjout.Location = new System.Drawing.Point(12, 12);
			this.gbAjout.Name = "gbAjout";
			this.gbAjout.Size = new System.Drawing.Size(929, 264);
			this.gbAjout.TabIndex = 10;
			this.gbAjout.TabStop = false;
			this.gbAjout.Text = "Ajout de noeuds";
			// 
			// btAjout
			// 
			this.btAjout.Location = new System.Drawing.Point(744, 194);
			this.btAjout.Name = "btAjout";
			this.btAjout.Size = new System.Drawing.Size(159, 52);
			this.btAjout.TabIndex = 10;
			this.btAjout.Text = "Ajouter";
			this.btAjout.UseVisualStyleBackColor = true;
			this.btAjout.Click += new System.EventHandler(this.btAjout_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1397, 542);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.gbAjout);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gbAjout.ResumeLayout(false);
			this.gbAjout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblLegende;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblAjoutNd;
		private System.Windows.Forms.Label lblTypeNd;
		private System.Windows.Forms.ListBox lbType;
		private System.Windows.Forms.GroupBox gbAjout;
		private System.Windows.Forms.Button btAjout;
	}
}

