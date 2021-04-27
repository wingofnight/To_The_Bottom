using System;
using System.Collections.Generic;
using System.Text;

namespace Drop_Life_test1
{
   
       public class Objects
    {
        public int MAX_RAITING = 200000;
        public string image_puth { get; set; }
        public string name;
        public string description;
        public int expenses_Amod;//модификатор уменьшающий расходы за счет ачивок
        public int rating_Amod; //сколько в день будет утикать рейтинга благодаря ачивкам
    }
    public class Characters:Objects
    {
        public short day_counter;
        public int rating;
        public List<Statuses> status;
        public List<Achivments> achivments;       
        
        public Characters()
        { 
            Statuses boss = new Statuses("Бос", "Это вершина пищевой цепи. Приносит вам в день доход в 20000 Денях и дает 2000 Возвышения! Самое время начать скатываться", 20000, 2000,200000);
            Statuses doNopeMan = new Statuses("Ничего не делатель", "Заместитель. Он и сам не понимает за что ему платят деньги, но это приносит вам 15000 Денях и 1000 Возвышения.", 15000, 1000, 190000);
            Statuses yellMan = new Statuses("Орун", "Менеджер, работа которого заключается в том, что бы кричать на рядовых и мешать им. Выпивая вашу кровь они получают 10000 Денях и 500 Возвышения!", 10000, 500, 150000 );
            Statuses soldier = new Statuses("Рядовой", "Рядовой сотрудник, обычный работяга на передовой. 100 Возвышения за работу в престижном месте и всего 7000 Денях на корман", 7000, 100, 100000);
            Statuses cashier = new Statuses("Кассир в Пятёре", "Обычный кассир в супермаркете. Можете вечно звать Гааалю, но вы уже падаете на дно. 100 очков Падения. Вы начинаете выживать всего на 3000 Денях в день", 3000, -100, 50000);
            Statuses cleaning = new Statuses("Клиннинг Менеджер", "Работа уборщицей уже далеко не престижна. 2000 Денях и столько же очков Падения...  ", 2000, -500, 15000);
            Statuses sweeper = new Statuses("Чичтильщик дворовой", "Вы надрываете хребтину за каких то 1000 Денях и при этом ощущаете 1000 Падения. Вы в крутом пике по достижению дня!", 1000, -1000, 5000);
            Statuses trasher = new Statuses("Помойщик", "Вы шаритесь по помойкам в надежде найти хоть что-то. Сдавая банки и бутылки вы наковыриваете 500 Денях в день. 2000 Падения ", 500, -2000, 0);
            Statuses bum = new Statuses("Бомжарный", "Вы доказываете миру, что есть куда еще падать. Все глубже и глубже. 4000 Падения вы себе обеспечили", 0, -4000, -1000);
            Statuses nobody = new Statuses("Никто", "Вы никто и ничто. Вы опустились ниже бомжа, вы готовы жрать крысс и пить из лужи. Из вас постоянно выбивают деньги и вам приходится отдавать по 500 Денях в день. 6000 Падения. ",-500, -6000, -10000);
            Statuses thief = new Statuses("Домушник", "Вы достигли дна. Вам приходиться воровать и шариться по домам. Из за проблем с законом вам приходиться тратить больше,чем вы наворовываете. Минус 2 000 Денях в день и 10000 Падения", -2000, -10000, - 25000);
            Statuses kurtz = new Statuses("Самоторговец", "Дно давно пробито, вы стремительно пробиваетесь в никуда все глубже и глубже. Вы готовые на все за деньги. Отдавайте по 500 Денях на взятки в день. 15000 Падения. Это конец. ", -500, -15000, -50000);
            Statuses transgress = new Statuses("Преступивший черту", "Жизнь Человека для вас ни что. Все что вас волнует, это как можно скорее раздобыть денег и обЗОЖится. Доход и Падения вам больше не интересны.", +10000, -30000,-100000);
            Statuses bottom = new Statuses("Дно пробито", "Это последний день вашей жизни, но вы уже это не осознаете. Ваш ЗОЖ довел вас до состояния овоща.", 0, -100000,-200000);
            day_counter = 0;
            rating = MAX_RAITING;
            status = new List<Statuses>
            {
                boss,doNopeMan,yellMan,soldier,cashier,cleaning,sweeper,trasher,bum,nobody,thief,kurtz,transgress,bottom
            };

            Achivments smoke = new Achivments("Дышание дымом", "Злоупотребление тобачным", -200, -200, 20);
            Achivments lightDrugs = new Achivments("Легкое ЗОЖничество", "Приводит к тяжелому ЗОЖ, и к тяжелым последствиям", -500, -500, 20);
            Achivments hardDrugs = new Achivments("Тяжелое ЗОЖ", "Шаткая дорожка. Обычно этот путь приводит на дно", -1000, -1000, 20);
            Achivments alcoholik = new Achivments("Жажда Огеной жижи", "Неутолимая жажда приводит к последствиям не лечше чем ЗОЖ", -300, -500, 20);
            Achivments gamer = new Achivments("Игромания", "Вред компьютерных игр доказан давным давно", 500, 500, 10);
            Achivments internetMan = new Achivments("Интернет Зависимость", "Ни дня без соцсетей", 1000, 1500, 10);
            Achivments gambling = new Achivments("Азартные Азарты", "Почти всегда приводит к нищите", -300, 300, 10);
            Achivments thiefMan = new Achivments("Клиптомания", "Прибыльная зависимость", 1000, -500, 10);
            Achivments antiSocial = new Achivments("Социопатия", "Вы ничего не чувствуете к другим людям", 100, -300, 10);
            Achivments depress = new Achivments("Депрессия", "Вам ни чего не хочется", -300, -300, 10);
            Achivments impulseDepress = new Achivments("Ипульсивно-компльсивное что-то там", "Вы уверены, что закрыли дверь?", 500, -300, 10);
            Achivments religion = new Achivments("Религиозность", "Не желаете впустить Ктулху в свое сердце?", -300, -300, 10);
            Achivments hardspeeker = new Achivments("Грубиян", "За словом в корман вы не лезите", 100, -300, 10);
            Achivments obscene = new Achivments("Материльщик", "Люди закрывают уши при виде вас", 0, -300, 10);
            Achivments agressive = new Achivments("Агрессивность", "Вы не можете сдежрживать себя в руках", 200, -300, 10);
            Achivments dirty = new Achivments("Грязность", "Кого волнует эта чистота?", 100, -300, 10);
            Achivments stinky = new Achivments("Вонючность", "Легкое арме всегда с вами.", 100, -300, 10);
            Achivments badWord = new Achivments("Неграмотность", "Балезнь двацать перваго века", 0, -300, 10);

            achivments = new List<Achivments>
            {
                 smoke,lightDrugs,hardDrugs,alcoholik,gamer,internetMan,gambling,thiefMan,antiSocial,depress,impulseDepress,religion,hardspeeker,obscene,agressive,dirty,stinky,badWord
            };

        }

    }

