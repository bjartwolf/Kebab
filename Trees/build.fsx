// include Fake libs
#r "tools/FAKE/tools/FakeLib.dll"

open Fake

RestorePackages()
// Directories
let buildDir  = "./build/"
let testDir   = "./test/"

// Filesets
let appReferences  = !! "src/app/**/*.fsproj"

let testReferences = !! "src/test/**/*.fsproj"

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
        |> xUnit (fun p -> {p with OutputDir = testDir})
)

Target "Docker" (fun _ ->  
        let errorcode = Shell.Exec("docker", "build .")
        trace (sprintf "Docker image %i" errorcode)
)

// Build order
"Clean"
  ==> "BuildApp"
  ==> "BuildTest"
  ==> "XUnitTest"
  ==> "Docker"

// start build
RunTargetOrDefault "Docker"
