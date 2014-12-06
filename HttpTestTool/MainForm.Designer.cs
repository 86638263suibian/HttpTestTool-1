namespace HttpTestTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layout = new DevExpress.XtraLayout.LayoutControl();
            this.txtEdit_url = new DevExpress.XtraEditors.TextEdit();
            this.treeList_response = new DevExpress.XtraTreeList.TreeList();
            this.colData = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btn_send = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup_method = new DevExpress.XtraEditors.RadioGroup();
            this.txtEdit_data = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.send = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_url.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList_response)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_method.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_data.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.send)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.Controls.Add(this.txtEdit_url);
            this.layout.Controls.Add(this.treeList_response);
            this.layout.Controls.Add(this.btn_send);
            this.layout.Controls.Add(this.radioGroup_method);
            this.layout.Controls.Add(this.txtEdit_data);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(680, 238, 445, 450);
            this.layout.Root = this.layoutControlGroup1;
            this.layout.Size = new System.Drawing.Size(686, 415);
            this.layout.TabIndex = 0;
            this.layout.Text = "layoutControl1";
            // 
            // txtEdit_url
            // 
            this.txtEdit_url.Location = new System.Drawing.Point(64, 41);
            this.txtEdit_url.Name = "txtEdit_url";
            this.txtEdit_url.Size = new System.Drawing.Size(610, 20);
            this.txtEdit_url.StyleController = this.layout;
            this.txtEdit_url.TabIndex = 8;
            // 
            // treeList_response
            // 
            this.treeList_response.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colData});
            this.treeList_response.Location = new System.Drawing.Point(64, 147);
            this.treeList_response.Name = "treeList_response";
            this.treeList_response.OptionsBehavior.AutoChangeParent = false;
            this.treeList_response.OptionsBehavior.CopyToClipboardWithColumnHeaders = false;
            this.treeList_response.OptionsBehavior.ResizeNodes = false;
            this.treeList_response.OptionsBehavior.ShowToolTips = false;
            this.treeList_response.OptionsMenu.EnableFooterMenu = false;
            this.treeList_response.OptionsView.AllowHtmlDrawHeaders = true;
            this.treeList_response.OptionsView.ShowColumns = false;
            this.treeList_response.OptionsView.ShowFocusedFrame = false;
            this.treeList_response.OptionsView.ShowHorzLines = false;
            this.treeList_response.OptionsView.ShowIndicator = false;
            this.treeList_response.OptionsView.ShowVertLines = false;
            this.treeList_response.Size = new System.Drawing.Size(610, 256);
            this.treeList_response.TabIndex = 7;
            // 
            // colData
            // 
            this.colData.Caption = "JSON Data";
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.Visible = true;
            this.colData.VisibleIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(574, 12);
            this.btn_send.MaximumSize = new System.Drawing.Size(100, 25);
            this.btn_send.MinimumSize = new System.Drawing.Size(100, 25);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(100, 25);
            this.btn_send.StyleController = this.layout;
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Send";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // radioGroup_method
            // 
            this.radioGroup_method.EditValue = RestSharp.Method.GET;
            this.radioGroup_method.Location = new System.Drawing.Point(64, 12);
            this.radioGroup_method.Name = "radioGroup_method";
            this.radioGroup_method.Properties.AllowMouseWheel = false;
            this.radioGroup_method.Properties.Columns = 4;
            this.radioGroup_method.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(RestSharp.Method.GET, "GET"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(RestSharp.Method.POST, "POST"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(RestSharp.Method.PUT, "PUT"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(RestSharp.Method.DELETE, "DELETE")});
            this.radioGroup_method.Size = new System.Drawing.Size(506, 25);
            this.radioGroup_method.StyleController = this.layout;
            this.radioGroup_method.TabIndex = 4;
            // 
            // txtEdit_data
            // 
            this.txtEdit_data.Location = new System.Drawing.Point(64, 65);
            this.txtEdit_data.Name = "txtEdit_data";
            this.txtEdit_data.Size = new System.Drawing.Size(610, 73);
            this.txtEdit_data.StyleController = this.layout;
            this.txtEdit_data.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.send,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.splitterItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(686, 415);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.radioGroup_method;
            this.layoutControlItem1.CustomizationFormText = "method";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(562, 29);
            this.layoutControlItem1.Text = "method";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(49, 14);
            // 
            // send
            // 
            this.send.Control = this.btn_send;
            this.send.CustomizationFormText = "send";
            this.send.Location = new System.Drawing.Point(562, 0);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(104, 29);
            this.send.Text = "send";
            this.send.TextSize = new System.Drawing.Size(0, 0);
            this.send.TextToControlDistance = 0;
            this.send.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.BestFitWeight = 10;
            this.layoutControlItem3.Control = this.txtEdit_data;
            this.layoutControlItem3.CustomizationFormText = "data";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(666, 77);
            this.layoutControlItem3.Text = "data";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(49, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.BestFitWeight = 400;
            this.layoutControlItem4.Control = this.treeList_response;
            this.layoutControlItem4.CustomizationFormText = "response";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 135);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(666, 260);
            this.layoutControlItem4.Text = "response";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(49, 14);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(0, 130);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(666, 5);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtEdit_url;
            this.layoutControlItem2.CustomizationFormText = "url";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 29);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(666, 24);
            this.layoutControlItem2.Text = "url";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(49, 14);
            // 
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btn_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(686, 415);
            this.Controls.Add(this.layout);
            this.Name = "MainForm";
            this.Text = "SimpleHttpTestTool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
            this.layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_url.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList_response)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup_method.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_data.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.send)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layout;
        private DevExpress.XtraEditors.RadioGroup radioGroup_method;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraTreeList.TreeList treeList_response;
        private DevExpress.XtraEditors.SimpleButton btn_send;
        private DevExpress.XtraEditors.MemoEdit txtEdit_data;
        private DevExpress.XtraLayout.LayoutControlItem send;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraEditors.TextEdit txtEdit_url;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colData;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;

    }
}

