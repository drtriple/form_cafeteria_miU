using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libRnCafeteria
{
    public class clsRnCafeteria
    {
        #region "Atributos"
        private string strDia;
        private float fltVrUnitLibra;
        private float fltCantLibrasNormal;
        private float fltCantLibrasQuincena;
        private float fltCantLibrasFestivo;
        private string strError;
        #endregion

        #region "Constructor"
        public clsRnCafeteria()
        {
            strDia = string.Empty;
            fltVrUnitLibra = 0;
            fltCantLibrasNormal = 0;
            fltCantLibrasQuincena = 0;
            fltCantLibrasFestivo = 0;
            strError = string.Empty;
        }
        #endregion

        #region "Propiedades"
        public string Dia
        {
            set => strDia = value;
        }

        public float ValorUnitarioLibra
        {
            get => fltVrUnitLibra;
        }

        public float CantidadLibrasNormal
        {
            get => fltCantLibrasNormal;
        }

        public float CantidadLibrasQuincena
        {
            get => fltCantLibrasQuincena;
        }

        public float CantidadLibrasFestivo
        {
            get => fltCantLibrasFestivo;
        }

        public string Error
        {
            get => strError;
        }
        #endregion

        #region "Métodos Privados"
        private bool Validar()
        {
            if (string.IsNullOrEmpty(strDia))
            {
                strError = "Debe seleccionar un día de la semana";
                return false;
            }
            return true;
        }

        private bool LeerArchivo()
        {
            try
            {
                string strPath = AppDomain.CurrentDomain.BaseDirectory + @"pedidos.txt";
                int intCantReg = 0;
                string strDiaLeido;
                float fltVrUnitLeido, fltCantNormalLeido, fltCantQuincenaLeido, fltCantFestivoLeido;
                string strLinea;
                string[] vectorLinea;

                intCantReg = File.ReadAllLines(strPath).Length;
                if (intCantReg <= 0)
                    return true;

                StreamReader Archivo = new StreamReader(@strPath);
                while ((strLinea = Archivo.ReadLine()) != null)
                {
                    vectorLinea = strLinea.Split('|');

                    strDiaLeido = vectorLinea[0];
                    fltVrUnitLeido = Convert.ToSingle(vectorLinea[1]);
                    fltCantNormalLeido = Convert.ToSingle(vectorLinea[2]);
                    fltCantQuincenaLeido = Convert.ToSingle(vectorLinea[3]);
                    fltCantFestivoLeido = Convert.ToSingle(vectorLinea[4]);

                    if (strDia.Equals(strDiaLeido, StringComparison.OrdinalIgnoreCase))
                    {
                        fltVrUnitLibra = fltVrUnitLeido;
                        fltCantLibrasNormal = fltCantNormalLeido;
                        fltCantLibrasQuincena = fltCantQuincenaLeido;
                        fltCantLibrasFestivo = fltCantFestivoLeido;
                        break;
                    }
                }

                Archivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }
        #endregion

        #region "Métodos Públicos"
        public bool ObtenerDatosDia()
        {
            if (!Validar())
                return false;
            return LeerArchivo();
        }
        #endregion
    }
}
