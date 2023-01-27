/*
 * Created by SharpDevelop.
 * User: valerio
 * Date: 26/01/2023
 * Time: 14:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Thread hilo1;
		Thread hilo2;
		
		public MainForm()
        {
            InitializeComponent();
        }
		public void moverx()
        {
            for (int i = 0; i < 20; i++)
            {
                button1.BeginInvoke((Action)delegate ()
                {
                    button1.SetBounds(0 +i , 0 + i , 100 , 50 );
                });

                Thread.Sleep(100);
            }
        }
        public void movery()
        {
            for (int i = 0; i < 20; i++)
            {
                button1.BeginInvoke((Action)delegate ()
                {
                    button1.SetBounds(0+i,0+i,100,50);
                });

                Thread.Sleep(100);
            }
        }
        private void Button2Click(object sender, EventArgs e)
        {
            hilo1 = new Thread(moverx);
            hilo1.Start();
        }
        private void Button4Click(object sender, EventArgs e)
        {
            hilo1.Abort();
        }
	}
}
