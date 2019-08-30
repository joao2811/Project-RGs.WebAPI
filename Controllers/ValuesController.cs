using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto1.Data;
using Projeto1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;
using Microsoft.AspNetCore.Http;

namespace Projeto1.Controllers
{
    [Route("info/[controller]")]
    [ApiController]
    public class RgController : ControllerBase
    {
        public readonly DataContext _context;
        public RgController(DataContext context){
            this._context = context;
        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {            
            try{
                return Ok(await _context.RGs.ToListAsync());
            }
            catch(Exception ex){
                Console.WriteLine("Error: " + ex.Message);
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha na busca ao banco de dados.");
            }
            #region Dados
            /*return new RG[] { 
                new RG(){
                    RgId = 1,
                    RgNome = "Bento Jorge Viana",
                    RgNomeMae = "Olivia Priscila",
                    RgNomePai = "Caleb Luiz Viana",
                    RgNaturalidade = "RS - Esteio",
                    RgDataDeNascimento = new DateTime(1945,08,17),
                    RgNumber = "24.862.097-6",
                    RgCpf = "242.025.724-32"
                },
                new RG(){
                    RgId = 2,
                    RgNome = "Edson Guilherme Santos",
                    RgNomeMae = "Gabrielly Nair Luiza",
                    RgNomePai = "Elias Luís Nelson Santos",
                    RgNaturalidade = "DF - Brasilia",
                    RgDataDeNascimento = new DateTime(1980,09,02),
                    RgNumber = "13.053.811-5",
                    RgCpf = "326.290.007-96"
                },
                new RG(){
                    RgId = 3,
                    RgNome = "Renato Lorenzo Martin Almada",
                    RgNomeMae = "Maya Letícia",
                    RgNomePai = "Renan Ricardo Hugo Almada",
                    RgNaturalidade = "MS - Campo Grande",
                    RgDataDeNascimento = new DateTime(1963,06,23),
                    RgNumber = "49.018.676-2",
                    RgCpf = "777.655.479-09"
                },
                new RG(){
                    RgId = 4,
                    RgNome = "Paulo Fábio Novaes",
                    RgNomeMae = "Ayla Alícia Vanessa",
                    RgNomePai = "Victor João Antonio Novaes",
                    RgNaturalidade = "MS - Campo Grande",
                    RgDataDeNascimento = new DateTime(1950,05,27),
                    RgNumber = "41.128.904-4",
                    RgCpf = "574.734.638-53"
                },
                new RG(){
                    RgId = 5,
                    RgNome = "Diego André Bernardes",
                    RgNomeMae = "Esther Laura",
                    RgNomePai = "Gabriel Anthony Breno Bernardes",
                    RgNaturalidade = "MS - Campo Grande",
                    RgDataDeNascimento = new DateTime(1952,05,19),
                    RgNumber = "19.872.742-2",
                    RgCpf = "970.695.549-66"
                },
            };*/
            #endregion
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try{
                return Ok(await _context.RGs.FirstOrDefaultAsync(x => x.RgId == id));
            }
            catch(Exception ex){
                Console.WriteLine("Erro: " + ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Falha na busca ao banco de dados.");
            }
            #region Dados
            /*return new RG[] { 
                new RG(){
                    RgId = 1,
                    RgNome = "Bento Jorge Viana",
                    RgNomeMae = "Olivia Priscila",
                    RgNomePai = "Caleb Luiz Viana",
                    RgNaturalidade = "RS - Esteio",
                    RgDataDeNascimento = new DateTime(1945,08,17),
                    RgNumber = "24.862.097-6",
                    RgCpf = "242.025.724-32"
                },
                new RG(){
                    RgId = 2,
                    RgNome = "Edson Guilherme Santos",
                    RgNomeMae = "Gabrielly Nair Luiza",
                    RgNomePai = "Elias Luís Nelson Santos",
                    RgNaturalidade = "DF - Brasilia",
                    RgDataDeNascimento = new DateTime(1980,09,02),
                    RgNumber = "13.053.811-5",
                    RgCpf = "326.290.007-96"
                },
                new RG(){
                    RgId = 3,
                    RgNome = "Renato Lorenzo Martin Almada",
                    RgNomeMae = "Maya Letícia",
                    RgNomePai = "Renan Ricardo Hugo Almada",
                    RgNaturalidade = "MS - Campo Grande",
                    RgDataDeNascimento = new DateTime(1963,06,23),
                    RgNumber = "49.018.676-2",
                    RgCpf = "777.655.479-09"
                },
                new RG(){
                    RgId = 4,
                    RgNome = "Paulo Fábio Novaes",
                    RgNomeMae = "Ayla Alícia Vanessa",
                    RgNomePai = "Victor João Antonio Novaes",
                    RgNaturalidade = "MS - Campo Grande",
                    RgDataDeNascimento = new DateTime(1950,05,27),
                    RgNumber = "41.128.904-4",
                    RgCpf = "574.734.638-53"
                },
                new RG(){
                    RgId = 5,
                    RgNome = "Diego André Bernardes",
                    RgNomeMae = "Esther Laura",
                    RgNomePai = "Gabriel Anthony Breno Bernardes",
                    RgNaturalidade = "MS - Campo Grande",
                    RgDataDeNascimento = new DateTime(1952,05,19),
                    RgNumber = "19.872.742-2",
                    RgCpf = "970.695.549-66"
                },
            }.FirstOrDefault(x => x.RgId == id);*/
            #endregion
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