    public class Character : Characters
    {
        public List<Achivments> current_achivments;
        public byte current_status;
        public int cash;        
        public int day_expenses;//затраты на день высчитываются изходя из роскоши и зависимостей и тд.

     public   Character()
        {
            cash = 100000;
            current_status = 0;
        }
    }

  public class Statuses:Objects
    {
        public int raiting_info; //сколько нужно до следующего уровня
        public int day_profit;
      
        public Statuses(string name, string description, int day_profit, int rating_Amod, int raiting_info )
        {
            this.name = name; this.description = description; this.day_profit = day_profit; this.rating_Amod = rating_Amod; this.raiting_info = raiting_info;
        }
    }

    public class Achivments:Objects
    {
        public int expirience;//прогресс до получения ачивки
        public Achivments(string name, string description, int expenses_Amod, int rating_Amod, int expirience)
        {
            this.name = name; this.description = description; this.expenses_Amod = expenses_Amod; this.rating_Amod = rating_Amod; this.expirience = expirience;
        }        
    }

    public class Property:Objects
    {
        
        public int coast_buy;
        public int coast_sell; 
        public Property(string name, string description, int expenses_Amod, int rating_Amod, int coast_buy, int coast_sell )
        {
            this.name = name; this.description = description; this.expenses_Amod = expenses_Amod; this.rating_Amod = rating_Amod; this.coast_buy = coast_buy; this.coast_sell = coast_sell;
        }
    }

