using Excel;

ApplicationContext db = new ApplicationContext();


/*List<Gosts> list = new List<Gosts>();
Gosts g1 = new Gosts();
g1.Gost = "ГОСТ 1497-84";
g1.TypeOfTestsId = 19;
list.Add(g1);
Gosts g2 = new Gosts();
g2.Gost = "ГОСТ 2999-75";
g2.TypeOfTestsId = 23;
list.Add(g2);
Gosts g3 = new Gosts();
g3.Gost = "ГОСТ 3728-78";
g3.TypeOfTestsId = 5;
list.Add(g3);
Gosts g4 = new Gosts();
g4.Gost = "ГОСТ 8693-2022";
g4.TypeOfTestsId = 1;
list.Add(g4);
Gosts g5 = new Gosts();
g5.Gost = "ГОСТ 8694-2022";
g5.TypeOfTestsId = 18;
list.Add(g5);
Gosts g6 = new Gosts();
g6.Gost = "ГОСТ 8695-2022";
g6.TypeOfTestsId = 20;
list.Add(g6);
Gosts g7 = new Gosts();
g7.Gost = "ГОСТ 9012-59";
g7.TypeOfTestsId = 19;
list.Add(g7);
Gosts g8 = new Gosts();
g8.Gost = "ГОСТ 9013-59";
g8.TypeOfTestsId = 24;
list.Add(g8);
Gosts g9 = new Gosts();
g9.Gost = "ГОСТ 9651-84";
g9.TypeOfTestsId = 19;
list.Add(g9);
Gosts g10 = new Gosts();
g10.Gost = "ГОСТ 10006-80";
g10.TypeOfTestsId = 19;
list.Add(g10);
Gosts g11 = new Gosts();
g11.Gost = "ГОСТ 10446-80";
g11.TypeOfTestsId = 19;
list.Add(g11);
Gosts g12 = new Gosts();
g12.Gost = "ГОСТ 14019-2003";
g12.TypeOfTestsId = 5;
list.Add(g12);
Gosts g13 = new Gosts();
g13.Gost = "ГОСТ 19040-81";
g13.TypeOfTestsId = 19;
list.Add(g13);
Gosts g14 = new Gosts();
g14.Gost = "ГОСТ 1778-2022";
g14.TypeOfTestsId = 15;
list.Add(g14);
Gosts g15 = new Gosts();
g15.Gost = "ГОСТ 5639-82";
g15.TypeOfTestsId = 3;
list.Add(g15);
Gosts g16 = new Gosts();
g16.Gost = "ГОСТ 6032-2017";
g16.TypeOfTestsId = 9;
list.Add(g16);
Gosts g17 = new Gosts();
g17.Gost = "РД 2.200.15-90";
g17.TypeOfTestsId = 9;
list.Add(g17);
Gosts g18 = new Gosts();
g18.Gost = "Методика ВНИТИ №7-95-87";
g18.TypeOfTestsId = 3;
list.Add(g18);
Gosts g19 = new Gosts();
g19.Gost = "Методика ВНИТИ №7-96-87";
g19.TypeOfTestsId = 15;
list.Add(g19);
Gosts g20 = new Gosts();
g20.Gost = "ASTM A262";
g20.TypeOfTestsId = 9;
list.Add(g20);
Gosts g21 = new Gosts();
g21.Gost = "ASTM E112";
g21.TypeOfTestsId = 3;
list.Add(g21);
Gosts g22 = new Gosts();
g22.Gost = "ISO 3651-2:1998";
g22.TypeOfTestsId = 3;
list.Add(g22);
Gosts g23 = new Gosts();
g23.Gost = "ISO 643";
g23.TypeOfTestsId = 3;
list.Add(g23);
Gosts g24 = new Gosts();
g24.Gost = "ГОСТ 5639-82";
g24.TypeOfTestsId = 3;
list.Add(g24);
Gosts g25 = new Gosts();
g25.Gost = "ГОСТ 10243-75";
g25.TypeOfTestsId = 0;
list.Add(g25);
Gosts g26 = new Gosts();
g26.Gost = "ГОСТ 11878-66";
g26.TypeOfTestsId = 27;
list.Add(g26);

Gosts g161 = new Gosts();
g161.Gost = "ГОСТ 6032-2017";
g161.TypeOfTestsId = 10;
list.Add(g161);

Gosts g162 = new Gosts();
g162.Gost = "ГОСТ 6032-2017";
g162.TypeOfTestsId = 11;
list.Add(g162);

Gosts g163 = new Gosts();
g163.Gost = "ГОСТ 6032-2017";
g163.TypeOfTestsId = 12;
list.Add(g163);

Gosts g171 = new Gosts();
g171.Gost = "РД 2.200.15-90";
g171.TypeOfTestsId = 10;
list.Add(g171);

Gosts g172 = new Gosts();
g172.Gost = "РД 2.200.15-90";
g172.TypeOfTestsId = 11;
list.Add(g172);

Gosts g173 = new Gosts();
g173.Gost = "РД 2.200.15-90";
g173.TypeOfTestsId = 12;
list.Add(g173);

Gosts g201 = new Gosts();
g201.Gost = "ASTM A262";
g201.TypeOfTestsId = 10;
list.Add(g201);

Gosts g202 = new Gosts();
g202.Gost = "ASTM A262";
g202.TypeOfTestsId = 11;
list.Add(g202);

Gosts g203 = new Gosts();
g203.Gost = "ASTM A262";
g203.TypeOfTestsId = 12;
list.Add(g203);


foreach (var a in list)
    db.Gosts.Add(a);*/

