using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace UtilityD.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        WebClient wc = new WebClient();
        WeAreDevs_API.ExploitAPI wrdapi = new WeAreDevs_API.ExploitAPI();
        EasyExploits.Module easyapi = new EasyExploits.Module();

        //Auto Execute
        async void WrdAttach()
        {
            wrdapi.LaunchExploit();

            while (wrdapi.isAPIAttached() == false)
            {
                await Task.Delay(1);
            }
            if (wrdapi.isAPIAttached() == true)
            {
                await Task.Delay(2000);
                DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\autoexec");
                FileInfo[] TXTFiles = d.GetFiles("*.txt");
                foreach (FileInfo file in TXTFiles)
                {
                    wrdapi.SendLimitedLuaScript(File.ReadAllText($"./autoexec/{file.Name}"));
                }
                FileInfo[] LUAFiles = d.GetFiles("*.lua");
                foreach (FileInfo file in LUAFiles)
                {
                    wrdapi.SendLimitedLuaScript(File.ReadAllText($"./autoexec/{file.Name}"));
                }
            }
        }
        async void EasyAttach()
        {
            easyapi.LaunchExploit();

            while (easyapi.IsAttached() == false)
            {
                await Task.Delay(1);
            }
            if (easyapi.IsAttached() == true)
            {
                await Task.Delay(2000);
                DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\autoexec");
                FileInfo[] TXTFiles = d.GetFiles("*.txt");
                foreach (FileInfo file in TXTFiles)
                {
                    easyapi.ExecuteScript(File.ReadAllText($"./autoexec/{file.Name}"));
                }
                FileInfo[] LUAFiles = d.GetFiles("*.lua");
                foreach (FileInfo file in LUAFiles)
                {
                    easyapi.ExecuteScript(File.ReadAllText($"./autoexec/{file.Name}"));
                }
            }
        }

        // Script Hub
        [Command("script reviz")]
        public async Task Reviz()
        {
            var embed = new Discord.EmbedBuilder();
            if (easyapi.IsAttached() == true)
            {
                easyapi.ExecuteScript(wc.DownloadString("https://raw.githubusercontent.com/Shade0122/Utility-Source/main/Scripts/Reviz%20Admin.lua"));

                embed.WithTitle("Success Command");
                embed.WithDescription("Script executed: reviz");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Green);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else if (wrdapi.isAPIAttached() == true)
            {
                wrdapi.SendLimitedLuaScript(wc.DownloadString("https://raw.githubusercontent.com/Shade0122/Utility-Source/main/Scripts/Reviz%20Admin.lua"));

                embed.WithTitle("Success Success");
                embed.WithDescription("Script executed: reviz");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Green);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else
            {
                if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
                {
                    embed.WithTitle("Error Command");
                    embed.WithDescription("Please open ROBLOX before executing a script!");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Red);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
                else
                {
                    embed.WithTitle("Error Command");
                    embed.WithDescription("Please attach to ROBLOX before executing a script.");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Red);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
            }
        }

        [Command("script coco")]
        public async Task Coco()
        {
            var embed = new Discord.EmbedBuilder();
            if (easyapi.IsAttached() == true)
            {
                easyapi.ExecuteScript(wc.DownloadString("https://raw.githubusercontent.com/Shade0122/Utility-Source/main/Scripts/Coco%20Hub.lua"));

                embed.WithTitle("Success Command");
                embed.WithDescription("Script executed: coco");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Green);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else if (wrdapi.isAPIAttached() == true)
            {
                wrdapi.SendLimitedLuaScript(wc.DownloadString("https://raw.githubusercontent.com/Shade0122/Utility-Source/main/Scripts/Coco%20Hub.lua"));

                embed.WithTitle("Success Success");
                embed.WithDescription("Script executed: coco");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Green);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else
            {
                if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
                {
                    embed.WithTitle("Error Command");
                    embed.WithDescription("Please open ROBLOX before executing a script!");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Red);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
                else
                {
                    embed.WithTitle("Error Command");
                    embed.WithDescription("Please attach to ROBLOX before executing a script.");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Red);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
            }
        }

        [Command("script dex")]
        public async Task Dex()
        {
            var embed = new Discord.EmbedBuilder();
            if (easyapi.IsAttached() == true)
            {
                easyapi.ExecuteScript(wc.DownloadString("https://raw.githubusercontent.com/Shade0122/Utility-Source/main/Scripts/Dex%20Explorer%20V2.lua"));

                embed.WithTitle("Success Command");
                embed.WithDescription("Script executed: dex");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Green);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else if (wrdapi.isAPIAttached() == true)
            {
                wrdapi.SendLimitedLuaScript(wc.DownloadString("https://raw.githubusercontent.com/Shade0122/Utility-Source/main/Scripts/Dex%20Explorer%20V2.lua"));

                embed.WithTitle("Success Success");
                embed.WithDescription("Script executed: dex");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Green);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else
            {
                if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
                {
                    embed.WithTitle("Error Command");
                    embed.WithDescription("Please open ROBLOX before executing a script!");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Red);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
                else
                {
                    embed.WithTitle("Error Command");
                    embed.WithDescription("Please attach to ROBLOX before executing a script.");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Red);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
            }
        }

        // WeAreDevs Commands
        [Command("ws")]
        public async Task Walkspeed(string echo)
        {
            var embed = new Discord.EmbedBuilder();
            if (easyapi.IsAttached() == true)
            {
                embed.WithTitle("Warning Command");
                embed.WithDescription("This API doesnt support WeAreDevs commands.");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Orange);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else if (wrdapi.isAPIAttached() == true)
            {
                wrdapi.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = " + echo);

                embed.WithTitle("Warning Success");
                embed.WithDescription("Command executed: ws " + echo);
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Green);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else
            {
                if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
                {
                    embed.WithTitle("Error Command");
                    embed.WithDescription("Please open ROBLOX before executing a command!");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Red);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
                else
                {
                    embed.WithTitle("Error Command");
                    embed.WithDescription("Please attach to ROBLOX using the WeAreDevs API!");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Red);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
            }
        }

        [Command("jp")]
        public async Task JumpPower(string echo)
        {
            var embed = new Discord.EmbedBuilder();
            if (easyapi.IsAttached() == true)
            {
                embed.WithTitle("Warning Command");
                embed.WithDescription("This API doesnt support WeAreDevs commands.");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Orange);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else if (wrdapi.isAPIAttached() == true)
            {
                wrdapi.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.JumpPower = " + echo);

                embed.WithTitle("Success Success");
                embed.WithDescription("Command executed: jp " + echo);
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Green);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else
            {
                if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
                {
                    embed.WithTitle("Error Command");
                    embed.WithDescription("Please open ROBLOX before executing a command!");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Red);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
                else
                {
                    embed.WithTitle("Error Command");
                    embed.WithDescription("Please attach to ROBLOX using the WeAreDevs API!");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Red);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
            }
        }

        [Command("btools")]
        public async Task Btools()
        {
            var embed = new Discord.EmbedBuilder();
            if (easyapi.IsAttached() == true)
            {
                embed.WithTitle("Warning Command");
                embed.WithDescription("This API doesnt support WeAreDevs commands.");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Orange);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else if (wrdapi.isAPIAttached() == true)
            {
                wrdapi.SendCommand("btools me");

                embed.WithTitle("Success Success");
                embed.WithDescription("Command executed: btools");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Green);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else
            {
                if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
                {
                    embed.WithTitle("Error Command");
                    embed.WithDescription("Please open ROBLOX before executing a command!");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Red);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
                else
                {
                    embed.WithTitle("Error Command");
                    embed.WithDescription("Please attach to ROBLOX using the WeAreDevs API!");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Red);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
            }
        }

        // Bot Command
        [Command("killrblx")]
        public async Task KillRoblox()
        {
            var embed = new Discord.EmbedBuilder();
            if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
            {
                embed.WithTitle("Error Command");
                embed.WithDescription("No ROBLOX processes were found!");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Red);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else
            {
                foreach (var process in Process.GetProcessesByName("RobloxPLayerBeta"))
                {
                    process.Kill();
                }

                embed.WithTitle("Success Command");
                embed.WithDescription("Command executed: killrblx");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Green);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
        }

        [Command("help")]
        public async Task Help()
        {
            var embed = new Discord.EmbedBuilder();
            embed.WithTitle("Success Command");
            embed.WithDescription("Here are all of listed commands the bot supports:");
            embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
            embed.AddField("attach wrd/easy", "Attaches to ROBLOX with the chosen api you choose.");
            embed.AddField("execfile", "Execute a file within discord.");
            embed.AddField("exec", "Execute code within discord.");
            embed.AddField("script reviz/dex/coco", "Executes the chosen script.");
            embed.AddField("ws [value]", "Changes your players walkspeed value.");
            embed.AddField("jp [value]", "Changes your players jumppower  value.");
            embed.AddField("btools", "Gives your player btools.");
            embed.AddField("help", "Gives you a list of commands.");
            embed.AddField("killrblx", "Kills all ROBLOX processes.");
            embed.AddField("invite", "Invites you to Utility Productions.");
            embed.AddField("whichapi", "Tells you which API is currently attached and which isnt.");
            embed.AddField("close", "Closes the program and shuts off the bot.");
            embed.WithFooter("Utility Productions");
            embed.WithColor(Color.Green);
            await Context.Channel.SendMessageAsync("", false, embed.Build());
        }

        [Command("close")]
        public async Task Close()
        {
            var embed = new Discord.EmbedBuilder();
            embed.WithTitle("Success Command");
            embed.WithDescription("The bot will shortly go offline! Thank you for using UtilityD");
            embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
            embed.WithFooter("Utility Productions");
            embed.WithColor(Color.Green);
            await Context.Channel.SendMessageAsync("", false, embed.Build());

            Environment.Exit(1);
        }

        [Command("whichapi")]
        public async Task WhichAPI()
        {
            var embed = new Discord.EmbedBuilder();
            embed.WithTitle("Success Command");
            embed.WithDescription("Here are all the API's and there current attachment state:");
            embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
            if (wrdapi.isAPIAttached() == true) { embed.AddField("WeAreDevs", "Attached"); } else { embed.AddField("WeAreDevs", "Not Attached"); }
            if (easyapi.IsAttached() == true) { embed.AddField("Easy Exploits", "Attached"); } else { embed.AddField("Easy Exploits", "Not Attached"); }
            embed.WithFooter("Utility Productions");
            embed.WithColor(Color.Green);
            await Context.Channel.SendMessageAsync("", false, embed.Build());
        }

        [Command("invite")]
        public async Task Invite()
        {
            var embed = new Discord.EmbedBuilder();
            embed.WithTitle("Success Command");
            embed.WithDescription("Discord Invite to Utility Productions:");
            embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
            embed.AddField("Invite", "https://discord.com/invite/UumeGPh5h3");
            embed.WithFooter("Utility Productions");
            embed.WithColor(Color.Green);
            await Context.Channel.SendMessageAsync("", false, embed.Build());
        }

        //Attach
        [Command("attach wrd")]
        public async Task Wrd()
        {
            var embed = new Discord.EmbedBuilder();
            if (wrdapi.isAPIAttached() == true)
            {
                embed.WithTitle("Attachment Warning");
                embed.WithDescription("You are already attached to ROBLOX!");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Orange);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else if (easyapi.IsAttached() == true)
            {
                embed.WithTitle("Attachment Warning");
                embed.WithDescription("You are already attached to ROBLOX!");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Orange);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else
            {
                if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
                {
                    embed.WithTitle("Attachment Error");
                    embed.WithDescription("Please open ROBLOX before attaching!");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Red);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
                else
                {
                    WrdAttach();

                    embed.WithTitle("Attachment Success");
                    embed.WithDescription("Attached!");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Green);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
            }
        }

        [Command("attach easy")]
        public async Task Easy()
        {
            var embed = new Discord.EmbedBuilder();
            if (wrdapi.isAPIAttached() == true)
            {
                embed.WithTitle("Attachment Warning");
                embed.WithDescription("You are already attached to ROBLOX!");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Orange);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else if (easyapi.IsAttached() == true)
            {
                embed.WithTitle("Attachment Warning");
                embed.WithDescription("You are already attached to ROBLOX!");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Orange);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else
            {
                if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
                {
                    embed.WithTitle("Attachment Error");
                    embed.WithDescription("Please open ROBLOX before attaching!");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Red);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
                else
                {
                    EasyAttach();

                    embed.WithTitle("Attachment Success");
                    embed.WithDescription("Attached!");
                    embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                    embed.WithFooter("Utility Productions");
                    embed.WithColor(Color.Green);
                    await Context.Channel.SendMessageAsync("", false, embed.Build());
                }
            }
        }

        //Execution
        [Command("execfile")]
        public async Task ExecuteFile()
        {
            var embed = new Discord.EmbedBuilder();
            if (wrdapi.isAPIAttached() == true)
            {
                using (var HttpClient = new HttpClient())
                    wrdapi.SendLimitedLuaScript(await HttpClient.GetStringAsync(Context.Message.Attachments.First().Url));

                embed.WithTitle("Execute File Success");
                embed.WithDescription("File executed");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Green);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else if (easyapi.IsAttached() == true)
            {
                using (var HttpClient = new HttpClient())
                    easyapi.ExecuteScript(await HttpClient.GetStringAsync(Context.Message.Attachments.First().Url));

                embed.WithTitle("Execute File Success");
                embed.WithDescription("File executed");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Green);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else
            {
                embed.WithTitle("Execute File Error");
                embed.WithDescription("Please attach to ROBLOX before executing a file!");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Red);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
        }

        [Command("exec")]
        public async Task Execute(string echo)
        {
            var embed = new Discord.EmbedBuilder();
            if (wrdapi.isAPIAttached() == true)
            {
                wrdapi.SendLimitedLuaScript(echo);

                embed.WithTitle("Execute Script Success");
                embed.WithDescription("Code executed!");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Green);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else if (easyapi.IsAttached() == true)
            {
                easyapi.ExecuteScript(echo);

                embed.WithTitle("Execute Script Success");
                embed.WithDescription("Code executed!");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Green);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
            else
            {
                embed.WithTitle("Execute Script Error");
                embed.WithDescription("Please attach to ROBLOX before executing!");
                embed.WithThumbnailUrl("https://cdn.discordapp.com/attachments/783276775429767179/799249486936277032/Logo2.png");
                embed.WithFooter("Utility Productions");
                embed.WithColor(Color.Red);
                await Context.Channel.SendMessageAsync("", false, embed.Build());
            }
        }
    }
}
//Coded by Shadee#0122, Desinged by ImmuneLion318#1441