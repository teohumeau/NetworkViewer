namespace NetworkViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableau = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPv4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passerelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_quitter = new System.Windows.Forms.Button();
            this.button_actualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).BeginInit();
            this.SuspendLayout();
            // 
            // tableau
            // 
            this.tableau.AllowUserToAddRows = false;
            this.tableau.AllowUserToDeleteRows = false;
            this.tableau.AllowUserToResizeColumns = false;
            this.tableau.AllowUserToResizeRows = false;
            this.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Interface,
            this.IPv4,
            this.Passerelle,
            this.Masque});
            this.tableau.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tableau.Location = new System.Drawing.Point(109, 12);
            this.tableau.MultiSelect = false;
            this.tableau.Name = "tableau";
            this.tableau.ReadOnly = true;
            this.tableau.RowTemplate.Height = 33;
            this.tableau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tableau.Size = new System.Drawing.Size(1428, 445);
            this.tableau.TabIndex = 0;
            // 
            // Type
            // 
            this.Type.Frozen = true;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 160;
            // 
            // Interface
            // 
            this.Interface.Frozen = true;
            this.Interface.HeaderText = "Interface";
            this.Interface.Name = "Interface";
            this.Interface.ReadOnly = true;
            this.Interface.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Interface.Width = 210;
            // 
            // IPv4
            // 
            this.IPv4.Frozen = true;
            this.IPv4.HeaderText = "Adresse IP";
            this.IPv4.Name = "IPv4";
            this.IPv4.ReadOnly = true;
            this.IPv4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Passerelle
            // 
            this.Passerelle.Frozen = true;
            this.Passerelle.HeaderText = "Passerelle";
            this.Passerelle.Name = "Passerelle";
            this.Passerelle.ReadOnly = true;
            this.Passerelle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Masque
            // 
            this.Masque.Frozen = true;
            this.Masque.HeaderText = "Masque sous-réseau";
            this.Masque.Name = "Masque";
            this.Masque.ReadOnly = true;
            this.Masque.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // button_quitter
            // 
            this.button_quitter.BackgroundImage = global::NetworkViewer.Properties.Resources.Annuler;
            this.button_quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_quitter.Location = new System.Drawing.Point(13, 110);
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.Size = new System.Drawing.Size(90, 90);
            this.button_quitter.TabIndex = 2;
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // button_actualiser
            // 
            this.button_actualiser.BackgroundImage = global::NetworkViewer.Properties.Resources.Boucle;
            this.button_actualiser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_actualiser.Location = new System.Drawing.Point(13, 13);
            this.button_actualiser.Name = "button_actualiser";
            this.button_actualiser.Size = new System.Drawing.Size(90, 90);
            this.button_actualiser.TabIndex = 1;
            this.button_actualiser.UseVisualStyleBackColor = true;
            this.button_actualiser.Click += new System.EventHandler(this.button_actualiser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 469);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.button_actualiser);
            this.Controls.Add(this.tableau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Network Viewer v1.1";
            ((System.ComponentModel.ISupportInitialize)(this.tableau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableau;
        private System.Windows.Forms.Button button_actualiser;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interface;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPv4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passerelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masque;
    }
}

