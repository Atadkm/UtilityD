using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace UtilityD
{
    public partial class MainWindow : Window
    {
        WeAreDevs_API.ExploitAPI wrdapi = new WeAreDevs_API.ExploitAPI();
        EasyExploits.Module easyapi = new EasyExploits.Module();
        Settings settings = new Settings();
        private DiscordSocketClient _client;
        private CommandService _commands;
        private IServiceProvider _services;
        public MainWindow()
        {
            InitializeComponent();
        }

        public async Task RegisterCommandsAsync() // Regsiter Command
        {
            _client.MessageReceived += HandleCommandAsync;
            await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _services);
        }

        private async Task HandleCommandAsync(SocketMessage arg) // Handle Command
        {
            var message = arg as SocketUserMessage;
            var context = new SocketCommandContext(_client, message);
            if (message.Author.IsBot) return;

            int argPos = 0;
            if (message.HasStringPrefix(settings.SavePrefix, ref argPos))
            {
                var result = await _commands.ExecuteAsync(context, argPos, _services);
                if (!result.IsSuccess) Console.WriteLine(result.ErrorReason);
                if (result.Error.Equals(CommandError.UnmetPrecondition)) await message.Channel.SendMessageAsync(result.ErrorReason);
            }
        }

        private async void CloseButton_Click(object sender, RoutedEventArgs e) // Exit
        {
            DoubleAnimation d = new DoubleAnimation(0, (Duration)TimeSpan.FromMilliseconds(750));
            d.EasingFunction = new QuarticEase();
            BeginAnimation(FrameworkElement.OpacityProperty, d);
            await Task.Delay(TimeSpan.FromMilliseconds(950));
            Environment.Exit(0);
        }

        private void MiniButton_Click(object sender, RoutedEventArgs e) // Minimize
        {
            WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) // Drag Down
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) // Load
        {
            string Text = @"Attach:
attach wrd/easy - Attaches to ROBLOX with the chosen api you choose.

Execution:
execfile - Execute a file within discord.
exec - Execute code within discord.

Script Hub:
script reviz/dex/coco - Executes the chosen script.

WeAreDevs Commands:
ws [value] - Changes your players walkspeed value.
jp [value] - Changes your players jumppower value.
btools - Gives your player btools.

Bot Commands:
help - Gives you a list of commands.
killrblx - Kills all ROBLOX processes.
invite - Invites you to Utility Productions.
whichapi - Tells you which API is currently attached and which isnt.
close - Closes the program and shuts off the bot.";
            TextEditor1.Text = Text;
            TopMostCheck.IsChecked = settings.TopMost;
            SetPrefixBox.Text = settings.SavePrefix;
            InputBox1.Text = settings.SaveToken;
            Modules.ListBoxFunction.ListBoxRefresh(ListBox1, "./scripts", "*.txt");
            Modules.ListBoxFunction.ListBoxRefresh(ListBox1, "./scripts", "*.lua");

            System.Windows.MessageBox.Show("UtilityD Open Source made by:" + "\n" + "Shade#0122 - Main Developer" + "\n" + "ImmuneLion318#1441 - WPF User Interface", "Utility Credits", MessageBoxButton.OK, MessageBoxImage.Information);
            System.Diagnostics.Process.Start("https://discord.com/invite/UumeGPh5h3");
            System.Diagnostics.Process.Start("https://discord.gg/rV3vKju");
        }

        private void TopMostCheck_Checked(object sender, RoutedEventArgs e) // TopMost checked
        {
            settings.TopMost = true;
            settings.Save();
            Topmost = true;
        }

        private void TopMostCheck_Unchecked(object sender, RoutedEventArgs e) // Topmost unchecked
        {
            settings.TopMost = false;
            settings.Save();
            Topmost = false;
        }

        private async void Button_Click(object sender, RoutedEventArgs e) // Set token
        {
            System.Windows.MessageBox.Show("Your token has been set: " + InputBox1.Text, "Utility Information", MessageBoxButton.OK, MessageBoxImage.Information);

            settings.SaveToken = InputBox1.Text;
            settings.Save();

            _client = new DiscordSocketClient();
            _commands = new CommandService();
            _services = new ServiceCollection()
                .AddSingleton(_client)
                .AddSingleton(_commands)
                .BuildServiceProvider();

            await RegisterCommandsAsync();
            await _client.LoginAsync(TokenType.Bot, InputBox1.Text);
            await _client.SetGameAsync("Utility Productions", "https://discord.com/invite/UumeGPh5h3");
            await _client.StartAsync();
            await Task.Delay(-1);
        }

        private void SetPrefixButton_Click(object sender, RoutedEventArgs e) // Set Prefix
        {
            settings.SavePrefix = SetPrefixBox.Text;
            settings.Save();
            System.Windows.MessageBox.Show("Your prefix has been set: " + SetPrefixBox.Text, "Utility Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void RefreshBox_Click(object sender, RoutedEventArgs e) // Refresh ListBox
        {
            Modules.ListBoxFunction.ListBoxRefresh(ListBox1, "./scripts", "*.txt");
            Modules.ListBoxFunction.ListBoxRefresh(ListBox1, "./scripts", "*.lua");
        }

        private void ExecuteFile_Click(object sender, RoutedEventArgs e) // Execute File ListBox
        {
            var embed = new Discord.EmbedBuilder();
            if (wrdapi.isAPIAttached() == true)
            {
                wrdapi.SendLimitedLuaScript(System.IO.File.ReadAllText("scripts\\" + this.ListBox1.SelectedItem.ToString()));
            }
            else if (easyapi.IsAttached() == true)
            {
                easyapi.ExecuteScript(System.IO.File.ReadAllText("scripts\\" + this.ListBox1.SelectedItem.ToString()));
            }
            else
            {
                if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
                {
                    System.Windows.MessageBox.Show("Please open ROBLOX before executing a file!", "Utility Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    System.Windows.MessageBox.Show("Please attach before executing a file!", "Utility Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void ScriptListButton_Click(object sender, RoutedEventArgs e) // Script List Open
        {
            ScriptListBorder.Visibility = Visibility.Hidden;
        }
    }
}
//Coded by Shadee#0122, Desinged by ImmuneLion318#1441