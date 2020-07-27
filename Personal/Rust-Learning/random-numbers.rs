extern crate rand;
use rand::Rng;

fn main() {
    let random_number = rand::thread_rng().gen_range(1, 11); // 1-10\
    println!("Rand: {}", random_number);

    let random_bool = rand::thread_rng().gen_weighted_bool(2); // one in x (this case 2)
    println!("Random Boolean: {}", random_bool)
}
