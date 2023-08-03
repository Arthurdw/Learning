fn main() {
    let mut x = 10;

    {
        let x = 15;
    }

    let x = "x is now a string";
    println!("x is {}", x);
    let x = true;
    println!("x is {}", x);
}
