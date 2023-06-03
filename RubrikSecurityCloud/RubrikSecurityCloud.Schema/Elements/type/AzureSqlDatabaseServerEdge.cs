// AzureSqlDatabaseServerEdge.cs
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
    #region AzureSqlDatabaseServerEdge
    public class AzureSqlDatabaseServerEdge: BaseType
    {
        #region members

        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        [JsonProperty("cursor")]
        public System.String? Cursor { get; set; }

        //      C# -> AzureSqlDatabaseServer? Node
        // GraphQL -> node: AzureSqlDatabaseServer! (type)
        [JsonProperty("node")]
        public AzureSqlDatabaseServer? Node { get; set; }


        #endregion

    #region methods

    public AzureSqlDatabaseServerEdge Set(
        System.String? Cursor = null,
        AzureSqlDatabaseServer? Node = null
    ) 
    {
        if ( Cursor != null ) {
            this.Cursor = Cursor;
        }
        if ( Node != null ) {
            this.Node = Node;
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
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        if (this.Cursor != null) {
            s += ind + "cursor\n" ;
        }
        //      C# -> AzureSqlDatabaseServer? Node
        // GraphQL -> node: AzureSqlDatabaseServer! (type)
        if (this.Node != null) {
            s += ind + "node {\n" + this.Node.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Cursor
        // GraphQL -> cursor: String! (scalar)
        if (this.Cursor == null && Exploration.Includes(parent + ".cursor", true))
        {
            this.Cursor = new System.String("FETCH");
        }
        //      C# -> AzureSqlDatabaseServer? Node
        // GraphQL -> node: AzureSqlDatabaseServer! (type)
        if (this.Node == null && Exploration.Includes(parent + ".node"))
        {
            this.Node = new AzureSqlDatabaseServer();
            this.Node.ApplyExploratoryFieldSpec(parent + ".node");
        }
    }


    #endregion

    } // class AzureSqlDatabaseServerEdge
    
    #endregion

    public static class ListAzureSqlDatabaseServerEdgeExtensions
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
            this List<AzureSqlDatabaseServerEdge> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureSqlDatabaseServerEdge> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureSqlDatabaseServerEdge());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types