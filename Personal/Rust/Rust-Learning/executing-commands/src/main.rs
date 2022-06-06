use std::process::Command;

fn main() {
    let mut cmd = Command::new("python");
    cmd.arg("example.py");

    match cmd.output() {
        Ok(o) => {
            unsafe {
                println!("Output: \n{}", String::from_utf8_unchecked(o.stdout));
            };
        }
        Err(e) => println!("An error occurred while trying to do this!\n{}", e)
    }

}
