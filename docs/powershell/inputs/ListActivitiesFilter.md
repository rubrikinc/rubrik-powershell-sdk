### ListActivitiesFilter
Filters for list activities.

- activityIds: list of System.Strings
  - The IDs of the activities to filter on.
- actorIds: list of System.Strings
  - The IDs of the actors to filter on.
- targetEntityIds: list of System.Strings
  - The IDs of the target entities to filter on.
- activityDateRange: DateTimeRange
  - The date range of the activity to filter on.
- identityFilters: IdentityFilter
  - The identity specific filters.
- categories: list of ActivityCategorys
  - The category of the activity.
- entityIds: list of System.Strings
  - The IDs of the target or actor entities to filter on.
- attributeChangeFilter: ActivityAuditorAttributeChangeFilter
  - The attribute change filter.
- sourceDcIds: list of System.Strings
  - The IDs of the source DCs to filter on.
- eventProviders: list of EventProviders
  - The event providers of the events to filter on.
- titles: list of System.Strings
  - The titles of the activity to filter on.
- targetTypes: list of System.Strings
  - The target types of the activity to filter on. The target type is
sub-type of the target scope.
- actionTypes: list of System.Strings
  - The action types of the activity to filter on.
- statuses: list of LambdaEventStatuss
  - The statuses of the actor to filter on.
- scopedTargetEntities: list of ActivityScopedTargetEntitys
  - Scoped target entities for filtering. Use this instead of target_entity_ids
for scope disambiguation to avoid ID collisions across targets from different resources.
