using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Rubrik.SecurityCloud.Types
{
    public interface IFragment
    {
        string AsFragment(int indent = 0);
        void ApplyExploratoryFragment(String parent="");
    }
}