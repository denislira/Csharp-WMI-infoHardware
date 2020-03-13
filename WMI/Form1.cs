using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace WMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            #region TEMPO DE Atualização
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 2000;//5 minutes
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
            #endregion

   #region NOME do PC
    ManagementObjectSearcher objMOS3 = new
    ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM  Win32_ComputerSystem"); ;
    foreach (ManagementObject objManag in objMOS3.Get())
        lb_nome_pc.Text = (objManag.GetPropertyValue("Name").ToString());
    #endregion
    #region MAC
    try
    {//MAC
        ManagementObjectSearcher objMOS5 = new
        ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM  Win32_NetworkAdapter WHERE NetEnabled=true");
        foreach (ManagementObject objManag in objMOS5.Get())
            lb_mac.Text = (objManag.GetPropertyValue("MACAddress").ToString());
    }
    catch (NullReferenceException) { lb_mac.Text = ("Essa referencia é Vazia"); }
    #endregion
    #region INTERNET True
    ManagementObjectSearcher objMOS4 = new
ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM  Win32_NetworkAdapter Where NetEnabled=true");
    foreach (ManagementObject objManag in objMOS4.Get())

        lb_internet.Text = (objManag.GetPropertyValue("NetEnabled").ToString());
    #endregion

    

            ManagementObjectSearcher objMOS = new
                ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM  Win32_CacheMemory");
            foreach (ManagementObject objManag in objMOS.Get())

                listBox1.Items.Add("Memória: " + objManag.GetPropertyValue("InstalledSize").ToString());
            //-----------------------------------
            ManagementObjectSearcher objMOS2 = new
                ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM  Win32_DiskDrive");
            foreach (ManagementObject objManag in objMOS2.Get())

                listBox1.Items.Add("HD modelo: " + objManag.GetPropertyValue("Model").ToString());
            //-----------------------------------

 
            //-----------------------------------

}//<<<fim initializeComponent Form1*******************FIM Inicialização*******************---------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------


#region CONEXÃO com BANCO de DADOS
        public void Form1_Load(object sender, EventArgs e)
        {
            /*   string host = "192.168.0.221";
               string database = "S8_Real";
               string user = "sa";
               string password = "Senha123";
               string Caminho_banco = "Data Source=" + host + ";Database=" + database + ";User ID=" + user + ";Password=" + password;

               try
               {
                   SqlConnection Conexao = new SqlConnection(Caminho_banco);
                   Conexao.Open();

                   if (Conexao.State.ToString() == "Open")
                   {
                       //MessageBox.Show("ok!");
                       status.Text = "Conectado";
                    
                    /*SELECT 
                       SqlCommand cmd = new SqlCommand("SELECT * FROM  Ordem_Servico WHERE Situacao = 'Diagnosticada'", Conexao);
                       SqlDataReader dr = cmd.ExecuteReader();
                       while (dr.Read())
                       {
                           listBox1.Items.Add(dr["Problema1"]);
                       }//Fim Select




                   }
               }
               catch (Exception er)
               {
                   MessageBox.Show("Erro ao conectar: " + er.Message);
               } */

        }//fim Conexao
      #endregion
        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            RefreshMyForm();
            #region NOME do PC
            ManagementObjectSearcher objMOS3 = new
            ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM  Win32_ComputerSystem"); ;
            foreach (ManagementObject objManag in objMOS3.Get())
                lb_nome_pc.Text = (objManag.GetPropertyValue("Name").ToString());
            #endregion
            #region MAC
            try
            {//MAC
                ManagementObjectSearcher objMOS5 = new
                ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM  Win32_NetworkAdapter WHERE NetEnabled=true");
                foreach (ManagementObject objManag in objMOS5.Get())
                    lb_mac.Text = (objManag.GetPropertyValue("MACAddress").ToString());
            }
            catch (NullReferenceException) { lb_mac.Text = ("Essa referencia é Vazia"); }
            #endregion
            #region INTERNET True
            ManagementObjectSearcher objMOS4 = new
        ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM  Win32_NetworkAdapter Where NetEnabled=true");
            foreach (ManagementObject objManag in objMOS4.Get())

                lb_internet.Text = (objManag.GetPropertyValue("NetEnabled").ToString());
            #endregion
        }

 private void timer1_Tick(object sender, EventArgs e)
{
     RefreshMyForm();
}

private void RefreshMyForm()
{
    #region Endereço IP
        ManagementObjectSearcher NetworkSearcher = new
        ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM  Win32_NetworkAdapterConfiguration WHERE IPEnabled=true");
        foreach (ManagementObject NetworkObj in NetworkSearcher.Get())
        {
            String[] arrIPAddress = (String[])(NetworkObj["IPAddress"]);
            lb_ip.Text = (arrIPAddress[0]);
        }
    #endregion

        
}//FIm REfresh











    
    }//fim Form1

  }//fim