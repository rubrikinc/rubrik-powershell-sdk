// EnableLambdaForSnappableReply.cs
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
    #region EnableLambdaForSnappableReply
    public class EnableLambdaForSnappableReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? DiffFmdEnabled
        // GraphQL -> diffFmdEnabled: Boolean! (scalar)
        [JsonProperty("diffFmdEnabled")]
        public System.Boolean? DiffFmdEnabled { get; set; }

        //      C# -> System.Boolean? FullFmdEnabled
        // GraphQL -> fullFmdEnabled: Boolean! (scalar)
        [JsonProperty("fullFmdEnabled")]
        public System.Boolean? FullFmdEnabled { get; set; }

        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        [JsonProperty("snappableFid")]
        public System.String? SnappableFid { get; set; }


        #endregion

    #region methods

    public EnableLambdaForSnappableReply Set(
        System.Boolean? DiffFmdEnabled = null,
        System.Boolean? FullFmdEnabled = null,
        System.String? SnappableFid = null
    ) 
    {
        if ( DiffFmdEnabled != null ) {
            this.DiffFmdEnabled = DiffFmdEnabled;
        }
        if ( FullFmdEnabled != null ) {
            this.FullFmdEnabled = FullFmdEnabled;
        }
        if ( SnappableFid != null ) {
            this.SnappableFid = SnappableFid;
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
        //      C# -> System.Boolean? DiffFmdEnabled
        // GraphQL -> diffFmdEnabled: Boolean! (scalar)
        if (this.DiffFmdEnabled != null) {
            s += ind + "diffFmdEnabled\n" ;
        }
        //      C# -> System.Boolean? FullFmdEnabled
        // GraphQL -> fullFmdEnabled: Boolean! (scalar)
        if (this.FullFmdEnabled != null) {
            s += ind + "fullFmdEnabled\n" ;
        }
        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        if (this.SnappableFid != null) {
            s += ind + "snappableFid\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? DiffFmdEnabled
        // GraphQL -> diffFmdEnabled: Boolean! (scalar)
        if (this.DiffFmdEnabled == null && Exploration.Includes(parent + ".diffFmdEnabled", true))
        {
            this.DiffFmdEnabled = true;
        }
        //      C# -> System.Boolean? FullFmdEnabled
        // GraphQL -> fullFmdEnabled: Boolean! (scalar)
        if (this.FullFmdEnabled == null && Exploration.Includes(parent + ".fullFmdEnabled", true))
        {
            this.FullFmdEnabled = true;
        }
        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        if (this.SnappableFid == null && Exploration.Includes(parent + ".snappableFid", true))
        {
            this.SnappableFid = "FETCH";
        }
    }


    #endregion

    } // class EnableLambdaForSnappableReply
    
    #endregion

    public static class ListEnableLambdaForSnappableReplyExtensions
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
            this List<EnableLambdaForSnappableReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<EnableLambdaForSnappableReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new EnableLambdaForSnappableReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types