﻿using System;
using Microsoft.Office.Tools.Ribbon;

namespace _1Math
{
    partial class Ribbon1Math : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1Math()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1Math));
            this.Tab1Math = this.Factory.CreateRibbonTab();
            this.GroupNet = this.Factory.CreateRibbonGroup();
            this.ButtonUrlCheck = this.Factory.CreateRibbonButton();
            this.buttonVideoLength = this.Factory.CreateRibbonButton();
            this.GroupDataCleaner = this.Factory.CreateRibbonGroup();
            this.ButtonAntiMerge = this.Factory.CreateRibbonButton();
            this.GroupText = this.Factory.CreateRibbonGroup();
            this.ButtonToEnglish = this.Factory.CreateRibbonSplitButton();
            this.ButtonTranslate = this.Factory.CreateRibbonButton();
            this.Tab1Math.SuspendLayout();
            this.GroupNet.SuspendLayout();
            this.GroupDataCleaner.SuspendLayout();
            this.GroupText.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab1Math
            // 
            this.Tab1Math.Groups.Add(this.GroupNet);
            this.Tab1Math.Groups.Add(this.GroupDataCleaner);
            this.Tab1Math.Groups.Add(this.GroupText);
            this.Tab1Math.Label = "1Math";
            this.Tab1Math.Name = "Tab1Math";
            this.Tab1Math.Position = this.Factory.RibbonPosition.AfterOfficeId("TabHome");
            // 
            // GroupNet
            // 
            this.GroupNet.Items.Add(this.ButtonUrlCheck);
            this.GroupNet.Items.Add(this.buttonVideoLength);
            this.GroupNet.Label = "网络";
            this.GroupNet.Name = "GroupNet";
            // 
            // ButtonUrlCheck
            // 
            this.ButtonUrlCheck.Image = ((System.Drawing.Image)(resources.GetObject("ButtonUrlCheck.Image")));
            this.ButtonUrlCheck.Label = "链接有效性";
            this.ButtonUrlCheck.Name = "ButtonUrlCheck";
            this.ButtonUrlCheck.ShowImage = true;
            this.ButtonUrlCheck.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonUrlCheck_ClickAsync);
            // 
            // buttonVideoLength
            // 
            this.buttonVideoLength.Image = ((System.Drawing.Image)(resources.GetObject("buttonVideoLength.Image")));
            this.buttonVideoLength.Label = "视频时长";
            this.buttonVideoLength.Name = "buttonVideoLength";
            this.buttonVideoLength.ShowImage = true;
            this.buttonVideoLength.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonVideoLength_ClickAsync);
            // 
            // GroupDataCleaner
            // 
            this.GroupDataCleaner.Items.Add(this.ButtonAntiMerge);
            this.GroupDataCleaner.Label = "数据清洗";
            this.GroupDataCleaner.Name = "GroupDataCleaner";
            // 
            // ButtonAntiMerge
            // 
            this.ButtonAntiMerge.Label = "取消合并";
            this.ButtonAntiMerge.Name = "ButtonAntiMerge";
            this.ButtonAntiMerge.ScreenTip = "取消合并单元格";
            this.ButtonAntiMerge.SuperTip = "批量取消选取中的合并单元格，并相对安全地自动填充。如果你只选中了一个单元格，那么会默认处理整个工作表。";
            this.ButtonAntiMerge.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonAntiMerge_ClickAsync);
            // 
            // GroupText
            // 
            this.GroupText.Items.Add(this.ButtonToEnglish);
            this.GroupText.Label = "文本处理";
            this.GroupText.Name = "GroupText";
            // 
            // ButtonToEnglish
            // 
            this.ButtonToEnglish.Items.Add(this.ButtonTranslate);
            this.ButtonToEnglish.Label = "中译英";
            this.ButtonToEnglish.Name = "ButtonToEnglish";
            this.ButtonToEnglish.ScreenTip = "批量中译英";
            this.ButtonToEnglish.SuperTip = "选中具备有效文本的连续单元格，译文将显示在选区右侧";
            this.ButtonToEnglish.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonToEnglish_ClickAsync);
            // 
            // ButtonTranslate
            // 
            this.ButtonTranslate.Label = "翻译...";
            this.ButtonTranslate.Name = "ButtonTranslate";
            this.ButtonTranslate.ScreenTip = "进行有更多详细设置的批量翻译";
            this.ButtonTranslate.ShowImage = true;
            this.ButtonTranslate.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ButtonTranslate_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.Tab1Math);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.Tab1Math.ResumeLayout(false);
            this.Tab1Math.PerformLayout();
            this.GroupNet.ResumeLayout(false);
            this.GroupNet.PerformLayout();
            this.GroupDataCleaner.ResumeLayout(false);
            this.GroupDataCleaner.PerformLayout();
            this.GroupText.ResumeLayout(false);
            this.GroupText.PerformLayout();
            this.ResumeLayout(false);

        }






        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Tab1Math;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupNet;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ButtonUrlCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonVideoLength;
        internal RibbonGroup GroupDataCleaner;
        internal RibbonButton ButtonAntiMerge;
        internal RibbonGroup GroupText;
        internal RibbonSplitButton ButtonToEnglish;
        internal RibbonButton ButtonTranslate;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1Math Ribbon1
        {
            get { return this.GetRibbon<Ribbon1Math>(); }
        }
    }
}