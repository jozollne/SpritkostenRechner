namespace SpritkostenRechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.spritKostenLabel = new System.Windows.Forms.Label();
            this.spritkostenBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.streckeBox = new System.Windows.Forms.TextBox();
            this.verbauchBox = new System.Windows.Forms.TextBox();
            this.streckeInKMLabel = new System.Windows.Forms.Label();
            this.verbrauchDurchschnittLabel = new System.Windows.Forms.Label();
            this.spritGesKostenLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spritKostenLabel
            // 
            this.spritKostenLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spritKostenLabel.AutoSize = true;
            this.spritKostenLabel.Font = new System.Drawing.Font("Calisto MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spritKostenLabel.Location = new System.Drawing.Point(50, 53);
            this.spritKostenLabel.Name = "spritKostenLabel";
            this.spritKostenLabel.Size = new System.Drawing.Size(289, 34);
            this.spritKostenLabel.TabIndex = 1;
            this.spritKostenLabel.Text = "Sprit Kosten pro Liter:";
            // 
            // spritkostenBox
            // 
            this.spritkostenBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spritkostenBox.Font = new System.Drawing.Font("Calisto MT", 21.75F);
            this.spritkostenBox.Location = new System.Drawing.Point(3, 143);
            this.spritkostenBox.Name = "spritkostenBox";
            this.spritkostenBox.Size = new System.Drawing.Size(383, 41);
            this.spritkostenBox.TabIndex = 4;
            this.spritkostenBox.Tag = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.streckeBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.verbauchBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.streckeInKMLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.spritKostenLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.spritkostenBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.verbrauchDurchschnittLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.spritGesKostenLabel, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.31565F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.36871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.31565F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1170, 367);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // streckeBox
            // 
            this.streckeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streckeBox.Font = new System.Drawing.Font("Calisto MT", 21.75F);
            this.streckeBox.Location = new System.Drawing.Point(392, 143);
            this.streckeBox.Name = "streckeBox";
            this.streckeBox.Size = new System.Drawing.Size(384, 41);
            this.streckeBox.TabIndex = 6;
            this.streckeBox.Tag = "";
            // 
            // verbauchBox
            // 
            this.verbauchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verbauchBox.Font = new System.Drawing.Font("Calisto MT", 21.75F);
            this.verbauchBox.Location = new System.Drawing.Point(782, 143);
            this.verbauchBox.Name = "verbauchBox";
            this.verbauchBox.Size = new System.Drawing.Size(385, 41);
            this.verbauchBox.TabIndex = 8;
            this.verbauchBox.Tag = "";
            // 
            // streckeInKMLabel
            // 
            this.streckeInKMLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.streckeInKMLabel.AutoSize = true;
            this.streckeInKMLabel.Font = new System.Drawing.Font("Calisto MT", 21.75F);
            this.streckeInKMLabel.Location = new System.Drawing.Point(489, 53);
            this.streckeInKMLabel.Name = "streckeInKMLabel";
            this.streckeInKMLabel.Size = new System.Drawing.Size(189, 34);
            this.streckeInKMLabel.TabIndex = 3;
            this.streckeInKMLabel.Text = "Strecke in km:";
            // 
            // verbrauchDurchschnittLabel
            // 
            this.verbrauchDurchschnittLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.verbrauchDurchschnittLabel.AutoSize = true;
            this.verbrauchDurchschnittLabel.Font = new System.Drawing.Font("Calisto MT", 21.75F);
            this.verbrauchDurchschnittLabel.Location = new System.Drawing.Point(787, 36);
            this.verbrauchDurchschnittLabel.Name = "verbrauchDurchschnittLabel";
            this.verbrauchDurchschnittLabel.Size = new System.Drawing.Size(374, 68);
            this.verbrauchDurchschnittLabel.TabIndex = 5;
            this.verbrauchDurchschnittLabel.Text = "Durshschnitlicher Verbrauch auf 100km:";
            // 
            // spritGesKostenLabel
            // 
            this.spritGesKostenLabel.AutoSize = true;
            this.spritGesKostenLabel.Font = new System.Drawing.Font("Calisto MT", 21.75F);
            this.spritGesKostenLabel.Location = new System.Drawing.Point(392, 225);
            this.spritGesKostenLabel.Name = "spritGesKostenLabel";
            this.spritGesKostenLabel.Size = new System.Drawing.Size(224, 34);
            this.spritGesKostenLabel.TabIndex = 9;
            this.spritGesKostenLabel.Text = "Spritkosten Ges.:";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 367);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label spritKostenLabel;
        private System.Windows.Forms.TextBox spritkostenBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox verbauchBox;
        private System.Windows.Forms.Label streckeInKMLabel;
        private System.Windows.Forms.Label verbrauchDurchschnittLabel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.TextBox streckeBox;
        private System.Windows.Forms.Label spritGesKostenLabel;
    }
}

