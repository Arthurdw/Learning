#![allow(dead_code)]

enum Day {
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday,
}

impl Day {
    fn is_weekday(&self) -> bool {
        return match self {
            &Day::Saturday | &Day::Sunday => false,
            _ => true,
        }
    }
}

fn main() {
    let w = Day::Monday;
    println!("Is w a weekday? {}", w.is_weekday());
    let d = Day::Sunday;
    println!("Is d a weekday? {}", d.is_weekday());
}
