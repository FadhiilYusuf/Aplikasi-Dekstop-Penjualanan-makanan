
namespace TokoSinarTasik
{
    partial class Profit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profit));
            this.txt_id = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.DgProfit = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.btn_hapus = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_refresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_bulan = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_simpan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Cb_idjual = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Cb_idOp = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Cb_idbelanja = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tbl_xilang = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonButton4 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_dtUser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_laporan = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cb_idjual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cb_idOp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cb_idbelanja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_xilang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(355, 85);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(300, 27);
            this.txt_id.StateCommon.Border.Color1 = System.Drawing.Color.Gold;
            this.txt_id.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_id.StateCommon.Border.Rounding = 5;
            this.txt_id.TabIndex = 43;
            // 
            // DgProfit
            // 
            this.DgProfit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProfit.Location = new System.Drawing.Point(203, 335);
            this.DgProfit.Name = "DgProfit";
            this.DgProfit.Size = new System.Drawing.Size(573, 154);
            this.DgProfit.StateCommon.Background.Color1 = System.Drawing.Color.WhiteSmoke;
            this.DgProfit.StateCommon.Background.Color2 = System.Drawing.Color.WhiteSmoke;
            this.DgProfit.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DgProfit.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.MistyRose;
            this.DgProfit.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.MistyRose;
            this.DgProfit.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.MistyRose;
            this.DgProfit.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.MistyRose;
            this.DgProfit.TabIndex = 41;
            this.DgProfit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgProfit_CellContentClick);
            this.DgProfit.Click += new System.EventHandler(this.DgProfit_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(457, 256);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(96, 26);
            this.btn_hapus.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.btn_hapus.StateCommon.Back.Color2 = System.Drawing.Color.Red;
            this.btn_hapus.StateCommon.Border.Color1 = System.Drawing.Color.Red;
            this.btn_hapus.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.btn_hapus.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_hapus.StateCommon.Border.Rounding = 5;
            this.btn_hapus.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_hapus.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_hapus.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_hapus.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_hapus.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_hapus.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_hapus.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_hapus.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_hapus.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_hapus.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btn_hapus.StateNormal.Back.Color2 = System.Drawing.Color.Red;
            this.btn_hapus.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.btn_hapus.StateNormal.Border.Color2 = System.Drawing.Color.Red;
            this.btn_hapus.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_hapus.StateNormal.Border.Rounding = 5;
            this.btn_hapus.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_hapus.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_hapus.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_hapus.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_hapus.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_hapus.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_hapus.StatePressed.Border.Rounding = 5;
            this.btn_hapus.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_hapus.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_hapus.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_hapus.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_hapus.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_hapus.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_hapus.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_hapus.StateTracking.Border.Rounding = 5;
            this.btn_hapus.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_hapus.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_hapus.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.TabIndex = 40;
            this.btn_hapus.Values.Text = "hapus";
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(559, 256);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(96, 26);
            this.btn_refresh.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.btn_refresh.StateCommon.Back.Color2 = System.Drawing.Color.Red;
            this.btn_refresh.StateCommon.Border.Color1 = System.Drawing.Color.Red;
            this.btn_refresh.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.btn_refresh.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_refresh.StateCommon.Border.Rounding = 5;
            this.btn_refresh.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_refresh.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_refresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_refresh.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_refresh.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_refresh.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_refresh.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_refresh.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_refresh.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_refresh.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btn_refresh.StateNormal.Back.Color2 = System.Drawing.Color.Red;
            this.btn_refresh.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.btn_refresh.StateNormal.Border.Color2 = System.Drawing.Color.Red;
            this.btn_refresh.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_refresh.StateNormal.Border.Rounding = 5;
            this.btn_refresh.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_refresh.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refresh.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refresh.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refresh.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refresh.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_refresh.StatePressed.Border.Rounding = 5;
            this.btn_refresh.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_refresh.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_refresh.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refresh.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refresh.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refresh.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_refresh.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_refresh.StateTracking.Border.Rounding = 5;
            this.btn_refresh.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_refresh.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_refresh.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.TabIndex = 39;
            this.btn_refresh.Values.Text = "bersih";
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_bulan
            // 
            this.txt_bulan.Location = new System.Drawing.Point(355, 118);
            this.txt_bulan.Name = "txt_bulan";
            this.txt_bulan.Size = new System.Drawing.Size(300, 27);
            this.txt_bulan.StateCommon.Border.Color1 = System.Drawing.Color.Gold;
            this.txt_bulan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_bulan.StateCommon.Border.Rounding = 5;
            this.txt_bulan.TabIndex = 36;
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(355, 256);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(96, 26);
            this.btn_simpan.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.btn_simpan.StateCommon.Back.Color2 = System.Drawing.Color.Red;
            this.btn_simpan.StateCommon.Border.Color1 = System.Drawing.Color.Red;
            this.btn_simpan.StateCommon.Border.Color2 = System.Drawing.Color.Red;
            this.btn_simpan.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_simpan.StateCommon.Border.Rounding = 5;
            this.btn_simpan.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_simpan.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_simpan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_simpan.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_simpan.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_simpan.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_simpan.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_simpan.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_simpan.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_simpan.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btn_simpan.StateNormal.Back.Color2 = System.Drawing.Color.Red;
            this.btn_simpan.StateNormal.Border.Color1 = System.Drawing.Color.Red;
            this.btn_simpan.StateNormal.Border.Color2 = System.Drawing.Color.Red;
            this.btn_simpan.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_simpan.StateNormal.Border.Rounding = 5;
            this.btn_simpan.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_simpan.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_simpan.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_simpan.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_simpan.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_simpan.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_simpan.StatePressed.Border.Rounding = 5;
            this.btn_simpan.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_simpan.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_simpan.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_simpan.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_simpan.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_simpan.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_simpan.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_simpan.StateTracking.Border.Rounding = 5;
            this.btn_simpan.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_simpan.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_simpan.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan.TabIndex = 35;
            this.btn_simpan.Values.Text = "Simpan";
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // Cb_idjual
            // 
            this.Cb_idjual.DropDownWidth = 296;
            this.Cb_idjual.Location = new System.Drawing.Point(355, 151);
            this.Cb_idjual.Name = "Cb_idjual";
            this.Cb_idjual.Size = new System.Drawing.Size(300, 25);
            this.Cb_idjual.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.Cb_idjual.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Red;
            this.Cb_idjual.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Red;
            this.Cb_idjual.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cb_idjual.StateCommon.ComboBox.Border.Rounding = 5;
            this.Cb_idjual.StateCommon.DropBack.Color1 = System.Drawing.Color.Gold;
            this.Cb_idjual.StateCommon.DropBack.Color2 = System.Drawing.Color.Gold;
            this.Cb_idjual.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.Cb_idjual.StateCommon.Item.Back.Color2 = System.Drawing.Color.Snow;
            this.Cb_idjual.TabIndex = 44;
            // 
            // Cb_idOp
            // 
            this.Cb_idOp.DropDownWidth = 167;
            this.Cb_idOp.Location = new System.Drawing.Point(355, 182);
            this.Cb_idOp.Name = "Cb_idOp";
            this.Cb_idOp.Size = new System.Drawing.Size(300, 25);
            this.Cb_idOp.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.Cb_idOp.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Red;
            this.Cb_idOp.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Red;
            this.Cb_idOp.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cb_idOp.StateCommon.ComboBox.Border.Rounding = 5;
            this.Cb_idOp.StateCommon.DropBack.Color1 = System.Drawing.Color.Gold;
            this.Cb_idOp.StateCommon.DropBack.Color2 = System.Drawing.Color.Gold;
            this.Cb_idOp.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.Cb_idOp.StateCommon.Item.Back.Color2 = System.Drawing.Color.Snow;
            this.Cb_idOp.TabIndex = 45;
            // 
            // Cb_idbelanja
            // 
            this.Cb_idbelanja.DropDownWidth = 167;
            this.Cb_idbelanja.Location = new System.Drawing.Point(355, 213);
            this.Cb_idbelanja.Name = "Cb_idbelanja";
            this.Cb_idbelanja.Size = new System.Drawing.Size(300, 25);
            this.Cb_idbelanja.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.Cb_idbelanja.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Red;
            this.Cb_idbelanja.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Red;
            this.Cb_idbelanja.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Cb_idbelanja.StateCommon.ComboBox.Border.Rounding = 5;
            this.Cb_idbelanja.StateCommon.DropBack.Color1 = System.Drawing.Color.Gold;
            this.Cb_idbelanja.StateCommon.DropBack.Color2 = System.Drawing.Color.Gold;
            this.Cb_idbelanja.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.Cb_idbelanja.StateCommon.Item.Back.Color2 = System.Drawing.Color.Snow;
            this.Cb_idbelanja.TabIndex = 46;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(203, 85);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(27, 26);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 49;
            this.kryptonLabel1.Values.Text = "Id ";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(203, 149);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(128, 26);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 50;
            this.kryptonLabel2.Values.Text = "Total Penjualan";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(203, 118);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(54, 26);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 51;
            this.kryptonLabel3.Values.Text = "Bulan";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(203, 181);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(147, 26);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 52;
            this.kryptonLabel4.Values.Text = "Biaya Operasional";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(203, 213);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(109, 26);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 53;
            this.kryptonLabel5.Values.Text = "Total Belanja";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(477, 53);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(53, 26);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 54;
            this.kryptonLabel6.Values.Text = "Profit\r\n";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.tbl_xilang);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(800, 33);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.Gold;
            this.kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.Gold;
            this.kryptonPanel2.TabIndex = 77;
            // 
            // tbl_xilang
            // 
            this.tbl_xilang.Location = new System.Drawing.Point(751, 3);
            this.tbl_xilang.Name = "tbl_xilang";
            this.tbl_xilang.Size = new System.Drawing.Size(25, 22);
            this.tbl_xilang.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.tbl_xilang.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.tbl_xilang.StateCommon.Image = ((System.Drawing.Image)(resources.GetObject("tbl_xilang.StateCommon.Image")));
            this.tbl_xilang.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.tbl_xilang.StateNormal.Color1 = System.Drawing.Color.Transparent;
            this.tbl_xilang.StateNormal.Color2 = System.Drawing.Color.Transparent;
            this.tbl_xilang.TabIndex = 5;
            this.tbl_xilang.Click += new System.EventHandler(this.tbl_xilang_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btn_laporan);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Controls.Add(this.kryptonButton4);
            this.kryptonPanel1.Controls.Add(this.kryptonButton3);
            this.kryptonPanel1.Controls.Add(this.kryptonButton2);
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.btn_dtUser);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 33);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(178, 527);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Red;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.Red;
            this.kryptonPanel1.TabIndex = 78;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 350);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(20, 41);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel4.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonPanel4.TabIndex = 7;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Location = new System.Drawing.Point(21, 3);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(131, 112);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel3.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPanel3.StateCommon.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPanel3.StateCommon.Image")));
            this.kryptonPanel3.StateCommon.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.Stretch;
            this.kryptonPanel3.TabIndex = 5;
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(-3, 350);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(181, 41);
            this.kryptonButton4.StateCommon.Back.Color1 = System.Drawing.Color.Gold;
            this.kryptonButton4.StateCommon.Back.Color2 = System.Drawing.Color.Gold;
            this.kryptonButton4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.TabIndex = 4;
            this.kryptonButton4.Values.Text = "Profit";
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Location = new System.Drawing.Point(-6, 289);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.Size = new System.Drawing.Size(184, 41);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.Gold;
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.Gold;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.TabIndex = 3;
            this.kryptonButton3.Values.Text = "Data Belanja";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(-6, 232);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(184, 41);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.Gold;
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.Gold;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 2;
            this.kryptonButton2.Values.Text = "Biaya Operasional";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(-3, 176);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(181, 41);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.Gold;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.Gold;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 1;
            this.kryptonButton1.Values.Text = "Data Penjualan";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // btn_dtUser
            // 
            this.btn_dtUser.Location = new System.Drawing.Point(-3, 118);
            this.btn_dtUser.Name = "btn_dtUser";
            this.btn_dtUser.Size = new System.Drawing.Size(181, 41);
            this.btn_dtUser.StateCommon.Back.Color1 = System.Drawing.Color.Gold;
            this.btn_dtUser.StateCommon.Back.Color2 = System.Drawing.Color.Gold;
            this.btn_dtUser.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dtUser.TabIndex = 0;
            this.btn_dtUser.Values.Text = "Data User";
            this.btn_dtUser.Click += new System.EventHandler(this.btn_dtUser_Click);
            // 
            // btn_laporan
            // 
            this.btn_laporan.Location = new System.Drawing.Point(-3, 409);
            this.btn_laporan.Name = "btn_laporan";
            this.btn_laporan.Size = new System.Drawing.Size(181, 41);
            this.btn_laporan.StateCommon.Back.Color1 = System.Drawing.Color.Gold;
            this.btn_laporan.StateCommon.Back.Color2 = System.Drawing.Color.Gold;
            this.btn_laporan.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laporan.TabIndex = 79;
            this.btn_laporan.Values.Text = "Laporan";
            this.btn_laporan.Click += new System.EventHandler(this.btn_laporan_Click);
            // 
            // Profit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.Cb_idbelanja);
            this.Controls.Add(this.Cb_idOp);
            this.Controls.Add(this.Cb_idjual);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.DgProfit);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txt_bulan);
            this.Controls.Add(this.btn_simpan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Header.Back.Color1 = System.Drawing.Color.Gold;
            this.StateActive.Header.Back.Color2 = System.Drawing.Color.Gold;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 5;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.Gold;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.Gold;
            this.Text = "Profit";
            this.Load += new System.EventHandler(this.Profit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cb_idjual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cb_idOp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cb_idbelanja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_xilang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_id;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DgProfit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_hapus;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_refresh;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_simpan;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Cb_idjual;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Cb_idOp;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Cb_idbelanja;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_bulan;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel tbl_xilang;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_dtUser;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_laporan;
    }
}