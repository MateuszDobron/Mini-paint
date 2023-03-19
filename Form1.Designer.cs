namespace MiniPaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_load = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_brush = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_rectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_ellipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_trash = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_Thickness = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_Chosencolor = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_Chosencolor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_Language = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton_English = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Polish = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            resources.ApplyResources(this.Canvas, "Canvas");
            this.Canvas.Name = "Canvas";
            this.Canvas.TabStop = false;
            this.Canvas.SizeChanged += new System.EventHandler(this.resized_canvas);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_canvas);
            this.Canvas.MouseLeave += new System.EventHandler(this.mouseLeave_canvas);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_canvas);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_canvas);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.Canvas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel, 1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // toolStrip
            // 
            resources.ApplyResources(this.toolStrip, "toolStrip");
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripButton_save,
            this.toolStripButton_load,
            this.toolStripSeparator1,
            this.toolStripLabel,
            this.toolStripLabel1,
            this.toolStripButton_brush,
            this.toolStripButton_rectangle,
            this.toolStripButton_ellipse,
            this.toolStripButton_trash,
            this.toolStripSeparator2,
            this.toolStripLabel_Thickness,
            this.toolStripComboBox,
            this.toolStripSeparator3,
            this.toolStripLabel_Chosencolor,
            this.toolStripButton_Chosencolor,
            this.toolStripSeparator4,
            this.toolStripLabel_Language,
            this.toolStripButton_English,
            this.toolStripButton_Polish});
            this.toolStrip.Name = "toolStrip";
            // 
            // toolStripLabel2
            // 
            resources.ApplyResources(this.toolStripLabel2, "toolStripLabel2");
            this.toolStripLabel2.Name = "toolStripLabel2";
            // 
            // toolStripButton_save
            // 
            resources.ApplyResources(this.toolStripButton_save, "toolStripButton_save");
            this.toolStripButton_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_save.Name = "toolStripButton_save";
            this.toolStripButton_save.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toolStripButton_load
            // 
            resources.ApplyResources(this.toolStripButton_load, "toolStripButton_load");
            this.toolStripButton_load.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_load.Name = "toolStripButton_load";
            this.toolStripButton_load.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolStripLabel
            // 
            resources.ApplyResources(this.toolStripLabel, "toolStripLabel");
            this.toolStripLabel.Name = "toolStripLabel";
            // 
            // toolStripLabel1
            // 
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            this.toolStripLabel1.Name = "toolStripLabel1";
            // 
            // toolStripButton_brush
            // 
            resources.ApplyResources(this.toolStripButton_brush, "toolStripButton_brush");
            this.toolStripButton_brush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_brush.Name = "toolStripButton_brush";
            this.toolStripButton_brush.Click += new System.EventHandler(this.brush_Click);
            // 
            // toolStripButton_rectangle
            // 
            resources.ApplyResources(this.toolStripButton_rectangle, "toolStripButton_rectangle");
            this.toolStripButton_rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_rectangle.Name = "toolStripButton_rectangle";
            this.toolStripButton_rectangle.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // toolStripButton_ellipse
            // 
            resources.ApplyResources(this.toolStripButton_ellipse, "toolStripButton_ellipse");
            this.toolStripButton_ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_ellipse.Name = "toolStripButton_ellipse";
            this.toolStripButton_ellipse.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // toolStripButton_trash
            // 
            resources.ApplyResources(this.toolStripButton_trash, "toolStripButton_trash");
            this.toolStripButton_trash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_trash.Name = "toolStripButton_trash";
            this.toolStripButton_trash.Click += new System.EventHandler(this.trashButton_Click);
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // toolStripLabel_Thickness
            // 
            resources.ApplyResources(this.toolStripLabel_Thickness, "toolStripLabel_Thickness");
            this.toolStripLabel_Thickness.Name = "toolStripLabel_Thickness";
            // 
            // toolStripComboBox
            // 
            resources.ApplyResources(this.toolStripComboBox, "toolStripComboBox");
            this.toolStripComboBox.Name = "toolStripComboBox";
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // toolStripLabel_Chosencolor
            // 
            resources.ApplyResources(this.toolStripLabel_Chosencolor, "toolStripLabel_Chosencolor");
            this.toolStripLabel_Chosencolor.Name = "toolStripLabel_Chosencolor";
            // 
            // toolStripButton_Chosencolor
            // 
            resources.ApplyResources(this.toolStripButton_Chosencolor, "toolStripButton_Chosencolor");
            this.toolStripButton_Chosencolor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Chosencolor.Name = "toolStripButton_Chosencolor";
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // toolStripLabel_Language
            // 
            resources.ApplyResources(this.toolStripLabel_Language, "toolStripLabel_Language");
            this.toolStripLabel_Language.Name = "toolStripLabel_Language";
            // 
            // toolStripButton_English
            // 
            resources.ApplyResources(this.toolStripButton_English, "toolStripButton_English");
            this.toolStripButton_English.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_English.Name = "toolStripButton_English";
            this.toolStripButton_English.Click += new System.EventHandler(this.englishButton_Click);
            // 
            // toolStripButton_Polish
            // 
            resources.ApplyResources(this.toolStripButton_Polish, "toolStripButton_Polish");
            this.toolStripButton_Polish.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Polish.Name = "toolStripButton_Polish";
            this.toolStripButton_Polish.Click += new System.EventHandler(this.polishButton_Click);
            // 
            // flowLayoutPanel
            // 
            resources.ApplyResources(this.flowLayoutPanel, "flowLayoutPanel");
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton_brush;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton_save;
        private System.Windows.Forms.ToolStripButton toolStripButton_load;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_rectangle;
        private System.Windows.Forms.ToolStripButton toolStripButton_ellipse;
        private System.Windows.Forms.ToolStripButton toolStripButton_trash;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Thickness;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Chosencolor;
        private System.Windows.Forms.ToolStripButton toolStripButton_Chosencolor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_Language;
        private System.Windows.Forms.ToolStripButton toolStripButton_English;
        private System.Windows.Forms.ToolStripButton toolStripButton_Polish;
    }
}
