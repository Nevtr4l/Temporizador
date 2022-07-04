
namespace Cronometro2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btniniciar = new System.Windows.Forms.Button();
            this.cbhoras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbminutos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbsegundos = new System.Windows.Forms.ComboBox();
            this.lbtiempo = new System.Windows.Forms.Label();
            this.btnpausar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btniniciar
            // 
            this.btniniciar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btniniciar, "btniniciar");
            this.btniniciar.ForeColor = System.Drawing.Color.ForestGreen;
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.UseVisualStyleBackColor = false;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // cbhoras
            // 
            this.cbhoras.FormattingEnabled = true;
            resources.ApplyResources(this.cbhoras, "cbhoras");
            this.cbhoras.Name = "cbhoras";
            this.cbhoras.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbminutos
            // 
            this.cbminutos.FormattingEnabled = true;
            resources.ApplyResources(this.cbminutos, "cbminutos");
            this.cbminutos.Name = "cbminutos";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbsegundos
            // 
            this.cbsegundos.FormattingEnabled = true;
            resources.ApplyResources(this.cbsegundos, "cbsegundos");
            this.cbsegundos.Name = "cbsegundos";
            // 
            // lbtiempo
            // 
            resources.ApplyResources(this.lbtiempo, "lbtiempo");
            this.lbtiempo.Name = "lbtiempo";
            // 
            // btnpausar
            // 
            this.btnpausar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnpausar, "btnpausar");
            this.btnpausar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnpausar.Name = "btnpausar";
            this.btnpausar.UseVisualStyleBackColor = false;
            this.btnpausar.Click += new System.EventHandler(this.btnpausar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.btnpausar);
            this.Controls.Add(this.lbtiempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbsegundos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbminutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbhoras);
            this.Controls.Add(this.btniniciar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.ComboBox cbhoras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbminutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbsegundos;
        private System.Windows.Forms.Label lbtiempo;
        private System.Windows.Forms.Button btnpausar;
        private System.Windows.Forms.Timer timer1;
    }
}

