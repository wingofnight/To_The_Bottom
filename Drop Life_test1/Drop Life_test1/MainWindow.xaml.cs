using System.Windows;

namespace Drop_Life_test1
{
   public static class Tranzistor
    {
      
    }

    public partial class MainWindow : Window
    {
        public  Character Player = new Character();
        public  Home home = new Home();
        public  Garage car = new Garage();
        public  Computer computer = new Computer();
        public  Phone phone = new Phone();
        public  Boots boots = new Boots();
        public  Clothes clothes = new Clothes();
        public  Hair hair = new Hair();
        public  Current_date date = new Current_date();

        private int Expenses()//считает общие расходы
        {
            int result = 0;
            result += home.properties[home.curren_property].expenses_Amod + car.properties[car.curren_property].expenses_Amod + computer.properties[computer.curren_property].expenses_Amod;
            result += phone.properties[phone.curren_property].expenses_Amod + boots.properties[boots.curren_property].expenses_Amod + clothes.properties[clothes.curren_property].expenses_Amod;
            result += hair.properties[hair.curren_property].expenses_Amod;
            return result;
        }

        private int Raiting_Amod()// высчитывает изменение в рейтинге
        {
            int result = 0;
            result += home.properties[home.curren_property].rating_Amod + car.properties[car.curren_property].rating_Amod + computer.properties[computer.curren_property].rating_Amod;
            result += phone.properties[phone.curren_property].rating_Amod + boots.properties[boots.curren_property].rating_Amod + clothes.properties[clothes.curren_property].rating_Amod;
            result += hair.properties[hair.curren_property].rating_Amod;
            return result;
        }
        public MainWindow()
        {
            InitializeComponent();
            Update_day();
            ResizeMode = 0;
            progressBar.Maximum = Player.MAX_RAITING;
            progressBar.Value = Player.rating;
            progressBar.Minimum = 0;
            lb_raiting.Content = Player.rating;
            lb_money.Content = Player.cash;
        }
       
        private void Update_day()
        {
            lb_day_nomber.Content = $"{date.current_day} {date.month[date.current_month]} {date.current_year}";
            lb_day_name.Content = date.dayOfWeek[date.current_dayOfWeek];
            lb_clock.Text = date.time[date.current_time];
            lb_day_fall.Content = Player.day_counter;
        }
        private void Update_time()
        {
            if (date.current_time != 3)
            {
                date.current_time++;
                if (date.current_time == 3)
                {
                    btn_action.IsEnabled = false;
                    btn_skip.IsEnabled = true;
                }
            }

            Update_day();
        }

        private void Progress_Fall(int x)
        {
            Player.rating += x;
            progressBar.Value = Player.rating;
            lb_raiting.Content = Player.rating;
            Player_status();
        }

        private void Player_status()
        {
            int[] chekRaiting = new int[14] {
                Player.status[0].raiting_info, Player.status[1].raiting_info, Player.status[2].raiting_info, 
                Player.status[3].raiting_info, Player.status[4].raiting_info, Player.status[5].raiting_info, 
                Player.status[6].raiting_info, Player.status[7].raiting_info, Player.status[8].raiting_info, 
                Player.status[9].raiting_info, Player.status[10].raiting_info,Player.status[11].raiting_info,
                Player.status[12].raiting_info,Player.status[13].raiting_info
            };

            
                if (Player.current_status > 0 && Player.rating > chekRaiting[Player.current_status-1]   )
                {
                    Player.current_status--;
                }
                else if ( Player.current_status < 13 && Player.rating < chekRaiting[Player.current_status+1] )
                {
                    Player.current_status++;
                }            

            lb_status.Content = Player.status[Player.current_status].name;

        }

        private void Button_Action(object sender, RoutedEventArgs e)
        {           
            Update_time();
            Progress_Fall(-100);
        }

        private void Button_Skip(object sender, RoutedEventArgs e)
        {           
            Player.day_counter++;
            date.Next_step();
            Update_day();
            btn_skip.IsEnabled = false;
            btn_action.IsEnabled = true;
            Progress_Fall(Player.status[Player.current_status].rating_Amod+ Raiting_Amod());
            Player.cash += Player.status[Player.current_status].day_profit+ Expenses();

            lb_money.Content = Player.cash;
        }

        private void btn_Status_Click(object sender, RoutedEventArgs e)
        {
            var status = new WinStatus();
            status.lb_car.Content = car.properties[car.curren_property].name;
            status.lb_clothes.Content = clothes.properties[clothes.curren_property].name;
            status.lb_home.Content = home.properties[home.curren_property].name;
            status.lb_pc.Content = computer.properties[computer.curren_property].name;
            status.lb_clothes.Content = clothes.properties[clothes.curren_property].name;
            status.lb_phone.Content = phone.properties[phone.curren_property].name;
            status.lb_shoes.Content = boots.properties[boots.curren_property].name;
            status.lb_hair.Content = hair.properties[hair.curren_property].name;
            status.lb_work.Content = Player.status[Player.current_status].name;//Сделать еще описание работы и всей мишуры

            status.Show();           
        }
    }


    public class Calendar
    {
        public byte day;
        public string[] month;
        public short year;
        public string[] dayOfWeek;
        public string[] time;

        public Calendar()
        {
            day = 12;
            month = new string[12] { "Junuary", "Febriary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            year = 2021;
            dayOfWeek = new string[7] { "Mondey", "Twosday", "Wensday", "Thurday", "Friday", "Suterday", "Sunday" };
            time = new string[4] { "10:00", "14:00", "19:00", "21:00" };

        }
    }
    public class Current_date : Calendar
    {
        public byte current_day;
        public byte current_month;
        public short current_year;
        public byte current_dayOfWeek;
        public byte current_time;
        public Current_date()
        {
            current_day = day;
            current_year = year;
            current_month = 4;
        }
        public void Next_step()
        {
            current_time = 0;
            if (current_day != 30)
            {
                current_day++;
            }
            else
            {
                current_day = 0;
                if (current_month != 11)
                {
                    current_month++;
                }
                else
                {
                    current_month = 0;
                    year++;
                }
            }

        }                 

        }
    }

