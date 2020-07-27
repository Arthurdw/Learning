fn main() {
    // Example:
    /*
    let name = String::from("Arthur");

    println!("Character at index 8: {}", match name.chars().nth(8) {
        Some(char) => char.to_string(),
        None => "No character".to_string()
    })
    */

    println!("Description: {}", match get_occupation("Arthur") {
        Some(res) => res,
        None => "No description found!",
    })
}

fn get_occupation(name: &str) -> Option<&str> {
    match name {
        "Arthur" => Some("Cool dude, jk lmao"),
        "Jeffry" => Some("A swaggy cactus plant"),
        _ => None,
    }
}
