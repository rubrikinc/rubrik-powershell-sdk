### AzureAdPimEligibilityMemberType
How a PIM eligibility was conferred on the principal.
Mirrors the Microsoft Graph memberType field. Values from
the role and group APIs differ in casing
(Direct/Group/Inherited vs direct/group); the converter
matches case-insensitively.

- PIM_MEMBER_TYPE_UNSPECIFIED - Default zero value. Indicates the member type was not
set or did not match any known Microsoft Graph value.
- PIM_MEMBER_TYPE_DIRECT - Eligibility was assigned directly to the principal.
- PIM_MEMBER_TYPE_GROUP - Eligibility is inherited via group membership.
- PIM_MEMBER_TYPE_INHERITED - Eligibility is inherited from a parent scope.
