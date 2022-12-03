using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MessageTweaker
{
    public partial class msgtwk : Form
    {
        bool VK_Working = false;
        bool VK_Stopped = true;
        bool Bot_Connected = false;
        uint lastID;
        uint newID;

        public msgtwk()
        {
            InitializeComponent();
            InitConfig();
        }

        private void InitConfig()
        {
            lastID = Properties.Settings.Default.lastID;
        }

        private void VKBridge()
        {
            try
            {
                if (VK_Working == false)
                {
                    VK_Stopped = false;
                    var process = Process.Start("VK.exe");
                    VK_Working = true;
                    process.WaitForExit();
                    int errcode = process.ExitCode;
                    if (errcode == 2)
                    {
                        Disconnect();
                        InfoPanel.Text = "Ошибка. Проверьте ID группы и VK API ключ.";
                    }
                    else if (errcode == 3)
                    {
                        Disconnect();
                        InfoPanel.Text = "Пожалуйста, подставьте VK-API ключ и ID группы VK в datafile.";
                    }
                    else
                    {
                        VK_Stopped = true;
                    }
                    VK_Working = false;
                }
                else
                {
                    InfoPanel.Text = "Один запрос уже отправляется.";
                }
            }

            catch (System.ComponentModel.Win32Exception)
            {
                InfoPanel.Text = "Повреждены файлы.";
                Disconnect(); ;
            }
        }

        async private void Connect()
        {
            InfoPanel.Text = " ";
            if (Bot_Connected == true)
            {
                Disconnect();
            }
            else
            {
                ushort TO = Properties.Settings.Default.Timeout;
                Bot_Connected = true;
                Start.Text = "Остановить";
                VK_Stopped = true;
                string temp = "";
                while (Bot_Connected == true)
                {

                    try
                    {
                        temp = System.IO.File.ReadAllText("lock");
                    }
                    catch (System.IO.FileNotFoundException)
                    {
                        if (VK_Stopped == true)
                        {
                            VKBridge();
                            Disconnect();
                            break;
                        }
                    }
                    catch (System.IO.IOException)
                    {
                        await Task.Delay(1);
                    }

                    if (temp == "")
                    {
                        Disconnect();
                        InfoPanel.Text = "Невозможно начать. Повреждены файлы.";
                        break;
                    }
                    uint Protection = uint.Parse(temp);
                    if (Protection == 1)
                    {
                        InfoPanel.Text = "Защита от повреждения JSON.";
                        await Task.Delay(2);
                    }
                    else if (Protection == 0)
                    {
                        if (VK_Stopped == true)
                        {
                            await Task.Run(async() =>
                            {
                                await Task.Delay(TO);
                                CountChecker();
                                VKBridge();
                            });
                        }
                    }
                }
            }
        }
        async private void CountChecker()
        {
            string json = "";
            try
            {
                using (StreamReader r = new StreamReader("market.json"))
                {
                    json = r.ReadToEnd();
                    r.Close();
                }
                JsonTextReader rjs = new JsonTextReader(new StringReader(json));
                rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read();
                if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "id")
                {
                    rjs.Read();
                    newID = uint.Parse(rjs.Value.ToString());
                }
                rjs.Close();
                try
                {
                    if (lastID != newID)
                    {
                        lastID = newID;
                        Properties.Settings.Default.lastID = lastID;
                        Properties.Settings.Default.Save();
                        SoundPlayer player = new SoundPlayer();
                        try
                        {
                            player.SoundLocation = "sound.wav";
                            player.Load();
                            player.Play();
                        }
                        catch (FileNotFoundException)
                        {
                            InfoPanel.Text = "*звук*. Файла звука нет...";
                        }
                        catch (InvalidOperationException)
                        {
                            InfoPanel.Text = "*звук*. Файла звука нет...";
                        }
                    }
                }
                catch (System.IO.FileNotFoundException)
                {
                }
                catch (System.IO.IOException)
                {
                    await Task.Delay(1);
                }
            }
            catch (System.IO.IOException)  {
                await Task.Delay(1);
            }
            await Task.Delay(5);
        }
        private void Disconnect()
        {
            Start.Invoke((MethodInvoker)delegate { Start.Text = "Запустить";});
            Bot_Connected = false;
            VK_Stopped = true;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            if (Bot_Connected == true)
            {
                Connect();
                Settings settings = new Settings();
                settings.ShowDialog();
                Connect();
            }
            else
            {
                Settings settings = new Settings();
                settings.ShowDialog();
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (File.Exists("VK.exe") != true)
            {
                InfoPanel.Text = "Файлы повреждены. Переустановите программу.";
                Disconnect();
            }
            else if (File.Exists("lock") != true)
            {
                Connect();
                Disconnect();
                InfoPanel.Text = "Настройте \"datefile\" в папке.";
            }
            else
            {
                Connect();
            }
        }

        private void OrderList_Click(object sender, EventArgs e)
        {

            OrderList orderlist = new OrderList();
            try
            {
                orderlist.ShowDialog();
            }
            catch (System.ObjectDisposedException)
            {
                InfoPanel.Text = "Отсутствует информация о маркете.";
            }
        }
    }
}
