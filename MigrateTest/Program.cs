using Excel;

ApplicationContext db = new ApplicationContext();


/*List<Gosts> listGosts = new List<Gosts>();

listGosts.Add(new Gosts() { Gost = "ГОСТ 1497-84", TypeOfTestsId = 17 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 1497-84", TypeOfTestsId = 19 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 1497-84", TypeOfTestsId = 37 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 2999-75", TypeOfTestsId = 23 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 3728-78", TypeOfTestsId = 5 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 8693-2022", TypeOfTestsId = 1 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 8694-2022", TypeOfTestsId = 18 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 8694-2022", TypeOfTestsId = 38 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 8695-2022", TypeOfTestsId = 20 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 9012-59", TypeOfTestsId = 22 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 9013-59", TypeOfTestsId = 24 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 9651-84", TypeOfTestsId = 17 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 9651-84", TypeOfTestsId = 19 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 9651-84", TypeOfTestsId = 37 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 10006-80", TypeOfTestsId = 17 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 10006-80", TypeOfTestsId = 19 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 10006-80", TypeOfTestsId = 37 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 10446-80", TypeOfTestsId = 17 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 10446-80", TypeOfTestsId = 19 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 10446-80", TypeOfTestsId = 37 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 14019-2003", TypeOfTestsId = 5 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 19040-81", TypeOfTestsId = 17 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 19040-81", TypeOfTestsId = 19 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 19040-81", TypeOfTestsId = 37 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 1778-2022", TypeOfTestsId = 15 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 5639-82", TypeOfTestsId = 2 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 5639-82", TypeOfTestsId = 3 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 6032-2017", TypeOfTestsId = 9 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 6032-2017", TypeOfTestsId = 10 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 6032-2017", TypeOfTestsId = 11 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 6032-2017", TypeOfTestsId = 12 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 6032-2017", TypeOfTestsId = 35 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 6032-2017", TypeOfTestsId = 36 });
listGosts.Add(new Gosts() { Gost = "РД 24.200.15-90", TypeOfTestsId = 9 });
listGosts.Add(new Gosts() { Gost = "РД 24.200.15-90", TypeOfTestsId = 10 });
listGosts.Add(new Gosts() { Gost = "РД 24.200.15-90", TypeOfTestsId = 11 });
listGosts.Add(new Gosts() { Gost = "РД 24.200.15-90", TypeOfTestsId = 12 });
listGosts.Add(new Gosts() { Gost = "РД 24.200.15-90", TypeOfTestsId = 35 });
listGosts.Add(new Gosts() { Gost = "РД 24.200.15-90", TypeOfTestsId = 36 });
listGosts.Add(new Gosts() { Gost = "Методика ВНИТИ №7-95-87", TypeOfTestsId = 2 });
listGosts.Add(new Gosts() { Gost = "Методика ВНИТИ №7-95-87", TypeOfTestsId = 3 });
listGosts.Add(new Gosts() { Gost = "Методика ВНИТИ №7-96-87", TypeOfTestsId = 15 });
listGosts.Add(new Gosts() { Gost = "ASTM A262", TypeOfTestsId = 9 });
listGosts.Add(new Gosts() { Gost = "ASTM A262", TypeOfTestsId = 10 });
listGosts.Add(new Gosts() { Gost = "ASTM A262", TypeOfTestsId = 11 });
listGosts.Add(new Gosts() { Gost = "ASTM A262", TypeOfTestsId = 12 });
listGosts.Add(new Gosts() { Gost = "ASTM A262", TypeOfTestsId = 35 });
listGosts.Add(new Gosts() { Gost = "ASTM A262", TypeOfTestsId = 36 });
listGosts.Add(new Gosts() { Gost = "ASTM E112", TypeOfTestsId = 2 });
listGosts.Add(new Gosts() { Gost = "ASTM E112", TypeOfTestsId = 3 });
listGosts.Add(new Gosts() { Gost = "ISO 3651-2:1998", TypeOfTestsId = 9 });
listGosts.Add(new Gosts() { Gost = "ISO 3651-2:1998", TypeOfTestsId = 10 });
listGosts.Add(new Gosts() { Gost = "ISO 3651-2:1998", TypeOfTestsId = 11 });
listGosts.Add(new Gosts() { Gost = "ISO 3651-2:1998", TypeOfTestsId = 12 });
listGosts.Add(new Gosts() { Gost = "ISO 3651-2:1998", TypeOfTestsId = 35 });
listGosts.Add(new Gosts() { Gost = "ISO 3651-2:1998", TypeOfTestsId = 36 });
listGosts.Add(new Gosts() { Gost = "ISO 643", TypeOfTestsId = 2 });
listGosts.Add(new Gosts() { Gost = "ISO 643", TypeOfTestsId = 3 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 5639-82", TypeOfTestsId = 3 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 10243-75", TypeOfTestsId = 34 });
listGosts.Add(new Gosts() { Gost = "ГОСТ 11878-66", TypeOfTestsId = 27 });
listGosts.Add(new Gosts() { Gost = "ТИ", TypeOfTestsId = 2 });
listGosts.Add(new Gosts() { Gost = "ТИ", TypeOfTestsId = 3 });
listGosts.Add(new Gosts() { Gost = "ТИ", TypeOfTestsId = 15 });

foreach (var a in listGosts)
    db.Gosts.Add(a);*/

