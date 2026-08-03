### PropertiesOneof
Type-specific properties for the named location.

- ipMetadata: EntraIDNamedLocationIPProperties
  - Properties specific to IP-based named locations.
Only populated when location_type is EID_NL_TYPE_IP.
- countryMetadata: EntraIDNamedLocationCountryProperties
  - Properties specific to country-based named locations.
Only populated when location_type is EID_NL_TYPE_COUNTRY.
