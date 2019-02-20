module Tests

open System
open Xunit
open Tennis

[<Fact>]
let ``Given a Player 1 the other player is Player 2`` () =
    (PlayerOne |> other_player |> string_of_player, "Player 2") |> Assert.Equal

[<Fact>]
let ``Given deuce when player wins then score is correct`` () =
    (PlayerOne |> score_when_deuce |> string_of_score, "Advantage Player 1") |> Assert.Equal
    
[<Fact>]
let ``Given advantage when advantaged player wins then score is Game to the advantaged player`` () =
    let advantagedPlayer = PlayerOne
    let winner = advantagedPlayer
    ((advantagedPlayer, winner) |> score_when_advantage |> string_of_score, "Game Player 1") |> Assert.Equal

[<Fact>]
let ``Given advantage when the other player wins then score is Deuce`` () =
    let advantagedPlayer = PlayerOne
    let winner = advantagedPlayer |> other_player
    ((advantagedPlayer, winner) |> score_when_advantage |> string_of_score, "Deuce") |> Assert.Equal

[<Fact>]
let ``Given player: 40 when player at 40 wins then score is Game for this player`` () =
    Assert.True(false)

[<Fact>]
let ``Given player: 40 | other : 30 when other wins then score is Deuce`` () =
    Assert.True(false)

[<Fact>]
let ``Given player: 40 | other : 15 when other wins then score is 40/15`` () =
    Assert.True(false)

[<Fact>]
let ``Given player: 15 | other : 15 when player wins then score is 30/15`` () =
    Assert.True(false)

[<Fact>]
let ``Given player: 0  | other : 15 when other wins then score is 0/30`` () =
    Assert.True(false)

[<Fact>]
let ``Given player: 30 | other : 15 when player wins then score is 40/15`` () =
    Assert.True(false)
