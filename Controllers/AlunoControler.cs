
using ACDRJ_API.Entidade;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;

namespace AcadSistemAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {

        [HttpPost(Name = "CreateAluno")]
        public ActionResult CreateAluno(Aluno aluno)
        {
            if (aluno.Idade >= 18)
            {
                string resultado = "Sucesso";
                return Ok("Aluno cadastrado com sucesso");
            }

            else
            {
                string resultado = "Errado";
                return Ok("Aluno precisa de responsavel");


            }
        }

            [HttpGet(Name = "GetAluno")]  
            public ActionResult GetAluno ()
            {

                var ListaAlunos = new List<Aluno>();
            
                var alunoObject = new Aluno();
                alunoObject.Nome = "Daniel";
                alunoObject.Matricula = 763650900;
                ListaAlunos.Add(alunoObject);


                var alunoObject2 = new Aluno();
                alunoObject2.Nome = "Rafael";
                alunoObject2.Matricula = 652187764;
                ListaAlunos.Add (alunoObject2);

                var alunoObject3 = new Aluno();
                alunoObject3.Nome = "Leticia";
                alunoObject3.Matricula = 867454397;
            ListaAlunos.Add(alunoObject3);

                return Ok(ListaAlunos);

            }
            
            
            
        }
    }
