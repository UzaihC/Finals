using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Finals
{
    class Email
    {
        public void SendEmail(string reciever, string OTP)
        {
            try
            {
                string senderemail = "deanuzaihconcepcion20@gmail.com";
                string password = "kolx pvjq bkgl bnag";


                SmtpClient client = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(senderemail, password),
                    EnableSsl = true
                };


                string htmlBody = $@"
            <html lang=""en"">
                        <head>
                            <meta charset=""UTF-8"">
                            <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                            <title>OTP Verification</title>
                            <style>
                                body {{
                                    font-family: Arial, sans-serif;
                                    background-color: #f4f4f4;
                                    padding: 20px;
                                    text-align: center;
                                }}
                                .email-container {{
                                    max-width: 500px;
                                    background: #fff;
                                    padding: 20px;
                                    border-radius: 8px;
                                    box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
                                    margin: auto;
                                }}
                                .otp-code {{
                                    font-size: 24px;
                                    font-weight: bold;
                                    color: #333;
                                    padding: 10px;
                                    background: #e0e0e0;
                                    border-radius: 5px;
                                    display: inline-block;
                                    margin: 10px 0;
                                }}
                                .footer {{
                                    font-size: 12px;
                                    color: #666;
                                    margin-top: 20px;
                                }}
                            </style>
                        </head>
                        <body>
                            <div class=""email-container"">
                                <h2>🔑 Your One-Time Password (OTP)</h2>
                                <p>Use the following OTP to verify your identity:</p>
                                <div class=""otp-code"">{OTP}</div>
                                <p>This code is valid for 5 minutes.</p>
                                <p class=""footer"">© 2025 Your Company. All rights reserved.</p>
                            </div>
                        </body>
                        </html>";


                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(senderemail),
                    Subject = "OTP",
                    Body = htmlBody,
                    IsBodyHtml = true
                };

                mail.To.Add(reciever);


                client.Send(mail);

                Console.WriteLine("OTP Code sent successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        public static void SendReceipt(string receiver, string currentUsername, string amount, string recipient)
        {
            try
            {
                string senderemail = "deanuzaihconcepcion20@gmail.com";
                string password = "kolx pvjq bkgl bnag";


                SmtpClient client = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(senderemail, password),
                    EnableSsl = true
                };


                string htmlBody = $@"
            <html>
            <head>
                <style>
                    body {{
                        font-family: Arial, sans-serif;
                        background-color: #f4f4f4;
                        text-align: center;
                        padding: 20px;
                    }}
                    .container {{
                        background-color: #ffffff;
                        padding: 20px;
                        border-radius: 10px;
                        box-shadow: 0px 0px 10px #ccc;
                        max-width: 600px;
                        margin: auto;
                    }}
                    h1 {{
                        color: #28a745;
                    }}
                    p {{
                        font-size: 16px;
                        color: #555;
                    }}
                    .footer {{
                        margin-top: 20px;
                        font-size: 14px;
                        color: #888;
                    }}
                </style>
            </head>
            <body>
                <div class='container'>
                    <h1>From All of Us – Thank You, {currentUsername}!</h1>
                    <p><strong>{amount}</strong> – that's more than just a number. It's a symbol of hope, a gesture of kindness, and a spark that brings light to someone’s life.</p>
                    <p>Because of you, <strong>{recipient}</strong> will receive the support they need — and the world feels just a little more compassionate today.</p>
                    <p>Your generosity doesn't just make a difference — it inspires change, builds bridges, and reminds us all that humanity still cares.</p>
                    <p><em>Thank you for believing, for giving, and for being part of something bigger than yourself.</em></p>
                    <div class='footer'>
                    <p>With deep appreciation,</p>
                    <p><strong>– The Leveling Corp Team</strong></p>
                    </div>
                </div>
            </body>
            </html>";


                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(senderemail),
                    Subject = "Donation Receipt – Thank You from Leveling Corp",
                    Body = htmlBody,
                    IsBodyHtml = true
                };

                mail.To.Add(receiver);


                client.Send(mail);

                Console.WriteLine("HTML Email sent successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}