
/*Guillermo Andres Larrota Briñez 
 * Proyecto Informacion de Cargos 
 * Grupo 202016907_36
 * Ingenieria de Sistemas 
 * Codigo Fuente: Autoria propia
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; 


namespace banco
{
    public partial class Cuentas : Form
    {
        public Cuentas()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void id_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNum.SoloNumeros(e);
        }

        private void TxtConsig_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumPos.SoloNumeros(e);
        }

        private void TxtRet_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumPos.SoloNumeros(e);
        }

        private void TxtNumCuent_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNum.SoloNumeros(e);
        }

        private void BtnCli_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(id_cliente.Text);

                if (a > 0)
                {
                                       
                    
                    XmlDocument doc = new XmlDocument();
                    XmlElement raiz = doc.CreateElement("Clientes");
                    doc.AppendChild(raiz);

                    XmlElement cliente = doc.CreateElement("cliente");
                    raiz.AppendChild(cliente);

                    XmlElement idcliente = doc.CreateElement("id_cliente");
                    idcliente.AppendChild(doc.CreateTextNode(id_cliente.Text));
                    cliente.AppendChild(idcliente);

                    XmlElement NomApeCli = doc.CreateElement("Nom_Ape_Cli");
                    NomApeCli.AppendChild(doc.CreateTextNode(TxtNomApe.Text));
                    cliente.AppendChild(NomApeCli);
                    
                    XmlElement Cuidad = doc.CreateElement("cuidad");
                    Cuidad.AppendChild(doc.CreateTextNode(CmbCiudad.Text));
                    cliente.AppendChild(Cuidad);

                    XmlElement TipCuent = doc.CreateElement("Tip_Cuent");
                    TipCuent.AppendChild(doc.CreateTextNode(CmbTipCuent.Text));
                    cliente.AppendChild(TipCuent);

                    XmlElement NumCuent = doc.CreateElement("Num_Cuent");
                    NumCuent.AppendChild(doc.CreateTextNode(TxtNumCuent.Text));
                    cliente.AppendChild(NumCuent);

                    XmlElement saldo = doc.CreateElement("saldo");
                    saldo.AppendChild(doc.CreateTextNode(TxtSaldo.Text));
                    cliente.AppendChild(saldo);

                    XmlElement inf_cargo = doc.CreateElement("inf_carg");
                    inf_cargo.AppendChild(doc.CreateTextNode(Txt_Inf_Carg.Text));
                    cliente.AppendChild(inf_cargo);

                    
                    doc.Save(id_cliente.Text + ".Xml");

                    MessageBox.Show("Registro Guardado Corretamenmte en la carpeta Degug del proyecto, con el formato ID cargo.Xml ", "Mensaje del procceso");
                   
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Para Guardar el registro Debe Ingresar un Numero de  Cargo", "Mensaje del Programa");
            }
        }

        private void BntMovi_Click(object sender, EventArgs e)
        {
            
            try
            {
            
                double cli = Convert.ToDouble(id_cliente.Text);
                double con = Convert.ToDouble(TxtConsig.Text);
                double ret = Convert.ToDouble(TxtRet.Text);
                double sal = Convert.ToDouble(TxtSaldo.Text);

                double val = ((sal + con) - ret);

                if (cli > 0 )
                {
                   
                        if (val < 0)
                        {
                            MessageBox.Show("El valor del saldo no puede Negativo  ", "Mensaje del Porceso");
                        }  
                        
                        else
                         {

                        TxtSaldo.Text = val.ToString();

                        MessageBox.Show("Nuevo saldo Cargado, por favor guarde cambios antes de salir, con el formato ID Cliente.Xml ", "Mensaje del procceso");
                        

                        }
                   
                }
              
            }
            
            
            catch
            {
                MessageBox.Show("Para hacer una transaccion debe crear o consultar el cliente antes", "Mensaje del Programa");
            }
            

       


        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(id_cliente.Text);

                if (a > 0)
                {


                    XmlDocument doc = new XmlDocument();
                    XmlElement raiz = doc.CreateElement("Clientes");
                    doc.AppendChild(raiz);

                    XmlElement cliente = doc.CreateElement("cliente");
                    raiz.AppendChild(cliente);

                    XmlElement idcliente = doc.CreateElement("id_cliente");
                    idcliente.AppendChild(doc.CreateTextNode(id_cliente.Text));
                    cliente.AppendChild(idcliente);

                    XmlElement NomApeCli = doc.CreateElement("Nom_Ape_Cli");
                    NomApeCli.AppendChild(doc.CreateTextNode(TxtNomApe.Text));
                    cliente.AppendChild(NomApeCli);

                    XmlElement Cuidad = doc.CreateElement("cuidad");
                    Cuidad.AppendChild(doc.CreateTextNode(CmbCiudad.Text));
                    cliente.AppendChild(Cuidad);

                    XmlElement TipCuent = doc.CreateElement("Tip_Cuent");
                    TipCuent.AppendChild(doc.CreateTextNode(CmbTipCuent.Text));
                    cliente.AppendChild(TipCuent);

                    XmlElement NumCuent = doc.CreateElement("Num_Cuent");
                    NumCuent.AppendChild(doc.CreateTextNode(TxtNumCuent.Text));
                    cliente.AppendChild(NumCuent);

                    XmlElement saldo = doc.CreateElement("saldo");
                    saldo.AppendChild(doc.CreateTextNode(TxtSaldo.Text));
                    cliente.AppendChild(saldo);

                    XmlElement inf_cargo = doc.CreateElement("inf_carg");
                    inf_cargo.AppendChild(doc.CreateTextNode(Txt_Inf_Carg.Text));
                    cliente.AppendChild(inf_cargo);


                    doc.Save(id_cliente.Text + ".Xml");

                    MessageBox.Show("Registro Guardado Corretamenmte en la carpeta Degug del proyecto, con el formato ID Cargo.Xml ", "Mensaje del procceso");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Para Guardar el registro Debe Ingresar un Numero de  Cargo", "Mensaje del Programa");
            }
        }

        private void BtnConsulCli_Click(object sender, EventArgs e)
        {

            try

            {
                
                  
                XmlDocument doc = new XmlDocument();

                doc.Load(TextLoadName.Text);

                XmlNodeList lista = doc.SelectNodes("Clientes/cliente");

                XmlNode unCliente;

                for (int i = 0; i < lista.Count; i++)
                {
                    unCliente = lista.Item(i);

                    string idCliente = unCliente.SelectSingleNode("id_cliente").InnerText;
                    string NomApe = unCliente.SelectSingleNode("Nom_Ape_Cli").InnerText;
                    string cuidadcli = unCliente.SelectSingleNode("cuidad").InnerText;
                    string TipCuent = unCliente.SelectSingleNode("Tip_Cuent").InnerText;
                    string NumCuen = unCliente.SelectSingleNode("Num_Cuent").InnerText;
                    string Saldo = unCliente.SelectSingleNode("saldo").InnerText;
                    string inf_carg = unCliente.SelectSingleNode("inf_carg").InnerText;

                    id_cliente.Text = idCliente;
                    TxtNomApe.Text = NomApe;
                    CmbCiudad.Text = cuidadcli;
                    CmbTipCuent.Text = TipCuent;
                    TxtNumCuent.Text = NumCuen;
                    TxtSaldo.Text = Saldo;
                    Txt_Inf_Carg.Text = inf_carg; 

                }

            } catch (Exception)
            {
                MessageBox.Show("Por favor ingrese de cargo antes de consultar", "Mensaje del Programa");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            id_cliente.Clear();
            TxtNomApe.Clear();
            TxtNumCuent.Clear();
            TxtSaldo.Text = ("0");
            TxtConsig.Text = ("0");
            TxtRet.Text = ("0");
            Txt_Inf_Carg.Clear();

        }

        private void TextLoadName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TxtSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblIdCliente_Click(object sender, EventArgs e)
        {

        }

        private void LblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
