using System;
using System.Windows.Forms;
using QuilaChiles.Business.General;
using QuilaChiles.Business.Utilidades;
using SmartQuilaChiles.Configuracion;
using SmartQuilaChiles.General;

namespace SmartQuilaChiles
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool terminar = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SettingsApplication applicationSettings = new SettingsApplication();
            while (applicationSettings.Properties.PrimeraArranque)
            {
                if (
                    Mensajes.Confirmacion(
                        "El programa se ha ejecutado por primera vez y requiere ser configurado\n¿Desea continuar?",
                        "Eduardo Cerritos Licea") == DialogResult.Yes)
                {
                    Application.Run(new FrmFirstTime(applicationSettings));
                    applicationSettings.LoadSettings();
                }
                else
                {
                    terminar = true;
                    applicationSettings.Properties.PrimeraArranque = false;
                }
            }
            if (terminar) return;
            FrmSplashScreen.ShowSplashScreen(Imagenes.ByteToImagen(applicationSettings.Properties.SplasImage));
            System.Threading.Thread.Sleep(500);
            //FrmSplashScreen.SetStatus("Inizializando...");
            //System.Threading.Thread.Sleep(1500);
            //FrmSplashScreen.SetStatus("Cargando configuracion...");
            //System.Threading.Thread.Sleep(1500);
            //FrmSplashScreen.SetStatus("cagandola...");
            //System.Threading.Thread.Sleep(1500);
            //foreach (var type in  Enum.GetValues(typeof(Enumeradores.PantallasEnum)))
            //{
            //    FrmSplashScreen.SetStatus("Cargando modulo " + type +D:\resp\Mis Documentos\tmpNet\SmartQuilaChiles\SmartQuilaChiles\Program.cs "...");
            //    System.Threading.Thread.Sleep(500);
            //}
            //Application.Run(new FrmLogin(applicationSettings));



            Application.Run(new FrmConfiguracion(applicationSettings));
        }
    }
}
