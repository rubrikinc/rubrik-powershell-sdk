// DataCenterSummary.cs
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
    #region DataCenterSummary
    public class DataCenterSummary: BaseType
    {
        #region members

        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        [JsonProperty("effectiveSlaDomainId")]
        public System.String? EffectiveSlaDomainId { get; set; }

        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        [JsonProperty("effectiveSlaDomainName")]
        public System.String? EffectiveSlaDomainName { get; set; }

        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        [JsonProperty("effectiveSlaDomainPolarisManagedId")]
        public System.String? EffectiveSlaDomainPolarisManagedId { get; set; }

        //      C# -> System.String? EffectiveSlaSourceObjectId
        // GraphQL -> effectiveSlaSourceObjectId: String (scalar)
        [JsonProperty("effectiveSlaSourceObjectId")]
        public System.String? EffectiveSlaSourceObjectId { get; set; }

        //      C# -> System.String? EffectiveSlaSourceObjectName
        // GraphQL -> effectiveSlaSourceObjectName: String (scalar)
        [JsonProperty("effectiveSlaSourceObjectName")]
        public System.String? EffectiveSlaSourceObjectName { get; set; }

        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String (scalar)
        [JsonProperty("vcenterId")]
        public System.String? VcenterId { get; set; }

        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        [JsonProperty("effectiveSlaHolder")]
        public EffectiveSlaHolder? EffectiveSlaHolder { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DataCenterSummary";
    }

    public DataCenterSummary Set(
        System.String? EffectiveSlaDomainId = null,
        System.String? EffectiveSlaDomainName = null,
        System.String? EffectiveSlaDomainPolarisManagedId = null,
        System.String? EffectiveSlaSourceObjectId = null,
        System.String? EffectiveSlaSourceObjectName = null,
        System.String? VcenterId = null,
        EffectiveSlaHolder? EffectiveSlaHolder = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( EffectiveSlaDomainId != null ) {
            this.EffectiveSlaDomainId = EffectiveSlaDomainId;
        }
        if ( EffectiveSlaDomainName != null ) {
            this.EffectiveSlaDomainName = EffectiveSlaDomainName;
        }
        if ( EffectiveSlaDomainPolarisManagedId != null ) {
            this.EffectiveSlaDomainPolarisManagedId = EffectiveSlaDomainPolarisManagedId;
        }
        if ( EffectiveSlaSourceObjectId != null ) {
            this.EffectiveSlaSourceObjectId = EffectiveSlaSourceObjectId;
        }
        if ( EffectiveSlaSourceObjectName != null ) {
            this.EffectiveSlaSourceObjectName = EffectiveSlaSourceObjectName;
        }
        if ( VcenterId != null ) {
            this.VcenterId = VcenterId;
        }
        if ( EffectiveSlaHolder != null ) {
            this.EffectiveSlaHolder = EffectiveSlaHolder;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
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
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        if (this.EffectiveSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainId\n" ;
            } else {
                s += ind + "effectiveSlaDomainId\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        if (this.EffectiveSlaDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainName\n" ;
            } else {
                s += ind + "effectiveSlaDomainName\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        if (this.EffectiveSlaDomainPolarisManagedId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainPolarisManagedId\n" ;
            } else {
                s += ind + "effectiveSlaDomainPolarisManagedId\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaSourceObjectId
        // GraphQL -> effectiveSlaSourceObjectId: String (scalar)
        if (this.EffectiveSlaSourceObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaSourceObjectId\n" ;
            } else {
                s += ind + "effectiveSlaSourceObjectId\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaSourceObjectName
        // GraphQL -> effectiveSlaSourceObjectName: String (scalar)
        if (this.EffectiveSlaSourceObjectName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaSourceObjectName\n" ;
            } else {
                s += ind + "effectiveSlaSourceObjectName\n" ;
            }
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String (scalar)
        if (this.VcenterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vcenterId\n" ;
            } else {
                s += ind + "vcenterId\n" ;
            }
        }
        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        if (this.EffectiveSlaHolder != null) {
            var fspec = this.EffectiveSlaHolder.AsFieldSpec(conf.Child("effectiveSlaHolder"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaHolder" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            var fspec = this.SlaAssignable.AsFieldSpec(conf.Child("slaAssignable"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaAssignable" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String (scalar)
        if (ec.Includes("effectiveSlaDomainId",true))
        {
            if(this.EffectiveSlaDomainId == null) {

                this.EffectiveSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainId != null && ec.Excludes("effectiveSlaDomainId",true))
        {
            this.EffectiveSlaDomainId = null;
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String (scalar)
        if (ec.Includes("effectiveSlaDomainName",true))
        {
            if(this.EffectiveSlaDomainName == null) {

                this.EffectiveSlaDomainName = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainName != null && ec.Excludes("effectiveSlaDomainName",true))
        {
            this.EffectiveSlaDomainName = null;
        }
        //      C# -> System.String? EffectiveSlaDomainPolarisManagedId
        // GraphQL -> effectiveSlaDomainPolarisManagedId: String (scalar)
        if (ec.Includes("effectiveSlaDomainPolarisManagedId",true))
        {
            if(this.EffectiveSlaDomainPolarisManagedId == null) {

                this.EffectiveSlaDomainPolarisManagedId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainPolarisManagedId != null && ec.Excludes("effectiveSlaDomainPolarisManagedId",true))
        {
            this.EffectiveSlaDomainPolarisManagedId = null;
        }
        //      C# -> System.String? EffectiveSlaSourceObjectId
        // GraphQL -> effectiveSlaSourceObjectId: String (scalar)
        if (ec.Includes("effectiveSlaSourceObjectId",true))
        {
            if(this.EffectiveSlaSourceObjectId == null) {

                this.EffectiveSlaSourceObjectId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaSourceObjectId != null && ec.Excludes("effectiveSlaSourceObjectId",true))
        {
            this.EffectiveSlaSourceObjectId = null;
        }
        //      C# -> System.String? EffectiveSlaSourceObjectName
        // GraphQL -> effectiveSlaSourceObjectName: String (scalar)
        if (ec.Includes("effectiveSlaSourceObjectName",true))
        {
            if(this.EffectiveSlaSourceObjectName == null) {

                this.EffectiveSlaSourceObjectName = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaSourceObjectName != null && ec.Excludes("effectiveSlaSourceObjectName",true))
        {
            this.EffectiveSlaSourceObjectName = null;
        }
        //      C# -> System.String? VcenterId
        // GraphQL -> vcenterId: String (scalar)
        if (ec.Includes("vcenterId",true))
        {
            if(this.VcenterId == null) {

                this.VcenterId = "FETCH";

            } else {


            }
        }
        else if (this.VcenterId != null && ec.Excludes("vcenterId",true))
        {
            this.VcenterId = null;
        }
        //      C# -> EffectiveSlaHolder? EffectiveSlaHolder
        // GraphQL -> effectiveSlaHolder: EffectiveSlaHolder (type)
        if (ec.Includes("effectiveSlaHolder",false))
        {
            if(this.EffectiveSlaHolder == null) {

                this.EffectiveSlaHolder = new EffectiveSlaHolder();
                this.EffectiveSlaHolder.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaHolder"));

            } else {

                this.EffectiveSlaHolder.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaHolder"));

            }
        }
        else if (this.EffectiveSlaHolder != null && ec.Excludes("effectiveSlaHolder",false))
        {
            this.EffectiveSlaHolder = null;
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (ec.Includes("slaAssignable",false))
        {
            if(this.SlaAssignable == null) {

                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            } else {

                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            }
        }
        else if (this.SlaAssignable != null && ec.Excludes("slaAssignable",false))
        {
            this.SlaAssignable = null;
        }
    }


    #endregion

    } // class DataCenterSummary
    
    #endregion

    public static class ListDataCenterSummaryExtensions
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
            this List<DataCenterSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DataCenterSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DataCenterSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DataCenterSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DataCenterSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types