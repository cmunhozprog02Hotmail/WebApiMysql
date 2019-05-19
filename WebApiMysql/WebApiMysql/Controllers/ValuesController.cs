using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiMysql.Util;


namespace WebApiMysql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            DAL objDAL = new DAL();
            /*string sql = "INSERT INTO cliente(nome, data_cadastro, cpf_cnpj, data_nascimento, tipo, telefone, email, cep, logradouro, numero, bairro, cidade, uf) VALUES('Christovam', '2019/05/19', '07537405832', '1967/10/05', 'f', '55612261', 'chris@chris.com', '04610060', 'ria um', '123', 'moema', 'São Paulo', 'sp')";
            objDAL.ExecutarComandoSQL(sql);
            */

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            DAL objDAL = new DAL();
            string sql = $"SELECT * FROM Cliente where id={id}";
            DataTable dados = objDAL.RetornarDataTable(sql);
            return dados.Rows[0]["Nome"].ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
