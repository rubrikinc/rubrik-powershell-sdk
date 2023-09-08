using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace RubrikSecurityCloud
{
    public class RscOp
    {
        public string CmdletName { get; set; }
        public string CmdletSwitchName { get; set; }
        public string GqlRootFieldName { get; set; }

        public RscOp(
            string cmdletName = "",
            string cmdletSwitchName = "",
            string gqlRootFieldName = "")
        {
            this.CmdletName = cmdletName;
            this.CmdletSwitchName = cmdletSwitchName;
            this.GqlRootFieldName = gqlRootFieldName;
        }

        public string InvokeInfo()
        {
            if (string.IsNullOrEmpty(this.CmdletName))
            {
                return "";
            }
            if (string.IsNullOrEmpty(this.CmdletSwitchName))
            {
                return this.CmdletName;
            }
            return $"{this.CmdletName} -{this.CmdletSwitchName}";
        }

        public override string ToString()
        {
            return this.InvokeInfo();
        }
    }
}