    public class Communic_Property
    {
        public string description;
        public List<Property> properties;
        public byte curren_property;
        public string image_puth { get; set; }
    }

    public class Garage:Communic_Property
    {
        public Garage()
        {
            curren_property = 0;
            description = "Это ваш гараш. Престижность вашего авто апределяет и вашу престижность, но это несет Определенные расходы.";
            Property Luxury = new Property("Коенжи","Роскошный гиперкар с которым вас пропустят даже закулисы в дубаи.", -3000, 5000, 35000, 25000);
            Property Sports = new Property("Дева", "Модный спорткар. Задвинит любую жигу за пояс", -2000, 3000, 25000, 15000);
            Property Foreign = new Property("Аполо", "Современная иномарка, вполне представительно.", -1500, 2000, 15000, 10000);
            Property Russia = new Property("Невеста", "Вполне приятная машины, но вечно что то ломается", -2000, 1500, 10000, 7000);
            Property Old_Foreight = new Property("ВолкВагон", "Старенькая но хорошая иномарка. Пока еще прилично выглядит.", -1000, 1500, 7000, 5000);
            Property Old_Russian = new Property("Двин", "Когда то считалась люксой в советкое время. Сейчас конечно яркий представитель Таза.", -1000, 1000, 5000, 2500);
            Property Wreck = new Property("Капидосина", "Что ты такое? Благодаря мистическим силам, все еще на ходу.", -500, 500, 2500, 1500);
            Property Moped = new Property("Тырка", "Вроде бы велосипед с педальками. Все еще может доставить вашу тушку в пункт назначения", -100, 100, 1500, 1000);
            Property Bicycle = new Property("Меридиан", "Лясопед, поддержите себя в тонусе", 0, 500, 1000, 500);
            Property Boots = new Property("Абики", "Спортивные кросовки, позволяют бегать и держать себя в форме", 0, 500, 500, 100);
            Property BareFeet = new Property("Босяк", "Остался босиком? Не беда, скоро ноги привыкнут.", 0, -500, 100, 0);
            properties = new List<Property> {Luxury,Sports,Foreign,Russia,Old_Foreight,Old_Russian,Wreck,Moped,Bicycle,Boots,BareFeet};
        }
    }
    public class Hair : Communic_Property
    {
        public Hair()
        { 
            description = "От вашей прически, да и головы в целом зависит многое. Как гворится - встречай книжку по лицу.";
            curren_property = 0;
            Property Stylist = new Property("Шевелюра", "Ваш личный стилист делает ваше лицо подобно Ангелу", -2000, 1000, 25000, 20000);
            Property Barber = new Property("Площадка", "Барбер отлично знает как стрич мужиков, чик чик.", -1500, 1000, 20000, 15000);
            Property HedMaker = new Property("Конадка", "Обычный парикмахер не так хорош, но все еще держит ваши волосы в порядке.", -1000, 700, 15000, 10000);
            Property Express = new Property("Подмышонку", "Дешего и сердито. Насадка №3", -500, 500, 10000, 5000);
            Property Uncle = new Property("Челка", "Тётя люба, мамина подруга мастер своего дела.", -200, 300, 5000, 2500);
            Property Mather = new Property("Лучший", "Вы для Мамы всегда будете самым лучшим.", 100, 500, 2500, 2000);
            Property SelfMachine = new Property("Йожик", "Себя подстрич - нужна сноровка, но под ноль не промахнешся", 0, 100, 2000, 1000);
            Property SelfSnip = new Property("ВАТАФУКЕР", "Подстричь себя ножницами может только акробат.", 0, -100, 1000, 500);
            Property Nothin = new Property("ЯЖАТРАЩИВАЮ", "Можно не стричься вовсе и иметь отличную длинную шевелюру.", 0, -500, 500, 0);

            properties = new List<Property> { Stylist, Barber, HedMaker, Express, Uncle, Mather, SelfMachine, SelfSnip, Nothin };

        }
    }

