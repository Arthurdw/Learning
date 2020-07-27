fn main() {
    print_numbers_to(10);
}

fn print_numbers_to(number: u32) {
    for numb in 0..number {
        println!("{} is {}", numb, if is_even(numb) { "even" } else { "odd" })
    }
}

fn is_even(num: u32) -> bool {
    return num % 2 == 0;
}
