using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace IDSS_StockingID_Management
{
    public partial class formStockingIDManagement : Form
    {
        public formStockingIDManagement ()
        {
            InitializeComponent ();
        }

        private void formStockingIDManagement_Load (object sender, EventArgs e)
        {
            DataTable dtBU = new DataTable();
            DataTable dtProductType = new DataTable();

            string consqlserver = ConfigurationManager.ConnectionStrings["LocalDBConnectionString"].ToString() + ";Password=CSD;";
            SqlConnection con = new SqlConnection(consqlserver);
            
            string sqlBU = "SELECT NAME FROM T_BI_BU";
            string sqlProductType = "SELECT TYPE_NAME FROM T_BI_SKUTYPE";

            SqlDataAdapter daBU = new SqlDataAdapter(sqlBU, con);
            SqlDataAdapter daProduceType = new SqlDataAdapter(sqlProductType, con);

            try
            {
                daBU.Fill(dtBU);
                if (dtBU.Rows.Count >= 1)
                {
                    for (int i = 0; i < dtBU.Rows.Count; i++)
                    {
                        comboBU.Items.Add(dtBU.Rows[i]["NAME"].ToString());
                    }
                }

                daProduceType.Fill(dtProductType);
                if (dtProductType.Rows.Count >= 1)
                {
                    for (int i = 0; i < dtProductType.Rows.Count; i++)
                    {
                        comboProductType.Items.Add(dtProductType.Rows[i]["TYPE_NAME"].ToString());
                    }
                }

                comboHVI.Items.Add("YES");
                comboHVI.Items.Add("NO");

                comboNeedTest.Items.Add("YES");
                comboNeedTest.Items.Add("NO");
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                daBU.Dispose();
                daProduceType.Dispose();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataTable dtBU = new DataTable();
            DataTable dtProductType = new DataTable();
            DataTable dtSearchResult = new DataTable();

            string strCondition = "";

            string consqlserver = ConfigurationManager.ConnectionStrings["LocalDBConnectionString"].ToString() + ";Password=CSD;";
            SqlConnection con = new SqlConnection(consqlserver);

            try
            {
                if (textStockingID.Text != "")
                {   //将StockingID的内容写入查询,用Like,支持部分匹配
                    strCondition = strCondition + " AND STOCKING_ID LIKE '%" + textStockingID.Text + "%'";
                }

                if (textProductCode.Text != "")
                {
                    strCondition = strCondition + " AND PRODUCT_CODE LIKE '%" + textProductCode.Text + "%'";
                }

                if (textProductGroup.Text != "")
                {
                    strCondition = strCondition + " AND PRODUCT_GROUP LIKE '%" + textProductGroup.Text + "%'";
                }

                if (textFamily.Text != "")
                {
                    strCondition = strCondition + " AND FAMILY LIKE '%" + textFamily.Text + "%'";
                }

                if (textMM.Text != "")
                {
                    strCondition = strCondition + " AND MM# LIKE '%" + textMM.Text + "%'";
                }

                if (comboBU.Text != "")
                {
                    SqlDataAdapter daBU = new SqlDataAdapter("SELECT ID FROM T_BI_BU WHERE NAME = '" + comboBU.Text + "'", con);
                    daBU.Fill(dtBU);
                    strCondition = strCondition + " AND BU_ID = " + dtBU.Rows[0]["ID"].ToString(); 
                }

                if (comboProductType.Text != "")
                {
                    SqlDataAdapter daProductType = new SqlDataAdapter("SELECT ID FROM T_BI_SKUTYPE WHERE TYPE_NAME = '" + comboProductType.Text + "'", con);
                    daProductType.Fill(dtProductType);
                    strCondition = strCondition + " AND SKUTYPE_ID = " + dtProductType.Rows[0]["ID"].ToString();
                }

                if (comboHVI.Text != "")
                {
                    if (comboHVI.Text == "YES")
                    {
                        strCondition = strCondition + " AND HVI = 1";
                    }else
                    {
                        strCondition = strCondition + " AND HVI = 0";
                    }
                }

                if (comboNeedTest.Text != "")
                {
                    if (comboNeedTest.Text == "YES")
                    {
                        strCondition = strCondition + " AND NEED_TEST = 1";
                    }
                    else
                    {
                        strCondition = strCondition + " AND NEED_TEST = 0";
                    }
                }

                if (strCondition != "")
                {   //生成查询语句,取得查询结果,并显示到dataGridView中
                    string sqlSearch = "SELECT (SELECT NAME FROM T_BI_BU WHERE ID=BU_ID) AS BU," +
                                               //"PRODUCT_GROUP," +
                                               "FAMILY," +
                                               "STOCKING_ID," +
                                               "PRODUCT_CODE," +
                                               "MM#," +
                                               "DESCRIPTION," +
                                               "CASE WHEN HVI = 1 THEN 'YES' ELSE 'NO' END AS HVI," +
                                               "CASE WHEN NEED_TEST = 1 THEN 'YES' ELSE 'NO' END AS NEED_TEST," +
                                               "CASE WHEN IS_AVAILABLE = 1 THEN 'YES' ELSE 'NO' END AS AVAILABLE " +
                                               "FROM T_BI_SKU WHERE NOT BU_ID IS NULL" + strCondition;
                    SqlDataAdapter daSearchResult = new SqlDataAdapter(sqlSearch,con);
                    daSearchResult.Fill(dtSearchResult);
                    if (dtSearchResult.Rows.Count >=1)
                    {
                        dataGridStockingIDList.DataSource = dtSearchResult;
                    }else
                    {
                        MessageBox.Show("没有符合条件的Stocking ID !");
                    }
                }
            }
            catch (Exception msg)
            {   
                MessageBox.Show(msg.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
                dtBU.Dispose();
                dtProductType.Dispose();
                dtSearchResult.Dispose();
            }
        }

        private void dataGridStockingIDList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("OK");
        }
    }
}
