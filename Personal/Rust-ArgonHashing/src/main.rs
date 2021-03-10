use std::time::Instant;

use argon2::{self, Config, ThreadMode, Variant, Version};

fn main() {
    println!("Creating config");
    let config = Config {
        variant: Variant::Argon2id,
        version: Version::Version13,
        mem_cost: 128,
        time_cost: 10,
        lanes: 4,
        thread_mode: ThreadMode::Parallel,
        secret: &[],
        ad: &[],
        hash_length: 1024,
    };

    println!("Starting hasher");
    let now = Instant::now();
    {
        let password = b"My Omega Super Secret Password :)";
        let salt = b"Very Big Super Secret Salt and Pepper";


        let hash = argon2::hash_raw(password, salt, &config).unwrap();
        for byte in hash {
            print!("{:02x}", byte);
        }
    }
    let elapsed = now.elapsed();

    println!("\n\nTook {:.2}ms", elapsed.as_millis());
}