/*List<Pokazatels> listPokazatels = new List<Pokazatels>();

listPokazatels.Add(new Pokazatels() { GostsId = 1, Pokazatel = "Предел текучести" });
listPokazatels.AddRange(Растяжение(2));
listPokazatels.Add(new Pokazatels() { GostsId = 3, Pokazatel = "Относительное сужение" });
listPokazatels.AddRange(ЧислоТвердости(4));
listPokazatels.AddRange(ТрещиныСМеталическимБлеском(5));
listPokazatels.AddRange(ТрещиныИлиНадрывыСМеталическимБлеском(6));
listPokazatels.AddRange(ТрещиныИлиНадрывыСМеталическимБлеском(7));
listPokazatels.AddRange(ТрещиныИлиНадрывыСМеталическимБлеском(8));
listPokazatels.AddRange(ТрещиныИлиНадрывыСМеталическимБлеском(9));
listPokazatels.AddRange(ЧислоТвердости(10));
listPokazatels.AddRange(ЧислоТвердости(11));
listPokazatels.Add(new Pokazatels() { GostsId = 12, Pokazatel = "Предел текучести" });
listPokazatels.AddRange(Растяжение(13));
listPokazatels.Add(new Pokazatels() { GostsId = 14, Pokazatel = "Относительное сужение" });
listPokazatels.Add(new Pokazatels() { GostsId = 15, Pokazatel = "Предел текучести" });
listPokazatels.AddRange(Растяжение(16));
listPokazatels.Add(new Pokazatels() { GostsId = 17, Pokazatel = "Относительное сужение" });
listPokazatels.Add(new Pokazatels() { GostsId = 18, Pokazatel = "Предел текучести" });
listPokazatels.AddRange(Растяжение(19));
listPokazatels.Add(new Pokazatels() { GostsId = 20, Pokazatel = "Относительное сужение" });
listPokazatels.AddRange(Трещины(21));
listPokazatels.Add(new Pokazatels() { GostsId = 22, Pokazatel = "Предел текучести" });
listPokazatels.AddRange(Растяжение(23));
listPokazatels.Add(new Pokazatels() { GostsId = 24, Pokazatel = "Относительное сужение" });
listPokazatels.AddRange(НеметаллическиеВключения(25));
listPokazatels.AddRange(ВеличинаЗерна(26));
listPokazatels.AddRange(ВеличинаЗерна(27));
listPokazatels.AddRange(МКК(28));
listPokazatels.AddRange(МКК(29));
listPokazatels.AddRange(МКК(30));
listPokazatels.AddRange(МКК(31));
listPokazatels.AddRange(МКК(32));
listPokazatels.AddRange(МКК(33));
listPokazatels.AddRange(МКК(34));
listPokazatels.AddRange(МКК(35));
listPokazatels.AddRange(МКК(36));
listPokazatels.AddRange(МКК(37));
listPokazatels.AddRange(МКК(38));
listPokazatels.AddRange(МКК(39));
listPokazatels.AddRange(ВеличинаЗерна(40));
listPokazatels.AddRange(ВеличинаЗерна(41));
listPokazatels.AddRange(НеметаллическиеВключения(42));
listPokazatels.AddRange(МКК(43));
listPokazatels.AddRange(МКК(44));
listPokazatels.AddRange(МКК(45));
listPokazatels.AddRange(МКК(46));
listPokazatels.AddRange(МКК(47));
listPokazatels.AddRange(МКК(48));
listPokazatels.AddRange(ВеличинаЗерна(49));
listPokazatels.AddRange(ВеличинаЗерна(50));
listPokazatels.AddRange(МКК(51));
listPokazatels.AddRange(МКК(52));
listPokazatels.AddRange(МКК(53));
listPokazatels.AddRange(МКК(54));
listPokazatels.AddRange(МКК(55));
listPokazatels.AddRange(МКК(56));
listPokazatels.AddRange(ВеличинаЗерна(57));
listPokazatels.AddRange(ВеличинаЗерна(58));
listPokazatels.AddRange(ВеличинаЗерна(59));
listPokazatels.AddRange(Макроструктура(60));
listPokazatels.AddRange(ФеритнаяФаза(61));
listPokazatels.AddRange(ВеличинаЗерна(62));
listPokazatels.AddRange(ВеличинаЗерна(63));
listPokazatels.AddRange(НеметаллическиеВключения(64));

foreach (var item in listPokazatels)
{
    db.Pokazatels.Add(item);
}

List<Pokazatels> Растяжение(int id)
{
    List<Pokazatels> morePokazatels = new List<Pokazatels>();
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Предел текучести" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Временное сопротивление" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Отношение предела текучести к временному сопротивллению" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Относительное удлинение" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Относительное сужение" });
    return morePokazatels;
}

List<Pokazatels> ЧислоТвердости(int id)
{
    List<Pokazatels> morePokazatels = new List<Pokazatels>();
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Число твердости" });
    return morePokazatels;
}

List<Pokazatels> Трещины(int id)
{
    List<Pokazatels> morePokazatels = new List<Pokazatels>();
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Трещины" });
    return morePokazatels;
}

List<Pokazatels> ФеритнаяФаза(int id)
{
    List<Pokazatels> morePokazatels = new List<Pokazatels>();
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Содержание ферритной фазы" });
    return morePokazatels;
}

List<Pokazatels> МКК(int id)
{
    List<Pokazatels> morePokazatels = new List<Pokazatels>();
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Межкристаллитная коррозия" });
    return morePokazatels;
}

List<Pokazatels> ВеличинаЗерна(int id)
{
    List<Pokazatels> morePokazatels = new List<Pokazatels>();
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Величина зерна" });
    return morePokazatels;

}
List<Pokazatels> ТрещиныСМеталическимБлеском(int id)
{
    List<Pokazatels> morePokazatels = new List<Pokazatels>();
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Трещины с металлическим блеском" });
    return morePokazatels;
}

List<Pokazatels> ТрещиныИлиНадрывыСМеталическимБлеском(int id)
{
    List<Pokazatels> morePokazatels = new List<Pokazatels>();
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Трещины или надрывы с металлическим блеском" });
    return morePokazatels;
}

List<Pokazatels> НеметаллическиеВключения(int id)
{
    List<Pokazatels> morePokazatels = new List<Pokazatels>();
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Оксиды точечные" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Оксиды строчечные" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "СХ (силикаты хрупкие)" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "СП (силикаты пластичные)" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "СН (силикаты недеформирующиеся)" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "НС (нитриды строчечные)" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "НТ (нитриды  точечные)" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Сульфиды" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Нитриды и карбонитриды" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Кислородные включения" });
    return morePokazatels;
}

List<Pokazatels> Макроструктура(int id)
{
    List<Pokazatels> morePokazatels = new List<Pokazatels>();
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Краевая пятнистая ликвация" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Ликвационный квадрат" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Межкристалитные трещины" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "общая пятнистая ликвация" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Подкорковые пузыри" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Подусадочная ликвация" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "послойная кристаллизация" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Светлая полоса (контур)" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Точечная неоднородность" });
    morePokazatels.Add(new Pokazatels() { GostsId = id, Pokazatel = "Центральная пористость" });
    return morePokazatels;
}*/

