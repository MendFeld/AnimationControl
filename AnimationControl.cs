using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimationControlD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void XuiButton1_Click(object sender, EventArgs e)
        {
            xuiObjectAnimator1.ColorAnimate(this, Color.LightBlue, XanderUI.XUIObjectAnimator.ColorAnimation.FillEllipse, true, 5);
        }

        private void XuiButton2_Click(object sender, EventArgs e)
        {
            xuiObjectAnimator1.StandardAnimate(xuiClock1, XanderUI.XUIObjectAnimator.StandardAnimation.SlideUp, 1);
        }

        private void XuiButton3_Click(object sender, EventArgs e)
        {
            xuiObjectAnimator1.FormAnimate(this, XanderUI.XUIObjectAnimator.FormAnimation.FadeIn, 1);
        }
    }
}
