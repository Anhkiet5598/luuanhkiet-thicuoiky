/*
 * Created by SharpDevelop.
 * User: Anh Kiet
 * Date: 12/27/2018
 * Time: 8:37 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Orm._HTron
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pbDraw = new System.Windows.Forms.ToolStrip();
			this.Line = new System.Windows.Forms.ToolStripButton();
			this.HinhVuong = new System.Windows.Forms.ToolStripButton();
			this.HinhTron = new System.Windows.Forms.ToolStripButton();
			this.Save = new System.Windows.Forms.ToolStripButton();
			this.Load = new System.Windows.Forms.ToolStripButton();
			this.pbDraws = new System.Windows.Forms.PictureBox();
			this.pbDraw.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraws)).BeginInit();
			this.SuspendLayout();
			// 
			// pbDraw
			// 
			this.pbDraw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.Line,
									this.HinhVuong,
									this.HinhTron,
									this.Save,
									this.Load});
			this.pbDraw.Location = new System.Drawing.Point(0, 0);
			this.pbDraw.Name = "pbDraw";
			this.pbDraw.Size = new System.Drawing.Size(824, 38);
			this.pbDraw.TabIndex = 0;
			this.pbDraw.Text = "pbDraw";
			// 
			// Line
			// 
			this.Line.CheckOnClick = true;
			this.Line.ForeColor = System.Drawing.Color.DarkRed;
			this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
			this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Line.Name = "Line";
			this.Line.Size = new System.Drawing.Size(33, 35);
			this.Line.Text = "Line";
			this.Line.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// HinhVuong
			// 
			this.HinhVuong.CheckOnClick = true;
			this.HinhVuong.Image = ((System.Drawing.Image)(resources.GetObject("HinhVuong.Image")));
			this.HinhVuong.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.HinhVuong.Name = "HinhVuong";
			this.HinhVuong.Size = new System.Drawing.Size(76, 35);
			this.HinhVuong.Text = "Tam Giác";
			// 
			// HinhTron
			// 
			this.HinhTron.CheckOnClick = true;
			this.HinhTron.Image = ((System.Drawing.Image)(resources.GetObject("HinhTron.Image")));
			this.HinhTron.ImageTransparentColor = System.Drawing.Color.Crimson;
			this.HinhTron.Name = "HinhTron";
			this.HinhTron.Size = new System.Drawing.Size(80, 35);
			this.HinhTron.Text = "Hình Thoi";
			// 
			// Save
			// 
			this.Save.CheckOnClick = true;
			this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
			this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(23, 35);
			this.Save.Text = "Save";
			this.Save.Click += new System.EventHandler(this.SaveClick);
			// 
			// Load
			// 
			this.Load.CheckOnClick = true;
			this.Load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.Load.Image = ((System.Drawing.Image)(resources.GetObject("Load.Image")));
			this.Load.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Load.Name = "Load";
			this.Load.Size = new System.Drawing.Size(23, 35);
			this.Load.Text = "Load";
			this.Load.Click += new System.EventHandler(this.LoadClick);
			// 
			// pbDraws
			// 
			this.pbDraws.BackColor = System.Drawing.Color.White;
			this.pbDraws.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbDraws.Location = new System.Drawing.Point(0, 38);
			this.pbDraws.Name = "pbDraws";
			this.pbDraws.Size = new System.Drawing.Size(824, 288);
			this.pbDraws.TabIndex = 1;
			this.pbDraws.TabStop = false;
			this.pbDraws.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbDrawsMouseDown);
			this.pbDraws.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbDrawsMouseMove);
			this.pbDraws.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbDrawsMouseUp);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 326);
			this.Controls.Add(this.pbDraws);
			this.Controls.Add(this.pbDraw);
			this.Name = "MainForm";
			this.Text = "Orm. HTron";
			this.pbDraw.ResumeLayout(false);
			this.pbDraw.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDraws)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton Load;
		private System.Windows.Forms.ToolStripButton Save;
		private System.Windows.Forms.PictureBox pbDraws;
		private System.Windows.Forms.ToolStripButton HinhTron;
		private System.Windows.Forms.ToolStripButton HinhVuong;
		private System.Windows.Forms.ToolStrip pbDraw;
		private System.Windows.Forms.ToolStripButton Line;
		
	}
}
