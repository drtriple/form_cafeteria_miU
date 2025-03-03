using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Referenciar y Usar
using libRnCafeteria;

namespace libOpeCafeteria
{
    public class clsOpeCafeteria
    {
        #region "Atributos"
        private string strDia;
        private bool blnEsQuincena;
        private bool blnEsFestivo;
        private float fltVrUnitLibra;
        private float fltCantLibrasNormal;
        private float fltCantLibrasAdicional;
        private float fltCantLibrasTotal;
        private float fltValorTotalPagar;
        private string strError;
        #endregion

        #region "Constructor"
        public clsOpeCafeteria()
        {
            strDia = string.Empty;
            blnEsQuincena = false;
            blnEsFestivo = false;
            fltVrUnitLibra = 0;
            fltCantLibrasNormal = 0;
            fltCantLibrasAdicional = 0;
            fltCantLibrasTotal = 0;
            fltValorTotalPagar = 0;
            strError = string.Empty;
        }
        #endregion

        #region "Propiedades"
        // Entradas
        public string Dia
        {
            set { strDia = value; }
        }

        public bool EsQuincena
        {
            set { blnEsQuincena = value; }
        }

        public bool EsFestivo
        {
            set { blnEsFestivo = value; }
        }

        // Salidas
        public float ValorUnitarioLibra
        {
            get { return fltVrUnitLibra; }
        }

        public float CantidadLibrasNormal
        {
            get { return fltCantLibrasNormal; }
        }

        public float CantidadLibrasAdicional
        {
            get { return fltCantLibrasAdicional; }
        }

        public float CantidadLibrasTotal
        {
            get { return fltCantLibrasTotal; }
        }

        public float ValorTotalPagar
        {
            get { return fltValorTotalPagar; }
        }

        public string Error
        {
            get { return strError; }
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
        #endregion

        #region "Métodos Públicos"
        public bool CalcularPedido()
        {
            try
            {
                if (!Validar())
                    return false;

                // Crear objeto RN
                clsRnCafeteria rn = new clsRnCafeteria();

                // Enviar información a RN
                rn.Dia = strDia;

                // Invocar método y tratamiento de error
                if (!rn.ObtenerDatosDia())
                {
                    strError = rn.Error;
                    rn = null;
                    return false;
                }

                // Recuperar información
                fltVrUnitLibra = rn.ValorUnitarioLibra;
                fltCantLibrasNormal = rn.CantidadLibrasNormal;
                float fltCantLibrasQuincena = rn.CantidadLibrasQuincena;
                float fltCantLibrasFestivo = rn.CantidadLibrasFestivo;
                rn = null;

                // Procesar
                fltCantLibrasAdicional = 0;

                if (blnEsQuincena)
                    fltCantLibrasAdicional += fltCantLibrasQuincena;

                if (blnEsFestivo)
                    fltCantLibrasAdicional += fltCantLibrasFestivo;

                fltCantLibrasTotal = fltCantLibrasNormal + fltCantLibrasAdicional;
                fltValorTotalPagar = fltCantLibrasTotal * fltVrUnitLibra;

                return true;
            }
            catch (Exception ex)
            {
                strError = "Error en CalcularPedido: " + ex.Message;
                return false;
            }
        }
        #endregion
    }
}
