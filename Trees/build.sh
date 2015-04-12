#!/bin/bash

mono .nuget/nuget.exe restore
mono .nuget/nuget.exe install FAKE -OutputDirectory tools -ExcludeVersion -Prerelease
mono tools/FAKE/tools/FAKE.exe --fsiargs -d:MONO build.fsx

