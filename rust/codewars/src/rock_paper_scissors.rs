pub(crate) fn rps(p1: &str, p2: &str) -> &'static str  {
    let choices = ["rock", "paper", "scissors"];
    let p1 = choices.iter().position(|&r| r == p1).unwrap();
    let p2 = choices.iter().position(|&r| r == p2).unwrap();
    match (p1, p2) {
        (0, 1) => "Player 2 won!",
        (0, 2) => "Player 1 won!",
        (1, 0) => "Player 1 won!",
        (1, 2) => "Player 2 won!",
        (2, 0) => "Player 2 won!",
        (2, 1) => "Player 1 won!",
        _ => "Draw!",
    }
}
