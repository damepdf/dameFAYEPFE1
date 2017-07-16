using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram;
using System.Threading;

namespace bootSoutenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Telegram.bot bot = new Telegram.bot();
            Telegram.JSON json = new Telegram.JSON();
            bot.token = "385203321:AAHtRnTNPkndAkj9ikgF7d3vBw0HQSbmapU";
            //bot.token = "446997055:AAGFfl8jrSkF5gB17zbiKlh78wsBfmvxCUw";
            CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.RunWorkerAsync();
            bot.update = "true";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void robot()
        {
            
            bot.update = "true";
                if (bot.message_text != "".ToLower()) {

                    if (bot.message_text == "/id")
                    {
                        bot.sendMessage.send(bot.chat_id, bot.chat_id.ToString());
                    }
                    else if (bot.message_text == "galilee")
                    {
                        bot.sendMessage.parse_mode = "html";
                        bot.sendMessage.send(bot.chat_id, "<a href=\"http://www.sup-galilee.univ-paris13.fr/index.php\">emploi du temps sup galilee</a>");
                    }
                    
                    // else
                    // {
                    //bot.sendMessage.send(bot.chat_id, "bot comprend pas ☹️");
                    // }

                }
                

            
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            Telegram.bot.update = "true";
            Telegram.bot.Automatic_answer.textMessage("anglais incontournable", "merci pour la reponse");
            Telegram.bot.Automatic_answer.textMessage("toiec determine pas le niveau d'anglais", "merci pour la reponse");
            Thread dame = new Thread(robot);
            Thread.Sleep(1);
            dame.IsBackground = true;
            dame.Start();
        }

     
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int a = 1;
            int b = 0;
            while (true)
            {

                bot.update = "true";
                if (bot.message_text == "2")
                {
                    bot.send_inline_keyboard.send(bot.chat_id, "question 1");
                    bot.send_inline_keyboard.keyboard_R1_1 = "pour 👍";
                    bot.send_inline_keyboard.keyboard_R1_1_callback_data = "up";
                    bot.send_inline_keyboard.keyboard_R1_2 = "contre 👎";
                    bot.send_inline_keyboard.keyboard_R1_2_callback_data = "down";
                    bot.send_inline_keyboard.send(bot.chat_id, "valider le toiec pour avoir le diplome");
                }
                if (bot.data == "up")
                {
                    // a += 1;
                    //bot.editMessageInlinekeyboard.send(bot.chat_id, bot.message_id, "question : " + a.ToString());
                    // bot.editMessageInlinekeyboard.keyboard_R1_1 = "👍";
                    //bot.editMessageInlinekeyboard.keyboard_R1_1_callback_data = "up";
                    //bot.editMessageInlinekeyboard.keyboard_R1_2 = "👎";
                    //bot.editMessageInlinekeyboard.keyboard_R1_2_callback_data = "down";
                    //bot.editMessageInlinekeyboard.send(bot.chat_id, bot.message_id, "votant pour " + a.ToString());
                    // bot.send_inline_keyboard.keyboard_R1_1 = "pourquoi ";
                    bot.send_inline_keyboard.send(bot.chat_id, "question 2");
                    bot.send_inline_keyboard.send(bot.chat_id, "pourquoi etes vous POUR?");
                    Telegram.bot.Automatic_answer.textMessage("anglais incontournable", "merci pour la reponse");     
                   
                   // bot.editMessageInlinekeyboard.send(bot.chat_id, bot.message_id, "question : " + a.ToString());

                }

                if (bot.data == "down")
                {
                    //b += 1;
                    //bot.editMessageInlinekeyboard.keyboard_R1_1 = "👍";
                    //bot.editMessageInlinekeyboard.keyboard_R1_1_callback_data = "up";
                    //bot.editMessageInlinekeyboard.keyboard_R1_2 = "👎";
                    //bot.editMessageInlinekeyboard.keyboard_R1_2_callback_data = "down";
                    //bot.editMessageInlinekeyboard.send(bot.chat_id, bot.message_id, "votant contre " + b.ToString());
                    //bot.send_inline_keyboard.keyboard_R1_1 = "pourquoi ";
                    bot.send_inline_keyboard.send(bot.chat_id, "question 2");
                    Telegram.bot.Automatic_answer.textMessage("toiec determine pas le niveau d'anglais", "merci pour la reponse");

                    bot.send_inline_keyboard.send(bot.chat_id, "pourquoi etes vous CONTRE?");

                }

                if (bot.message_text == "/id")
                {
                    bot.sendMessage.send(bot.chat_id, bot.chat_id.ToString());
                }

                if (bot.message_text == "start")
                {
                    bot.sendMessage.send(bot.chat_id, " choix 1: infos formation \n choix : 2 questionnaire evaluation\n");

                    // Telegram.bot.Automatic_answer.textMessage("1", "pas disponiblr");

                }
                if (bot.message_text == "1")
                {
                    bot.sendMessage.parse_mode = "html";
                    bot.sendMessage.send(bot.chat_id, "<a href=\"http://www.sup-galilee.univ-paris13.fr/index.php\">Telecom info et emploi du temps</a>");
                }

              
            

            }
       }
    }
}
