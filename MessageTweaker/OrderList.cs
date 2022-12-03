using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace MessageTweaker
{
    public partial class OrderList : Form
    {
        public OrderList()
        {
            InitializeComponent();
            zalupa();
        }

        public void zalupa()
        {
            if (File.Exists("market.json"))
            {
                string json = "";
                using (StreamReader r = new StreamReader("market.json"))
                {
                    json = r.ReadToEnd();
                    r.Close();
                }
                JsonTextReader rjs = new JsonTextReader(new StringReader(json));
                ushort count = 0;
                ushort a = 0;
                string[] ready = { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" };
                rjs.Read(); rjs.Read();
                if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "count")
                {
                    rjs.Read();

                    count = ushort.Parse(rjs.Value.ToString());
                    if (count != 0)
                    {
                        count--;
                    }

                }
                rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read();
                if (rjs.TokenType != JsonToken.StartObject && rjs.TokenType != JsonToken.EndObject)
                {
                    for (int i = 0; i <= count; i++)
                    {
                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "id")
                        {
                            rjs.Read();
                            ready[0] = rjs.Value.ToString();
                            rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read();
                        }

                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "date")
                        {
                            ushort temp = Properties.Settings.Default.UTC;
                            rjs.Read();
                            int tmp = int.Parse(rjs.Value.ToString());
                            System.DateTime time = new System.DateTime(1970, 1, 1, (int)temp, 0, 0, 0, System.DateTimeKind.Utc);
                            time = time.AddSeconds(tmp);
                            ready[3] = time.ToString();
                            rjs.Read();
                        }

                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "status")
                        {
                            rjs.Read();
                            ready[2] = rjs.Value.ToString();
                            rjs.Read();
                        }

                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "items_count")
                        {
                            rjs.Read();
                            ready[7] = rjs.Value.ToString();
                            rjs.Read();
                        }

                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "total_price")
                        {
                            rjs.Read(); rjs.Read(); rjs.Skip(); rjs.Read(); rjs.Skip(); rjs.Read(); rjs.Read();
                            ready[9] = rjs.Value.ToString();
                            rjs.Read(); rjs.Read();
                        }
                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "display_order_id")
                        {
                            rjs.Read();
                            ready[1] = rjs.Value.ToString();
                            rjs.Read();
                        }
                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "comment")
                        {
                            rjs.Read();
                            ready[8] = rjs.Value.ToString();
                            rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Skip(); rjs.Read(); rjs.Skip(); rjs.Read();
                        }
                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "preview_order_items" || ready[9] == "бесплатно")
                        {
                            rjs.Skip(); rjs.Read();
                        }

                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "delivery")
                        {
                            rjs.Read(); rjs.Read(); rjs.Read();
                            ready[6] = rjs.Value.ToString();
                            rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read();
                        }
                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "display_text")
                        {
                            rjs.Read();
                            ready[8] = ready[8] + " Доп. информация:" + rjs.Value.ToString();
                            rjs.Read(); rjs.Read();
                        }
                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "payment")
                        {
                            rjs.Read(); rjs.Read(); rjs.Read();
                            ready[4] = rjs.Value.ToString();
                            rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read();
                            if (rjs.TokenType == JsonToken.EndObject)
                            {
                                rjs.Read();
                                if (rjs.TokenType == JsonToken.EndObject)
                                {
                                    rjs.Read();
                                    if (rjs.TokenType == JsonToken.StartObject)
                                    {
                                        rjs.Read();
                                    }
                                }
                            }
                        }

                        if (ready[0] != "-")
                        {
                            if (a != count)
                            {
                                a++;
                            }
                            else
                            {
                                rjs.Close();
                            }
                            Datatable_0.Rows.Insert(0, ready[0], ready[1], ready[2], ready[3], ready[4], ready[5], ready[6], ready[7], ready[8], ready[9]);
                            ready[0] = "-"; ready[1] = "-"; ready[2] = "-"; ready[3] = "-"; ready[4] = "-"; ready[5] = "-"; ready[6] = "-"; ready[7] = "-"; ready[8] = "-"; ready[9] = "-";
                        }
                    }
                    rjs.Close();
                }
            }

            else
            {
                Close();
            }
        }

        private void Refresh_btn_Click(object sender, System.EventArgs e)
        {
            Datatable_0.Rows.Clear();
            zalupa();
        }
    }
}


