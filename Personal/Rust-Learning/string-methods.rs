fn main() {
    let string = String::from("    Rust is pretty nice :D\nBut you know what is even better?\nThat may be you!\n");
    println!("Original string:\n{}", string);

    // Replace //
    {
        let _my_string = &string;
        println!("After replace:");
        println!("{}", _my_string.replace("nice", "cool"));
    }

    // Lines //
    {
        let _my_string = &string;

        println!("Separating the lines:");
        for line in _my_string.lines() {
            println!("[ {} ]", line);
        }
    }

    // Split //
    {
        let _my_string = &string;

        println!("\nSplitting by '\\n':");
        let tokens: Vec<&str> = _my_string.split("\n").collect();
        println!("The first line:\n{}", tokens[0]);
    }

    // Trim //
    {
        let _my_string = &string;

        println!("\nTrimming the string:");
        println!("{}", _my_string.trim());
    }

    // Chars //
    {
        let _my_string = &string;

        println!("\nGetting the fourth char of the string:");
        match _my_string.trim().chars().nth(3) {
            Some(c) =>  println!("{}", c),
            None => println!("There is no fourth character!")
        }
    }
}
