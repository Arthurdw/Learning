from discord import Member, Forbidden
from discord.ext import commands
from discord.ext.commands import Context
from utilsx.discord import BotX, Cog


class Bot(BotX):
    def __init__(self):
        super().__init__()
        self.add_cog(CommandHandler)


class CommandHandler(Cog):
    def __init__(self, bot: Bot):
        super().__init__()
        self.bot = bot

    async def check_permissions(self, ctx: Context, user: Member, is_ban: bool = False) -> bool:
        if ctx.author.guild_permissions.ban_members if is_ban else ctx.author.guild_permissions.kick_members:
            await self.embed(ctx, "You do not have enough permissions to execute this command!")
            return False

        if ctx.author == user:
            await self.embed(ctx, f"You can not {'ban' if is_ban else 'kick'} yourself!")
            return False

        if ctx.author.top_role.position < user.top_role.position and not ctx.author == ctx.guild.owner:
            await self.embed(ctx, f"You can not {'ban' if is_ban else 'kick'} a user which has a greater role than "
                                  f"yours!")
            return False
        return True

    @commands.command(name="kick")
    async def kick(self, ctx: Context, user: Member = None, reason: str = "No reason provided!"):
        """
        Kicks a member from your server!
        """
        if not user:
            return await self.embed(ctx, "Please provide a member you want to kick.")

        if await self.check_permissions(ctx, user):
            try:
                await self.embed(user,
                                 f"You have been kicked from {ctx.guild.name} by {str(ctx.author)} ({ctx.author.mention})")
            except Exception:
                pass

            try:
                await user.kick(reason=reason)
                await self.embed(ctx, f"Successfully kicked {user.mention} ({str(user)})")
            except Forbidden:
                await self.embed(ctx, f"I do not have enough permissions to kick that member!")

    @commands.command(name="ban")
    async def ban(self, ctx: Context, user: Member = None, reason: str = "No reason provided!"):
        """
        Ban a member from your server!
        """
        if not user:
            return await self.embed(ctx, "Please provide a member you want to ban.")

        if await self.check_permissions(ctx, user, True):
            try:
                await self.embed(user,
                                 f"You have been banned from {ctx.guild.name} by {str(ctx.author)} ({ctx.author.mention})")
            except Exception:
                pass

            try:
                await user.ban(reason=reason)
                await self.embed(ctx, f"Successfully banned {user.mention} ({str(user)})")
            except Forbidden:
                await self.embed(ctx, f"I do not have enough permissions to ban that member!")


if __name__ == '__main__':
    Bot().run("")
