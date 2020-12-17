ZADATAK: Kreirati:
Abstraktnu klasu Artikal:
 Protected string naziv,
 Protected int cena,
 Parametarizovanim konstruktorom
 Javnom virtualnom metodom prodajnaCena: float
 Javnom override metodom ToString():string

Klasu Pice izvedenu iz klase Artikal:
 Protected float prAlkohola,
 Parametarizovanim konstruktorom
 Javnom override metodom prodajnaCena: float, cena artikla se uvećava za onoliko
procenata koliko je procenat alkohola.
 Javnom override metodom ToString():string

Klasu Hrana izvedenu iz klase Artikal:
 Protected float preostaliRokUpotrebe,
 Parametarizovanim konstruktorom
 Javnom override metodom prodajnaCena: float, cena artikla se umanjuje za 40% ako je
preostali rok upotrebe manji od 10 dana
 Javnom override metodom ToString():string
Interfejs IKupovina sa:
 Metodom ukupnaCena(): float
 Medotom dodaj(Artikal a): void

Klasu Korpa koja implementira interfejs IKupovina:
 private Artikal[] niz,
 private int brArtikala,
 parametrizovanim konstruktorom kojim se inicijalizuje niz artikala
 Javnom override metodom ToString():string sa ispisom svih artikala u korpi

U glavnom delu programa :
 kreirati nekoliko artikala
 kreirati korpu za artikle pomoću instance intefejsa IKupovina
 dodati kreirane artikle u korpu koristeći metodu dodaj(Artikal a)
 na standardnom izlazu prikazati sadržaj korpe, kao i iznos ukupne cene svih artikala koji se
nalaze u korpi
