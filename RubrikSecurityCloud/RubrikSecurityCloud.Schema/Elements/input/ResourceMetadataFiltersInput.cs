// ResourceMetadataFiltersInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region ResourceMetadataFiltersInput

    public class ResourceMetadataFiltersInput: IInput
    {
        #region members

        //      C# -> List<DataGovObjectType>? ObjectTypes
        // GraphQL -> objectTypes: [DataGovObjectType!] (enum)
        [JsonProperty("objectTypes")]
        public List<DataGovObjectType>? ObjectTypes { get; set; }

        //      C# -> List<System.String>? CloudAccountIds
        // GraphQL -> cloudAccountIds: [UUID!] (scalar)
        [JsonProperty("cloudAccountIds")]
        public List<System.String>? CloudAccountIds { get; set; }

        //      C# -> List<ManagedObjectType>? ManagedObjectTypes
        // GraphQL -> managedObjectTypes: [ManagedObjectType!] (enum)
        [JsonProperty("managedObjectTypes")]
        public List<ManagedObjectType>? ManagedObjectTypes { get; set; }

        //      C# -> List<ViolationPrincipalType>? PrincipalTypes
        // GraphQL -> principalTypes: [ViolationPrincipalType!] (enum)
        [JsonProperty("principalTypes")]
        public List<ViolationPrincipalType>? PrincipalTypes { get; set; }

        //      C# -> List<IdentityResolutionType>? ResolutionTypes
        // GraphQL -> resolutionTypes: [IdentityResolutionType!] (enum)
        [JsonProperty("resolutionTypes")]
        public List<IdentityResolutionType>? ResolutionTypes { get; set; }

        //      C# -> List<System.String>? DomainFids
        // GraphQL -> domainFids: [UUID!] (scalar)
        [JsonProperty("domainFids")]
        public List<System.String>? DomainFids { get; set; }

        //      C# -> System.String? IdentityNameSearch
        // GraphQL -> identityNameSearch: String (scalar)
        [JsonProperty("identityNameSearch")]
        public System.String? IdentityNameSearch { get; set; }

        //      C# -> List<AccessVia>? AccessTypes
        // GraphQL -> accessTypes: [AccessVia!] (enum)
        [JsonProperty("accessTypes")]
        public List<AccessVia>? AccessTypes { get; set; }

        //      C# -> List<System.String>? Sources
        // GraphQL -> sources: [String!] (scalar)
        [JsonProperty("sources")]
        public List<System.String>? Sources { get; set; }

        //      C# -> List<IdpType>? IdpTypes
        // GraphQL -> idpTypes: [IdpType!] (enum)
        [JsonProperty("idpTypes")]
        public List<IdpType>? IdpTypes { get; set; }

        //      C# -> TimeRangeInput? OriginEventDateRange
        // GraphQL -> originEventDateRange: TimeRangeInput (input)
        [JsonProperty("originEventDateRange")]
        public TimeRangeInput? OriginEventDateRange { get; set; }

        //      C# -> List<IdentityTag>? IdentityTags
        // GraphQL -> identityTags: [IdentityTag!] (enum)
        [JsonProperty("identityTags")]
        public List<IdentityTag>? IdentityTags { get; set; }

        //      C# -> List<System.String>? ActorIds
        // GraphQL -> actorIds: [String!] (scalar)
        [JsonProperty("actorIds")]
        public List<System.String>? ActorIds { get; set; }

        //      C# -> List<PrincipalOrigin>? IdentityOrigins
        // GraphQL -> identityOrigins: [PrincipalOrigin!] (enum)
        [JsonProperty("identityOrigins")]
        public List<PrincipalOrigin>? IdentityOrigins { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class ResourceMetadataFiltersInput
    #endregion

} // namespace RubrikSecurityCloud.Types