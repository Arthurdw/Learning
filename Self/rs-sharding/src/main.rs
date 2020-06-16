use std::env;

use serenity::{
    client::Client,
    model::{channel::Message, gateway::Ready},
    prelude::*,
    framework::standard::{
        StandardFramework, CommandResult,
        macros::{command, group}
    }
};

struct Handler;

impl EventHandler for Handler {
    fn ready(&self, ctx: Context, ready: Ready) {
        println!("Successfully started the bot on {} - Shard: {}", ready.user.name, ctx.shard_id + 1);
    }
}

#[group]
#[commands(shard)]
struct General;

fn main() {
    let mut client = Client::new(&env::var("DISCORD_BOT_TOKEN")
        .expect("token"), Handler)
        .expect("Oops, an error occurred while trying to create this client.");

    client.with_framework(StandardFramework::new()
        .configure(|c| c.prefix("!"))
        .configure(|c| c.case_insensitivity(true))
        .group(&GENERAL_GROUP));

    if let Err(reason) = client.start_shards(10) {
        println!("Oops, something went wrong while running the client.\r\n\
        Here is some more information: {:?}", reason);
    }
}

#[command]
fn shard(ctx: &mut Context, msg: &Message) -> CommandResult {
    let shard = ctx.shard_id + 1;
    msg.channel_id.say(ctx, format!("Currently running on the {}th shard!", shard))?;

    Ok(())
}
