
namespace WindowsFormsApp1
{
    partial class fmrUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cdusuarioLabel;
            System.Windows.Forms.Label nmusuarioLabel;
            System.Windows.Forms.Label sglevelLabel;
            System.Windows.Forms.Label nmloginLabel;
            System.Windows.Forms.Label cdsenhaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrUsuario));
            this.cadastro = new WindowsFormsApp1.cadastro();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarioTableAdapter = new WindowsFormsApp1.cadastroTableAdapters.tbUsuarioTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.cadastroTableAdapters.TableAdapterManager();
            this.tbUsuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbUsuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cdusuarioTextBox = new System.Windows.Forms.TextBox();
            this.nmusuarioTextBox = new System.Windows.Forms.TextBox();
            this.sglevelTextBox = new System.Windows.Forms.TextBox();
            this.nmloginTextBox = new System.Windows.Forms.TextBox();
            this.cdsenhaTextBox = new System.Windows.Forms.TextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            cdusuarioLabel = new System.Windows.Forms.Label();
            nmusuarioLabel = new System.Windows.Forms.Label();
            sglevelLabel = new System.Windows.Forms.Label();
            nmloginLabel = new System.Windows.Forms.Label();
            cdsenhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingNavigator)).BeginInit();
            this.tbUsuarioBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // cdusuarioLabel
            // 
            cdusuarioLabel.AutoSize = true;
            cdusuarioLabel.Location = new System.Drawing.Point(52, 129);
            cdusuarioLabel.Name = "cdusuarioLabel";
            cdusuarioLabel.Size = new System.Drawing.Size(56, 13);
            cdusuarioLabel.TabIndex = 1;
            cdusuarioLabel.Text = "cdusuario:";
            // 
            // nmusuarioLabel
            // 
            nmusuarioLabel.AutoSize = true;
            nmusuarioLabel.Location = new System.Drawing.Point(57, 155);
            nmusuarioLabel.Name = "nmusuarioLabel";
            nmusuarioLabel.Size = new System.Drawing.Size(58, 13);
            nmusuarioLabel.TabIndex = 3;
            nmusuarioLabel.Text = "nmusuario:";
            // 
            // sglevelLabel
            // 
            sglevelLabel.AutoSize = true;
            sglevelLabel.Location = new System.Drawing.Point(59, 184);
            sglevelLabel.Name = "sglevelLabel";
            sglevelLabel.Size = new System.Drawing.Size(43, 13);
            sglevelLabel.TabIndex = 5;
            sglevelLabel.Text = "sglevel:";
            // 
            // nmloginLabel
            // 
            nmloginLabel.AutoSize = true;
            nmloginLabel.Location = new System.Drawing.Point(57, 210);
            nmloginLabel.Name = "nmloginLabel";
            nmloginLabel.Size = new System.Drawing.Size(46, 13);
            nmloginLabel.TabIndex = 7;
            nmloginLabel.Text = "nmlogin:";
            // 
            // cdsenhaLabel
            // 
            cdsenhaLabel.AutoSize = true;
            cdsenhaLabel.Location = new System.Drawing.Point(57, 236);
            cdsenhaLabel.Name = "cdsenhaLabel";
            cdsenhaLabel.Size = new System.Drawing.Size(51, 13);
            cdsenhaLabel.TabIndex = 9;
            cdsenhaLabel.Text = "cdsenha:";
            // 
            // cadastro
            // 
            this.cadastro.DataSetName = "cadastro";
            this.cadastro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.cadastro;
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbFornecedorTableAdapter = null;
            this.tableAdapterManager.tbProdutoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = this.tbUsuarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.cadastroTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbUsuarioBindingNavigator
            // 
            this.tbUsuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbUsuarioBindingNavigator.BindingSource = this.tbUsuarioBindingSource;
            this.tbUsuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbUsuarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbUsuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbUsuarioBindingNavigatorSaveItem});
            this.tbUsuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbUsuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbUsuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbUsuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbUsuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbUsuarioBindingNavigator.Name = "tbUsuarioBindingNavigator";
            this.tbUsuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbUsuarioBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tbUsuarioBindingNavigator.TabIndex = 0;
            this.tbUsuarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tbUsuarioBindingNavigatorSaveItem
            // 
            this.tbUsuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbUsuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbUsuarioBindingNavigatorSaveItem.Image")));
            this.tbUsuarioBindingNavigatorSaveItem.Name = "tbUsuarioBindingNavigatorSaveItem";
            this.tbUsuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tbUsuarioBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbUsuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbUsuarioBindingNavigatorSaveItem_Click);
            // 
            // cdusuarioTextBox
            // 
            this.cdusuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "cdusuario", true));
            this.cdusuarioTextBox.Location = new System.Drawing.Point(121, 126);
            this.cdusuarioTextBox.Name = "cdusuarioTextBox";
            this.cdusuarioTextBox.Size = new System.Drawing.Size(62, 20);
            this.cdusuarioTextBox.TabIndex = 2;
            // 
            // nmusuarioTextBox
            // 
            this.nmusuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nmusuario", true));
            this.nmusuarioTextBox.Location = new System.Drawing.Point(121, 152);
            this.nmusuarioTextBox.Name = "nmusuarioTextBox";
            this.nmusuarioTextBox.Size = new System.Drawing.Size(191, 20);
            this.nmusuarioTextBox.TabIndex = 4;
            // 
            // sglevelTextBox
            // 
            this.sglevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "sglevel", true));
            this.sglevelTextBox.Location = new System.Drawing.Point(121, 181);
            this.sglevelTextBox.Name = "sglevelTextBox";
            this.sglevelTextBox.Size = new System.Drawing.Size(42, 20);
            this.sglevelTextBox.TabIndex = 6;
            // 
            // nmloginTextBox
            // 
            this.nmloginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nmlogin", true));
            this.nmloginTextBox.Location = new System.Drawing.Point(121, 207);
            this.nmloginTextBox.Name = "nmloginTextBox";
            this.nmloginTextBox.Size = new System.Drawing.Size(100, 20);
            this.nmloginTextBox.TabIndex = 8;
            // 
            // cdsenhaTextBox
            // 
            this.cdsenhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "cdsenha", true));
            this.cdsenhaTextBox.Location = new System.Drawing.Point(121, 233);
            this.cdsenhaTextBox.Name = "cdsenhaTextBox";
            this.cdsenhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cdsenhaTextBox.TabIndex = 10;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(172, 318);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 11;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(269, 318);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 12;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(357, 318);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(448, 318);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(538, 318);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(269, 361);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(357, 361);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 17;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(172, 361);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(448, 361);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(538, 361);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 20;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // fmrUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(cdusuarioLabel);
            this.Controls.Add(this.cdusuarioTextBox);
            this.Controls.Add(nmusuarioLabel);
            this.Controls.Add(this.nmusuarioTextBox);
            this.Controls.Add(sglevelLabel);
            this.Controls.Add(this.sglevelTextBox);
            this.Controls.Add(nmloginLabel);
            this.Controls.Add(this.nmloginTextBox);
            this.Controls.Add(cdsenhaLabel);
            this.Controls.Add(this.cdsenhaTextBox);
            this.Controls.Add(this.tbUsuarioBindingNavigator);
            this.Name = "fmrUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.fmrUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingNavigator)).EndInit();
            this.tbUsuarioBindingNavigator.ResumeLayout(false);
            this.tbUsuarioBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cadastro cadastro;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private cadastroTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private cadastroTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbUsuarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbUsuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cdusuarioTextBox;
        private System.Windows.Forms.TextBox nmusuarioTextBox;
        private System.Windows.Forms.TextBox sglevelTextBox;
        private System.Windows.Forms.TextBox nmloginTextBox;
        private System.Windows.Forms.TextBox cdsenhaTextBox;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnImprimir;
    }
}