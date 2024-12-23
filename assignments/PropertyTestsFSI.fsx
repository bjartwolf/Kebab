#load @"./../.paket/load/net9.0/fscheck.fsx"

#load "Trees.fs"
#load "TreeTests.fs"

open FsCheck
open TreeTests


Check.Quick ``Flipped unsymmetric tree is not equal to self``
Check.Quick ``Eating pears does not change a tree if it doesn't have pears``
Check.Quick ``Doubleflipped trees are equal to themselves`` 
Check.Quick ``Flipped unsymmetric tree is different from self`` 
Check.Quick ``Flipped bud is equal to self`` 