/*List<EIs> listEI = new List<EIs>();

listEI.AddRange(ПределТекучести(1));
listEI.AddRange(ПределТекучести(2));
listEI.AddRange(ВременноеСопративление(3));
listEI.AddRange(ОтносительноеУдлинение(5));
listEI.AddRange(ОтносительноеСужение(6));
listEI.AddRange(ОтносительноеСужение(7));
listEI.AddRange(ЧислоТвёрдости(8));
listEI.AddRange(ЧислоТвёрдости(9));
listEI.AddRange(ЧислоТвёрдости(10));
listEI.AddRange(ЧислоТвёрдости(11));
listEI.AddRange(ЧислоТвёрдости(12));
listEI.AddRange(ЧислоТвёрдости(13));
listEI.AddRange(ЧислоТвёрдости(14));
listEI.AddRange(ЧислоТвёрдости(15));
listEI.AddRange(ПределТекучести(16));
listEI.AddRange(ПределТекучести(17));
listEI.AddRange(ВременноеСопративление(18));
listEI.AddRange(ОтносительноеУдлинение(20));
listEI.AddRange(ОтносительноеСужение(21));
listEI.AddRange(ОтносительноеСужение(22));
listEI.AddRange(ПределТекучести(23));
listEI.AddRange(ПределТекучести(24));
listEI.AddRange(ВременноеСопративление(25));
listEI.AddRange(ОтносительноеУдлинение(27));
listEI.AddRange(ОтносительноеСужение(28));
listEI.AddRange(ОтносительноеСужение(29));
listEI.AddRange(ПределТекучести(30));
listEI.AddRange(ПределТекучести(31));
listEI.AddRange(ВременноеСопративление(32));
listEI.AddRange(ОтносительноеУдлинение(34));
listEI.AddRange(ОтносительноеСужение(35));
listEI.AddRange(ОтносительноеСужение(36));
listEI.AddRange(Трещины(37));
listEI.AddRange(ПределТекучести(38));
listEI.AddRange(ПределТекучести(39));
listEI.AddRange(ВременноеСопративление(40));
listEI.AddRange(ОтносительноеУдлинение(42));
listEI.AddRange(ОтносительноеСужение(43));
listEI.AddRange(ОтносительноеСужение(44));
listEI.AddRange(Балл(45));
listEI.AddRange(Балл(46));
listEI.AddRange(Балл(47));
listEI.AddRange(Балл(48));
listEI.AddRange(Балл(49));
listEI.AddRange(Балл(50));
listEI.AddRange(Балл(51));
listEI.AddRange(Балл(52));
listEI.AddRange(Балл(53));
listEI.AddRange(Балл(54));
listEI.AddRange(ВеличинаЗерна(55));
listEI.AddRange(ВеличинаЗерна(56));
listEI.AddRange(МКК(57));
listEI.AddRange(МКК(58));
listEI.AddRange(МКК(59));
listEI.AddRange(МКК(60));
listEI.AddRange(МКК(61));
listEI.AddRange(МКК(62));
listEI.AddRange(МКК(63));
listEI.AddRange(МКК(64));
listEI.AddRange(МКК(65));
listEI.AddRange(МКК(66));
listEI.AddRange(МКК(67));
listEI.AddRange(МКК(68));
listEI.AddRange(ВеличинаЗерна(69));
listEI.AddRange(ВеличинаЗерна(70));
listEI.AddRange(Балл(71));
listEI.AddRange(Балл(72));
listEI.AddRange(Балл(73));
listEI.AddRange(Балл(74));
listEI.AddRange(Балл(75));
listEI.AddRange(Балл(76));
listEI.AddRange(Балл(77));
listEI.AddRange(Балл(78));
listEI.AddRange(Балл(79));
listEI.AddRange(Балл(80));
listEI.AddRange(МКК(81));
listEI.AddRange(МКК(82));
listEI.AddRange(МКК(83));
listEI.AddRange(МКК(84));
listEI.AddRange(МКК(85));
listEI.AddRange(МКК(86));
listEI.AddRange(ВеличинаЗерна(87));
listEI.AddRange(ВеличинаЗерна(88));
listEI.AddRange(МКК(89));
listEI.AddRange(МКК(90));
listEI.AddRange(МКК(91));
listEI.AddRange(МКК(92));
listEI.AddRange(МКК(93));
listEI.AddRange(МКК(94));
listEI.AddRange(ВеличинаЗерна(95));
listEI.AddRange(ВеличинаЗерна(96));
listEI.AddRange(ВеличинаЗерна(97));
listEI.AddRange(Балл(98));
listEI.AddRange(Балл(99));
listEI.AddRange(Балл(100));
listEI.AddRange(Балл(101));
listEI.AddRange(Балл(102));
listEI.AddRange(Балл(103));
listEI.AddRange(Балл(104));
listEI.AddRange(Балл(105));
listEI.AddRange(Балл(106));
listEI.AddRange(Балл(107));
listEI.AddRange(СФФ(108));
listEI.AddRange(ВеличинаЗерна(109));
listEI.AddRange(ВеличинаЗерна(110));
listEI.AddRange(Балл(111));
listEI.AddRange(Балл(112));
listEI.AddRange(Балл(113));
listEI.AddRange(Балл(114));
listEI.AddRange(Балл(115));
listEI.AddRange(Балл(116));
listEI.AddRange(Балл(117));
listEI.AddRange(Балл(118));
listEI.AddRange(Балл(119));
listEI.AddRange(Балл(120));

var list = listEI;
for (int i = 0; i < list.Count; i++)
{
    if (list[i].EI == "кгс/мм2")
        list[i].MainEI = "кгс/мм2";
    if (list[i].EI == "Отсутствие")
        list[i].MainEI = "Отсутствие";
    if (list[i].EI == "Не склонен")
        list[i].MainEI = "Не склонен";
}
*//*list[73].MainEI = "%";*//*
foreach (var item in list)
    db.EIs.Add(item);

List<EIs> МКК(int id)
{
    List<EIs> moreEIs = new List<EIs>();
    moreEIs.Add(new EIs(id, "Склонен"));
    moreEIs.Add(new EIs(id, "Не склонен"));
    return moreEIs;
}

List<EIs> ПределТекучести(int id)
{
    List<EIs> moreEIs = new List<EIs>();
    moreEIs.Add(new EIs(id, "Н/мм2"));
    moreEIs.Add(new EIs(id, "кгс/мм2"));
    return moreEIs;
}

List<EIs> ВременноеСопративление(int id)
{
    List<EIs> moreEIs = new List<EIs>();
    moreEIs.Add(new EIs(id, "Н/мм2"));
    moreEIs.Add(new EIs(id, "кгс/мм2"));
    return moreEIs;
}

List<EIs> ОтносительноеУдлинение(int id)
{
    List<EIs> moreEIs = new List<EIs>();
    moreEIs.Add(new EIs(id, "%"));
    return moreEIs;
}

List<EIs> ОтносительноеСужение(int id)
{
    List<EIs> moreEIs = new List<EIs>();
    moreEIs.Add(new EIs(id, "%"));
    return moreEIs;
}

List<EIs> ЧислоТвёрдости(int id)
{
    List<EIs> moreEIs = new List<EIs>();
    moreEIs.Add(new EIs(id, "HV"));
    moreEIs.Add(new EIs(id, "HB"));
    moreEIs.Add(new EIs(id, "HRA"));
    moreEIs.Add(new EIs(id, "HRB"));
    moreEIs.Add(new EIs(id, "HRC"));
    return moreEIs;
}

List<EIs> Трещины(int id)
{
    List<EIs> moreEIs = new List<EIs>();
    moreEIs.Add(new EIs(id, "Отсутствие"));
    moreEIs.Add(new EIs(id, "Наличие"));
    return moreEIs;
}

List<EIs> Балл(int id)
{
    List<EIs> moreEIs = new List<EIs>();
    moreEIs.Add(new EIs(id, "БАЛЛ"));
    return moreEIs;
}

List<EIs> ВеличинаЗерна(int id)
{
    List<EIs> moreEIs = new List<EIs>();
    moreEIs.Add(new EIs(id, "НОМ"));
    return moreEIs;
}

List<EIs> СФФ(int id)
{
    List<EIs> moreEIs = new List<EIs>();
    moreEIs.Add(new EIs(id, "%"));
    moreEIs.Add(new EIs(id, "БАЛЛ"));
    return moreEIs;
}*/


