fn main() {
    let mut x = 10;
    {
        let xr = &mut x;

        *xr += 10;
    }

    println!("x is {}", x);
}
