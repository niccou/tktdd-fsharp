module Tennis

// Types
type player =
| PlayerOne
| PlayerTwo

type point = int // surely not the best choice

type pointsData = {
    playerOne: point
    playerTwo: point
}

type score =
    // surely incomplete
    | Points of pointsData
    | Deuce
    | Game of player

// Type transformation functions
let string_of_score (score:score) = "replace this with your code"

let string_of_player player =
    match player with
    | PlayerOne -> "Player 1"
    | PlayerTwo -> "Player 2"

// Tooling functions    
let other_player player =
    match player with
    | PlayerOne -> PlayerTwo
    | PlayerTwo -> PlayerOne

let increment_point (point: point) =
    match point with
    | 15 -> Some(15)
    | _ -> None

let read_from_option_point op =
    match op with
    | Some(a) -> a
    | None -> 0

// Score management functions
let score_when_deuce(winner: player) = Deuce

let score_when_advantage(advantagePlayer: player, winner: player) = Deuce

let score_when_forty(current: player, winner: player) = Deuce

let score_when_game (winner: player) = Deuce

let score (currentScore: score, winner: player) = Deuce
