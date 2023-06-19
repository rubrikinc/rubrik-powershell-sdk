using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace RubrikSecurityCloud.Types
{
    public interface IFieldSpec
    {
        string AsFieldSpec(int indent = 0);
        void ApplyExploratoryFieldSpec(string parent = "");
    }
}
