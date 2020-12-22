#[macro_use]
extern crate tower_web;

use tower_web::ServiceBuilder;

#[derive(Clone, Debug)]
pub struct ArgsResource;

impl_web! {
    impl ArgsResource {
        #[get("/hello/:value")]
        fn hello(&self, value: String) -> Result<String, ()> {
            Ok(format!("Hello, {}!", value))
        }

        #[get("/hello/:first/and/:second")]
        fn hello_and(&self, first: String, second: String) -> Result<String, ()> {
            Ok(format!("Hello there {} and {}!", first, second))
        }

        #[get("/num/:num")]
        fn num(&self, num: u32) -> Result<String, ()> {
            Ok(format!("The provided number was {}!", num))
        }

        #[get("/query-string")]
        fn query_string(&self, query_string: String) -> Result<String, ()> {
            Ok(format!("Query received: {:?}", query_string))
        }

        #[get("/request-body")]
        fn request_body(&self, body: Vec<u8>) -> Result<String, ()> {
            Ok(format!("We received {} bytes", body.len()))
        }

        #[get("/headers")]
        fn headers(&self, x_required: String, x_optional: Option<String>) -> Result<String, ()> {
            Ok(format!("We received: x-required = {}; x-optional = {:?}", x_required, x_optional))
        }
    }
}

pub fn main() {
    let addr = "127.0.0.1:8080".parse().expect("Invalid adress provided!");
    println!("Listening on http://{}", addr);

    ServiceBuilder::new()
        .resource(ArgsResource)
        .run(&addr)
        .unwrap();
}
