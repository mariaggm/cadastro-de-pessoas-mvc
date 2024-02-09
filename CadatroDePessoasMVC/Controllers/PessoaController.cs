using CadatroDePessoasMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileSystemGlobbing.Internal.PathSegments;
using System.Data;
using System.Runtime.ConstrainedExecution;

namespace CadatroDePessoasMVC.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListaPessoas()
        {
            //to do: conectar o banco de dados, como nao temos
            //vamos criar dados fake

            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa { CPF = 15246252962, Nome = "maria", datanascimento = DateTime.Now.AddDays(25), Endereco = "aaaaaaaaa", telefone = 940359251, email = "maria.maiero@gmail.com", nomemae = "maria", sexo = "feminino", salario = 10000, cor = "parda" });
            pessoas.Add(new Pessoa { CPF = 15246252962, Nome = "maria", datanascimento = DateTime.Now.AddDays(25), Endereco = "aaaaaaaaa", telefone = 940359251, email = "maria.maiero@gmail.com", nomemae = "maria", sexo = "feminino", salario = 10000, cor = "parda" });
            pessoas.Add(new Pessoa { CPF = 15246252962, Nome = "maria", datanascimento = DateTime.Now.AddDays(25), Endereco = "aaaaaaaaa", telefone = 940359251, email = "maria.maiero@gmail.com", nomemae = "maria", sexo = "feminino", salario = 10000, cor = "parda" });
            
            return View(pessoas);

        }

        public IActionResult criarpessoas() 
        { 
            
            return View();
            
        }

    }
}
