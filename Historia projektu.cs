
12:16 2019-04-06 dom wersja 3
Wyœwietla bazê w DataGridView

14:53 2019-04-06 dom wersja 4
Próbujê zrobiæ dodawanie rêczne to DataGridView, aby status by³ wyœwietlany jako unsold i sold zamiast 0 i 1

18:12 2019-04-06 dom wersja 5
Wyswietla unsold i sold

20:51 2019-04-22 dom wersja 6
Robiê interfeace dla klas operuj¹cych na bazie danych.

21:46 2019-04-24 dom wersja 7 
³¹czê siê z baz¹ rfid.

17:23 2019-04-27 dom wersja 8
doda³em odwo³ania do IdReader

20:43 2019-04-28 dom wersja 9
Odczytuje zawartoœæ bazy

17:15 2019-05-01 dom wersja 10
Usuwa rekord z bazy i tabeli na ekranie.

13:22 2019-05-04 dom wersja 11
Zainstalowalem logger net4log. Dodaje do bazy nowy rekord.
baza sql zwraca jako null dan¹ ustawion¹ jako null i powstaje wyj¹tek.
Ustawienie default jako pusty string nie pomaga,

13:49 2019-05-05 dom wersja 12
Dodaje rekord ( narazie zamiast Kolor, Nazwa i Rozmiar dodaje a,b,c)
i czyœci bazê.

19:04 2019-05-05 dom wersja 13
Wszystkie funkcje na bazie dzia³aj¹. Wymagaj¹ jeszcze dopracowania.



19:17 2019-05-07
Zmiana ustawieñ tabelii rfid tak, aby ostatnie trzy kolumny mia³y wartoœæ domyœln¹ pusty string ( jest to podwójny apostrof bez spacjii '').

08:59 2019-05-12 dom wersja 14
W funkcjach SQL nazwê tabeli podaje siê jako parametr wywo³ania.

16:22 2019-05-12 wersja 15 dom
Funkcje operuj¹ce na bazie danych dzia³aj¹ na connection pool.

19:11 09.06.2019 wersja 16 dom
Pierwsze wejœcie w klasê LabelsEPC

12:01 16.06.2019 wersja 17 dom
Usuno³em statyczne sk³adniki klasy i klasê LabelsEPC zamieni³em na abstrakcyjn¹ AbstractLabelsEPC

16:00 18.06.2019 dom wersja 18
Pokazuje siê formularz z czasem do odczytania etykiety.

19:54 21.06.2019 dom wersja 19
Pokazuje siê formularz z list¹ odczytanych EPC.

11:08 23.06.2019 wersja 20 dom
Zrobi³em klasê do testowania odczytu EPC. Nazywa siê AbstractLabelcEPCTest i znajduje siê w folderze TEST.

20:36 24.06.2019 wersja 21 dom
Odczyt EPC jest wyposa¿ony w zg³aszanie wyj¹tku, gdy nie ma po³¹czenia z IdReaderem.

20:29 29.06.2019 wersja 22 dom
Próbowa³em stworzyæ wlasny event po dojœciu paska czasu do koñca. Nie uda³o siê.
Te kody sa wy³¹czone przez kompilacjê warunkow¹ przez dyrektywê DefTimeReachedEvent.
Dyrektywa DEFAbstractLabelcEPCTest s³u¿y do w³¹czenia testowego odczytu EPC.

20:29 11.07.2019 wersja 23 dom
Archiwizacja poprzedniej wersji z ró¿nymi próbami

11:46 13.07.2019 wersja 24 dom
Stworzylem klasê pochodn¹ EPCsListBox od klasy ListBox, która miala zawieraæ klasê do odczytu EPC.
Klasa EPCslistBox by³aby wykorzystywana na trzech formularzach.
Zastanawiam siê, czy nie lepiej stworzyæ klasê pochodn¹ od TForm, która bêdzie zawiera³a ListBox i dwa klawisze.Sprawdzê to w
wersji 25.

14:51 14.07.2019 wersja 25 dom
Jest kontynuacj¹ wersji 24.Nic nie uda³o mi sie rozwi¹zaæ.
Nauczy³em siê dodawaæ przyciski w run time i pisaæ dla nich event handler.
Testowy program nazywa siê TestEvent i znajduje siê w katalogu c:\Users\Eastworks\source\repos\TestEvent\.
Zastosujê to w wersji 26.

