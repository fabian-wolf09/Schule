## Anforderungen
1. Neue Klassen sollen ohne Schüler angelegt werden
2. Schüler werden  später zugeordnet und können höchstens einer Klasse angehören
3. Nicht jeder Lehrer ist Klassenvorstand


## Aufgaben
1. UML anpassen
2. Testfälle überlegen und aufschreiben
3. System adaptieren
4. Manuell Testen


:::mermaid
classDiagram
    Person <|-- Schüler
    Person <|-- Lehrer

    Schule "1" o-- "1..n" Abteilung : besteht aus
    Abteilung "1" o-- "1..n" Klasse : besteht aus
    Klasse "1" o-- "1" Lehrer : hat
    Klasse "1" o-- "1..n" Schüler : hat

    class Person
    class Schule
    class Abteilung
    class Klasse
    class Lehrer
    class Schüler
:::