using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartQuilaChiles.General
{
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {

            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.RowCount = 20/tableLayoutPanel1.ColumnCount;
            foreach (ColumnStyle style in tableLayoutPanel1.ColumnStyles)
            {
                style.SizeType = SizeType.Percent;
                style.Width = 100 / tableLayoutPanel1.ColumnCount;
            }
            foreach (RowStyle style in tableLayoutPanel1.RowStyles)
            {
                style.SizeType = SizeType.Percent;
                style.Height = 100 / tableLayoutPanel1.ColumnCount;
            }
            int width = tableLayoutPanel1.GetColumnWidths()[0];
            int height = tableLayoutPanel1.GetRowHeights()[0];
            for (int i = 0; i < 20; i++)
            {

                Button btn = new Button();
                btn.Name = "IdEmpleado";
                btn.Text = "Nombre Empleado";
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                tableLayoutPanel1.Controls.Add(btn);
                btn.Size = new Size(width - 10, height - 10);
            }
        }
    }
}
