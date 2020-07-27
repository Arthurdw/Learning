enum Direction {
    Up,
    Down,
    Left,
    Right,
}

fn main() {
    let player_direction: Direction = Direction::Up;
    // let player_direction: Direction = Direction::Down;
    // let player_direction: Direction = Direction::Left;
    // let player_direction: Direction = Direction::Right;

    match player_direction {
        Direction::Up => { println!("We are heading up!") }
        Direction::Down => { println!("We are going down!") }
        Direction::Left => { println!("We are going to the left!") }
        Direction::Right => { println!("We are going to the right!") }
    }
}
