
12:16 2019-04-06 dom wersja 3
Wy�wietla baz� w DataGridView

14:53 2019-04-06 dom wersja 4
Pr�buj� zrobi� dodawanie r�czne to DataGridView, aby status by� wy�wietlany jako unsold i sold zamiast 0 i 1

18:12 2019-04-06 dom wersja 5
Wyswietla unsold i sold

20:51 2019-04-22 dom wersja 6
Robi� interfeace dla klas operuj�cych na bazie danych.

21:46 2019-04-24 dom wersja 7 
��cz� si� z baz� rfid.

17:23 2019-04-27 dom wersja 8
doda�em odwo�ania do IdReader

20:43 2019-04-28 dom wersja 9
Odczytuje zawarto�� bazy

17:15 2019-05-01 dom wersja 10
Usuwa rekord z bazy i tabeli na ekranie.

13:22 2019-05-04 dom wersja 11
Zainstalowalem logger net4log. Dodaje do bazy nowy rekord.
baza sql zwraca jako null dan� ustawion� jako null i powstaje wyj�tek.
Ustawienie default jako pusty string nie pomaga,

13:49 2019-05-05 dom wersja 12
Dodaje rekord ( narazie zamiast Kolor, Nazwa i Rozmiar dodaje a,b,c)
i czy�ci baz�.

19:04 2019-05-05 dom wersja 13
Wszystkie funkcje na bazie dzia�aj�. Wymagaj� jeszcze dopracowania.



19:17 2019-05-07
Zmiana ustawie� tabelii rfid tak, aby ostatnie trzy kolumny mia�y warto�� domy�ln� pusty string ( jest to podw�jny apostrof bez spacjii '').

08:59 2019-05-12 dom wersja 14
W funkcjach SQL nazw� tabeli podaje si� jako parametr wywo�ania.

16:22 2019-05-12 wersja 15 dom
Funkcje operuj�ce na bazie danych dzia�aj� na connection pool.

19:11 09.06.2019 wersja 16 dom
Pierwsze wej�cie w klas� LabelsEPC

12:01 16.06.2019 wersja 17 dom
Usuno�em statyczne sk�adniki klasy i klas� LabelsEPC zamieni�em na abstrakcyjn� AbstractLabelsEPC

16:00 18.06.2019 dom wersja 18
Pokazuje si� formularz z czasem do odczytania etykiety.

19:54 21.06.2019 dom wersja 19
Pokazuje si� formularz z list� odczytanych EPC.

11:08 23.06.2019 wersja 20 dom
Zrobi�em klas� do testowania odczytu EPC. Nazywa si� AbstractLabelcEPCTest i znajduje si� w folderze TEST.

20:36 24.06.2019 wersja 21 dom
Odczyt EPC jest wyposa�ony w zg�aszanie wyj�tku, gdy nie ma po��czenia z IdReaderem.

20:29 29.06.2019 wersja 22 dom
Pr�bowa�em stworzy� wlasny event po doj�ciu paska czasu do ko�ca. Nie uda�o si�.
Te kody sa wy��czone przez kompilacj� warunkow� przez dyrektyw� DefTimeReachedEvent.
Dyrektywa DEFAbstractLabelcEPCTest s�u�y do w��czenia testowego odczytu EPC.

20:29 11.07.2019 wersja 23 dom
Archiwizacja poprzedniej wersji z r�nymi pr�bami

11:46 13.07.2019 wersja 24 dom
Stworzylem klas� pochodn� EPCsListBox od klasy ListBox, kt�ra miala zawiera� klas� do odczytu EPC.
Klasa EPCslistBox by�aby wykorzystywana na trzech formularzach.
Zastanawiam si�, czy nie lepiej stworzy� klas� pochodn� od TForm, kt�ra b�dzie zawiera�a ListBox i dwa klawisze.Sprawdz� to w
wersji 25.

14:51 14.07.2019 wersja 25 dom
Jest kontynuacj� wersji 24.Nic nie uda�o mi sie rozwi�za�.
Nauczy�em si� dodawa� przyciski w run time i pisa� dla nich event handler.
Testowy program nazywa si� TestEvent i znajduje si� w katalogu c:\Users\Eastworks\source\repos\TestEvent\.
Zastosuj� to w wersji 26.

