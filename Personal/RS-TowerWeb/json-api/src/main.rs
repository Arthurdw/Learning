#[macro_use]
extern crate tower_web;

#[macro_use]
extern crate serde_json;

use tower_web::ServiceBuilder;

#[derive(Clone, Debug)]
struct JsonResource;

#[derive(Debug, Response)]
struct MyResponse {
    foo: usize,
    bar: &'static str,
}

#[derive(Debug, Response)]
#[web(status = "201")]
struct CreatedResponse {
    message: &'static str,

    #[web(header)]
    x_my_header: &'static str,

    #[web(header)]
    my_custom_header: &'static str,
}

impl_web! {
    impl JsonResource {
        #[get("/")]
        fn hello_world(&self) -> Result<serde_json::Value, ()> {
            Ok(json!({
                "message": "Hello, World",
            }))
        }

        #[get("/custom")]
        #[content_type("application/json")]
        fn custom(&self) -> Result<MyResponse, ()> {
            Ok(MyResponse {
                foo: 123,
                bar: "Hello, World!",
            })
        }

        #[post("/create")]
        #[content_type("application/json")]
        fn create(&self) -> Result<CreatedResponse, ()> {
            Ok(CreatedResponse {
                message: "created",
                x_my_header: "cool",
                my_custom_header: "epic header",
            })
        }
    }
}

pub fn main() {
    let addr = "127.0.0.1:8080".parse().expect("Invalid address!");
    println!("Listening on http://{}", addr);

    ServiceBuilder::new()
        .resource(JsonResource)
        .run(&addr)
        .unwrap();
}