List<Pokazatels> list1 = new List<Pokazatels>();


/*Pokazatels p21 = new Pokazatels();
p21.GostsId = 1;
p21.Pokazatel = "Предел текучести";
list1.Add(p21);

Pokazatels p22 = new Pokazatels();
p22.GostsId = 1;
p22.Pokazatel = "Временное сопротивление";
list1.Add(p22);

Pokazatels p23 = new Pokazatels();
p23.GostsId = 1;
p23.Pokazatel = "Отношение предела текучести к временному сопротивллению";
list1.Add(p23);

Pokazatels p24 = new Pokazatels();
p24.GostsId = 1;
p24.Pokazatel = "Относительное удлинение";
list1.Add(p24);

Pokazatels p25 = new Pokazatels();
p25.GostsId = 1;
p25.Pokazatel = "Относительное сужение";
list1.Add(p25);

Pokazatels p26 = new Pokazatels();
p26.GostsId = 2;
p26.Pokazatel = "Число твердости";
list1.Add(p26);

Pokazatels p27 = new Pokazatels();
p27.GostsId = 3;
p27.Pokazatel = "Трещины с металлическим блеском";
list1.Add(p27);

Pokazatels p28 = new Pokazatels();
p28.GostsId = 4;
p28.Pokazatel = "Трещины или надрывы с металлическим блеском";
list1.Add(p28);

Pokazatels p29 = new Pokazatels();
p29.GostsId = 5;
p29.Pokazatel = "Трещины или надрывы с металлическим блеском";
list1.Add(p29);

Pokazatels p210 = new Pokazatels();
p210.GostsId = 6;
p210.Pokazatel = "Трещины или надрывы с металлическим блеском";
list1.Add(p210);

Pokazatels p211 = new Pokazatels();
p211.GostsId = 7;
p211.Pokazatel = "Число твердости";
list1.Add(p211);

Pokazatels p212 = new Pokazatels();
p212.GostsId = 8;
p212.Pokazatel = "Число твердости";
list1.Add(p212);

Pokazatels p213 = new Pokazatels();
p213.GostsId = 9;
p213.Pokazatel = "Предел текучести";
list1.Add(p213);

Pokazatels p214 = new Pokazatels();
p214.GostsId = 9;
p214.Pokazatel = "Временное сопротивление";
list1.Add(p214);

Pokazatels p215 = new Pokazatels();
p215.GostsId = 9;
p215.Pokazatel = "Относительное удлинение";
list1.Add(p215);

Pokazatels p216 = new Pokazatels();
p216.GostsId = 9;
p216.Pokazatel = "Относительное сужение";
list1.Add(p216);

Pokazatels p217 = new Pokazatels();
p217.GostsId = 10;
p217.Pokazatel = "Предел текучести";
list1.Add(p217);

Pokazatels p218 = new Pokazatels();
p218.GostsId = 10;
p218.Pokazatel = "Временное сопротивление";
list1.Add(p218);

Pokazatels p219 = new Pokazatels();
p219.GostsId = 10;
p219.Pokazatel = "Относительное удлинение";
list1.Add(p219);

Pokazatels p220 = new Pokazatels();
p220.GostsId = 10;
p220.Pokazatel = "Относительное сужение";
list1.Add(p220);

Pokazatels p221 = new Pokazatels();
p221.GostsId = 11;
p221.Pokazatel = "Временное сопротивление";
list1.Add(p221);

Pokazatels p222 = new Pokazatels();
p222.GostsId = 11;
p222.Pokazatel = "Относительное сужение";
list1.Add(p222);

Pokazatels p223 = new Pokazatels();
p223.GostsId = 12;
p223.Pokazatel = "Трещины";
list1.Add(p223);

Pokazatels p224 = new Pokazatels();
p224.GostsId = 13;
p224.Pokazatel = "Предел текучести";
list1.Add(p224);

Pokazatels p225 = new Pokazatels();
p225.GostsId = 13;
p225.Pokazatel = "Временное сопротивление";
list1.Add(p225);

Pokazatels p226 = new Pokazatels();
p226.GostsId = 13;
p226.Pokazatel = "Относительное удлинение";
list1.Add(p226);

Pokazatels p227 = new Pokazatels();
p227.GostsId = 13;
p227.Pokazatel = "Относительное сужение";
list1.Add(p227);

Pokazatels p228 = new Pokazatels();
p228.GostsId = 14;
p228.Pokazatel = "Оксиды точечные";
list1.Add(p228);

Pokazatels p229 = new Pokazatels();
p229.GostsId = 14;
p229.Pokazatel = "Оксиды строчечные";
list1.Add(p229);

Pokazatels p230 = new Pokazatels();
p230.GostsId = 14;
p230.Pokazatel = "СХ (силикаты хрупкие)";
list1.Add(p230);

Pokazatels p231 = new Pokazatels();
p231.GostsId = 14;
p231.Pokazatel = "СП (силикаты пластичные)";
list1.Add(p231);

Pokazatels p232 = new Pokazatels();
p232.GostsId = 14;
p232.Pokazatel = "СН (силикаты недеформирующиеся)";
list1.Add(p232);

Pokazatels p233 = new Pokazatels();
p233.GostsId = 14;
p233.Pokazatel = "Сульфиды";
list1.Add(p233);

Pokazatels p234 = new Pokazatels();
p234.GostsId = 14;
p234.Pokazatel = "Нитриды и карбонитриды";
list1.Add(p234);

Pokazatels p235 = new Pokazatels();
p235.GostsId = 15;
p235.Pokazatel = "Величина зерна";
list1.Add(p235);

Pokazatels p236 = new Pokazatels();
p236.GostsId = 16;
p236.Pokazatel = "Межкристаллитная коррозия";
list1.Add(p236);

Pokazatels p237 = new Pokazatels();
p237.GostsId = 16;
p237.Pokazatel = "Межкристаллитная коррозия";
list1.Add(p237);

Pokazatels p238 = new Pokazatels();
p238.GostsId = 16;
p238.Pokazatel = "Межкристаллитная коррозия";
list1.Add(p238);

Pokazatels p239 = new Pokazatels();
p239.GostsId = 16;
p239.Pokazatel = "Межкристаллитная коррозия";
list1.Add(p239);

Pokazatels p240 = new Pokazatels();
p240.GostsId = 17;
p240.Pokazatel = "Межкристаллитная коррозия";
list1.Add(p240);

Pokazatels p241 = new Pokazatels();
p241.GostsId = 18;
p241.Pokazatel = "Величина зерна";
list1.Add(p241);

Pokazatels p242 = new Pokazatels();
p242.GostsId = 19;
p242.Pokazatel = "Оксиды точечные";
list1.Add(p242);

Pokazatels p243 = new Pokazatels();
p243.GostsId = 19;
p243.Pokazatel = "Оксиды строчечные";
list1.Add(p243);

Pokazatels p244 = new Pokazatels();
p244.GostsId = 19;
p244.Pokazatel = "Сульфиды";
list1.Add(p244);

Pokazatels p245 = new Pokazatels();
p245.GostsId = 19;
p245.Pokazatel = "Нитриды и карбонитриды";
list1.Add(p245);

Pokazatels p2 = new Pokazatels();
p2.GostsId = 20;
p2.Pokazatel = "Межкристаллитная коррозия";
list1.Add(p2);


Pokazatels p3 = new Pokazatels();
p3.GostsId = 21;
p3.Pokazatel = "Величина зерна";
list1.Add(p3);
Pokazatels p4 = new Pokazatels();
p4.GostsId = 22;
p4.Pokazatel = "Межкристаллитная коррозия";
list1.Add(p4);
Pokazatels p5 = new Pokazatels();
p5.GostsId = 23;
p5.Pokazatel = "Величина зерна";
list1.Add(p5);
Pokazatels p6 = new Pokazatels();
p6.GostsId = 24;
p6.Pokazatel = "Величина зерна";
list1.Add(p6);
Pokazatels p7 = new Pokazatels();
p7.GostsId = 25;
p7.Pokazatel = "";
list1.Add(p7);
Pokazatels p8 = new Pokazatels();
p8.GostsId = 26;
p8.Pokazatel = "Содержание ферритной фазы";
list1.Add(p8);

Pokazatels p9 = new Pokazatels();
p9.GostsId = 27;
p9.Pokazatel = "Межкристаллитная коррозия";
list1.Add(p9);

Pokazatels p10 = new Pokazatels();
p10.GostsId = 28;
p10.Pokazatel = "Межкристаллитная коррозия";
list1.Add(p10);

Pokazatels p11 = new Pokazatels();
p11.GostsId = 29;
p11.Pokazatel = "Межкристаллитная коррозия";
list1.Add(p11);

Pokazatels p12 = new Pokazatels();
p12.GostsId = 30;
p12.Pokazatel = "Межкристаллитная коррозия";
list1.Add(p12);

Pokazatels p13 = new Pokazatels();
p13.GostsId = 31;
p13.Pokazatel = "Межкристаллитная коррозия";
list1.Add(p13);

Pokazatels p14 = new Pokazatels();
p14.GostsId = 32;
p14.Pokazatel = "Межкристаллитная коррозия";
list1.Add(p14);*/

