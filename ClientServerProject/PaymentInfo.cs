using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClientServerProject
{
	public partial class PaymentInfo : UserControl
	{
		private MySqlConnection _connection;
		private MySqlCommand _command;
		private Plan _plan;
		private int[] _ext;
		public PaymentInfo(MySqlConnection conn, MySqlCommand cmd, Plan p, int[] extras)
		{
			InitializeComponent();
			_plan = p;
			_command = cmd;
			_connection = conn;
			_ext = extras;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			var payment = new Payment(_connection,_command,_plan,_ext);
			_plan.Controls.Add(payment);
			_plan.Controls.Remove(this);
		}

		private void btnPay_Click(object sender, EventArgs e)
		{
			/* Form Validation & Payment Processing should go here
			 * However, the scope of this project does not involve payment processing
			 * We will then assume that this section is done through cash or other independent systems
			 */
			MessageBox.Show(@"Payment Processed. Have a Great Day!");
		}

		private void txtCCV_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				MessageBox.Show(@"Payment Processed. Have a Great Day!");
			}
		}
	}
}
