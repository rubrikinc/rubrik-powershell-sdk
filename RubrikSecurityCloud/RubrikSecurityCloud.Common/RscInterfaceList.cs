using System.Collections.Generic;

namespace RubrikSecurityCloud.Types
{
    public class RscInterfaceList<T>: RscInterface<T> where T: IFieldSpec
    {
        public RscInterfaceList(): base() { }
        public RscInterfaceList(IEnumerable<T> collection): base(collection) { }
    }
}
