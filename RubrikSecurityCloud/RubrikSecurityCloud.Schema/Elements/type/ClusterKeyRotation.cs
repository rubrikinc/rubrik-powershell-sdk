// ClusterKeyRotation.cs
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
    #region ClusterKeyRotation
    public class ClusterKeyRotation: BaseType
    {
        #region members

        //      C# -> ClusterKeyProtection? ProtectionType
        // GraphQL -> protectionType: ClusterKeyProtection! (enum)
        [JsonProperty("protectionType")]
        public ClusterKeyProtection? ProtectionType { get; set; }

        //      C# -> ClusterKeyRotationState? State
        // GraphQL -> state: ClusterKeyRotationState! (enum)
        [JsonProperty("state")]
        public ClusterKeyRotationState? State { get; set; }

        //      C# -> DateTime? CompletedAt
        // GraphQL -> completedAt: DateTime (scalar)
        [JsonProperty("completedAt")]
        public DateTime? CompletedAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterKeyRotation";
    }

    public ClusterKeyRotation Set(
        ClusterKeyProtection? ProtectionType = null,
        ClusterKeyRotationState? State = null,
        DateTime? CompletedAt = null
    ) 
    {
        if ( ProtectionType != null ) {
            this.ProtectionType = ProtectionType;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( CompletedAt != null ) {
            this.CompletedAt = CompletedAt;
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
        //      C# -> ClusterKeyProtection? ProtectionType
        // GraphQL -> protectionType: ClusterKeyProtection! (enum)
        if (this.ProtectionType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "protectionType\n" ;
            } else {
                s += ind + "protectionType\n" ;
            }
        }
        //      C# -> ClusterKeyRotationState? State
        // GraphQL -> state: ClusterKeyRotationState! (enum)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> DateTime? CompletedAt
        // GraphQL -> completedAt: DateTime (scalar)
        if (this.CompletedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "completedAt\n" ;
            } else {
                s += ind + "completedAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ClusterKeyProtection? ProtectionType
        // GraphQL -> protectionType: ClusterKeyProtection! (enum)
        if (ec.Includes("protectionType",true))
        {
            if(this.ProtectionType == null) {

                this.ProtectionType = new ClusterKeyProtection();

            } else {


            }
        }
        else if (this.ProtectionType != null && ec.Excludes("protectionType",true))
        {
            this.ProtectionType = null;
        }
        //      C# -> ClusterKeyRotationState? State
        // GraphQL -> state: ClusterKeyRotationState! (enum)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = new ClusterKeyRotationState();

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> DateTime? CompletedAt
        // GraphQL -> completedAt: DateTime (scalar)
        if (ec.Includes("completedAt",true))
        {
            if(this.CompletedAt == null) {

                this.CompletedAt = new DateTime();

            } else {


            }
        }
        else if (this.CompletedAt != null && ec.Excludes("completedAt",true))
        {
            this.CompletedAt = null;
        }
    }


    #endregion

    } // class ClusterKeyRotation
    
    #endregion

    public static class ListClusterKeyRotationExtensions
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
            this List<ClusterKeyRotation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterKeyRotation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterKeyRotation> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterKeyRotation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterKeyRotation> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types