using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BitzRestApi.utils;
using BitzRestApi.rest;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BitzRestApi
{
    public partial class Form1 : Form
    {
        BitzApiRestClient restClient;
        /**
         * ------------------------------------------------------------------
         * @param apiKey        必须
         * @param secretKey     必须
         * @param tradePwd      需要下单交易时必须传（addEntrustSheet）
         * ------------------------------------------------------------------
         */
        String apiKey = "";
        String secretKey = "";
        String tradePwd = ""; // 需要下单交易时必须传
        public Form1()
        {
            InitializeComponent();
            this.restClient = new BitzApiRestClient(this.apiKey,this.secretKey,this.tradePwd);
        }

        private void tickerall_Click(object sender, EventArgs e)
        {
            String data = this.restClient.tickerall();
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }


        private void ticker_Click(object sender, EventArgs e)
        {
            String symbol = coinFrom.Text + "_" + coinTo.Text;
            String data = this.restClient.ticker(symbol);
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }
        private void kline_Click(object sender, EventArgs e)
        {
            String symbol = coinFrom.Text + "_" + coinTo.Text;
            String ktype = comboBox1.Text;
            String data = this.restClient.kline(symbol, ktype);
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }
        private void symbolList_Click(object sender, EventArgs e)
        {
            String data = this.restClient.symbolList();
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }
        private void getUserAssets_Click(object sender, EventArgs e)
        {
            String data = this.restClient.getUserAssets();
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String cFrom = coinFrom.Text;
            String cTo = coinTo.Text;
            String data = this.restClient.getUserHistoryEntrustSheet(cFrom,cTo, "1", "1", "5");
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }
        private void addEntrustSheet_Click(object sender, EventArgs e)
        {
            String symbol = coinFrom.Text + "_" + coinTo.Text;
            String data = this.restClient.addEntrustSheet(symbol, "1", "5.0", "2");
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }
        private void nowEntrust_Click(object sender, EventArgs e)
        {
            String cFrom = coinFrom.Text;
            String cTo = coinTo.Text;
            String data = this.restClient.getUserNowEntrustSheet(cFrom, cTo, "1", "1", "5");
            JObject jsonData = (JObject)JsonConvert.DeserializeObject(data);
            txtConsole.Text = jsonData.ToString();
        }



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