20:34 14.07.2019 wersja 26 dom
FormKopiuj jest dziedziczona z ListOfReadEpcs.

20:33 21.07.2019 wesja 27 dom
Stworzy�em now� klas� ClassReadEPCs, kt�ra b�dzie zawiera� wszystkie funkcje , kt�re s� uruchamiane
po klikni�ciu przycisku na g�ownej formie.

19:50 26.07.2019 wersja 28 dom
Tworz� formularz do dodawania do bazy.

16:37 27.07.2019 wersja 29 dom
W formularzu dodawania do bazy wstawilem nowe kontrolki.
Kompilator zglasza problem.

19:27 30.07.2019 wersja 30 dom
Graficznie zrobiony formularz do dodawania do bazy.

20:18 01.08.2019 wersja 31 dom
Wykrywa pr�b� dodawania rekord�w zduplikowanych.

14:34 14.08.2019 wersja 32 dom
Domy�lym kodowaniem w .NET jest utf16. Z tego powodu kody EPC o d�go�ci 20bajt�w nie
mie�ci�y si� w polu EPC o d�ugo�ci 24.
EPC odczytane w kodzie EPC trzeba konwertowa� na UTF8.

13:14 15.08.2019 wersja 33 dom
W clasie DAOMsSql stworzy�em nowy wyjatek dla tej klasy i u�ywam go we wszystkich metodach
dzialaj�cych na bazie.

21:35 16.08.2019 wersja 34 dom
Kolumny tekstowe Rozmiar, Kolor i ta trzecia nie mog� mie� warto�� null jak domy�ln�, poniewa�
wykoleja si� funkcja wy�wietlaj�ca zawato�� tabelii w oknie. Jako warto�� domy�ln� trzeba ustawi� "".
Poprawi�e Zmie�Status.

11:31 18.08.2019 wersja 35 dom
Odkomentowa�em rozszerzon� wersj� funkcji AddToDataBase i b�d� to kontynowa�.

19:25 26.08.2019 wersja 36 dom
Do pobierania danych jednego rekordu zastosowa�em LisView, ale to jest bardzo skomplikowane chocia� �adnie wygl�da.
Musz� z tego zrezygnowa� na korzy�� etykiet i okienek edycyjnych.

11:41 01.09.2019 wersja 37 dom
Dodawanie pojedy�czego rekordu dzia�a.

20:17 04.11.2019 wersja 38 dom
doda�em serwer asynchroniczny - odpowiada na etykiety, kt�re odbiera

13:36 05.11.2019 wersja 39 praca
symulacja czytania z anten dzia�a.
Doda�em combobox-sprzeda�, czytanie etykiet. 
Teraz trzeba wy�wietli� je i doda� do bazy.

19:32 06.11.2019 wersja 40 dom
Ma�e zmiany w por�wnaniu do wersji 39.

19:34 06.11.2019 wersja 41 dom
Dodaj� kolejk� FIFO do czytania etykiet z anteny.

12:33 07.11.2019 wersja 42 praca
Na razie nie u�ywam FIFO poniewa� okaza�o si�,�e zamkni�cie programu nie zamyka socketu.
Tworzenie socketu musz� przenie�� z klasy Serwer_asynchroniczny do klasy Main.

13:38 07.11.2019 wersja 43 praca
Porz�dkowanie klasy Main i dodawanie wyj�tk�w.

19:58 08.11.2019 wersja 44 dom
Kontynuacja wersji 43

21:01 10.11.2019 wersja 47 dom
Nareszcie bez problem�w. Trzeba od�wie�y� g�own� tabel� etykiet po dodaniu nowych.

12:32 13.11.2019 wersja 48 praca 
Pracuj� nad okienkami do wy�wietlania, m.dz. wyj�tk�w.

14:34 13.11.2019 wersja 49 praca
Uzupe�niam program funkcjami do odczytu klasy i metod.
Takie informacje przydadz� si� do wy�wietlania b��d�w.

11:43 15.11.2019 wersja 50 praca
Ju� wczesniej zrobi�em klas� do wy�wietlania wyj�tk�w - znajduje si� w Utils.cs.
Wyj�tek wy�wietla si� normalnie, gdy program jest skompilowany w trybie release.

