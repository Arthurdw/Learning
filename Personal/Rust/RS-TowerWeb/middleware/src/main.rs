extern crate env_logger;
#[macro_use]
extern crate tower_web;

use flate2::Compression;
use tower_web::middleware::deflate::DeflateMiddleware;
use tower_web::middleware::log::LogMiddleware;
use tower_web::ServiceBuilder;

#[derive(Clone, Debug)]
pub struct HelloWorld;

impl_web! {
    impl HelloWorld {
        #[get("/")]
        fn hello_world(&self) -> Result<&'static str, ()> {
            Ok("Hello world")
        }
    }
}

pub fn main() {
    let _ = env_logger::try_init();

    let addr = "127.0.0.1:8080".parse().expect("Invalid address");
    println!("Listening on http://{}", addr);

    ServiceBuilder::new()
        .resource(HelloWorld)
        .middleware(LogMiddleware::new("hello_world::web"))
        .middleware(DeflateMiddleware::new(Compression::best()))
        .run(&addr)
        .unwrap();
}
