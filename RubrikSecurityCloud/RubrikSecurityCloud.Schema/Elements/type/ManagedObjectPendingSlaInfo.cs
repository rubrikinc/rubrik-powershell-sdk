// ManagedObjectPendingSlaInfo.cs
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
    #region ManagedObjectPendingSlaInfo
    public class ManagedObjectPendingSlaInfo: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsPendingSlaDomainRetentionLocked
        // GraphQL -> isPendingSlaDomainRetentionLocked: Boolean (scalar)
        [JsonProperty("isPendingSlaDomainRetentionLocked")]
        public System.Boolean? IsPendingSlaDomainRetentionLocked { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> System.String? PendingSlaDomainId
        // GraphQL -> pendingSlaDomainId: String! (scalar)
        [JsonProperty("pendingSlaDomainId")]
        public System.String? PendingSlaDomainId { get; set; }

        //      C# -> System.String? PendingSlaDomainName
        // GraphQL -> pendingSlaDomainName: String! (scalar)
        [JsonProperty("pendingSlaDomainName")]
        public System.String? PendingSlaDomainName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ManagedObjectPendingSlaInfo";
    }

    public ManagedObjectPendingSlaInfo Set(
        System.Boolean? IsPendingSlaDomainRetentionLocked = null,
        System.String? ObjectId = null,
        System.String? PendingSlaDomainId = null,
        System.String? PendingSlaDomainName = null
    ) 
    {
        if ( IsPendingSlaDomainRetentionLocked != null ) {
            this.IsPendingSlaDomainRetentionLocked = IsPendingSlaDomainRetentionLocked;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( PendingSlaDomainId != null ) {
            this.PendingSlaDomainId = PendingSlaDomainId;
        }
        if ( PendingSlaDomainName != null ) {
            this.PendingSlaDomainName = PendingSlaDomainName;
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
        //      C# -> System.Boolean? IsPendingSlaDomainRetentionLocked
        // GraphQL -> isPendingSlaDomainRetentionLocked: Boolean (scalar)
        if (this.IsPendingSlaDomainRetentionLocked != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isPendingSlaDomainRetentionLocked\n" ;
            } else {
                s += ind + "isPendingSlaDomainRetentionLocked\n" ;
            }
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectId\n" ;
            } else {
                s += ind + "objectId\n" ;
            }
        }
        //      C# -> System.String? PendingSlaDomainId
        // GraphQL -> pendingSlaDomainId: String! (scalar)
        if (this.PendingSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingSlaDomainId\n" ;
            } else {
                s += ind + "pendingSlaDomainId\n" ;
            }
        }
        //      C# -> System.String? PendingSlaDomainName
        // GraphQL -> pendingSlaDomainName: String! (scalar)
        if (this.PendingSlaDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingSlaDomainName\n" ;
            } else {
                s += ind + "pendingSlaDomainName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? IsPendingSlaDomainRetentionLocked
        // GraphQL -> isPendingSlaDomainRetentionLocked: Boolean (scalar)
        if (ec.Includes("isPendingSlaDomainRetentionLocked",true))
        {
            if(this.IsPendingSlaDomainRetentionLocked == null) {

                this.IsPendingSlaDomainRetentionLocked = true;

            } else {


            }
        }
        else if (this.IsPendingSlaDomainRetentionLocked != null && ec.Excludes("isPendingSlaDomainRetentionLocked",true))
        {
            this.IsPendingSlaDomainRetentionLocked = null;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (ec.Includes("objectId",true))
        {
            if(this.ObjectId == null) {

                this.ObjectId = "FETCH";

            } else {


            }
        }
        else if (this.ObjectId != null && ec.Excludes("objectId",true))
        {
            this.ObjectId = null;
        }
        //      C# -> System.String? PendingSlaDomainId
        // GraphQL -> pendingSlaDomainId: String! (scalar)
        if (ec.Includes("pendingSlaDomainId",true))
        {
            if(this.PendingSlaDomainId == null) {

                this.PendingSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.PendingSlaDomainId != null && ec.Excludes("pendingSlaDomainId",true))
        {
            this.PendingSlaDomainId = null;
        }
        //      C# -> System.String? PendingSlaDomainName
        // GraphQL -> pendingSlaDomainName: String! (scalar)
        if (ec.Includes("pendingSlaDomainName",true))
        {
            if(this.PendingSlaDomainName == null) {

                this.PendingSlaDomainName = "FETCH";

            } else {


            }
        }
        else if (this.PendingSlaDomainName != null && ec.Excludes("pendingSlaDomainName",true))
        {
            this.PendingSlaDomainName = null;
        }
    }


    #endregion

    } // class ManagedObjectPendingSlaInfo
    
    #endregion

    public static class ListManagedObjectPendingSlaInfoExtensions
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
            this List<ManagedObjectPendingSlaInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ManagedObjectPendingSlaInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ManagedObjectPendingSlaInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedObjectPendingSlaInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ManagedObjectPendingSlaInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types