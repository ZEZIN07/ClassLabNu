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
        string _bairro;
        string _logradouro;
        string _localidade;

 
        public string UF
        {
            get { return _uf; }
        }
        public string Bairro
        {
            get { return _bairro; }
        }
        public string Lagradouro
        {
            get { return _logradouro; }
        }
        public string Localidade
        {
            get { return _localidade; }
        }


        #region "Construtor"  
        /// <summary>  
        /// WebService para Busca de CEP  
        ///  </summary>  
        /// <param  name="CEP"></param>  
        public WebCEP(string CEP)
        {
            _uf = "";
            _localidade = "";
            _bairro = "";
            _logradouro = "";

            //Cria um DataSet  baseado no retorno do XML  
            DataSet ds = new DataSet();
            ds.ReadXml("https://viacep.com.br/ws/" + CEP.Replace("-", "").Trim() + "/xml");

            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count > 0)
                {
                    _uf = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                    _localidade = ds.Tables[0].Rows[0]["localidade"].ToString().Trim();
                    _bairro = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
                    _logradouro = ds.Tables[0].Rows[0]["logradouro"].ToString().Trim(); _uf = ds.Tables[0].Rows[0]["uf"].ToString().Trim();
                    _localidade = ds.Tables[0].Rows[0]["localidade"].ToString().Trim();
                    _bairro = ds.Tables[0].Rows[0]["bairro"].ToString().Trim();
                }
            }            
        }
        #endregion
    }
}
