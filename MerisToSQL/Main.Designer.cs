namespace MerisToSQL
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label2 = new System.Windows.Forms.Label();
            this.databasebox = new System.Windows.Forms.TextBox();
            this.finishedres = new System.Windows.Forms.TextBox();
            this.crtbtn = new System.Windows.Forms.Button();
            this.resultbox = new System.Windows.Forms.Label();
            this.merise = new System.Windows.Forms.TextBox();
            this.tablesbox = new System.Windows.Forms.Label();
            this.use = new System.Windows.Forms.Label();
            this.CSQbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "BaseName :";
            // 
            // databasebox
            // 
            this.databasebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databasebox.Location = new System.Drawing.Point(131, 20);
            this.databasebox.Name = "databasebox";
            this.databasebox.Size = new System.Drawing.Size(199, 29);
            this.databasebox.TabIndex = 2;
            this.databasebox.Text = "HOTEL";
            // 
            // finishedres
            // 
            this.finishedres.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishedres.Location = new System.Drawing.Point(12, 181);
            this.finishedres.Multiline = true;
            this.finishedres.Name = "finishedres";
            this.finishedres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.finishedres.Size = new System.Drawing.Size(1061, 535);
            this.finishedres.TabIndex = 3;
            // 
            // crtbtn
            // 
            this.crtbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crtbtn.Location = new System.Drawing.Point(551, 9);
            this.crtbtn.Name = "crtbtn";
            this.crtbtn.Size = new System.Drawing.Size(108, 46);
            this.crtbtn.TabIndex = 4;
            this.crtbtn.Text = "Create";
            this.crtbtn.UseVisualStyleBackColor = true;
            this.crtbtn.Click += new System.EventHandler(this.crtbtn_Click);
            // 
            // resultbox
            // 
            this.resultbox.AutoSize = true;
            this.resultbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultbox.Location = new System.Drawing.Point(545, 20);
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(0, 20);
            this.resultbox.TabIndex = 5;
            // 
            // merise
            // 
            this.merise.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merise.Location = new System.Drawing.Point(12, 64);
            this.merise.Multiline = true;
            this.merise.Name = "merise";
            this.merise.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.merise.Size = new System.Drawing.Size(1061, 111);
            this.merise.TabIndex = 6;
            this.merise.Text = "CHAMBRE(!$NUM CHAMBRE,TYPE_CHAMBRE, $PRIX)\r\nCLIENT(!$ID_CLIENT, NOM_CLIENT, LOGIN" +
    ", PASSWORD)\r\nRESERVATION(#NUM CHAMBRE, #ID_CLIENT, %DATE_RESERVATION,$NOMBRE_JOU" +
    "R)";
            // 
            // tablesbox
            // 
            this.tablesbox.AutoSize = true;
            this.tablesbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablesbox.Location = new System.Drawing.Point(401, 20);
            this.tablesbox.Name = "tablesbox";
            this.tablesbox.Size = new System.Drawing.Size(86, 24);
            this.tablesbox.TabIndex = 7;
            this.tablesbox.Text = "X Tables";
            // 
            // use
            // 
            this.use.AutoSize = true;
            this.use.Cursor = System.Windows.Forms.Cursors.Hand;
            this.use.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.use.Location = new System.Drawing.Point(1027, 26);
            this.use.Name = "use";
            this.use.Size = new System.Drawing.Size(37, 16);
            this.use.TabIndex = 8;
            this.use.Text = "Help";
            this.use.Click += new System.EventHandler(this.use_Click);
            // 
            // CSQbtn
            // 
            this.CSQbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CSQbtn.Location = new System.Drawing.Point(770, 9);
            this.CSQbtn.Name = "CSQbtn";
            this.CSQbtn.Size = new System.Drawing.Size(166, 46);
            this.CSQbtn.TabIndex = 9;
            this.CSQbtn.Text = "Copy SQL Query";
            this.CSQbtn.UseVisualStyleBackColor = true;
            this.CSQbtn.Click += new System.EventHandler(this.CSQbtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 728);
            this.Controls.Add(this.CSQbtn);
            this.Controls.Add(this.use);
            this.Controls.Add(this.tablesbox);
            this.Controls.Add(this.merise);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.crtbtn);
            this.Controls.Add(this.finishedres);
            this.Controls.Add(this.databasebox);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "MerisSQL v0.2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox databasebox;
        private System.Windows.Forms.TextBox finishedres;
        private System.Windows.Forms.Button crtbtn;
        private System.Windows.Forms.Label resultbox;
        private System.Windows.Forms.TextBox merise;
        private System.Windows.Forms.Label tablesbox;
        private System.Windows.Forms.Label use;
        private System.Windows.Forms.Button CSQbtn;
    }
}

