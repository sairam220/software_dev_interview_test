using System;
using System.Windows;
using Rhino.Geometry;
using Rhino.Commands;
using Rhino.UI;

namespace RhinoSamplePlugin
{
    public partial class SampleWpfWindow : Window
    {
        public SampleWpfWindow()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            double length = double.Parse(LengthTextBox.Text);
            double width = double.Parse(WidthTextBox.Text);
            double x = double.Parse(XTextBox.Text);
            double y = double.Parse(YTextBox.Text);
            double z = double.Parse(ZTextBox.Text);

            
            RhinoDoc doc = RhinoDoc.ActiveDoc;
            Point3d center = new Point3d(x, y, z);

            Rectangle3d rectangle = new Rectangle3d(Plane.WorldXY, center, length, width);
            Brep surface = rectangle.ToBrep();

            doc.Objects.AddBrep(surface);

            doc.Views.Redraw();
        }
    }
}
