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
        println!("Running test dm bot on {}!", ready.user.name)
    }
}

#[group]
#[commands(dm)]
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
fn dm(ctx: &mut Context, msg: &Message) -> CommandResult {
    let dm = msg.author.dm(ctx.clone(), |m| {
        m.content(format!("Hello {}", msg.author.name));
        m
    });

    if let Err(reason) = dm {
        msg.channel_id.say(ctx.clone(),format!("Could not send you a message <@{}>!", msg.author.id))?;
        println!("Error while trying to execute the DM command: {}", reason);
    } else {
        msg.channel_id.say(ctx.clone(),format!("Send you a message <@{}>!", msg.author.id))?;
    }

    Ok(())
}