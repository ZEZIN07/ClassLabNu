using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ClassLabNu
{
    public class WebCEP
    {  
        string _uf;
        string _cidade;
        string _bairro;
        string _logradouro;
        string _resultado;
        string _resultato_txt;
 
        public string UF
        {
            get { return _uf; }
        }
        public string Cidade
        {
            get { return _cidade; }
        }
        public string Bairro
        {
            get { return _bairro; }
        }
        public string Lagradouro
        {
            get { return _logradouro; }
        }
        public string Resultado
        {
            get { return _resultado; }
        }
        public string ResultadoTXT
        {
            get { return _resultato_txt; }
        }


        #region "Construtor"  
        /// <summary>  
        /// WebService para Busca de CEP  
        ///  </summary>  
        /// <param  name="CEP"></param>  
        public WebCEP(string CEP)
        {
            _uf = "";
            _cidade = "";
            _bairro = "";
            _logradouro = "";
            _resultado = "0";
            _resultato_txt = "CEP não encontrado";

            //Cria um DataSet  baseado no retorno do XML  
            DataSet ds = new DataSet();
            ds.ReadXml("http://cep.republicavirtual.com.br/web_cep.php?cep=" + CEP.Replace("-", "").Trim() + "&formato=xml");

            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    _resultado = ds.Tables[0].Rows[0]["resultado"].ToString();
                    switch (_resultado)
                    {
                        case "1":
                            _uf = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                            _cidade = ds.Tables[0].Rows[0]["cidade"].ToString().Trim();
                            _bairro = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
                            _logradouro = ds.Tables[0].Rows[0]["logradouro"].ToString().Trim();
                            _resultato_txt = "CEP completo";
                            break;
                        case "2":
                            _uf = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                            _cidade = ds.Tables[0].Rows[0]["cidade"].ToString().Trim();
                            _bairro = "";
                            _logradouro = "";
                            _resultato_txt = "CEP  único";
                            break;
                        default:
                            _uf = "";
                            _cidade = "";
                            _bairro = "";
                            _logradouro = "";
                            _resultato_txt = "CEP não  encontrado";
                            break;

                    }
                }
            }            
        }
        #endregion
    }
}
