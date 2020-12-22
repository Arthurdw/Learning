#[macro_use]
extern crate tower_web;

use tower_web::ServiceBuilder;

#[derive(Clone, Debug)]
pub struct ArgResource;

#[derive(Debug, Extract)]
struct Foo {
    foo: u32,
    bar: Option<String>,
}

impl_web! {
    impl ArgResource {
        #[get("/query-string")]
        fn hello_query_string(&self, query_string: Option<Foo>) -> Result<String, ()> {
            Ok(format!("Query: {:?}", query_string))
        }
    }
}

pub fn main() {
    let addr = "127.0.0.1:8080".parse().expect("Invalid address provided!");
    println!("Listening on http://{}", addr);

    ServiceBuilder::new()
        .resource(ArgResource)
        .run(&addr)
        .unwrap();
}
