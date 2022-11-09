using RehabilitationForm.utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehabilitationForm
{
    internal class Utility
    {
        private SqlConnection GetSqlConnection()
        {
            //return new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=dbClass;Integrated Security=True");
            return new SqlConnection(@"Data Source=.;Initial Catalog=dbClass;Integrated Security=True");

        }
        public int exeNonQuery(string sql, List<ParamatsWithValueClass> paramatsList)
        {
            int ifSuccess = -1;

            using (SqlConnection con = GetSqlConnection())
            {

                SqlCommand scomm = new SqlCommand(sql);
                scomm.Connection = con;
                con.Open();
                SqlTransaction transactionMan = con.BeginTransaction();
                scomm.Transaction = transactionMan;

                try
                {
                    if (paramatsList != null)
                    {
                        foreach (ParamatsWithValueClass item in paramatsList)
                        {
                            scomm.Parameters.AddWithValue(item.key, item.value);
                        }
                    }
               

                    ifSuccess = scomm.ExecuteNonQuery();
                    transactionMan.Commit();
                }
                catch (Exception ex)
                {
                    transactionMan.Rollback();
                    MessageBox.Show(sql + "   交易程序失敗 \r\n" + ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }
            return ifSuccess;

        }
        public string exeScalar(string sql, List<ParamatsWithValueClass> paramatsList)
        {

            string ifSuccess = "";

            using (SqlConnection con = GetSqlConnection())
            {

                SqlCommand scomm = new SqlCommand(sql);
                scomm.Connection = con;
                con.Open();

                SqlTransaction transactionMan = con.BeginTransaction();
                scomm.Transaction = transactionMan;
                try
                {
                    if (paramatsList != null)
                    {
                        foreach (ParamatsWithValueClass item in paramatsList)
                        {
                            scomm.Parameters.AddWithValue(item.key, item.value);
                        }
                    }
                    var ifSuccessVar = scomm.ExecuteScalar();

                    if (ifSuccessVar == null) { ifSuccess = "0"; } else { ifSuccess = ifSuccessVar.ToString(); }

                    transactionMan.Commit();
                }
                catch (Exception ex)
                {
                    transactionMan.Rollback();
                    MessageBox.Show(sql + "   交易程序失敗 \r\n" + ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }
            return ifSuccess;

        }
        public DataTable exeReader(string sql, List<ParamatsWithValueClass> paramatsList)
        {
        
            DataTable schemaTable=new DataTable();
            using (SqlConnection con = GetSqlConnection())
            {
                SqlCommand scomm = new SqlCommand(sql);
                scomm.Connection = con;
                con.Open();
                SqlTransaction transactionMan = con.BeginTransaction();
                scomm.Transaction = transactionMan;
                SqlDataReader sr = null;
                try
                {
                    if (paramatsList != null)
                    {
                        foreach (ParamatsWithValueClass item in paramatsList)
                        {
                            scomm.Parameters.AddWithValue(item.key, item.value);
                        }
                    }
                 sr = scomm.ExecuteReader();
                    schemaTable.Load(sr);
                sr.Close(); //機車啊在commit前就要關了，一直說我開太多沒關，還以為我哪邊又開了，原來是他要你把sr關了他才會說正常。
                transactionMan.Commit();
                }
                catch (Exception ex)
                {
                    sr.Close();
                    transactionMan.Rollback();

                    MessageBox.Show(sql + "   交易程序失敗 \r\n" + ex.Message);
                }
                finally
                {
                    sr.Close();
                    con.Close();
                }
            }
            return schemaTable;
        }

        public void ReadOrModifyResxData(string resXdataName, string OptionKey, ComboBox sender, params string[] stringArgs)
        {
            if (File.Exists(Application.StartupPath + @"\" + resXdataName))
            {
                if (sender != null && sender is ComboBox)
                {
                    getComboxData(resXdataName, sender);
                }
                else { resXModify(resXdataName, OptionKey, null, false, stringArgs[0],true); }
            }
            else
            {
                int count = 0;
                ResXResourceWriter ResWriter = new ResXResourceWriter(resXdataName);
                if (sender != null && sender is ComboBox)
                {

                    foreach (string item in stringArgs)
                    {
                        ResWriter.AddResource($"{count++}", item);
                    }
                }
                else
                {
                    ResWriter.AddResource(OptionKey, stringArgs[0]);
                }
                ResWriter.Close();

            }

        }

        private void getComboxData(string resXName, ComboBox sender)
        {
            ResXResourceReader ResReader = null;
            try
            {
                ResReader = new ResXResourceReader(resXName);
                foreach (DictionaryEntry d in ResReader)
                {
                    sender.Items.Add(d.Value);
                }
                ResReader.Close();
            }
            catch (FileNotFoundException fnfeEx)
            {
                MessageBox.Show("combox \r\n" + resXName + "\r\n 暫無內容，請連絡管理人" + fnfeEx.Message);
                return;
            }
            catch (ArgumentException caught)
            {
                MessageBox.Show("Source: " + caught.Source + "Message: " + caught.Message + "\r\n請連絡管理人");
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("發生不可預期錯誤，請連絡管理人");
                return;
            }
            finally
            {
                ResReader.Close();
            }
        }
        public void resXModify(string resXName, string ExplorerFileShortNameOrOptionKey, Image ExplorerFileImage, bool deleteSwitch, string infoValue,bool OptionKey)
        {
            var resx = new List<DictionaryEntry>();
            using (ResXResourceReader reader = new ResXResourceReader(resXName))
            {

                resx = reader.Cast<DictionaryEntry>().ToList();
                var existingResource = resx.Where(r => r.Key.ToString() == ExplorerFileShortNameOrOptionKey).FirstOrDefault();
                if (existingResource.Key == null && existingResource.Value == null) // NEW!
                {
                     if(OptionKey == true) { resx.Add(new DictionaryEntry() { Key = ExplorerFileShortNameOrOptionKey, Value = infoValue }); }
                    //if (ExplorerFileImage != null || deleteSwitch == true)
                    else
                    { resx.Add(new DictionaryEntry() { Key = ExplorerFileShortNameOrOptionKey, Value = ExplorerFileImage }); }
                }
                else // MODIFIED RESOURCE!
                {
                    DictionaryEntry modifiedResx = new DictionaryEntry();
                    if (OptionKey == true) { modifiedResx = new DictionaryEntry() { Key = existingResource.Key, Value = infoValue }; }
                    //if (ExplorerFileImage != null || deleteSwitch == true)
                    else
                    { modifiedResx = new DictionaryEntry() { Key = existingResource.Key, Value = ExplorerFileImage }; }
                    resx.Remove(existingResource);  // REMOVING RESOURCE!
                    if (!deleteSwitch) resx.Add(modifiedResx);  // AND THEN ADDING RESOURCE!
                }


            }
            using (ResXResourceWriter writer = new ResXResourceWriter(resXName))
            {
                resx.ForEach(r =>
                {
                    // Again Adding all resource to generate with final items
                     if (OptionKey == true) { writer.AddResource(r.Key.ToString(), r.Value.ToString()); }  //option或者combo在用的
                    //if (ExplorerFileImage != null || deleteSwitch == true)
                    else
                    { writer.AddResource(r.Key.ToString(), (Image)r.Value); }    //刪除模式時，圖是null的，所以會不跑 要把刪除時的狀態也要跑這條不然圖會變成字串記錄下次就會出錯了

                });
                writer.Generate();

            }
        }

        public void getResxLikeOptions(string resxDataName)
        {
            if (File.Exists(Application.StartupPath + @"\" + resxDataName))
            {
                var resx = new List<DictionaryEntry>();
                using (ResXResourceReader reader = new ResXResourceReader(resxDataName))
                {
                    resx = reader.Cast<DictionaryEntry>().ToList();
                    resx.ForEach(r =>
                    {
                        if (r.Key.ToString() == "comboboxWheel") { classForStatic.comboboxWheel = r.Value.ToString(); }
                    });
                }
            }
            else { MessageBox.Show("nooptionrex"); return; }
        }


    }
}
