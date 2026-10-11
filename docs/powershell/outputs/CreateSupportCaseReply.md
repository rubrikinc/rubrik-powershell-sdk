### CreateSupportCaseReply
Create a support case reply.

- caseId: System.String
  - The support case ID.
- caseNumber: System.String
  - The number used as the name of the support case.
- caseLink: System.String
  - URL to view the case on Rubrik Support portal.
- rscCaseLink: System.String
  - URL to view the case in RSC support portal when REL_ENABLE_SUPPORT_PORTAL is enabled.
Prefer this for in-app navigation over the external caseLink when present.