/*Pokazatels p7123 = new Pokazatels();
p7123.GostsId = 25;
p7123.Pokazatel = "Предел текучести";
list1.Add(p7123);

Pokazatels p71231 = new Pokazatels();
p71231.GostsId = 25;
p71231.Pokazatel = "Временное сопротивление";
list1.Add(p71231);

Pokazatels p71232 = new Pokazatels();
p71232.GostsId = 25;
p71232.Pokazatel = "Относительное удлинение";
list1.Add(p71232);

Pokazatels p71233 = new Pokazatels();
p71233.GostsId = 25;
p71233.Pokazatel = "Относительное сужение";
list1.Add(p71233);

Pokazatels p71234 = new Pokazatels();
p71234.GostsId = 25;
p71234.Pokazatel = "Число твердости";
list1.Add(p71234);

Pokazatels p71235 = new Pokazatels();
p71235.GostsId = 25;
p71235.Pokazatel = "Трещины с металлическим блеском";
list1.Add(p71235);

Pokazatels p71236 = new Pokazatels();
p71236.GostsId = 25;
p71236.Pokazatel = "Трещины или надрывы с металлическим блеском";
list1.Add(p71236);

Pokazatels p71237 = new Pokazatels();
p71237.GostsId = 25;
p71237.Pokazatel = "Трещины";
list1.Add(p71237);

Pokazatels p71238 = new Pokazatels();
p71238.GostsId = 25;
p71238.Pokazatel = "Оксиды точечные";
list1.Add(p71238);

Pokazatels p71239 = new Pokazatels();
p71239.GostsId = 25;
p71239.Pokazatel = "Оксиды строчечные";
list1.Add(p71239);

Pokazatels p71240 = new Pokazatels();
p71240.GostsId = 25;
p71240.Pokazatel = "СХ (силикаты хрупкие)";
list1.Add(p71240);

Pokazatels p71241 = new Pokazatels();
p71241.GostsId = 25;
p71241.Pokazatel = "СП (силикаты пластичные)";
list1.Add(p71241);

Pokazatels p71242 = new Pokazatels();
p71242.GostsId = 25;
p71242.Pokazatel = "СН (силикаты недеформирующиеся)";
list1.Add(p71242);

Pokazatels p71243 = new Pokazatels();
p71243.GostsId = 25;
p71243.Pokazatel = "Сульфиды";
list1.Add(p71243);

Pokazatels p71244 = new Pokazatels();
p71244.GostsId = 25;
p71244.Pokazatel = "Нитриды и карбонитриды";
list1.Add(p71244);

Pokazatels p71245 = new Pokazatels();
p71245.GostsId = 25;
p71245.Pokazatel = "Величина зерна";
list1.Add(p71245);

Pokazatels p71246 = new Pokazatels();
p71246.GostsId = 25;
p71246.Pokazatel = "Межкристаллитная коррозия";
list1.Add(p71246);

Pokazatels p71247 = new Pokazatels();
p71247.GostsId = 25;
p71247.Pokazatel = "Содержание ферритной фазы";
list1.Add(p71247);



foreach (var item in list1)
{
    db.Pokazatels.Add(item);
}*/

