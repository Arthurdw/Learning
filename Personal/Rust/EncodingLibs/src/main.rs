use std::{
    collections::HashMap,
    fs::{self, File},
    io::Write,
};

use borsh::{BorshDeserialize, BorshSerialize};
use std::time::Instant;

fn main() {
    type SimpleKeyValue = HashMap<String, (String, String)>;

    let sample = HashMap::from([
        (
            "hello".to_string(),
            ("world".to_string(), "2022-04-12T22:10:57+02:00".to_string()),
        ),
        (
            "foo".to_string(),
            ("bar".to_string(), "2022-04-12T22:10:57+02:00".to_string()),
        ),
        (
            "bake".to_string(),
            ("eggs".to_string(), "2022-04-12T22:10:57+02:00".to_string()),
        ),
    ]);

    println!("Borsh:");

    let borsh_start = Instant::now();
    let encoded = sample.try_to_vec().unwrap();
    let borsh_elapsed = borsh_start.elapsed();
    println!(
        "Encoding time: {:.2?}, size: {:?}",
        borsh_elapsed,
        &encoded.len()
    );

    let mut file = File::create("data.borsh").unwrap();
    file.write_all(&encoded).unwrap();

    let data = fs::read("data.borsh").unwrap();
    let borsh_decode_start = Instant::now();
    let _decoded_from_file: SimpleKeyValue = HashMap::try_from_slice(&data).unwrap();
    let borsh_decode_elapsed = borsh_decode_start.elapsed();
    println!("Decoding time: {:.2?}", borsh_decode_elapsed);

    println!("\nJSON Serde:");

    let json_start = Instant::now();
    let json = serde_json::to_vec(&sample).unwrap();
    let json_elapsed = json_start.elapsed();
    println!(
        "Encoding time: {:.2?}, size: {:?}",
        json_elapsed,
        &json.len()
    );

    let mut json_file = File::create("data.json").unwrap();
    json_file.write_all(&json).unwrap();

    let json_data = fs::read("data.json").unwrap();
    let json_decode_start = Instant::now();
    let _decoded_from_json: SimpleKeyValue = serde_json::from_slice(&json_data).unwrap();
    let json_decode_elapsed = json_decode_start.elapsed();
    println!("Decoding time: {:.2?}", json_decode_elapsed);

    println!("\nBincode:");

    let bicode_start = Instant::now();
    let bincode_encoded = bincode::serialize(&sample).unwrap();
    let bincode_elapsed = bicode_start.elapsed();
    println!(
        "Encoding time: {:.2?}, size: {:?}",
        bincode_elapsed,
        &bincode_encoded.len()
    );

    let mut bincode_file = File::create("data.bin").unwrap();
    bincode_file.write_all(&bincode_encoded).unwrap();

    let bincode_data = fs::read("data.bin").unwrap();
    let bincode_decode_start = Instant::now();
    let _bincode_decoded: SimpleKeyValue = bincode::deserialize(&bincode_data).unwrap();
    let bincode_decode_elapsed = bincode_decode_start.elapsed();
    println!("Decoding time: {:?}", bincode_decode_elapsed);
}