/*List<TypeOfTests> types = new List<TypeOfTests>();

types.Add(new TypeOfTests() { TypeOfTest = "Бортование" });
types.Add(new TypeOfTests() { TypeOfTest = "Величина аустенитного зерна" });
types.Add(new TypeOfTests() { TypeOfTest = "Величина зерна" });
types.Add(new TypeOfTests() { TypeOfTest = "Глубина внутренних дефектов" });
types.Add(new TypeOfTests() { TypeOfTest = "Загиб" });
types.Add(new TypeOfTests() { TypeOfTest = "Неметаллические включения" });
types.Add(new TypeOfTests() { TypeOfTest = "Испытания ТМЦ" });
types.Add(new TypeOfTests() { TypeOfTest = "Лабораторные испытания (дополн.)" });
types.Add(new TypeOfTests() { TypeOfTest = "МКК (А)" });
types.Add(new TypeOfTests() { TypeOfTest = "МКК (АМ)" });
types.Add(new TypeOfTests() { TypeOfTest = "МКК (АМУ)" });
types.Add(new TypeOfTests() { TypeOfTest = "МКК (Е)" });
types.Add(new TypeOfTests() { TypeOfTest = "Механические свойства" });
types.Add(new TypeOfTests() { TypeOfTest = "Микроструктура" });
types.Add(new TypeOfTests() { TypeOfTest = "Загрязн. немет. включениями" });
types.Add(new TypeOfTests() { TypeOfTest = "Обезуглероженный слой" });
types.Add(new TypeOfTests() { TypeOfTest = "Предел текучести" });
types.Add(new TypeOfTests() { TypeOfTest = "Раздача" });
types.Add(new TypeOfTests() { TypeOfTest = "Растяжение" });
types.Add(new TypeOfTests() { TypeOfTest = "Сплющивание" });
types.Add(new TypeOfTests() { TypeOfTest = "Сумма неметаллических включений" });
types.Add(new TypeOfTests() { TypeOfTest = "Твердость по Бринеллю" });
types.Add(new TypeOfTests() { TypeOfTest = "Твердость по Виккерсу" });
types.Add(new TypeOfTests() { TypeOfTest = "Твердость по Роквеллу" });
types.Add(new TypeOfTests() { TypeOfTest = "Толщина стенки" });
types.Add(new TypeOfTests() { TypeOfTest = "Ударная вязкость" });
types.Add(new TypeOfTests() { TypeOfTest = "Ферритная фаза" });
types.Add(new TypeOfTests() { TypeOfTest = "Хим.анализ_37 цех" });
types.Add(new TypeOfTests() { TypeOfTest = "Химический анализ плавки" });
types.Add(new TypeOfTests() { TypeOfTest = "Химический анализ плавки (ЛC)" });
types.Add(new TypeOfTests() { TypeOfTest = "Химический анализ плавки (Н)" });
types.Add(new TypeOfTests() { TypeOfTest = "Химический состав" });
types.Add(new TypeOfTests() { TypeOfTest = "Шероховатость поверхности" });
types.Add(new TypeOfTests() { TypeOfTest = "Макроструктура" });
types.Add(new TypeOfTests() { TypeOfTest = "МКК (АМУФ)" });
types.Add(new TypeOfTests() { TypeOfTest = "МКК (ВУ)" });
types.Add(new TypeOfTests() { TypeOfTest = "Сужение" });
types.Add(new TypeOfTests() { TypeOfTest = "Раздача до разрушения" });

foreach (var test in types)
{
    db.TypeOfTests.Add(test);
}*/

