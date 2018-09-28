using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_NORTHWND
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio
        [OperationContract]
        NORTHWND.Models.categoriaModel selectCategory(NORTHWND.Models.categoriaModel categoria);

        [OperationContract]
        List<NORTHWND.Models.categoriaModel> selectAllCategory();

        [OperationContract]
        int insertCategory(NORTHWND.Models.categoriaModel categoria);

        [OperationContract]
        int updateCategory(NORTHWND.Models.categoriaModel categoria);

        [OperationContract]
        int deleteCategory(NORTHWND.Models.categoriaModel categoria);

        [OperationContract]
        List<NORTHWND.Models.categoriaModel> searchNameCategory(NORTHWND.Models.categoriaModel categoria);

        [OperationContract]
        List<NORTHWND.Models.categoriaModel> searchDescriptionCategory(NORTHWND.Models.categoriaModel categoria);
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
