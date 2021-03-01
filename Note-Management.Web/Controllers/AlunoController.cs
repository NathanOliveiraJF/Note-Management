using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Note_Management.Web.Controllers
{
    public class AlunoController : Controller
    {
        public string Index()
        {
            return "This is my default action..";
        }

        //GET: /Aluno/Register
        public string Register()
        {
            return "this is the Register action method"
        }
    }
}