List<MoreData> listMD = new List<MoreData>();

listMD.AddRange(ПределТекучести(1));
listMD.AddRange(ПределТекучести(2));
listMD.AddRange(ВременноеCопротивление(3));
listMD.AddRange(ОтносительноеУдлинение(5));
listMD.AddRange(ОтносительноеСужение(6));
listMD.AddRange(ОтносительноеСужение(7));
listMD.AddRange(ПределТекучести(16));
listMD.AddRange(ПределТекучести(17));
listMD.AddRange(ВременноеCопротивление(18));
listMD.AddRange(ОтносительноеУдлинение(20));
listMD.AddRange(ОтносительноеСужение(21));
listMD.AddRange(ОтносительноеСужение(22));
listMD.AddRange(ПределТекучести(23));
listMD.AddRange(ПределТекучести(24));
listMD.AddRange(ВременноеCопротивление(25));
listMD.AddRange(ОтносительноеУдлинение(27));
listMD.AddRange(ОтносительноеСужение(28));
listMD.AddRange(ОтносительноеСужение(29));
listMD.AddRange(ПределТекучести(30));
listMD.AddRange(ПределТекучести(31));
listMD.AddRange(ВременноеCопротивление(32));
listMD.AddRange(ОтносительноеУдлинение(34));
listMD.AddRange(ОтносительноеСужение(35));
listMD.AddRange(ОтносительноеСужение(36));
listMD.AddRange(ПределТекучести(38));
listMD.AddRange(ПределТекучести(39));
listMD.AddRange(ВременноеCопротивление(40));
listMD.AddRange(ОтносительноеУдлинение(42));
listMD.AddRange(ОтносительноеСужение(43));
listMD.AddRange(ОтносительноеСужение(44));
listMD.AddRange(ОксидыТочечные(45));
listMD.AddRange(ОксидыСтрочечные(46));
listMD.AddRange(Сульфиды(52));
listMD.AddRange(НитридыИКарбонитриды(53));
listMD.AddRange(КислородныеВключения(54));
listMD.AddRange(МежкристаллитнаяКоррозия(57));
listMD.AddRange(МежкристаллитнаяКоррозия(58));
listMD.AddRange(МежкристаллитнаяКоррозия(59));
listMD.AddRange(МежкристаллитнаяКоррозия(60));
listMD.AddRange(МежкристаллитнаяКоррозия(61));
listMD.AddRange(МежкристаллитнаяКоррозия(62));
listMD.AddRange(МежкристаллитнаяКоррозия(63));
listMD.AddRange(МежкристаллитнаяКоррозия(64));
listMD.AddRange(МежкристаллитнаяКоррозия(65));
listMD.AddRange(МежкристаллитнаяКоррозия(66));
listMD.AddRange(МежкристаллитнаяКоррозия(67));
listMD.AddRange(МежкристаллитнаяКоррозия(68));
listMD.AddRange(ОксидыТочечные(71));
listMD.AddRange(ОксидыСтрочечные(72));
listMD.AddRange(Сульфиды(78));
listMD.AddRange(НитридыИКарбонитриды(79));
listMD.AddRange(КислородныеВключения(80));
listMD.AddRange(МежкристаллитнаяКоррозия(81));
listMD.AddRange(МежкристаллитнаяКоррозия(82));
listMD.AddRange(МежкристаллитнаяКоррозия(83));
listMD.AddRange(МежкристаллитнаяКоррозия(84));
listMD.AddRange(МежкристаллитнаяКоррозия(85));
listMD.AddRange(МежкристаллитнаяКоррозия(86));
listMD.AddRange(МежкристаллитнаяКоррозия(89));
listMD.AddRange(МежкристаллитнаяКоррозия(90));
listMD.AddRange(МежкристаллитнаяКоррозия(91));
listMD.AddRange(МежкристаллитнаяКоррозия(92));
listMD.AddRange(МежкристаллитнаяКоррозия(93));
listMD.AddRange(МежкристаллитнаяКоррозия(94));
listMD.AddRange(ОксидыТочечные(111));
listMD.AddRange(ОксидыСтрочечные(112));
listMD.AddRange(Сульфиды(118));
listMD.AddRange(НитридыИКарбонитриды(119));
listMD.AddRange(КислородныеВключения(120));

