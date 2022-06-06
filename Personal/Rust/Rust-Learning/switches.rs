fn main() {
    let number = 9;

    match number {
        1 => println!("It is the one and only number one!"),
        2 => println!("There is the second one!"),
        3..=9 => println!("Its greater than 3 and less than ten!"),
        10 | 11 => println!("Its 10 or 11, I don't know!"),
        _ => println!("No matches found! :(")
    }

    let name = "Arthur";
    match name {
        "Arthur" => println!("Yeah thats me :D"),
        "Chris" => println!("Oi m8!"),
        "Jeffrey" => println!("That's my cactus!"),
        _ => println!("Do I know you?")
    }
}
