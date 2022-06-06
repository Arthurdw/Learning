fn main() {
    let mut n = 0;
    loop {
        n += 1;
        if n > 10 {
            break;
        } else if n == 7 {
            continue;
        }
        println!("N is currently {}", n);
    }
}
