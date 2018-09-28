using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_NORTHWND
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        private NORTHWND.Managers.categoriaManager categoriaManager = new NORTHWND.Managers.categoriaManager();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        public NORTHWND.Models.categoriaModel selectCategory(NORTHWND.Models.categoriaModel categoria) {
            return categoriaManager.select(categoria);
        }
        public List<NORTHWND.Models.categoriaModel> selectAllCategory() {
            return categoriaManager.selectAll();
        }
        public int insertCategory(NORTHWND.Models.categoriaModel categoria) {
            return categoriaManager.insert(categoria);
        }

        public int updateCategory(NORTHWND.Models.categoriaModel categoria) {
            return categoriaManager.update(categoria);
        }

        public int deleteCategory(NORTHWND.Models.categoriaModel categoria) {
            return categoriaManager.delete(categoria);
        }
        public List<NORTHWND.Models.categoriaModel> searchNameCategory(NORTHWND.Models.categoriaModel categoria) {
            return categoriaManager.searchName(categoria);
        }

        public List<NORTHWND.Models.categoriaModel> searchDescriptionCategory(NORTHWND.Models.categoriaModel categoria) {
            return categoriaManager.searchDescription(categoria);
        }
    }
}
