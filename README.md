Projekt

Panel systemmowy szkoły.

Stworzylismy aplikację, która zarządza uczniami i nauczycielami, a także pokazuje nam jakie mamy zajęcia dostępne na uczelni.
Nasza aplikacja składa sie z zakładki strona głowna, uczniowie, nauczyciele, zajęcia i statystyka studentów. 
W zakładce uczniowie mamy baze danych uczniów z informacjami takimi jak Imie, nazwisko czy data dodania. Informacje mozna oczywiscie zmienać poprzez przycisk "Edytuj". Również jest opcja "Szczegóły", gdzie widzimy wszelkie informacje o uczniu.
Mamy również możliwość dodawania kolejnych uczniów oraz wyszukiwania ich w naszej bazie.
W zakładce nauczyciele mamy w zasadzie to samo oraz widnieje opcja sprawdz zajęcia czego nie ma w naszym projekcie, ale w przyszłości można rozbudować to. W zakładce zajęcia mamy informacje o przedmiotach i jaka liczba ECT jest za kazdy przedmiot. Można dodać nowe przedmioty i maxymalna liczba ECT możliwa do ustawienia wynosi 5.
Możemy też sprawdzić statystyki, gdzie mamy pokazaną ilość uczniów i nauczycieli jaka dołaczyła w danym dniu.



Wymagany jest zainstalowany mssql jako localdb

Migracja przykłądowej bazy danych
1. Teraz na pasku visual studio: Narzędzia -> Konsola Nuget
1. W konsoli wpisujemy add-migration
3. Podajemy nazwe migracji (obojętnie jaka)
4. Wpisujemy w konsoli update-database
