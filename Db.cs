using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon
{
    class Db
    {
        static string _ConnectionString = "server=localhost;port=3306;database=hastaneotomasyon;uid=root;pwd=;";
        static MySqlConnection _Connection;
        public static MySqlConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    _Connection = new MySqlConnection(_ConnectionString);
                    _Connection.Open();

                    return _Connection;
                }
                else if (_Connection.State != System.Data.ConnectionState.Open)
                {
                    _Connection.Open();

                    return _Connection;
                }
                else
                {
                    return _Connection;
                }
            }
        }

        static DataSet GetDataSet(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adp.Fill(ds);
            Connection.Close();

            return ds;
        }

        public static DataTable GetDataTable(string sql)
        {
            DataSet ds = GetDataSet(sql);

            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }

        public static int ExecuteSQL(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            return cmd.ExecuteNonQuery();
        }

        public static int ExecuteSQL(string sql, MySqlParameter p)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            cmd.Parameters.Add(p);
            return cmd.ExecuteNonQuery();

        }

        public static DataSet bolumleri_getir() 
        {
            var sql = "SELECT bolum_id as 'Bölüm No', bolum_adi as 'Bölüm Adı' FROM bolumler";
            var dataset = GetDataSet(sql);
            return dataset;
        }

        public static void yeni_bolum_ekle(string bolum_adi) 
        {
            var sql = $"INSERT INTO `bolumler` (`bolum_adi`) VALUES ('{bolum_adi}')";
            ExecuteSQL(sql);
        }

        public static void bolumu_sil(int bolum_id)
        {
            var sql = $"DELETE FROM `bolumler` WHERE bolum_id = '{bolum_id}'";
            ExecuteSQL(sql);
        }

        public static void doktor_ekle(int bolum_id, string doktor_adi, string doktor_sifre)
        {
            var sql = $"INSERT INTO doktorlar (`doktor_adi`, `doktor_sifre`, `bolum_id`) VALUES ('{doktor_adi}', '{doktor_sifre}', '{bolum_id}')";
            ExecuteSQL(sql);
        }

        internal static void doktor_sil(int doktor_id)
        {
            var sql = $"DELETE FROM `doktorlar` WHERE doktor_id = '{doktor_id}'";
            ExecuteSQL(sql);
        }

        public static DataSet doktorlari_getir()
        {
            var sql = "SELECT doktor_id as 'Doktor No', doktor_adi as 'Doktor Adı', bolumler.bolum_adi as 'Bölüm Adı' FROM doktorlar INNER JOIN bolumler on doktorlar.bolum_id = bolumler.bolum_id";
            var dataset = GetDataSet(sql);
            return dataset;
        }

        public static DataSet doktorlari_getir(int bolum_id)
        {
            var sql = $"SELECT * FROM doktorlar WHERE bolum_id = {bolum_id}";
            var dataset = GetDataSet(sql);
            return dataset;
        }

        public static void randevu_kayit(string hasta_tc, string hasta_adi, DateTime randevu_tarih, int bolum_id, int doktor_id,int status)
        {
            string tarih_saat = randevu_tarih.ToString("yyyy-MM-dd HH:mm:ss");
            var sql = $"INSERT INTO `randevu_kayitlari` (`hasta_tc`, `hasta_adi`, `bolum_id`, `doktor_id`, `randevu_tarih`,`status`) VALUES ('{hasta_tc}', '{hasta_adi}', '{bolum_id}', '{doktor_id}', '{tarih_saat}','{status}')";
            ExecuteSQL(sql);
        }

        public static DataSet randevulari_getir(int doktor_id, int status)
        {
            var sql = $"SELECT randevu_id as 'Randevu No', hasta_tc as 'T.C.', hasta_adi as 'Hasta Adı', randevu_tarih as 'Tarih',status FROM randevu_kayitlari WHERE doktor_id = {doktor_id} and  status = {status} ";
            var dataset = GetDataSet(sql);
            return dataset;
        }

        public static bool doktor_kontrol(int doktor_id, string sifre)
        {
            var sql = $"SELECT * FROM doktorlar WHERE doktor_id = '{doktor_id}' and doktor_sifre = '{sifre}'";
            var datatable = GetDataTable(sql);
            return datatable.Rows.Count > 0;
        }
    }
}