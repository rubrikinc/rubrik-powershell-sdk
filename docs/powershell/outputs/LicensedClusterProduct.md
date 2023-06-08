### LicensedClusterProduct
Represents a single licensed product.

- product: Product
  - The name of the product.
- purchasedCapacityBytes: System.Single
  - The total purchased capacity of this product, in bytes.
- registeredCapacityBytes: System.Single
  - The total registered capacity of this product, in bytes.
- nextExpiringBytes: System.Single
  - The amount of bytes under the license with the nearest expiry date.
- nextExpiringTime: DateTime
  - The next expiry date of a license under this product.
- productTypes: list of System.Strings
  - The product types under this product that the customer has.
- numClusters: System.Int32
  - The number of Rubrik clusters included in this product.
- contributions: list of CapacityContributions
  - The contributions from other products that make up the used capacity of this product. Only valid when product type is Scale.
