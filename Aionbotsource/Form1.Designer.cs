﻿using System;
using System.Diagnostics;


namespace AngelBot
{
    partial class Form1
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
            this.button1.Visible = true;
            this.btnstop.Visible = false;
            timer1.Stop();
            //timer2.Stop();
            tmrtabby.Stop();
            tmrstuck.Stop();
            tmrpot.Stop();
            tmrheal.Stop();
            Environment.Exit(1);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playerName = new System.Windows.Forms.Label();
            this.playerExp = new System.Windows.Forms.Label();
            this.playerProg = new System.Windows.Forms.ProgressBar();
            this.expHRLabel = new System.Windows.Forms.Label();
            this.kinahLabel = new System.Windows.Forms.Label();
            this.resetAll = new System.Windows.Forms.Button();
            this.elapsedLabel = new System.Windows.Forms.Label();
            this.killLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.healthbar = new System.Windows.Forms.ProgressBar();
            this.manabar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.lblxpgain = new System.Windows.Forms.Label();
            this.lbltarget = new System.Windows.Forms.Label();
            this.tarhealth = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.btnignore = new System.Windows.Forms.Button();
            this.btnuningnore = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keypressWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waypoint = new System.Windows.Forms.ToolStripMenuItem();
            this.clearWaypointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWaypointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWaypointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waypointEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblstatus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnstop = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnwaypoint = new System.Windows.Forms.Button();
            this.btnautoway = new System.Windows.Forms.Button();
            this.listkeypress = new System.Windows.Forms.ListBox();
            this.lbldistance = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.lblrot = new System.Windows.Forms.Label();
            this.tmrstuck = new System.Windows.Forms.Timer(this.components);
            this.tmrpot = new System.Windows.Forms.Timer(this.components);
            this.tmrheal = new System.Windows.Forms.Timer(this.components);
            this.lblwprange = new System.Windows.Forms.Label();
            this.tmrtabby = new System.Windows.Forms.Timer(this.components);
            this.lbltimelvl = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tmrunstuck = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tmrshutoff = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerName.Location = new System.Drawing.Point(0, 24);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(62, 24);
            this.playerName.TabIndex = 0;
            this.playerName.Text = "Player";
            // 
            // playerExp
            // 
            this.playerExp.AutoSize = true;
            this.playerExp.Location = new System.Drawing.Point(1, 255);
            this.playerExp.Name = "playerExp";
            this.playerExp.Size = new System.Drawing.Size(28, 13);
            this.playerExp.TabIndex = 2;
            this.playerExp.Text = "Exp:";
            // 
            // playerProg
            // 
            this.playerProg.Location = new System.Drawing.Point(-3, 280);
            this.playerProg.Name = "playerProg";
            this.playerProg.Size = new System.Drawing.Size(411, 15);
            this.playerProg.TabIndex = 3;
            // 
            // expHRLabel
            // 
            this.expHRLabel.AutoSize = true;
            this.expHRLabel.Location = new System.Drawing.Point(90, 255);
            this.expHRLabel.Name = "expHRLabel";
            this.expHRLabel.Size = new System.Drawing.Size(39, 13);
            this.expHRLabel.TabIndex = 4;
            this.expHRLabel.Text = "ExpHr:";
            // 
            // kinahLabel
            // 
            this.kinahLabel.AutoSize = true;
            this.kinahLabel.Location = new System.Drawing.Point(309, 63);
            this.kinahLabel.Name = "kinahLabel";
            this.kinahLabel.Size = new System.Drawing.Size(37, 13);
            this.kinahLabel.TabIndex = 5;
            this.kinahLabel.Text = "Kinah:";
            // 
            // resetAll
            // 
            this.resetAll.Location = new System.Drawing.Point(244, 24);
            this.resetAll.Name = "resetAll";
            this.resetAll.Size = new System.Drawing.Size(75, 20);
            this.resetAll.TabIndex = 6;
            this.resetAll.Text = "Reset";
            this.resetAll.UseVisualStyleBackColor = true;
            this.resetAll.Click += new System.EventHandler(this.resetAll_Click);
            // 
            // elapsedLabel
            // 
            this.elapsedLabel.AutoSize = true;
            this.elapsedLabel.Location = new System.Drawing.Point(329, 24);
            this.elapsedLabel.Name = "elapsedLabel";
            this.elapsedLabel.Size = new System.Drawing.Size(36, 13);
            this.elapsedLabel.TabIndex = 8;
            this.elapsedLabel.Text = "Timer:";
            // 
            // killLabel
            // 
            this.killLabel.AutoSize = true;
            this.killLabel.Location = new System.Drawing.Point(309, 76);
            this.killLabel.Name = "killLabel";
            this.killLabel.Size = new System.Drawing.Size(28, 13);
            this.killLabel.TabIndex = 9;
            this.killLabel.Text = "Kills:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Health";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mana";
            // 
            // healthbar
            // 
            this.healthbar.BackColor = System.Drawing.Color.Black;
            this.healthbar.ForeColor = System.Drawing.Color.Firebrick;
            this.healthbar.Location = new System.Drawing.Point(48, 50);
            this.healthbar.Name = "healthbar";
            this.healthbar.Size = new System.Drawing.Size(156, 22);
            this.healthbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.healthbar.TabIndex = 16;
            // 
            // manabar
            // 
            this.manabar.BackColor = System.Drawing.Color.Black;
            this.manabar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.manabar.Location = new System.Drawing.Point(48, 73);
            this.manabar.Name = "manabar";
            this.manabar.Size = new System.Drawing.Size(156, 22);
            this.manabar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.manabar.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblxpgain
            // 
            this.lblxpgain.AutoSize = true;
            this.lblxpgain.Location = new System.Drawing.Point(309, 90);
            this.lblxpgain.Name = "lblxpgain";
            this.lblxpgain.Size = new System.Drawing.Size(24, 13);
            this.lblxpgain.TabIndex = 19;
            this.lblxpgain.Text = "XP:";
            // 
            // lbltarget
            // 
            this.lbltarget.AutoSize = true;
            this.lbltarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltarget.Location = new System.Drawing.Point(0, 108);
            this.lbltarget.Name = "lbltarget";
            this.lbltarget.Size = new System.Drawing.Size(64, 24);
            this.lbltarget.TabIndex = 20;
            this.lbltarget.Text = "Target";
            // 
            // tarhealth
            // 
            this.tarhealth.BackColor = System.Drawing.Color.Black;
            this.tarhealth.ForeColor = System.Drawing.Color.Lime;
            this.tarhealth.Location = new System.Drawing.Point(48, 135);
            this.tarhealth.Name = "tarhealth";
            this.tarhealth.Size = new System.Drawing.Size(156, 22);
            this.tarhealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.tarhealth.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Health";
            // 
            // btnignore
            // 
            this.btnignore.Location = new System.Drawing.Point(216, 123);
            this.btnignore.Name = "btnignore";
            this.btnignore.Size = new System.Drawing.Size(76, 24);
            this.btnignore.TabIndex = 23;
            this.btnignore.Text = "Ignore NPC";
            this.btnignore.UseVisualStyleBackColor = true;
            this.btnignore.Click += new System.EventHandler(this.btnignore_Click);
            // 
            // btnuningnore
            // 
            this.btnuningnore.Location = new System.Drawing.Point(216, 153);
            this.btnuningnore.Name = "btnuningnore";
            this.btnuningnore.Size = new System.Drawing.Size(76, 24);
            this.btnuningnore.TabIndex = 24;
            this.btnuningnore.Text = "Unignore";
            this.btnuningnore.UseVisualStyleBackColor = true;
            this.btnuningnore.Click += new System.EventHandler(this.btnuningnore_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.waypointEditorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.keypressWindowToolStripMenuItem,
            this.waypoint,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // keypressWindowToolStripMenuItem
            // 
            this.keypressWindowToolStripMenuItem.Name = "keypressWindowToolStripMenuItem";
            this.keypressWindowToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.keypressWindowToolStripMenuItem.Text = "Keypress window";
            this.keypressWindowToolStripMenuItem.Click += new System.EventHandler(this.keypressWindowToolStripMenuItem_Click);
            // 
            // waypoint
            // 
            this.waypoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.waypoint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearWaypointsToolStripMenuItem,
            this.loadWaypointsToolStripMenuItem,
            this.saveWaypointsToolStripMenuItem});
            this.waypoint.Name = "waypoint";
            this.waypoint.Size = new System.Drawing.Size(157, 22);
            this.waypoint.Text = "Waypoints";
            // 
            // clearWaypointsToolStripMenuItem
            // 
            this.clearWaypointsToolStripMenuItem.Name = "clearWaypointsToolStripMenuItem";
            this.clearWaypointsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.clearWaypointsToolStripMenuItem.Text = "Clear Waypoints";
            this.clearWaypointsToolStripMenuItem.Click += new System.EventHandler(this.clearWaypointsToolStripMenuItem_Click);
            // 
            // loadWaypointsToolStripMenuItem
            // 
            this.loadWaypointsToolStripMenuItem.Name = "loadWaypointsToolStripMenuItem";
            this.loadWaypointsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.loadWaypointsToolStripMenuItem.Text = "Load Waypoints";
            this.loadWaypointsToolStripMenuItem.Click += new System.EventHandler(this.loadWaypointsToolStripMenuItem_Click);
            // 
            // saveWaypointsToolStripMenuItem
            // 
            this.saveWaypointsToolStripMenuItem.Name = "saveWaypointsToolStripMenuItem";
            this.saveWaypointsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveWaypointsToolStripMenuItem.Text = "Save Waypoints";
            this.saveWaypointsToolStripMenuItem.Click += new System.EventHandler(this.saveWaypointsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // waypointEditorToolStripMenuItem
            // 
            this.waypointEditorToolStripMenuItem.Name = "waypointEditorToolStripMenuItem";
            this.waypointEditorToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.waypointEditorToolStripMenuItem.Text = "Waypoint Editor";
            this.waypointEditorToolStripMenuItem.Click += new System.EventHandler(this.waypointEditorToolStripMenuItem_Click_1);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(9, 172);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(55, 15);
            this.lblstatus.TabIndex = 26;
            this.lblstatus.Text = "Status: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(309, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Stats";
            // 
            // btnstop
            // 
            this.btnstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.Location = new System.Drawing.Point(109, 214);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(98, 38);
            this.btnstop.TabIndex = 28;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Visible = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(300, 198);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 17);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Death Waypoints";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnwaypoint
            // 
            this.btnwaypoint.Location = new System.Drawing.Point(306, 221);
            this.btnwaypoint.Name = "btnwaypoint";
            this.btnwaypoint.Size = new System.Drawing.Size(90, 26);
            this.btnwaypoint.TabIndex = 30;
            this.btnwaypoint.Text = "Add Waypoint";
            this.btnwaypoint.UseVisualStyleBackColor = true;
            this.btnwaypoint.Click += new System.EventHandler(this.btnwaypoint_Click);
            // 
            // btnautoway
            // 
            this.btnautoway.Location = new System.Drawing.Point(306, 249);
            this.btnautoway.Name = "btnautoway";
            this.btnautoway.Size = new System.Drawing.Size(90, 25);
            this.btnautoway.TabIndex = 31;
            this.btnautoway.Text = "Auto Waypoints";
            this.btnautoway.UseVisualStyleBackColor = true;
            this.btnautoway.Click += new System.EventHandler(this.btnautoway_Click);
            // 
            // listkeypress
            // 
            this.listkeypress.FormattingEnabled = true;
            this.listkeypress.Location = new System.Drawing.Point(408, 31);
            this.listkeypress.Name = "listkeypress";
            this.listkeypress.Size = new System.Drawing.Size(145, 264);
            this.listkeypress.TabIndex = 32;
            // 
            // lbldistance
            // 
            this.lbldistance.AutoSize = true;
            this.lbldistance.Location = new System.Drawing.Point(45, 159);
            this.lbldistance.Name = "lbldistance";
            this.lbldistance.Size = new System.Drawing.Size(45, 13);
            this.lbldistance.TabIndex = 33;
            this.lbldistance.Text = "Range: ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // timer3
            // 
            this.timer3.Interval = 3000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // lblrot
            // 
            this.lblrot.AutoSize = true;
            this.lblrot.Location = new System.Drawing.Point(203, 98);
            this.lblrot.Name = "lblrot";
            this.lblrot.Size = new System.Drawing.Size(19, 13);
            this.lblrot.TabIndex = 35;
            this.lblrot.Text = "rot";
            // 
            // tmrstuck
            // 
            this.tmrstuck.Interval = 2000;
            this.tmrstuck.Tick += new System.EventHandler(this.tmrstuck_Tick_1);
            // 
            // tmrpot
            // 
            this.tmrpot.Interval = 30000;
            this.tmrpot.Tick += new System.EventHandler(this.tmrpot_Tick);
            // 
            // tmrheal
            // 
            this.tmrheal.Interval = 1000;
            this.tmrheal.Tick += new System.EventHandler(this.tmrheal_Tick_1);
            // 
            // lblwprange
            // 
            this.lblwprange.AutoSize = true;
            this.lblwprange.Location = new System.Drawing.Point(2, 98);
            this.lblwprange.Name = "lblwprange";
            this.lblwprange.Size = new System.Drawing.Size(60, 13);
            this.lblwprange.TabIndex = 36;
            this.lblwprange.Text = "WPRange:";
            // 
            // tmrtabby
            // 
            this.tmrtabby.Interval = 1000;
            this.tmrtabby.Tick += new System.EventHandler(this.tmrtabby_Tick_1);
            // 
            // lbltimelvl
            // 
            this.lbltimelvl.AutoSize = true;
            this.lbltimelvl.Location = new System.Drawing.Point(193, 255);
            this.lbltimelvl.Name = "lbltimelvl";
            this.lbltimelvl.Size = new System.Drawing.Size(48, 13);
            this.lbltimelvl.TabIndex = 37;
            this.lbltimelvl.Text = "Level In:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(4, 191);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 17);
            this.checkBox2.TabIndex = 38;
            this.checkBox2.Text = "Background Mode";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // tmrunstuck
            // 
            this.tmrunstuck.Interval = 300000;
            this.tmrunstuck.Tick += new System.EventHandler(this.tmrunstuck_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(450, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 261);
            this.textBox1.TabIndex = 40;
            this.textBox1.Visible = false;
            // 
            // tmrshutoff
            // 
            this.tmrshutoff.Interval = 1000;
            this.tmrshutoff.Tick += new System.EventHandler(this.tmrshutoff_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Inv:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Deaths:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(406, 295);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.lbltimelvl);
            this.Controls.Add(this.lblwprange);
            this.Controls.Add(this.lblrot);
            this.Controls.Add(this.lbldistance);
            this.Controls.Add(this.listkeypress);
            this.Controls.Add(this.btnautoway);
            this.Controls.Add(this.btnwaypoint);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btnuningnore);
            this.Controls.Add(this.btnignore);
            this.Controls.Add(this.tarhealth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbltarget);
            this.Controls.Add(this.lblxpgain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.manabar);
            this.Controls.Add(this.healthbar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.killLabel);
            this.Controls.Add(this.elapsedLabel);
            this.Controls.Add(this.resetAll);
            this.Controls.Add(this.kinahLabel);
            this.Controls.Add(this.expHRLabel);
            this.Controls.Add(this.playerProg);
            this.Controls.Add(this.playerExp);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = System.Diagnostics.Process.GetCurrentProcess().ProcessName.ToString();
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.Shown += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label playerExp;
        private System.Windows.Forms.ProgressBar playerProg;
        private System.Windows.Forms.Label expHRLabel;
        private System.Windows.Forms.Label kinahLabel;
        private System.Windows.Forms.Button resetAll;
        private System.Windows.Forms.Label elapsedLabel;
        private System.Windows.Forms.Label killLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar healthbar;
        private System.Windows.Forms.ProgressBar manabar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblxpgain;
        private System.Windows.Forms.Label lbltarget;
        private System.Windows.Forms.ProgressBar tarhealth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnignore;
        private System.Windows.Forms.Button btnuningnore;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keypressWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waypointEditorToolStripMenuItem;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnwaypoint;
        private System.Windows.Forms.Button btnautoway;
        private System.Windows.Forms.ListBox listkeypress;
        private System.Windows.Forms.Label lbldistance;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem waypoint;
        private System.Windows.Forms.ToolStripMenuItem clearWaypointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadWaypointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWaypointsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblrot;
        private System.Windows.Forms.Timer tmrstuck;
        private System.Windows.Forms.Timer tmrpot;
        private System.Windows.Forms.Timer tmrheal;
        public System.Windows.Forms.Timer tmrtabby;
        private System.Windows.Forms.Label lbltimelvl;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Timer tmrunstuck;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer tmrshutoff;
        public System.Windows.Forms.Label lblwprange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}