20:34 14.07.2019 wersja 26 dom
FormKopiuj jest dziedziczona z ListOfReadEpcs.

20:33 21.07.2019 wesja 27 dom
Stworzy³em now¹ klasê ClassReadEPCs, która bêdzie zawieraæ wszystkie funkcje , które s¹ uruchamiane
po klikniêciu przycisku na g³ownej formie.

19:50 26.07.2019 wersja 28 dom
Tworzê formularz do dodawania do bazy.

16:37 27.07.2019 wersja 29 dom
W formularzu dodawania do bazy wstawilem nowe kontrolki.
Kompilator zglasza problem.

19:27 30.07.2019 wersja 30 dom
Graficznie zrobiony formularz do dodawania do bazy.

20:18 01.08.2019 wersja 31 dom
Wykrywa próbê dodawania rekordów zduplikowanych.

14:34 14.08.2019 wersja 32 dom
Domyœlym kodowaniem w .NET jest utf16. Z tego powodu kody EPC o d³goœci 20bajtów nie
mieœci³y siê w polu EPC o d³ugoœci 24.
EPC odczytane w kodzie EPC trzeba konwertowaæ na UTF8.

13:14 15.08.2019 wersja 33 dom
W clasie DAOMsSql stworzy³em nowy wyjatek dla tej klasy i u¿ywam go we wszystkich metodach
dzialaj¹cych na bazie.

21:35 16.08.2019 wersja 34 dom
Kolumny tekstowe Rozmiar, Kolor i ta trzecia nie mog¹ mieæ wartoœæ null jak domyœln¹, poniewa¿
wykoleja siê funkcja wyœwietlaj¹ca zawatoœæ tabelii w oknie. Jako wartoœæ domyœln¹ trzeba ustawiæ "".
Poprawi³e ZmieñStatus.

11:31 18.08.2019 wersja 35 dom
Odkomentowa³em rozszerzon¹ wersjê funkcji AddToDataBase i bêdê to kontynowa³.

19:25 26.08.2019 wersja 36 dom
Do pobierania danych jednego rekordu zastosowa³em LisView, ale to jest bardzo skomplikowane chocia¿ ³adnie wygl¹da.
Muszê z tego zrezygnowaæ na korzyœæ etykiet i okienek edycyjnych.

11:41 01.09.2019 wersja 37 dom
Dodawanie pojedyñczego rekordu dzia³a.

20:17 04.11.2019 wersja 38 dom
doda³em serwer asynchroniczny - odpowiada na etykiety, które odbiera

13:36 05.11.2019 wersja 39 praca
symulacja czytania z anten dzia³a.
Doda³em combobox-sprzeda¿, czytanie etykiet. 
Teraz trzeba wyœwietliæ je i dodaæ do bazy.

19:32 06.11.2019 wersja 40 dom
Ma³e zmiany w porównaniu do wersji 39.

19:34 06.11.2019 wersja 41 dom
Dodajê kolejkê FIFO do czytania etykiet z anteny.

12:33 07.11.2019 wersja 42 praca
Na razie nie u¿ywam FIFO poniewa¿ okaza³o siê,¿e zamkniêcie programu nie zamyka socketu.
Tworzenie socketu muszê przenieœæ z klasy Serwer_asynchroniczny do klasy Main.

13:38 07.11.2019 wersja 43 praca
Porz¹dkowanie klasy Main i dodawanie wyj¹tków.

19:58 08.11.2019 wersja 44 dom
Kontynuacja wersji 43

21:01 10.11.2019 wersja 47 dom
Nareszcie bez problemów. Trzeba odœwie¿yæ g³own¹ tabelê etykiet po dodaniu nowych.

12:32 13.11.2019 wersja 48 praca 
Pracujê nad okienkami do wyœwietlania, m.dz. wyj¹tków.

14:34 13.11.2019 wersja 49 praca
Uzupe³niam program funkcjami do odczytu klasy i metod.
Takie informacje przydadz¹ siê do wyœwietlania b³êdów.

11:43 15.11.2019 wersja 50 praca
Ju¿ wczesniej zrobi³em klasê do wyœwietlania wyj¹tków - znajduje siê w Utils.cs.
Wyj¹tek wyœwietla siê normalnie, gdy program jest skompilowany w trybie release.

