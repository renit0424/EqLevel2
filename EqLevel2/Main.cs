using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EQLevel2
{
    public partial class Main : Form
    {
        private System.Media.SoundPlayer player = null;
        Setting setting;
        public Main()
        {
            InitializeComponent();
            setting = new Setting();
            setting.Main = this;
            Get_timer.Start();
        }

        private void Get_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                setting.checkBox1.Checked = Properties.Settings.Default.check;
                setting.checkBox2.Checked = Properties.Settings.Default.check2;
                string json;
                using (var wc = new System.Net.WebClient())
                {
                    wc.Encoding = System.Text.Encoding.UTF8;
                    json = wc.DownloadString("https://kwatch-24h.net/EQLevel.json");
                }
                var jsonData = JsonConvert.DeserializeObject<EQJson>(json);

                levellabel.Text = $"振動レベル\nLv.{jsonData.l}";
                redlabrl.Text = $"赤：{jsonData.r}";
                yellowlabel.Text = $"黄：{jsonData.y}";
                greenlabel.Text = $"緑：{jsonData.g}";


                using (System.IO.StreamReader file = new System.IO.StreamReader(@"sounds/sound.txt", System.Text.Encoding.UTF8))
                {
                    string line = "";
                    List<string> list = new List<string>();

                    while ((line = file.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                    if (jsonData.l < int.Parse(list[1]))
                    {
                        switch (setting.checkBox1.Checked)
                        {
                            case true:
                                Console.WriteLine("効果音1有効です。");
                                PlaySound(@"sounds/alarm1.wav");
                                break;
                            case false:
                                Console.WriteLine("効果音1は無効です。");
                                break;
                        }
                    }
                    if (jsonData.l > int.Parse(list[3]))
                    {
                        switch (setting.checkBox1.Checked)
                        {
                            case true:
                                Console.WriteLine("効果音2有効です。");
                                PlaySound(@"sounds/alarm2.wav");
                                break;
                            case false:
                                Console.WriteLine("効果音2は無効です。");
                                break;
                        }
                    }
                    if (jsonData.l > int.Parse(list[5]))
                    {
                        switch (setting.checkBox2.Checked)
                        {
                            case true:
                                Console.WriteLine("効果音3有効です。");
                                PlaySound(@"sounds/alarm3.wav");
                                break;
                            case false:
                                Console.WriteLine("効果音3は無効です。");
                                break;
                        }
                    }
                    if (jsonData.l > int.Parse(list[7]))
                    {
                        switch (setting.checkBox2.Checked)
                        {
                            case true:
                                Console.WriteLine("効果音4有効です。");
                                PlaySound(@"sounds/alarm4.wav");
                                break;
                            case false:
                                Console.WriteLine("効果音4は無効です。");
                                break;
                        }
                    }
                    if (jsonData.l > int.Parse(list[9]))
                    {
                        switch (setting.checkBox2.Checked)
                        {
                            case true:
                                Console.WriteLine("効果音5有効です。");
                                PlaySound(@"sounds/alarm5.wav");
                                break;
                            case false:
                                Console.WriteLine("効果音5は無効です。");
                                break;
                        }
                    }
                    if (jsonData.l > int.Parse(list[11]))
                    {
                        switch (setting.checkBox2.Checked)
                        {
                            case true:
                                Console.WriteLine("効果音6有効です。");
                                PlaySound(@"sounds/alarm6.wav");
                                break;
                            case false:
                                Console.WriteLine("効果音6は無効です。");
                                break;
                        }
                        if (jsonData.l > int.Parse(list[13]))
                        {
                            switch (setting.checkBox2.Checked)
                            {
                                case true:
                                    Console.WriteLine("効果音7有効です。");
                                    PlaySound(@"sounds/alarm7.wav");
                                    break;
                                case false:
                                    Console.WriteLine("効果音7は無効です。");
                                    break;
                            }
                        }
                    }
                }
            }
            catch { }
        }
        private void PlaySound(string waveFile)
        {
            player = new System.Media.SoundPlayer(waveFile);
            player.Play();
        }

        private void StopSound()
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null;
            }
        }

        public class EQJson
        {
            public int l { get; set; }
            public int g { get; set; }
            public int y { get; set; }
            public int r { get; set; }
            public string t { get; set; }
            public int e { get; set; }
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.check = setting.checkBox1.Checked;
            Properties.Settings.Default.check2 = setting.checkBox2.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
