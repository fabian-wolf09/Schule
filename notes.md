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
    Klasse "0..1" o-- "0..1" Lehrer : hat KV
    Klasse "0..1" o-- "0..n" Schüler : hat

    class Person
    class Schule
    class Abteilung
    class Klasse
    class Lehrer
    class Schüler
:::

## Testcases
1. Klasse ohne Schüler anlegen
   - Vorraussetzungen: Ein Lehrer und eine Abteilung existiert
   - Aktion: Klasse erstellen, der Abteilung hinzufügen und den Lehrer zuweisen
   - Ergenbis: Klasse wird erfolgreivch erstellt
2. Schüler nachträglich zuordnen
   - Vorraussetzungen: Eine Klasse und ein nicht zugewiesener Schüler
   - Aktion: Der Schüler wird der bestehenden Klasse hinzugefügt.
   - Ergebnis: Der Schüler ist nun in der Liste der Klasse.
3. Schüler darf höchstens einer Klasse angehören
   - Vorraussetzungen: Ein Schüler ist bereits einer Klasse zugewiesen und eine weitere Klasse existiert.
   - Aktion: Den Schüler in eine versuchen einer zweiten Klasse zuweisen.
   - Ergebnis: Es wird ein Fehler geworfen und der Schüler ist am Ende nicht in beiden Klassen eingetragen.
4. Lehrer als Nicht-KV
   - Vorraussetzungen: Eine Klasse
   - Aktion: Neuer Lehrer erstellt, aber wird keiner Klasse hinzugefügt.
   - Lehrer wird gespeichert, aber der Platz für die KV bleibt leer.