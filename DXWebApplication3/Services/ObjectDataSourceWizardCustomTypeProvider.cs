using DevExpress.DataAccess.Web;
using System;
using System.Collections.Generic;

namespace DXWebApplication3.Services {
    public class ObjectDataSourceWizardCustomTypeProvider : IObjectDataSourceWizardTypeProvider {
        public IEnumerable<Type> GetAvailableTypes(string context) {
            return new[] { typeof(Employees.DataSource) };
        }
    }
}