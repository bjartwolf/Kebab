#!/bin/bash

mono .nuget/NuGet.exe restore
mono .nuget/NuGet.exe install FAKE -OutputDirectory tools -ExcludeVersion -Prerelease
mono tools/FAKE/tools/FAKE.exe --fsiargs -d:MONO build.fsx