13:49 15.11.2019 wersja 51 praca
Zrobi³em blokady dostêpu w klasie FifoClass.

10:46 17.11.2019 wersja 52 dom
Wyprubujê metodê bezpoœredniego odczytu EPC z anten do okna, jak to dzia³a w programie zrobionym w Javie.

10:30 19.11.2019 wersja 53 praca
Nie bêdê robi³ narazie interfejsów, tylko zajmê siê prze³¹czaniem sprzeda¿ - przyjêcie w programie serwera.

13:53 19.11.2019 wersja 54 praca
Dodajê logery i wyj¹tki w MainForm

21:06 19.11.2019 wersja 55 dom
Interfejs z combobox w menu g³ównym jest do kitu.
Mo¿na zastosowaæ submenu z mo¿lwoœcia ustawienia checked.

17:27 20.11.2019 wersja 56 dom
Zrobi³em nowy interfejs.

12:37 21.11.2019 wersja 57 praca
Pod³¹czy³em odczyt etykiet z anten, ale nie dzia³a jeszcze dobrze od strony odczytu etkiet z Fifoclass do okna.
Mo¿e trzeba czyœciæ okna odczytu etykiet doprawid³owym zapisie do bazy.

13:13 21.11.2019 wersja 58 praca
Muszê popracowaæ dalej nad czytaniem etykiet.

15:00 21.11.2019 wersja 59 pracaftalny b³a
Czytanie etykiet z anten funkcja:  private void toolStripMenuItemAntena_Click(object sender, EventArgs e)
reaguje na submenu Antena w menu WybierzZrodlo.
Funkcjonalnoœæ zawarta w tej funkcji powinna siê znajdowaæ w klasie FormDodajDoBazy

12:48 24.11.2019 wersja 60 dom
Zapisanie ca³ej wersji 59

21:19 25.11.2019 wersja 61 dom
Usuniêcie b³êdu w serwerze: odczytana linia koñczy³a siê na ,\n\r. Funkcja split dodawa³a jeden pusty string .

15:22 26.11.2019 wersja 62 dom
W wersji 61 wystêpowa³ fatalny b³¹d niezamkniêcia po³¹czenia z baz¹ danych. Poprawiê to najpierw w funkcji czytania statusu.

18:19 26.11.2019 wersja 63 dom
Jest b³¹d w serwerze taki, ¿e gdy przetwarza odebrany ci¹g, to nowy ci¹g przerywa przetwarzanie.

10:41 27.11.2019 wersja 64 dom
Ci¹gle problem z serwerem asynchronicznym. Trafnoœæ odczytu by³a oko³o 30 odczytów.
Gdy zamiast odczytywaæ z bazy danych jako odpowiedŸ wsatawia³em "1", to iloœæ fa³szywych odczytów siê zmniejszy³a,
ale w zamian powsta³o du¿o nowych komunikatów, ¿e odpowiedŸ jest nieprawid³owa.

17:54 27.11.2019 wersja 65 dom
Serwer dzia³a dobrze.

17:59 28.11.2019 wersja 66 dom
Kontynuacja wersji 65

21:29 28.11.2019 wersja 67 dom
Uda³o mi siê konczyæ czytania przez socket listener ( on blokowa³ zamkniêcie, bo ci¹gle nas³uchywa³).
W pliku Serwer_asynchroniczny jest funkcja StopServer, która zamyka socket.

14:00 29.11.2019 wersja 68 dom
Kontynuacja wersji 68 z t¹ ró¿nic¹, ¿e w¹tek serwera asynchronicznego nie jest w¹tkiem w tle.
Konieczna jest znowu modernizacja interfejsu aby by³y dostêpne inne funkcje IdPos.

19:40 03.12.2019 wersja 69 dom
Narazie powstrzymam siê od modernizacji interfejsu. Wiêkszym problemem jest zbyt d³ugi czas odczytu statusu z bazy danyc.
Pocz¹tkowo jest w miarê OK, lecz póŸniej czasy wyd³u¿aja siê.Najd³u¿szy jest odczyt pierwszego EPC: to mo¿e byæ nawet 60ms.
Byæ mo¿e na to mog¹ mieæ wp³yw dwa czynniki:
1. Otwieranie connecection przed pêtl¹ foreach i zmkniêcie go po pêtli.
2. ? zapomnia³em.
W nastêpnej wesji powrócê do tworzenia i zamykania connection wewnêtrz pêtli.

