### ConfigResourceAwsLoadBalancer
AWS Load Balancer specific details for config resources.

- type: AwsLoadBalancerType
  - Load balancer type.
- vpcName: System.String
  - Name of the VPC the load balancer is associated with.
- ipAddress: System.String
  - IP address of the load balancer.
- targetGroupsCount: System.Int32
  - Target groups associated with the load balancer.
- status: AwsLoadBalancerStatus
  - Load balancer status.
- vpcId: System.String
  - ID of the VPC the load balancer is associated with.