13:49 15.11.2019 wersja 51 praca
Zrobi�em blokady dost�pu w klasie FifoClass.

10:46 17.11.2019 wersja 52 dom
Wyprubuj� metod� bezpo�redniego odczytu EPC z anten do okna, jak to dzia�a w programie zrobionym w Javie.

10:30 19.11.2019 wersja 53 praca
Nie b�d� robi� narazie interfejs�w, tylko zajm� si� prze��czaniem sprzeda� - przyj�cie w programie serwera.

13:53 19.11.2019 wersja 54 praca
Dodaj� logery i wyj�tki w MainForm

21:06 19.11.2019 wersja 55 dom
Interfejs z combobox w menu g��wnym jest do kitu.
Mo�na zastosowa� submenu z mo�lwo�cia ustawienia checked.

17:27 20.11.2019 wersja 56 dom
Zrobi�em nowy interfejs.

12:37 21.11.2019 wersja 57 praca
Pod��czy�em odczyt etykiet z anten, ale nie dzia�a jeszcze dobrze od strony odczytu etkiet z Fifoclass do okna.
Mo�e trzeba czy�ci� okna odczytu etykiet doprawid�owym zapisie do bazy.

13:13 21.11.2019 wersja 58 praca
Musz� popracowa� dalej nad czytaniem etykiet.

15:00 21.11.2019 wersja 59 pracaftalny b�a
Czytanie etykiet z anten funkcja:  private void toolStripMenuItemAntena_Click(object sender, EventArgs e)
reaguje na submenu Antena w menu WybierzZrodlo.
Funkcjonalno�� zawarta w tej funkcji powinna si� znajdowa� w klasie FormDodajDoBazy

12:48 24.11.2019 wersja 60 dom
Zapisanie ca�ej wersji 59

21:19 25.11.2019 wersja 61 dom
Usuni�cie b��du w serwerze: odczytana linia ko�czy�a si� na ,\n\r. Funkcja split dodawa�a jeden pusty string .

15:22 26.11.2019 wersja 62 dom
W wersji 61 wyst�powa� fatalny b��d niezamkni�cia po��czenia z baz� danych. Poprawi� to najpierw w funkcji czytania statusu.

18:19 26.11.2019 wersja 63 dom
Jest b��d w serwerze taki, �e gdy przetwarza odebrany ci�g, to nowy ci�g przerywa przetwarzanie.

10:41 27.11.2019 wersja 64 dom
Ci�gle problem z serwerem asynchronicznym. Trafno�� odczytu by�a oko�o 30 odczyt�w.
Gdy zamiast odczytywa� z bazy danych jako odpowied� wsatawia�em "1", to ilo�� fa�szywych odczyt�w si� zmniejszy�a,
ale w zamian powsta�o du�o nowych komunikat�w, �e odpowied� jest nieprawid�owa.

17:54 27.11.2019 wersja 65 dom
Serwer dzia�a dobrze.

17:59 28.11.2019 wersja 66 dom
Kontynuacja wersji 65

21:29 28.11.2019 wersja 67 dom
Uda�o mi si� konczy� czytania przez socket listener ( on blokowa� zamkni�cie, bo ci�gle nas�uchywa�).
W pliku Serwer_asynchroniczny jest funkcja StopServer, kt�ra zamyka socket.

14:00 29.11.2019 wersja 68 dom
Kontynuacja wersji 68 z t� r�nic�, �e w�tek serwera asynchronicznego nie jest w�tkiem w tle.
Konieczna jest znowu modernizacja interfejsu aby by�y dost�pne inne funkcje IdPos.

19:40 03.12.2019 wersja 69 dom
Narazie powstrzymam si� od modernizacji interfejsu. Wi�kszym problemem jest zbyt d�ugi czas odczytu statusu z bazy danyc.
Pocz�tkowo jest w miar� OK, lecz p�niej czasy wyd�u�aja si�.Najd�u�szy jest odczyt pierwszego EPC: to mo�e by� nawet 60ms.
By� mo�e na to mog� mie� wp�yw dwa czynniki:
1. Otwieranie connecection przed p�tl� foreach i zmkni�cie go po p�tli.
2. ? zapomnia�em.
W nast�pnej wesji powr�c� do tworzenia i zamykania connection wewn�trz p�tli.