15:11 07.12.2019 wersja 72 dom
Wersje od 70 do 71 mia³y znacznie d³u¿szy czas pomiaru.

13:41 08.12.2019 wersja 72OK dom
Doda³em dodatkowe ustawienia do socketu listener.
Monito przyœpiesza dzia³anie.
Serwer dziala nieŸle, Pierwsze test po uruchomieniue trwa d³u¿ej, póŸniej jest OK (90%)

19:45 08.12.2019 wersja 73 dom
U¿y³em innego programu serwera. 
Dzia³a te¿ nieŸle.

17:17 09.12.2019 wersja 74OK dom
Test mieœci siê w 500ms, gdy wy³¹czony jest antywirus.

15:07 10.12.2019 wersja 75OK dom
W stosunku do poprzedniej wersji na pocz¹tku w¹tka Serwer_asynchroniczny tworzê pulê po³¹czeñ.
allDane jest sygnalizowane przed wys³aniem.
Usun¹³em nieu¿ywane elementy.

22:34 10.12.2019 wersja 78OK dom
W stosunku do poprzednich wersji wprowadzi³em dwie zmiany:
1. W funkcji Send by³ kawa³ek kodu generuj¹cy same 1 .
2. Brakowa³o kasowania StringBuildera Odpowiedz.
Po uruchomieniu komputera program SystemRFID otwiera siê wolniej i pierwszy test te¿ trwa bardzo d³ugo.

13:24 11.12.2019 wersja 79 dom
robiê przeróbkê sposobu tworzenia puli po³¹czeñ.
Pulê trzeba likwidowaæ przy zamkniêciu programu

12:15 12.12.2019 wersja 80 dom
w nastêpnej wersji spróbujê utworzyæ pulê przy otwarciu programu..

21:17 12.12.2019 wersja 82OKOK dom
Chyba najlepsza, najszybsza wersja.
Kontynuacja wersji 81.

12:27 15.12.2019 wersja 83 dom
Zacz¹³em u¿ywaæ Git'a do zarz¹dzania wersjami.
Wersja IdReader_1 usuun¹³emm powi¹zanie z przyciskiem cztaj IdReader.

14:49 15.12.2019 wersja 84 dom
Pousuwalem wszystkie poprzednie menu i przyciski oprócz File i Rêczna edycja bazy.

17:39 18.12.2019 wersja 85 dom
Metoda ZapiszDoBazy bêdzie siê teraz nazywa³a ZapiszDoBazyZUrz¹dzenia i bêdzie znajdowaæ siê w oddzielnej klasie KlasaZapiszDoBazyZUrz¹dzenia

20:52 22.12.2019 wersja 87 dom
Ta wersja zawiera trzy rozga³êzienia:
 - master
 - rename_jeden_rekord  	zmieni³a odczytywanie jednego rekordu na rêczne odczytywanie jedneego rekordu
 - dodaje_klasy_IdReader	dodalem noew klasy fo folderu Klasy IdReader.
Ten ostatni dodaje do master

12:10 29.12.2019 wersja 88 dom
Wszystkie niezbêdne funkcje do obs³ugi IrReader,a s¹ w klasie SimpleReader.
Od wersji 88 zaczynam prace nad zastosowaniem tych funkcji.

17:41 31.12.2019 wersja 89 dom
Przegl¹dam klasy - usuno³em klasê EPCListBox

18:14 02.01.2020 wersja 90 dom
Zrobi³em menu sprzedaj i zwóæ.
Trzeba je przetestowaæ oraz rozwi¹zaæ ma³y problem z czytaniem statusu z ³e³em

15:31 03.01.2020 wersja 91 dom
Sprzedawanie i zwracanie produktów dzia³a dobrze.
Usun¹³em branch menu_zmienione i zosta³ tylko master.

13:00 04.01.2020 wersja 92 dom
Konstrktor klasy KlasaIdReader poszerzy³em o dwa wejœcia: float czas po³¹czenia i bool zamknij po³¹czenie.
Jest to przygotowanie do niszczenia tagu, które odbywa siê w dwóch kroków.

22:59 05.01.2020 wesja 93 dom
Uda³o siê prawie zakoñczyæ niszczenie tagu. Przy tej okazji musia³em opracowaæ okienko do pobierania tekstu.
Linijki kodu niszczenia tagu trzeba uj¹æ miêdzy try catch.

