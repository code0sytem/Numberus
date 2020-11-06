using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidSection;

namespace VisualSection
{
    public partial class FormularioDeArranque : Form
    {
        public FormularioDeArranque()
        {
            InitializeComponent();
        }

        MidInicioDeSesion ObjIDS = new MidInicioDeSesion();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void controlMovimientos(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void IniciarSesionBtn_Click(object sender, EventArgs e)
        {
            string[] UserData = new string[2];
            UserData[0] = UsertxtBox.Text;
            UserData[1] = PasstxtBox.Text;
            string Ret = ObjIDS.IniciarSesion(UserData[0], UserData[1]);
            MessageBox.Show(Ret);
            /*if (Ret== 1)
            {
                MessageBox.Show("ERROR");
            }*/
        }

        private void ShowEYE_Click(object sender, EventArgs e)
        {
            
        }
    }
}
