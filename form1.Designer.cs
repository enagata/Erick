namespace Erick
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblLayout1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.tbllayout2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblCAPTURA = new System.Windows.Forms.Label();
            this.lbldor = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.txtcusto = new System.Windows.Forms.MaskedTextBox();
            this.txtdist = new System.Windows.Forms.MaskedTextBox();
            this.gbRadio = new System.Windows.Forms.GroupBox();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.cbDor = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lstDados = new System.Windows.Forms.ListView();
            this.tblLayout1.SuspendLayout();
            this.tbllayout2.SuspendLayout();
            this.gbRadio.SuspendLayout();
            this.gbButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayout1
            // 
            this.tblLayout1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblLayout1.ColumnCount = 2;
            this.tblLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 348F));
            this.tblLayout1.Controls.Add(this.btnExcluir, 0, 0);
            this.tblLayout1.Controls.Add(this.btnIncluir, 0, 0);
            this.tblLayout1.Location = new System.Drawing.Point(514, 17);
            this.tblLayout1.Margin = new System.Windows.Forms.Padding(4);
            this.tblLayout1.Name = "tblLayout1";
            this.tblLayout1.RowCount = 1;
            this.tblLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblLayout1.Size = new System.Drawing.Size(534, 46);
            this.tblLayout1.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(190, 4);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(178, 32);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluir.Location = new System.Drawing.Point(4, 4);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(178, 32);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // tbllayout2
            // 
            this.tbllayout2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbllayout2.ColumnCount = 2;
            this.tbllayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbllayout2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 362F));
            this.tbllayout2.Controls.Add(this.lblData, 0, 0);
            this.tbllayout2.Controls.Add(this.lblCusto, 0, 1);
            this.tbllayout2.Controls.Add(this.lblDistancia, 0, 2);
            this.tbllayout2.Controls.Add(this.lblCAPTURA, 0, 3);
            this.tbllayout2.Controls.Add(this.lbldor, 0, 4);
            this.tbllayout2.Controls.Add(this.txtdata, 1, 0);
            this.tbllayout2.Controls.Add(this.txtcusto, 1, 1);
            this.tbllayout2.Controls.Add(this.txtdist, 1, 2);
            this.tbllayout2.Controls.Add(this.gbRadio, 1, 3);
            this.tbllayout2.Controls.Add(this.cbDor, 1, 4);
            this.tbllayout2.Controls.Add(this.listView1, 0, 6);
            this.tbllayout2.Controls.Add(this.gbButton, 0, 5);
            this.tbllayout2.Location = new System.Drawing.Point(514, 71);
            this.tbllayout2.Margin = new System.Windows.Forms.Padding(4);
            this.tbllayout2.Name = "tbllayout2";
            this.tbllayout2.RowCount = 7;
            this.tbllayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tbllayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tbllayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tbllayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tbllayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tbllayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 277F));
            this.tbllayout2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tbllayout2.Size = new System.Drawing.Size(534, 536);
            this.tbllayout2.TabIndex = 2;
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(64, 0);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(43, 62);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCusto
            // 
            this.lblCusto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(60, 62);
            this.lblCusto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(52, 62);
            this.lblCusto.TabIndex = 1;
            this.lblCusto.Text = "Custo";
            this.lblCusto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDistancia
            // 
            this.lblDistancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(49, 124);
            this.lblDistancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(74, 62);
            this.lblDistancia.TabIndex = 2;
            this.lblDistancia.Text = "Distância";
            this.lblDistancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCAPTURA
            // 
            this.lblCAPTURA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCAPTURA.AutoSize = true;
            this.lblCAPTURA.Location = new System.Drawing.Point(52, 186);
            this.lblCAPTURA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCAPTURA.Name = "lblCAPTURA";
            this.lblCAPTURA.Size = new System.Drawing.Size(67, 62);
            this.lblCAPTURA.TabIndex = 3;
            this.lblCAPTURA.Text = "Captura";
            this.lblCAPTURA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldor
            // 
            this.lbldor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbldor.AutoSize = true;
            this.lbldor.Location = new System.Drawing.Point(38, 248);
            this.lbldor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldor.Name = "lbldor";
            this.lbldor.Size = new System.Drawing.Size(96, 62);
            this.lbldor.TabIndex = 4;
            this.lbldor.Text = "Nivel de dor";
            this.lbldor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdata
            // 
            this.txtdata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdata.Location = new System.Drawing.Point(176, 18);
            this.txtdata.Margin = new System.Windows.Forms.Padding(4);
            this.txtdata.Mask = "00/00/0000";
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(354, 26);
            this.txtdata.TabIndex = 5;
            this.txtdata.ValidatingType = typeof(System.DateTime);
            // 
            // txtcusto
            // 
            this.txtcusto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcusto.Location = new System.Drawing.Point(176, 80);
            this.txtcusto.Margin = new System.Windows.Forms.Padding(4);
            this.txtcusto.Mask = "$ 999999,00";
            this.txtcusto.Name = "txtcusto";
            this.txtcusto.Size = new System.Drawing.Size(354, 26);
            this.txtcusto.TabIndex = 6;
            // 
            // txtdist
            // 
            this.txtdist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdist.Location = new System.Drawing.Point(176, 142);
            this.txtdist.Margin = new System.Windows.Forms.Padding(4);
            this.txtdist.Mask = "00000000";
            this.txtdist.Name = "txtdist";
            this.txtdist.Size = new System.Drawing.Size(354, 26);
            this.txtdist.TabIndex = 7;
            // 
            // gbRadio
            // 
            this.gbRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbRadio.Controls.Add(this.rbSim);
            this.gbRadio.Controls.Add(this.rbNao);
            this.gbRadio.Location = new System.Drawing.Point(176, 190);
            this.gbRadio.Margin = new System.Windows.Forms.Padding(4);
            this.gbRadio.Name = "gbRadio";
            this.gbRadio.Padding = new System.Windows.Forms.Padding(4);
            this.gbRadio.Size = new System.Drawing.Size(354, 54);
            this.gbRadio.TabIndex = 9;
            this.gbRadio.TabStop = false;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(141, 22);
            this.rbSim.Margin = new System.Windows.Forms.Padding(4);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(54, 22);
            this.rbSim.TabIndex = 1;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(4, 22);
            this.rbNao.Margin = new System.Windows.Forms.Padding(4);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(56, 22);
            this.rbNao.TabIndex = 0;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // cbDor
            // 
            this.cbDor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDor.FormattingEnabled = true;
            this.cbDor.Items.AddRange(new object[] {
             "",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbDor.Location = new System.Drawing.Point(176, 268);
            this.cbDor.Margin = new System.Windows.Forms.Padding(4);
            this.cbDor.Name = "cbDor";
            this.cbDor.Size = new System.Drawing.Size(354, 26);
            this.cbDor.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 590);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 22);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // gbButton
            // 
            this.gbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbllayout2.SetColumnSpan(this.gbButton, 2);
            this.gbButton.Controls.Add(this.lblId);
            this.gbButton.Controls.Add(this.btnCancelar);
            this.gbButton.Controls.Add(this.btnSalvar);
            this.gbButton.Location = new System.Drawing.Point(4, 314);
            this.gbButton.Margin = new System.Windows.Forms.Padding(4);
            this.gbButton.Name = "gbButton";
            this.gbButton.Padding = new System.Windows.Forms.Padding(4);
            this.gbButton.Size = new System.Drawing.Size(526, 269);
            this.gbButton.TabIndex = 10;
            this.gbButton.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(135, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 18);
            this.lblId.TabIndex = 2;
            this.lblId.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(292, 82);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 32);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Location = new System.Drawing.Point(102, 82);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(177, 32);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lstDados
            // 
            this.lstDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstDados.GridLines = true;
            this.lstDados.HideSelection = false;
            this.lstDados.Location = new System.Drawing.Point(13, 17);
            this.lstDados.Name = "lstDados";
            this.lstDados.Size = new System.Drawing.Size(463, 590);
            this.lstDados.TabIndex = 3;
            this.lstDados.UseCompatibleStateImageBehavior = false;
            this.lstDados.View = System.Windows.Forms.View.Details;
            this.lstDados.SelectedIndexChanged += new System.EventHandler(this.lstDados_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.Controls.Add(this.lstDados);
            this.Controls.Add(this.tbllayout2);
            this.Controls.Add(this.tblLayout1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ACME FLIGHT MANAGER";
            this.tblLayout1.ResumeLayout(false);
            this.tbllayout2.ResumeLayout(false);
            this.tbllayout2.PerformLayout();
            this.gbRadio.ResumeLayout(false);
            this.gbRadio.PerformLayout();
            this.gbButton.ResumeLayout(false);
            this.gbButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblLayout1;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TableLayoutPanel tbllayout2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCusto;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblCAPTURA;
        private System.Windows.Forms.Label lbldor;
        private System.Windows.Forms.MaskedTextBox txtdata;
        private System.Windows.Forms.MaskedTextBox txtcusto;
        private System.Windows.Forms.MaskedTextBox txtdist;
        private System.Windows.Forms.GroupBox gbRadio;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.GroupBox gbButton;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbDor;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView lstDados;
        private System.Windows.Forms.Label lblId;
    }
}

