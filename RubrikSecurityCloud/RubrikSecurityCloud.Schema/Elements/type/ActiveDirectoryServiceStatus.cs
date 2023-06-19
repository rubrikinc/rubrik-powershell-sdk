// ActiveDirectoryServiceStatus.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region ActiveDirectoryServiceStatus
    public class ActiveDirectoryServiceStatus: BaseType
    {
        #region members

        //      C# -> ServiceStatus? ServiceStatus
        // GraphQL -> serviceStatus: ServiceStatus! (enum)
        [JsonProperty("serviceStatus")]
        public ServiceStatus? ServiceStatus { get; set; }

        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        [JsonProperty("timestampMillis")]
        public DateTime? TimestampMillis { get; set; }


        #endregion

    #region methods

    public ActiveDirectoryServiceStatus Set(
        ServiceStatus? ServiceStatus = null,
        DateTime? TimestampMillis = null
    ) 
    {
        if ( ServiceStatus != null ) {
            this.ServiceStatus = ServiceStatus;
        }
        if ( TimestampMillis != null ) {
            this.TimestampMillis = TimestampMillis;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ServiceStatus? ServiceStatus
        // GraphQL -> serviceStatus: ServiceStatus! (enum)
        if (this.ServiceStatus != null) {
            s += ind + "serviceStatus\n" ;
        }
        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        if (this.TimestampMillis != null) {
            s += ind + "timestampMillis\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ServiceStatus? ServiceStatus
        // GraphQL -> serviceStatus: ServiceStatus! (enum)
        if (this.ServiceStatus == null && Exploration.Includes(parent + ".serviceStatus", true))
        {
            this.ServiceStatus = new ServiceStatus();
        }
        //      C# -> DateTime? TimestampMillis
        // GraphQL -> timestampMillis: DateTime (scalar)
        if (this.TimestampMillis == null && Exploration.Includes(parent + ".timestampMillis", true))
        {
            this.TimestampMillis = new DateTime();
        }
    }


    #endregion

    } // class ActiveDirectoryServiceStatus
    
    #endregion

    public static class ListActiveDirectoryServiceStatusExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<ActiveDirectoryServiceStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectoryServiceStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectoryServiceStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types