foreach (var item in listMD)
    db.MoreData.Add(item);


List<MoreData> ПределТекучести(int id)
{
    List<MoreData> moreDatas = new List<MoreData>();
    moreDatas.Add(new MoreData(id, "(+400)"));
    moreDatas.Add(new MoreData(id, "t=100С"));
    moreDatas.Add(new MoreData(id, "t=150С"));
    moreDatas.Add(new MoreData(id, "t=190С"));
    moreDatas.Add(new MoreData(id, "t=200С"));
    moreDatas.Add(new MoreData(id, "t=250С"));
    moreDatas.Add(new MoreData(id, "t=300С"));
    moreDatas.Add(new MoreData(id, "t=350С"));
    moreDatas.Add(new MoreData(id, "t=375С"));
    moreDatas.Add(new MoreData(id, "t=500С"));
    moreDatas.Add(new MoreData(id, "t=600С"));
    moreDatas.Add(new MoreData(id, "t=650С"));
    return moreDatas;
}

List<MoreData> ВременноеCопротивление(int id)
{
    List<MoreData> moreDatas = new List<MoreData>();
    moreDatas.Add(new MoreData(id, "t=100С"));
    moreDatas.Add(new MoreData(id, "t=150С"));
    moreDatas.Add(new MoreData(id, "t=190С"));
    moreDatas.Add(new MoreData(id, "t=200С"));
    moreDatas.Add(new MoreData(id, "t=250С"));
    moreDatas.Add(new MoreData(id, "t=300С"));
    moreDatas.Add(new MoreData(id, "t=350С"));
    moreDatas.Add(new MoreData(id, "t=375С"));
    moreDatas.Add(new MoreData(id, "t=500С"));
    moreDatas.Add(new MoreData(id, "t=600С"));
    moreDatas.Add(new MoreData(id, "t=650С"));
    return moreDatas;
}

