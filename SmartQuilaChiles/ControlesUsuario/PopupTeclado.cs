using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartQuilaChiles.ControlesUsuario
{
    public class PopupTeclado: ToolStripDropDown
{
    private Control _content;
    private ToolStripControlHost _host;

    public PopupTeclado(Control content)
    {
        //Basic setup...
        AutoSize = false;
        DoubleBuffered = true;
        ResizeRedraw = true;

        _content = content;
        _host = new ToolStripControlHost(content);

        //Positioning and Sizing
        MinimumSize = content.MinimumSize;
        MaximumSize = content.Size;
        Size = content.Size;
        content.Location = Point.Empty;

        //Add the host to the list
        Items.Add(_host);
    }
}
}
