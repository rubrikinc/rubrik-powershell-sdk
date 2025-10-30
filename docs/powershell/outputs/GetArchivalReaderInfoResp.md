### GetArchivalReaderInfoResp
GetArchivalReaderInfoResp is the response object for GetArchivalReaderInfo.

- readerRefreshStatus: ReaderRefreshStatus
  - Reader refresh status contains valid JSON data for reader locations; it is null for
owner locations. This field is relevant only if the requested location in the input
is a reader location. It indicates the refresh status of the requested location.
- activeReaderLocationIds: list of System.Strings
  - Field active_reader_location_ids contains the list of active (not deleted) reader
location IDs linked to the requested location. This list includes all reader location IDs
associated with the same bucket as the requested location. It will contain RSC-managed IDs
for RSC-managed locations and FIDs for CDM-managed locations.
- activeOwnerLocationIds: list of System.Strings
  - Field active_owner_location_ids contains the list of active (not deleted) owner
location IDs linked to the requested location. This list includes all owner location IDs
associated with the same bucket as the requested location. It will contain RSC-managed IDs
for RSC-managed locations and FIDs for CDM-managed locations.
The list will have at most one element, but it is structured as a list for potential future
scenarios where multiple owners may exist, similar to having multiple readers.
