### GetExotaskImageBundleReply
Represents the reply of get exotask image bundle.

- bundleVersion: System.String
  - The current Version of the exotask images bundle.
- repoUrl: System.String
  - Contains the URL of Rubrik's ECR from where the images can be downloaded.
- bundleImages: list of BundleImages
  - Details of the exo-task images in the bundle.
- eksVersion: System.String
  - EKS version for EKS version dependent images.
