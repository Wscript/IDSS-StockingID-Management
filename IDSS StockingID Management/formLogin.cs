using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace IDSS_StockingID_Management
{
    public partial class formLogin : Form
    {

        public formLogin ()
        {
            InitializeComponent ();
        }

        private void buttonLogin_Click (object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show ("用户名或密码不能为空!");
            }
            else
            {
                //定义数据表,后面填充数据使用
                DataTable dt = new DataTable();

                //定义数据库连接语句
                string consqlserver = ConfigurationManager.ConnectionStrings["LocalDBConnectionString"].ToString () + ";Password=CSD;";

                //定义SQL查询语句  
                string sql = "SELECT * FROM SYSUSER WHERE SYSUSERID='" + textBoxUsername.Text + "'";

                //定义SQL Server连接对象  
                SqlConnection con = new SqlConnection (consqlserver);

                //数据库命令和数据库连接  
                SqlDataAdapter da = new SqlDataAdapter (sql, con);

                try
                {
                    da.Fill (dt);                                    //填充数据  
                    if (dt.Rows.Count > 0)                //判断是否符合条件的数据记录  
                    {
                        if (dt.Rows[0]["SYSPASSWORD"].ToString () == textBoxPassword.Text)
                        {
                            //MessageBox.Show("用户名密码正确!");
                            Global.stringUserName = textBoxUsername.Text;
                            formStockingIDManagement formStockingIDManagement = new formStockingIDManagement ();
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show ("密码不正确!");
                        }
                    }
                    else
                    {
                        MessageBox.Show ("用户名不存在!");
                    }
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message);
                }
                finally
                {
                    con.Close ();                    //关闭连接  
                    con.Dispose ();                  //释放连接
                    da.Dispose ();                   //释放资源
                    dt.Dispose();
                }
            }

        }

        private void formLogin_Load (object sender, EventArgs e)
        {
            this.AcceptButton = buttonLogin;
        }
    }
}
