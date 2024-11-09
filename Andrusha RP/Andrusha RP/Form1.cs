using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Andrusha_RP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
            blocked_nickname[0] = "IVAN_PUPOK";
            blocked_nickname[1] = "Kostya_Top";
            blocked_nickname[2] = "Andrusha";
            blocked_nickname[3] = "Jeka_Top1338";
            tabPage2.Parent = null;
            tabPage3.Parent = null;
            tabPage4.Parent = null;
            tabPage5.Parent = null;
            tabPage6.Parent = null;
            tabPage7.Parent = null;
            tabPage8.Parent = null;
            
        }

        private const string Path = "C:\\Users\\Public\\Documents\\firstLog.txt";
        Random rnd = new Random();

        int i = 0;
        int c = 0;
        int ending = 0;
        string name;
        string nickname;
        string password;
        string[] blocked_nickname = new string[100];
        int skip = 0;
        bool firstTimeOpen = true;

        private string Current_Text(int c)
        {
            string[] text = new string[10000]; //чтоб не было ошибки

            switch (ending)
            {

                case 0:
                    {

                        switch (c)
                        {

                            case 0:
                                {
                                    write_name.Visible = true;
                                    text[0] = "Введите имя";
                                    name = write_name.Text;
                                    break;
                                }

                            case 1:
                                {
                                    write_name.Visible = false;
                                    name = write_name.Text;
                                    pictureBox2.Visible = false;
                                    Background.Image = Properties.Resources.zavod;
                                    glav_panel.BackColor = Color.Transparent;
                                    text[1] = "Ну сколько можно!";
                                    break;
                                }

                            case 2:
                                {
                                    text[2] = "Мне 37 лет, а я никак не могу найти себе развлечние после работы!";
                                    break;
                                }

                            case 3:
                                {
                                    text[3] = "Все что и делаю после работы это, пью пиво и смотрю телик!";
                                    break;
                                }

                            case 4:
                                {
                                    text[4] = "А вот раньше умели делать игры!";

                                    break;
                                }

                            case 5:
                                {
                                    Background.Image = Properties.Resources._9_samyh_populyarnyh_mifov_gta_san_andreas_16349971542037098424;
                                    text[5] = " Чего только стоит легендарная GTA San Andres";
                                    break;
                                }

                            case 6:
                                {
                                    Background.Image = Properties.Resources.zavod;
                                    text[6] = "Все современные игры фигня!";
                                    break;
                                }

                            case 7:
                                {
                                    text[7] = "Разрабы хотят, чтоб мы хавали их мусор за 60 баксов";
                                    break;
                                }

                            case 8:
                                {
                                    text[8] = "Или же закидывали их донатом";
                                    break;
                                }

                            case 9:
                                {
                                    text[9] = "Видимо я больше никогда не поиграю в хорошую игру...";
                                    break;
                                }

                            case 10:
                                {
                                    text[10] = $"{name} заметил подходящего к нему коллегу";
                                    break;
                                }

                            case 11:
                                {
                                    text[11] = $"Слыш, {name}!";
                                    label_text.ForeColor = Color.Orange;
                                    break;
                                }

                            case 12:
                                {
                                    text[12] = $"Что тебе, Николаевич?";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 13:
                                {
                                    text[13] = "Я себе на копухтер скачал новую игрушку";
                                    label_text.ForeColor = Color.Orange;
                                    break;
                                }

                            case 14:
                                {
                                    text[14] = $"Я думал ты кроме танков вообще ни во что не играешь";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 15:
                                {

                                    text[15] = "С чего ты взял!";
                                    label_text.ForeColor = Color.Orange;
                                    break;
                                }

                            case 16:
                                {
                                    text[16] = "Ладно к чему это я";
                                    break;
                                }

                            case 17:
                                {
                                    text[17] = "Так вот, бродя по просторам ютуба";
                                    break;
                                }

                            case 18:
                                {
                                    text[18] = "Я нашел летсплей на Andrusha RP";
                                    break;
                                }

                            case 19:
                                {
                                    text[19] = "АНДРЮША РП!?";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 20:
                                {
                                    text[20] = "Это ведь хрень для школьников! Как в это играть?";
                                    break;
                                }

                            case 21:
                                {
                                    text[21] = "Ты меня не перебивай";
                                    label_text.ForeColor = Color.Orange;
                                    break;
                                }

                            case 22:
                                {
                                    text[22] = "Посмотрел я, скачал и просидел там до трех ночи";
                                    break;
                                }

                            case 23:
                                {
                                    text[23] = "Именно по этому я опоздал на работу";
                                    break;
                                }

                            case 24:
                                {
                                    text[24] = "Скачай игру, имбовый проект";
                                    break;
                                }

                            case 25:
                                {
                                    text[25] = "Подумаю…";
                                    label_text.ForeColor = Color.White;

                                    break;
                                }

                            case 26:
                                {
                                    text[26] = "Николаевич отходит";
                                    break;
                                }

                            case 27:
                                {
                                    text[27] = "А может реально";
                                    break;
                                }

                            case 28:
                                {
                                    text[28] = "Я давно не играл в свою либимую ГТА";
                                    break;
                                }

                            case 29:
                                {
                                    text[29] = "А в SAMP играл лет 15 назад";
                                    break;
                                }

                            case 30:
                                {
                                    text[30] = "Посмотрю я на ваш Andrusha RP";
                                    break;
                                }

                            case 31:
                                {
                                    Background.Image = Properties.Resources.black;
                                    text[31] = "..."; // черный экран
                                    break;
                                }

                            case 32:
                                {
                                    Background.Image = Properties.Resources.загруженное;
                                    text[32] = "..."; // коридор главного героя
                                    break;
                                }

                            case 33:
                                {
                                    text[33] = "Эхх...";
                                    break;
                                }

                            case 34:
                                {
                                    text[34] = "Было время, когда я беззаботно играл в игры";
                                    break;
                                }

                            case 35:
                                {
                                    text[35] = "Было раньше время...";
                                    break;
                                }

                            case 36:
                                {
                                    Background.Image = Properties.Resources._153362986213385651;
                                    text[36] = "...";//молча зоходит в комноту с компом
                                    break;
                                }

                            case 37:
                                {
                                    Background.Image = Properties.Resources.komp;
                                    text[37] = "..."; //молча садится за комп
                                    break;
                                }

                            case 38:
                                {
                                    //звук
                                    text[38] = "..."; //молча запускает его
                                    break;
                                }

                            case 39:
                                {
                                    Background.Image = Properties.Resources.komp2;
                                    text[39] = "..."; //загрузка
                                    break;
                                }

                            case 40:
                                {
                                    Background.Image = Properties.Resources.komp1;
                                    text[40] = "..."; //рабочий стол
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 41:
                                {
                                    text[41] = "..."; //на весь экран
                                    break;
                                }

                            case 42:
                                {
                                    text[42] = "AndrushaRP.org"; // это в гугл
                                    break;
                                }

                            case 44:
                                {
                                    text[44] = "И вот!"; 
                                    break;
                                }

                            case 45:
                                {
                                    text[45] = "Наконец я увижу понастоящему хорошую игру!";
                                    break;
                                }

                            case 46:
                                {
                                    text[46] = $"{name} видит окно лаунчера и возле кнопки играть висит банер";
                                    break;
                                }

                            case 47:
                                {
                                    text[47] = $"'На 1 сервере Андрюша выберает новичков для нового видео'";
                                    break;
                                }

                            case 48:
                                {
                                    text[48] = "Ну...";
                                    break;
                                }

                            case 49:
                                {
                                    text[49] = "Испытаю удачу, вдруг попаду в видео";
                                    break;
                                }

                            case 50:
                                {
                                    Background.Image = Properties.Resources.komp;
                                    text[50] = " ";
                                    break;
                                }

                            case 51:
                                {
                                    Background.Image = Properties.Resources._4foMi8O;
                                    text[51] = "Вот и он!";
                                    break;
                                }

                            case 52:
                                {
                                    text[52] = "Долгожданный спавн Андрюшаа РП";
                                    break;
                                }

                            case 53:
                                {
                                    text[53] = "Надо подойти к кому-нибудь";
                                    break;
                                }

                            case 54:
                                {
                                    text[54] = "Узнать как играть и развиться";
                                    break;
                                }

                            case 55:
                                {
                                    Background.Image = Properties.Resources.загруженное__1_;
                                    text[55] = "Я новенький, мог бы ты помочь?";
                                    break;
                                }

                            case 56:
                                {
                                    text[56] = "Да иди ты!";
                                    label_text.ForeColor = Color.BlueViolet;

                                    break;
                                }

                            case 57:
                                {
                                    text[57] = "У меня друг новичок, его должен Андрюша выбрать!";
                                    break;
                                }

                            case 58:
                                {
                                    text[58] = "Надеюс смогу пробиться в админы";
                                    break;
                                }

                            case 59:
                                {
                                    text[59] = "А ты только мешать будешь!";
                                    break;
                                }

                            case 60:
                                {
                                    text[60] = "Ясно, пойду попрошу другого";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 61:
                                {
                                    text[61] = "ЭТО ЖЕ ГЛАВНЫЙ ПОМОЩНИК АНДРЮШИ ЗАШЕЛ!!";
                                    label_text.ForeColor = Color.BlueViolet;
                                    break;
                                }

                            case 62:
                                {
                                    Background.Image = Properties.Resources.загруженное__2_;
                                    text[62] = "На сервер зашел великий и неповториммый Jeka_Top1338";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 63:
                                {
                                    text[63] = "Андрюша зайдет через 10 минут, пока ждем всех";
                                    label_text.ForeColor = Color.GreenYellow;
                                    break;
                                }

                            case 64:
                                {
                                    text[64] = "Все игроки встали в строй";
                                    break;
                                }

                            case 65:
                                {
                                    text[65] = "Я последовал им и также встал в строй";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 66:
                                {
                                    text[66] = "Андрюша запешел через 17 минут";
                                    break;
                                }

                            case 67:
                                {
                                    text[67] = "Я уже устал его ждать и хотел по скорее это закончить";
                                    break;
                                }

                            case 68:
                                {
                                    Background.Image = Properties.Resources.загруженное__3_;
                                    text[68] = "Так вот, надо выбрать человека для видео";
                                    label_text.ForeColor = Color.Red;
                                    break;
                                }

                            case 69:
                                {
                                    text[69] = "Пофиг, Жека выбирай ты, мне лень";
                                    break;
                                }

                            case 70:
                                {
                                    text[70] = "Серьёзно?!";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 71:
                                {
                                    text[71] = "Мало того, что Андрюша это хриплый школьник";
                                    break;
                                }

                            case 72:
                                {
                                    text[72] = "Так он ещё так наплевательские относиться к своему проекту";
                                    break;
                                }

                            case 73:
                                {
                                    text[73] = "Где все его почитают и мечтают встретится";
                                    break;
                                }

                            case 74:
                                {
                                    text[74] = "Доверяет своему другу выбор, который многие хотят, чтоб он сделал сам";
                                    break;
                                }

                            case 75:
                                {
                                    text[75] = "Жека немедля подходит к первому человеку";
                                    break;
                                }

                            case 76:
                                {
                                    text[76] = "И им оказываюся я";
                                    break;
                                }

                            case 77:
                                {
                                    text[77] = "Ты!";
                                    label_text.ForeColor = Color.GreenYellow;
                                    break;
                                }

                            case 78:
                                {
                                    text[78] = "Я? Вы уверены?";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 79:
                                {
                                    Background.Image = Properties.Resources.pNG8ySw;
                                    text[79] = "Не успел я сказать, как меня телепортировали в зону для съемок";
                                    break;
                                }

                            case 80:
                                {
                                    text[80] = "Мы щас с тобой снимим очередное видео, но в начале надо рекламу снять";
                                    label_text.ForeColor = Color.Red;
                                    break;
                                }

                            case 81:
                                {
                                    text[81] = "А то придурки с рекламой будут орать типо";
                                    break;
                                }

                            case 82:
                                {
                                    text[82] = "Реклама фигня, переснимайте!";
                                    break;
                                }

                            case 83:
                                {
                                    Background.Image = Properties.Resources.pNG8ySw;
                                    text[83] = "...";
                                    label_text.ForeColor = Color.White;
                                    button5.Visible = true;
                                    button6.Visible = true;
                                    break;
                                }
                        }

                        break;
                    }

                case 1:
                    {
                        switch (c)
                        {
                            case 100:
                                {
                                    Background.Image = Properties.Resources.загруженное__2_;
                                    text[100] = "Иди к черту!";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 101:
                                {
                                    text[101] = "Что за мусорный проект восхваления тебя и выжимания денег из тупых школьников?";
                                    break;
                                }

                            case 102:
                                {
                                    text[102] = "ЖЕКА БАНЬ ЕГО!!!";
                                    label_text.ForeColor = Color.Red;
                                    break;
                                }

                            case 103:
                                {
                                    text[103] = "Ща!";
                                    label_text.ForeColor = Color.GreenYellow;
                                    break;
                                }

                            case 104:
                                {
                                    Background.Image = Properties.Resources.загруженное__3_;
                                    text[104] = "ЁКАРНЫЙ БАБАЙ!";
                                    break;
                                }

                            case 105:
                                {
                                    text[105] = "Я колу пролил на клаву!";
                                    break;
                                }

                            case 106:
                                {
                                    text[106] = "На заднем фоне слышаться крики матери";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 107:
                                {
                                    text[107] = "Я тебе щас дам! Паршивец гребаный!";
                                    label_text.ForeColor = Color.Green;
                                    break;
                                }

                            case 108:
                                {
                                    Background.Image = Properties.Resources.загруженное__1_;

                                    text[108] = "С этого момента";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 109:
                                {
                                    text[109] = "Неповторимый Jeka_Top1338 теряет провод от компа на долгое время";
                                    break;
                                }

                            case 110:
                                {
                                    Background.Image = Properties.Resources.загруженное__2_;
                                    text[110] = "Мы не сможем снять видео из-за этого идиота";
                                    label_text.ForeColor = Color.Red;
                                    break;
                                }

                            case 111:
                                {
                                    text[111] = "Снимем с тобой рекламу, отправим придурышным";
                                    break;
                                }

                            case 112:
                                {
                                    text[112] = "А на следующей неделе, когда ему вернут комп снимем видео";
                                    break;
                                }

                            case 113:
                                {
                                    text[113] = "Так просто? И я не получу бан?";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 114:
                                {
                                    text[114] = "Получишь после съемок";
                                    label_text.ForeColor = Color.Red;
                                    break;
                                }

                            case 115:
                                {
                                    text[115] = "Извиняться на коленях будешь, чтоб не банили";
                                    break;
                                }

                            case 116:
                                {
                                    text[116] = "Понятно, а как вы меня найдете?";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 117:
                                {
                                    text[117] = "Мне ведь там дискорд скинуть нужно и т. д.?";
                                    break;
                                }

                            case 118:
                                {
                                    text[118] = "Скидывай, через неделю позвоним";
                                    label_text.ForeColor = Color.Red;
                                    break;
                                }

                            case 119:
                                {
                                    text[119] = "Ладно, нам надо снимать";
                                    break;
                                }

                            case 120:
                                {
                                    Background.Image = Properties.Resources.загруженное__3_;
                                    text[120] = "Поехали";
                                    break;
                                }

                            case 121:
                                {
                                    text[121] = "Раньше этот школьник был очень бедный";
                                    break;
                                }

                            case 122:
                                {
                                    text[122] = "Один раз он увидил рекламу казино 3 семерки";
                                    break;
                                }

                            case 123:
                                {
                                    text[123] = "И решил сыграть";
                                    break;
                                }

                            case 124:
                                {
                                    text[124] = "Он поставил всю пенсию своей бабки и поднял не хилое баблишко";
                                    break;
                                }

                            case 125:
                                {
                                    text[125] = "Не будьте жалкими нещукамий";
                                    break;
                                }

                            case 126:
                                {
                                    text[126] = "Играйте на 3 семерки и становитесь богатыми";
                                    break;
                                }

                            case 127:
                                {
                                    Background.Image = Properties.Resources.загруженное__1_;
                                    text[127] = "Стоп! В смылсе!?";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 128:
                                {
                                    text[128] = "Так я оставить это не могу!";
                                    break;
                                }

                            case 129:
                                {
                                    Background.Image = Properties.Resources.загруженное__1_;
                                    text[129] = "Это скам! Я не хочу быть частью этого!";
                                    label_text.ForeColor = Color.White;
                                    button5.Text = "Катичь к черту Андрюша!";
                                    button6.Text = "Через неделю посмотрим";
                                    button5.Visible = true;
                                    button6.Visible = true;
                                    break;
                                }







                        }


                    break;
                    }


                case 2:
                    {

                        switch (c)
                        {
                            case 200:
                                {
                                    text[200] = "Андрюша спокойно запускает съемку и начинает рекламировать";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 201:
                                {
                                    Background.Image = Properties.Resources.загруженное__2_;
                                    text[201] = "Раньше этот школьник был очень бедный";
                                    label_text.ForeColor = Color.Red;
                                    break;
                                }

                            case 202:
                                {
                                    text[202] = "Очень-очень бедный...";
                                    label_text.ForeColor = Color.GreenYellow;
                                    break;
                                }

                            case 203:
                                {
                                    text[203] = "Один раз он увидил рекламу казино 3 семерки";
                                    label_text.ForeColor = Color.Red;
                                    break;
                                }

                            case 204:
                                {
                                    text[204] = "И решил сыграть";
                                    break;
                                }

                            case 205:
                                {
                                    text[205] = "Он поставил всю пенсию своей бабки и поднял не хилое баблишко";
                                    break;
                                }

                            case 206:
                                {
                                    text[206] = "Не будьте жалкими нещукамий";
                                    break;
                                }

                            case 207:
                                {
                                    text[207] = "Играйте на 3 семерки и становитесь богатыми";
                                    break;
                                }

                            case 208:
                                {
                                    Background.Image = Properties.Resources.загруженное__1_;
                                    text[208] = "Что!?";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 209:
                                {
                                    text[209] = "Этот школьник только что снимал рекламу казино с моим участием";
                                    break;
                                }

                            case 210:
                                {
                                    text[210] = "А другой поддакивал ему?";
                                    break;
                                }

                            case 211:
                                {
                                    text[211] = "Как вообще ему дали подписать рекламный контракт";
                                    break;
                                }

                            case 212:
                                {
                                    text[212] = "Я нихочу в этом учавтсвовать";
                                    break;
                                }

                            case 213:
                                {
                                    Background.Image = Properties.Resources.загруженное__1_;
                                    text[213] = "Я не хочу быть скамером";
                                    label_text.ForeColor = Color.White;
                                    button5.Text = "Катичь к черту Андрюша!";
                                    button6.Text = "Ну ладно... Давай снимать";
                                    button5.Visible = true;
                                    button6.Visible = true;
                                    break;
                                }
                        }
                        break;
                    }

                case 3:
                    {
                        switch (c) 
                        {
                            case 300:
                                {
                                    Background.Image = Properties.Resources.загруженное__2_;
                                    text[300] =  "Иди ты к черту, Андрюша";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 301:
                                {
                                    text[301] = "Я пошел, без тебя обойдусь";
                                    break;
                                }

                            case 302:
                                {
                                    Background.Image = Properties.Resources.komp1;
                                    text[302] = "Ну зашибись мне Николаевич посоветовал!";
                                    break;
                                }

                            case 303:
                                {
                                    File.Delete("C:\\Users\\Public\\Documents\\firstLog.txt");
                                    tabPage2.Parent = null;
                                    tabPage8.Parent = tabControl1;
                                    break;
                                }
                        }
                        break;
                    }

                case 4:
                    {
                        switch (c) 
                        {
                            case 400:
                                {
                                    Background.Image = Properties.Resources.загруженное__2_;
                                    text[400] = "Меня совсем не мучает чувство совести";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 401:
                                {
                                    text[401] = "Мне абсолютно плевать на тупых школьников";
                                    break;
                                }

                            case 402:
                                {
                                    text[402] = "Пусть они проиграют зарплату родителей";
                                    break;
                                }


                            case 403:
                                {
                                    text[403] = "И что? ";
                                    break;
                                }


                            case 404:
                                {
                                    text[404] = "Андрюше ведь только лучше!";
                                    break;
                                }

                            case 405:
                                {
                                    text[405] = "Да и мне что?";
                                    break;
                                }

                            case 406:
                                {
                                    text[406] = "Пусть все знают, что я снимался в видео у Андрюши";
                                    break;
                                }

                            case 407:
                                {
                                    text[407] = "На заводе завидовать будут!";
                                    break;
                                }

                            case 408:
                                {
                                    text[408] = "Мы начали снимать видео";
                                    break;
                                }

                            case 409:
                                {
                                    text[409] = "Я с гордостью выполнял унизительные задания Андрюши";
                                    break;
                                }

                            case 410:
                                {
                                    text[410] = "И поддерживал его во всех рекламных вставках";
                                    break;
                                }

                            case 411:
                                {
                                    text[411] = "Я даже поставил свои деньги на 3 семерки";
                                    break;
                                }

                            case 412:
                                {
                                    text[412] = "Чтоб у Андрюши было прекрасное видео";
                                    break;
                                }

                            case 413:
                                {
                                    Background.Image = Properties.Resources._1_3_1;
                                    text[413] = "После съемок я лег спать";
                                    break;
                                }

                            case 414:
                                {
                                    text[414] = "Через неделю видео было на ютубе";
                                    break;
                                }

                            case 415:
                                {
                                    Background.Image = Properties.Resources.zavod;
                                    text[415] = "Прийдя на завод я не чувствовал той гордости...";
                                    break;
                                }

                            case 416:
                                {
                                    text[416] = "Все ржали с меня";
                                    break;
                                }

                            case 417:
                                {
                                    Background.Image = Properties.Resources.black;
                                    text[417] = "И только тогда я понял";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 418:
                                {
                                    text[418] = "Какой я был абузой...";
                                    break;
                                }

                            case 419:
                                {
                                    File.Delete("C:\\Users\\Public\\Documents\\firstLog.txt");
                                    tabPage2.Parent = null;
                                    tabPage8.Parent = tabControl1;
                                    break;
                                }


                        }

                        break;
                    }

                case 5:
                    {
                        switch (c)
                        {
                            case 500:
                                {
                                    Background.Image = Properties.Resources.komp1;
                                    text[500] = "Через неделю я как обычно сел за комп";
                                    label_text.ForeColor = Color.White;
                                    break;
                                }

                            case 501:
                                {
                                    text[501] = "Задумавшись о правильности своих действий";
                                    break;
                                }

                            case 502:
                                {
                                    text[502] = "Я не должен допустить. У Андрюши не выйдет!";
                                    break;
                                }

                            case 503:
                                {
                                    text[503] = "Казино плохо и я сорву ему видео";
                                    break;
                                }

                            case 504:
                                {
                                    text[504] = "Насколько я знаю";
                                    break;
                                }

                            case 505:
                                {
                                    text[505] = "У него горят сроки  и проблемы с рекламодателем";
                                    break;
                                }

                            case 506:
                                {
                                    text[506] = "Поэтому у меня всё выйдет";
                                    break;
                                }

                            case 507:
                                {
                                    text[507] = "Раздался звонок в дискорд";
                                    break;
                                }

                            case 508:
                                {
                                    text[508] = "НАКОНЕЦ, ТЫ ИМБИЦИЛ ПОЛУЧИЛ СВОЙ ДРЕВНЕГРЕЧЕСКИЙ КОМП!";
                                    label_text.ForeColor = Color.Red;
                                    break;
                                }

                            case 509:
                                {
                                    label_text.ForeColor = Color.GreenYellow;
                                    text[509] = "Давайте снимать, вы вроде рекламу сняли только?";
                                    break;
                                }

                            case 510:
                                {
                                    label_text.ForeColor = Color.White;
                                    text[510] = "Я захожу на сервер";
                                    break;
                                }

                            case 511:
                                {
                                    text[511] = "Мы начали съемку";
                                    break;
                                }

                            case 512:
                                {
                                    text[512] = "Я срывал ему рекламную вставку каждый удобный момент";
                                    break;
                                }

                            case 513:
                                {
                                    text[513] = "Не выполнял его унизительные задания";
                                    break;
                                }

                            case 514:
                                {
                                    text[514] = "И читал ему целые лекции о вреде казино";
                                    break;
                                }

                            case 515:
                                {
                                    label_text.ForeColor = Color.Red;
                                    text[515] = "КАКОГО ЧЕРТА ТЫ НЕ ДАЕШЬ НАМ СНЯТЬ НОРМАЛЬНО ВИДЕО";
                                    break;
                                }

                            case 516:
                                {
                                    text[516] = "РЕКЛАМОДАТЕЛЬ НЕ ХОЧЕТ ДЕНЬГИ ПЛАТИТЬ";
                                    break;
                                }

                            case 517:
                                {
                                    text[517] = "КОНЕЧНО, КАК ПЛАТИТЬ КОГДА ТУТ КРИВОЗУБЫХ ИДИОТОВ НАВАЛОМ";
                                    break;
                                }

                            case 518:
                                {
                                    text[518] = "ОДИН КОЛУ ПТЬ НЕ УМЕЕТ, ДРУГОЙ МНЕ О ВРЕДЕ КАЗИНО РАССКАЗЫВАЕТ";
                                    break;
                                }

                            case 519:
                                {
                                    text[519] = "СЕЙЧАС ЛИБО ТЫ ДОНАТИШЬ ПЕНСИЮ СВОЕЙ БАБКИ НА 3 СЕМЕРКИ";
                                    break;
                                }

                            case 520:
                                {
                                    text[520] = "ЛИБО ТЫ БУДЕШЬ ЗАБАНЕН НАВСЕГДА";
                                    break;
                                }

                            case 521:
                                {
                                    label_text.ForeColor = Color.White;
                                    text[521] = "Ладно, меня мама кушать зовет, пока!";
                                    break;
                                }

                            case 522:
                                {
                                    label_text.ForeColor = Color.Red;
                                    text[522] = "ТЫ ОФИГЕЛ ШКОЛЬНИК ТУПОРЫЛЫЙ!";
                                    break;
                                }

                            case 523:
                                {
                                    Background.Image = Properties.Resources.komp1;
                                    label_text.ForeColor = Color.White;
                                    text[523] = "Но я его уже не слышал";
                                    break;
                                }

                            case 524:
                                {
                                    text[524] = "Я с довольным лицом катался на своем проперженом стуле";
                                    break;
                                }

                            case 525:
                                {
                                    File.Delete("C:\\Users\\Public\\Documents\\firstLog.txt");
                                    tabPage2.Parent = null;
                                    tabPage8.Parent = tabControl1;
                                    break;
                                }
                        }
                        break;
                    }

            }


            label_timer.Interval = 10;
            label_timer.Enabled = true;

            return text[c];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c == 41)
            {
                tabPage3.Parent = tabControl1;
                tabControl1.SelectedIndex = 2;
                tabPage2.Parent = null;

            }

            if (c == 43)
            {
                tabPage5.Parent = tabControl1;
                tabControl1.SelectedIndex = 4;
                tabPage4.Parent = null;

            }

            else
            {
                Current_Text(c);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    {
                        if(c == 41)
                        {
                            tabPage3.Parent = tabControl1;
                            tabControl1.SelectedIndex = 2;
                            tabPage2.Parent = null;

                        }

                        if (c == 43)
                        {
                            tabPage5.Parent = tabControl1;
                            tabControl1.SelectedIndex = 4;
                            tabPage4.Parent = null;

                        }

                        else
                        {
                            Current_Text(c);
                        }

                        break;
                    }

                case Keys.LButton:
                    {
                        if (c == 41)
                        {
                            tabControl1.SelectedIndex = 2;
                        }

                        if (c == 43)
                        {
                            tabControl1.SelectedIndex = 4;
                        }

                        else
                        {
                            Current_Text(c);
                        }

                        break;
                    }

                case Keys.Enter:
                    {
                        if (c == 43)
                        {
                            tabPage5.Parent = tabControl1;
                            tabControl1.SelectedIndex = 4;
                            tabPage4.Parent = null;
                        }
                        break;
                    }

                case Keys.Escape:
                    {
                        if(tabPage8.Parent == tabControl1)
                        {
                            exit_menu1.Visible = true;
                        }

                        break;
                    }
            }
        }

        private void label_timer_Tick(object sender, EventArgs e)
        {

            try
            {

                if (i == 0)
                {
                    label_text.Text = "";
                    google_text.Text = "";
                }

                if (c == 42)
                {
                    
                    google_text.Text += Current_Text(c)[i]; 
                }



                else
                {
                    label_text.Text += Current_Text(c)[i];
                }

                i++;

                if (i == Current_Text(c).Length)
                {
                    i = 0;
                    c++;
                    label_timer.Enabled = false;
                }

            }

            catch
            {
                
            }
        }

        private void NewGame_button_Click(object sender, EventArgs e)
        {
            tabPage2.Parent = tabControl1;
            tabControl1.SelectedIndex = 1;
            tabPage1.Parent = null;

            label_timer.Interval = 10;
            label_timer.Enabled = true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button_zaglushka1_Click(object sender, EventArgs e)
        {
            if (rnd.Next(0, 4) == 0)
            {
                label_pc.Text = "Это мне сейчас не нужно";
            }

            else if (rnd.Next(0, 4) == 1)
            {
                label_pc.Text = "Давай потом";
            }

            else if (rnd.Next(0, 4) == 2)
            {
                label_pc.Text = "Где ярлык хрома?";
            }
            else
            {
                label_pc.Text = "Чертов хром! Где ты!?";
            }

            //звук
        }

        private void button_zaglushka2_Click(object sender, EventArgs e)
        {
            if (rnd.Next(0, 4) == 0)
            {
                label_pc.Text = "Это мне сейчас не нужно";
            }

            else if (rnd.Next(0, 4) == 1)
            {
                label_pc.Text = "Давай потом";
            }

            else if (rnd.Next(0, 4) == 2)
            {
                label_pc.Text = "Где ярлык хрома?";
            }
            else
            {
                label_pc.Text = "Чертов хром! Где ты!?";
            }
            //звук
        }

        private void chrome_button_Click(object sender, EventArgs e)
        {
            tabPage4.Parent = tabControl1;
            tabControl1.SelectedIndex = 3;
            tabPage3.Parent = null;

            c = 42;
            Current_Text(c);
        }

        private void write_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabPage5.Parent = tabControl1;
            tabControl1.SelectedIndex = 4;
            tabPage4.Parent = null;
  
        }

        private void download_button_Click(object sender, EventArgs e)
        {
            tabPage6.Parent = tabControl1;
            tabControl1.SelectedIndex = 5;
            tabPage5.Parent = null;

        }

        private void project_button_Click(object sender, EventArgs e)
        {
            tabPage7.Parent = tabControl1;
            tabControl1.SelectedIndex = 6;
            tabPage5.Parent = null;

        }

        private void singup_button_Click_1(object sender, EventArgs e)
        {
            tabPage6.Parent = tabControl1;
            tabControl1.SelectedIndex = 5;
            tabPage5.Parent = null;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(ending == 0)
            {
                ending = 1;
                c = 100;
                Current_Text(c);
                
                
            }

            else if(ending == 1) //послал нафиг и ливнул
            {

                ending = 3;
                c = 300;
                Current_Text(c);
            }

            else if(ending == 2)//послал нафиг и ливнул
            {
                button5.Text = "Катичь к черту Андрюша!";
                button6.Text = "Ну ладно, давай снимать";
                ending = 3;
                c = 300;
                Current_Text(c);
            }

            button5.Visible = false;
            button6.Visible = false;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if(ending == 0)
            {
                ending = 2;
                c = 200;
                Current_Text(c);
            }

            else if (ending == 2)
            {
                ending = 4;
                c = 400;
                Current_Text(c);
            }

            else if(ending == 1)
            {
                ending = 5;
                c = 500;
                Current_Text(c);
            }

            button5.Visible = false;
            button6.Visible = false;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            exit_box.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            exit_box.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\Users\\Public\\Documents\\firstLog.txt");
            Application.Exit();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string FilePath = "C:\\Users\\Public\\Documents\\SaveAndrushaRP0.txt";
            if (!File.Exists(FilePath))
            {
                FileStream fs = File.Create(FilePath);
                fs.Close();
            }

            else
            {
                FileStream file = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine(ending);
                writer.Close();
            }

            FilePath = "C:\\Users\\Public\\Documents\\SaveAndrushaRP1.txt";
            
            if (!File.Exists(FilePath))
            {
                FileStream fs1 = File.Create(FilePath);
                fs1.Close();
            }
            
            else
            {
                FileStream file1 = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
                StreamWriter writer1 = new StreamWriter(file1);
                writer1.WriteLine(c);
                writer1.Close();
            }

            Save_label.Text = "Успешно!";
            label53.ForeColor = Color.GreenYellow;
            label53.Text = "Успешно";
            save.Enabled = true;
            
        }

        private void exit1_button_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\Users\\Public\\Documents\\firstLog.txt");
            Application.Exit();
        }

        private void LoadSave_Button_Click(object sender, EventArgs e)
        {
            string FilePath = "C:\\Users\\Public\\Documents\\SaveAndrushaRP0.txt";

            if (!File.Exists(FilePath))
            {
                FileStream fs = File.Create(FilePath);
                fs.Close();
            }
            else
            {
                FileStream file = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(file);

                while (!reader.EndOfStream)
                {
                    ending = int.Parse(reader.ReadLine());
                }

                reader.Close();
                file.Close();
            }

            FilePath = "C:\\Users\\Public\\Documents\\SaveAndrushaRP1.txt";

            if (!File.Exists(FilePath))
            {
                FileStream fs1 = File.Create(FilePath);
                fs1.Close();
            }
            else
            {
                FileStream file1 = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
                StreamReader reader1 = new StreamReader(file1);

                while (!reader1.EndOfStream)
                {
                    c = int.Parse(reader1.ReadLine())  - 1;
                }

                reader1.Close();
                file1.Close();
            }

            if(c == 41)
            {
                tabPage3.Parent = tabControl1;
                tabControl1.SelectedIndex = 2;
                tabPage2.Parent = null;

            }

            else if(c == 42)
            {
                tabPage4.Parent = tabControl1;
                tabControl1.SelectedIndex = 3;
                tabPage3.Parent = null;

            }

            else
            {
                tabPage2.Parent = tabControl1;
                tabControl1.SelectedIndex = 1;
                tabPage1.Parent = null;

            }

            Current_Text(c);
            tabPage1.Parent = null;
            
        }

        private void download_button1_Click_1(object sender, EventArgs e)
        {
            tabPage6.Parent = tabControl1;
            tabControl1.SelectedIndex = 5;
            tabPage7.Parent = null;

        }

        private void download_button1_Click(object sender, EventArgs e)
        {
           if(login_textbox.Text == "" || login_textbox.Text == " " && password_textbox.Text == "" || password_textbox.Text == " ")
            {
                nick_label.Text = "Введите логин и пароль";
            }
            else
            {
                c = 44;

                tabPage2.Parent = tabControl1;
                tabControl1.SelectedIndex = 1;
                tabPage6.Parent = null;


                pictureBox2.Visible = false;
                Current_Text(c);
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            
        }

        private void save_Tick(object sender, EventArgs e)
        {
            Save_label.Text = "";
            label53.Text = "";
            Save_label.ForeColor = Color.YellowGreen;
            save.Enabled = false;
        }

        private void skip_button_Click(object sender, EventArgs e)
        {
            if(c == 40)
            {
                Save_label.ForeColor = Color.Red;
                Save_label.Text = "Отказано";
                save.Enabled = true;
            }   

            else if (c == 83)
            {
                Save_label.ForeColor = Color.Red;
                Save_label.Text = "Отказано";
                save.Enabled = true;
            }

            else if (c == 129)
            {
                Save_label.ForeColor = Color.Red;
                Save_label.Text = "Отказано";
                save.Enabled = true;
            }

            else if (c == 213)
            {
                Save_label.ForeColor = Color.Red;
                Save_label.Text = "Отказано";
                save.Enabled = true;
            }
            else if (c == 417)
            {
                Save_label.ForeColor = Color.Red;
                Save_label.Text = "Отказано";
                save.Enabled = true;
            }

            else if (c == 523)
            {
                Save_label.ForeColor = Color.Red;
                Save_label.Text = "Отказано";
                save.Enabled = true;
            }

            else
            {
                if (c < 40)
                {
                    write_name.Visible = false;
                    c = 40;
                    Current_Text(c);
                }

                else if (c < 83)
                {
                    c = 83;
                    Current_Text(c);
                }

                else if (ending == 1)
                {
                    c = 129;
                    Current_Text(c);
                }

                else if (ending == 2)
                {
                    c = 213;
                    Current_Text(c);
                }

                else if (ending == 3)
                {
                    Save_label.ForeColor = Color.Red;
                    Save_label.Text = "Отказано";
                    save.Enabled = true;
                }

                else if (ending == 4)
                {
                    c = 417;
                    Current_Text(c);
                }

                else if (ending == 5)
                {
                    c = 523;
                    Current_Text(c);
                }
            }
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            label53.ForeColor = Color.Red;
            label53.Text = "Отказано";
            save.Enabled = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exit_box_Enter(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            exit_menu1.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\Users\\Public\\Documents\\firstLog.txt");
            Application.Exit();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            if(!File.Exists("C:\\Users\\Public\\Documents\\firstLog.txt"))
            {
                FileStream fs1 = File.Create("C:\\Users\\Public\\Documents\\firstLog.txt");
                fs1.Close();
                Form2 magaz = new Form2();
                Hide();
                magaz.ShowDialog();
                this.Close();

            }
                
        }
    }
}
