// OraclePdbDetails.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region OraclePdbDetails
    public class OraclePdbDetails: BaseType
    {
        #region members

        //      C# -> List<System.String>? RegularPdbs
        // GraphQL -> regularPdbs: [String!]! (scalar)
        [JsonProperty("regularPdbs")]
        public List<System.String>? RegularPdbs { get; set; }

        //      C# -> List<OraclePdbApplicationContainer>? ApplicationContainers
        // GraphQL -> applicationContainers: [OraclePdbApplicationContainer!]! (type)
        [JsonProperty("applicationContainers")]
        public List<OraclePdbApplicationContainer>? ApplicationContainers { get; set; }


        #endregion

    #region methods

    public OraclePdbDetails Set(
        List<System.String>? RegularPdbs = null,
        List<OraclePdbApplicationContainer>? ApplicationContainers = null
    ) 
    {
        if ( RegularPdbs != null ) {
            this.RegularPdbs = RegularPdbs;
        }
        if ( ApplicationContainers != null ) {
            this.ApplicationContainers = ApplicationContainers;
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
        //      C# -> List<System.String>? RegularPdbs
        // GraphQL -> regularPdbs: [String!]! (scalar)
        if (this.RegularPdbs != null) {
            s += ind + "regularPdbs\n" ;
        }
        //      C# -> List<OraclePdbApplicationContainer>? ApplicationContainers
        // GraphQL -> applicationContainers: [OraclePdbApplicationContainer!]! (type)
        if (this.ApplicationContainers != null) {
            s += ind + "applicationContainers {\n" + this.ApplicationContainers.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<System.String>? RegularPdbs
        // GraphQL -> regularPdbs: [String!]! (scalar)
        if (this.RegularPdbs == null && Exploration.Includes(parent + ".regularPdbs", true))
        {
            this.RegularPdbs = new List<System.String>();
        }
        //      C# -> List<OraclePdbApplicationContainer>? ApplicationContainers
        // GraphQL -> applicationContainers: [OraclePdbApplicationContainer!]! (type)
        if (this.ApplicationContainers == null && Exploration.Includes(parent + ".applicationContainers"))
        {
            this.ApplicationContainers = new List<OraclePdbApplicationContainer>();
            this.ApplicationContainers.ApplyExploratoryFieldSpec(parent + ".applicationContainers");
        }
    }


    #endregion

    } // class OraclePdbDetails
    
    #endregion

    public static class ListOraclePdbDetailsExtensions
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
            this List<OraclePdbDetails> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OraclePdbDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OraclePdbDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types