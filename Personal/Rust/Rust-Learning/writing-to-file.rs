use std::fs::File;
use std::io::prelude::*;

fn main() {
    let mut file = File::create("output.txt").expect("Oops, file couldn't be created!");
    file.write_all(b"Hello World!").expect("Cannot write to the file!");
}