15:11 07.12.2019 wersja 72 dom
Wersje od 70 do 71 mia�y znacznie d�u�szy czas pomiaru.

13:41 08.12.2019 wersja 72OK dom
Doda�em dodatkowe ustawienia do socketu listener.
Monito przy�piesza dzia�anie.
Serwer dziala nie�le, Pierwsze test po uruchomieniue trwa d�u�ej, p�niej jest OK (90%)

19:45 08.12.2019 wersja 73 dom
U�y�em innego programu serwera. 
Dzia�a te� nie�le.

17:17 09.12.2019 wersja 74OK dom
Test mie�ci si� w 500ms, gdy wy��czony jest antywirus.

15:07 10.12.2019 wersja 75OK dom
W stosunku do poprzedniej wersji na pocz�tku w�tka Serwer_asynchroniczny tworz� pul� po��cze�.
allDane jest sygnalizowane przed wys�aniem.
Usun��em nieu�ywane elementy.

22:34 10.12.2019 wersja 78OK dom
W stosunku do poprzednich wersji wprowadzi�em dwie zmiany:
1. W funkcji Send by� kawa�ek kodu generuj�cy same 1 .
2. Brakowa�o kasowania StringBuildera Odpowiedz.
Po uruchomieniu komputera program SystemRFID otwiera si� wolniej i pierwszy test te� trwa bardzo d�ugo.

13:24 11.12.2019 wersja 79 dom
robi� przer�bk� sposobu tworzenia puli po��cze�.
Pul� trzeba likwidowa� przy zamkni�ciu programu

12:15 12.12.2019 wersja 80 dom
w nast�pnej wersji spr�buj� utworzy� pul� przy otwarciu programu..

21:17 12.12.2019 wersja 82OKOK dom
Chyba najlepsza, najszybsza wersja.
Kontynuacja wersji 81.

12:27 15.12.2019 wersja 83 dom
Zacz��em u�ywa� Git'a do zarz�dzania wersjami.
Wersja IdReader_1 usuun��emm powi�zanie z przyciskiem cztaj IdReader.

14:49 15.12.2019 wersja 84 dom
Pousuwalem wszystkie poprzednie menu i przyciski opr�cz File i R�czna edycja bazy.

17:39 18.12.2019 wersja 85 dom
Metoda ZapiszDoBazy b�dzie si� teraz nazywa�a ZapiszDoBazyZUrz�dzenia i b�dzie znajdowa� si� w oddzielnej klasie KlasaZapiszDoBazyZUrz�dzenia

20:52 22.12.2019 wersja 87 dom
Ta wersja zawiera trzy rozga��zienia:
 - master
 - rename_jeden_rekord  	zmieni�a odczytywanie jednego rekordu na r�czne odczytywanie jedneego rekordu
 - dodaje_klasy_IdReader	dodalem noew klasy fo folderu Klasy IdReader.
Ten ostatni dodaje do master

12:10 29.12.2019 wersja 88 dom
Wszystkie niezb�dne funkcje do obs�ugi IrReader,a s� w klasie SimpleReader.
Od wersji 88 zaczynam prace nad zastosowaniem tych funkcji.

17:41 31.12.2019 wersja 89 dom
Przegl�dam klasy - usuno�em klas� EPCListBox

18:14 02.01.2020 wersja 90 dom
Zrobi�em menu sprzedaj i zw��.
Trzeba je przetestowa� oraz rozwi�za� ma�y problem z czytaniem statusu z �e�em

15:31 03.01.2020 wersja 91 dom
Sprzedawanie i zwracanie produkt�w dzia�a dobrze.
Usun��em branch menu_zmienione i zosta� tylko master.

13:00 04.01.2020 wersja 92 dom
Konstrktor klasy KlasaIdReader poszerzy�em o dwa wej�cia: float czas po��czenia i bool zamknij po��czenie.
Jest to przygotowanie do niszczenia tagu, kt�re odbywa si� w dw�ch krok�w.

22:59 05.01.2020 wesja 93 dom
Uda�o si� prawie zako�czy� niszczenie tagu. Przy tej okazji musia�em opracowa� okienko do pobierania tekstu.
Linijki kodu niszczenia tagu trzeba uj�� mi�dzy try catch.

