// include Fake libs
#r "tools/FAKE/tools/FakeLib.dll"

open Fake
open Fake.Testing
open Fake.DotCover

RestorePackages()
// Directories
let buildDir  = "./build/"
let testDir   = "./testoutput/"

// Filesets
let appReferences  = !! "src/app/**/*.fsproj"

let testReferences = !! "src/test/**/*.fsproj"

".nuget/packages.config" |> RestorePackage (fun p -> { p with OutputPath = "tools" } )

// Targets
Target "Clean" (fun _ -> 
    CleanDirs [buildDir; testDir]
)

Target "BuildApp" (fun _ ->
    MSBuildRelease buildDir "Build" appReferences
        |> Log "AppBuild-Output: "
)

Target "BuildTest" (fun _ ->
    MSBuildDebug testDir "Build" testReferences
        |> Log "TestBuild-Output: "
)

Target "XUnitTest" (fun _ ->  
    !! (testDir + "Trees.Test.dll")
        |> xUnit2 (fun p -> p)
)

Target "Cover" (fun _ ->  
//    !! (testDir + "Trees.Test.dll")
     DotCover (fun _ -> { DotCoverDefaults with 
                              TargetExecutable = @"tools\xunit.runner.console.2.1.0\tools\xunit.console.exe";
                              TargetArguments = testDir + "Trees.Test.dll";
                              WorkingDir = "" }))

Target "Docker" (fun _ ->  
        let errorcode = Shell.Exec("docker", "build .")
        trace (sprintf "Docker image %i" errorcode)
)

// Build order
"Clean"
  ==> "BuildApp"
  ==> "BuildTest"
//  ==> "XUnitTest"
  ==> "Cover"
  ==> "Docker"

// start build
RunTargetOrDefault "Cover"
