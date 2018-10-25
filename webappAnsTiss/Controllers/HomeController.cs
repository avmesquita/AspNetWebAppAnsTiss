using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webappAnsTiss.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ANSText()
        {
            /*
            wsTissComunicacaoBeneficiario.comunicacaoBeneficiarioWS cliente = new wsTissComunicacaoBeneficiario.comunicacaoBeneficiarioWS();
            cliente.cabecalho = new wsTissComunicacaoBeneficiario.cabecalhoTransacao();
            cliente.cabecalho.loginSenhaPrestador = new wsTissComunicacaoBeneficiario.ct_loginSenha() { loginPrestador = "", senhaPrestador = ""};
            cliente.comunicacaoBeneficiario.dadosBeneficiario = new wsTissComunicacaoBeneficiario.ct_beneficiarioDados() { nomeBeneficiario = "João" };
            cliente.comunicacaoBeneficiario.dadosInternacao = new wsTissComunicacaoBeneficiario.ctm_beneficiarioComunicacaoDadosInternacao() { Item = new object() };
            cliente.comunicacaoBeneficiario.dataEvento = new DateTime();
            cliente.comunicacaoBeneficiario.tipoEvento = wsTissComunicacaoBeneficiario.dm_tipoEvento.A;
            cliente.Signature = new wsTissComunicacaoBeneficiario.Signature() { Id = 0, SignatureValue = new wsTissComunicacaoBeneficiario.SignatureValueType() { Id = "0" } };
            */

            // [...]

            return View();
        }

    }
}