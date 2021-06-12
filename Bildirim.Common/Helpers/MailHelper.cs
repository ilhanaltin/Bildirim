﻿using Bildirim.Common.Types;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Bildirim.Common.Helpers
{
    public static class MailHelper
    {
        public static async Task SentVerificationMail(VerificationRequest request)
        {
            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("destek@dolar.net", "Dolar.net - Kullanıcı Doğrula");
            mesaj.To.Add(request.Email);
            mesaj.Subject = "Dolar.Net";
            mesaj.Body = GetVerificationEmailHtml(request);
            mesaj.IsBodyHtml = true; // giden mailin içeriği html olmasını istiyorsak true kalması lazım
            SmtpClient client = new SmtpClient("smtp.yandex.ru", 587);
            client.Credentials = new NetworkCredential("destek@dolar.net", "J8Arn73N");
            client.EnableSsl = true;
            await client.SendMailAsync(mesaj);
        }

        public static string GetVerificationEmailHtml(VerificationRequest request)
        {
            var mystringbuilder = new StringBuilder();
            mystringbuilder.Append("\n");
            mystringbuilder.Append("<!DOCTYPE html>\n");
            mystringbuilder.Append("<html>\n");
            mystringbuilder.Append("  <head>\n");
            mystringbuilder.Append("    <title>Lütfen Kullanıcınızı Onaylayın.</title>\n");
            mystringbuilder.Append("    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">\n");
            mystringbuilder.Append("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n");
            mystringbuilder.Append("    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n");
            mystringbuilder.Append("    <style type=\"text/css\">\n");
            mystringbuilder.Append("      body,table,td,a{\n");
            mystringbuilder.Append("      -webkit-text-size-adjust:100%;\n");
            mystringbuilder.Append("      -ms-text-size-adjust:100%;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      table,td{\n");
            mystringbuilder.Append("      mso-table-lspace:0pt;\n");
            mystringbuilder.Append("      mso-table-rspace:0pt;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      img{\n");
            mystringbuilder.Append("      -ms-interpolation-mode:bicubic;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      img{\n");
            mystringbuilder.Append("      border:0;\n");
            mystringbuilder.Append("      height:auto;\n");
            mystringbuilder.Append("      line-height:100%;\n");
            mystringbuilder.Append("      outline:none;\n");
            mystringbuilder.Append("      text-decoration:none;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      table{\n");
            mystringbuilder.Append("      border-collapse:collapse !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      body{\n");
            mystringbuilder.Append("      height:100% !important;\n");
            mystringbuilder.Append("      margin:0 !important;\n");
            mystringbuilder.Append("      padding:0 !important;\n");
            mystringbuilder.Append("      width:100% !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      a[x-apple-data-detectors]{\n");
            mystringbuilder.Append("      color:inherit !important;\n");
            mystringbuilder.Append("      text-decoration:none !important;\n");
            mystringbuilder.Append("      font-size:inherit !important;\n");
            mystringbuilder.Append("      font-family:inherit !important;\n");
            mystringbuilder.Append("      font-weight:inherit !important;\n");
            mystringbuilder.Append("      line-height:inherit !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      a{\n");
            mystringbuilder.Append("      color:#00bc87;\n");
            mystringbuilder.Append("      text-decoration:underline;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      * img[tabindex=0]+div{\n");
            mystringbuilder.Append("      display:none !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      @media screen and (max-width:350px){\n");
            mystringbuilder.Append("      h1{\n");
            mystringbuilder.Append("      font-size:24px !important;\n");
            mystringbuilder.Append("      line-height:24px !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      }   div[style*=margin: 16px 0;]{\n");
            mystringbuilder.Append("      margin:0 !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      @media screen and (min-width: 360px){\n");
            mystringbuilder.Append("      .headingMobile {\n");
            mystringbuilder.Append("      font-size: 40px !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      .headingMobileSmall {\n");
            mystringbuilder.Append("      font-size: 28px !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("    </style>\n");
            mystringbuilder.Append("  </head>\n");
            mystringbuilder.Append("  <body bgcolor=\"#ffffff\" style=\"background-color: #ffffff; margin: 0 !important; padding: 0 !important;\">\n");
            mystringbuilder.Append("    <div style=\"display: none; font-size: 1px; color: #fefefe; line-height: 1px; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; max-height: 0px; max-width: 0px; opacity: 0; overflow: hidden;\"> - to finish signing up, you just need to confirm that we got your e-mail right within 48 hours. To confirm please click the VERIFY button.</div>\n");
            mystringbuilder.Append("    <center>\n");
            mystringbuilder.Append("      <table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" align=\"center\" valign=\"top\">\n");
            mystringbuilder.Append("        <tbody>\n");
            mystringbuilder.Append("          <tr>\n");
            mystringbuilder.Append("            <td>\n");
            mystringbuilder.Append("              <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" align=\"center\" valign=\"top\" bgcolor=\"#ffffff\" style=\"padding: 0 20px !important;max-width: 500px;width: 90%;\">\n");
            mystringbuilder.Append("                <tbody>\n");
            mystringbuilder.Append("                  <tr>\n");
            mystringbuilder.Append("                    <td bgcolor=\"#ffffff\" align=\"center\" style=\"padding: 10px 0 0px 0;\"><!--[if (gte mso 9)|(IE)]><table align=\"center\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"350\">\n");
            mystringbuilder.Append("<tr>\n");
            mystringbuilder.Append("<td align=\"center\" valign=\"top\" width=\"350\">\n");
            mystringbuilder.Append("<![endif]-->\n");
            mystringbuilder.Append("                      <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"max-width: 500px;border-bottom: 1px solid #e4e4e4 ;\">\n");
            mystringbuilder.Append("                        <tbody>\n");
            mystringbuilder.Append("                          <tr>\n");
            mystringbuilder.Append("                            <td bgcolor=\"#ffffff\" align=\"left\" valign=\"middle\" style=\"padding: 0px; color: #111111; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 48px; font-weight: 400; line-height: 62px;padding:0 0 15px 0;\"><a href=\"https://app.avocode.com\" target=\"_blank\"><img width=\"192\" height=\"59\" alt=\"logo\" src=\"https://dolar.net/assets/images/logo/Bildirim_logo.png\" ></a></td>\n");
            mystringbuilder.Append("                            <td bgcolor=\"#ffffff\" align=\"right\" valign=\"middle\" style=\"padding: 0px; color: #111111; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 48px; font-weight: 400; line-height: 48px;padding:0 0 15px 0;\"><a href=\"https://dolar.net/login\" target=\"_blank\" style=\"font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif;color: #797979;font-size: 12px;font-weight:400;-webkit-font-smoothing:antialiased;text-decoration: none;\">Giriş Yap: dolar.net</a></td>\n");
            mystringbuilder.Append("                          </tr>\n");
            mystringbuilder.Append("                        </tbody>\n");
            mystringbuilder.Append("                      </table><!--[if (gte mso 9)|(IE)]></td></tr></table>\n");
            mystringbuilder.Append("<![endif]-->\n");
            mystringbuilder.Append("                    </td>\n");
            mystringbuilder.Append("                  </tr>\n");
            mystringbuilder.Append("                  <tr>\n");
            mystringbuilder.Append("                    <td bgcolor=\"#ffffff\" align=\"center\" style=\"padding: 0;\"><!--[if (gte mso 9)|(IE)]><table align=\"center\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"350\">\n");
            mystringbuilder.Append("<tr>\n");
            mystringbuilder.Append("<td align=\"center\" valign=\"top\" width=\"350\">\n");
            mystringbuilder.Append("<![endif]-->\n");
            mystringbuilder.Append("                      <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"max-width: 500px;border-bottom: 1px solid #e4e4e4;\">\n");
            mystringbuilder.Append("                        <tbody>\n");
            mystringbuilder.Append("                          <tr>\n");
            mystringbuilder.Append("                            <td bgcolor=\"#ffffff\" align=\"left\" style=\"padding: 20px 0 0 0; color: #666666; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400;-webkit-font-smoothing:antialiased;\">\n");
            mystringbuilder.Append("                                                <p class=\"headingMobile\" style=\"margin: 0;color: #171717;font-size: 26px;font-weight: 200;line-height: 130%;margin-bottom:5px;\">Dolar.Net'e kayıt işlemini tamamlamak için e-postanızı doğrulayın</p>\n");
            mystringbuilder.Append("                            </td>\n");
            mystringbuilder.Append("                          </tr>\n");
            mystringbuilder.Append("                                            <tr>\n");
            mystringbuilder.Append("                                              <td height=\"20\"></td>\n");
            mystringbuilder.Append("                                            </tr>\n");
            mystringbuilder.Append("                          <tr>\n");
            mystringbuilder.Append("                            <td bgcolor=\"#ffffff\" align=\"left\" style=\"padding:0; color: #666666; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400;-webkit-font-smoothing:antialiased;\">\n");
            mystringbuilder.Append("                                                <p style=\"margin:0;color:#585858;font-size:14px;font-weight:400;line-height:170%;\">Dolar.Net'i seçtiğiniz için teşekkür ederiz.</p>\n");
            mystringbuilder.Append("                                                <p style=\"margin:0;margin-top:20px;line-height:0;\"></p>\n");
            mystringbuilder.Append("                                                <p style=\"margin:0;color:#585858;font-size:14px;font-weight:400;line-height:170%;\">Lütfen aşağıdaki düğmeye tıklayarak <b>" + request.Email + "</b> e-posta adresinin size ait olduğunu 48 saat içinde doğrulayın veya bu bağlantıyı kullanın <a style='color: #00bc87;text-decoration: underline;' target='_blank' href='https://dolar.net/account-activation/" + request.Token + "'>https://dolar.net/account-activation/" + request.Token + "</a></p>\n");
            mystringbuilder.Append("                            </td>\n");
            mystringbuilder.Append("                          </tr>\n");
            mystringbuilder.Append("                                            <tr>\n");
            mystringbuilder.Append("                                              <td align=\"center\">\n");
            mystringbuilder.Append("                                                <table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">\n");
            mystringbuilder.Append("                                                  <tr>\n");
            mystringbuilder.Append("                                                    <td align=\"center\" style=\"padding: 33px 0 33px 0;\">\n");
            mystringbuilder.Append("                                                      <table border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"100%\">\n");
            mystringbuilder.Append("                                                        <tr>\n");
            mystringbuilder.Append("                                                          <td align=\"center\" style=\"border-radius: 4px;\" bgcolor=\"#00bc87\"><a href=\"https://dolar.net/account-activation/" + request.Token + "\" style=\"text-transform:uppercase;background:#00bc87;font-size: 13px; font-weight: 700; font-family: Helvetica, Arial, sans-serif; color: #ffffff; text-decoration: none !important; padding: 20px 25px; border-radius: 4px; border: 1px solid #00bc87; display: block;-webkit-font-smoothing:antialiased;\" target=\"_blank\"><span style=\"color: #ffffff;text-decoration: none;\">Aktive Et</span></a></td>\n");
            mystringbuilder.Append("                                                        </tr>\n");
            mystringbuilder.Append("                                                      </table>\n");
            mystringbuilder.Append("                                                    </td>\n");
            mystringbuilder.Append("                                                  </tr>\n");
            mystringbuilder.Append("                                                </table>\n");
            mystringbuilder.Append("                                              </td>\n");
            mystringbuilder.Append("                                            </tr>\n");
            mystringbuilder.Append("                        </tbody>\n");
            mystringbuilder.Append("                      </table><!--[if (gte mso 9)|(IE)]></td></tr></table>\n");
            mystringbuilder.Append("<![endif]-->\n");
            mystringbuilder.Append("                    </td>\n");
            mystringbuilder.Append("                  </tr>\n");
            mystringbuilder.Append("                  <tr>\n");
            mystringbuilder.Append("                    <td bgcolor=\"#ffffff\" align=\"center\" style=\"padding: 0;\"><!--[if (gte mso 9)|(IE)]><table align=\"center\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"350\">\n");
            mystringbuilder.Append("<tr>\n");
            mystringbuilder.Append("<td align=\"center\" valign=\"top\" width=\"350\">\n");
            mystringbuilder.Append("<![endif]-->\n");
            mystringbuilder.Append("                      <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"max-width: 500px;\">\n");
            mystringbuilder.Append("                        <tbody>\n");
            mystringbuilder.Append("                          <tr>\n");
            mystringbuilder.Append("                            <td bgcolor=\"#ffffff\" align=\"center\" style=\"padding: 30px 0 30px 0; color: #666666; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 18px;\">\n");
            mystringbuilder.Append("                                                <p style=\"margin: 0;color: #585858;font-size: 12px;font-weight: 400;-webkit-font-smoothing:antialiased;line-height: 170%;\">Yardım için? <a href=\"mailto:info@dolar.net\" style=\"color: #00bc87;text-decoration: underline;\" target=\"_blank\">info@dolar.net</a> adresine mail atabilirsiniz.</p>\n");
            mystringbuilder.Append("                                                <tr>\n");
            mystringbuilder.Append("                                                  <td bgcolor=\"#ffffff\" align=\"center\" style=\"padding: 0; color: #666666; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 18px;\">\n");
            mystringbuilder.Append("                                                    <p style=\"margin: 0;color: #585858;font-size: 12px;font-weight: 400;-webkit-font-smoothing:antialiased;line-height: 170%;\"></p>\n");
            mystringbuilder.Append("                                                  </td>\n");
            mystringbuilder.Append("                                                </tr>\n");
            mystringbuilder.Append("                                                <tr>\n");
            mystringbuilder.Append("                                                  <td bgcolor=\"#ffffff\" align=\"center\" style=\"padding: 15px 0 30px 0; color: #666666; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 18px;\">\n");
            mystringbuilder.Append("                                                    <p style=\"margin: 0;color: #585858;font-size: 12px;font-weight: 400;-webkit-font-smoothing:antialiased;line-height: 170%;\">Dolar.Net</p>\n");
            mystringbuilder.Append("                                                  </td>\n");
            mystringbuilder.Append("                                                </tr>\n");
            mystringbuilder.Append("                            </td>\n");
            mystringbuilder.Append("                          </tr>\n");
            mystringbuilder.Append("                        </tbody>\n");
            mystringbuilder.Append("                      </table><!--[if (gte mso 9)|(IE)]></td></tr></table>\n");
            mystringbuilder.Append("<![endif]-->\n");
            mystringbuilder.Append("                    </td>\n");
            mystringbuilder.Append("                  </tr>\n");
            mystringbuilder.Append("                </tbody>\n");
            mystringbuilder.Append("              </table>\n");
            mystringbuilder.Append("            </td>\n");
            mystringbuilder.Append("          </tr>\n");
            mystringbuilder.Append("        </tbody>\n");
            mystringbuilder.Append("      </table>\n");
            mystringbuilder.Append("    </center>\n");
            mystringbuilder.Append("\n");
            mystringbuilder.Append("  \n");
            mystringbuilder.Append("  </body>\n");
            mystringbuilder.Append("</html>\n");
            mystringbuilder.Append("\n");

            return mystringbuilder.ToString();

        }

        public static async Task SentRecoverMail(VerificationRequest request)
        {
            try
            {
                MailMessage mesaj = new MailMessage();
                mesaj.From = new MailAddress("destek@soltrabilisim.com.tr", "Fırsatçı - Şifre Yenile");
                mesaj.To.Add(request.Email);
                mesaj.Subject = "Fırsatçı - Şifre Yenile";
                mesaj.Body = GetPasswordRecoverEmailHtml(request);
                mesaj.IsBodyHtml = true; // giden mailin içeriği html olmasını istiyorsak true kalması lazım
                SmtpClient client = new SmtpClient("smtp.yandex.com.tr", 587);
                client.Credentials = new NetworkCredential("destek@soltrabilisim.com.tr", "9jrMXNzv");
                client.EnableSsl = true;
                await client.SendMailAsync(mesaj);
            }
            catch (System.Exception ex)
            {

                throw;
            }
            
        }

        public static string GetPasswordRecoverEmailHtml(VerificationRequest request)
        {
            var mystringbuilder = new StringBuilder();
            mystringbuilder.Append("\n");
            mystringbuilder.Append("<!DOCTYPE html>\n");
            mystringbuilder.Append("<html>\n");
            mystringbuilder.Append("  <head>\n");
            mystringbuilder.Append("    <title>Lütfen yeni şifrenizi alabilmek için yönergeleri uygulayın.</title>\n");
            mystringbuilder.Append("    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">\n");
            mystringbuilder.Append("    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\n");
            mystringbuilder.Append("    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\n");
            mystringbuilder.Append("    <style type=\"text/css\">\n");
            mystringbuilder.Append("      body,table,td,a{\n");
            mystringbuilder.Append("      -webkit-text-size-adjust:100%;\n");
            mystringbuilder.Append("      -ms-text-size-adjust:100%;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      table,td{\n");
            mystringbuilder.Append("      mso-table-lspace:0pt;\n");
            mystringbuilder.Append("      mso-table-rspace:0pt;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      img{\n");
            mystringbuilder.Append("      -ms-interpolation-mode:bicubic;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      img{\n");
            mystringbuilder.Append("      border:0;\n");
            mystringbuilder.Append("      height:auto;\n");
            mystringbuilder.Append("      line-height:100%;\n");
            mystringbuilder.Append("      outline:none;\n");
            mystringbuilder.Append("      text-decoration:none;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      table{\n");
            mystringbuilder.Append("      border-collapse:collapse !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      body{\n");
            mystringbuilder.Append("      height:100% !important;\n");
            mystringbuilder.Append("      margin:0 !important;\n");
            mystringbuilder.Append("      padding:0 !important;\n");
            mystringbuilder.Append("      width:100% !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      a[x-apple-data-detectors]{\n");
            mystringbuilder.Append("      color:inherit !important;\n");
            mystringbuilder.Append("      text-decoration:none !important;\n");
            mystringbuilder.Append("      font-size:inherit !important;\n");
            mystringbuilder.Append("      font-family:inherit !important;\n");
            mystringbuilder.Append("      font-weight:inherit !important;\n");
            mystringbuilder.Append("      line-height:inherit !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      a{\n");
            mystringbuilder.Append("      color:#00bc87;\n");
            mystringbuilder.Append("      text-decoration:underline;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      * img[tabindex=0]+div{\n");
            mystringbuilder.Append("      display:none !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      @media screen and (max-width:350px){\n");
            mystringbuilder.Append("      h1{\n");
            mystringbuilder.Append("      font-size:24px !important;\n");
            mystringbuilder.Append("      line-height:24px !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      }   div[style*=margin: 16px 0;]{\n");
            mystringbuilder.Append("      margin:0 !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      @media screen and (min-width: 360px){\n");
            mystringbuilder.Append("      .headingMobile {\n");
            mystringbuilder.Append("      font-size: 40px !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      .headingMobileSmall {\n");
            mystringbuilder.Append("      font-size: 28px !important;\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("      }\n");
            mystringbuilder.Append("    </style>\n");
            mystringbuilder.Append("  </head>\n");
            mystringbuilder.Append("  <body bgcolor=\"#ffffff\" style=\"background-color: #ffffff; margin: 0 !important; padding: 0 !important;\">\n");
            mystringbuilder.Append("    <div style=\"display: none; font-size: 1px; color: #fefefe; line-height: 1px; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; max-height: 0px; max-width: 0px; opacity: 0; overflow: hidden;\"> - to finish signing up, you just need to confirm that we got your e-mail right within 48 hours. To confirm please click the VERIFY button.</div>\n");
            mystringbuilder.Append("    <center>\n");
            mystringbuilder.Append("      <table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" align=\"center\" valign=\"top\">\n");
            mystringbuilder.Append("        <tbody>\n");
            mystringbuilder.Append("          <tr>\n");
            mystringbuilder.Append("            <td>\n");
            mystringbuilder.Append("              <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" align=\"center\" valign=\"top\" bgcolor=\"#ffffff\" style=\"padding: 0 20px !important;max-width: 500px;width: 90%;\">\n");
            mystringbuilder.Append("                <tbody>\n");
            mystringbuilder.Append("                  <tr>\n");
            mystringbuilder.Append("                    <td bgcolor=\"#ffffff\" align=\"center\" style=\"padding: 10px 0 0px 0;\"><!--[if (gte mso 9)|(IE)]><table align=\"center\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"350\">\n");
            mystringbuilder.Append("<tr>\n");
            mystringbuilder.Append("<td align=\"center\" valign=\"top\" width=\"350\">\n");
            mystringbuilder.Append("<![endif]-->\n");
            mystringbuilder.Append("                      <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"max-width: 500px;border-bottom: 1px solid #e4e4e4 ;\">\n");
            mystringbuilder.Append("                        <tbody>\n");
            mystringbuilder.Append("                          <tr>\n");
            mystringbuilder.Append("                            <td bgcolor=\"#ffffff\" align=\"left\" valign=\"middle\" style=\"padding: 0px; color: #111111; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 48px; font-weight: 400; line-height: 62px;padding:0 0 15px 0;\"><a href=\"https://app.avocode.com\" target=\"_blank\"><img width=\"192\" height=\"59\" alt=\"logo\" src=\"https://api.bildirmatik.com/Images/Media/2021/6/firsatci-logo.PNG\"></a></td>\n");            
            mystringbuilder.Append("                          </tr>\n");
            mystringbuilder.Append("                        </tbody>\n");
            mystringbuilder.Append("                      </table><!--[if (gte mso 9)|(IE)]></td></tr></table>\n");
            mystringbuilder.Append("<![endif]-->\n");
            mystringbuilder.Append("                    </td>\n");
            mystringbuilder.Append("                  </tr>\n");
            mystringbuilder.Append("                  <tr>\n");
            mystringbuilder.Append("                    <td bgcolor=\"#ffffff\" align=\"center\" style=\"padding: 0;\"><!--[if (gte mso 9)|(IE)]><table align=\"center\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"350\">\n");
            mystringbuilder.Append("<tr>\n");
            mystringbuilder.Append("<td align=\"center\" valign=\"top\" width=\"350\">\n");
            mystringbuilder.Append("<![endif]-->\n");
            mystringbuilder.Append("                      <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"max-width: 500px;border-bottom: 1px solid #e4e4e4;\">\n");
            mystringbuilder.Append("                        <tbody>\n");
            mystringbuilder.Append("                          <tr>\n");
            mystringbuilder.Append("                            <td bgcolor=\"#ffffff\" align=\"left\" style=\"padding: 20px 0 0 0; color: #666666; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400;-webkit-font-smoothing:antialiased;\">\n");
            mystringbuilder.Append("                                                <p class=\"headingMobile\" style=\"margin: 0;color: #171717;font-size: 26px;font-weight: 200;line-height: 130%;margin-bottom:5px;\">FIRSATÇI'ya giriş şifrenizi yeniden oluşturmak için aşağıdaki yönergeleri uygulayın.</p>\n");
            mystringbuilder.Append("                            </td>\n");
            mystringbuilder.Append("                          </tr>\n");
            mystringbuilder.Append("                                            <tr>\n");
            mystringbuilder.Append("                                              <td height=\"20\"></td>\n");
            mystringbuilder.Append("                                            </tr>\n");
            mystringbuilder.Append("                          <tr>\n");
            mystringbuilder.Append("                            <td bgcolor=\"#ffffff\" align=\"left\" style=\"padding:0; color: #666666; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400;-webkit-font-smoothing:antialiased;\">\n");
            mystringbuilder.Append("                                                <p style=\"margin:0;color:#585858;font-size:14px;font-weight:400;line-height:170%;\">FIRSATÇI'yı seçtiğiniz için teşekkür ederiz.</p>\n");
            mystringbuilder.Append("                                                <p style=\"margin:0;margin-top:20px;line-height:0;\"></p>\n");
            mystringbuilder.Append("                                                <p style=\"margin:0;color:#585858;font-size:14px;font-weight:400;line-height:170%;\">Lütfen aşağıdaki kodu kullanarak şifrenizi yeniden oluşturun</p>\n");
            mystringbuilder.Append("                            </td>\n");
            mystringbuilder.Append("                          </tr>\n");
            mystringbuilder.Append("                          <tr>\n");
            mystringbuilder.Append("                            <td bgcolor=\"#ffffff\" align=\"left\" style=\"padding: 20px 0 0 0; color: #666666; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400;-webkit-font-smoothing:antialiased;\">\n");
            mystringbuilder.Append("                                                <p class=\"headingMobile\" style=\"margin: 0;color: #171717;font-size: 26px;font-weight: 200;line-height: 130%;margin-bottom:5px;\">" + request.Token + "</p>\n");
            mystringbuilder.Append("                            </td>\n");
            mystringbuilder.Append("                          </tr>\n");
            mystringbuilder.Append("                        </tbody>\n");
            mystringbuilder.Append("                      </table><!--[if (gte mso 9)|(IE)]></td></tr></table>\n");
            mystringbuilder.Append("<![endif]-->\n");
            mystringbuilder.Append("                    </td>\n");
            mystringbuilder.Append("                  </tr>\n");
            mystringbuilder.Append("                  <tr>\n");
            mystringbuilder.Append("                    <td bgcolor=\"#ffffff\" align=\"center\" style=\"padding: 0;\"><!--[if (gte mso 9)|(IE)]><table align=\"center\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" width=\"350\">\n");
            mystringbuilder.Append("<tr>\n");
            mystringbuilder.Append("<td align=\"center\" valign=\"top\" width=\"350\">\n");
            mystringbuilder.Append("<![endif]-->\n");
            mystringbuilder.Append("                      <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" width=\"100%\" style=\"max-width: 500px;\">\n");
            mystringbuilder.Append("                        <tbody>\n");
            mystringbuilder.Append("                          <tr>\n");
            mystringbuilder.Append("                            <td bgcolor=\"#ffffff\" align=\"center\" style=\"padding: 30px 0 30px 0; color: #666666; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 18px;\">\n");
            mystringbuilder.Append("                                                <p style=\"margin: 0;color: #585858;font-size: 12px;font-weight: 400;-webkit-font-smoothing:antialiased;line-height: 170%;\">Yardım için? <a href=\"mailto:info@soltrabilisim.com.tr\" style=\"color: #00bc87;text-decoration: underline;\" target=\"_blank\">info@soltrabilisim.com.tr</a> adresine mail atabilirsiniz.</p>\n");
            mystringbuilder.Append("                                                <tr>\n");
            mystringbuilder.Append("                                                  <td bgcolor=\"#ffffff\" align=\"center\" style=\"padding: 0; color: #666666; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 18px;\">\n");
            mystringbuilder.Append("                                                    <p style=\"margin: 0;color: #585858;font-size: 12px;font-weight: 400;-webkit-font-smoothing:antialiased;line-height: 170%;\"></p>\n");
            mystringbuilder.Append("                                                  </td>\n");
            mystringbuilder.Append("                                                </tr>\n");
            mystringbuilder.Append("                                                <tr>\n");
            mystringbuilder.Append("                                                  <td bgcolor=\"#ffffff\" align=\"center\" style=\"padding: 15px 0 30px 0; color: #666666; font-family: 'Helvetica Neue', Helvetica, Arial, sans-serif; font-size: 16px; font-weight: 400; line-height: 18px;\">\n");
            mystringbuilder.Append("                                                    <p style=\"margin: 0;color: #585858;font-size: 12px;font-weight: 400;-webkit-font-smoothing:antialiased;line-height: 170%;\">FIRSATÇI</p>\n");
            mystringbuilder.Append("                                                  </td>\n");
            mystringbuilder.Append("                                                </tr>\n");
            mystringbuilder.Append("                            </td>\n");
            mystringbuilder.Append("                          </tr>\n");
            mystringbuilder.Append("                        </tbody>\n");
            mystringbuilder.Append("                      </table><!--[if (gte mso 9)|(IE)]></td></tr></table>\n");
            mystringbuilder.Append("<![endif]-->\n");
            mystringbuilder.Append("                    </td>\n");
            mystringbuilder.Append("                  </tr>\n");
            mystringbuilder.Append("                </tbody>\n");
            mystringbuilder.Append("              </table>\n");
            mystringbuilder.Append("            </td>\n");
            mystringbuilder.Append("          </tr>\n");
            mystringbuilder.Append("        </tbody>\n");
            mystringbuilder.Append("      </table>\n");
            mystringbuilder.Append("    </center>\n");
            mystringbuilder.Append("\n");
            mystringbuilder.Append("  \n");
            mystringbuilder.Append("  </body>\n");
            mystringbuilder.Append("</html>\n");
            mystringbuilder.Append("\n");

            return mystringbuilder.ToString();

        }

        public static async Task SentContactMail(ContactRequest contact)
        {
            MailMessage mesaj = new MailMessage();
            mesaj.From = new MailAddress("destek@dolar.net", "Dolar.net-İletişim Formu Verisi");
            mesaj.To.Add("info@dolar.net");
            mesaj.Subject = "Dolar.Net";
            mesaj.Body = GetContactEmailHtml(contact);
            mesaj.IsBodyHtml = true; // giden mailin içeriği html olmasını istiyorsak true kalması lazım
            SmtpClient client = new SmtpClient("smtp.yandex.ru", 587);
            client.Credentials = new NetworkCredential("destek@dolar.net", "J8Arn73N");
            client.EnableSsl = true;
            await client.SendMailAsync(mesaj);
        }

        public static string GetContactEmailHtml(ContactRequest request)
        {
            var mystringbuilder = new StringBuilder();

            mystringbuilder.Append("\n");
            mystringbuilder.Append("<table align=\"left\" style=\"width:100%; margin-bottom:5px;\">");
            mystringbuilder.Append("    <tr align= \"left\"> ");
            mystringbuilder.Append("        <th style=\"width:20%\">Adı Soyadı</th>");
            mystringbuilder.Append("        <td>" + request.NameSurname + "</td>");
            mystringbuilder.Append("    </tr>");
            mystringbuilder.Append("    <tr align= \"left\">");
            mystringbuilder.Append("        <th style=\"width:20%\">E-Posta</td>");
            mystringbuilder.Append("        <td>" + request.Email + "</td>");
            mystringbuilder.Append("    </tr>");
            mystringbuilder.Append("    <tr align= \"left\">");
            mystringbuilder.Append("        <th style=\"width:20%\">GSM</td>");
            mystringbuilder.Append("        <td>" + request.Gsm + "</td>");
            mystringbuilder.Append("    </tr>");
            mystringbuilder.Append("</table>");
            mystringbuilder.Append("<h3><b>Mesaj</b></h3>");
            mystringbuilder.Append("<p>" + request.Message + "</p>");
            mystringbuilder.Append("\n");

            return mystringbuilder.ToString();
        }
    }
}
