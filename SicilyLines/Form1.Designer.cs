namespace SicilyLines
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
            this.listBoxSecteur = new System.Windows.Forms.ListBox();
            this.listBoxResLiaison = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxSecteur
            // 
            this.listBoxSecteur.FormattingEnabled = true;
            this.listBoxSecteur.ItemHeight = 25;
            this.listBoxSecteur.Location = new System.Drawing.Point(86, 74);
            this.listBoxSecteur.Name = "listBoxSecteur";
            this.listBoxSecteur.Size = new System.Drawing.Size(230, 204);
            this.listBoxSecteur.TabIndex = 0;
            this.listBoxSecteur.SelectedIndexChanged += new System.EventHandler(this.listBoxSecteur_SelectedIndexChanged);
            // 
            // listBoxResLiaison
            // 
            this.listBoxResLiaison.FormattingEnabled = true;
            this.listBoxResLiaison.ItemHeight = 25;
            this.listBoxResLiaison.Location = new System.Drawing.Point(495, 101);
            this.listBoxResLiaison.Name = "listBoxResLiaison";
            this.listBoxResLiaison.Size = new System.Drawing.Size(210, 154);
            this.listBoxResLiaison.TabIndex = 1;
            this.listBoxResLiaison.SelectedIndexChanged += new System.EventHandler(this.listBoxResLiaison_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.listBoxResLiaison);
            this.Controls.Add(this.listBoxSecteur);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSecteur;
        private System.Windows.Forms.ListBox listBoxResLiaison;
    }
}

