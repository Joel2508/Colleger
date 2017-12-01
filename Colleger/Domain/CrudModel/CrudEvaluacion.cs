namespace Domain.CrudModel
{
    using Domain.Data;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class CrudEvaluacion
    {
      
        public void InserEvaluacion(TBA_Evaluaciones tbaEva)
        {
            using (var db = new CollegerEntities())
            {
                db.TBA_Evaluaciones.Add(tbaEva);
                db.SaveChanges();
            }
        }

        public void UpdateEvaluacion(TBA_Evaluaciones tbaEva)
        {
            using (var db = new CollegerEntities())
            {
                var evaluacion = db.TBA_Evaluaciones.FirstOrDefault(
                    tb => tb.idEvaluacion == tbaEva.idEvaluacion);
                db.Entry(evaluacion).State = EntityState.Modified;
                db.Entry(evaluacion).CurrentValues.SetValues(tbaEva);
                db.SaveChanges();
            }
        }

        public void  DeleteEvaluacion(int idEvaluacion)
        {
            using (var db = new CollegerEntities())
            {
                var evaluacion = db.TBA_Evaluaciones.FirstOrDefault(tb => tb.idEvaluacion == idEvaluacion.ToString());
                db.Entry(evaluacion).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<TBA_Evaluaciones> SelectEvaluacion()
        {
            using(var db = new CollegerEntities())
            {
                var qry = from e in db.TBA_Evaluaciones
                          select e;
                return qry.ToList();
            }
        }
    }
}