    public class Clothes : Communic_Property
    {
        public Clothes()
        {
            description = "Встречают по одежке, а проважают на такси";
            curren_property = 0;
            Property Tailor = new Property("Портной", "Ваш личный портной наряжает вас как божество", -2000, 1000, 25000, 20000);
            Property Boutique = new Property("Бутик", "Мировые бренды, такие как - Дольки Кабана.", -1500, 1000, 20000, 15000);
            Property Abidas = new Property("Абидас", "Фирмовый магазин - стильно, модно, молодежно.", -1000, 700, 15000, 10000);
            Property Family = new Property("Семейный", "Дешего и со вкусом. Может быть даже в размер.", -500, 500, 10000, 5000);
            Property SecondHand = new Property("Немного Поношенный", "Вещи из европы высшего качества.", -200, 300, 5000, 2500);
            Property Free = new Property("Дары", "Если попросить, вас и так хорошо оденут, еще и бессплатно!", 0, 100, 2000, 1000);
            Property Brother = new Property("Братшоп", "Доношу за братом. Пускай он и младший", 0, -100, 1000, 500);
            Property Trash = new Property("Помойкайк", "Люди часто оставляют почти хорошие вещи на помойке.", 0, -100, 500, 250);
            Property Nothin = new Property("ЯЖДАНАШИВАЮ", "Грязь сама отвалится. Зачем раздеваться, если потом опять одеваться.", 0, -500, 250, 0);

            properties = new List<Property> { Tailor,Boutique,Abidas,Family,SecondHand,Free,Brother,Trash,Nothin};
        }
    }

    public class Boots : Communic_Property
    {
        public Boots()
        {
            description = "Как говорится, обувь - лицо мужчины";
            curren_property = 0;
            Property Shoemakerr = new Property("Шумейкер", "Ваш личный сапожник, сделает ваши ноги - неотразимыми!", -2000, 1000, 25000, 20000);
            Property Elitas = new Property("Элитас", "Мировые бренды, отличные туфли. Ботинок по цене машины.", -1500, 1000, 20000, 15000);
            Property Abidas = new Property("Абидас", "Фирмовый магазин - стильно, модно, молодежно.", -1000, 700, 15000, 10000);
            Property Asino = new Property("Азинос", "Неплохая обувь и дешевле бренда", -500, 500, 10000, 5000);
            Property Chinas = new Property("Китай", "Вещи из европы высшего качества.", -200, 300, 5000, 2500);
            Property Sneakers = new Property("Сникерсы", "Кеды всегда были в моде!", -100, 100, 2000, 1000);
            Property FlipFlops = new Property("ФлипФлопы", "Шлепки, отлично подойдут летом", -50, -100, 1000, 500);
            Property Suks = new Property("Соксы", "Можно просто ходить босиком.", 0, -100, 500, 250);
            Property Nothin = new Property("ТАКЖИПАЛЕЗНО", "Грязь сама отвалится. Подошва ног не хуже покрышки.", 0, -500, 250, 0);

            properties = new List<Property> { Shoemakerr,Elitas,Abidas,Asino,Chinas,Sneakers,FlipFlops,Suks,Nothin};
        }
    }

    public class Phone:Communic_Property
    {
        public Phone()
        {
            description = "Как говорится, телефон - отражение твоей души. Ну или кошелька.";
            curren_property = 0;
            Property Iphone = new Property("Ябокфон", "Крутой и стильный телефон. Самый дорогой на планете.", -2000, 1000, 25000, 20000);
            Property Sumsung = new Property("Самвсун", "Навороченный донельзя, но не яблоко.", -1500, 1000, 20000, 15000);
            Property Honor = new Property("Хунар", "За честь и отвагу!", -1000, 700, 15000, 10000);
            Property Xiaomy = new Property("Хуоми", "Отличный трешафон, звонит, лагает, все как надо.", -500, 500, 10000, 5000);
            Property Chinas = new Property("КитайФун", "Кто сказал, что хороший телефон должен быть брендевым?", -200, 300, 5000, 2500);
            Property HomePhone = new Property("Домашний", "Всегда можно и из дома позвонить!", -100, 100, 2000, 1000);
            Property Taxophone = new Property("Таксофон", "Просто позвоню с улицы и все.", -50, -100, 1000, 500);
            Property Pigeon = new Property("Голубь", "Голубиная почта. Просто и эффективно, жаль в 2056 не поиграешь.", 0, -100, 500, 250);
            Property Nothin = new Property("НАФИГВАШИТИЛИФОНЫ", "Кому нада, сам придет и пообщаица.", 0, -500, 250, 0);

            properties = new List<Property> { Iphone,Sumsung,Honor,Xiaomy,Chinas,HomePhone,Taxophone,Pigeon,Nothin};

        }
    }