List<MoreData> ОтносительноеУдлинение(int id)
{
    List<MoreData> moreDatas = new List<MoreData>();
    moreDatas.Add(new MoreData(id, "t=100С"));
    moreDatas.Add(new MoreData(id, "t=190С"));
    moreDatas.Add(new MoreData(id, "t=200С"));
    moreDatas.Add(new MoreData(id, "t=250С"));
    moreDatas.Add(new MoreData(id, "t=350С"));
    moreDatas.Add(new MoreData(id, "t=375С"));
    moreDatas.Add(new MoreData(id, "t=500С"));
    moreDatas.Add(new MoreData(id, "t=650С"));
    return moreDatas;
}

List<MoreData> ОтносительноеСужение(int id)
{
    List<MoreData> moreDatas = new List<MoreData>();
    moreDatas.Add(new MoreData(id, "t=20С"));
    moreDatas.Add(new MoreData(id, "t=150С"));
    moreDatas.Add(new MoreData(id, "t=200С"));
    moreDatas.Add(new MoreData(id, "t=250С"));
    moreDatas.Add(new MoreData(id, "t=350С"));
    moreDatas.Add(new MoreData(id, "t=400С"));
    moreDatas.Add(new MoreData(id, "t=500С"));
    return moreDatas;
}

List<MoreData> ОксидыТочечные(int id)
{
    List<MoreData> moreDatas = new List<MoreData>();
    moreDatas.Add(new MoreData(id, "макс"));
    moreDatas.Add(new MoreData(id, "ср"));
    return moreDatas;
}

