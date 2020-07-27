use std::fs::File;
use std::io::prelude::*;

fn main() {
    let mut file = File::open("test.txt").expect("Can't open file!");

    let mut contents = String::new();
    file.read_to_string(&mut contents).expect("Oops, can't read the file!");

    println!("File contents:\n{}", contents);
}
