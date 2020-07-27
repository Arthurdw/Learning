fn main() {
    // let numbers: [u8; 10] = [1, 2, 3, 4, 5, 6, 7, 8, 9, 0];
    let numbers = [2; 400];

    for n in numbers.iter() {
        println!("{}", n);
    }

    // for i in 0..numbers.len() {
    //     println!("{}", numbers[i]);
    // }
}
