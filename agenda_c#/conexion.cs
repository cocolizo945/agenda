/*
 * Created by SharpDevelop.
 * User: coquito
 * Date: 31/10/2022
 * Time: 12:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

namespace agenda_c_
{
	/// <summary>
	/// Description of conexion.
	/// </summary>
	public class conexion
	{
		
		public conexion()
		{
		}
		
		public static MySqlConnection conex(){
			string server = "localhost";
			string user = "root";
			string pass = "123456789";
			string db = "agenda";
			
			string chain = "server ="+server+"; user ="+user+"; pwd="+pass+"; database="+db+"";
			
			try{MySqlConnection cn = new MySqlConnection(chain);
				MessageBox.Show("conexion exitosa");
				return cn;
				
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message + "\n conexion fallida");
				return null;
				
			}
		}
	}
}