17:56 07.01.2020 wersja 94 dom
Ca�kowicie zako�czy�em klas� zniszcz tag

20:43 07.01.2020 wersja 95 dom
Oprogramowa�em funkcj� aktywacji/dezaktywacji tag�w.

12:33 26.01.2020 wersja 96 dom
W mi�dzyczasie skupi�em si� na kodowaniu i rozkodowaniu EPC. 
Aby uzyska� prawid�owe prefix producent i kod produktu trzeba je uzyska� z BarcodeSGTIN

13:34 07.02.2020 wersja 97 dom
Kontynuacja wersji 96

17:10 07.02.2020 wersja 98
Do��czylem i skompilowa�em Decode_Encode_EPC

14:34 11.02.2020 wersja 99 dom
Uzupe�ni�em kilka klas. W nast�pnej werji zrobi� kodowanie EPC i zapis do bazy.

16:36 12.02.2020 wersja 1.0.7346.37442 dom
Zmiana formy do wy�wietlania wersji, dzi�ki czemu mog� wersj� do nazwy projektu.

18:55 12.02.2020 Wersja: 1.0.7347.34040 dom
Pierwszy etap kodowania.

20:46 13.02.2020 wersja 1.0.7348.37323 dom
Pod��czy�em IdPos dla sprawdzenia po��czenia - po��czenie jest utrzymywane ca�y czas, a nie tylk0 dla jednehj funkcj0i.
Trxzeba napisa.c progtam obs�gi od nowa.
Kolejno�� ptrogramowanoia taga:
1. Utworzenie EPC z koodu kreskowego,
2. Sprawdzenie EPC w bazie,
3, Je�ki nie ma w bazie, to zapis EPC w bazie,
4. Sprawdzenie, czy EPC zapisa�o soi� dobrze.
5. Zapis EPC do bazy,
6. Aktywacja etykirty

16:27 16.02.2020 wersja 1.0.7351.24866 dom
Zmodernizowa�em klasy do obs�ugi IdReader. Jedna to klasa do ��czrenia si� z IdReaderem, druga do czytanoia etykoiet.
Doda�em te� striptool na dole, kt�ry ma wy�wietla� informacje o wersjach IdReadera, ale chyba go usun�.
Teraz przerabiam klas� ClasReadEPCs. Wersj� s� zapisywane w Githubie. 

21:54 17.02.2020 wersja 1.0.7352.39304 dom
Nie czyta etykirety z IdPosa.Sprawdz� sr\tae\rsz� wersmj�.

14:12 18.02.2020 wersja 1.0.7353.22695 dom
Dziala:
sprawdz status
sprzedaj produkt
zwr�� produkt
zniszcz tag- nie wiem czy skutecznie, ale nie ma b��du

18:40 19.02.2020 wersja 1.0.7354.33573 dom
Ju� mam koncepcj� na formularz do dodawania nowej etykoiety.

10:40 23.02.2020 wersja 1.0.7357.37709 dom
Formularz prawie zrobiony, pracuj� jescze nas generatorem numr�w seryjnych.

20:33 25.02.2020 wersja 1.0.7360.35857 dom
Stano�em na funkcji zapisi EPC do tagu, bo nie wiem jak wykorzysta� klas� EPCGen2WriteObservationResponse class. 

10:38 26.02.2020 wersja 1.0.7361.19099 praca
Na razie ko�cz� prac� nad zapisem - musz� zaj�� si� pmwentaryzacj�.

21:30 29.02.2020 wersja 1.0.7364.38522 dom
Robi� tylko kopi� poprzedniej wersji.

20:31 01.03.2020 wersja 1.0.7365.36907 dom
zrobi�em funkcje do wykonania aktywacji i dezaktywacji.

20:22 06.03.2020 wersja 1.0.7370.36613 dom
Zostawiam dezaktywacj� na boku. Trzeba poprawi� dzialanie menu r�cznej edycji bazy i poprawi� dzia�anie inwentaryzacj� przez anten�.

16:11 07.03.2020 wersja 1.0.7371.28734 dom
Poprzednie poprawi�em, teraz pracuj� nad inwentaryzacj� przez IdPos

