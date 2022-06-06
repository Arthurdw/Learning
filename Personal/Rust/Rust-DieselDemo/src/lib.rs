#[macro_use]
extern crate diesel;
extern crate dotenv;

use std::env;

use diesel::{
    pg::PgConnection,
    prelude::*,
};
use dotenv::dotenv;

use crate::models::{NewPost, Post};

pub mod schema;
pub mod models;

pub fn establish_connection() -> PgConnection {
    dotenv().ok();

    let database_url = env::var("DATABASE_url").expect("DATABASE_URL not found");
    PgConnection::establish(&database_url).expect(&format!("Error connecting to: {}", database_url))
}

pub fn create_post<'a>(conn: &PgConnection, title: &'a str, body: &'a str) -> Post {
    use schema::posts;

    let new_post = NewPost { title, body };

    diesel::insert_into(posts::table)
        .values(&new_post)
        .get_result(conn)
        .expect("Error saving new post.")
}