List<EIs> list2 = new List<EIs>();
/*EIs e112 = new EIs();
e112.PokazatelsId = 1;
e112.EI = "Н/мм2";
list2.Add(e112);

EIs e111 = new EIs();
e111.PokazatelsId = 1;
e111.EI = "кгс/мм2";
list2.Add(e111);

EIs e113 = new EIs();
e113.PokazatelsId = 2;
e113.EI = "Н/мм2";
list2.Add(e113);

EIs e114 = new EIs();
e114.PokazatelsId = 2;
e114.EI = "кгс/мм2";
list2.Add(e114);

EIs e119 = new EIs();
e119.PokazatelsId = 4;
e119.EI = "%";
list2.Add(e119);

EIs e120 = new EIs();
e120.PokazatelsId = 5;
e120.EI = "%";
list2.Add(e120);

EIs e121 = new EIs();
e121.PokazatelsId = 6;
e121.EI = "HV";
list2.Add(e121);

EIs e122 = new EIs();
e122.PokazatelsId = 7;
e122.EI = "Отсутствие";
list2.Add(e122);

EIs e122q = new EIs();
e122q.PokazatelsId = 7;
e122q.EI = "Наличие";
list2.Add(e122q);

EIs e123 = new EIs();
e123.PokazatelsId = 8;
e123.EI = "Отсутствие";
list2.Add(e123);

EIs e123q = new EIs();
e123q.PokazatelsId = 8;
e123q.EI = "Наличие";
list2.Add(e123q);

EIs e124 = new EIs();
e124.PokazatelsId = 9;
e124.EI = "Отсутствие";
list2.Add(e124);

EIs e12q4 = new EIs();
e12q4.PokazatelsId = 9;
e12q4.EI = "Наличие";
list2.Add(e12q4);

EIs e125 = new EIs();
e125.PokazatelsId = 10;
e125.EI = "Отсутствие";
list2.Add(e125);

EIs e1e25 = new EIs();
e1e25.PokazatelsId = 10;
e1e25.EI = "Наличие";
list2.Add(e1e25);

EIs e126 = new EIs();
e126.PokazatelsId = 11;
e126.EI = "HB";
list2.Add(e126);

EIs e1 = new EIs();
e1.PokazatelsId = 12;
e1.EI = "HRA";
list2.Add(e1);


EIs e2 = new EIs();
e2.PokazatelsId = 12;
e2.EI = "HRB";
list2.Add(e2);

EIs e3 = new EIs();
e3.PokazatelsId = 12;
e3.EI = "HRC";
list2.Add(e3);

EIs e4 = new EIs();
e4.PokazatelsId = 13;
e4.EI = "Н/мм2";
list2.Add(e4);

EIs e5 = new EIs();
e5.PokazatelsId = 13;
e5.EI = "кгс/мм2";
list2.Add(e5);

EIs e6 = new EIs();
e6.PokazatelsId = 14;
e6.EI = "Н/мм2";
list2.Add(e6);

EIs e7 = new EIs();
e7.PokazatelsId = 14;
e7.EI = "кгс/мм2";
list2.Add(e7);

EIs e8 = new EIs();
e8.PokazatelsId = 15;
e8.EI = "%";
list2.Add(e8);

EIs e9 = new EIs();
e9.PokazatelsId = 16;
e9.EI = "%";
list2.Add(e9);

EIs e10 = new EIs();
e10.PokazatelsId = 17;
e10.EI = "Н/мм2";
list2.Add(e10);

EIs e11 = new EIs();
e11.PokazatelsId = 17;
e11.EI = "кгс/мм2";
list2.Add(e11);

EIs e12 = new EIs();
e12.PokazatelsId = 18;
e12.EI = "Н/мм2";
list2.Add(e12);

EIs e13 = new EIs();
e13.PokazatelsId = 18;
e13.EI = "кгс/мм2";
list2.Add(e13);

EIs e14 = new EIs();
e14.PokazatelsId = 19;
e14.EI = "%";
list2.Add(e14);

EIs e15 = new EIs();
e15.PokazatelsId = 20;
e15.EI = "%";
list2.Add(e15);

EIs e16 = new EIs();
e16.PokazatelsId = 21;
e16.EI = "Н/мм2";
list2.Add(e16);

EIs e17 = new EIs();
e17.PokazatelsId = 21;
e17.EI = "кгс/мм2";
list2.Add(e17);

EIs e18 = new EIs();
e18.PokazatelsId = 22;
e18.EI = "%";
list2.Add(e18);

EIs e19 = new EIs();
e19.PokazatelsId = 23;
e19.EI = "Отсутствие";
list2.Add(e19);

EIs e1q19 = new EIs();
e1q19.PokazatelsId = 23;
e1q19.EI = "Наличие";
list2.Add(e1q19);

EIs e20 = new EIs();
e20.PokazatelsId = 24;
e20.EI = "Н/мм2";
list2.Add(e20);

EIs e21 = new EIs();
e21.PokazatelsId = 24;
e21.EI = "кгс/мм2";
list2.Add(e21);

EIs e22 = new EIs();
e22.PokazatelsId = 25;
e22.EI = "Н/мм2";
list2.Add(e22);

EIs e23 = new EIs();
e23.PokazatelsId = 25;
e23.EI = "кгс/мм2";
list2.Add(e23);

EIs e24 = new EIs();
e24.PokazatelsId = 26;
e24.EI = "%";
list2.Add(e24);

EIs e25 = new EIs();
e25.PokazatelsId = 27;
e25.EI = "%";
list2.Add(e25);

EIs e26 = new EIs();
e26.PokazatelsId = 28;
e26.EI = "БАЛЛ";
list2.Add(e26);

EIs e27 = new EIs();
e27.PokazatelsId = 29;
e27.EI = "БАЛЛ";
list2.Add(e27);

EIs e28 = new EIs();
e28.PokazatelsId = 30;
e28.EI = "БАЛЛ";
list2.Add(e28);

EIs e29 = new EIs();
e29.PokazatelsId = 31;
e29.EI = "БАЛЛ";
list2.Add(e29);

EIs e30 = new EIs();
e30.PokazatelsId = 32;
e30.EI = "БАЛЛ";
list2.Add(e30);

EIs e31 = new EIs();
e31.PokazatelsId = 33;
e31.EI = "БАЛЛ";
list2.Add(e31);

EIs e32 = new EIs();
e32.PokazatelsId = 34;
e32.EI = "БАЛЛ";
list2.Add(e32);

EIs e33 = new EIs();
e33.PokazatelsId = 35;
e33.EI = "НОМ";
list2.Add(e33);

EIs e34 = new EIs();
e34.PokazatelsId = 36;
e34.EI = "Склонен";
list2.Add(e34);

EIs eа34 = new EIs();
eа34.PokazatelsId = 36;
eа34.EI = "Не склонен";
list2.Add(eа34);

EIs e35 = new EIs();
e35.PokazatelsId = 37;
e35.EI = "Склонен";
list2.Add(e35);

EIs e3е5 = new EIs();
e3е5.PokazatelsId = 37;
e3е5.EI = "Не склонен";
list2.Add(e3е5);

EIs e36 = new EIs();
e36.PokazatelsId = 38;
e36.EI = "Склонен";
list2.Add(e36);

EIs e3ап6 = new EIs();
e3ап6.PokazatelsId = 38;
e3ап6.EI = "Не склонен";
list2.Add(e3ап6);

EIs e37 = new EIs();
e37.PokazatelsId = 39;
e37.EI = "Склонен";
list2.Add(e37);

EIs e3п7 = new EIs();
e3п7.PokazatelsId = 39;
e3п7.EI = "Не склонен";
list2.Add(e3п7);

EIs e38 = new EIs();
e38.PokazatelsId = 40;
e38.EI = "Склонен";
list2.Add(e38);

EIs e3р8 = new EIs();
e3р8.PokazatelsId = 40;
e3р8.EI = "Не склонен";
list2.Add(e3р8);

EIs e39 = new EIs();
e39.PokazatelsId = 41;
e39.EI = "НОМ";
list2.Add(e39);

EIs e40 = new EIs();
e40.PokazatelsId = 42;
e40.EI = "БАЛЛ";
list2.Add(e40);

EIs e41 = new EIs();
e41.PokazatelsId = 43;
e41.EI = "БАЛЛ";
list2.Add(e41);

EIs e42 = new EIs();
e42.PokazatelsId = 44;
e42.EI = "БАЛЛ";
list2.Add(e42);

EIs e43 = new EIs();
e43.PokazatelsId = 45;
e43.EI = "БАЛЛ";
list2.Add(e43);

EIs e381 = new EIs();
e381.PokazatelsId = 46;
e381.EI = "Склонен";
list2.Add(e381);

EIs e3р82 = new EIs();
e3р82.PokazatelsId = 46;
e3р82.EI = "Не склонен";
list2.Add(e3р82);

EIs e3813 = new EIs();
e3813.PokazatelsId = 47;
e3813.EI = "НОМ";
list2.Add(e3813);


EIs e38135 = new EIs();
e38135.PokazatelsId = 48;
e38135.EI = "Склонен";
list2.Add(e38135);

EIs e3р8246 = new EIs();
e3р8246.PokazatelsId = 48;
e3р8246.EI = "Не склонен";
list2.Add(e3р8246);

EIs e38136 = new EIs();
e38136.PokazatelsId = 49;
e38136.EI = "НОМ";
list2.Add(e38136);


EIs e38138 = new EIs();
e38138.PokazatelsId = 50;
e38138.EI = "НОМ";
list2.Add(e38138);


EIs e381381 = new EIs();
e381381.PokazatelsId = 51;
e381381.EI = "";
list2.Add(e381381);


EIs e44 = new EIs();
e44.PokazatelsId = 52;
e44.EI = "НОМ";
list2.Add(e44);

EIs e45 = new EIs();
e45.PokazatelsId = 53;
e45.EI = "Склонен";
list2.Add(e45);

EIs e4512 = new EIs();
e4512.PokazatelsId = 53;
e4512.EI = "Не склонен";
list2.Add(e4512);

EIs e46 = new EIs();
e46.PokazatelsId = 54;
e46.EI = "Склонен";
list2.Add(e46);

EIs e4м6 = new EIs();
e4м6.PokazatelsId = 54;
e4м6.EI = "Не склонен";
list2.Add(e4м6);

EIs e47 = new EIs();
e47.PokazatelsId = 55;
e47.EI = "Склонен";
list2.Add(e47);

EIs e4714 = new EIs();
e4714.PokazatelsId = 55;
e4714.EI = "Не склонен";
list2.Add(e4714);

EIs e48 = new EIs();
e48.PokazatelsId = 56;
e48.EI = "Склонен";
list2.Add(e48);

EIs e48167 = new EIs();
e48167.PokazatelsId = 56;
e48167.EI = "Не склонен";
list2.Add(e48167);

EIs e49 = new EIs();
e49.PokazatelsId = 57;
e49.EI = "Склонен";
list2.Add(e49);

EIs eп49 = new EIs();
eп49.PokazatelsId = 57;
eп49.EI = "Не склонен";
list2.Add(eп49);

EIs e50 = new EIs();
e50.PokazatelsId = 58;
e50.EI = "Склонен";
list2.Add(e50);

EIs e505 = new EIs();
e505.PokazatelsId = 58;
e505.EI = "Не склонен";
list2.Add(e505);*/

