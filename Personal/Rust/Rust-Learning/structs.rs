struct Color {
    red:u8,
    green:u8,
    blue:u8
}

fn main() {
    let mut bg = Color {red: 255, green: 10, blue: 50};

    bg.blue = 15;

    println!("{} {} {}", bg.red, bg.green, bg.blue);
}
