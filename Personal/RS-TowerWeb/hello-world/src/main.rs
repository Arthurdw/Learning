#[macro_use]
extern crate tower_web;

use tokio::prelude::*;
use tower_web::ServiceBuilder;

#[derive(Clone, Debug)]
pub struct HelloWorld {
    motd: String,
}

impl_web! {
    impl HelloWorld {
        #[get("/")]
        fn hello_world(&self) -> Result<&'static str, ()> {
            Ok("Hello, World!")
        }

        #[get("/motd")]
        fn motd(&self) -> Result<String, ()> {
            Ok(self.motd.to_string())
        }

        #[get("/hello-future")]
        fn hello_future(&self) -> impl Future<Item = String, Error = ()> {
            future::ok("A future that resolves the response".to_string())
        }

        #[post("/print_std")]
        fn print_std(&self) -> Result<&'static str, ()> {
            println!("This got triggered by a post request!");
            Ok("done")
        }
    }
}

pub fn main() {
    let addr = "127.0.0.1:8080".parse().expect("Invalid address");
    println!("Listening on http://{}", addr);

    ServiceBuilder::new().resource(HelloWorld {
        motd: "This is the current MOTD!".to_string(),
    }).run(&addr).unwrap();
}
