// HasRelicAzureAdSnapshotReplyType.cs
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
    #region HasRelicAzureAdSnapshotReplyType
    public class HasRelicAzureAdSnapshotReplyType: BaseType
    {
        #region members

        //      C# -> System.Boolean? HasRelicSnapshots
        // GraphQL -> hasRelicSnapshots: Boolean! (scalar)
        [JsonProperty("hasRelicSnapshots")]
        public System.Boolean? HasRelicSnapshots { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HasRelicAzureAdSnapshotReplyType";
    }

    public HasRelicAzureAdSnapshotReplyType Set(
        System.Boolean? HasRelicSnapshots = null
    ) 
    {
        if ( HasRelicSnapshots != null ) {
            this.HasRelicSnapshots = HasRelicSnapshots;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Boolean? HasRelicSnapshots
        // GraphQL -> hasRelicSnapshots: Boolean! (scalar)
        if (this.HasRelicSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasRelicSnapshots\n" ;
            } else {
                s += ind + "hasRelicSnapshots\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? HasRelicSnapshots
        // GraphQL -> hasRelicSnapshots: Boolean! (scalar)
        if (ec.Includes("hasRelicSnapshots",true))
        {
            if(this.HasRelicSnapshots == null) {

                this.HasRelicSnapshots = true;

            } else {


            }
        }
        else if (this.HasRelicSnapshots != null && ec.Excludes("hasRelicSnapshots",true))
        {
            this.HasRelicSnapshots = null;
        }
    }


    #endregion

    } // class HasRelicAzureAdSnapshotReplyType
    
    #endregion

    public static class ListHasRelicAzureAdSnapshotReplyTypeExtensions
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
            this List<HasRelicAzureAdSnapshotReplyType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<HasRelicAzureAdSnapshotReplyType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HasRelicAzureAdSnapshotReplyType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HasRelicAzureAdSnapshotReplyType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HasRelicAzureAdSnapshotReplyType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types