17:56 07.01.2020 wersja 94 dom
Ca³kowicie zakoñczy³em klasê zniszcz tag

20:43 07.01.2020 wersja 95 dom
Oprogramowa³em funkcjê aktywacji/dezaktywacji tagów.

12:33 26.01.2020 wersja 96 dom
W miêdzyczasie skupi³em siê na kodowaniu i rozkodowaniu EPC. 
Aby uzyskaæ prawid³owe prefix producent i kod produktu trzeba je uzyskaæ z BarcodeSGTIN

13:34 07.02.2020 wersja 97 dom
Kontynuacja wersji 96

17:10 07.02.2020 wersja 98
Do³¹czylem i skompilowa³em Decode_Encode_EPC

14:34 11.02.2020 wersja 99 dom
Uzupe³ni³em kilka klas. W nastêpnej werji zrobiê kodowanie EPC i zapis do bazy.

16:36 12.02.2020 wersja 1.0.7346.37442 dom
Zmiana formy do wyœwietlania wersji, dziêki czemu mogê wersjê do nazwy projektu.

18:55 12.02.2020 Wersja: 1.0.7347.34040 dom
Pierwszy etap kodowania.

20:46 13.02.2020 wersja 1.0.7348.37323 dom
Pod³¹czy³em IdPos dla sprawdzenia po³¹czenia - po³¹czenie jest utrzymywane ca³y czas, a nie tylk0 dla jednehj funkcj0i.
Trxzeba napisa.c progtam obs³gi od nowa.
Kolejnoœæ ptrogramowanoia taga:
1. Utworzenie EPC z koodu kreskowego,
2. Sprawdzenie EPC w bazie,
3, Jeœki nie ma w bazie, to zapis EPC w bazie,
4. Sprawdzenie, czy EPC zapisa³o soiê dobrze.
5. Zapis EPC do bazy,
6. Aktywacja etykirty

16:27 16.02.2020 wersja 1.0.7351.24866 dom
Zmodernizowa³em klasy do obs³ugi IdReader. Jedna to klasa do ³¹czrenia siê z IdReaderem, druga do czytanoia etykoiet.
Doda³em te¿ striptool na dole, który ma wyœwietlaæ informacje o wersjach IdReadera, ale chyba go usunê.
Teraz przerabiam klasê ClasReadEPCs. Wersjê s¹ zapisywane w Githubie. 

21:54 17.02.2020 wersja 1.0.7352.39304 dom
Nie czyta etykirety z IdPosa.Sprawdzê sr\tae\rsz¹ wersmjê.

14:12 18.02.2020 wersja 1.0.7353.22695 dom
Dziala:
sprawdz status
sprzedaj produkt
zwróæ produkt
zniszcz tag- nie wiem czy skutecznie, ale nie ma b³êdu

18:40 19.02.2020 wersja 1.0.7354.33573 dom
Ju¿ mam koncepcjê na formularz do dodawania nowej etykoiety.

10:40 23.02.2020 wersja 1.0.7357.37709 dom
Formularz prawie zrobiony, pracujê jescze nas generatorem numrów seryjnych.

20:33 25.02.2020 wersja 1.0.7360.35857 dom
Stano³em na funkcji zapisi EPC do tagu, bo nie wiem jak wykorzystaæ klasê EPCGen2WriteObservationResponse class. 

10:38 26.02.2020 wersja 1.0.7361.19099 praca
Na razie koñczê pracê nad zapisem - muszê zaj¹æ siê pmwentaryzacj¹.

21:30 29.02.2020 wersja 1.0.7364.38522 dom
Robiê tylko kopiê poprzedniej wersji.

20:31 01.03.2020 wersja 1.0.7365.36907 dom
zrobi³em funkcje do wykonania aktywacji i dezaktywacji.

20:22 06.03.2020 wersja 1.0.7370.36613 dom
Zostawiam dezaktywacjê na boku. Trzeba poprawiæ dzialanie menu rêcznej edycji bazy i poprawiæ dzia³anie inwentaryzacjê przez antenê.

16:11 07.03.2020 wersja 1.0.7371.28734 dom
Poprzednie poprawi³em, teraz pracujê nad inwentaryzacj¹ przez IdPos