/*
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace MessageTweaker
{
    public partial class OrderList : Form
    {
        public OrderList()
        {
            InitializeComponent();
            zalupa();
        }

        public void zalupa()
        {
            if (File.Exists("market.json"))
            {
                string json = "";
                using (StreamReader r = new StreamReader("market.json"))
                {
                    json = r.ReadToEnd();
                    r.Close();
                }
                JsonTextReader rjs = new JsonTextReader(new StringReader(json));
                ushort count = 0;
                ushort a = 0;
                string[] ready = { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" };
                rjs.Read(); rjs.Read();
                if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "count")
                {
                    rjs.Read();

                    count = ushort.Parse(rjs.Value.ToString());
                    if (count != 0)
                    {
                        count--;
                    }

                }
                rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read();
                if (rjs.TokenType != JsonToken.StartObject && rjs.TokenType != JsonToken.EndObject)
                {
                    for (int i = 0; i <= count; i++)
                    {
                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "id")
                        {
                            rjs.Read();
                            ready[0] = rjs.Value.ToString();
                            rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read();
                        }

                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "date")
                        {
                            ushort temp = Properties.Settings.Default.UTC;
                            rjs.Read();
                            int tmp = int.Parse(rjs.Value.ToString());
                            System.DateTime time = new System.DateTime(1970, 1, 1, (int)temp, 0, 0, 0, System.DateTimeKind.Utc);
                            time = time.AddSeconds(tmp);
                            ready[3] = time.ToString();
                            rjs.Read();
                        }

                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "status")
                        {
                            rjs.Read();
                            ready[2] = rjs.Value.ToString();
                            rjs.Read();
                        }

                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "items_count")
                        {
                            rjs.Read();
                            ready[7] = rjs.Value.ToString();
                            rjs.Read();
                        }

                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "total_price")
                        {
                            rjs.Read(); rjs.Read(); rjs.Skip(); rjs.Read(); rjs.Skip(); rjs.Read(); rjs.Read();
                            ready[9] = rjs.Value.ToString();
                            rjs.Read(); rjs.Read();
                        }
                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "display_order_id")
                        {
                            rjs.Read();
                            ready[1] = rjs.Value.ToString();
                            rjs.Read();
                        }
                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "comment")
                        {
                            rjs.Read();
                            ready[8] = rjs.Value.ToString();
                            rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Skip(); rjs.Read(); rjs.Skip(); rjs.Read();
                        }
                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "preview_order_items" || ready[9] == "бесплатно")
                        {
                            rjs.Skip(); rjs.Read();
                        }

                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "delivery")
                        {
                            rjs.Read(); rjs.Read(); rjs.Read();
                            ready[6] = rjs.Value.ToString();
                            rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read();
                        }
                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "display_text")
                        {
                            rjs.Read();
                            ready[8] = ready[8] + " Доп. информация:" + rjs.Value.ToString();
                            rjs.Read(); rjs.Read();
                        }
                        if (rjs.TokenType == JsonToken.PropertyName && rjs.Value.ToString() == "payment")
                        {
                            rjs.Read(); rjs.Read(); rjs.Read();
                            ready[4] = rjs.Value.ToString();
                            rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read(); rjs.Read();
                            if (rjs.TokenType == JsonToken.EndObject)
                            {
                                rjs.Read();
                                if (rjs.TokenType == JsonToken.EndObject)
                                {
                                    rjs.Read();
                                    if (rjs.TokenType == JsonToken.StartObject)
                                    {
                                        rjs.Read();
                                    }
                                }
                            }
                        }

                        if (ready[0] != "-")
                        {
                            if (a != count)
                            {
                                a++;
                            }
                            else
                            {
                                rjs.Close();
                            }
                            Datatable_0.Rows.Insert(0, ready[0], ready[1], ready[2], ready[3], ready[4], ready[5], ready[6], ready[7], ready[8], ready[9]);
                            ready[0] = "-"; ready[1] = "-"; ready[2] = "-"; ready[3] = "-"; ready[4] = "-"; ready[5] = "-"; ready[6] = "-"; ready[7] = "-"; ready[8] = "-"; ready[9] = "-";
                        }
                    }
                    rjs.Close();
                }
            }

            else
            {
                Close();
            }
        }

        private void Refresh_btn_Click(object sender, System.EventArgs e)
        {
            Datatable_0.Rows.Clear();
            zalupa();
        }
    }
}
*/