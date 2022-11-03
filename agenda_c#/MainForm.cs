/*
 * Created by SharpDevelop.
 * User: coquito
 * Date: 31/10/2022
 * Time: 12:17 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace agenda_c_
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			MySqlConnection con = conexion.conex();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnsaveClick(object sender, EventArgs e)
		{
			int vid=0;
			string nombre=txtname.Text;
			string ap=txtname.Text;
			
			string insert_bd="insert into personas values('"+vid+"','"+nombre+"','"+ap+"');";
			
			MySqlCommand cmdin=new MySqlCommand(insert_bd);
		
			txtname.Text="";
			txtap.Text="";
		}
	}
}