/*EIs ed51 = new EIs();
ed51.PokazatelsId = 59;
ed51.EI = "Склонен";
list2.Add(ed51);

EIs ed52 = new EIs();
ed52.PokazatelsId = 59;
ed52.EI = "Не склонен";
list2.Add(ed52);

EIs ed53 = new EIs();
ed53.PokazatelsId = 60;
ed53.EI = "Склонен";
list2.Add(ed53);

EIs ed54 = new EIs();
ed54.PokazatelsId = 60;
ed54.EI = "Не склонен";
list2.Add(ed54);

EIs ed55 = new EIs();
ed55.PokazatelsId = 61;
ed55.EI = "Склонен";
list2.Add(ed55);

EIs ed56 = new EIs();
ed56.PokazatelsId = 61;
ed56.EI = "Не склонен";
list2.Add(ed56);

EIs ed57 = new EIs();
ed57.PokazatelsId = 62;
ed57.EI = "Склонен";
list2.Add(ed57);

EIs ed58 = new EIs();
ed58.PokazatelsId = 62;
ed58.EI = "Не склонен";
list2.Add(ed58);

EIs ed59 = new EIs();
ed59.PokazatelsId = 63;
ed59.EI = "Склонен";
list2.Add(ed59);

EIs ed60 = new EIs();
ed60.PokazatelsId = 63;
ed60.EI = "Не склонен";
list2.Add(ed60);

EIs ed61 = new EIs();
ed61.PokazatelsId = 64;
ed61.EI = "Склонен";
list2.Add(ed61);

EIs ed62 = new EIs();
ed62.PokazatelsId = 64;
ed62.EI = "Не склонен";
list2.Add(ed62);

EIs ed63 = new EIs();
ed63.PokazatelsId = 65;
ed63.EI = "Склонен";
list2.Add(ed63);

EIs ed64 = new EIs();
ed64.PokazatelsId = 65;
ed64.EI = "Не склонен";
list2.Add(ed64);

EIs ed65 = new EIs();
ed65.PokazatelsId = 66;
ed65.EI = "Склонен";
list2.Add(ed65);

EIs ed66 = new EIs();
ed66.PokazatelsId = 66;
ed66.EI = "Не склонен";
list2.Add(ed66);

EIs ed67 = new EIs();
ed67.PokazatelsId = 67;
ed67.EI = "Склонен";
list2.Add(ed67);

EIs ed68 = new EIs();
ed68.PokazatelsId = 67;
ed68.EI = "Не склонен";
list2.Add(ed68);

EIs ed69 = new EIs();
ed69.PokazatelsId = 68;
ed69.EI = "Склонен";
list2.Add(ed69);

EIs ed70 = new EIs();
ed70.PokazatelsId = 68;
ed70.EI = "Не склонен";
list2.Add(ed70);

EIs ed71 = new EIs();
ed71.PokazatelsId = 69;
ed71.EI = "Склонен";
list2.Add(ed71);

EIs ed72 = new EIs();
ed72.PokazatelsId = 69;
ed72.EI = "Не склонен";
list2.Add(ed72);

EIs ed73 = new EIs();
ed73.PokazatelsId = 70;
ed73.EI = "Склонен";
list2.Add(ed73);

EIs ed74 = new EIs();
ed74.PokazatelsId = 70;
ed74.EI = "Не склонен";
list2.Add(ed74);

EIs ed75 = new EIs();
ed75.PokazatelsId = 71;
ed75.EI = "Склонен";
list2.Add(ed75);

EIs ed76 = new EIs();
ed76.PokazatelsId = 71;
ed76.EI = "Не склонен";
list2.Add(ed76);

EIs ed77 = new EIs();
ed77.PokazatelsId = 72;
ed77.EI = "Склонен";
list2.Add(ed77);

EIs ed78 = new EIs();
ed78.PokazatelsId = 72;
ed78.EI = "Не склонен";
list2.Add(ed78);

EIs ed79 = new EIs();
ed79.PokazatelsId = 73;
ed79.EI = "Склонен";
list2.Add(ed79);

EIs ed80 = new EIs();
ed80.PokazatelsId = 73;
ed80.EI = "Не склонен";
list2.Add(ed80);

EIs ed81 = new EIs();
ed81.PokazatelsId = 74;
ed81.EI = "Склонен";
list2.Add(ed81);

EIs ed82 = new EIs();
ed82.PokazatelsId = 74;
ed82.EI = "Не склонен";
list2.Add(ed82);

EIs ed83 = new EIs();
ed83.PokazatelsId = 75;
ed83.EI = "Склонен";
list2.Add(ed83);

EIs ed84 = new EIs();
ed84.PokazatelsId = 75;
ed84.EI = "Не склонен";
list2.Add(ed84);

EIs ed85 = new EIs();
ed85.PokazatelsId = 76;
ed85.EI = "Склонен";
list2.Add(ed85);

EIs ed86 = new EIs();
ed86.PokazatelsId = 76;
ed86.EI = "Не склонен";
list2.Add(ed86);



var list = list2;
for (int i = 0; i < list.Count; i++)
{
    if (list[i].EI == "кгс/мм2")
        list[i].MainEI = "кгс/мм2";
    if (list[i].EI == "Отсутствие")
        list[i].MainEI = "Отсутствие";
    if (list[i].EI == "Не склонен")
        list[i].MainEI = "Не склонен";
}
list[78].MainEI = "%";
foreach (var item in list)
    db.EIs.Add(item);*/


