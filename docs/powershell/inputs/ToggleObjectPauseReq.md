### ToggleObjectPauseReq
Information to initiate ToggleObjectPause assignment.

- togglePauseInfo: list of TogglePauseInfos
  - Information about the objects on which the ToggleObjectPause operation is to be assigned, along with their workload hierarchy type.
- note: System.String
  - User note, if any, stating the reason for the operation on the objects.
- isPause: System.Boolean
  - Indicates whether the operation is to pause or unpause the objects.
