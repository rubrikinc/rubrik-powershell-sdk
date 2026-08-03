// QuiesceTarget.cs
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
    #region QuiesceTarget
    public class QuiesceTarget: BaseType
    {
        #region members

        //      C# -> QuiesceTargetTargetType? TargetType
        // GraphQL -> targetType: QuiesceTargetTargetType! (enum)
        [JsonProperty("targetType")]
        public QuiesceTargetTargetType? TargetType { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: UUID (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? VmId
        // GraphQL -> vmId: UUID (scalar)
        [JsonProperty("vmId")]
        public System.String? VmId { get; set; }

        //      C# -> VmBackupScript? PostBackupScript
        // GraphQL -> postBackupScript: VmBackupScript (type)
        [JsonProperty("postBackupScript")]
        public VmBackupScript? PostBackupScript { get; set; }

        //      C# -> VmBackupScript? PostSnapScript
        // GraphQL -> postSnapScript: VmBackupScript (type)
        [JsonProperty("postSnapScript")]
        public VmBackupScript? PostSnapScript { get; set; }

        //      C# -> VmBackupScript? PreBackupScript
        // GraphQL -> preBackupScript: VmBackupScript (type)
        [JsonProperty("preBackupScript")]
        public VmBackupScript? PreBackupScript { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "QuiesceTarget";
    }

    public QuiesceTarget Set(
        QuiesceTargetTargetType? TargetType = null,
        System.String? HostId = null,
        System.String? VmId = null,
        VmBackupScript? PostBackupScript = null,
        VmBackupScript? PostSnapScript = null,
        VmBackupScript? PreBackupScript = null
    ) 
    {
        if ( TargetType != null ) {
            this.TargetType = TargetType;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( VmId != null ) {
            this.VmId = VmId;
        }
        if ( PostBackupScript != null ) {
            this.PostBackupScript = PostBackupScript;
        }
        if ( PostSnapScript != null ) {
            this.PostSnapScript = PostSnapScript;
        }
        if ( PreBackupScript != null ) {
            this.PreBackupScript = PreBackupScript;
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
        //      C# -> QuiesceTargetTargetType? TargetType
        // GraphQL -> targetType: QuiesceTargetTargetType! (enum)
        if (this.TargetType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetType\n" ;
            } else {
                s += ind + "targetType\n" ;
            }
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: UUID (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: UUID (scalar)
        if (this.VmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vmId\n" ;
            } else {
                s += ind + "vmId\n" ;
            }
        }
        //      C# -> VmBackupScript? PostBackupScript
        // GraphQL -> postBackupScript: VmBackupScript (type)
        if (this.PostBackupScript != null) {
            var fspec = this.PostBackupScript.AsFieldSpec(conf.Child("postBackupScript"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "postBackupScript" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VmBackupScript? PostSnapScript
        // GraphQL -> postSnapScript: VmBackupScript (type)
        if (this.PostSnapScript != null) {
            var fspec = this.PostSnapScript.AsFieldSpec(conf.Child("postSnapScript"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "postSnapScript" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VmBackupScript? PreBackupScript
        // GraphQL -> preBackupScript: VmBackupScript (type)
        if (this.PreBackupScript != null) {
            var fspec = this.PreBackupScript.AsFieldSpec(conf.Child("preBackupScript"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "preBackupScript" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> QuiesceTargetTargetType? TargetType
        // GraphQL -> targetType: QuiesceTargetTargetType! (enum)
        if (ec.Includes("targetType",true))
        {
            if(this.TargetType == null) {

                this.TargetType = new QuiesceTargetTargetType();

            } else {


            }
        }
        else if (this.TargetType != null && ec.Excludes("targetType",true))
        {
            this.TargetType = null;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: UUID (scalar)
        if (ec.Includes("hostId",true))
        {
            if(this.HostId == null) {

                this.HostId = "FETCH";

            } else {


            }
        }
        else if (this.HostId != null && ec.Excludes("hostId",true))
        {
            this.HostId = null;
        }
        //      C# -> System.String? VmId
        // GraphQL -> vmId: UUID (scalar)
        if (ec.Includes("vmId",true))
        {
            if(this.VmId == null) {

                this.VmId = "FETCH";

            } else {


            }
        }
        else if (this.VmId != null && ec.Excludes("vmId",true))
        {
            this.VmId = null;
        }
        //      C# -> VmBackupScript? PostBackupScript
        // GraphQL -> postBackupScript: VmBackupScript (type)
        if (ec.Includes("postBackupScript",false))
        {
            if(this.PostBackupScript == null) {

                this.PostBackupScript = new VmBackupScript();
                this.PostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScript"));

            } else {

                this.PostBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("postBackupScript"));

            }
        }
        else if (this.PostBackupScript != null && ec.Excludes("postBackupScript",false))
        {
            this.PostBackupScript = null;
        }
        //      C# -> VmBackupScript? PostSnapScript
        // GraphQL -> postSnapScript: VmBackupScript (type)
        if (ec.Includes("postSnapScript",false))
        {
            if(this.PostSnapScript == null) {

                this.PostSnapScript = new VmBackupScript();
                this.PostSnapScript.ApplyExploratoryFieldSpec(ec.NewChild("postSnapScript"));

            } else {

                this.PostSnapScript.ApplyExploratoryFieldSpec(ec.NewChild("postSnapScript"));

            }
        }
        else if (this.PostSnapScript != null && ec.Excludes("postSnapScript",false))
        {
            this.PostSnapScript = null;
        }
        //      C# -> VmBackupScript? PreBackupScript
        // GraphQL -> preBackupScript: VmBackupScript (type)
        if (ec.Includes("preBackupScript",false))
        {
            if(this.PreBackupScript == null) {

                this.PreBackupScript = new VmBackupScript();
                this.PreBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("preBackupScript"));

            } else {

                this.PreBackupScript.ApplyExploratoryFieldSpec(ec.NewChild("preBackupScript"));

            }
        }
        else if (this.PreBackupScript != null && ec.Excludes("preBackupScript",false))
        {
            this.PreBackupScript = null;
        }
    }


    #endregion

    } // class QuiesceTarget
    
    #endregion

    public static class ListQuiesceTargetExtensions
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
            this List<QuiesceTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<QuiesceTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<QuiesceTarget> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new QuiesceTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<QuiesceTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types