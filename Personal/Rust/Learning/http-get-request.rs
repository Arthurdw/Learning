extern crate reqwest;

fn main() {
    // let response_text = reqwest::get("https://arthurdw.github.io/Learning/README.md")
    //     .expect("Oops something went wrong while trying to create a request!")
    //     .text().expect("Could not read response!");
    // println!("{}", response_text);

    match reqwest::get("https://arthurdw.github.io/Learning/README.md") {
        Ok(mut response) => {
            if response.status() == reqwest::StatusCode::Ok {
                match response.text() {
                    Ok(text) => println!("Response Text: {}", text),
                    Err(_) => println!("Could not read response!")
                }
            } else {
                println!("The response wasn't 200 :(")
            }
        }
        Err(_) => println!("Oops something went wrong while trying to create a request!")
    }
}
