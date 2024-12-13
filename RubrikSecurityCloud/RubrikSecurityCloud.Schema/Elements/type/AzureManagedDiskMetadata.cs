// AzureManagedDiskMetadata.cs
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
    #region AzureManagedDiskMetadata
 
    public class AzureManagedDiskMetadata: BaseType, ApplicationSpecificMetadata
    {
        #region members

        //      C# -> System.String? AttachedVmId
        // GraphQL -> attachedVmId: String! (scalar)
        [JsonProperty("attachedVmId")]
        public System.String? AttachedVmId { get; set; }

        //      C# -> System.String? AttachedVmName
        // GraphQL -> attachedVmName: String! (scalar)
        [JsonProperty("attachedVmName")]
        public System.String? AttachedVmName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureManagedDiskMetadata";
    }

    public AzureManagedDiskMetadata Set(
        System.String? AttachedVmId = null,
        System.String? AttachedVmName = null
    ) 
    {
        if ( AttachedVmId != null ) {
            this.AttachedVmId = AttachedVmId;
        }
        if ( AttachedVmName != null ) {
            this.AttachedVmName = AttachedVmName;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? AttachedVmId
        // GraphQL -> attachedVmId: String! (scalar)
        if (this.AttachedVmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attachedVmId\n" ;
            } else {
                s += ind + "attachedVmId\n" ;
            }
        }
        //      C# -> System.String? AttachedVmName
        // GraphQL -> attachedVmName: String! (scalar)
        if (this.AttachedVmName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "attachedVmName\n" ;
            } else {
                s += ind + "attachedVmName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AttachedVmId
        // GraphQL -> attachedVmId: String! (scalar)
        if (ec.Includes("attachedVmId",true))
        {
            if(this.AttachedVmId == null) {

                this.AttachedVmId = "FETCH";

            } else {


            }
        }
        else if (this.AttachedVmId != null && ec.Excludes("attachedVmId",true))
        {
            this.AttachedVmId = null;
        }
        //      C# -> System.String? AttachedVmName
        // GraphQL -> attachedVmName: String! (scalar)
        if (ec.Includes("attachedVmName",true))
        {
            if(this.AttachedVmName == null) {

                this.AttachedVmName = "FETCH";

            } else {


            }
        }
        else if (this.AttachedVmName != null && ec.Excludes("attachedVmName",true))
        {
            this.AttachedVmName = null;
        }
    }


    #endregion

    } // class AzureManagedDiskMetadata
    
    #endregion

    public static class ListAzureManagedDiskMetadataExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AzureManagedDiskMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureManagedDiskMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureManagedDiskMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureManagedDiskMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureManagedDiskMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types