List<MoreData> ОксидыСтрочечные(int id)
{
    List<MoreData> moreDatas = new List<MoreData>();
    moreDatas.Add(new MoreData(id, "макс"));
    moreDatas.Add(new MoreData(id, "ср"));
    return moreDatas;
}

List<MoreData> Сульфиды(int id)
{
    List<MoreData> moreDatas = new List<MoreData>();
    moreDatas.Add(new MoreData(id, "макс"));
    return moreDatas;
}

List<MoreData> НитридыИКарбонитриды(int id)
{
    List<MoreData> moreDatas = new List<MoreData>();
    moreDatas.Add(new MoreData(id, "ниобия max"));
    moreDatas.Add(new MoreData(id, "строчечные средний"));
    moreDatas.Add(new MoreData(id, "титана max"));
    moreDatas.Add(new MoreData(id, "макс"));
    return moreDatas;
}
List<MoreData> МежкристаллитнаяКоррозия(int id)
{
    List<MoreData> moreDatas = new List<MoreData>();
    moreDatas.Add(new MoreData(id, "по методу  АМ"));
    moreDatas.Add(new MoreData(id, "по методу E"));
    moreDatas.Add(new MoreData(id, "по методу А"));
    moreDatas.Add(new MoreData(id, "по методу АМУ"));
    moreDatas.Add(new MoreData(id, "по методу АМУФ"));
    moreDatas.Add(new MoreData(id, "по методу ВУ"));
    return moreDatas;
}

List<MoreData> ЧислоТвердости(int id)
{
    List<MoreData> moreDatas = new List<MoreData>();
    moreDatas.Add(new MoreData(id, "по Бринеллю"));
    moreDatas.Add(new MoreData(id, "по Бринеллю (диаметр отпечатка)"));
    moreDatas.Add(new MoreData(id, "по Роквеллу"));
    return moreDatas;
}

List<MoreData> КислородныеВключения(int id)
{
    List<MoreData> moreDatas = new List<MoreData>();
    moreDatas.Add(new MoreData(id, "глобулярные"));
    moreDatas.Add(new MoreData(id, "строчечные"));
    return moreDatas;
}

db.SaveChanges();