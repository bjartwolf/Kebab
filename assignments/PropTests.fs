module PropTests

// the ExpectoFsCheck module is auto-opened by this
// the configuration record is in the Expecto namespace in the core library
open Expecto
open TreeTests
let config = { FsCheckConfig.defaultConfig with maxTest = 10000 }
[<Tests>]
let properties =
  testList "FsCheck runner" [
    testProperty "We need more names for this runner" ``Flipped unsymmetric tree is not equal to self``
    testProperty "Lots of names" ``Eating pears does not change a tree if it doesn't have pears``
    testProperty "So many names" ``Flipped unsymmetric tree is not equal to self``
    testProperty "The names..." ``Doubleflipped trees are equal to themselves`` 
    testPropertyWithConfig config "finally " ``Flipped bud is equal to self`` 
  ]
