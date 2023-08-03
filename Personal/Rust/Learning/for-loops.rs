fn main() {
    let items = vec!["Ani1", "Ani2", "Ani3"];
    for (index, val) in items.iter().enumerate() {
        println!("Value for item in the vector is {} at {}", val, index);
    }
}
