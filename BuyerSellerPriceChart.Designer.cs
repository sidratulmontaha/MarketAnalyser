namespace MarketAnalyser
{
    partial class BuyerSellerPriceChart
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
            Infragistics.UltraChart.Resources.Appearance.PaintElement paintElement1 = new Infragistics.UltraChart.Resources.Appearance.PaintElement();
            Infragistics.UltraChart.Resources.Appearance.ChartArea chartArea1 = new Infragistics.UltraChart.Resources.Appearance.ChartArea();
            Infragistics.UltraChart.Resources.Appearance.AxisItem axisItem1 = new Infragistics.UltraChart.Resources.Appearance.AxisItem();
            Infragistics.UltraChart.Resources.Appearance.AxisItem axisItem2 = new Infragistics.UltraChart.Resources.Appearance.AxisItem();
            Infragistics.UltraChart.Resources.Appearance.AxisItem axisItem3 = new Infragistics.UltraChart.Resources.Appearance.AxisItem();
            Infragistics.UltraChart.Resources.Appearance.PaintElement paintElement2 = new Infragistics.UltraChart.Resources.Appearance.PaintElement();
            Infragistics.UltraChart.Resources.Appearance.PaintElement paintElement3 = new Infragistics.UltraChart.Resources.Appearance.PaintElement();
            Infragistics.UltraChart.Resources.Appearance.ChartLayerAppearance chartLayerAppearance1 = new Infragistics.UltraChart.Resources.Appearance.ChartLayerAppearance();
            Infragistics.UltraChart.Resources.Appearance.ChartLayerAppearance chartLayerAppearance2 = new Infragistics.UltraChart.Resources.Appearance.ChartLayerAppearance();
            Infragistics.UltraChart.Resources.Appearance.GradientEffect gradientEffect1 = new Infragistics.UltraChart.Resources.Appearance.GradientEffect();
            this.ultraDateTimeEditor1 = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraDateTimeEditor2 = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ultraChart1 = new Infragistics.Win.UltraWinChart.UltraChart();
            this.BVC = new System.Windows.Forms.CheckBox();
            this.VC = new System.Windows.Forms.CheckBox();
            this.PC = new System.Windows.Forms.CheckBox();
            this.SVC = new System.Windows.Forms.CheckBox();
            this.BSRt = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraDateTimeEditor1
            // 
            this.ultraDateTimeEditor1.FormatString = "";
            this.ultraDateTimeEditor1.Location = new System.Drawing.Point(66, 15);
            this.ultraDateTimeEditor1.MaskInput = "{date} {time}";
            this.ultraDateTimeEditor1.Name = "ultraDateTimeEditor1";
            this.ultraDateTimeEditor1.Size = new System.Drawing.Size(185, 21);
            this.ultraDateTimeEditor1.TabIndex = 0;
            // 
            // ultraDateTimeEditor2
            // 
            this.ultraDateTimeEditor2.FormatString = "";
            this.ultraDateTimeEditor2.Location = new System.Drawing.Point(273, 15);
            this.ultraDateTimeEditor2.MaskInput = "{date} {time}";
            this.ultraDateTimeEditor2.Name = "ultraDateTimeEditor2";
            this.ultraDateTimeEditor2.Size = new System.Drawing.Size(185, 21);
            this.ultraDateTimeEditor2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(474, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1097, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
//			'UltraChart' properties's serialization: Since 'ChartType' changes the way axes look,
//			'ChartType' must be persisted ahead of any Axes change made in design time.
//		
            this.ultraChart1.ChartType = Infragistics.UltraChart.Shared.Styles.ChartType.Composite;
            // 
            // ultraChart1
            // 
            this.ultraChart1.Axis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            paintElement1.ElementType = Infragistics.UltraChart.Shared.Styles.PaintElementType.None;
            paintElement1.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(220)))));
            this.ultraChart1.Axis.PE = paintElement1;
            this.ultraChart1.Axis.X.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.X.Labels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart1.Axis.X.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>";
            this.ultraChart1.Axis.X.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.X.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart1.Axis.X.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.X.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart1.Axis.X.Labels.SeriesLabels.FormatString = "";
            this.ultraChart1.Axis.X.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.X.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.X.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart1.Axis.X.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.X.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.X.LineThickness = 1;
            this.ultraChart1.Axis.X.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.X.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.X.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.X.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.X.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.X.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.X.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.X.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.X.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart1.Axis.X.Visible = true;
            this.ultraChart1.Axis.X2.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.X2.Labels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart1.Axis.X2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart1.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>";
            this.ultraChart1.Axis.X2.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.X2.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.FormatString = "";
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            this.ultraChart1.Axis.X2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.X2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.X2.Labels.Visible = false;
            this.ultraChart1.Axis.X2.LineThickness = 1;
            this.ultraChart1.Axis.X2.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.X2.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.X2.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.X2.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.X2.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.X2.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.X2.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.X2.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.X2.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart1.Axis.X2.Visible = false;
            this.ultraChart1.Axis.Y.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Y.Labels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart1.Axis.Y.Labels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart1.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
            this.ultraChart1.Axis.Y.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Y.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.FormatString = "";
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Far;
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Y.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Y.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Y.LineThickness = 1;
            this.ultraChart1.Axis.Y.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Y.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.Y.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Y.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.Y.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Y.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.Y.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Y.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.Y.TickmarkInterval = 10D;
            this.ultraChart1.Axis.Y.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart1.Axis.Y.Visible = true;
            this.ultraChart1.Axis.Y2.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Y2.Labels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart1.Axis.Y2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
            this.ultraChart1.Axis.Y2.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Y2.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.FormatString = "";
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Y2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Y2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Y2.Labels.Visible = false;
            this.ultraChart1.Axis.Y2.LineThickness = 1;
            this.ultraChart1.Axis.Y2.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Y2.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.Y2.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Y2.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.Y2.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Y2.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.Y2.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Y2.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.Y2.TickmarkInterval = 10D;
            this.ultraChart1.Axis.Y2.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart1.Axis.Y2.Visible = false;
            this.ultraChart1.Axis.Z.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Z.Labels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart1.Axis.Z.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.Z.Labels.ItemFormatString = "";
            this.ultraChart1.Axis.Z.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Z.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.FontColor = System.Drawing.Color.DimGray;
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Z.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Z.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Z.LineThickness = 1;
            this.ultraChart1.Axis.Z.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Z.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.Z.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Z.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.Z.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Z.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.Z.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Z.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.Z.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart1.Axis.Z.Visible = false;
            this.ultraChart1.Axis.Z2.Labels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Z2.Labels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart1.Axis.Z2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.Z2.Labels.ItemFormatString = "";
            this.ultraChart1.Axis.Z2.Labels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Z2.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.Font = new System.Drawing.Font("Verdana", 7F);
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.FontColor = System.Drawing.Color.Gray;
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.Layout.Behavior = Infragistics.UltraChart.Shared.Styles.AxisLabelLayoutBehaviors.Auto;
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            this.ultraChart1.Axis.Z2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Z2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            this.ultraChart1.Axis.Z2.Labels.Visible = false;
            this.ultraChart1.Axis.Z2.LineThickness = 1;
            this.ultraChart1.Axis.Z2.MajorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Z2.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            this.ultraChart1.Axis.Z2.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Z2.MajorGridLines.Visible = true;
            this.ultraChart1.Axis.Z2.MinorGridLines.AlphaLevel = ((byte)(255));
            this.ultraChart1.Axis.Z2.MinorGridLines.Color = System.Drawing.Color.LightGray;
            this.ultraChart1.Axis.Z2.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            this.ultraChart1.Axis.Z2.MinorGridLines.Visible = false;
            this.ultraChart1.Axis.Z2.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            this.ultraChart1.Axis.Z2.Visible = false;
            this.ultraChart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ultraChart1.ColorModel.AlphaLevel = ((byte)(150));
            this.ultraChart1.ColorModel.ColorBegin = System.Drawing.Color.Pink;
            this.ultraChart1.ColorModel.ColorEnd = System.Drawing.Color.DarkRed;
            this.ultraChart1.ColorModel.ModelStyle = Infragistics.UltraChart.Shared.Styles.ColorModels.CustomLinear;
            axisItem1.DataType = Infragistics.UltraChart.Shared.Styles.AxisDataType.Time;
            axisItem1.Key = "axis1";
            axisItem1.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            axisItem1.Labels.ItemFormatString = "<ITEM_LABEL:HH:mm>";
            axisItem1.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.VerticalLeftFacing;
            axisItem1.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center;
            axisItem1.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            axisItem1.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            axisItem1.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            axisItem1.MajorGridLines.AlphaLevel = ((byte)(255));
            axisItem1.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            axisItem1.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            axisItem1.MajorGridLines.Visible = true;
            axisItem1.MinorGridLines.AlphaLevel = ((byte)(255));
            axisItem1.MinorGridLines.Color = System.Drawing.Color.LightGray;
            axisItem1.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            axisItem1.MinorGridLines.Visible = false;
            axisItem1.OrientationType = Infragistics.UltraChart.Shared.Styles.AxisNumber.X_Axis;
            axisItem1.SetLabelAxisType = Infragistics.UltraChart.Core.Layers.SetLabelAxisType.GroupBySeries;
            axisItem1.TickmarkInterval = 5D;
            axisItem1.TickmarkIntervalType = Infragistics.UltraChart.Shared.Styles.AxisIntervalType.Years;
            axisItem1.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            axisItem2.DataType = Infragistics.UltraChart.Shared.Styles.AxisDataType.Numeric;
            axisItem2.Key = "axis2";
            axisItem2.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            axisItem2.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
            axisItem2.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            axisItem2.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center;
            axisItem2.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            axisItem2.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            axisItem2.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            axisItem2.MajorGridLines.AlphaLevel = ((byte)(255));
            axisItem2.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            axisItem2.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            axisItem2.MajorGridLines.Visible = true;
            axisItem2.MinorGridLines.AlphaLevel = ((byte)(255));
            axisItem2.MinorGridLines.Color = System.Drawing.Color.LightGray;
            axisItem2.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            axisItem2.MinorGridLines.Visible = false;
            axisItem2.OrientationType = Infragistics.UltraChart.Shared.Styles.AxisNumber.Y_Axis;
            axisItem2.SetLabelAxisType = Infragistics.UltraChart.Core.Layers.SetLabelAxisType.GroupBySeries;
            axisItem2.TickmarkStyle = Infragistics.UltraChart.Shared.Styles.AxisTickStyle.Smart;
            axisItem3.DataType = Infragistics.UltraChart.Shared.Styles.AxisDataType.Numeric;
            axisItem3.Key = "axis3";
            axisItem3.Labels.HorizontalAlign = System.Drawing.StringAlignment.Near;
            axisItem3.Labels.ItemFormatString = "<DATA_VALUE:00.##>";
            axisItem3.Labels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            axisItem3.Labels.SeriesLabels.HorizontalAlign = System.Drawing.StringAlignment.Center;
            axisItem3.Labels.SeriesLabels.Orientation = Infragistics.UltraChart.Shared.Styles.TextOrientation.Horizontal;
            axisItem3.Labels.SeriesLabels.VerticalAlign = System.Drawing.StringAlignment.Center;
            axisItem3.Labels.VerticalAlign = System.Drawing.StringAlignment.Center;
            axisItem3.MajorGridLines.AlphaLevel = ((byte)(255));
            axisItem3.MajorGridLines.Color = System.Drawing.Color.Gainsboro;
            axisItem3.MajorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            axisItem3.MajorGridLines.Visible = true;
            axisItem3.MinorGridLines.AlphaLevel = ((byte)(255));
            axisItem3.MinorGridLines.Color = System.Drawing.Color.LightGray;
            axisItem3.MinorGridLines.DrawStyle = Infragistics.UltraChart.Shared.Styles.LineDrawStyle.Dot;
            axisItem3.MinorGridLines.Visible = false;
            axisItem3.OrientationType = Infragistics.UltraChart.Shared.Styles.AxisNumber.Y2_Axis;
            axisItem3.SetLabelAxisType = Infragistics.UltraChart.Core.Layers.SetLabelAxisType.GroupBySeries;
            chartArea1.Axes.Add(axisItem1);
            chartArea1.Axes.Add(axisItem2);
            chartArea1.Axes.Add(axisItem3);
            paintElement2.ElementType = Infragistics.UltraChart.Shared.Styles.PaintElementType.None;
            chartArea1.GridPE = paintElement2;
            chartArea1.Key = "area1";
            chartArea1.PE = paintElement3;
            this.ultraChart1.CompositeChart.ChartAreas.Add(chartArea1);
            chartLayerAppearance1.AxisXKey = "axis1";
            chartLayerAppearance1.AxisYKey = "axis2";
            chartLayerAppearance1.ChartAreaKey = "area1";
            chartLayerAppearance1.ChartType = Infragistics.UltraChart.Shared.Styles.ChartType.AreaChart;
            chartLayerAppearance1.Key = "chartLayer1";
            chartLayerAppearance2.AxisXKey = "axis1";
            chartLayerAppearance2.AxisYKey = "axis3";
            chartLayerAppearance2.ChartAreaKey = "area1";
            chartLayerAppearance2.ChartType = Infragistics.UltraChart.Shared.Styles.ChartType.LineChart;
            chartLayerAppearance2.Key = "chartLayer2";
            this.ultraChart1.CompositeChart.ChartLayers.AddRange(new Infragistics.UltraChart.Resources.Appearance.ChartLayerAppearance[] {
            chartLayerAppearance1,
            chartLayerAppearance2});
            this.ultraChart1.Effects.Effects.Add(gradientEffect1);
            this.ultraChart1.Location = new System.Drawing.Point(33, 50);
            this.ultraChart1.Name = "ultraChart1";
            this.ultraChart1.Size = new System.Drawing.Size(1239, 690);
            this.ultraChart1.TabIndex = 4;
            this.ultraChart1.Tooltips.HighlightFillColor = System.Drawing.Color.DimGray;
            this.ultraChart1.Tooltips.HighlightOutlineColor = System.Drawing.Color.DarkGray;
            // 
            // BVC
            // 
            this.BVC.AutoSize = true;
            this.BVC.Checked = true;
            this.BVC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BVC.Location = new System.Drawing.Point(642, 15);
            this.BVC.Name = "BVC";
            this.BVC.Size = new System.Drawing.Size(88, 17);
            this.BVC.TabIndex = 5;
            this.BVC.Text = "BuyerVolume";
            this.BVC.UseVisualStyleBackColor = true;
            // 
            // VC
            // 
            this.VC.AutoSize = true;
            this.VC.Checked = true;
            this.VC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VC.Location = new System.Drawing.Point(885, 17);
            this.VC.Name = "VC";
            this.VC.Size = new System.Drawing.Size(85, 17);
            this.VC.TabIndex = 6;
            this.VC.Text = "TotalVolume";
            this.VC.UseVisualStyleBackColor = true;
            // 
            // PC
            // 
            this.PC.AutoSize = true;
            this.PC.Checked = true;
            this.PC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PC.Location = new System.Drawing.Point(829, 15);
            this.PC.Name = "PC";
            this.PC.Size = new System.Drawing.Size(50, 17);
            this.PC.TabIndex = 7;
            this.PC.Text = "Price";
            this.PC.UseVisualStyleBackColor = true;
            // 
            // SVC
            // 
            this.SVC.AutoSize = true;
            this.SVC.Checked = true;
            this.SVC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SVC.Location = new System.Drawing.Point(736, 15);
            this.SVC.Name = "SVC";
            this.SVC.Size = new System.Drawing.Size(87, 17);
            this.SVC.TabIndex = 8;
            this.SVC.Text = "SellerVolume";
            this.SVC.UseVisualStyleBackColor = true;
            // 
            // BSRt
            // 
            this.BSRt.AutoSize = true;
            this.BSRt.Checked = true;
            this.BSRt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BSRt.Location = new System.Drawing.Point(978, 17);
            this.BSRt.Name = "BSRt";
            this.BSRt.Size = new System.Drawing.Size(104, 17);
            this.BSRt.TabIndex = 9;
            this.BSRt.Text = "BuyerSellerRatio";
            this.BSRt.UseVisualStyleBackColor = true;
            // 
            // BuyerSellerPriceChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 752);
            this.Controls.Add(this.BSRt);
            this.Controls.Add(this.SVC);
            this.Controls.Add(this.PC);
            this.Controls.Add(this.VC);
            this.Controls.Add(this.BVC);
            this.Controls.Add(this.ultraChart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ultraDateTimeEditor2);
            this.Controls.Add(this.ultraDateTimeEditor1);
            this.Name = "BuyerSellerPriceChart";
            this.Text = "BuyerSellerPriceChart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BuyerSellerPriceChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDateTimeEditor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraChart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditor1;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor ultraDateTimeEditor2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private Infragistics.Win.UltraWinChart.UltraChart ultraChart1;
        private System.Windows.Forms.CheckBox BVC;
        private System.Windows.Forms.CheckBox VC;
        private System.Windows.Forms.CheckBox PC;
        private System.Windows.Forms.CheckBox SVC;
        private System.Windows.Forms.CheckBox BSRt;
    }
}