/*List<TypeOfTests> types = new List<TypeOfTests>();

TypeOfTests tests1 = new TypeOfTests();
tests1.TypeOfTest = "Бортование";
types.Add(tests1);

TypeOfTests tests2 = new TypeOfTests();
tests2.TypeOfTest = "Величина аустенитного зерна";
types.Add(tests2);

TypeOfTests tests3 = new TypeOfTests();
tests3.TypeOfTest = "Величина зерна";
types.Add(tests3);

TypeOfTests tests4 = new TypeOfTests();
tests4.TypeOfTest = "Глубина внутренних дефектов";
types.Add(tests4);

TypeOfTests tests5 = new TypeOfTests();
tests5.TypeOfTest = "Загиб";
types.Add(tests5);

TypeOfTests tests6 = new TypeOfTests();
tests6.TypeOfTest = "Загрязн. немет. включениями";
types.Add(tests6);

TypeOfTests tests7 = new TypeOfTests();
tests7.TypeOfTest = "Испытания ТМЦ";
types.Add(tests7);

TypeOfTests tests8 = new TypeOfTests();
tests8.TypeOfTest = "Лабораторные испытания (дополн.)";
types.Add(tests8);

TypeOfTests tests9 = new TypeOfTests();
tests9.TypeOfTest = "МКК (А)";
types.Add(tests9);

TypeOfTests tests10 = new TypeOfTests();
tests10.TypeOfTest = "МКК (АМ)";
types.Add(tests10);

TypeOfTests tests11 = new TypeOfTests();
tests11.TypeOfTest = "МКК (АМУ)";
types.Add(tests11);

TypeOfTests tests12 = new TypeOfTests();
tests12.TypeOfTest = "МКК (Е)";
types.Add(tests12);

TypeOfTests tests13 = new TypeOfTests();
tests13.TypeOfTest = "Механические свойства";
types.Add(tests13);

TypeOfTests tests14 = new TypeOfTests();
tests14.TypeOfTest = "Микроструктура";
types.Add(tests14);

TypeOfTests tests15 = new TypeOfTests();
tests15.TypeOfTest = "Неметаллические включения";
types.Add(tests15);

TypeOfTests tests16 = new TypeOfTests();
tests16.TypeOfTest = "Обезуглероженный слой";
types.Add(tests16);

TypeOfTests tests17 = new TypeOfTests();
tests17.TypeOfTest = "Предел текучести";
types.Add(tests17);

TypeOfTests tests18 = new TypeOfTests();
tests18.TypeOfTest = "Раздача";
types.Add(tests18);

TypeOfTests tests19 = new TypeOfTests();
tests19.TypeOfTest = "Растяжение";
types.Add(tests19);

TypeOfTests tests20 = new TypeOfTests();
tests20.TypeOfTest = "Сплющивание";
types.Add(tests20);

TypeOfTests tests21 = new TypeOfTests();
tests21.TypeOfTest = "Сумма неметаллических включений";
types.Add(tests21);

TypeOfTests tests22 = new TypeOfTests();
tests22.TypeOfTest = "Твердость по Бринеллю";
types.Add(tests22);

TypeOfTests tests23 = new TypeOfTests();
tests23.TypeOfTest = "Твердость по Виккерсу";
types.Add(tests23);

TypeOfTests tests24 = new TypeOfTests();
tests24.TypeOfTest = "Твердость по Роквеллу";
types.Add(tests24);

TypeOfTests tests25 = new TypeOfTests();
tests25.TypeOfTest = "Толщина стенки";
types.Add(tests25);

TypeOfTests tests26 = new TypeOfTests();
tests26.TypeOfTest = "Ударная вязкость";
types.Add(tests26);

TypeOfTests tests27 = new TypeOfTests();
tests27.TypeOfTest = "Ферритная фаза";
types.Add(tests27);

TypeOfTests tests28 = new TypeOfTests();
tests28.TypeOfTest = "Хим.анализ_37 цех";
types.Add(tests28);

TypeOfTests tests29 = new TypeOfTests();
tests29.TypeOfTest = "Химический анализ плавки";
types.Add(tests29);

TypeOfTests tests30 = new TypeOfTests();
tests30.TypeOfTest = "Химический анализ плавки (ЛC)";
types.Add(tests30);

TypeOfTests tests31 = new TypeOfTests();
tests31.TypeOfTest = "Химический анализ плавки (Н)";
types.Add(tests31);

TypeOfTests tests32 = new TypeOfTests();
tests32.TypeOfTest = "Химический состав";
types.Add(tests32);

TypeOfTests tests33 = new TypeOfTests();
tests33.TypeOfTest = "Шероховатость поверхности";
types.Add(tests33);


foreach (var test in types)
{
    db.TypeOfTests.Add(test);
}*/

