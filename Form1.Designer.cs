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
            this.dataGridView_interfaces = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interface = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPv4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passerelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_mode = new System.Windows.Forms.Button();
            this.button_quitter = new System.Windows.Forms.Button();
            this.button_actualiser = new System.Windows.Forms.Button();
            this.comboBox_interfaces = new System.Windows.Forms.ComboBox();
            this.dataGridView_netview = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresseIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_adresseIP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_interfaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_netview)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_interfaces
            // 
            this.dataGridView_interfaces.AllowUserToAddRows = false;
            this.dataGridView_interfaces.AllowUserToDeleteRows = false;
            this.dataGridView_interfaces.AllowUserToResizeColumns = false;
            this.dataGridView_interfaces.AllowUserToResizeRows = false;
            this.dataGridView_interfaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_interfaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Interface,
            this.IPv4,
            this.Passerelle,
            this.Masque});
            this.dataGridView_interfaces.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_interfaces.Location = new System.Drawing.Point(109, 12);
            this.dataGridView_interfaces.MultiSelect = false;
            this.dataGridView_interfaces.Name = "dataGridView_interfaces";
            this.dataGridView_interfaces.ReadOnly = true;
            this.dataGridView_interfaces.RowHeadersVisible = false;
            this.dataGridView_interfaces.RowTemplate.Height = 33;
            this.dataGridView_interfaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_interfaces.Size = new System.Drawing.Size(1428, 445);
            this.dataGridView_interfaces.TabIndex = 0;
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
            // button_mode
            // 
            this.button_mode.BackgroundImage = global::NetworkViewer.Properties.Resources.Réseau;
            this.button_mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_mode.Location = new System.Drawing.Point(13, 109);
            this.button_mode.Name = "button_mode";
            this.button_mode.Size = new System.Drawing.Size(90, 90);
            this.button_mode.TabIndex = 3;
            this.button_mode.UseVisualStyleBackColor = true;
            this.button_mode.Click += new System.EventHandler(this.button_mode_Click);
            // 
            // button_quitter
            // 
            this.button_quitter.BackgroundImage = global::NetworkViewer.Properties.Resources.Annuler;
            this.button_quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_quitter.Location = new System.Drawing.Point(13, 205);
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
            // comboBox_interfaces
            // 
            this.comboBox_interfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_interfaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_interfaces.FormattingEnabled = true;
            this.comboBox_interfaces.Location = new System.Drawing.Point(110, 12);
            this.comboBox_interfaces.Name = "comboBox_interfaces";
            this.comboBox_interfaces.Size = new System.Drawing.Size(673, 45);
            this.comboBox_interfaces.TabIndex = 4;
            this.comboBox_interfaces.SelectedIndexChanged += new System.EventHandler(this.comboBox_interfaces_SelectedIndexChanged);
            // 
            // dataGridView_netview
            // 
            this.dataGridView_netview.AllowUserToAddRows = false;
            this.dataGridView_netview.AllowUserToDeleteRows = false;
            this.dataGridView_netview.AllowUserToResizeColumns = false;
            this.dataGridView_netview.AllowUserToResizeRows = false;
            this.dataGridView_netview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_netview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.AdresseIP,
            this.Ping});
            this.dataGridView_netview.Location = new System.Drawing.Point(110, 63);
            this.dataGridView_netview.MultiSelect = false;
            this.dataGridView_netview.Name = "dataGridView_netview";
            this.dataGridView_netview.ReadOnly = true;
            this.dataGridView_netview.RowHeadersVisible = false;
            this.dataGridView_netview.RowTemplate.Height = 33;
            this.dataGridView_netview.Size = new System.Drawing.Size(1427, 394);
            this.dataGridView_netview.TabIndex = 5;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // AdresseIP
            // 
            this.AdresseIP.HeaderText = "Adresse IP";
            this.AdresseIP.Name = "AdresseIP";
            this.AdresseIP.ReadOnly = true;
            // 
            // Ping
            // 
            this.Ping.HeaderText = "Ping";
            this.Ping.Name = "Ping";
            this.Ping.ReadOnly = true;
            // 
            // label_adresseIP
            // 
            this.label_adresseIP.AutoSize = true;
            this.label_adresseIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_adresseIP.Location = new System.Drawing.Point(790, 12);
            this.label_adresseIP.Name = "label_adresseIP";
            this.label_adresseIP.Size = new System.Drawing.Size(0, 44);
            this.label_adresseIP.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 469);
            this.Controls.Add(this.label_adresseIP);
            this.Controls.Add(this.dataGridView_netview);
            this.Controls.Add(this.comboBox_interfaces);
            this.Controls.Add(this.button_mode);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.button_actualiser);
            this.Controls.Add(this.dataGridView_interfaces);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1575, 540);
            this.Name = "Form1";
            this.Text = "Network Viewer ";
            this.Resize += new System.EventHandler(this.modifierDimensions);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_interfaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_netview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_interfaces;
        private System.Windows.Forms.Button button_actualiser;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interface;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPv4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passerelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masque;
        private System.Windows.Forms.Button button_mode;
        private System.Windows.Forms.ComboBox comboBox_interfaces;
        private System.Windows.Forms.DataGridView dataGridView_netview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresseIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ping;
        private System.Windows.Forms.Label label_adresseIP;
    }
}

