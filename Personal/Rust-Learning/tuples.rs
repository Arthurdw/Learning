fn main() {
    let tuple = (10, 20, 30, 40, "test", (1, 2, (3, 5)));
    println!("{}", ((tuple.5).2).1);

    let tup2 = (1, 2, 3);

    let (a, b, c) = tup2;
    println!("a is {}", a);
    println!("b is {}", b);
    println!("c is {}", c);
}
