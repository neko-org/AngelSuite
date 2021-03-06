/*
    Copyright � 2009, Aion-Radar.com
    All rights reserved.
    http://www.aion-radar.com


    This file is part of Aion Radar.

    Aion Radar is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Aion Radar is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Aion Radar.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace AngelSuite
{
    partial class Radar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Radar));
            this.picRadar = new System.Windows.Forms.PictureBox();
            this.tmrRadarUpdate = new System.Windows.Forms.Timer(this.components);
            this.menuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playershostileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersgroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.nPCsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCspeacefulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCshostileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCshostilelowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCsdeadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCsotherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.gatherableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gatherableairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.objectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorsShopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.compassModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCrosshairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSelfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDescriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLevelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLegionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHealthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUndergroundTargetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyDisplayRadarWhenAionIsTheActiveApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.useHighestQualityRenderingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classIconsForPlayersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.tmrheart = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picRadar)).BeginInit();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // picRadar
            // 
            this.picRadar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picRadar.BackColor = System.Drawing.Color.PapayaWhip;
            this.picRadar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRadar.Location = new System.Drawing.Point(1, 1);
            this.picRadar.Margin = new System.Windows.Forms.Padding(0);
            this.picRadar.Name = "picRadar";
            this.picRadar.Size = new System.Drawing.Size(498, 498);
            this.picRadar.TabIndex = 1;
            this.picRadar.TabStop = false;
            this.picRadar.Click += new System.EventHandler(this.picRadar_Click);
            // 
            // tmrRadarUpdate
            // 
            this.tmrRadarUpdate.Enabled = true;
            this.tmrRadarUpdate.Tick += new System.EventHandler(this.tmrRadarUpdate_Tick);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersToolStripMenuItem,
            this.playershostileToolStripMenuItem,
            this.playersgroupToolStripMenuItem,
            this.toolStripMenuItem3,
            this.nPCsToolStripMenuItem,
            this.nPCspeacefulToolStripMenuItem,
            this.nPCshostileToolStripMenuItem,
            this.nPCshostilelowToolStripMenuItem,
            this.nPCsdeadToolStripMenuItem,
            this.nPCsotherToolStripMenuItem,
            this.toolStripMenuItem4,
            this.gatherableToolStripMenuItem,
            this.gatherableairToolStripMenuItem,
            this.toolStripMenuItem5,
            this.objectsToolStripMenuItem,
            this.vendorsShopsToolStripMenuItem,
            this.landmarksToolStripMenuItem,
            this.toolStripMenuItem7,
            this.compassModeToolStripMenuItem,
            this.toolStripMenuItem6,
            this.zoomToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(174, 464);
            this.menuMain.Text = "Pete\'s Aion Radar";
            this.menuMain.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.menuMain_Closing);
            this.menuMain.Opening += new System.ComponentModel.CancelEventHandler(this.menuMain_Opening);
            this.menuMain.LayoutCompleted += new System.EventHandler(this.menuMain_LayoutCompleted);
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.CheckOnClick = true;
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.playersToolStripMenuItem.Text = "&Players";
            // 
            // playershostileToolStripMenuItem
            // 
            this.playershostileToolStripMenuItem.Checked = true;
            this.playershostileToolStripMenuItem.CheckOnClick = true;
            this.playershostileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.playershostileToolStripMenuItem.Name = "playershostileToolStripMenuItem";
            this.playershostileToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.playershostileToolStripMenuItem.Text = "Players (hostile)";
            // 
            // playersgroupToolStripMenuItem
            // 
            this.playersgroupToolStripMenuItem.Checked = true;
            this.playersgroupToolStripMenuItem.CheckOnClick = true;
            this.playersgroupToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.playersgroupToolStripMenuItem.Name = "playersgroupToolStripMenuItem";
            this.playersgroupToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.playersgroupToolStripMenuItem.Text = "Players (group)";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(170, 6);
            // 
            // nPCsToolStripMenuItem
            // 
            this.nPCsToolStripMenuItem.CheckOnClick = true;
            this.nPCsToolStripMenuItem.Name = "nPCsToolStripMenuItem";
            this.nPCsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nPCsToolStripMenuItem.Text = "NPCs";
            // 
            // nPCspeacefulToolStripMenuItem
            // 
            this.nPCspeacefulToolStripMenuItem.CheckOnClick = true;
            this.nPCspeacefulToolStripMenuItem.Name = "nPCspeacefulToolStripMenuItem";
            this.nPCspeacefulToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nPCspeacefulToolStripMenuItem.Text = "&NPCs (peaceful)";
            // 
            // nPCshostileToolStripMenuItem
            // 
            this.nPCshostileToolStripMenuItem.Checked = true;
            this.nPCshostileToolStripMenuItem.CheckOnClick = true;
            this.nPCshostileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nPCshostileToolStripMenuItem.Name = "nPCshostileToolStripMenuItem";
            this.nPCshostileToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nPCshostileToolStripMenuItem.Text = "NPCs (hostile)";
            // 
            // nPCshostilelowToolStripMenuItem
            // 
            this.nPCshostilelowToolStripMenuItem.CheckOnClick = true;
            this.nPCshostilelowToolStripMenuItem.Name = "nPCshostilelowToolStripMenuItem";
            this.nPCshostilelowToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nPCshostilelowToolStripMenuItem.Text = "NPCs (hostile/low)";
            // 
            // nPCsdeadToolStripMenuItem
            // 
            this.nPCsdeadToolStripMenuItem.Checked = true;
            this.nPCsdeadToolStripMenuItem.CheckOnClick = true;
            this.nPCsdeadToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nPCsdeadToolStripMenuItem.Name = "nPCsdeadToolStripMenuItem";
            this.nPCsdeadToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nPCsdeadToolStripMenuItem.Text = "NPCs (dead)";
            // 
            // nPCsotherToolStripMenuItem
            // 
            this.nPCsotherToolStripMenuItem.Checked = true;
            this.nPCsotherToolStripMenuItem.CheckOnClick = true;
            this.nPCsotherToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nPCsotherToolStripMenuItem.Name = "nPCsotherToolStripMenuItem";
            this.nPCsotherToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nPCsotherToolStripMenuItem.Text = "NPCs (other)";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(170, 6);
            // 
            // gatherableToolStripMenuItem
            // 
            this.gatherableToolStripMenuItem.Checked = true;
            this.gatherableToolStripMenuItem.CheckOnClick = true;
            this.gatherableToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gatherableToolStripMenuItem.Name = "gatherableToolStripMenuItem";
            this.gatherableToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gatherableToolStripMenuItem.Text = "Gatherable";
            // 
            // gatherableairToolStripMenuItem
            // 
            this.gatherableairToolStripMenuItem.Checked = true;
            this.gatherableairToolStripMenuItem.CheckOnClick = true;
            this.gatherableairToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gatherableairToolStripMenuItem.Name = "gatherableairToolStripMenuItem";
            this.gatherableairToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.gatherableairToolStripMenuItem.Text = "Gatherable (air)";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(170, 6);
            // 
            // objectsToolStripMenuItem
            // 
            this.objectsToolStripMenuItem.Checked = true;
            this.objectsToolStripMenuItem.CheckOnClick = true;
            this.objectsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.objectsToolStripMenuItem.Name = "objectsToolStripMenuItem";
            this.objectsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.objectsToolStripMenuItem.Text = "&Objects";
            // 
            // vendorsShopsToolStripMenuItem
            // 
            this.vendorsShopsToolStripMenuItem.Checked = true;
            this.vendorsShopsToolStripMenuItem.CheckOnClick = true;
            this.vendorsShopsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vendorsShopsToolStripMenuItem.Name = "vendorsShopsToolStripMenuItem";
            this.vendorsShopsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.vendorsShopsToolStripMenuItem.Text = "&Vendors/Shops";
            // 
            // landmarksToolStripMenuItem
            // 
            this.landmarksToolStripMenuItem.Checked = true;
            this.landmarksToolStripMenuItem.CheckOnClick = true;
            this.landmarksToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.landmarksToolStripMenuItem.Name = "landmarksToolStripMenuItem";
            this.landmarksToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.landmarksToolStripMenuItem.Text = "&Landmarks";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(170, 6);
            // 
            // compassModeToolStripMenuItem
            // 
            this.compassModeToolStripMenuItem.CheckOnClick = true;
            this.compassModeToolStripMenuItem.Name = "compassModeToolStripMenuItem";
            this.compassModeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.compassModeToolStripMenuItem.Text = "Compass mode";
            this.compassModeToolStripMenuItem.Click += new System.EventHandler(this.compassModeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(170, 6);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem13,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.zoomToolStripMenuItem.Text = "&Zoom";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Checked = true;
            this.toolStripMenuItem9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem9.Text = "100%";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem13.Text = "150%";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem13_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem10.Text = "200%";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem11.Text = "300%";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem11_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem12.Text = "400%";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem12_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCrosshairToolStripMenuItem,
            this.showSelfToolStripMenuItem,
            this.showDescriptionsToolStripMenuItem,
            this.showLevelsToolStripMenuItem,
            this.showLegionsToolStripMenuItem,
            this.showHealthToolStripMenuItem,
            this.showUndergroundTargetsToolStripMenuItem,
            this.onlyDisplayRadarWhenAionIsTheActiveApplicationToolStripMenuItem,
            this.useHighestQualityRenderingToolStripMenuItem,
            this.classIconsForPlayersToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // showCrosshairToolStripMenuItem
            // 
            this.showCrosshairToolStripMenuItem.Checked = true;
            this.showCrosshairToolStripMenuItem.CheckOnClick = true;
            this.showCrosshairToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCrosshairToolStripMenuItem.Name = "showCrosshairToolStripMenuItem";
            this.showCrosshairToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.showCrosshairToolStripMenuItem.Text = "Show crosshair";
            // 
            // showSelfToolStripMenuItem
            // 
            this.showSelfToolStripMenuItem.CheckOnClick = true;
            this.showSelfToolStripMenuItem.Name = "showSelfToolStripMenuItem";
            this.showSelfToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.showSelfToolStripMenuItem.Text = "Show self";
            // 
            // showDescriptionsToolStripMenuItem
            // 
            this.showDescriptionsToolStripMenuItem.Checked = true;
            this.showDescriptionsToolStripMenuItem.CheckOnClick = true;
            this.showDescriptionsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showDescriptionsToolStripMenuItem.Name = "showDescriptionsToolStripMenuItem";
            this.showDescriptionsToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.showDescriptionsToolStripMenuItem.Text = "Show descriptions";
            // 
            // showLevelsToolStripMenuItem
            // 
            this.showLevelsToolStripMenuItem.Checked = true;
            this.showLevelsToolStripMenuItem.CheckOnClick = true;
            this.showLevelsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showLevelsToolStripMenuItem.Name = "showLevelsToolStripMenuItem";
            this.showLevelsToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.showLevelsToolStripMenuItem.Text = "Show levels";
            // 
            // showLegionsToolStripMenuItem
            // 
            this.showLegionsToolStripMenuItem.CheckOnClick = true;
            this.showLegionsToolStripMenuItem.Name = "showLegionsToolStripMenuItem";
            this.showLegionsToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.showLegionsToolStripMenuItem.Text = "Show legions";
            // 
            // showHealthToolStripMenuItem
            // 
            this.showHealthToolStripMenuItem.Checked = true;
            this.showHealthToolStripMenuItem.CheckOnClick = true;
            this.showHealthToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showHealthToolStripMenuItem.Name = "showHealthToolStripMenuItem";
            this.showHealthToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.showHealthToolStripMenuItem.Text = "Show health";
            // 
            // showUndergroundTargetsToolStripMenuItem
            // 
            this.showUndergroundTargetsToolStripMenuItem.Checked = true;
            this.showUndergroundTargetsToolStripMenuItem.CheckOnClick = true;
            this.showUndergroundTargetsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showUndergroundTargetsToolStripMenuItem.Name = "showUndergroundTargetsToolStripMenuItem";
            this.showUndergroundTargetsToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.showUndergroundTargetsToolStripMenuItem.Text = "Show underground targets";
            // 
            // onlyDisplayRadarWhenAionIsTheActiveApplicationToolStripMenuItem
            // 
            this.onlyDisplayRadarWhenAionIsTheActiveApplicationToolStripMenuItem.Checked = true;
            this.onlyDisplayRadarWhenAionIsTheActiveApplicationToolStripMenuItem.CheckOnClick = true;
            this.onlyDisplayRadarWhenAionIsTheActiveApplicationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.onlyDisplayRadarWhenAionIsTheActiveApplicationToolStripMenuItem.Name = "onlyDisplayRadarWhenAionIsTheActiveApplicationToolStripMenuItem";
            this.onlyDisplayRadarWhenAionIsTheActiveApplicationToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.onlyDisplayRadarWhenAionIsTheActiveApplicationToolStripMenuItem.Text = "Only display radar when Aion is the active application";
            // 
            // useHighestQualityRenderingToolStripMenuItem
            // 
            this.useHighestQualityRenderingToolStripMenuItem.CheckOnClick = true;
            this.useHighestQualityRenderingToolStripMenuItem.Name = "useHighestQualityRenderingToolStripMenuItem";
            this.useHighestQualityRenderingToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.useHighestQualityRenderingToolStripMenuItem.Text = "Use highest quality rendering";
            // 
            // classIconsForPlayersToolStripMenuItem
            // 
            this.classIconsForPlayersToolStripMenuItem.Checked = true;
            this.classIconsForPlayersToolStripMenuItem.CheckOnClick = true;
            this.classIconsForPlayersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.classIconsForPlayersToolStripMenuItem.Name = "classIconsForPlayersToolStripMenuItem";
            this.classIconsForPlayersToolStripMenuItem.Size = new System.Drawing.Size(356, 22);
            this.classIconsForPlayersToolStripMenuItem.Text = "Class icons for players (not for compass mode)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(170, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // iconSystemTray
            // 
            this.iconSystemTray.ContextMenuStrip = this.menuMain;
            this.iconSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("iconSystemTray.Icon")));
            this.iconSystemTray.Text = "Pete\'s Aion Radar";
            this.iconSystemTray.Visible = true;
            // 
            // tmrheart
            // 
            this.tmrheart.Interval = 60000;
            this.tmrheart.Tick += new System.EventHandler(this.tmrheart_Tick);
            // 
            // Radar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.picRadar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Radar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pete\'s Aion Radar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRadar)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRadar;
        private System.Windows.Forms.Timer tmrRadarUpdate;
        private System.Windows.Forms.ContextMenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon iconSystemTray;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem objectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorsShopsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem landmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPCspeacefulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPCshostileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPCsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPCsotherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playershostileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersgroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem nPCsdeadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPCshostilelowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatherableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gatherableairToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSelfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUndergroundTargetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLevelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLegionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHealthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCrosshairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyDisplayRadarWhenAionIsTheActiveApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem useHighestQualityRenderingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDescriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem compassModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classIconsForPlayersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.Timer tmrheart;
    }
}

