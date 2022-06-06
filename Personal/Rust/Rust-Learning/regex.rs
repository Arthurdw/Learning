extern crate regex;
use regex::Regex;

fn main() {
    let re = Regex::new(r"(\w{6})").unwrap();
    let text = "Arthur";

    // println!("Found match? {}", re.is_match(text));
    match re.captures(text) {
        Some(caps) => println!("Found match: {}", &caps[0]),
        None => println!("No matches found!"),
    }
}