List<MoreData> listMD = new List<MoreData>();
listMD.AddRange(ПределТекучести(1));
listMD.AddRange(ВременноеCопротивление(2));
listMD.AddRange(ОтносительноеУдлинение(4));
listMD.AddRange(ОтносительноеСужение(5));
listMD.AddRange(ЧислоТвердости(6));
listMD.AddRange(ЧислоТвердости(11));
listMD.AddRange(ЧислоТвердости(12));
listMD.AddRange(ПределТекучести(13));
listMD.AddRange(ВременноеCопротивление(14));
listMD.AddRange(ОтносительноеУдлинение(15));
listMD.AddRange(ОтносительноеСужение(16));
listMD.AddRange(ПределТекучести(17));
listMD.AddRange(ВременноеCопротивление(18));
listMD.AddRange(ОтносительноеУдлинение(19));
listMD.AddRange(ОтносительноеСужение(20));
listMD.AddRange(ВременноеCопротивление(21));
listMD.AddRange(ОтносительноеСужение(22));
listMD.AddRange(ПределТекучести(24));
listMD.AddRange(ВременноеCопротивление(25));
listMD.AddRange(ОтносительноеУдлинение(26));
listMD.AddRange(ОтносительноеСужение(27));
listMD.AddRange(ОксидыТочечные(28));
listMD.AddRange(ОксидыСтрочечные(29));
listMD.AddRange(Сульфиды(33));
listMD.AddRange(НитридыИКарбонитриды(34));
listMD.AddRange(МежкристаллитнаяКоррозия(36));
listMD.AddRange(МежкристаллитнаяКоррозия(37));
listMD.AddRange(МежкристаллитнаяКоррозия(38));
listMD.AddRange(МежкристаллитнаяКоррозия(39));
listMD.AddRange(МежкристаллитнаяКоррозия(40));
listMD.AddRange(ОксидыТочечные(42));
listMD.AddRange(ОксидыСтрочечные(43));
listMD.AddRange(Сульфиды(44));
listMD.AddRange(НитридыИКарбонитриды(45));
listMD.AddRange(МежкристаллитнаяКоррозия(46));
listMD.AddRange(МежкристаллитнаяКоррозия(48));
listMD.AddRange(МежкристаллитнаяКоррозия(53));
listMD.AddRange(МежкристаллитнаяКоррозия(54));
listMD.AddRange(МежкристаллитнаяКоррозия(55));
listMD.AddRange(МежкристаллитнаяКоррозия(56));
listMD.AddRange(МежкристаллитнаяКоррозия(57));
listMD.AddRange(МежкристаллитнаяКоррозия(58));
listMD.AddRange(ПределТекучести(59));
listMD.AddRange(ВременноеCопротивление(60));
listMD.AddRange(ОтносительноеУдлинение(61));
listMD.AddRange(ОтносительноеСужение(62));
listMD.AddRange(ЧислоТвердости(63));
listMD.AddRange(ОксидыТочечные(67));
listMD.AddRange(ОксидыСтрочечные(68));
listMD.AddRange(Сульфиды(72));
listMD.AddRange(НитридыИКарбонитриды(73));
listMD.AddRange(МежкристаллитнаяКоррозия(75));

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

db.SaveChanges();