18:24 07.03.2020 wersja 1.0.7371.33057 dom
Zrobi�em troch� inwentaryzacji.

9:44 08.03.2020 wersja 1.0.7372.17538 dom
Kontynuacja inwentaryzacji.

10:32 08.03.2020 wersja 1.0.7372.18589 dom
Nie mo�na bezpo�rednio dodawa� etykiet do okna inwentaryzacji z obserwationReceived w 
klasie, poniewa� s� w innych w�tkach. Musz� nad tym popracowa�.
Ten b��d jest wywo�any przez debugger

14:09 09.03.2020 wersja 1.0.7373.25504 dom
Dodaj� funkcj� GetStandaloneMode.

10:16 11.03.2020 wersja 1.0.7375.18268 praca
Niekiedy wyst�puje nieprzechwycony wyj�tek zapisu do ListOfReadEPCs, gdy czytam z IdPos. Wyja�nienie wyj�tku jest
takie, �e dodanie do listy odbywa si� z innego w�tku, ni� w�tek g�owny.
Musz� logowa� nieprzechwycone wyj�tki.

12:57 12.03.2020 Wersja: 1.0.7376.23222 dom
Inwentaryzacja dziala , reaguje na start i stop.
�le raportuje ilo�� wszystkich odczytywanych etykiet.

20:55 17.03.2020 kontynuacja poprzedniej wersji
Dodam trackbar do regulacjji mocy IdPosa. B�d� kopiowa� z poprzedniego nieudanego projektu.

9:42 18.03.2020 Wersja 1.0.7382.17399 dom
Trackbar mocy dziala. Trzeba poprawi� jeszcze troch�.

18:15 26.03.2020 Wersja 1.0.7390.32866 dom
Dokona�em poprawek w klasie forma_inwentaryzacji

21:35 06.04.2020 Wersja 1.0.7401.38373 dom
Jeszcze trzeba popracowa� nad aktywacj�/dezajtywacj�.
 
21:07 09.04,2020 Wersja 1.0.7404.37951 dom
Podczas aktywacji przez ca�y czas odbierane s� EPC znajduj�ce si� w zasi�gu IdPosa.
U�y�em eventu do przekaznia odczytanych EPC.

21:47 12.04.2020 Wersja 1.0.7407.39189 dom
Ju� w zasadzie wykrywanie, czy przyrz�d zosta� wy��czony w trybie trwa�ym dzia�a.
Pozostaje sprawdzenie,czy by�a to aktywacja czy deaktywacja.

17:28 13.04.2020 Wersja 1.0.7408.28269 dom
Odxzytuje prawid�owo aktywacj� i dezaktywacj�.

08:53 21.04.2020 Wersja 1.0.7416.15968 dom
Przyst�pi�em do pisania funkcji odczytu z wybranego banku pami�ci i zapisu do wybranego banku pami�ci.

14:52 22.04.202 0Wersja 1.0.7417.26589 dom
W tej wersji zrobi�em odczyt wszystkich bank�w. W nast�pnych wersjach b�d� to testowa�.
Przed pr�b� odczytu jakiegokolwiek banku trzeba sprawdzic, czy na czytniku znajduje si� jeden tag.

15:34 24.04.2020 Wersja 1.0.7419.28018 dom
Odczytuje EPC prawidlowo, ale TID nie, poniewa� dane dla TID s� w polu Data.
By� mo�e zamiast struktury trzeba zastosowa� klas� statyczn�.

17:29 30.04.2020 Wersja 1.0.7425.31441 dom
Zacz��em zapis EPC do taga.

18:30 01.05.2020 Wersja 1.0.7426.33414 dom
Chyba programowanie taga jest na dobrej drodze. Nie mozna by�o przetestowa� programowania
na etykietach i tagach, kt�re mam, poniewa� s� zablokowane. Na programie Nedap te� si� nie uda�o.

16:26 03.05.2020 Wersja 1.0.7428.29284 dom
Do wszystkich klas dopisalem wiersz odczytuj�cy nazw� klasy.

14:42 04.05.2020 Wersja 1.0.7429.26435 dom
Do wszystkich (prawie) dopisalem wiersz odczytuj�cy nazw� metody.

