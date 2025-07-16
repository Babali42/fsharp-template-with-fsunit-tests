namespace fsharp_template_with_tests

open NUnit.Framework
open FsUnit
open fsharp_template_with_tests.App

[<TestFixture>]
module Tests =

    [<Test>]
    let ``One should equal one`` () =
        one() |> should equal 1
