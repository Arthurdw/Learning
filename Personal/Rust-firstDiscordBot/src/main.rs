use serenity::client::Client;
use serenity::model::channel::Message;
use serenity::prelude::{EventHandler, Context};
use serenity::framework::standard::{
    StandardFramework, CommandResult,
    macros::{
        command, group
    }
};

use std::env;
use serenity::model::gateway::Ready;

struct Handler;

impl EventHandler for Handler {
    fn ready(&self, _: Context, ready: Ready) {
        println!("Successfully start my first discord bot!\r\nCurrently running on {}!", ready.user.name)
    }
}

#[group]
#[commands(hello)]
struct General;

fn main() {
    let mut client = Client::new(&env::var("DISCORD_BOT_TOKEN")
        .expect("token"), Handler)
        .expect("Oops, an error occurred while trying to create the client!");

    client.with_framework(StandardFramework::new()
        .configure(|c| c.prefix("!"))
        .configure(|c| c.case_insensitivity(true))
        .group(&GENERAL_GROUP));

    if let Err(reason) = client.start() {
        println!("Oops, something went wrong while running the client.\r\n\
        Here is some more information: {:?}", reason);
    }
}

#[command]
fn hello(ctx: &mut Context, msg: &Message) -> CommandResult {
    msg.channel_id.say(ctx,
                       format!("Hello there <@{}>\rThis is my first bot in rust!", msg.author.id))?;

    Ok(())
}
