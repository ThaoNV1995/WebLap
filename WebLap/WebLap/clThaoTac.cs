using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace De01_Vs03
{
    public class clThaoTac
    {
        string connect = @"Data Source=.;Initial Catalog=dbWeb11;Integrated Security=True";
        SqlConnection _sqlCon;
        SqlCommand _sqlCom;
        SqlDataAdapter _sqlADap;

        public void KetNoi()
        {
            _sqlCon = new SqlConnection(connect);
            if (_sqlCon.State == ConnectionState.Closed)
                _sqlCon.Open();
        }

        public void DongKetNoi()
        {
            if (_sqlCon.State == ConnectionState.Open)
                _sqlCon.Close();
        }

        public void ThucThi(string sql)
        {
            KetNoi();
            _sqlCom = new SqlCommand(sql, _sqlCon);
            _sqlCom.ExecuteNonQuery();
            DongKetNoi();
        }

        public DataTable LayDuLieu(string sql)
        {
            _sqlADap = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            _sqlADap.Fill(dt);
            return dt;
        }

        //private clThaoTac cl = new clThaoTac();
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    var dt = cl.LayDuLieu("SELECT *FROM tbCatalogs");
        //    List<tbCatalogs> list = (from DataRow dr in dt.Rows
        //                             select new tbCatalogs
        //                             {
        //                                 T_ID = int.Parse(dr[0].ToString()),
        //                                 T_Name = dr[1].ToString()
        //                             }).ToList();
        //    drL.DataSource = list;
        //    drL.DataValueField = "T_ID";
        //    drL.DataTextField = "T_Name";
        //    drL.SelectedValue = "2";
        //    drL.DataBind();

        //    var dul = cl.LayDuLieu("SELECT * FROM tbShoes WHERE P_ID=" + Request.QueryString["id"] + "");
        //    foreach (DataRow item in dul.Rows)
        //    {
        //        txtName.Text = item[1].ToString();
        //        txtGia.Text = item[2].ToString();
        //        txtSize.Text = item[3].ToString();
        //        txtSoLuong.Text = item[4].ToString();
        //    }

        //}

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    string s = drL.SelectedValue;
        //}
    }
}