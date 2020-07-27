use std::io;

fn main() {
    let mut input = String::new();

    println!("Tell me your MOTD: ");

    match io::stdin().read_line(&mut input) {
        Ok(_) => {
            println!("Your MOTD is {}", input);
        },
        Err(e) => println!("Oops, something went wrong!\n{}", e)
    }
}
