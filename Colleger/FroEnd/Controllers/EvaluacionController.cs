using Domain.CrudModel;
using Domain.Data;
using Domain.PatronCreation;
using FroEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FroEnd.Controllers
{
    public class EvaluacionController : Controller
    {
        // GET: Evaluacion
        public ActionResult Index(TBA_EvaluacionView view)
        {
            var singleton = Singleton.GetInstanceCrudEvaluacion().SelectEvaluacion();
            return View(singleton);
        }

        private TBA_Evaluaciones ToViewEvaluacion(TBA_EvaluacionView view)
        {
            return new TBA_Evaluaciones
            {
                bFinal= view.bFinal,
                bMostrarBoletin = view.bMostrarBoletin,
                bMostrarConducta = view.bMostrarConducta,
                bMostrarIndice = view.bMostrarIndice,
                bMostrarPromedio = view.bMostrarPromedio,
                bPromediable = view.bPromediable,
                FechaFinAsistencia = view.FechaFinAsistencia,
                FechaInicioAsistencia = view.FechaInicioAsistencia,
                FechaInicioDigitacion = view.FechaInicioDigitacion,
                FechaLimiteDigitacion = view.FechaLimiteDigitacion,
                FechaPublicacion = view.FechaPublicacion,
                Formula = view.Formula,
                FormulaConducta = view.FormulaConducta,
                idCurso = view.idCurso,
                idEvaluacion = view.idEvaluacion,
                idPeriodo = view.idPeriodo,
                idSemestre = view.idSemestre,
                idTipoEvaluacion = view.idTipoEvaluacion,
                Nombre = view.Nombre,
                Orden = view.Orden,
                OrdenActa = view.OrdenActa,
                OrdenPrefijoGrupal = view.OrdenPrefijoGrupal,
                Prefijo = view.Prefijo,
                PrefijoGrupal = view.PrefijoGrupal,
                Tipo = view.Tipo,
            };
        }
    }
}