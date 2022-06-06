use std::collections::HashMap;

fn main() {
    let mut marks = HashMap::new();

    marks.insert("Rust Programming", 96);
    marks.insert("C# Programming", 98);
    marks.insert("Web Development", 94);
    marks.insert("Electronics", 86);

    println!("You have studied {} subjects!", marks.len());

    match marks.get("Web Development") {
        Some(mark) => println!("You got {} for Web Development", mark),
        None => println!("You didn't study that!")
    }

    marks.remove("Web Development");

    for (key, value) in &marks {
        println!("For {} you got {}%", key, value);
    }

    println!("Cpp studied? {}", marks.contains_key("Cpp Programming"));
}
