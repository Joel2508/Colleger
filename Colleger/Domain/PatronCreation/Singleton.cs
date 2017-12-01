using Domain.CrudModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.PatronCreation
{
    public class Singleton
    {
        private static CrudEvaluacion instance;
        public static CrudEvaluacion GetInstanceCrudEvaluacion()
        {
            if (instance == null)
            {
                instance = new CrudEvaluacion();
            }
            return instance;
        }

    }
}
