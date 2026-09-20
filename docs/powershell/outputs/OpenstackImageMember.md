### OpenstackImageMember
A project member with access to an OpenStack image.

- imageId: System.String
  - OpenStack image ID.
- memberId: System.String
  - OpenStack project ID of the member.
- status: OpenstackImageMemberStatus
  - Member access status for the OpenStack image.
- project: OpenstackProject
  - The OpenStack project associated with this member.
