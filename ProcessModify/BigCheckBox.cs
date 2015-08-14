//http://forum.codecall.net/topic/73939-how-to-resize-a-checkbox-using-the-net-framework/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Drawing;

namespace ProcessModify
{
    public class BigCheckBox : CheckBox
	    {
		    public BigCheckBox()
		    {
			    this.Text = "";
			    this.TextAlign = ContentAlignment.MiddleRight;			    
		    }

		    public override bool AutoSize
		    {
			    set { base.AutoSize = false; }
			    get { return base.AutoSize; }
		    }

		    protected override void OnPaint(PaintEventArgs e)
		    {
			    base.OnPaint(e);
							    
			    this.Height = 100;
			    this.Width = 200;
                this.Location = new Point(8, 22);
                
			    int squareSide = 26;

			    Rectangle rect = new Rectangle(new Point(0, 1), new Size(squareSide + 5, squareSide));

			    ControlPaint.DrawCheckBox(e.Graphics, rect, this.Checked ? ButtonState.Checked : ButtonState.Normal);
		    }
	    }
}
