using RehabilitationForm.utility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RehabilitationForm
{
    public partial class GroupActivityForm : Form
    {

        public string getStaffID(int id)
        {
            string result = "";
            try
            {
                List<ParamatsWithValueClass> lp = new List<ParamatsWithValueClass>();
                lp.Add(new ParamatsWithValueClass() { key = "K_id", value = id.ToString() });
                result = new Utility().exeScalar(@"select Employee.fName from [dbo].[Employee] where Employee.fid = @K_id", lp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("getStaffID Exception\r\n" + ex.Message);
                return null;
            }
            return result;
        }



    }

}



//=================================備用區

/*
     private void getComboxEmotionsData() { 

     }
     private void getComboxParticipatePersistenceData() {
         ResXResourceReader ParticipatePersistenceResReader = null;
         try
         {
             ParticipatePersistenceResReader = new ResXResourceReader("comboxParticipatePersistence.resx");
             foreach (DictionaryEntry d in ParticipatePersistenceResReader)
             {

             }
             ParticipatePersistenceResReader.Close();
         }
         catch (FileNotFoundException fnfeEx)
         {
             MessageBox.Show("combox暫無內容，請連絡管理人");
             return;
         }
         catch (ArgumentException caught)
         {
             MessageBox.Show("Source: " + caught.Source + "Message: " + caught.Message);
             return;
         }
         catch (Exception)
         {

             return;
         }
         finally
         {
             ParticipatePersistenceResReader.Close();
         }
     }
     private void getComboxCooperateData() { 
         ResXResourceReader CooperateResReader = null;
         try
         {
             CooperateResReader = new ResXResourceReader("comboxCooperate.resx");

             CooperateResReader.Close();
         }
         catch (FileNotFoundException fnfeEx)
         {
             MessageBox.Show("combox暫無內容，請連絡管理人");
             return;
         }
         catch (ArgumentException caught)
         {
             MessageBox.Show("Source: " + caught.Source + "Message: " + caught.Message);
             return;
         }
         catch (Exception)
         {

             return;
         }
         finally {
             CooperateResReader.Close();
         }

     }
     private void getComboxHumanInteractionData() {
         ResXResourceReader HumanInteractionResReader = null;
         try
         {
             HumanInteractionResReader = new ResXResourceReader("comboxHumanInteraction.resx");


             HumanInteractionResReader.Close();
         }
         catch (FileNotFoundException fnfeEx)
         {
             MessageBox.Show("combox暫無內容，請連絡管理人");
             return;
         }
         catch (ArgumentException caught)
         {
             MessageBox.Show("Source: " + caught.Source + "Message: " + caught.Message);
             return;
         }
         catch (Exception)
         {

             return;
         }
         finally
         {
             HumanInteractionResReader.Close();

         }

     }
     private void getComboxAttentionData() {
         ResXResourceReader AttentionResReader = null;
         try
         {
             AttentionResReader = new ResXResourceReader("comboxAttention.resx");


             AttentionResReader.Close();
         }
         catch (FileNotFoundException fnfeEx)
         {
             MessageBox.Show("combox暫無內容，請連絡管理人");
             return;
         }
         catch (ArgumentException caught)
         {
             MessageBox.Show("Source: " + caught.Source + "Message: " + caught.Message);
             return;
         }
         catch (Exception)
         {

             return;
         }
         finally
         {
             AttentionResReader.Close();

         }

     }
     private void getComboxParticipatePerformanceData()
     {

         ResXResourceReader ParticipatePerformanceResReader = null;
         try
         {
             ParticipatePerformanceResReader = new ResXResourceReader("comboxParticipatePerformance.resx");

             ParticipatePerformanceResReader.Close();
         }
         catch (FileNotFoundException fnfeEx)
         {
             MessageBox.Show("combox暫無內容，請連絡管理人");
             return;
         }
         catch (ArgumentException caught)
         {
             MessageBox.Show("Source: " + caught.Source + "Message: " + caught.Message);
             return;
         }
         finally
         { 
             ParticipatePerformanceResReader.Close();
         }

     }
*/


//==================================備用區2

/**/
/* 
            if (File.Exists(Application.StartupPath + @"\comboxParticipatePersistence.resx")) {
            
            } else {
                int count = 0;
                ResXResourceWriter ParticipatePersistenceWriter = new ResXResourceWriter("comboxParticipatePersistence.resx");
                ParticipatePersistenceWriter.AddResource($"{count++}", "高亢/興奮");
                ParticipatePersistenceWriter.AddResource($"{count++}", "愉快/平穩");
                ParticipatePersistenceWriter.AddResource($"{count++}", "淡漠/平板");
                ParticipatePersistenceWriter.AddResource($"{count++}", "焦慮/緊張");
                ParticipatePersistenceWriter.AddResource($"{count++}", "憤怒/煩躁");
                ParticipatePersistenceWriter.Close(); 
            }

            if (File.Exists(Application.StartupPath + @"\comboxCooperate.resx")) {
            
            } else { ResXResourceWriter CooperateWriter = new ResXResourceWriter("comboxCooperate.resx"); CooperateWriter.Close(); }

            if (File.Exists(Application.StartupPath + @"\comboxHumanInteraction.resx")) {
            
            } else { ResXResourceWriter HumanInteractionWriter = new ResXResourceWriter("comboxHumanInteraction.resx"); HumanInteractionWriter.Close(); }

            if (File.Exists(Application.StartupPath + @"\comboxAttentionRes.resx")) {
            
            } else { ResXResourceWriter AttentionWriter = new ResXResourceWriter("comboxAttentionRes.resx"); AttentionWriter.Close(); }

            if (File.Exists(Application.StartupPath + @"\comboxParticipatePerformance.resx")) { 
            
            } else { ResXResourceWriter ParticipatePerformanceWriter = new ResXResourceWriter("comboxParticipatePerformance.resx"); ParticipatePerformanceWriter.Close(); }     
 
 */