    public class Computer : Communic_Property
    {
        public Computer()
        {
            description = "Это все для учебы, чеснслова";
            curren_property = 0;
            Property Super3090 = new Property("Супе3090ГТХ", "Самый мощный на сегодняшний день пк.", -2000, 1000, 25000, 20000);
            Property Normal2060 = new Property("Нордман2060Педро", "Мощный, навороченый, все потянет.", -1500, 1000, 20000, 15000);
            Property Easy1080 = new Property("Изи1080Гусь", "Бюджетно, но все еще вам доступны все программы и игры.", -1000, 700, 15000, 10000);
            Property MacBook = new Property("Яблобук", "Пристижно, но пойдет только для работы и интернета.", -500, 500, 10000, 5000);
            Property AsusGamer = new Property("АгусГамус", "Игровые ноутбуки существуют? Этот докажет вам, что - нет!", -200, 300, 5000, 2500);
            Property Lenovo = new Property("Ленива", "Посидеть в соцсетях, позалипать, самое то.", -100, 100, 2000, 1000);
            Property Irbis = new Property("Ирис", "Нетбук. Не поддерживает вторую вкладку браузера.", -50, -100, 1000, 500);
            Property Tablet = new Property("Таблет", "Планшет на андрюхе. Худо бедно даст вам доступ в интернет.", 0, -100, 500, 250);
            Property Nothin = new Property("ЯНИЗАВИСИМЫЙ", "Нет зависимости от Ай Ты!", 0, -500, 250, 0);

            properties = new List<Property> { Super3090,Normal2060,Easy1080,MacBook,AsusGamer,Lenovo,Irbis,Tablet,Nothin };
        }
    }

    public class Home : Communic_Property
    {
        public Home()
        {
            description = "Ваш дом - ваша крепость. Место уединения.";
            curren_property = 0;
            Property Villa = new Property("Вилла", "Расскошна вилла на берегу моря. Личные виноградники.", -3000, 5000, 35000, 25000);
            Property Manshion = new Property("Особняк", "Большой красивый дом, в лесном массиве.", -2000, 3000, 25000, 20000);
            Property PrivateHouse = new Property("Частный дом", "Частный дом в городской черте. Все еще очень престижно!", -1500, 1000, 20000, 15000);
            Property Loft = new Property("Лофт", "Расскошное жилье на верхнем этаже. Просто огромная квартира.", -1000, 700, 15000, 10000);
            Property ThreeRooms = new Property("Трешка", "Обычная, но большая квартира.", -500, 500, 10000, 5000);
            Property Single = new Property("Хрущевка", "Одна комната, но все еще своё жилье.", -200, 300, 5000, 2500);
            Property Public = new Property("Общага", "Дешего, зато не на улице.", -100, 100, 2000, 1000);
            Property Hut = new Property("СвойДом", "Зачем кому то платить, если можно просто построить свое жилье. Из картона и веток.", 0, -100, 250, 100);
            Property Trush = new Property("Мусорный бак", "Доставка еды на дом.", 0, -500, 150, 100);
            Property Cannals = new Property("Каналья", "Огромный дворец, сотник комнат и длинных коридоров. Еда бегает прямо под ногами!", 0, -1000, 100, 0);

            properties = new List<Property> { Villa,Manshion,PrivateHouse,Loft,ThreeRooms,Single,Public,Hut,Trush,Cannals };

        }
    }
    
}
