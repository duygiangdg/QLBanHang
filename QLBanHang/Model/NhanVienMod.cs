using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Model
{
    class NhanVienMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from tb_NhanVien";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return dt;
        }

        public bool AddData(NhanVienObj nvObj)
        {
            cmd.CommandText = "insert into tb_NhanVien values ('" 
                + nvObj.Ma + "','"
                + nvObj.Ten + "','"
                + nvObj.GioiTinh + "', CONVER(DATE,'"
                + nvObj.NamSinh.ToShortDateString() + "',103),'" 
                + nvObj.DiaChi + "','"
                + nvObj.Sdt + "','"
                + nvObj.MatKhau + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }
    }
}
