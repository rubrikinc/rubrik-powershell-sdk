### Group
User group details.

- groupId: System.String
  - The ID of the user group.
- groupName: System.String
  - The name of the user group.
- domainName: System.String
  - Domain name of the user group.
- users: list of Users
  - Users from the user group who are logged-in to the account.
- roles: list of Roles
  - User group roles in the context organization.
- allOrgs: list of Orgs
  - The suborganizations in which the user group has roles.
- activeUsers: list of Users
  - Users from the user group who are currently logged-in to the account.
