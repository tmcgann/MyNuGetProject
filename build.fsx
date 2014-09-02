// include Fake lib
#r @"packages\FAKE\tools\FakeLib.dll"
open Fake
open System
open Fake.AssemblyInfoFile

Target "Default" (fun _ ->
	LogMessage "Hello, World!"
)

RunTargetOrDefault "Default"