extern crate image;
extern crate webp;

use std::fs::File;
use std::io::Write;
use std::ops::Deref;
use std::time::{SystemTime, UNIX_EPOCH, Instant};

use image::GenericImageView;
use image::imageops::FilterType;
use webp::Encoder;

fn main() {
    let start = Instant::now();
    let mut img = image::open("assets/8kimage.jpg").unwrap();
    img = img.resize_to_fill(500, 500, FilterType::Lanczos3);
    let encoded = Encoder::from_rgb(img.as_bytes(), img.width(), img.height()).encode_lossless();

    let _ = match File::create(format!("./assets/out-{:?}.webp", SystemTime::now().duration_since(UNIX_EPOCH).expect("Time went back?"))) {
        Ok(mut file) => file.write_all(encoded.deref()),
        Err(e) => panic!(e)
    };
    let duration = start.elapsed();
    println!("Duration: {:?}", duration);
}