18:24 07.03.2020 wersja 1.0.7371.33057 dom
Zrobi³em trochê inwentaryzacji.

9:44 08.03.2020 wersja 1.0.7372.17538 dom
Kontynuacja inwentaryzacji.

10:32 08.03.2020 wersja 1.0.7372.18589 dom
Nie mo¿na bezpoœrednio dodawaæ etykiet do okna inwentaryzacji z obserwationReceived w 
klasie, poniewa¿ s¹ w innych w¹tkach. Muszê nad tym popracowaæ.
Ten b³¹d jest wywo³any przez debugger

14:09 09.03.2020 wersja 1.0.7373.25504 dom
Dodajê funkcjê GetStandaloneMode.

10:16 11.03.2020 wersja 1.0.7375.18268 praca
Niekiedy wystêpuje nieprzechwycony wyj¹tek zapisu do ListOfReadEPCs, gdy czytam z IdPos. Wyjaœnienie wyj¹tku jest
takie, ¿e dodanie do listy odbywa siê z innego w¹tku, ni¿ w¹tek g³owny.
Muszê logowaæ nieprzechwycone wyj¹tki.

12:57 12.03.2020 Wersja: 1.0.7376.23222 dom
Inwentaryzacja dziala , reaguje na start i stop.
le raportuje iloœæ wszystkich odczytywanych etykiet.

20:55 17.03.2020 kontynuacja poprzedniej wersji
Dodam trackbar do regulacjji mocy IdPosa. Bêdê kopiowa³ z poprzedniego nieudanego projektu.

9:42 18.03.2020 Wersja 1.0.7382.17399 dom
Trackbar mocy dziala. Trzeba poprawiæ jeszcze trochê.

18:15 26.03.2020 Wersja 1.0.7390.32866 dom
Dokona³em poprawek w klasie forma_inwentaryzacji

21:35 06.04.2020 Wersja 1.0.7401.38373 dom
Jeszcze trzeba popracowaæ nad aktywacj¹/dezajtywacj¹.
 
21:07 09.04,2020 Wersja 1.0.7404.37951 dom
Podczas aktywacji przez ca³y czas odbierane s¹ EPC znajduj¹ce siê w zasiêgu IdPosa.
U¿y³em eventu do przekaznia odczytanych EPC.

21:47 12.04.2020 Wersja 1.0.7407.39189 dom
Ju¿ w zasadzie wykrywanie, czy przyrz¹d zosta³ wy³¹czony w trybie trwa³ym dzia³a.
Pozostaje sprawdzenie,czy by³a to aktywacja czy deaktywacja.

17:28 13.04.2020 Wersja 1.0.7408.28269 dom
Odxzytuje prawid³owo aktywacjê i dezaktywacjê.

08:53 21.04.2020 Wersja 1.0.7416.15968 dom
Przyst¹pi³em do pisania funkcji odczytu z wybranego banku pamiêci i zapisu do wybranego banku pamiêci.

14:52 22.04.202 0Wersja 1.0.7417.26589 dom
W tej wersji zrobi³em odczyt wszystkich banków. W nastêpnych wersjach bêdê to testowa³.
Przed prób¹ odczytu jakiegokolwiek banku trzeba sprawdzic, czy na czytniku znajduje siê jeden tag.

15:34 24.04.2020 Wersja 1.0.7419.28018 dom
Odczytuje EPC prawidlowo, ale TID nie, poniewa¿ dane dla TID s¹ w polu Data.
Byæ mo¿e zamiast struktury trzeba zastosowaæ klasê statyczn¹.

17:29 30.04.2020 Wersja 1.0.7425.31441 dom
Zacz¹³em zapis EPC do taga.

18:30 01.05.2020 Wersja 1.0.7426.33414 dom
Chyba programowanie taga jest na dobrej drodze. Nie mozna by³o przetestowaæ programowania
na etykietach i tagach, które mam, poniewa¿ s¹ zablokowane. Na programie Nedap te¿ siê nie uda³o.

16:26 03.05.2020 Wersja 1.0.7428.29284 dom
Do wszystkich klas dopisalem wiersz odczytuj¹cy nazwê klasy.

14:42 04.05.2020 Wersja 1.0.7429.26435 dom
Do wszystkich (prawie) dopisalem wiersz odczytuj¹cy nazwê metody.

